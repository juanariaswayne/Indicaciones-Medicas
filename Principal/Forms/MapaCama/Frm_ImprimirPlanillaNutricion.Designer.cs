namespace Principal.Forms.MapaCama
{
    partial class Frm_ImprimirPlanillaNutricion
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmboxDocumento = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmboxPiso = new MetroFramework.Controls.MetroComboBox();
            this.btnImprimir = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmboxTipoDocumento = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(42, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 110;
            this.metroLabel3.Text = "Documento";
            // 
            // cmboxDocumento
            // 
            this.cmboxDocumento.FormattingEnabled = true;
            this.cmboxDocumento.ItemHeight = 23;
            this.cmboxDocumento.Location = new System.Drawing.Point(140, 92);
            this.cmboxDocumento.Name = "cmboxDocumento";
            this.cmboxDocumento.Size = new System.Drawing.Size(221, 29);
            this.cmboxDocumento.TabIndex = 111;
            this.cmboxDocumento.UseSelectable = true;
            this.cmboxDocumento.SelectedIndexChanged += new System.EventHandler(this.cmboxDocumento_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(86, 275);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
            this.metroLabel1.TabIndex = 112;
            this.metroLabel1.Text = "Piso";
            // 
            // cmboxPiso
            // 
            this.cmboxPiso.FormattingEnabled = true;
            this.cmboxPiso.ItemHeight = 23;
            this.cmboxPiso.Location = new System.Drawing.Point(140, 275);
            this.cmboxPiso.Name = "cmboxPiso";
            this.cmboxPiso.Size = new System.Drawing.Size(221, 29);
            this.cmboxPiso.TabIndex = 113;
            this.cmboxPiso.UseSelectable = true;
            this.cmboxPiso.SelectedIndexChanged += new System.EventHandler(this.cmboxPiso_SelectedIndexChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ActiveControl = null;
            this.btnImprimir.Location = new System.Drawing.Point(140, 476);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(226, 49);
            this.btnImprimir.Style = MetroFramework.MetroColorStyle.Green;
            this.btnImprimir.TabIndex = 114;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.UseSelectable = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 185);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 115;
            this.metroLabel2.Text = "Datos a incluir";
            // 
            // cmboxTipoDocumento
            // 
            this.cmboxTipoDocumento.FormattingEnabled = true;
            this.cmboxTipoDocumento.ItemHeight = 23;
            this.cmboxTipoDocumento.Location = new System.Drawing.Point(140, 185);
            this.cmboxTipoDocumento.Name = "cmboxTipoDocumento";
            this.cmboxTipoDocumento.Size = new System.Drawing.Size(221, 29);
            this.cmboxTipoDocumento.TabIndex = 116;
            this.cmboxTipoDocumento.UseSelectable = true;
            this.cmboxTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmboxTipoDocumento_SelectedIndexChanged);
            // 
            // Frm_ImprimirPlanillaNutricion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 548);
            this.Controls.Add(this.cmboxTipoDocumento);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cmboxPiso);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmboxDocumento);
            this.Controls.Add(this.metroLabel3);
            this.Name = "Frm_ImprimirPlanillaNutricion";
            this.Text = "Planillas de nutrición";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmboxDocumento;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmboxPiso;
        private MetroFramework.Controls.MetroTile btnImprimir;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmboxTipoDocumento;
    }
}