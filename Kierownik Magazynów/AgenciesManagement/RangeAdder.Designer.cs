namespace Kierownik_Magazynów.AgenciesManagement
{
    partial class RangeAdder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangeAdder));
            this.textEditFrom = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditAgencies = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditWarehouse = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditAgencies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditWarehouse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditFrom
            // 
            this.textEditFrom.Location = new System.Drawing.Point(103, 64);
            this.textEditFrom.Name = "textEditFrom";
            this.textEditFrom.Properties.Mask.EditMask = "[0-9]{1,7}";
            this.textEditFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditFrom.Size = new System.Drawing.Size(100, 20);
            this.textEditFrom.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Agencja";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Magazyn";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Zakres od";
            // 
            // textEditTo
            // 
            this.textEditTo.Location = new System.Drawing.Point(103, 90);
            this.textEditTo.Name = "textEditTo";
            this.textEditTo.Properties.Mask.EditMask = "[0-9]{1,7}";
            this.textEditTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEditTo.Size = new System.Drawing.Size(100, 20);
            this.textEditTo.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 93);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Zakres do";
            // 
            // lookUpEditAgencies
            // 
            this.lookUpEditAgencies.Location = new System.Drawing.Point(103, 8);
            this.lookUpEditAgencies.Name = "lookUpEditAgencies";
            this.lookUpEditAgencies.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpEditAgencies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditAgencies.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AgencyId", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AgencyName", "Nazwa")});
            this.lookUpEditAgencies.Properties.DataSource = typeof(Kierownik_Magazynów.Database.Agency);
            this.lookUpEditAgencies.Properties.DisplayMember = "AgencyName";
            this.lookUpEditAgencies.Properties.NullText = "wybierz agencję:";
            this.lookUpEditAgencies.Properties.ValueMember = "AgencyId";
            this.lookUpEditAgencies.Size = new System.Drawing.Size(100, 20);
            this.lookUpEditAgencies.TabIndex = 8;
            // 
            // lookUpEditWarehouse
            // 
            this.lookUpEditWarehouse.Location = new System.Drawing.Point(103, 34);
            this.lookUpEditWarehouse.Name = "lookUpEditWarehouse";
            this.lookUpEditWarehouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditWarehouse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WarehouseId", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Miejscowość", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.False)});
            this.lookUpEditWarehouse.Properties.DataSource = typeof(Kierownik_Magazynów.Database.Warehouse);
            this.lookUpEditWarehouse.Properties.DisplayMember = "Name";
            this.lookUpEditWarehouse.Properties.NullText = "wybierz magazyn";
            this.lookUpEditWarehouse.Properties.ValueMember = "WarehouseId";
            this.lookUpEditWarehouse.Size = new System.Drawing.Size(100, 20);
            this.lookUpEditWarehouse.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(13, 127);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 49);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Dodaj";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(128, 127);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 49);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Anuluj";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // RangeAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 188);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lookUpEditWarehouse);
            this.Controls.Add(this.lookUpEditAgencies);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEditTo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditFrom);
            this.Name = "RangeAdder";
            this.Text = "RangeAdder";
            ((System.ComponentModel.ISupportInitialize)(this.textEditFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditAgencies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditWarehouse.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditFrom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditTo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditAgencies;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditWarehouse;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}