using EmployeeManagement;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kierownik_Magazynów.EmployeeManagement
{
    public partial class EmployeeManagementForm : Form
    {
        private EmployeeManagementDataService employeeManagementDataService;
        public EmployeeManagementForm()
        {
            InitializeComponent();
            employeeManagementDataService = new EmployeeManagementDataService();
        }

        private void LoadData()
        {
            employeeManagementDataService.GetEmployees();
            gridControlEmployee.DataSource = employeeManagementDataService.Employees;
            gridControlEmployee.Refresh();
            int employeeId = employeeManagementDataService.GetEmployeeId(gridViewEmployee.GetFocusedDataSourceRowIndex());
            employeeManagementDataService.GetEmployeeDetails(employeeId);
            gridControlDetails.DataSource = employeeManagementDataService.EmployeeDetails;
            //dataGridViewEmployees.Columns["EmployeeId"].Visible = false;
            //dataGridViewEmployees.Columns["EmployeeDetails"].Visible = false;
            //dataGridViewEmployees.Columns["EmployeeNotes"].Visible = false;
            //dataGridViewEmployees.Columns["FirstName"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridViewEmployees.Columns["LastName"].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        //private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int selectedRow = dataGridViewEmployees.SelectedCells[0].RowIndex;

        //    if (selectedRow < 20)
        //    {
        //        employeeManagementDataService.GetEmployeeDetails(employeeManagementDataService.GetEmployeeId(selectedRow));
        //    }

        //    listViewDetails.Items.Clear();

        //    string hireDate = employeeManagementDataService.EmployeeDetails.Rows[0].Field<DateTime>("HireDate").ToString("dd-MM-yyyy");

        //    string dismissDate = "-";
        //    if (!String.IsNullOrEmpty(employeeManagementDataService.EmployeeDetails.Rows[0].Field<DateTime?>("DismissDate").ToString()))
        //    {
        //        dismissDate = employeeManagementDataService.EmployeeDetails.Rows[0].Field<DateTime>("DismissDate").ToString("dd-MM-yyyy");
        //    }


        //    string defaultActivity = "-";
        //    if (!String.IsNullOrEmpty(employeeManagementDataService.EmployeeDetails.Rows[0].Field<string>("DefaultActivity")))
        //    {
        //        defaultActivity = employeeManagementDataService.EmployeeDetails.Rows[0].Field<string>("DefaultActivity");
        //    }


        //    string[] details = new string[] {
        //        employeeManagementDataService.EmployeeDetails.Rows[0].Field<DateTime>("HireDate").ToString(),
        //        dismissDate,
        //        defaultActivity
        //    };


        //    ListViewItem employeeDetails = new ListViewItem(details);
        //    employeeDetails.Tag = employeeManagementDataService.EmployeeDetails;
        //    listViewDetails.Items.Add(employeeDetails);
        //    listViewDetails.Refresh();
        //}

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
