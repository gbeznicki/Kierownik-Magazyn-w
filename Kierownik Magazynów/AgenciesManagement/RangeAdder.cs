using AgenciesManagement;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kierownik_Magazynów.AgenciesManagement
{
    public partial class RangeAdder : Form
    {
        private AgencyManagementDataService dataService;

        // ustawiany na true jeżeli klasa zostanie wywołana z konstruktorem do edycji
        // dzięki temu weryfikujemy czy jest dodawany czy edytowany zakres
        private Boolean editing = false;

        private int rangeId;

        public RangeAdder(DataTable agencies, DataTable warehouses, ref AgencyManagementDataService agencyManagementDataService)
        {
            InitializeComponent();

            lookUpEditAgencies.Properties.DataSource = agencies;
            lookUpEditWarehouse.Properties.DataSource = warehouses;

            this.dataService = agencyManagementDataService;
        }

        public RangeAdder(DataTable agencies, DataTable warehouses, int selectedAgencyId, int selectedWarehouseId, int rangeId, ref AgencyManagementDataService agencyManagementDataService)
        {
            InitializeComponent();

            lookUpEditAgencies.Properties.DataSource = agencies;
            lookUpEditWarehouse.Properties.DataSource = warehouses;

            lookUpEditAgencies.EditValue = selectedAgencyId;
            lookUpEditWarehouse.EditValue = selectedWarehouseId;

            this.dataService = agencyManagementDataService;

            this.simpleButtonAddEdit.Text = "Edytuj";

            this.rangeId = rangeId;

            editing = true;
        }

        private void simpleButtonAddEdit_Click(object sender, EventArgs e)
        {
            if(editing == false)
            {
                try
                {
                    dataService.AddRange((int)this.lookUpEditWarehouse.EditValue, (int)this.lookUpEditAgencies.EditValue, Int16.Parse(this.textEditFrom.Text), Int16.Parse(this.textEditTo.Text));
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Błędnie wpisane dane", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    dataService.EditRange(rangeId, Int16.Parse(this.textEditFrom.Text), Int16.Parse(this.textEditTo.Text));
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Błędnie wpisane dane", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        private void simpleButtonCalcel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
