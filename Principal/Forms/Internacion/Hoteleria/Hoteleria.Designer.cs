namespace Principal.Forms.Internacion.Hoteleria
{
    partial class Hoteleria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoteleria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewPertenencias = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtSupervisor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtGobernante = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxObservacion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxBolsas = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelNombrePac = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPaciente = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoAlta_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paciente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupEnfermeria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gobernante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantBolsasSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservacionSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPertenencias)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewPertenencias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 336);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewPertenencias
            // 
            this.dataGridViewPertenencias.AllowUserToAddRows = false;
            this.dataGridViewPertenencias.AllowUserToDeleteRows = false;
            this.dataGridViewPertenencias.AllowUserToOrderColumns = true;
            this.dataGridViewPertenencias.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPertenencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPertenencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.motivoAlta_id,
            this.estado_id,
            this.paciente_id,
            this.Paciente,
            this.fecha_alta,
            this.SupEnfermeria,
            this.Gobernante,
            this.CantBolsasSede,
            this.ObservacionSede,
            this.Estado,
            this.Sede});
            this.dataGridViewPertenencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewPertenencias.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPertenencias.Name = "dataGridViewPertenencias";
            this.dataGridViewPertenencias.RowHeadersVisible = false;
            this.dataGridViewPertenencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPertenencias.Size = new System.Drawing.Size(893, 333);
            this.dataGridViewPertenencias.TabIndex = 0;
            this.dataGridViewPertenencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPertenencias_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboEstado);
            this.panel2.Controls.Add(this.metroLabel5);
            this.panel2.Controls.Add(this.txtSupervisor);
            this.panel2.Controls.Add(this.metroLabel4);
            this.panel2.Controls.Add(this.txtGobernante);
            this.panel2.Controls.Add(this.metroLabel3);
            this.panel2.Controls.Add(this.metroTextBoxObservacion);
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.metroTextBoxBolsas);
            this.panel2.Controls.Add(this.metroLabelNombrePac);
            this.panel2.Controls.Add(this.metroLabelPaciente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 71);
            this.panel2.TabIndex = 1;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(715, 10);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(164, 21);
            this.cboEstado.TabIndex = 15;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(661, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Estado";
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Lines = new string[0];
            this.txtSupervisor.Location = new System.Drawing.Point(496, 8);
            this.txtSupervisor.MaxLength = 32767;
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.PasswordChar = '\0';
            this.txtSupervisor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupervisor.SelectedText = "";
            this.txtSupervisor.Size = new System.Drawing.Size(147, 23);
            this.txtSupervisor.TabIndex = 9;
            this.txtSupervisor.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(423, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Supervisor";
            // 
            // txtGobernante
            // 
            this.txtGobernante.Lines = new string[0];
            this.txtGobernante.Location = new System.Drawing.Point(265, 8);
            this.txtGobernante.MaxLength = 32767;
            this.txtGobernante.Name = "txtGobernante";
            this.txtGobernante.PasswordChar = '\0';
            this.txtGobernante.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGobernante.SelectedText = "";
            this.txtGobernante.Size = new System.Drawing.Size(143, 23);
            this.txtGobernante.TabIndex = 8;
            this.txtGobernante.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(185, 8);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Gobernante";
            // 
            // metroTextBoxObservacion
            // 
            this.metroTextBoxObservacion.Lines = new string[0];
            this.metroTextBoxObservacion.Location = new System.Drawing.Point(359, 40);
            this.metroTextBoxObservacion.MaxLength = 32767;
            this.metroTextBoxObservacion.Name = "metroTextBoxObservacion";
            this.metroTextBoxObservacion.PasswordChar = '\0';
            this.metroTextBoxObservacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxObservacion.SelectedText = "";
            this.metroTextBoxObservacion.Size = new System.Drawing.Size(520, 23);
            this.metroTextBoxObservacion.TabIndex = 12;
            this.metroTextBoxObservacion.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(258, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Observaciones";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(177, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Cantidad de bolsas recibidas";
            // 
            // metroTextBoxBolsas
            // 
            this.metroTextBoxBolsas.Lines = new string[0];
            this.metroTextBoxBolsas.Location = new System.Drawing.Point(188, 40);
            this.metroTextBoxBolsas.MaxLength = 3;
            this.metroTextBoxBolsas.Name = "metroTextBoxBolsas";
            this.metroTextBoxBolsas.PasswordChar = '\0';
            this.metroTextBoxBolsas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxBolsas.SelectedText = "";
            this.metroTextBoxBolsas.Size = new System.Drawing.Size(56, 23);
            this.metroTextBoxBolsas.TabIndex = 11;
            this.metroTextBoxBolsas.UseSelectable = true;
            this.metroTextBoxBolsas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxBolsas_KeyPress);
            // 
            // metroLabelNombrePac
            // 
            this.metroLabelNombrePac.AutoSize = true;
            this.metroLabelNombrePac.Location = new System.Drawing.Point(69, 4);
            this.metroLabelNombrePac.Name = "metroLabelNombrePac";
            this.metroLabelNombrePac.Size = new System.Drawing.Size(111, 19);
            this.metroLabelNombrePac.TabIndex = 1;
            this.metroLabelNombrePac.Text = "Nombre Paciente";
            // 
            // metroLabelPaciente
            // 
            this.metroLabelPaciente.AutoSize = true;
            this.metroLabelPaciente.Location = new System.Drawing.Point(6, 4);
            this.metroLabelPaciente.Name = "metroLabelPaciente";
            this.metroLabelPaciente.Size = new System.Drawing.Size(57, 19);
            this.metroLabelPaciente.TabIndex = 0;
            this.metroLabelPaciente.Text = "Paciente";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonGuardar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(20, 473);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 32);
            this.panel3.TabIndex = 2;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
            this.buttonGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonGuardar.Location = new System.Drawing.Point(752, 0);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(141, 32);
            this.buttonGuardar.TabIndex = 13;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click_1);
            // 
            // id
            // 
            this.id.HeaderText = "idPertenencia";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // motivoAlta_id
            // 
            this.motivoAlta_id.HeaderText = "motivoAltaId";
            this.motivoAlta_id.Name = "motivoAlta_id";
            this.motivoAlta_id.Visible = false;
            // 
            // estado_id
            // 
            this.estado_id.HeaderText = "estadoId";
            this.estado_id.Name = "estado_id";
            this.estado_id.Visible = false;
            // 
            // paciente_id
            // 
            this.paciente_id.HeaderText = "paciente_id";
            this.paciente_id.Name = "paciente_id";
            this.paciente_id.Visible = false;
            // 
            // Paciente
            // 
            this.Paciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            // 
            // fecha_alta
            // 
            this.fecha_alta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fecha_alta.DefaultCellStyle = dataGridViewCellStyle1;
            this.fecha_alta.HeaderText = "Fecha Alta";
            this.fecha_alta.Name = "fecha_alta";
            this.fecha_alta.ReadOnly = true;
            // 
            // SupEnfermeria
            // 
            this.SupEnfermeria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupEnfermeria.HeaderText = "Sup. Enfermeria";
            this.SupEnfermeria.Name = "SupEnfermeria";
            this.SupEnfermeria.ReadOnly = true;
            // 
            // Gobernante
            // 
            this.Gobernante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gobernante.HeaderText = "Gobernante";
            this.Gobernante.Name = "Gobernante";
            this.Gobernante.ReadOnly = true;
            // 
            // CantBolsasSede
            // 
            this.CantBolsasSede.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CantBolsasSede.HeaderText = "Cant. Bolsas";
            this.CantBolsasSede.Name = "CantBolsasSede";
            // 
            // ObservacionSede
            // 
            this.ObservacionSede.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ObservacionSede.HeaderText = "Observacion";
            this.ObservacionSede.Name = "ObservacionSede";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Sede
            // 
            this.Sede.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sede.HeaderText = "Sede";
            this.Sede.Name = "Sede";
            // 
            // Hoteleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hoteleria";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Hoteleria";
            this.Load += new System.EventHandler(this.Hoteleria_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPertenencias)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewPertenencias;
        private MetroFramework.Controls.MetroLabel metroLabelNombrePac;
        private MetroFramework.Controls.MetroLabel metroLabelPaciente;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBolsas;
        private MetroFramework.Controls.MetroTextBox metroTextBoxObservacion;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button buttonGuardar;
        private MetroFramework.Controls.MetroTextBox txtSupervisor;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtGobernante;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoAlta_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_alta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupEnfermeria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gobernante;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantBolsasSede;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservacionSede;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede;
    }
}