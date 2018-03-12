namespace Principal.Forms.Facturacion
{
    partial class Factu_selectorPaciente
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
            this.btnMedicacion = new MetroFramework.Controls.MetroTile();
            this.btnProcedimientos = new MetroFramework.Controls.MetroTile();
            this.btnInternacion = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnMedicacion
            // 
            this.btnMedicacion.ActiveControl = null;
            this.btnMedicacion.Location = new System.Drawing.Point(23, 77);
            this.btnMedicacion.Name = "btnMedicacion";
            this.btnMedicacion.Size = new System.Drawing.Size(185, 39);
            this.btnMedicacion.Style = MetroFramework.MetroColorStyle.Red;
            this.btnMedicacion.TabIndex = 3;
            this.btnMedicacion.Text = "Medicacion";
            this.btnMedicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMedicacion.UseSelectable = true;
            this.btnMedicacion.Click += new System.EventHandler(this.btnMedicacion_Click);
            // 
            // btnProcedimientos
            // 
            this.btnProcedimientos.ActiveControl = null;
            this.btnProcedimientos.Location = new System.Drawing.Point(214, 77);
            this.btnProcedimientos.Name = "btnProcedimientos";
            this.btnProcedimientos.Size = new System.Drawing.Size(185, 39);
            this.btnProcedimientos.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnProcedimientos.TabIndex = 4;
            this.btnProcedimientos.Text = "Procedimientos";
            this.btnProcedimientos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProcedimientos.UseSelectable = true;
            this.btnProcedimientos.Click += new System.EventHandler(this.btnProcedimientos_Click);
            // 
            // btnInternacion
            // 
            this.btnInternacion.ActiveControl = null;
            this.btnInternacion.Location = new System.Drawing.Point(23, 134);
            this.btnInternacion.Name = "btnInternacion";
            this.btnInternacion.Size = new System.Drawing.Size(376, 39);
            this.btnInternacion.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnInternacion.TabIndex = 5;
            this.btnInternacion.Text = "Datos de internacion";
            this.btnInternacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInternacion.UseSelectable = true;
            this.btnInternacion.Click += new System.EventHandler(this.btnInternacion_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 185);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(376, 39);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "Imprimir indicacion medica";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Factu_selectorPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 239);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnInternacion);
            this.Controls.Add(this.btnProcedimientos);
            this.Controls.Add(this.btnMedicacion);
            this.MaximizeBox = false;
            this.Name = "Factu_selectorPaciente";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Nombre Paciente";
            this.Load += new System.EventHandler(this.Factu_selectorPaciente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnMedicacion;
        private MetroFramework.Controls.MetroTile btnProcedimientos;
        private MetroFramework.Controls.MetroTile btnInternacion;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}