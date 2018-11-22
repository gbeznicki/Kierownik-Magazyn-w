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
                MessageBox.Show("Nieudana próba pobrania listy pracowników", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Nieudana próba pobrania listy notatek", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Nieudana próba pobrania listy szczegó³ów pracownika", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                message = "Treœæ notatki nie mo¿e byæ pusta";
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
                message = "Nie wybrano notatki do usuniêcia!";
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
                message = "Treœæ notatki nie mo¿e byæ pusta.";
            }
            else
            {
                message = "Nie wybrano notatki do usuniêcia.";
            }
            return message;
        }

    }

}

