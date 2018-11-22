using System.Data;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public class EmployeeManagementDataService
    {
        public DataTable EmployeeNotes { get; set; }

        public DataTable Employees { get; set; }

        public DataTable EmployeeDetails { get; set; }

        private EmployeeManagementRepository employeeRepository;

        /// This method fills Employees DataTable
        public void GetEmployees()
        {
            try
            {
                Employees = employeeRepository.GetEmployees();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Nieudana pr�ba pobrania listy pracownik�w", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void GetEmployeeNotes(int employeeId)
        {
            try
            {
                EmployeeNotes = employeeRepository.GetEmployeeNotes();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Nieudana pr�ba pobrania listy notatek", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetEmployeeDetails(int employeeId)
        {
            try
            {
                EmployeeDetails = employeeRepository.GetEmployeeDetails();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Nieudana pr�ba pobrania listy szczeg��w pracownika", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string AddNote(string noteText, int employeeId)
        {
            string message;
            if (noteText.Length >= 1)
            {
                message = employeeRepository.AddNote(noteText, employeeId);
            }
            else
            {
                message = "Tre�� notatki nie mo�e by� pusta";
            }
            return message;
        }

        public string DeleteNote(int noteId)
        {
            string message;
            if(noteId != 0)
            {
                message = employeeRepository.DeleteNote(noteId);
            }
            else
            {
                message = "Nie wybrano notatki do usuni�cia!";
            }
            return message;
        }

        public string EditNote(string noteText, int noteId)
        {
            string message;
            if(noteText.Length >= 1 && noteId != 0)
            {
                message = employeeRepository.EditNote(noteText, noteId);
            }
            else if(!(noteText.Length >= 1))
            {
                message = "Tre�� notatki nie mo�e by� pusta.";
            }
            else
            {
                message = "Nie wybrano notatki do usuni�cia.";
            }
            return message;
        }

    }

}

