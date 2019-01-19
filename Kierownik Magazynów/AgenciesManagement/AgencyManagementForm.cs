using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciesManagement;
using DevExpress.XtraEditors;

namespace Kierownik_Magazynów.AgenciesManagement
{
    public partial class AgencyManagementForm : Form
    {
        private AgencyManagementDataService agencyManagementDataService;
        public AgencyManagementForm()
        {
            InitializeComponent();
            this.agencyManagementDataService = new AgencyManagementDataService();
        }

        private void AgencyManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
            //this.agencyManagementDataService.GetAgencies();
            //this.gridControlAgencies.DataSource = agencyManagementDataService.Agencies;

            //this.agencyManagementDataService.GetRanges();
        }

        private void LoadData()
        {
            XtraMessageBox.Show(agencyManagementDataService.GetAgencies());
            this.gridControlAgencies.DataSource = agencyManagementDataService.Agencies;
            this.gridControlAgencies.Refresh();

            XtraMessageBox.Show(agencyManagementDataService.GetRanges());
            this.gridControlRanges.DataSource = agencyManagementDataService.Ranges;
            this.gridControlRanges.Refresh();

            agencyManagementDataService.GetWarehouses();

        }

        private void ReloadAgencies()
        {
            this.gridControlAgencies.DataSource = null;
            agencyManagementDataService.GetAgencies();
            this.gridControlAgencies.DataSource = agencyManagementDataService.Agencies;
            this.gridControlAgencies.RefreshDataSource();
        }

        private void ReloadRanges()
        {
            this.gridControlRanges.DataSource = null;
            agencyManagementDataService.GetRanges();
            this.gridControlRanges.DataSource = agencyManagementDataService.Ranges;
            this.gridControlRanges.RefreshDataSource();
        }

        private void btnAddAgency_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           string agencyName = XtraInputBox.Show("Dodawanie", "Wprowadź nazwę agencji: ", "Tutaj wpisz nazwę...");
            if (!String.IsNullOrEmpty(agencyName))
            {
                XtraMessageBox.Show(agencyManagementDataService.AddAgency(agencyName));
                ReloadAgencies();
            }
        }

        private void btnAddRange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RangeAdder rangeAdder = new RangeAdder(agencyManagementDataService.Agencies, agencyManagementDataService.Warehouses, ref agencyManagementDataService);
            rangeAdder.Show();
            ReloadRanges();
        }
    }
}
