using AgenciesManagement;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kierownik_Magazynów.AgenciesManagement
{
    public partial class RangeAdder : Form
    {
        AgencyManagementDataService dataService;

        public RangeAdder(DataTable agencies, DataTable warehouses, ref AgencyManagementDataService agencyManagementDataService)
        {
            InitializeComponent();

            lookUpEditAgencies.Properties.DataSource = agencies;
            lookUpEditWarehouse.Properties.DataSource = warehouses;

            this.dataService = agencyManagementDataService;
        }

        public RangeAdder(DataTable agencies, DataTable warehouses, int selectedAgencyId, int selectedWarehouseId, ref AgencyManagementDataService agencyManagementDataService)
        {
            InitializeComponent();

            lookUpEditAgencies.Properties.DataSource = agencies;
            lookUpEditWarehouse.Properties.DataSource = warehouses;

            lookUpEditAgencies.EditValue = selectedAgencyId;
            lookUpEditWarehouse.EditValue = selectedWarehouseId;

            this.dataService = agencyManagementDataService;

            this.simpleButtonAddEdit.Text = "Edytuj";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                dataService.AddRange((int)this.lookUpEditWarehouse.EditValue, (int)this.lookUpEditAgencies.EditValue, Int16.Parse(this.textEditFrom.Text), Int16.Parse(this.textEditTo.Text));
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Błędnie wpisane dane", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
