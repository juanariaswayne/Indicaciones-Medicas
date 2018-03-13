namespace Principal.Forms.MapaCama.Paciente.Ficha.Laboratorio
{
    partial class ResultadosLab
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
            this.panelLab = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.solicitud_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_idRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.id_solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtrosEstudios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevoPedido = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panelLab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLab
            // 
            this.panelLab.Controls.Add(this.groupBox2);
            this.panelLab.Controls.Add(this.groupBox1);
            this.panelLab.Controls.Add(this.panel1);
            this.panelLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLab.Location = new System.Drawing.Point(20, 60);
            this.panelLab.Name = "panelLab";
            this.panelLab.Size = new System.Drawing.Size(1005, 359);
            this.panelLab.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewResultados);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(464, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 320);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados de analisis";
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.AllowUserToAddRows = false;
            this.dataGridViewResultados.AllowUserToDeleteRows = false;
            this.dataGridViewResultados.AllowUserToResizeColumns = false;
            this.dataGridViewResultados.AllowUserToResizeRows = false;
            this.dataGridViewResultados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.solicitud_id,
            this.orden_id,
            this.Fecha,
            this.TipoRes,
            this.Estado,
            this.usuario_idRes});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResultados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResultados.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.ReadOnly = true;
            this.dataGridViewResultados.RowHeadersVisible = false;
            this.dataGridViewResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResultados.Size = new System.Drawing.Size(535, 301);
            this.dataGridViewResultados.TabIndex = 0;
            this.dataGridViewResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResultados_CellDoubleClick);
            // 
            // solicitud_id
            // 
            this.solicitud_id.HeaderText = "Num. Solicitud";
            this.solicitud_id.Name = "solicitud_id";
            this.solicitud_id.ReadOnly = true;
            // 
            // orden_id
            // 
            this.orden_id.HeaderText = "Num. Orden";
            this.orden_id.Name = "orden_id";
            this.orden_id.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 80;
            // 
            // TipoRes
            // 
            this.TipoRes.HeaderText = "Tipo";
            this.TipoRes.Name = "TipoRes";
            this.TipoRes.ReadOnly = true;
            this.TipoRes.Width = 70;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // usuario_idRes
            // 
            this.usuario_idRes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usuario_idRes.HeaderText = "Solicito";
            this.usuario_idRes.Name = "usuario_idRes";
            this.usuario_idRes.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewPedidos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos de orden pendientes";
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToAddRows = false;
            this.dataGridViewPedidos.AllowUserToDeleteRows = false;
            this.dataGridViewPedidos.AllowUserToResizeColumns = false;
            this.dataGridViewPedidos.AllowUserToResizeRows = false;
            this.dataGridViewPedidos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_solicitud,
            this.fechaSolicitud,
            this.tipo,
            this.Obs,
            this.OtrosEstudios,
            this.EstadoSol,
            this.usuario_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.ReadOnly = true;
            this.dataGridViewPedidos.RowHeadersVisible = false;
            this.dataGridViewPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(458, 301);
            this.dataGridViewPedidos.TabIndex = 0;
            this.dataGridViewPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidos_CellDoubleClick);
            // 
            // id_solicitud
            // 
            this.id_solicitud.HeaderText = "Num. Solicitud";
            this.id_solicitud.Name = "id_solicitud";
            this.id_solicitud.ReadOnly = true;
            // 
            // fechaSolicitud
            // 
            this.fechaSolicitud.HeaderText = "Fecha";
            this.fechaSolicitud.Name = "fechaSolicitud";
            this.fechaSolicitud.ReadOnly = true;
            this.fechaSolicitud.Width = 70;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 90;
            // 
            // Obs
            // 
            this.Obs.HeaderText = "Obs";
            this.Obs.Name = "Obs";
            this.Obs.ReadOnly = true;
            this.Obs.Visible = false;
            // 
            // OtrosEstudios
            // 
            this.OtrosEstudios.HeaderText = "OtrosEstudios";
            this.OtrosEstudios.Name = "OtrosEstudios";
            this.OtrosEstudios.ReadOnly = true;
            this.OtrosEstudios.Visible = false;
            // 
            // EstadoSol
            // 
            this.EstadoSol.HeaderText = "Estado";
            this.EstadoSol.Name = "EstadoSol";
            this.EstadoSol.ReadOnly = true;
            // 
            // usuario_id
            // 
            this.usuario_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usuario_id.HeaderText = "Solicita";
            this.usuario_id.Name = "usuario_id";
            this.usuario_id.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNuevoPedido);
            this.panel1.Controls.Add(this.metroTile2);
            this.panel1.Controls.Add(this.metroTile1);
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 39);
            this.panel1.TabIndex = 1;
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.ActiveControl = null;
            this.btnNuevoPedido.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevoPedido.Location = new System.Drawing.Point(862, 0);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(143, 39);
            this.btnNuevoPedido.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnNuevoPedido.TabIndex = 4;
            this.btnNuevoPedido.Text = "Nuevo Pedido";
            this.btnNuevoPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevoPedido.TileImage = global::Principal.Properties.Resources.add;
            this.btnNuevoPedido.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoPedido.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnNuevoPedido.UseSelectable = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            this.btnNuevoPedido.MouseEnter += new System.EventHandler(this.btnNuevoPedido_MouseEnter);
            this.btnNuevoPedido.MouseLeave += new System.EventHandler(this.btnNuevoPedido_MouseLeave);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroTile2.Location = new System.Drawing.Point(476, 0);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(140, 39);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "Imprimir Resultado";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(190, 34);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Imprimir solicitud pendiente";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(476, 39);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ResultadosLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 439);
            this.Controls.Add(this.panelLab);
            this.Name = "ResultadosLab";
            this.Text = "ResultadosLab";
            this.Load += new System.EventHandler(this.ResultadosLab_Load);
            this.panelLab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelLab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_solicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtrosEstudios;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitud_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_idRes;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnNuevoPedido;
    }
}