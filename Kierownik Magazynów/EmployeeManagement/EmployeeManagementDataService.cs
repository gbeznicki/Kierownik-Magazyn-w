using EmployeeManagement;
using System.Data;

namespace EmployeeManagement
{
	public class EmployeeManagementDataService
	{
		public DataTable EmployeeNotes;

		public DataTable Employees;

		public DataTable EmployeeDetails;

		private EmployeeManagementRepository employeeRepository;

		/// This method fills Employees DataTable
		public string GetEmployees()
		{
			return null;
		}

		public string GetEmployeeNotes(int employeeId)
		{
			return null;
		}

		public string GetEmployeeDetails(int employeeId)
		{
			return null;
		}

		public string AddNote(string noteText, int employeeId)
		{
			return null;
		}

		public string DeleteNote(int noteId)
		{
			return null;
		}

		public string EditNote(string noteText, int noteId)
		{
			return null;
		}

	}

}

