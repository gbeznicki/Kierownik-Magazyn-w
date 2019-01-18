namespace Kierownik_Magazynów.AgenciesManagement
{
    partial class AgencyManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Kierownik_Magazynów.EmployeeManagement.SplashScreen2), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgencyManagementForm));
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colAgencyName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.ribbonControlAgencyManagement = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddAgency = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditAgency = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteAgency = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddRange = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditRange = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteRange = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageAgencies = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupAgencies = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageRanges = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupRanges = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlAgencies = new DevExpress.XtraGrid.GridControl();
            this.tileViewAgencies = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colAgencyId1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colRange = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridControlRanges = new DevExpress.XtraGrid.GridControl();
            this.gridViewRanges = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRangeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgencyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRangeFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRangeTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalRange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.agencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAgencyManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAgencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewAgencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // colAgencyName
            // 
            this.colAgencyName.FieldName = "AgencyName";
            this.colAgencyName.Name = "colAgencyName";
            this.colAgencyName.Visible = true;
            this.colAgencyName.VisibleIndex = 1;
            // 
            // ribbonControlAgencyManagement
            // 
            this.ribbonControlAgencyManagement.ExpandCollapseItem.Id = 0;
            this.ribbonControlAgencyManagement.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlAgencyManagement.ExpandCollapseItem,
            this.barButtonItem1,
            this.btnAddAgency,
            this.btnEditAgency,
            this.btnDeleteAgency,
            this.btnAddRange,
            this.btnEditRange,
            this.btnDeleteRange});
            this.ribbonControlAgencyManagement.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlAgencyManagement.MaxItemId = 8;
            this.ribbonControlAgencyManagement.Name = "ribbonControlAgencyManagement";
            this.ribbonControlAgencyManagement.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageAgencies,
            this.ribbonPageRanges});
            this.ribbonControlAgencyManagement.Size = new System.Drawing.Size(1069, 141);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnAddAgency
            // 
            this.btnAddAgency.Caption = "Dodaj";
            this.btnAddAgency.Id = 2;
            this.btnAddAgency.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAgency.ImageOptions.Image")));
            this.btnAddAgency.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddAgency.ImageOptions.LargeImage")));
            this.btnAddAgency.Name = "btnAddAgency";
            this.btnAddAgency.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddAgency_ItemClick);
            // 
            // btnEditAgency
            // 
            this.btnEditAgency.Caption = "Edytuj";
            this.btnEditAgency.Id = 3;
            this.btnEditAgency.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAgency.ImageOptions.Image")));
            this.btnEditAgency.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditAgency.ImageOptions.LargeImage")));
            this.btnEditAgency.Name = "btnEditAgency";
            this.btnEditAgency.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditAgency_ItemClick);
            // 
            // btnDeleteAgency
            // 
            this.btnDeleteAgency.Caption = "Usuń";
            this.btnDeleteAgency.Id = 4;
            this.btnDeleteAgency.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAgency.ImageOptions.Image")));
            this.btnDeleteAgency.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAgency.ImageOptions.LargeImage")));
            this.btnDeleteAgency.Name = "btnDeleteAgency";
            this.btnDeleteAgency.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteAgency_ItemClick);
            // 
            // btnAddRange
            // 
            this.btnAddRange.Caption = "Dodaj";
            this.btnAddRange.Id = 5;
            this.btnAddRange.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRange.ImageOptions.Image")));
            this.btnAddRange.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddRange.ImageOptions.LargeImage")));
            this.btnAddRange.Name = "btnAddRange";
            this.btnAddRange.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddRange_ItemClick);
            // 
            // btnEditRange
            // 
            this.btnEditRange.Caption = "Edytuj";
            this.btnEditRange.Id = 6;
            this.btnEditRange.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRange.ImageOptions.Image")));
            this.btnEditRange.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditRange.ImageOptions.LargeImage")));
            this.btnEditRange.Name = "btnEditRange";
            this.btnEditRange.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditRange_ItemClick);
            // 
            // btnDeleteRange
            // 
            this.btnDeleteRange.Caption = "Usuń";
            this.btnDeleteRange.Id = 7;
            this.btnDeleteRange.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRange.ImageOptions.Image")));
            this.btnDeleteRange.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteRange.ImageOptions.LargeImage")));
            this.btnDeleteRange.Name = "btnDeleteRange";
            this.btnDeleteRange.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteRange_ItemClick);
            // 
            // ribbonPageAgencies
            // 
            this.ribbonPageAgencies.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupAgencies});
            this.ribbonPageAgencies.Name = "ribbonPageAgencies";
            this.ribbonPageAgencies.Text = "Agencje";
            // 
            // ribbonPageGroupAgencies
            // 
            this.ribbonPageGroupAgencies.ItemLinks.Add(this.btnAddAgency);
            this.ribbonPageGroupAgencies.ItemLinks.Add(this.btnEditAgency);
            this.ribbonPageGroupAgencies.ItemLinks.Add(this.btnDeleteAgency);
            this.ribbonPageGroupAgencies.Name = "ribbonPageGroupAgencies";
            this.ribbonPageGroupAgencies.Text = "Modyfikacje";
            // 
            // ribbonPageRanges
            // 
            this.ribbonPageRanges.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupRanges});
            this.ribbonPageRanges.Name = "ribbonPageRanges";
            this.ribbonPageRanges.Text = "Zakresy";
            // 
            // ribbonPageGroupRanges
            // 
            this.ribbonPageGroupRanges.ItemLinks.Add(this.btnAddRange);
            this.ribbonPageGroupRanges.ItemLinks.Add(this.btnEditRange);
            this.ribbonPageGroupRanges.ItemLinks.Add(this.btnDeleteRange);
            this.ribbonPageGroupRanges.Name = "ribbonPageGroupRanges";
            this.ribbonPageGroupRanges.Text = "Modyfikacje";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 141);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlAgencies);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlRanges);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1069, 522);
            this.splitContainerControl1.SplitterPosition = 506;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // gridControlAgencies
            // 
            this.gridControlAgencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAgencies.Location = new System.Drawing.Point(0, 0);
            this.gridControlAgencies.MainView = this.tileViewAgencies;
            this.gridControlAgencies.MenuManager = this.ribbonControlAgencyManagement;
            this.gridControlAgencies.Name = "gridControlAgencies";
            this.gridControlAgencies.Size = new System.Drawing.Size(506, 522);
            this.gridControlAgencies.TabIndex = 0;
            this.gridControlAgencies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileViewAgencies});
            this.gridControlAgencies.MouseEnter += new System.EventHandler(this.gridControlAgencies_MouseEnter);
            // 
            // tileViewAgencies
            // 
            this.tileViewAgencies.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAgencyId1,
            this.colAgencyName,
            this.colRange});
            this.tileViewAgencies.GridControl = this.gridControlAgencies;
            this.tileViewAgencies.Name = "tileViewAgencies";
            this.tileViewAgencies.OptionsTiles.ItemSize = new System.Drawing.Size(222, 120);
            this.tileViewAgencies.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban;
            this.tileViewAgencies.OptionsTiles.RowCount = 0;
            this.tileViewAgencies.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tileViewAgencies.TileColumns.Add(tableColumnDefinition1);
            this.tileViewAgencies.TileColumns.Add(tableColumnDefinition2);
            this.tileViewAgencies.TileColumns.Add(tableColumnDefinition3);
            this.tileViewAgencies.TileRows.Add(tableRowDefinition1);
            this.tileViewAgencies.TileRows.Add(tableRowDefinition2);
            this.tileViewAgencies.TileRows.Add(tableRowDefinition3);
            tableSpan1.ColumnSpan = 3;
            tableSpan1.RowSpan = 3;
            this.tileViewAgencies.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.colAgencyName;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "colAgencyName";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Top;
            tileViewItemElement2.AnchorElementIndex = 0;
            tileViewItemElement2.AnchorOffset = new System.Drawing.Point(-25, 0);
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.RowIndex = 2;
            tileViewItemElement2.Text = "Nazwa agencji: ";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileViewAgencies.TileTemplate.Add(tileViewItemElement1);
            this.tileViewAgencies.TileTemplate.Add(tileViewItemElement2);
            // 
            // colAgencyId1
            // 
            this.colAgencyId1.FieldName = "AgencyId";
            this.colAgencyId1.Name = "colAgencyId1";
            this.colAgencyId1.Visible = true;
            this.colAgencyId1.VisibleIndex = 0;
            // 
            // colRange
            // 
            this.colRange.FieldName = "Range";
            this.colRange.Name = "colRange";
            this.colRange.Visible = true;
            this.colRange.VisibleIndex = 2;
            // 
            // gridControlRanges
            // 
            this.gridControlRanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRanges.Location = new System.Drawing.Point(0, 0);
            this.gridControlRanges.MainView = this.gridViewRanges;
            this.gridControlRanges.MenuManager = this.ribbonControlAgencyManagement;
            this.gridControlRanges.Name = "gridControlRanges";
            this.gridControlRanges.Size = new System.Drawing.Size(558, 522);
            this.gridControlRanges.TabIndex = 0;
            this.gridControlRanges.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRanges});
            this.gridControlRanges.MouseEnter += new System.EventHandler(this.gridControlRanges_MouseEnter);
            // 
            // gridViewRanges
            // 
            this.gridViewRanges.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRangeId,
            this.colWarehouseId,
            this.colAgencyId,
            this.colRangeFrom,
            this.colRangeTo,
            this.colTotalRange,
            this.colAgency,
            this.colWarehouse});
            this.gridViewRanges.GridControl = this.gridControlRanges;
            this.gridViewRanges.Name = "gridViewRanges";
            this.gridViewRanges.OptionsBehavior.Editable = false;
            // 
            // colRangeId
            // 
            this.colRangeId.FieldName = "RangeId";
            this.colRangeId.Name = "colRangeId";
            // 
            // colWarehouseId
            // 
            this.colWarehouseId.Caption = "Numer Magazynu";
            this.colWarehouseId.FieldName = "WarehouseId";
            this.colWarehouseId.Name = "colWarehouseId";
            this.colWarehouseId.Visible = true;
            this.colWarehouseId.VisibleIndex = 0;
            // 
            // colAgencyId
            // 
            this.colAgencyId.Caption = "Numer Agencji";
            this.colAgencyId.FieldName = "AgencyId";
            this.colAgencyId.Name = "colAgencyId";
            this.colAgencyId.Visible = true;
            this.colAgencyId.VisibleIndex = 1;
            // 
            // colRangeFrom
            // 
            this.colRangeFrom.Caption = "Zakres Od";
            this.colRangeFrom.FieldName = "RangeFrom";
            this.colRangeFrom.Name = "colRangeFrom";
            this.colRangeFrom.Visible = true;
            this.colRangeFrom.VisibleIndex = 2;
            // 
            // colRangeTo
            // 
            this.colRangeTo.Caption = "Zakres Do";
            this.colRangeTo.FieldName = "RangeTo";
            this.colRangeTo.Name = "colRangeTo";
            this.colRangeTo.Visible = true;
            this.colRangeTo.VisibleIndex = 3;
            // 
            // colTotalRange
            // 
            this.colTotalRange.Caption = "Całkowity Zakres";
            this.colTotalRange.FieldName = "TotalRange";
            this.colTotalRange.Name = "colTotalRange";
            this.colTotalRange.Visible = true;
            this.colTotalRange.VisibleIndex = 4;
            // 
            // colAgency
            // 
            this.colAgency.FieldName = "Agency";
            this.colAgency.Name = "colAgency";
            // 
            // colWarehouse
            // 
            this.colWarehouse.FieldName = "Warehouse";
            this.colWarehouse.Name = "colWarehouse";
            // 
            // agencyBindingSource
            // 
            this.agencyBindingSource.DataSource = typeof(Kierownik_Magazynów.Database.Agency);
            // 
            // rangeBindingSource
            // 
            this.rangeBindingSource.DataSource = typeof(Kierownik_Magazynów.Database.Range);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Dodaj";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // AgencyManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 663);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControlAgencyManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgencyManagementForm";
            this.Text = "AgencyManagementForm";
            this.Load += new System.EventHandler(this.AgencyManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAgencyManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAgencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewAgencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlAgencyManagement;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnAddAgency;
        private DevExpress.XtraBars.BarButtonItem btnEditAgency;
        private DevExpress.XtraBars.BarButtonItem btnDeleteAgency;
        private DevExpress.XtraBars.BarButtonItem btnAddRange;
        private DevExpress.XtraBars.BarButtonItem btnEditRange;
        private DevExpress.XtraBars.BarButtonItem btnDeleteRange;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageAgencies;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAgencies;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageRanges;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupRanges;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlAgencies;
        private DevExpress.XtraGrid.Views.Tile.TileView tileViewAgencies;
        private DevExpress.XtraGrid.GridControl gridControlRanges;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRanges;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource agencyBindingSource;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAgencyId1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAgencyName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colRange;
        private System.Windows.Forms.BindingSource rangeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRangeId;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseId;
        private DevExpress.XtraGrid.Columns.GridColumn colAgencyId;
        private DevExpress.XtraGrid.Columns.GridColumn colRangeFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colRangeTo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalRange;
        private DevExpress.XtraGrid.Columns.GridColumn colAgency;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
    }
}