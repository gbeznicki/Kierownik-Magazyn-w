using Kierownik_Magazyn�w.Database;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace EmployeeManagement
{
	public class EmployeeManagementRepository
	{
        public EmployeeManagementRepository()
        {
            this.employeeDataBase = new WarehouseManagerEntities();
        }

        private WarehouseManagerEntities employeeDataBase;

        public DbSet<Employee> GetEmployees()
		{
			return employeeDataBase.Employee;
		}

		public DbSet<EmployeeNote> GetEmployeeNotes()
		{
			return employeeDataBase.EmployeeNotes;
		}

		public DbSet<EmployeeDetails> GetEmployeeDetails()
		{
			return employeeDataBase.EmployeeDetails;
		}

		public string AddNote(string noteText, int employeeId)
		{
            EmployeeNote noteToAdd = new EmployeeNote();
            noteToAdd.EmployeeId = employeeId;
            noteToAdd.NoteText = noteText;
            noteToAdd.CreationDate = System.DateTime.Now;
            employeeDataBase.EmployeeNotes.Add(noteToAdd);
            employeeDataBase.SaveChanges();
            return "Dodano notatk�";
		}

		public string DeleteNote(int noteId)
		{
            var noteToDelete = employeeDataBase.EmployeeNotes.Where(note => note.NoteId == noteId).FirstOrDefault();
            if (noteToDelete != null)
            {
                employeeDataBase.EmployeeNotes.Remove((EmployeeNote)noteToDelete);
                employeeDataBase.SaveChanges();
                return "Usuni�to notatk�";
            }
            else
            {
                return "Wyst�pi� b��d przy usuwaniu notatki";
            }
        }

		public string EditNote(string noteText, int noteId)
		{
            var noteToEdit = employeeDataBase.EmployeeNotes.Where(note => note.NoteId == noteId);
            if(noteToEdit != null)
            {
                employeeDataBase.EmployeeNotes.Where(note => note.NoteId == noteId).First().NoteText = noteText;
                employeeDataBase.EmployeeNotes.Where(note => note.NoteId == noteId).First().ModifyDate = System.DateTime.Now;
                employeeDataBase.SaveChanges();
                return "Pomy�lnie zedytowano notatk�";
            }
            else
            {
                return "Najpierw wybierz notatk� do edycji";
            }
        }

	}

}

