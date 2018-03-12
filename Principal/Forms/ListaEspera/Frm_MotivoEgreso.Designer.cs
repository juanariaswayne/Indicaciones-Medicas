namespace Principal.Forms.ListaEspera
{
    partial class Frm_MotivoEgreso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTileNuevoIngreso = new MetroFramework.Controls.MetroTile();
            this.btnGrabar = new MetroFramework.Controls.MetroTile();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMotivos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxDesde = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.btnSalir.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotivos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroTileNuevoIngreso);
            this.panel1.Controls.Add(this.btnGrabar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 40);
            this.panel1.TabIndex = 25;
            // 
            // metroTileNuevoIngreso
            // 
            this.metroTileNuevoIngreso.ActiveControl = null;
            this.metroTileNuevoIngreso.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroTileNuevoIngreso.Location = new System.Drawing.Point(0, 0);
            this.metroTileNuevoIngreso.Name = "metroTileNuevoIngreso";
            this.metroTileNuevoIngreso.Size = new System.Drawing.Size(116, 38);
            this.metroTileNuevoIngreso.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileNuevoIngreso.TabIndex = 7;
            this.metroTileNuevoIngreso.Text = "Nuevo Ingreso";
            this.metroTileNuevoIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileNuevoIngreso.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTileNuevoIngreso.UseSelectable = true;
            this.metroTileNuevoIngreso.Click += new System.EventHandler(this.metroTileNuevoIngreso_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.ActiveControl = null;
            this.btnGrabar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGrabar.Location = new System.Drawing.Point(732, 0);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(116, 38);
            this.btnGrabar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGrabar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnGrabar.UseSelectable = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveControl = null;
            this.btnSalir.Controls.Add(this.splitter2);
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Location = new System.Drawing.Point(848, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 38);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 38);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 350);
            this.panel2.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewMotivos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(372, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 350);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Morivos creados";
            // 
            // dataGridViewMotivos
            // 
            this.dataGridViewMotivos.AllowUserToAddRows = false;
            this.dataGridViewMotivos.AllowUserToDeleteRows = false;
            this.dataGridViewMotivos.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMotivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMotivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMotivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descripcion,
            this.IdTipo,
            this.TipoMotivo});
            this.dataGridViewMotivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMotivos.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewMotivos.MultiSelect = false;
            this.dataGridViewMotivos.Name = "dataGridViewMotivos";
            this.dataGridViewMotivos.ReadOnly = true;
            this.dataGridViewMotivos.RowHeadersVisible = false;
            this.dataGridViewMotivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMotivos.Size = new System.Drawing.Size(568, 331);
            this.dataGridViewMotivos.TabIndex = 0;
            this.dataGridViewMotivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMotivos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.comboBoxDesde);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.TextBoxDescripcion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 350);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevos Motivos";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Descripción:";
            // 
            // TextBoxDescripcion
            // 
            // 
            // 
            // 
            this.TextBoxDescripcion.CustomButton.Image = null;
            this.TextBoxDescripcion.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.TextBoxDescripcion.CustomButton.Name = "";
            this.TextBoxDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxDescripcion.CustomButton.TabIndex = 1;
            this.TextBoxDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxDescripcion.CustomButton.UseSelectable = true;
            this.TextBoxDescripcion.CustomButton.Visible = false;
            this.TextBoxDescripcion.Lines = new string[0];
            this.TextBoxDescripcion.Location = new System.Drawing.Point(115, 121);
            this.TextBoxDescripcion.MaxLength = 32767;
            this.TextBoxDescripcion.Name = "TextBoxDescripcion";
            this.TextBoxDescripcion.PasswordChar = '\0';
            this.TextBoxDescripcion.PromptText = "Descripción";
            this.TextBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxDescripcion.SelectedText = "";
            this.TextBoxDescripcion.SelectionLength = 0;
            this.TextBoxDescripcion.SelectionStart = 0;
            this.TextBoxDescripcion.ShortcutsEnabled = true;
            this.TextBoxDescripcion.Size = new System.Drawing.Size(238, 23);
            this.TextBoxDescripcion.TabIndex = 0;
            this.TextBoxDescripcion.UseSelectable = true;
            this.TextBoxDescripcion.WaterMark = "Descripción";
            this.TextBoxDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBoxDesde
            // 
            this.comboBoxDesde.FormattingEnabled = true;
            this.comboBoxDesde.Location = new System.Drawing.Point(115, 177);
            this.comboBoxDesde.Name = "comboBoxDesde";
            this.comboBoxDesde.Size = new System.Drawing.Size(238, 21);
            this.comboBoxDesde.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(55, 177);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Para:";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 400;
            // 
            // IdTipo
            // 
            this.IdTipo.HeaderText = "IdTipo";
            this.IdTipo.Name = "IdTipo";
            this.IdTipo.ReadOnly = true;
            this.IdTipo.Visible = false;
            // 
            // TipoMotivo
            // 
            this.TipoMotivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TipoMotivo.DefaultCellStyle = dataGridViewCellStyle3;
            this.TipoMotivo.HeaderText = "TopoMotivo";
            this.TipoMotivo.Name = "TipoMotivo";
            this.TipoMotivo.ReadOnly = true;
            // 
            // Frm_MotivoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_MotivoEgreso";
            this.Text = "Motivos de Egreso (Lista de Espera / Clínica)";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Frm_MotivoEgreso_Load);
            this.panel1.ResumeLayout(false);
            this.btnSalir.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotivos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile metroTileNuevoIngreso;
        private MetroFramework.Controls.MetroTile btnGrabar;
        private MetroFramework.Controls.MetroTile btnSalir;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextBoxDescripcion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewMotivos;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox comboBoxDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMotivo;
    }
}