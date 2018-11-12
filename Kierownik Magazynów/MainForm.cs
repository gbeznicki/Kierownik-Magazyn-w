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

namespace Kierownik_Magazynów
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            this.labelChooseFunction.Padding = new Padding((int)(this.Size.Width * 0.35), 0, (int)(this.Size.Width * 0.35), 0);
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            EmployeeManagement.EmployeeManagementForm employeeManagementForm = new EmployeeManagement.EmployeeManagementForm();
            employeeManagementForm.ShowDialog();
        }
    }
}
