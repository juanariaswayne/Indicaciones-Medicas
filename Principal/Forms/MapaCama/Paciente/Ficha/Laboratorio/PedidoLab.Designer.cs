namespace Principal.Forms.MapaCama.Paciente.Ficha.Laboratorio
{
    partial class PedidoLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoLab));
            this.panelLab = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.cboAnalisisDeriv = new MetroFramework.Controls.MetroComboBox();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.cboAnalisisClinica = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtObsBioq = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtObsMedico = new MetroFramework.Controls.MetroTextBox();
            this.txtOtrosAnalisis = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.estudio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.buttonModifica = new MetroFramework.Controls.MetroTile();
            this.buttonGuardar = new MetroFramework.Controls.MetroTile();
            this.lblSolicitud = new MetroFramework.Controls.MetroLabel();
            this.dateFecha = new MetroFramework.Controls.MetroDateTime();
            this.chckRutinaIngreso = new MetroFramework.Controls.MetroCheckBox();
            this.lblLeyenda = new MetroFramework.Controls.MetroLabel();
            this.chckUrgente = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panelLab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLab
            // 
            this.panelLab.Controls.Add(this.groupBox1);
            this.panelLab.Controls.Add(this.groupBoxGeneral);
            this.panelLab.Controls.Add(this.metroLabel4);
            this.panelLab.Controls.Add(this.txtObsBioq);
            this.panelLab.Controls.Add(this.metroLabel3);
            this.panelLab.Controls.Add(this.metroLabel2);
            this.panelLab.Controls.Add(this.txtObsMedico);
            this.panelLab.Controls.Add(this.txtOtrosAnalisis);
            this.panelLab.Controls.Add(this.groupBox2);
            this.panelLab.Controls.Add(this.metroPanel2);
            this.panelLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLab.Location = new System.Drawing.Point(20, 60);
            this.panelLab.Name = "panelLab";
            this.panelLab.Size = new System.Drawing.Size(687, 452);
            this.panelLab.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroTile2);
            this.groupBox1.Controls.Add(this.cboAnalisisDeriv);
            this.groupBox1.Location = new System.Drawing.Point(1, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analisis que se derivan";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(271, 61);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(64, 35);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile2.TabIndex = 6;
            this.metroTile2.Text = "Agregar";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // cboAnalisisDeriv
            // 
            this.cboAnalisisDeriv.FormattingEnabled = true;
            this.cboAnalisisDeriv.ItemHeight = 23;
            this.cboAnalisisDeriv.Location = new System.Drawing.Point(7, 21);
            this.cboAnalisisDeriv.Name = "cboAnalisisDeriv";
            this.cboAnalisisDeriv.Size = new System.Drawing.Size(328, 29);
            this.cboAnalisisDeriv.Style = MetroFramework.MetroColorStyle.Red;
            this.cboAnalisisDeriv.TabIndex = 0;
            this.cboAnalisisDeriv.UseSelectable = true;
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.metroTile1);
            this.groupBoxGeneral.Controls.Add(this.cboAnalisisClinica);
            this.groupBoxGeneral.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(341, 101);
            this.groupBoxGeneral.TabIndex = 0;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "Analisis realizados en la clinica";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(272, 60);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(64, 35);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Agregar";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // cboAnalisisClinica
            // 
            this.cboAnalisisClinica.FormattingEnabled = true;
            this.cboAnalisisClinica.ItemHeight = 23;
            this.cboAnalisisClinica.Location = new System.Drawing.Point(7, 19);
            this.cboAnalisisClinica.Name = "cboAnalisisClinica";
            this.cboAnalisisClinica.Size = new System.Drawing.Size(328, 29);
            this.cboAnalisisClinica.Style = MetroFramework.MetroColorStyle.Red;
            this.cboAnalisisClinica.TabIndex = 0;
            this.cboAnalisisClinica.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 342);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(175, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Observacion del laboratorio";
            // 
            // txtObsBioq
            // 
            // 
            // 
            // 
            this.txtObsBioq.CustomButton.Image = null;
            this.txtObsBioq.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.txtObsBioq.CustomButton.Name = "";
            this.txtObsBioq.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txtObsBioq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObsBioq.CustomButton.TabIndex = 1;
            this.txtObsBioq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObsBioq.CustomButton.UseSelectable = true;
            this.txtObsBioq.CustomButton.Visible = false;
            this.txtObsBioq.Lines = new string[0];
            this.txtObsBioq.Location = new System.Drawing.Point(7, 366);
            this.txtObsBioq.MaxLength = 32767;
            this.txtObsBioq.Multiline = true;
            this.txtObsBioq.Name = "txtObsBioq";
            this.txtObsBioq.PasswordChar = '\0';
            this.txtObsBioq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObsBioq.SelectedText = "";
            this.txtObsBioq.SelectionLength = 0;
            this.txtObsBioq.SelectionStart = 0;
            this.txtObsBioq.ShortcutsEnabled = true;
            this.txtObsBioq.Size = new System.Drawing.Size(328, 43);
            this.txtObsBioq.TabIndex = 6;
            this.txtObsBioq.UseSelectable = true;
            this.txtObsBioq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObsBioq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 262);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(153, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Observacion de solicitud";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 212);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Otros analisis";
            // 
            // txtObsMedico
            // 
            // 
            // 
            // 
            this.txtObsMedico.CustomButton.Image = null;
            this.txtObsMedico.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.txtObsMedico.CustomButton.Name = "";
            this.txtObsMedico.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.txtObsMedico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObsMedico.CustomButton.TabIndex = 1;
            this.txtObsMedico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObsMedico.CustomButton.UseSelectable = true;
            this.txtObsMedico.CustomButton.Visible = false;
            this.txtObsMedico.Lines = new string[0];
            this.txtObsMedico.Location = new System.Drawing.Point(8, 286);
            this.txtObsMedico.MaxLength = 32767;
            this.txtObsMedico.Multiline = true;
            this.txtObsMedico.Name = "txtObsMedico";
            this.txtObsMedico.PasswordChar = '\0';
            this.txtObsMedico.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObsMedico.SelectedText = "";
            this.txtObsMedico.SelectionLength = 0;
            this.txtObsMedico.SelectionStart = 0;
            this.txtObsMedico.ShortcutsEnabled = true;
            this.txtObsMedico.Size = new System.Drawing.Size(327, 49);
            this.txtObsMedico.TabIndex = 4;
            this.txtObsMedico.UseSelectable = true;
            this.txtObsMedico.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObsMedico.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOtrosAnalisis
            // 
            // 
            // 
            // 
            this.txtOtrosAnalisis.CustomButton.Image = null;
            this.txtOtrosAnalisis.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtOtrosAnalisis.CustomButton.Name = "";
            this.txtOtrosAnalisis.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOtrosAnalisis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOtrosAnalisis.CustomButton.TabIndex = 1;
            this.txtOtrosAnalisis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOtrosAnalisis.CustomButton.UseSelectable = true;
            this.txtOtrosAnalisis.CustomButton.Visible = false;
            this.txtOtrosAnalisis.Lines = new string[0];
            this.txtOtrosAnalisis.Location = new System.Drawing.Point(7, 235);
            this.txtOtrosAnalisis.MaxLength = 32767;
            this.txtOtrosAnalisis.Name = "txtOtrosAnalisis";
            this.txtOtrosAnalisis.PasswordChar = '\0';
            this.txtOtrosAnalisis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOtrosAnalisis.SelectedText = "";
            this.txtOtrosAnalisis.SelectionLength = 0;
            this.txtOtrosAnalisis.SelectionStart = 0;
            this.txtOtrosAnalisis.ShortcutsEnabled = true;
            this.txtOtrosAnalisis.Size = new System.Drawing.Size(328, 23);
            this.txtOtrosAnalisis.TabIndex = 2;
            this.txtOtrosAnalisis.UseSelectable = true;
            this.txtOtrosAnalisis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOtrosAnalisis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewPedido);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(348, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 415);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedido a realizar";
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.AllowUserToAddRows = false;
            this.dataGridViewPedido.AllowUserToDeleteRows = false;
            this.dataGridViewPedido.AllowUserToOrderColumns = true;
            this.dataGridViewPedido.AllowUserToResizeColumns = false;
            this.dataGridViewPedido.AllowUserToResizeRows = false;
            this.dataGridViewPedido.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estudio_id,
            this.Estudio,
            this.Eliminar,
            this.NroItem});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedido.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPedido.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewPedido.MultiSelect = false;
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.ReadOnly = true;
            this.dataGridViewPedido.RowHeadersVisible = false;
            this.dataGridViewPedido.RowHeadersWidth = 35;
            this.dataGridViewPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedido.Size = new System.Drawing.Size(333, 396);
            this.dataGridViewPedido.TabIndex = 0;
            this.dataGridViewPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedido_CellClick);
            // 
            // estudio_id
            // 
            this.estudio_id.HeaderText = "estudio_id";
            this.estudio_id.Name = "estudio_id";
            this.estudio_id.ReadOnly = true;
            this.estudio_id.Visible = false;
            // 
            // Estudio
            // 
            this.Estudio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estudio.HeaderText = "Estudio";
            this.Estudio.Name = "Estudio";
            this.Estudio.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "X";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "X";
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 20;
            // 
            // NroItem
            // 
            this.NroItem.HeaderText = "NroItem";
            this.NroItem.Name = "NroItem";
            this.NroItem.ReadOnly = true;
            this.NroItem.Visible = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.buttonModifica);
            this.metroPanel2.Controls.Add(this.buttonGuardar);
            this.metroPanel2.Controls.Add(this.lblSolicitud);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 415);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(687, 37);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // buttonModifica
            // 
            this.buttonModifica.ActiveControl = null;
            this.buttonModifica.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonModifica.Location = new System.Drawing.Point(473, 0);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(107, 37);
            this.buttonModifica.Style = MetroFramework.MetroColorStyle.Red;
            this.buttonModifica.TabIndex = 8;
            this.buttonModifica.Text = "Modificar";
            this.buttonModifica.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonModifica.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonModifica.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.buttonModifica.UseSelectable = true;
            this.buttonModifica.UseTileImage = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click_1);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.ActiveControl = null;
            this.buttonGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonGuardar.Location = new System.Drawing.Point(580, 0);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(107, 37);
            this.buttonGuardar.Style = MetroFramework.MetroColorStyle.Red;
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGuardar.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonGuardar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.buttonGuardar.UseSelectable = true;
            this.buttonGuardar.UseTileImage = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click_1);
            // 
            // lblSolicitud
            // 
            this.lblSolicitud.AutoSize = true;
            this.lblSolicitud.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSolicitud.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSolicitud.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSolicitud.Location = new System.Drawing.Point(0, 0);
            this.lblSolicitud.Name = "lblSolicitud";
            this.lblSolicitud.Size = new System.Drawing.Size(84, 19);
            this.lblSolicitud.Style = MetroFramework.MetroColorStyle.Red;
            this.lblSolicitud.TabIndex = 3;
            this.lblSolicitud.Text = "lblSolicitud";
            // 
            // dateFecha
            // 
            this.dateFecha.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(18, 24);
            this.dateFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(115, 29);
            this.dateFecha.TabIndex = 1;
            // 
            // chckRutinaIngreso
            // 
            this.chckRutinaIngreso.AutoSize = true;
            this.chckRutinaIngreso.Location = new System.Drawing.Point(869, 39);
            this.chckRutinaIngreso.Name = "chckRutinaIngreso";
            this.chckRutinaIngreso.Size = new System.Drawing.Size(115, 15);
            this.chckRutinaIngreso.Style = MetroFramework.MetroColorStyle.Orange;
            this.chckRutinaIngreso.TabIndex = 2;
            this.chckRutinaIngreso.Text = "Rutina de ingreso";
            this.chckRutinaIngreso.UseSelectable = true;
            this.chckRutinaIngreso.CheckedChanged += new System.EventHandler(this.chckRutinaIngreso_CheckedChanged);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblLeyenda.Location = new System.Drawing.Point(20, 516);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(362, 15);
            this.lblLeyenda.TabIndex = 3;
            this.lblLeyenda.Text = "Los pedidos de estudios realizados previamente no se pueden cambiar";
            // 
            // chckUrgente
            // 
            this.chckUrgente.AutoSize = true;
            this.chckUrgente.Location = new System.Drawing.Point(763, 39);
            this.chckUrgente.Name = "chckUrgente";
            this.chckUrgente.Size = new System.Drawing.Size(65, 15);
            this.chckUrgente.Style = MetroFramework.MetroColorStyle.Red;
            this.chckUrgente.TabIndex = 4;
            this.chckUrgente.Text = "Urgente";
            this.chckUrgente.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(16, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 15);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Fecha de pedido";
            // 
            // PedidoLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 532);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.chckUrgente);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.chckRutinaIngreso);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.panelLab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PedidoLab";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Pedido de analisis de sangre";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.PedidoLab_Load);
            this.panelLab.ResumeLayout(false);
            this.panelLab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelLab;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroDateTime dateFecha;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtObsMedico;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtOtrosAnalisis;
        private MetroFramework.Controls.MetroCheckBox chckRutinaIngreso;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtObsBioq;
        private MetroFramework.Controls.MetroLabel lblSolicitud;
        private MetroFramework.Controls.MetroLabel lblLeyenda;
        private MetroFramework.Controls.MetroCheckBox chckUrgente;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cboAnalisisDeriv;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private MetroFramework.Controls.MetroComboBox cboAnalisisClinica;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile buttonModifica;
        private MetroFramework.Controls.MetroTile buttonGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn estudio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudio;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroItem;
    }
}