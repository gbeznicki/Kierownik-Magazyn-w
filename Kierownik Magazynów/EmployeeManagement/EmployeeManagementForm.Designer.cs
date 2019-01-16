﻿namespace Kierownik_Magazynów.EmployeeManagement
{
    partial class EmployeeManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementForm));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.gridControlEmployee = new DevExpress.XtraGrid.GridControl();
            this.employeeManagementDataServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerDetailsNotes = new System.Windows.Forms.SplitContainer();
            this.gridControlDetails = new DevExpress.XtraGrid.GridControl();
            this.layoutViewDetails = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.gridControlNotes = new DevExpress.XtraGrid.GridControl();
            this.tileViewNotes = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.buttonEditNote = new System.Windows.Forms.Button();
            this.buttonDeleteNote = new System.Windows.Forms.Button();
            this.layoutViewColumnHireDate = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumnDismissDate = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumnSupervisorId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumnDefaultActivity = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementDataServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetailsNotes)).BeginInit();
            this.splitContainerDetailsNotes.Panel1.SuspendLayout();
            this.splitContainerDetailsNotes.Panel2.SuspendLayout();
            this.splitContainerDetailsNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewNotes)).BeginInit();
            this.flowLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.gridControlEmployee);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerDetailsNotes);
            this.splitContainerMain.Size = new System.Drawing.Size(1063, 652);
            this.splitContainerMain.SplitterDistance = 227;
            this.splitContainerMain.TabIndex = 1;
            // 
            // gridControlEmployee
            // 
            this.gridControlEmployee.DataSource = this.employeeManagementDataServiceBindingSource;
            this.gridControlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmployee.Location = new System.Drawing.Point(0, 0);
            this.gridControlEmployee.MainView = this.gridViewEmployee;
            this.gridControlEmployee.Name = "gridControlEmployee";
            this.gridControlEmployee.Size = new System.Drawing.Size(227, 652);
            this.gridControlEmployee.TabIndex = 0;
            this.gridControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmployee});
            // 
            // gridViewEmployee
            // 
            this.gridViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colLastName});
            this.gridViewEmployee.GridControl = this.gridControlEmployee;
            this.gridViewEmployee.Name = "gridViewEmployee";
            this.gridViewEmployee.OptionsBehavior.Editable = false;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Imię";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Nazwisko";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            // 
            // splitContainerDetailsNotes
            // 
            this.splitContainerDetailsNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDetailsNotes.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDetailsNotes.Name = "splitContainerDetailsNotes";
            this.splitContainerDetailsNotes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDetailsNotes.Panel1
            // 
            this.splitContainerDetailsNotes.Panel1.Controls.Add(this.gridControlDetails);
            // 
            // splitContainerDetailsNotes.Panel2
            // 
            this.splitContainerDetailsNotes.Panel2.Controls.Add(this.gridControlNotes);
            this.splitContainerDetailsNotes.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerDetailsNotes.Panel2.Controls.Add(this.flowLayoutPanelButtons);
            this.splitContainerDetailsNotes.Size = new System.Drawing.Size(832, 652);
            this.splitContainerDetailsNotes.SplitterDistance = 265;
            this.splitContainerDetailsNotes.TabIndex = 0;
            // 
            // gridControlDetails
            // 
            this.gridControlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetails.Location = new System.Drawing.Point(0, 0);
            this.gridControlDetails.MainView = this.layoutViewDetails;
            this.gridControlDetails.Name = "gridControlDetails";
            this.gridControlDetails.Size = new System.Drawing.Size(832, 265);
            this.gridControlDetails.TabIndex = 0;
            this.gridControlDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutViewDetails});
            // 
            // layoutViewDetails
            // 
            this.layoutViewDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumnHireDate,
            this.layoutViewColumnDismissDate,
            this.layoutViewColumnSupervisorId,
            this.layoutViewColumnDefaultActivity});
            this.layoutViewDetails.GridControl = this.gridControlDetails;
            this.layoutViewDetails.Name = "layoutViewDetails";
            this.layoutViewDetails.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_layoutViewColumn2,
            this.layoutViewField_layoutViewColumn1_1,
            this.layoutViewField_layoutViewColumn1_2});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // gridControlNotes
            // 
            this.gridControlNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNotes.Location = new System.Drawing.Point(0, 0);
            this.gridControlNotes.MainView = this.tileViewNotes;
            this.gridControlNotes.Name = "gridControlNotes";
            this.gridControlNotes.Size = new System.Drawing.Size(832, 316);
            this.gridControlNotes.TabIndex = 6;
            this.gridControlNotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileViewNotes});
            // 
            // tileViewNotes
            // 
            this.tileViewNotes.GridControl = this.gridControlNotes;
            this.tileViewNotes.Name = "tileViewNotes";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(211, 134);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.buttonAddNote);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonEditNote);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonDeleteNote);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(0, 316);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(832, 67);
            this.flowLayoutPanelButtons.TabIndex = 4;
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.Location = new System.Drawing.Point(3, 3);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(270, 53);
            this.buttonAddNote.TabIndex = 1;
            this.buttonAddNote.Text = "Dodaj notatkę";
            this.buttonAddNote.UseVisualStyleBackColor = true;
            // 
            // buttonEditNote
            // 
            this.buttonEditNote.Location = new System.Drawing.Point(279, 3);
            this.buttonEditNote.Name = "buttonEditNote";
            this.buttonEditNote.Size = new System.Drawing.Size(270, 53);
            this.buttonEditNote.TabIndex = 3;
            this.buttonEditNote.Text = "Edytuj notatkę";
            this.buttonEditNote.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteNote
            // 
            this.buttonDeleteNote.Location = new System.Drawing.Point(555, 3);
            this.buttonDeleteNote.Name = "buttonDeleteNote";
            this.buttonDeleteNote.Size = new System.Drawing.Size(270, 53);
            this.buttonDeleteNote.TabIndex = 2;
            this.buttonDeleteNote.Text = "Usuń notatkę";
            this.buttonDeleteNote.UseVisualStyleBackColor = true;
            // 
            // layoutViewColumnHireDate
            // 
            this.layoutViewColumnHireDate.Caption = "Data Zatrudnienia";
            this.layoutViewColumnHireDate.FieldName = "HireDate";
            this.layoutViewColumnHireDate.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.layoutViewColumnHireDate.Name = "layoutViewColumnHireDate";
            this.layoutViewColumnHireDate.OptionsColumn.AllowEdit = false;
            this.layoutViewColumnHireDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(120, 20);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutViewColumnDismissDate
            // 
            this.layoutViewColumnDismissDate.Caption = "Data Zwolnienia";
            this.layoutViewColumnDismissDate.FieldName = "DismissDate";
            this.layoutViewColumnDismissDate.LayoutViewField = this.layoutViewField_layoutViewColumn2;
            this.layoutViewColumnDismissDate.Name = "layoutViewColumnDismissDate";
            this.layoutViewColumnDismissDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            // 
            // layoutViewField_layoutViewColumn2
            // 
            this.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn2.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2";
            this.layoutViewField_layoutViewColumn2.Size = new System.Drawing.Size(120, 20);
            this.layoutViewField_layoutViewColumn2.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutViewColumnSupervisorId
            // 
            this.layoutViewColumnSupervisorId.Caption = "Numer Przełożonego";
            this.layoutViewColumnSupervisorId.FieldName = "SupervisorId";
            this.layoutViewColumnSupervisorId.LayoutViewField = this.layoutViewField_layoutViewColumn1_1;
            this.layoutViewColumnSupervisorId.Name = "layoutViewColumnSupervisorId";
            this.layoutViewColumnSupervisorId.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // layoutViewField_layoutViewColumn1_1
            // 
            this.layoutViewField_layoutViewColumn1_1.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1_1.Location = new System.Drawing.Point(0, 40);
            this.layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1";
            this.layoutViewField_layoutViewColumn1_1.Size = new System.Drawing.Size(120, 20);
            this.layoutViewField_layoutViewColumn1_1.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutViewColumnDefaultActivity
            // 
            this.layoutViewColumnDefaultActivity.Caption = "Czynność domyślna";
            this.layoutViewColumnDefaultActivity.FieldName = "DefaultActivity";
            this.layoutViewColumnDefaultActivity.LayoutViewField = this.layoutViewField_layoutViewColumn1_2;
            this.layoutViewColumnDefaultActivity.Name = "layoutViewColumnDefaultActivity";
            this.layoutViewColumnDefaultActivity.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // layoutViewField_layoutViewColumn1_2
            // 
            this.layoutViewField_layoutViewColumn1_2.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1_2.Location = new System.Drawing.Point(0, 60);
            this.layoutViewField_layoutViewColumn1_2.Name = "layoutViewField_layoutViewColumn1_2";
            this.layoutViewField_layoutViewColumn1_2.Size = new System.Drawing.Size(120, 20);
            this.layoutViewField_layoutViewColumn1_2.TextSize = new System.Drawing.Size(103, 13);
            // 
            // EmployeeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 652);
            this.Controls.Add(this.splitContainerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeManagementForm";
            this.Text = "EmployeeManagementForm";
            this.Load += new System.EventHandler(this.EmployeeManagementForm_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeManagementDataServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            this.splitContainerDetailsNotes.Panel1.ResumeLayout(false);
            this.splitContainerDetailsNotes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetailsNotes)).EndInit();
            this.splitContainerDetailsNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewNotes)).EndInit();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerDetailsNotes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonEditNote;
        private System.Windows.Forms.Button buttonDeleteNote;
        private System.Windows.Forms.Button buttonAddNote;
        private DevExpress.XtraGrid.GridControl gridControlEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployee;
        private DevExpress.XtraGrid.GridControl gridControlDetails;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutViewDetails;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.GridControl gridControlNotes;
        private DevExpress.XtraGrid.Views.Tile.TileView tileViewNotes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource employeeManagementDataServiceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumnHireDate;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumnDismissDate;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumnSupervisorId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumnDefaultActivity;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_2;
    }
}