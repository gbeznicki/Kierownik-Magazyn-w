namespace Kierownik_Magazynów.EmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementForm));
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerDetailsNotes = new System.Windows.Forms.SplitContainer();
            this.listViewDetails = new System.Windows.Forms.ListView();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.buttonEditNote = new System.Windows.Forms.Button();
            this.buttonDeleteNote = new System.Windows.Forms.Button();
            this.listViewNotes = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetailsNotes)).BeginInit();
            this.splitContainerDetailsNotes.Panel1.SuspendLayout();
            this.splitContainerDetailsNotes.Panel2.SuspendLayout();
            this.splitContainerDetailsNotes.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(227, 652);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.dataGridViewEmployees);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerDetailsNotes);
            this.splitContainerMain.Size = new System.Drawing.Size(1063, 652);
            this.splitContainerMain.SplitterDistance = 227;
            this.splitContainerMain.TabIndex = 1;
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
            this.splitContainerDetailsNotes.Panel1.Controls.Add(this.listViewDetails);
            // 
            // splitContainerDetailsNotes.Panel2
            // 
            this.splitContainerDetailsNotes.Panel2.Controls.Add(this.flowLayoutPanelButtons);
            this.splitContainerDetailsNotes.Panel2.Controls.Add(this.listViewNotes);
            this.splitContainerDetailsNotes.Size = new System.Drawing.Size(832, 652);
            this.splitContainerDetailsNotes.SplitterDistance = 265;
            this.splitContainerDetailsNotes.TabIndex = 0;
            // 
            // listViewDetails
            // 
            this.listViewDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDetails.Location = new System.Drawing.Point(0, 0);
            this.listViewDetails.Name = "listViewDetails";
            this.listViewDetails.Size = new System.Drawing.Size(832, 265);
            this.listViewDetails.TabIndex = 0;
            this.listViewDetails.UseCompatibleStateImageBehavior = false;
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
            // listViewNotes
            // 
            this.listViewNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewNotes.Location = new System.Drawing.Point(0, 0);
            this.listViewNotes.Name = "listViewNotes";
            this.listViewNotes.Size = new System.Drawing.Size(832, 313);
            this.listViewNotes.TabIndex = 0;
            this.listViewNotes.UseCompatibleStateImageBehavior = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerDetailsNotes.Panel1.ResumeLayout(false);
            this.splitContainerDetailsNotes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetailsNotes)).EndInit();
            this.splitContainerDetailsNotes.ResumeLayout(false);
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerDetailsNotes;
        private System.Windows.Forms.ListView listViewDetails;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonEditNote;
        private System.Windows.Forms.Button buttonDeleteNote;
        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.ListView listViewNotes;
    }
}