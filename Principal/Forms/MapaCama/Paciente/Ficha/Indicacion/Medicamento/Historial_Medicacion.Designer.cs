namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento
{
    partial class Historial_Medicacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProcedimientos = new System.Windows.Forms.DataGridView();
            this.ID_Procedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_baja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewHisMed = new System.Windows.Forms.DataGridView();
            this.SuministroMedicacion_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finaliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnImprimir = new MetroFramework.Controls.MetroButton();
            this.dateDesde = new MetroFramework.Controls.MetroDateTime();
            this.dateHasta = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHisMed)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewProcedimientos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridViewHisMed);
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 623);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewProcedimientos
            // 
            this.dataGridViewProcedimientos.AllowUserToAddRows = false;
            this.dataGridViewProcedimientos.AllowUserToDeleteRows = false;
            this.dataGridViewProcedimientos.AllowUserToOrderColumns = true;
            this.dataGridViewProcedimientos.AllowUserToResizeColumns = false;
            this.dataGridViewProcedimientos.AllowUserToResizeRows = false;
            this.dataGridViewProcedimientos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcedimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Procedimiento,
            this.F_inicio,
            this.Procedimiento,
            this.fecha_baja,
            this.medico});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProcedimientos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProcedimientos.Location = new System.Drawing.Point(0, 340);
            this.dataGridViewProcedimientos.Name = "dataGridViewProcedimientos";
            this.dataGridViewProcedimientos.ReadOnly = true;
            this.dataGridViewProcedimientos.RowHeadersVisible = false;
            this.dataGridViewProcedimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcedimientos.Size = new System.Drawing.Size(1262, 238);
            this.dataGridViewProcedimientos.TabIndex = 3;
            // 
            // ID_Procedimiento
            // 
            this.ID_Procedimiento.HeaderText = "ID_Procedimiento";
            this.ID_Procedimiento.Name = "ID_Procedimiento";
            this.ID_Procedimiento.ReadOnly = true;
            this.ID_Procedimiento.Visible = false;
            // 
            // F_inicio
            // 
            this.F_inicio.HeaderText = "F. Inicio";
            this.F_inicio.Name = "F_inicio";
            this.F_inicio.ReadOnly = true;
            // 
            // Procedimiento
            // 
            this.Procedimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Procedimiento.HeaderText = "Procedimiento";
            this.Procedimiento.Name = "Procedimiento";
            this.Procedimiento.ReadOnly = true;
            // 
            // fecha_baja
            // 
            this.fecha_baja.HeaderText = "F. Baja";
            this.fecha_baja.Name = "fecha_baja";
            this.fecha_baja.ReadOnly = true;
            // 
            // medico
            // 
            this.medico.HeaderText = "medico";
            this.medico.Name = "medico";
            this.medico.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 27);
            this.panel2.TabIndex = 2;
            // 
            // dataGridViewHisMed
            // 
            this.dataGridViewHisMed.AllowUserToAddRows = false;
            this.dataGridViewHisMed.AllowUserToDeleteRows = false;
            this.dataGridViewHisMed.AllowUserToOrderColumns = true;
            this.dataGridViewHisMed.AllowUserToResizeColumns = false;
            this.dataGridViewHisMed.AllowUserToResizeRows = false;
            this.dataGridViewHisMed.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHisMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHisMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SuministroMedicacion_id,
            this.Medicamento_id,
            this.Inicio,
            this.Medicamento,
            this.Horario,
            this.Finaliza,
            this.Obs,
            this.Medico_med});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHisMed.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHisMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewHisMed.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHisMed.MultiSelect = false;
            this.dataGridViewHisMed.Name = "dataGridViewHisMed";
            this.dataGridViewHisMed.ReadOnly = true;
            this.dataGridViewHisMed.RowHeadersVisible = false;
            this.dataGridViewHisMed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHisMed.Size = new System.Drawing.Size(1262, 313);
            this.dataGridViewHisMed.TabIndex = 0;
            // 
            // SuministroMedicacion_id
            // 
            this.SuministroMedicacion_id.HeaderText = "SuministroMedicacion_id";
            this.SuministroMedicacion_id.Name = "SuministroMedicacion_id";
            this.SuministroMedicacion_id.ReadOnly = true;
            this.SuministroMedicacion_id.Visible = false;
            // 
            // Medicamento_id
            // 
            this.Medicamento_id.HeaderText = "Medicamento_id";
            this.Medicamento_id.Name = "Medicamento_id";
            this.Medicamento_id.ReadOnly = true;
            this.Medicamento_id.Visible = false;
            // 
            // Inicio
            // 
            this.Inicio.HeaderText = "F. Inicio";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            // 
            // Medicamento
            // 
            this.Medicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medicamento.HeaderText = "Medicamento";
            this.Medicamento.Name = "Medicamento";
            this.Medicamento.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // Finaliza
            // 
            this.Finaliza.HeaderText = "F. Baja";
            this.Finaliza.Name = "Finaliza";
            this.Finaliza.ReadOnly = true;
            // 
            // Obs
            // 
            this.Obs.HeaderText = "Cambio";
            this.Obs.Name = "Obs";
            this.Obs.ReadOnly = true;
            this.Obs.Width = 250;
            // 
            // Medico_med
            // 
            this.Medico_med.HeaderText = "Medico";
            this.Medico_med.Name = "Medico_med";
            this.Medico_med.ReadOnly = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnImprimir);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 578);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1262, 45);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimir.Location = new System.Drawing.Point(1135, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(127, 45);
            this.btnImprimir.Style = MetroFramework.MetroColorStyle.Green;
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnImprimir.UseSelectable = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dateDesde
            // 
            this.dateDesde.CustomFormat = "";
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDesde.Location = new System.Drawing.Point(23, 28);
            this.dateDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(109, 29);
            this.dateDesde.TabIndex = 2;
            this.dateDesde.ValueChanged += new System.EventHandler(this.dateDesde_ValueChanged);
            // 
            // dateHasta
            // 
            this.dateHasta.CustomFormat = "";
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHasta.Location = new System.Drawing.Point(138, 28);
            this.dateHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(109, 29);
            this.dateHasta.TabIndex = 3;
            this.dateHasta.ValueChanged += new System.EventHandler(this.dateHasta_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Desde";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(138, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Hasta";
            // 
            // Historial_Medicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 703);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.panel1);
            this.Name = "Historial_Medicacion";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Historial";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Historial_Medicacion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHisMed)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewHisMed;
        private MetroFramework.Controls.MetroButton btnImprimir;
        private MetroFramework.Controls.MetroDateTime dateDesde;
        private MetroFramework.Controls.MetroDateTime dateHasta;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dataGridViewProcedimientos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Procedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuministroMedicacion_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finaliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico_med;
    }
}