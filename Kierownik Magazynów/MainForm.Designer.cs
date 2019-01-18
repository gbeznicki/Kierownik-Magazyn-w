namespace Kierownik_Magazynów
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Kierownik_Magazynów.EmployeeManagement.SplashScreen2), true, true);
            this.labelChooseFunction = new System.Windows.Forms.Label();
            this.buttonAgencies = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChooseFunction
            // 
            this.labelChooseFunction.AutoSize = true;
            this.labelChooseFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelChooseFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChooseFunction.Location = new System.Drawing.Point(0, 0);
            this.labelChooseFunction.Margin = new System.Windows.Forms.Padding(0);
            this.labelChooseFunction.Name = "labelChooseFunction";
            this.labelChooseFunction.Size = new System.Drawing.Size(200, 31);
            this.labelChooseFunction.TabIndex = 0;
            this.labelChooseFunction.Text = "Wybierz moduł:";
            this.labelChooseFunction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAgencies
            // 
            this.buttonAgencies.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAgencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAgencies.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgencies.Image")));
            this.buttonAgencies.Location = new System.Drawing.Point(0, 31);
            this.buttonAgencies.Name = "buttonAgencies";
            this.buttonAgencies.Size = new System.Drawing.Size(388, 279);
            this.buttonAgencies.TabIndex = 1;
            this.buttonAgencies.Text = "Agencje";
            this.buttonAgencies.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAgencies.UseVisualStyleBackColor = true;
            this.buttonAgencies.Click += new System.EventHandler(this.buttonAgencies_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEmployees.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmployees.Image")));
            this.buttonEmployees.Location = new System.Drawing.Point(394, 31);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(414, 279);
            this.buttonEmployees.TabIndex = 2;
            this.buttonEmployees.Text = "Pracownicy";
            this.buttonEmployees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 310);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonAgencies);
            this.Controls.Add(this.labelChooseFunction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(824, 349);
            this.MinimumSize = new System.Drawing.Size(824, 349);
            this.Name = "MainForm";
            this.Text = "Kierownik Magazynów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseFunction;
        private System.Windows.Forms.Button buttonAgencies;
        private System.Windows.Forms.Button buttonEmployees;
    }
}

