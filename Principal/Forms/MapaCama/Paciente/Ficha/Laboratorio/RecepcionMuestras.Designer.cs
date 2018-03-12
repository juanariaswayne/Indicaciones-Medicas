namespace Principal.Forms.MapaCama.Paciente.Ficha.Laboratorio
{
    partial class RecepcionMuestras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecepcionMuestras));
            this.panelMuestras = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeDesde = new MetroFramework.Controls.MetroDateTime();
            this.dateTimeHasta = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chckSelectAll = new MetroFramework.Controls.MetroCheckBox();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.dataGridViewEstudios = new System.Windows.Forms.DataGridView();
            this.estudio_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new MetroFramework.Controls.MetroTile();
            this.Recibido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitud_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paciente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OtrosEstudios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsBioq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMuestras.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMuestras
            // 
            this.panelMuestras.Controls.Add(this.groupBox2);
            this.panelMuestras.Controls.Add(this.groupBox1);
            this.panelMuestras.Controls.Add(this.metroPanel1);
            this.panelMuestras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMuestras.HorizontalScrollbarBarColor = true;
            this.panelMuestras.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMuestras.HorizontalScrollbarSize = 10;
            this.panelMuestras.Location = new System.Drawing.Point(20, 60);
            this.panelMuestras.Name = "panelMuestras";
            this.panelMuestras.Size = new System.Drawing.Size(1143, 471);
            this.panelMuestras.TabIndex = 0;
            this.panelMuestras.VerticalScrollbarBarColor = true;
            this.panelMuestras.VerticalScrollbarHighlightOnWheel = false;
            this.panelMuestras.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnImprimir);
            this.metroPanel1.Controls.Add(this.chckSelectAll);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 435);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1143, 36);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewPedidos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 435);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido de estudio por pacientes";
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(20, 22);
            this.dateTimeDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(109, 29);
            this.dateTimeDesde.TabIndex = 1;
            this.dateTimeDesde.ValueChanged += new System.EventHandler(this.dateTimeDesde_ValueChanged);
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(135, 22);
            this.dateTimeHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(109, 29);
            this.dateTimeHasta.TabIndex = 2;
            this.dateTimeHasta.ValueChanged += new System.EventHandler(this.dateTimeHasta_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(18, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 15);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Fecha desde";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(133, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 15);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Fecha hasta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewEstudios);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(877, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 435);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // chckSelectAll
            // 
            this.chckSelectAll.AutoSize = true;
            this.chckSelectAll.Location = new System.Drawing.Point(9, 10);
            this.chckSelectAll.Name = "chckSelectAll";
            this.chckSelectAll.Size = new System.Drawing.Size(116, 15);
            this.chckSelectAll.Style = MetroFramework.MetroColorStyle.Silver;
            this.chckSelectAll.TabIndex = 2;
            this.chckSelectAll.Text = "Seleccionar todos";
            this.chckSelectAll.UseSelectable = true;
            this.chckSelectAll.CheckedChanged += new System.EventHandler(this.chckSelectAll_CheckedChanged);
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
            this.Recibido,
            this.Fecha,
            this.solicitud_id,
            this.ID_TIPO,
            this.Tipo,
            this.usuario_id,
            this.paciente_id,
            this.Paciente,
            this.hab,
            this.Estado,
            this.OtrosEstudios,
            this.ObsMed,
            this.ObsBioq,
            this.U_ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.RowHeadersVisible = false;
            this.dataGridViewPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(871, 416);
            this.dataGridViewPedidos.TabIndex = 1;
            this.dataGridViewPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidos_CellClick);
            // 
            // dataGridViewEstudios
            // 
            this.dataGridViewEstudios.AllowUserToAddRows = false;
            this.dataGridViewEstudios.AllowUserToDeleteRows = false;
            this.dataGridViewEstudios.AllowUserToOrderColumns = true;
            this.dataGridViewEstudios.AllowUserToResizeColumns = false;
            this.dataGridViewEstudios.AllowUserToResizeRows = false;
            this.dataGridViewEstudios.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estudio_id,
            this.Estudio});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEstudios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEstudios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEstudios.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewEstudios.Name = "dataGridViewEstudios";
            this.dataGridViewEstudios.RowHeadersVisible = false;
            this.dataGridViewEstudios.Size = new System.Drawing.Size(260, 416);
            this.dataGridViewEstudios.TabIndex = 0;
            // 
            // estudio_id
            // 
            this.estudio_id.HeaderText = "estudio_id";
            this.estudio_id.Name = "estudio_id";
            this.estudio_id.Visible = false;
            // 
            // Estudio
            // 
            this.Estudio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estudio.HeaderText = "Estudio";
            this.Estudio.Name = "Estudio";
            // 
            // btnImprimir
            // 
            this.btnImprimir.ActiveControl = null;
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimir.Location = new System.Drawing.Point(1043, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 36);
            this.btnImprimir.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnImprimir.UseSelectable = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Recibido
            // 
            this.Recibido.HeaderText = "Imprimir";
            this.Recibido.Name = "Recibido";
            this.Recibido.Width = 60;
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
            this.usuario_id.HeaderText = "Medico Sol.";
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
            // Estado
            // 
            this.Estado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = false;
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
            // RecepcionMuestras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 551);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dateTimeHasta);
            this.Controls.Add(this.dateTimeDesde);
            this.Controls.Add(this.panelMuestras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecepcionMuestras";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Generacion de muestras";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecepcionMuestras_FormClosed);
            this.Load += new System.EventHandler(this.RecepcionMuestras_Load);
            this.panelMuestras.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelMuestras;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime dateTimeDesde;
        private MetroFramework.Controls.MetroDateTime dateTimeHasta;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroCheckBox chckSelectAll;
        private System.Windows.Forms.DataGridView dataGridViewEstudios;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn estudio_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudio;
        private MetroFramework.Controls.MetroTile btnImprimir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Recibido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitud_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn hab;
        private System.Windows.Forms.DataGridViewComboBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtrosEstudios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsBioq;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ID;
    }
}