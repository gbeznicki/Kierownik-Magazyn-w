﻿using AgenciesManagement;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kierownik_Magazynów.AgenciesManagement
{
    public partial class AgencyManagementForm : Form
    {
        private AgencyManagementDataService agencyManagementDataService;
        public AgencyManagementForm()
        {
            InitializeComponent();
            agencyManagementDataService = new AgencyManagementDataService();
        }

        private void AgencyManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //XtraMessageBox.Show(agencyManagementDataService.GetAgencies());
            agencyManagementDataService.GetAgencies();
            gridControlAgencies.DataSource = agencyManagementDataService.Agencies;
            gridControlAgencies.Refresh();

            //XtraMessageBox.Show(agencyManagementDataService.GetRanges());
            agencyManagementDataService.GetRanges();
            gridControlRanges.DataSource = agencyManagementDataService.Ranges;
            gridControlRanges.Refresh();

            agencyManagementDataService.GetWarehouses();
        }

        private void ReloadAgencies()
        {
            gridControlAgencies.DataSource = null;
            agencyManagementDataService.GetAgencies();
            gridControlAgencies.DataSource = agencyManagementDataService.Agencies;
            gridControlAgencies.RefreshDataSource();
        }

        private void ReloadRanges()
        {
            gridControlRanges.DataSource = null;
            agencyManagementDataService.GetRanges();
            gridControlRanges.DataSource = agencyManagementDataService.Ranges;
            gridControlRanges.RefreshDataSource();
        }

        #region buttonsEventHandlers
        private void btnAddRange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RangeAdder rangeAdder = new RangeAdder(agencyManagementDataService.Agencies, agencyManagementDataService.Warehouses, ref agencyManagementDataService);
            rangeAdder.ShowDialog();
            ReloadRanges();
        }

        private void btnEditRange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int selectedAgency = gridViewRanges.GetFocusedDataRow().Field<int>("AgencyId");
            int selectedWarehouse = gridViewRanges.GetFocusedDataRow().Field<int>("WarehouseId");
            int selectedRange = gridViewRanges.GetFocusedDataRow().Field<int>("RangeId");

            RangeAdder rangeAdder = new RangeAdder(agencyManagementDataService.Agencies, agencyManagementDataService.Warehouses, selectedAgency, selectedWarehouse, selectedRange, ref agencyManagementDataService);
            rangeAdder.ShowDialog();
            ReloadRanges();
        }

        private void btnDeleteRange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rangeId = gridViewRanges.GetFocusedDataRow().Field<int>("RangeId");
            if(rangeId != 0)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Czy na pewno chcesz usunąć wybrany zakres?", "Usunięcie zakresu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    XtraMessageBox.Show(agencyManagementDataService.DeleteRange(rangeId), "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadRanges();
                }
            }
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

        private void btnEditAgency_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int agencyId = tileViewAgencies.GetFocusedDataRow().Field<int>("AgencyId");
            if (agencyId != 0)
            {
                string result = XtraInputBox.Show("Podaj nową nazwę agencji:", "Edytuj agencję", "Tutaj wpisz nową nazwę...");
                if (!String.IsNullOrEmpty(result))
                {
                    XtraMessageBox.Show(agencyManagementDataService.EditAgency(agencyId, result));
                    ReloadAgencies();
                }

            }
        }

        private void btnDeleteAgency_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int agencyId = tileViewAgencies.GetFocusedDataRow().Field<int>("AgencyId");
            if (agencyId != 0)
            {
                DialogResult result = XtraMessageBox.Show("Czy na pewno chcesz usunąć wybraną agencję?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    XtraMessageBox.Show(agencyManagementDataService.DeleteAgency(agencyId));
                    ReloadAgencies();
                }
            }

        }
        #endregion

        private void gridControlAgencies_MouseEnter(object sender, EventArgs e)
        {
            this.ribbonControlAgencyManagement.SelectedPage = this.ribbonPageAgencies;

        }

        private void gridControlRanges_MouseEnter(object sender, EventArgs e)
        {
            this.ribbonControlAgencyManagement.SelectedPage = this.ribbonPageRanges;
        }
    }
}
