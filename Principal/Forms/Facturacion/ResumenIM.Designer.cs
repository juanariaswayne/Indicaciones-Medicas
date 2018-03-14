namespace Principal.Forms.Facturacion
{
    partial class ResumenIM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.idPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSede = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnGuardar = new MetroFramework.Controls.MetroTile();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.dataGridViewProcedimientos = new System.Windows.Forms.DataGridView();
            this.dataGridViewDescartables = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMedicamentos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diluyente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDesde = new MetroFramework.Controls.MetroDateTime();
            this.dateHasta = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ID_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENERICO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INICIOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUMINISTRO_ID_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROCEDIMIENTO_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIAS_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FINP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECK_2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDescartables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.gridPacientes);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(319, 684);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // gridPacientes
            // 
            this.gridPacientes.AllowUserToAddRows = false;
            this.gridPacientes.AllowUserToOrderColumns = true;
            this.gridPacientes.AllowUserToResizeColumns = false;
            this.gridPacientes.AllowUserToResizeRows = false;
            this.gridPacientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaciente,
            this.Habitacion,
            this.Paciente});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPacientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPacientes.Location = new System.Drawing.Point(0, 0);
            this.gridPacientes.MultiSelect = false;
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.ReadOnly = true;
            this.gridPacientes.RowHeadersVisible = false;
            this.gridPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPacientes.Size = new System.Drawing.Size(319, 684);
            this.gridPacientes.TabIndex = 2;
            this.gridPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPacientes_CellClick);
            this.gridPacientes.SelectionChanged += new System.EventHandler(this.gridPacientes_SelectionChanged);
            // 
            // idPaciente
            // 
            this.idPaciente.HeaderText = "ID";
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.ReadOnly = true;
            this.idPaciente.Visible = false;
            // 
            // Habitacion
            // 
            this.Habitacion.HeaderText = "Hab";
            this.Habitacion.Name = "Habitacion";
            this.Habitacion.ReadOnly = true;
            this.Habitacion.Width = 70;
            // 
            // Paciente
            // 
            this.Paciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            // 
            // cboSede
            // 
            this.cboSede.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboSede.FormattingEnabled = true;
            this.cboSede.ItemHeight = 19;
            this.cboSede.Items.AddRange(new object[] {
            "Venezuela",
            "Mexico",
            "Catamarca"});
            this.cboSede.Location = new System.Drawing.Point(20, 29);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(143, 25);
            this.cboSede.TabIndex = 1;
            this.cboSede.UseSelectable = true;
            this.cboSede.SelectedIndexChanged += new System.EventHandler(this.cboSede_SelectedIndexChanged);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(169, 31);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Buscar paciente";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(170, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Buscar paciente";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Sede";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnGuardar);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(339, 705);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1229, 39);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveControl = null;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 39);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "imprimir";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.UseSelectable = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.dataGridViewProcedimientos);
            this.metroPanel3.Controls.Add(this.dataGridViewDescartables);
            this.metroPanel3.Controls.Add(this.panel1);
            this.metroPanel3.Controls.Add(this.dataGridViewMedicamentos);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(339, 60);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1229, 645);
            this.metroPanel3.TabIndex = 5;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // dataGridViewProcedimientos
            // 
            this.dataGridViewProcedimientos.AllowUserToAddRows = false;
            this.dataGridViewProcedimientos.AllowUserToDeleteRows = false;
            this.dataGridViewProcedimientos.AllowUserToOrderColumns = true;
            this.dataGridViewProcedimientos.AllowUserToResizeRows = false;
            this.dataGridViewProcedimientos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcedimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_2,
            this.GENERICO_ID,
            this.INICIOP,
            this.SUMINISTRO_ID_2,
            this.PROCEDIMIENTO_2,
            this.HORARIO_2,
            this.DIAS_2,
            this.OBS_2,
            this.FINP,
            this.CHECK_2,
            this.TIPO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProcedimientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProcedimientos.Location = new System.Drawing.Point(0, 434);
            this.dataGridViewProcedimientos.MultiSelect = false;
            this.dataGridViewProcedimientos.Name = "dataGridViewProcedimientos";
            this.dataGridViewProcedimientos.RowHeadersVisible = false;
            this.dataGridViewProcedimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcedimientos.Size = new System.Drawing.Size(838, 211);
            this.dataGridViewProcedimientos.TabIndex = 13;
            this.dataGridViewProcedimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcedimientos_CellContentClick);
            this.dataGridViewProcedimientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcedimientos_CellDoubleClick);
            this.dataGridViewProcedimientos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcedimientos_CellValueChanged);
            // 
            // dataGridViewDescartables
            // 
            this.dataGridViewDescartables.AllowUserToAddRows = false;
            this.dataGridViewDescartables.AllowUserToDeleteRows = false;
            this.dataGridViewDescartables.AllowUserToOrderColumns = true;
            this.dataGridViewDescartables.AllowUserToResizeRows = false;
            this.dataGridViewDescartables.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDescartables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDescartables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDescartables.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDescartables.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewDescartables.Location = new System.Drawing.Point(838, 434);
            this.dataGridViewDescartables.MultiSelect = false;
            this.dataGridViewDescartables.Name = "dataGridViewDescartables";
            this.dataGridViewDescartables.RowHeadersVisible = false;
            this.dataGridViewDescartables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDescartables.Size = new System.Drawing.Size(391, 211);
            this.dataGridViewDescartables.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "ID_CIERRE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "SUMINISTRO_ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.HeaderText = "Cod_Desc";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 5);
            this.panel1.TabIndex = 17;
            // 
            // dataGridViewMedicamentos
            // 
            this.dataGridViewMedicamentos.AllowUserToAddRows = false;
            this.dataGridViewMedicamentos.AllowUserToDeleteRows = false;
            this.dataGridViewMedicamentos.AllowUserToOrderColumns = true;
            this.dataGridViewMedicamentos.AllowUserToResizeRows = false;
            this.dataGridViewMedicamentos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Inicio,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Diluyente,
            this.ML,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.DIA,
            this.OBS_3,
            this.FIN});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMedicamentos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMedicamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMedicamentos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMedicamentos.MultiSelect = false;
            this.dataGridViewMedicamentos.Name = "dataGridViewMedicamentos";
            this.dataGridViewMedicamentos.RowHeadersVisible = false;
            this.dataGridViewMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedicamentos.Size = new System.Drawing.Size(1229, 429);
            this.dataGridViewMedicamentos.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Inicio
            // 
            this.Inicio.HeaderText = "INICIO";
            this.Inicio.Name = "Inicio";
            this.Inicio.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_SUM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "PRODUCTO_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "MEDICAMENTO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "VIA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // Diluyente
            // 
            this.Diluyente.HeaderText = "DIL.";
            this.Diluyente.Name = "Diluyente";
            this.Diluyente.Width = 80;
            // 
            // ML
            // 
            this.ML.HeaderText = "ML";
            this.ML.Name = "ML";
            this.ML.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "DOSIS";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "HORARIO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // DIA
            // 
            this.DIA.HeaderText = "DIAS";
            this.DIA.Name = "DIA";
            this.DIA.ReadOnly = true;
            // 
            // OBS_3
            // 
            this.OBS_3.HeaderText = "OBS";
            this.OBS_3.Name = "OBS_3";
            this.OBS_3.ReadOnly = true;
            this.OBS_3.Width = 150;
            // 
            // FIN
            // 
            this.FIN.HeaderText = "FIN";
            this.FIN.Name = "FIN";
            this.FIN.Width = 70;
            // 
            // dateDesde
            // 
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDesde.Location = new System.Drawing.Point(351, 25);
            this.dateDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(109, 29);
            this.dateDesde.TabIndex = 6;
            this.dateDesde.ValueChanged += new System.EventHandler(this.dateDesde_ValueChanged);
            // 
            // dateHasta
            // 
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHasta.Location = new System.Drawing.Point(466, 25);
            this.dateHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(109, 29);
            this.dateHasta.TabIndex = 7;
            this.dateHasta.ValueChanged += new System.EventHandler(this.dateHasta_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(351, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Desde";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(466, 6);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Hasta";
            // 
            // ID_2
            // 
            this.ID_2.HeaderText = "ID_PROCEDIMIENTO";
            this.ID_2.Name = "ID_2";
            this.ID_2.Visible = false;
            // 
            // GENERICO_ID
            // 
            this.GENERICO_ID.HeaderText = "GENERICO_ID";
            this.GENERICO_ID.Name = "GENERICO_ID";
            this.GENERICO_ID.Visible = false;
            // 
            // INICIOP
            // 
            this.INICIOP.HeaderText = "INICIO";
            this.INICIOP.Name = "INICIOP";
            this.INICIOP.Width = 80;
            // 
            // SUMINISTRO_ID_2
            // 
            this.SUMINISTRO_ID_2.HeaderText = "ID";
            this.SUMINISTRO_ID_2.Name = "SUMINISTRO_ID_2";
            this.SUMINISTRO_ID_2.Width = 80;
            // 
            // PROCEDIMIENTO_2
            // 
            this.PROCEDIMIENTO_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PROCEDIMIENTO_2.HeaderText = "PROCEDIMIENTO";
            this.PROCEDIMIENTO_2.Name = "PROCEDIMIENTO_2";
            this.PROCEDIMIENTO_2.ReadOnly = true;
            // 
            // HORARIO_2
            // 
            this.HORARIO_2.HeaderText = "HORARIO";
            this.HORARIO_2.Name = "HORARIO_2";
            this.HORARIO_2.ReadOnly = true;
            // 
            // DIAS_2
            // 
            this.DIAS_2.HeaderText = "DIAS";
            this.DIAS_2.Name = "DIAS_2";
            this.DIAS_2.ReadOnly = true;
            // 
            // OBS_2
            // 
            this.OBS_2.HeaderText = "OBS";
            this.OBS_2.Name = "OBS_2";
            this.OBS_2.ReadOnly = true;
            this.OBS_2.Width = 200;
            // 
            // FINP
            // 
            this.FINP.HeaderText = "FIN";
            this.FINP.Name = "FINP";
            this.FINP.Width = 80;
            // 
            // CHECK_2
            // 
            this.CHECK_2.HeaderText = "✓";
            this.CHECK_2.Name = "CHECK_2";
            this.CHECK_2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHECK_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CHECK_2.Width = 20;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.Visible = false;
            // 
            // ResumenIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 764);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.cboSede);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ResumenIM";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Resumen Indicaciones Medicas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.ResumenIM_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDescartables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox cboSede;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private MetroFramework.Controls.MetroDateTime dateDesde;
        private MetroFramework.Controls.MetroDateTime dateHasta;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dataGridViewProcedimientos;
        private System.Windows.Forms.DataGridView dataGridViewDescartables;
        private System.Windows.Forms.DataGridView dataGridViewMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private MetroFramework.Controls.MetroTile btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diluyente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ML;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENERICO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn INICIOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUMINISTRO_ID_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROCEDIMIENTO_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAS_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
    }
}