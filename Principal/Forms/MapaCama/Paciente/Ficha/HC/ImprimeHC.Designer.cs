namespace Principal.Forms.MapaCama.Paciente.Ficha.HC
{
    partial class ImprimeHC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimeHC));
            this.panelImprimir = new System.Windows.Forms.Panel();
            this.radioEpicrisis = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.datefechaDesde = new MetroFramework.Controls.MetroDateTime();
            this.datefechaHasta = new MetroFramework.Controls.MetroDateTime();
            this.radioHC = new MetroFramework.Controls.MetroRadioButton();
            this.radioProrrogas = new MetroFramework.Controls.MetroRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.radioResumen = new MetroFramework.Controls.MetroRadioButton();
            this.panelImprimir.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImprimir
            // 
            this.panelImprimir.Controls.Add(this.radioResumen);
            this.panelImprimir.Controls.Add(this.radioEpicrisis);
            this.panelImprimir.Controls.Add(this.metroLabel3);
            this.panelImprimir.Controls.Add(this.metroLabel4);
            this.panelImprimir.Controls.Add(this.datefechaDesde);
            this.panelImprimir.Controls.Add(this.datefechaHasta);
            this.panelImprimir.Controls.Add(this.radioHC);
            this.panelImprimir.Controls.Add(this.radioProrrogas);
            this.panelImprimir.Controls.Add(this.panel2);
            this.panelImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImprimir.Location = new System.Drawing.Point(20, 60);
            this.panelImprimir.Name = "panelImprimir";
            this.panelImprimir.Size = new System.Drawing.Size(275, 244);
            this.panelImprimir.TabIndex = 0;
            // 
            // radioEpicrisis
            // 
            this.radioEpicrisis.AutoSize = true;
            this.radioEpicrisis.Location = new System.Drawing.Point(21, 164);
            this.radioEpicrisis.Name = "radioEpicrisis";
            this.radioEpicrisis.Size = new System.Drawing.Size(65, 15);
            this.radioEpicrisis.TabIndex = 11;
            this.radioEpicrisis.Text = "Epicrisis";
            this.radioEpicrisis.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Fecha hasta";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 86);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Fecha desde";
            // 
            // datefechaDesde
            // 
            this.datefechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefechaDesde.Location = new System.Drawing.Point(122, 81);
            this.datefechaDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.datefechaDesde.Name = "datefechaDesde";
            this.datefechaDesde.Size = new System.Drawing.Size(106, 29);
            this.datefechaDesde.TabIndex = 7;
            // 
            // datefechaHasta
            // 
            this.datefechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefechaHasta.Location = new System.Drawing.Point(122, 118);
            this.datefechaHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.datefechaHasta.Name = "datefechaHasta";
            this.datefechaHasta.Size = new System.Drawing.Size(106, 29);
            this.datefechaHasta.TabIndex = 6;
            // 
            // radioHC
            // 
            this.radioHC.AutoSize = true;
            this.radioHC.Location = new System.Drawing.Point(21, 13);
            this.radioHC.Name = "radioHC";
            this.radioHC.Size = new System.Drawing.Size(117, 15);
            this.radioHC.TabIndex = 5;
            this.radioHC.Text = "H.C / Evoluciones";
            this.radioHC.UseSelectable = true;
            // 
            // radioProrrogas
            // 
            this.radioProrrogas.AutoSize = true;
            this.radioProrrogas.Location = new System.Drawing.Point(21, 47);
            this.radioProrrogas.Name = "radioProrrogas";
            this.radioProrrogas.Size = new System.Drawing.Size(74, 15);
            this.radioProrrogas.TabIndex = 4;
            this.radioProrrogas.Text = "Prorrogas";
            this.radioProrrogas.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonImprimir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 36);
            this.panel2.TabIndex = 0;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonImprimir.BackgroundImage")));
            this.buttonImprimir.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonImprimir.Location = new System.Drawing.Point(179, 0);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(96, 36);
            this.buttonImprimir.TabIndex = 0;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // radioResumen
            // 
            this.radioResumen.AutoSize = true;
            this.radioResumen.Location = new System.Drawing.Point(101, 47);
            this.radioResumen.Name = "radioResumen";
            this.radioResumen.Size = new System.Drawing.Size(72, 15);
            this.radioResumen.TabIndex = 12;
            this.radioResumen.Text = "Resumen";
            this.radioResumen.UseSelectable = true;
            // 
            // ImprimeHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 324);
            this.Controls.Add(this.panelImprimir);
            this.Name = "ImprimeHC";
            this.Text = "Imprimir";
            this.Load += new System.EventHandler(this.ImprimeHC_Load);
            this.panelImprimir.ResumeLayout(false);
            this.panelImprimir.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImprimir;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroRadioButton radioProrrogas;
        private MetroFramework.Controls.MetroRadioButton radioEpicrisis;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime datefechaDesde;
        private MetroFramework.Controls.MetroDateTime datefechaHasta;
        private MetroFramework.Controls.MetroRadioButton radioHC;
        private System.Windows.Forms.Button buttonImprimir;
        private MetroFramework.Controls.MetroRadioButton radioResumen;
    }
}