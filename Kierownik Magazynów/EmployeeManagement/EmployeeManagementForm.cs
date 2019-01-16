﻿using DevExpress.XtraEditors;
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
            XtraMessageBox.Show(employeeManagementDataService.GetEmployees());
            gridControlEmployee.DataSource = employeeManagementDataService.Employees;
            gridControlEmployee.Refresh();
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridViewEmployee_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int employeeId = gridViewEmployee.GetFocusedDataRow().Field<int>("EmployeeId");
            employeeManagementDataService.GetEmployeeDetails(employeeId);
            gridControlDetails.DataSource = employeeManagementDataService.EmployeeDetails;
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            var result = XtraInputBox.Show("Dodaj notatkę", "Treść notatki:", "Tutaj wpisz treść...");
            if (!String.IsNullOrEmpty(result))
            {
                XtraMessageBox.Show("BRAWO!");
                //employeeManagementDataService.AddNote(result.ToString(), gridViewEmployee.GetFocusedDataRow())
            }
        }

        private void buttonEditNote_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteNote_Click(object sender, EventArgs e)
        {

        }
    }
}
