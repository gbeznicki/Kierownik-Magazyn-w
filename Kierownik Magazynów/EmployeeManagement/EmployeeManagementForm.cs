using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagement;

namespace Kierownik_Magazynów.EmployeeManagement
{
    public partial class EmployeeManagementForm : Form
    {
        private EmployeeManagementDataService employeeManagementDataService;
        public EmployeeManagementForm()
        {
            InitializeComponent();
            employeeManagementDataService = new EmployeeManagementDataService();
            LoadData();
        }

        private void LoadData()
        {
            employeeManagementDataService.GetEmployees();
            dataGridViewEmployees.DataSource = employeeManagementDataService.Employees;
            dataGridViewEmployees.Columns["EmployeeId"].Visible = false;
            dataGridViewEmployees.Columns["EmployeeDetails"].Visible = false;
            dataGridViewEmployees.Columns["EmployeeNotes"].Visible = false;

        }
    }
}
