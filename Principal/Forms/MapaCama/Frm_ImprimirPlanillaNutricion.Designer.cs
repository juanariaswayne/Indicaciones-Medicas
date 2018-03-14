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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmboxHorario = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 101);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(125, 19);
            this.metroLabel3.TabIndex = 110;
            this.metroLabel3.Text = "Tipo de documento";
            // 
            // cmboxDocumento
            // 
            this.cmboxDocumento.FormattingEnabled = true;
            this.cmboxDocumento.ItemHeight = 23;
            this.cmboxDocumento.Location = new System.Drawing.Point(155, 101);
            this.cmboxDocumento.Name = "cmboxDocumento";
            this.cmboxDocumento.Size = new System.Drawing.Size(221, 29);
            this.cmboxDocumento.TabIndex = 111;
            this.cmboxDocumento.UseSelectable = true;
            this.cmboxDocumento.SelectedIndexChanged += new System.EventHandler(this.cmboxDocumento_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(68, 152);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
            this.metroLabel1.TabIndex = 112;
            this.metroLabel1.Text = "Piso";
            // 
            // cmboxPiso
            // 
            this.cmboxPiso.FormattingEnabled = true;
            this.cmboxPiso.ItemHeight = 23;
            this.cmboxPiso.Location = new System.Drawing.Point(112, 152);
            this.cmboxPiso.Name = "cmboxPiso";
            this.cmboxPiso.Size = new System.Drawing.Size(221, 29);
            this.cmboxPiso.TabIndex = 113;
            this.cmboxPiso.UseSelectable = true;
            this.cmboxPiso.SelectedIndexChanged += new System.EventHandler(this.cmboxPiso_SelectedIndexChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ActiveControl = null;
            this.btnImprimir.Location = new System.Drawing.Point(136, 529);
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
            this.metroLabel2.Location = new System.Drawing.Point(39, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 115;
            this.metroLabel2.Text = "Pacientes";
            // 
            // cmboxTipoDocumento
            // 
            this.cmboxTipoDocumento.FormattingEnabled = true;
            this.cmboxTipoDocumento.ItemHeight = 23;
            this.cmboxTipoDocumento.Location = new System.Drawing.Point(112, 62);
            this.cmboxTipoDocumento.Name = "cmboxTipoDocumento";
            this.cmboxTipoDocumento.Size = new System.Drawing.Size(221, 29);
            this.cmboxTipoDocumento.TabIndex = 116;
            this.cmboxTipoDocumento.UseSelectable = true;
            this.cmboxTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmboxTipoDocumento_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(47, 244);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 117;
            this.metroLabel4.Text = "Horario";
            // 
            // cmboxHorario
            // 
            this.cmboxHorario.FormattingEnabled = true;
            this.cmboxHorario.ItemHeight = 23;
            this.cmboxHorario.Location = new System.Drawing.Point(112, 244);
            this.cmboxHorario.Name = "cmboxHorario";
            this.cmboxHorario.Size = new System.Drawing.Size(221, 29);
            this.cmboxHorario.TabIndex = 118;
            this.cmboxHorario.UseSelectable = true;
            this.cmboxHorario.SelectedIndexChanged += new System.EventHandler(this.cmboxHorario_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmboxTipoDocumento);
            this.groupBox1.Controls.Add(this.cmboxHorario);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.cmboxPiso);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 319);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información a incluir";
            // 
            // Frm_ImprimirPlanillaNutricion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cmboxDocumento);
            this.Controls.Add(this.metroLabel3);
            this.Name = "Frm_ImprimirPlanillaNutricion";
            this.Text = "Planillas de nutrición";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmboxHorario;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}