namespace Principal.Forms.MapaCama.Paciente.Ficha.Laboratorio
{
    partial class AutorizacionLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizacionLab));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new MetroFramework.Controls.MetroTile();
            this.btnImprimir = new MetroFramework.Controls.MetroTile();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitud_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paciente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recibido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OtrosEstudios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsBioq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cboSector = new MetroFramework.Controls.MetroComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.cboTipoPedido = new MetroFramework.Controls.MetroComboBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.cboEstado = new MetroFramework.Controls.MetroComboBox();
            this.dateHasta = new MetroFramework.Controls.MetroDateTime();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.DateFecha = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chckLapsoTiempo = new MetroFramework.Controls.MetroCheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridViewPedidos);
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 421);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 41);
            this.panel2.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveControl = null;
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.Location = new System.Drawing.Point(855, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 41);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseEnter += new System.EventHandler(this.btnGuardar_MouseEnter);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ActiveControl = null;
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImprimir.Location = new System.Drawing.Point(0, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(127, 41);
            this.btnImprimir.Style = MetroFramework.MetroColorStyle.Green;
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.UseSelectable = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.MouseEnter += new System.EventHandler(this.btnImprimir_MouseEnter);
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToAddRows = false;
            this.dataGridViewPedidos.AllowUserToDeleteRows = false;
            this.dataGridViewPedidos.AllowUserToOrderColumns = true;
            this.dataGridViewPedidos.AllowUserToResizeColumns = false;
            this.dataGridViewPedidos.AllowUserToResizeRows = false;
            this.dataGridViewPedidos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.solicitud_id,
            this.ID_TIPO,
            this.Tipo,
            this.usuario_id,
            this.paciente_id,
            this.Paciente,
            this.hab,
            this.Recibido,
            this.Estado,
            this.OtrosEstudios,
            this.ObsMed,
            this.ObsBioq,
            this.U_ID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedidos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.RowHeadersVisible = false;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(990, 391);
            this.dataGridViewPedidos.TabIndex = 0;
            this.dataGridViewPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidos_CellContentClick);
            this.dataGridViewPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidos_CellDoubleClick);
            this.dataGridViewPedidos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewPedidos_CurrentCellDirtyStateChanged);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 70;
            // 
            // solicitud_id
            // 
            this.solicitud_id.HeaderText = "Num. Solicitud";
            this.solicitud_id.Name = "solicitud_id";
            this.solicitud_id.ReadOnly = true;
            // 
            // ID_TIPO
            // 
            this.ID_TIPO.HeaderText = "ID_TIPO";
            this.ID_TIPO.Name = "ID_TIPO";
            this.ID_TIPO.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // usuario_id
            // 
            this.usuario_id.HeaderText = "Ultima Mod.";
            this.usuario_id.Name = "usuario_id";
            this.usuario_id.ReadOnly = true;
            // 
            // paciente_id
            // 
            this.paciente_id.HeaderText = "paciente_id";
            this.paciente_id.Name = "paciente_id";
            this.paciente_id.ReadOnly = true;
            this.paciente_id.Visible = false;
            // 
            // Paciente
            // 
            this.Paciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            // 
            // hab
            // 
            this.hab.HeaderText = "Hab.";
            this.hab.Name = "hab";
            this.hab.ReadOnly = true;
            this.hab.Width = 50;
            // 
            // Recibido
            // 
            this.Recibido.HeaderText = "Recibido";
            this.Recibido.Name = "Recibido";
            this.Recibido.Width = 60;
            // 
            // Estado
            // 
            this.Estado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 140;
            // 
            // OtrosEstudios
            // 
            this.OtrosEstudios.HeaderText = "OtrosEstudios";
            this.OtrosEstudios.Name = "OtrosEstudios";
            this.OtrosEstudios.Visible = false;
            // 
            // ObsMed
            // 
            this.ObsMed.HeaderText = "ObsMed";
            this.ObsMed.Name = "ObsMed";
            this.ObsMed.Visible = false;
            // 
            // ObsBioq
            // 
            this.ObsBioq.HeaderText = "ObsBioq";
            this.ObsBioq.Name = "ObsBioq";
            this.ObsBioq.Visible = false;
            // 
            // U_ID
            // 
            this.U_ID.HeaderText = "U_ID";
            this.U_ID.Name = "U_ID";
            this.U_ID.Visible = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.cboSector);
            this.metroPanel1.Controls.Add(this.splitter1);
            this.metroPanel1.Controls.Add(this.cboTipoPedido);
            this.metroPanel1.Controls.Add(this.splitter2);
            this.metroPanel1.Controls.Add(this.cboEstado);
            this.metroPanel1.Controls.Add(this.dateHasta);
            this.metroPanel1.Controls.Add(this.splitter3);
            this.metroPanel1.Controls.Add(this.DateFecha);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(990, 30);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cboSector
            // 
            this.cboSector.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboSector.FormattingEnabled = true;
            this.cboSector.ItemHeight = 23;
            this.cboSector.Items.AddRange(new object[] {
            "General",
            "Microbiologia"});
            this.cboSector.Location = new System.Drawing.Point(407, 0);
            this.cboSector.Name = "cboSector";
            this.cboSector.PromptText = "Seleccione sector";
            this.cboSector.Size = new System.Drawing.Size(185, 29);
            this.cboSector.TabIndex = 4;
            this.cboSector.UseSelectable = true;
            this.cboSector.SelectedIndexChanged += new System.EventHandler(this.cboSector_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(592, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(18, 30);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // cboTipoPedido
            // 
            this.cboTipoPedido.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboTipoPedido.FormattingEnabled = true;
            this.cboTipoPedido.ItemHeight = 23;
            this.cboTipoPedido.Items.AddRange(new object[] {
            "Rutina",
            "Urgente"});
            this.cboTipoPedido.Location = new System.Drawing.Point(610, 0);
            this.cboTipoPedido.Name = "cboTipoPedido";
            this.cboTipoPedido.PromptText = "Tipo de pedido";
            this.cboTipoPedido.Size = new System.Drawing.Size(184, 29);
            this.cboTipoPedido.TabIndex = 6;
            this.cboTipoPedido.UseSelectable = true;
            this.cboTipoPedido.SelectedIndexChanged += new System.EventHandler(this.cboTipoPedido_SelectedIndexChanged);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(794, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(17, 30);
            this.splitter2.TabIndex = 8;
            this.splitter2.TabStop = false;
            // 
            // cboEstado
            // 
            this.cboEstado.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 23;
            this.cboEstado.Location = new System.Drawing.Point(811, 0);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.PromptText = "Tipo de estado";
            this.cboEstado.Size = new System.Drawing.Size(179, 29);
            this.cboEstado.TabIndex = 7;
            this.cboEstado.UseSelectable = true;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // dateHasta
            // 
            this.dateHasta.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHasta.Location = new System.Drawing.Point(127, 0);
            this.dateHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(109, 29);
            this.dateHasta.TabIndex = 9;
            this.dateHasta.ValueChanged += new System.EventHandler(this.dateHasta_ValueChanged);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(108, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(19, 30);
            this.splitter3.TabIndex = 10;
            this.splitter3.TabStop = false;
            // 
            // DateFecha
            // 
            this.DateFecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.DateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFecha.Location = new System.Drawing.Point(0, 0);
            this.DateFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateFecha.Name = "DateFecha";
            this.DateFecha.Size = new System.Drawing.Size(108, 29);
            this.DateFecha.TabIndex = 1;
            this.DateFecha.ValueChanged += new System.EventHandler(this.DateFecha_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Fecha de solicitud";
            // 
            // chckLapsoTiempo
            // 
            this.chckLapsoTiempo.AutoSize = true;
            this.chckLapsoTiempo.Location = new System.Drawing.Point(20, 39);
            this.chckLapsoTiempo.Name = "chckLapsoTiempo";
            this.chckLapsoTiempo.Size = new System.Drawing.Size(111, 15);
            this.chckLapsoTiempo.Style = MetroFramework.MetroColorStyle.Silver;
            this.chckLapsoTiempo.TabIndex = 3;
            this.chckLapsoTiempo.Text = "Lapso de tiempo";
            this.chckLapsoTiempo.UseSelectable = true;
            this.chckLapsoTiempo.CheckedChanged += new System.EventHandler(this.chckLapsoTiempo_CheckedChanged);
            // 
            // AutorizacionLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 501);
            this.Controls.Add(this.chckLapsoTiempo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutorizacionLab";
            this.Text = "Recepcion de pedidos de analisis";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutorizacionLab_FormClosed);
            this.Load += new System.EventHandler(this.AutorizacionLab_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private MetroFramework.Controls.MetroDateTime DateFecha;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnGuardar;
        private MetroFramework.Controls.MetroTile btnImprimir;
        private MetroFramework.Controls.MetroComboBox cboSector;
        private System.Windows.Forms.Splitter splitter1;
        private MetroFramework.Controls.MetroComboBox cboTipoPedido;
        private System.Windows.Forms.Splitter splitter2;
        private MetroFramework.Controls.MetroComboBox cboEstado;
        private MetroFramework.Controls.MetroCheckBox chckLapsoTiempo;
        private MetroFramework.Controls.MetroDateTime dateHasta;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitud_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn hab;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Recibido;
        private System.Windows.Forms.DataGridViewComboBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtrosEstudios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsBioq;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ID;
    }
}