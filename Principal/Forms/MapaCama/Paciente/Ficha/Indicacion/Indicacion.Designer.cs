namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion
{
    partial class Indicacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indicacion));
            this.panelIndicacion = new MetroFramework.Controls.MetroPanel();
            this.tabIndicacion = new MetroFramework.Controls.MetroTabControl();
            this.tabMedicacion = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dataGridViewMedicacion = new System.Windows.Forms.DataGridView();
            this.suministroDeMedicacionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicacionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProcedimiento = new MetroFramework.Controls.MetroTabPage();
            this.dataGridViewProcedimiento = new System.Windows.Forms.DataGridView();
            this.suministroProcedimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProcedimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnfermeriaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posologiaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genericoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colocacionViaPeriferiaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuidadoOralId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuidadoPosturalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteccionFisica_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.php_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnImprimir = new MetroFramework.Controls.MetroTile();
            this.btnMedicacion = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHistorico = new MetroFramework.Controls.MetroTile();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProcedimiento = new MetroFramework.Controls.MetroTile();
            this.panelIndicacion.SuspendLayout();
            this.tabIndicacion.SuspendLayout();
            this.tabMedicacion.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicacion)).BeginInit();
            this.tabProcedimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedimiento)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIndicacion
            // 
            this.panelIndicacion.Controls.Add(this.tabIndicacion);
            this.panelIndicacion.Controls.Add(this.metroPanel1);
            this.panelIndicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIndicacion.HorizontalScrollbarBarColor = true;
            this.panelIndicacion.HorizontalScrollbarHighlightOnWheel = false;
            this.panelIndicacion.HorizontalScrollbarSize = 10;
            this.panelIndicacion.Location = new System.Drawing.Point(20, 60);
            this.panelIndicacion.Name = "panelIndicacion";
            this.panelIndicacion.Size = new System.Drawing.Size(1185, 413);
            this.panelIndicacion.TabIndex = 2;
            this.panelIndicacion.VerticalScrollbarBarColor = true;
            this.panelIndicacion.VerticalScrollbarHighlightOnWheel = false;
            this.panelIndicacion.VerticalScrollbarSize = 10;
            // 
            // tabIndicacion
            // 
            this.tabIndicacion.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabIndicacion.Controls.Add(this.tabMedicacion);
            this.tabIndicacion.Controls.Add(this.tabProcedimiento);
            this.tabIndicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabIndicacion.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabIndicacion.Location = new System.Drawing.Point(0, 0);
            this.tabIndicacion.Name = "tabIndicacion";
            this.tabIndicacion.SelectedIndex = 0;
            this.tabIndicacion.Size = new System.Drawing.Size(1185, 374);
            this.tabIndicacion.Style = MetroFramework.MetroColorStyle.Red;
            this.tabIndicacion.TabIndex = 3;
            this.tabIndicacion.UseSelectable = true;
            // 
            // tabMedicacion
            // 
            this.tabMedicacion.Controls.Add(this.metroPanel2);
            this.tabMedicacion.HorizontalScrollbarBarColor = true;
            this.tabMedicacion.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMedicacion.HorizontalScrollbarSize = 10;
            this.tabMedicacion.Location = new System.Drawing.Point(4, 37);
            this.tabMedicacion.Name = "tabMedicacion";
            this.tabMedicacion.Padding = new System.Windows.Forms.Padding(1);
            this.tabMedicacion.Size = new System.Drawing.Size(1177, 333);
            this.tabMedicacion.Style = MetroFramework.MetroColorStyle.Purple;
            this.tabMedicacion.TabIndex = 0;
            this.tabMedicacion.Text = "Medicacion";
            this.tabMedicacion.UseStyleColors = true;
            this.tabMedicacion.VerticalScrollbarBarColor = true;
            this.tabMedicacion.VerticalScrollbarHighlightOnWheel = false;
            this.tabMedicacion.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.dataGridViewMedicacion);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(1, 1);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1175, 331);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dataGridViewMedicacion
            // 
            this.dataGridViewMedicacion.AllowUserToAddRows = false;
            this.dataGridViewMedicacion.AllowUserToDeleteRows = false;
            this.dataGridViewMedicacion.AllowUserToOrderColumns = true;
            this.dataGridViewMedicacion.AllowUserToResizeColumns = false;
            this.dataGridViewMedicacion.AllowUserToResizeRows = false;
            this.dataGridViewMedicacion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewMedicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suministroDeMedicacionId,
            this.pacienteId,
            this.medicacionId,
            this.fechaInicio,
            this.Medicamento,
            this.horario,
            this.fechaHasta,
            this.observacion,
            this.Medico});
            this.dataGridViewMedicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMedicacion.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewMedicacion.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMedicacion.MultiSelect = false;
            this.dataGridViewMedicacion.Name = "dataGridViewMedicacion";
            this.dataGridViewMedicacion.ReadOnly = true;
            this.dataGridViewMedicacion.RowHeadersVisible = false;
            this.dataGridViewMedicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedicacion.Size = new System.Drawing.Size(1175, 331);
            this.dataGridViewMedicacion.TabIndex = 3;
            this.dataGridViewMedicacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicacion_CellDoubleClick);
            this.dataGridViewMedicacion.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewMedicamento_CurrentCellDirtyStateChanged);
            // 
            // suministroDeMedicacionId
            // 
            this.suministroDeMedicacionId.HeaderText = "suministroDeMedicacionId";
            this.suministroDeMedicacionId.Name = "suministroDeMedicacionId";
            this.suministroDeMedicacionId.ReadOnly = true;
            this.suministroDeMedicacionId.Visible = false;
            // 
            // pacienteId
            // 
            this.pacienteId.HeaderText = "pacienteId";
            this.pacienteId.Name = "pacienteId";
            this.pacienteId.ReadOnly = true;
            this.pacienteId.Visible = false;
            // 
            // medicacionId
            // 
            this.medicacionId.HeaderText = "medicamentoId";
            this.medicacionId.Name = "medicacionId";
            this.medicacionId.ReadOnly = true;
            this.medicacionId.Visible = false;
            // 
            // fechaInicio
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            this.fechaInicio.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaInicio.FillWeight = 64.22433F;
            this.fechaInicio.HeaderText = "Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            this.fechaInicio.Width = 85;
            // 
            // Medicamento
            // 
            this.Medicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            this.Medicamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Medicamento.FillWeight = 215.3959F;
            this.Medicamento.HeaderText = "Medicamento";
            this.Medicamento.Name = "Medicamento";
            this.Medicamento.ReadOnly = true;
            this.Medicamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // horario
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo;
            this.horario.DefaultCellStyle = dataGridViewCellStyle3;
            this.horario.FillWeight = 110.2095F;
            this.horario.HeaderText = "Horario // Via";
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            this.horario.Width = 190;
            // 
            // fechaHasta
            // 
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo;
            this.fechaHasta.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaHasta.FillWeight = 62.40926F;
            this.fechaHasta.HeaderText = "Finaliza";
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.ReadOnly = true;
            this.fechaHasta.Width = 85;
            // 
            // observacion
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Indigo;
            this.observacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.observacion.FillWeight = 153.9466F;
            this.observacion.HeaderText = "Observaciones";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.Width = 261;
            // 
            // Medico
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Purple;
            this.Medico.DefaultCellStyle = dataGridViewCellStyle6;
            this.Medico.HeaderText = "Medico";
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            this.Medico.Width = 101;
            // 
            // tabProcedimiento
            // 
            this.tabProcedimiento.Controls.Add(this.dataGridViewProcedimiento);
            this.tabProcedimiento.HorizontalScrollbarBarColor = true;
            this.tabProcedimiento.HorizontalScrollbarHighlightOnWheel = false;
            this.tabProcedimiento.HorizontalScrollbarSize = 10;
            this.tabProcedimiento.Location = new System.Drawing.Point(4, 37);
            this.tabProcedimiento.Name = "tabProcedimiento";
            this.tabProcedimiento.Padding = new System.Windows.Forms.Padding(1);
            this.tabProcedimiento.Size = new System.Drawing.Size(1177, 333);
            this.tabProcedimiento.Style = MetroFramework.MetroColorStyle.Orange;
            this.tabProcedimiento.TabIndex = 1;
            this.tabProcedimiento.Text = "Procedimientos";
            this.tabProcedimiento.UseStyleColors = true;
            this.tabProcedimiento.VerticalScrollbarBarColor = true;
            this.tabProcedimiento.VerticalScrollbarHighlightOnWheel = false;
            this.tabProcedimiento.VerticalScrollbarSize = 10;
            // 
            // dataGridViewProcedimiento
            // 
            this.dataGridViewProcedimiento.AllowUserToAddRows = false;
            this.dataGridViewProcedimiento.AllowUserToDeleteRows = false;
            this.dataGridViewProcedimiento.AllowUserToOrderColumns = true;
            this.dataGridViewProcedimiento.AllowUserToResizeColumns = false;
            this.dataGridViewProcedimiento.AllowUserToResizeRows = false;
            this.dataGridViewProcedimiento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcedimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suministroProcedimientoId,
            this.procedimientoId,
            this.procedimiento,
            this.tipoProcedimientoId,
            this.tipoProcedimiento,
            this.EnfermeriaId,
            this.posologiaId,
            this.genericoId,
            this.colocacionViaPeriferiaId,
            this.cuidadoOralId,
            this.cuidadoPosturalId,
            this.proteccionFisica_Id,
            this.php_Id});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProcedimiento.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewProcedimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProcedimiento.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewProcedimiento.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewProcedimiento.MultiSelect = false;
            this.dataGridViewProcedimiento.Name = "dataGridViewProcedimiento";
            this.dataGridViewProcedimiento.ReadOnly = true;
            this.dataGridViewProcedimiento.RowHeadersVisible = false;
            this.dataGridViewProcedimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcedimiento.Size = new System.Drawing.Size(1175, 331);
            this.dataGridViewProcedimiento.TabIndex = 3;
            this.dataGridViewProcedimiento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcedimiento_CellDoubleClick);
            this.dataGridViewProcedimiento.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewProcedimiento_CurrentCellDirtyStateChanged);
            // 
            // suministroProcedimientoId
            // 
            this.suministroProcedimientoId.HeaderText = "Suministro_Procedimiento_Id";
            this.suministroProcedimientoId.Name = "suministroProcedimientoId";
            this.suministroProcedimientoId.ReadOnly = true;
            this.suministroProcedimientoId.Visible = false;
            // 
            // procedimientoId
            // 
            this.procedimientoId.HeaderText = "Procedimiento_Id";
            this.procedimientoId.Name = "procedimientoId";
            this.procedimientoId.ReadOnly = true;
            this.procedimientoId.Visible = false;
            // 
            // procedimiento
            // 
            this.procedimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.procedimiento.HeaderText = "Procedimiento";
            this.procedimiento.Name = "procedimiento";
            this.procedimiento.ReadOnly = true;
            // 
            // tipoProcedimientoId
            // 
            this.tipoProcedimientoId.HeaderText = "Tipo Procedimiento Id";
            this.tipoProcedimientoId.Name = "tipoProcedimientoId";
            this.tipoProcedimientoId.ReadOnly = true;
            this.tipoProcedimientoId.Visible = false;
            // 
            // tipoProcedimiento
            // 
            this.tipoProcedimiento.HeaderText = "Tipo Procedimiento";
            this.tipoProcedimiento.Name = "tipoProcedimiento";
            this.tipoProcedimiento.ReadOnly = true;
            this.tipoProcedimiento.Visible = false;
            // 
            // EnfermeriaId
            // 
            this.EnfermeriaId.HeaderText = "Enfermeria_Id";
            this.EnfermeriaId.Name = "EnfermeriaId";
            this.EnfermeriaId.ReadOnly = true;
            this.EnfermeriaId.Visible = false;
            // 
            // posologiaId
            // 
            this.posologiaId.HeaderText = "Posologia_Id";
            this.posologiaId.Name = "posologiaId";
            this.posologiaId.ReadOnly = true;
            this.posologiaId.Visible = false;
            // 
            // genericoId
            // 
            this.genericoId.HeaderText = "Generico_Id";
            this.genericoId.Name = "genericoId";
            this.genericoId.ReadOnly = true;
            this.genericoId.Visible = false;
            // 
            // colocacionViaPeriferiaId
            // 
            this.colocacionViaPeriferiaId.HeaderText = "ColocacionViaPeriferia_Id";
            this.colocacionViaPeriferiaId.Name = "colocacionViaPeriferiaId";
            this.colocacionViaPeriferiaId.ReadOnly = true;
            this.colocacionViaPeriferiaId.Visible = false;
            // 
            // cuidadoOralId
            // 
            this.cuidadoOralId.HeaderText = "Cuidado_Oral_Id";
            this.cuidadoOralId.Name = "cuidadoOralId";
            this.cuidadoOralId.ReadOnly = true;
            this.cuidadoOralId.Visible = false;
            // 
            // cuidadoPosturalId
            // 
            this.cuidadoPosturalId.HeaderText = "Cuidado_Postural_Id";
            this.cuidadoPosturalId.Name = "cuidadoPosturalId";
            this.cuidadoPosturalId.ReadOnly = true;
            this.cuidadoPosturalId.Visible = false;
            // 
            // proteccionFisica_Id
            // 
            this.proteccionFisica_Id.HeaderText = "Proteccion_Fisica_Id";
            this.proteccionFisica_Id.Name = "proteccionFisica_Id";
            this.proteccionFisica_Id.ReadOnly = true;
            this.proteccionFisica_Id.Visible = false;
            // 
            // php_Id
            // 
            this.php_Id.HeaderText = "Php_Id";
            this.php_Id.Name = "php_Id";
            this.php_Id.ReadOnly = true;
            this.php_Id.Visible = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnImprimir);
            this.metroPanel1.Controls.Add(this.btnMedicacion);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.btnHistorico);
            this.metroPanel1.Controls.Add(this.panel2);
            this.metroPanel1.Controls.Add(this.btnProcedimiento);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 374);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1185, 39);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnImprimir
            // 
            this.btnImprimir.ActiveControl = null;
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImprimir.Location = new System.Drawing.Point(113, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 39);
            this.btnImprimir.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnImprimir.UseSelectable = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click_1);
            // 
            // btnMedicacion
            // 
            this.btnMedicacion.ActiveControl = null;
            this.btnMedicacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMedicacion.Location = new System.Drawing.Point(891, 0);
            this.btnMedicacion.Name = "btnMedicacion";
            this.btnMedicacion.Size = new System.Drawing.Size(137, 39);
            this.btnMedicacion.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnMedicacion.TabIndex = 10;
            this.btnMedicacion.Text = "Suministrar Medicacion";
            this.btnMedicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMedicacion.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnMedicacion.UseSelectable = true;
            this.btnMedicacion.Click += new System.EventHandler(this.btnMedicacion_Click_1);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(99, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 39);
            this.panel1.TabIndex = 13;
            // 
            // btnHistorico
            // 
            this.btnHistorico.ActiveControl = null;
            this.btnHistorico.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHistorico.Location = new System.Drawing.Point(0, 0);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(99, 39);
            this.btnHistorico.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnHistorico.TabIndex = 9;
            this.btnHistorico.Text = "Historico";
            this.btnHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHistorico.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnHistorico.UseSelectable = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1028, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 39);
            this.panel2.TabIndex = 14;
            // 
            // btnProcedimiento
            // 
            this.btnProcedimiento.ActiveControl = null;
            this.btnProcedimiento.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProcedimiento.Location = new System.Drawing.Point(1047, 0);
            this.btnProcedimiento.Name = "btnProcedimiento";
            this.btnProcedimiento.Size = new System.Drawing.Size(138, 39);
            this.btnProcedimiento.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnProcedimiento.TabIndex = 11;
            this.btnProcedimiento.Text = "Aplicar Procedimiento";
            this.btnProcedimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProcedimiento.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnProcedimiento.UseSelectable = true;
            this.btnProcedimiento.Click += new System.EventHandler(this.btnProcedimiento_Click_1);
            // 
            // Indicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 493);
            this.Controls.Add(this.panelIndicacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Indicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Indicacion_Load);
            this.panelIndicacion.ResumeLayout(false);
            this.tabIndicacion.ResumeLayout(false);
            this.tabMedicacion.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicacion)).EndInit();
            this.tabProcedimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedimiento)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProcedimiento;
        private MetroFramework.Controls.MetroTabPage tabProcedimiento;
        private System.Windows.Forms.DataGridView dataGridViewMedicacion;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTabPage tabMedicacion;
        private MetroFramework.Controls.MetroTabControl tabIndicacion;
        public MetroFramework.Controls.MetroPanel panelIndicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn php_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteccionFisica_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuidadoPosturalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuidadoOralId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colocacionViaPeriferiaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn genericoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn posologiaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnfermeriaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProcedimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn suministroProcedimientoId;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnHistorico;
        private MetroFramework.Controls.MetroTile btnMedicacion;
        private MetroFramework.Controls.MetroTile btnProcedimiento;
        private MetroFramework.Controls.MetroTile btnImprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn suministroDeMedicacionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicacionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
    }
}

