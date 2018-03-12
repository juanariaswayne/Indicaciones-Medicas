namespace Principal.Forms.MapaCama.Paciente.Ficha.Laboratorio
{
    partial class ImpresionLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpresionLab));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dateDesde = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dateHasta = new MetroFramework.Controls.MetroDateTime();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnImprimir = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioTodos = new MetroFramework.Controls.MetroRadioButton();
            this.radioSector = new MetroFramework.Controls.MetroRadioButton();
            this.cboSector = new MetroFramework.Controls.MetroComboBox();
            this.cboTipo = new MetroFramework.Controls.MetroComboBox();
            this.radioTipo = new MetroFramework.Controls.MetroRadioButton();
            this.cboEstado = new MetroFramework.Controls.MetroComboBox();
            this.radioEstado = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioPaciente = new MetroFramework.Controls.MetroRadioButton();
            this.radioSolicitud = new MetroFramework.Controls.MetroRadioButton();
            this.radioAyuna = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.dateHasta);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.dateDesde);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(302, 349);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dateDesde
            // 
            this.dateDesde.Location = new System.Drawing.Point(4, 26);
            this.dateDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(270, 29);
            this.dateDesde.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Fecha desde";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Fecha hasta";
            // 
            // dateHasta
            // 
            this.dateHasta.Location = new System.Drawing.Point(4, 81);
            this.dateHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(270, 29);
            this.dateHasta.TabIndex = 4;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnImprimir);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 318);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(302, 31);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnImprimir
            // 
            this.btnImprimir.ActiveControl = null;
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimir.Location = new System.Drawing.Point(188, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(114, 31);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.UseSelectable = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.MouseEnter += new System.EventHandler(this.btnImprimir_MouseEnter);
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAyuna);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.radioEstado);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.radioTipo);
            this.groupBox1.Controls.Add(this.cboSector);
            this.groupBox1.Controls.Add(this.radioSector);
            this.groupBox1.Controls.Add(this.radioTodos);
            this.groupBox1.Location = new System.Drawing.Point(3, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de informe";
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Location = new System.Drawing.Point(7, 20);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(55, 15);
            this.radioTodos.TabIndex = 0;
            this.radioTodos.Text = "Todos";
            this.radioTodos.UseSelectable = true;
            this.radioTodos.CheckedChanged += new System.EventHandler(this.radioTodos_CheckedChanged);
            // 
            // radioSector
            // 
            this.radioSector.AutoSize = true;
            this.radioSector.Location = new System.Drawing.Point(7, 50);
            this.radioSector.Name = "radioSector";
            this.radioSector.Size = new System.Drawing.Size(56, 15);
            this.radioSector.TabIndex = 1;
            this.radioSector.Text = "Sector";
            this.radioSector.UseSelectable = true;
            this.radioSector.CheckedChanged += new System.EventHandler(this.radioSector_CheckedChanged);
            // 
            // cboSector
            // 
            this.cboSector.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboSector.FormattingEnabled = true;
            this.cboSector.ItemHeight = 19;
            this.cboSector.Items.AddRange(new object[] {
            "General",
            "Microbiologia"});
            this.cboSector.Location = new System.Drawing.Point(84, 44);
            this.cboSector.Name = "cboSector";
            this.cboSector.PromptText = "<Seleccione>";
            this.cboSector.Size = new System.Drawing.Size(190, 25);
            this.cboSector.TabIndex = 2;
            this.cboSector.UseSelectable = true;
            // 
            // cboTipo
            // 
            this.cboTipo.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 19;
            this.cboTipo.Items.AddRange(new object[] {
            "Rutina",
            "Urgente"});
            this.cboTipo.Location = new System.Drawing.Point(84, 75);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.PromptText = "<Seleccione>";
            this.cboTipo.Size = new System.Drawing.Size(190, 25);
            this.cboTipo.TabIndex = 4;
            this.cboTipo.UseSelectable = true;
            // 
            // radioTipo
            // 
            this.radioTipo.AutoSize = true;
            this.radioTipo.Location = new System.Drawing.Point(7, 81);
            this.radioTipo.Name = "radioTipo";
            this.radioTipo.Size = new System.Drawing.Size(47, 15);
            this.radioTipo.TabIndex = 3;
            this.radioTipo.Text = "Tipo";
            this.radioTipo.UseSelectable = true;
            this.radioTipo.CheckedChanged += new System.EventHandler(this.radioTipo_CheckedChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 19;
            this.cboEstado.Location = new System.Drawing.Point(84, 106);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(190, 25);
            this.cboEstado.TabIndex = 6;
            this.cboEstado.UseSelectable = true;
            // 
            // radioEstado
            // 
            this.radioEstado.AutoSize = true;
            this.radioEstado.Location = new System.Drawing.Point(7, 112);
            this.radioEstado.Name = "radioEstado";
            this.radioEstado.Size = new System.Drawing.Size(58, 15);
            this.radioEstado.TabIndex = 5;
            this.radioEstado.Text = "Estado";
            this.radioEstado.UseSelectable = true;
            this.radioEstado.CheckedChanged += new System.EventHandler(this.radioEstado_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSolicitud);
            this.groupBox2.Controls.Add(this.radioPaciente);
            this.groupBox2.Location = new System.Drawing.Point(3, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 61);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenamiento";
            // 
            // radioPaciente
            // 
            this.radioPaciente.AutoSize = true;
            this.radioPaciente.Location = new System.Drawing.Point(7, 20);
            this.radioPaciente.Name = "radioPaciente";
            this.radioPaciente.Size = new System.Drawing.Size(68, 15);
            this.radioPaciente.Style = MetroFramework.MetroColorStyle.Silver;
            this.radioPaciente.TabIndex = 0;
            this.radioPaciente.Text = "Paciente";
            this.radioPaciente.UseSelectable = true;
            // 
            // radioSolicitud
            // 
            this.radioSolicitud.AutoSize = true;
            this.radioSolicitud.Location = new System.Drawing.Point(7, 41);
            this.radioSolicitud.Name = "radioSolicitud";
            this.radioSolicitud.Size = new System.Drawing.Size(69, 15);
            this.radioSolicitud.Style = MetroFramework.MetroColorStyle.Silver;
            this.radioSolicitud.TabIndex = 1;
            this.radioSolicitud.Text = "Solicitud";
            this.radioSolicitud.UseSelectable = true;
            this.radioSolicitud.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // radioAyuna
            // 
            this.radioAyuna.AutoSize = true;
            this.radioAyuna.Location = new System.Drawing.Point(151, 20);
            this.radioAyuna.Name = "radioAyuna";
            this.radioAyuna.Size = new System.Drawing.Size(124, 15);
            this.radioAyuna.Style = MetroFramework.MetroColorStyle.Green;
            this.radioAyuna.TabIndex = 7;
            this.radioAyuna.Text = "Pacientes en ayuna";
            this.radioAyuna.UseSelectable = true;
            // 
            // ImpresionLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 429);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImpresionLab";
            this.Resizable = false;
            this.Text = "Imprimir pedidos laboratorio";
            this.Load += new System.EventHandler(this.ImpresionLab_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dateHasta;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dateDesde;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile btnImprimir;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cboTipo;
        private MetroFramework.Controls.MetroRadioButton radioTipo;
        private MetroFramework.Controls.MetroComboBox cboSector;
        private MetroFramework.Controls.MetroRadioButton radioSector;
        private MetroFramework.Controls.MetroRadioButton radioTodos;
        private MetroFramework.Controls.MetroComboBox cboEstado;
        private MetroFramework.Controls.MetroRadioButton radioEstado;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroRadioButton radioSolicitud;
        private MetroFramework.Controls.MetroRadioButton radioPaciente;
        private MetroFramework.Controls.MetroRadioButton radioAyuna;
    }
}