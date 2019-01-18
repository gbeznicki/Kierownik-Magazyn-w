using EmployeeManagement;
using Kierownik_Magazyn�w.Database;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace EmployeeManagement
{
	public class EmployeeManagementDataService
	{

		public DataTable EmployeeNotes { get; set; }

		public DataTable Employees { get; set; }

		public DataTable EmployeeDetails { get; set; }

		private EmployeeManagementRepository employeeRepository;

        public EmployeeManagementDataService()
        {
            this.employeeRepository = new EmployeeManagementRepository();
        }

		/// This method fills Employees DataTable
		public string GetEmployees()
		{
            string message;
            try
            {
                Employees = employeeRepository.GetEmployees().ToListAsync().Result.ToDataTable();
                message = "Pobrano list� pracownik�w";
            }
            catch
            {
                message = "Nieudana pr�ba pobrania listy pracownik�w z bazy danych";
            }
			return message;
		}

		public string GetEmployeeNotes(int employeeId)
		{
            string message;
            try
            {
                EmployeeNotes = employeeRepository.GetEmployeeNotes().ToListAsync().Result.Where(employee => employee.EmployeeId == employeeId).ToList().ToDataTable();
                message = "Pobrano list� notatek";
            }
            catch
            {
                message = "Nieudana pr�ba pobrania listy notatek z bazy danych";
            }
            return message;
        }

		public string GetEmployeeDetails(int employeeId)
		{
            string message;
            try
            {
                EmployeeDetails = employeeRepository.GetEmployeeDetails().ToListAsync().Result.Where(employee => employee.EmployeeId == employeeId).ToList().ToDataTable();
                message = "Pobrano list� szczeg��w pracownik�w";
            }
            catch
            {
                message = "Nieudana pr�ba pobrania listy szczeg��w pracownik�w z bazy danych";
            }
            return message;
        }

        //public int GetEmployeeId(int rowIndex)
        //{
        //        return this.Employees.Rows[rowIndex].Field<int>("EmployeeId");
        //}

		public string AddNote(string noteText, int employeeId)
		{
            string message;
			if(noteText.Length >= 1 && employeeId != 0)
            {
                return employeeRepository.AddNote(noteText, employeeId);
            }
            else if(noteText.Length < 1)
            {
                message = "Minimalna d�ugo�� notatki wynosi 1 znak.";
            }
            else
            {
                message = "Nie wybrano pracownika.";
            }
            return message;
		}

		public string DeleteNote(int noteId)
		{
            string message;
            if (noteId != 0)
            {
                return employeeRepository.DeleteNote(noteId);
            }
            else
            {
                message = "Nie wybrano notatki do usuni�cia.";
            }
            return message;
        }

		public string EditNote(string noteText, int noteId)
		{
            string message;
            if (noteText.Length >= 10 && noteId != 0)
            {
                return employeeRepository.EditNote(noteText, noteId);
            }
            else if (noteText.Length < 10)
            {
                message = "Minimalna d�ugo�� notatki wynosi 10 znak�w.";
            }
            else
            {
                message = "Nie wybrano notatki do edycji.";
            }
            return message;
        }

	}

}

