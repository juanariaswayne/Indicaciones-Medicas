namespace Principal.Forms.ListaEspera
{
    partial class Frm_ModuloEmpresa
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelModulo = new System.Windows.Forms.Label();
            this.TextBoxPuntaje = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxCodigo = new MetroFramework.Controls.MetroTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewModulos = new System.Windows.Forms.DataGridView();
            this.moduloId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroTileNuevo = new MetroFramework.Controls.MetroTile();
            this.btnGrabar = new MetroFramework.Controls.MetroTile();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModulos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 417);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewModulos);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(966, 377);
            this.splitContainer1.SplitterDistance = 415;
            this.splitContainer1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelModulo);
            this.groupBox1.Controls.Add(this.TextBoxPuntaje);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.TextBoxDescripcion);
            this.groupBox1.Controls.Add(this.TextBoxCodigo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 346);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // labelModulo
            // 
            this.labelModulo.AutoSize = true;
            this.labelModulo.Location = new System.Drawing.Point(81, 31);
            this.labelModulo.Name = "labelModulo";
            this.labelModulo.Size = new System.Drawing.Size(0, 13);
            this.labelModulo.TabIndex = 12;
            this.labelModulo.Visible = false;
            // 
            // TextBoxPuntaje
            // 
            // 
            // 
            // 
            this.TextBoxPuntaje.CustomButton.Image = null;
            this.TextBoxPuntaje.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.TextBoxPuntaje.CustomButton.Name = "";
            this.TextBoxPuntaje.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxPuntaje.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxPuntaje.CustomButton.TabIndex = 1;
            this.TextBoxPuntaje.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxPuntaje.CustomButton.UseSelectable = true;
            this.TextBoxPuntaje.CustomButton.Visible = false;
            this.TextBoxPuntaje.Lines = new string[0];
            this.TextBoxPuntaje.Location = new System.Drawing.Point(107, 238);
            this.TextBoxPuntaje.MaxLength = 3;
            this.TextBoxPuntaje.Name = "TextBoxPuntaje";
            this.TextBoxPuntaje.PasswordChar = '\0';
            this.TextBoxPuntaje.PromptText = "Puntaje";
            this.TextBoxPuntaje.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPuntaje.SelectedText = "";
            this.TextBoxPuntaje.SelectionLength = 0;
            this.TextBoxPuntaje.SelectionStart = 0;
            this.TextBoxPuntaje.ShortcutsEnabled = true;
            this.TextBoxPuntaje.Size = new System.Drawing.Size(104, 23);
            this.TextBoxPuntaje.TabIndex = 11;
            this.TextBoxPuntaje.UseSelectable = true;
            this.TextBoxPuntaje.WaterMark = "Puntaje";
            this.TextBoxPuntaje.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxPuntaje.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxPuntaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPuntaje_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(48, 240);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Puntaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "(Código de 3 dígitos)";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Descripción:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Código:";
            // 
            // TextBoxDescripcion
            // 
            // 
            // 
            // 
            this.TextBoxDescripcion.CustomButton.Image = null;
            this.TextBoxDescripcion.CustomButton.Location = new System.Drawing.Point(275, 1);
            this.TextBoxDescripcion.CustomButton.Name = "";
            this.TextBoxDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxDescripcion.CustomButton.TabIndex = 1;
            this.TextBoxDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxDescripcion.CustomButton.UseSelectable = true;
            this.TextBoxDescripcion.CustomButton.Visible = false;
            this.TextBoxDescripcion.Lines = new string[0];
            this.TextBoxDescripcion.Location = new System.Drawing.Point(107, 149);
            this.TextBoxDescripcion.MaxLength = 32767;
            this.TextBoxDescripcion.Name = "TextBoxDescripcion";
            this.TextBoxDescripcion.PasswordChar = '\0';
            this.TextBoxDescripcion.PromptText = "Descripción";
            this.TextBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxDescripcion.SelectedText = "";
            this.TextBoxDescripcion.SelectionLength = 0;
            this.TextBoxDescripcion.SelectionStart = 0;
            this.TextBoxDescripcion.ShortcutsEnabled = true;
            this.TextBoxDescripcion.Size = new System.Drawing.Size(297, 23);
            this.TextBoxDescripcion.TabIndex = 1;
            this.TextBoxDescripcion.UseSelectable = true;
            this.TextBoxDescripcion.WaterMark = "Descripción";
            this.TextBoxDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxCodigo
            // 
            // 
            // 
            // 
            this.TextBoxCodigo.CustomButton.Image = null;
            this.TextBoxCodigo.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.TextBoxCodigo.CustomButton.Name = "";
            this.TextBoxCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxCodigo.CustomButton.TabIndex = 1;
            this.TextBoxCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxCodigo.CustomButton.UseSelectable = true;
            this.TextBoxCodigo.CustomButton.Visible = false;
            this.TextBoxCodigo.Lines = new string[0];
            this.TextBoxCodigo.Location = new System.Drawing.Point(107, 69);
            this.TextBoxCodigo.MaxLength = 3;
            this.TextBoxCodigo.Name = "TextBoxCodigo";
            this.TextBoxCodigo.PasswordChar = '\0';
            this.TextBoxCodigo.PromptText = "Código";
            this.TextBoxCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxCodigo.SelectedText = "";
            this.TextBoxCodigo.SelectionLength = 0;
            this.TextBoxCodigo.SelectionStart = 0;
            this.TextBoxCodigo.ShortcutsEnabled = true;
            this.TextBoxCodigo.Size = new System.Drawing.Size(104, 23);
            this.TextBoxCodigo.TabIndex = 0;
            this.TextBoxCodigo.UseSelectable = true;
            this.TextBoxCodigo.WaterMark = "Código";
            this.TextBoxCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCodigo_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 31);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Editar / Crear Módulo";
            // 
            // dataGridViewModulos
            // 
            this.dataGridViewModulos.AllowUserToAddRows = false;
            this.dataGridViewModulos.AllowUserToDeleteRows = false;
            this.dataGridViewModulos.AllowUserToResizeRows = false;
            this.dataGridViewModulos.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewModulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moduloId,
            this.Descripcion,
            this.Puntaje});
            this.dataGridViewModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewModulos.Location = new System.Drawing.Point(0, 31);
            this.dataGridViewModulos.MultiSelect = false;
            this.dataGridViewModulos.Name = "dataGridViewModulos";
            this.dataGridViewModulos.ReadOnly = true;
            this.dataGridViewModulos.RowHeadersVisible = false;
            this.dataGridViewModulos.Size = new System.Drawing.Size(547, 346);
            this.dataGridViewModulos.TabIndex = 1;
            this.dataGridViewModulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModulos_CellClick);
            this.dataGridViewModulos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewModulos_CurrentCellDirtyStateChanged);
            // 
            // moduloId
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.moduloId.DefaultCellStyle = dataGridViewCellStyle2;
            this.moduloId.HeaderText = "Código";
            this.moduloId.Name = "moduloId";
            this.moduloId.ReadOnly = true;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Puntaje.DefaultCellStyle = dataGridViewCellStyle4;
            this.Puntaje.HeaderText = "Puntaje";
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 31);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Módulos Creados";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.metroTileNuevo);
            this.panel2.Controls.Add(this.btnGrabar);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 40);
            this.panel2.TabIndex = 24;
            // 
            // metroTileNuevo
            // 
            this.metroTileNuevo.ActiveControl = null;
            this.metroTileNuevo.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroTileNuevo.Location = new System.Drawing.Point(0, 0);
            this.metroTileNuevo.Name = "metroTileNuevo";
            this.metroTileNuevo.Size = new System.Drawing.Size(116, 38);
            this.metroTileNuevo.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileNuevo.TabIndex = 7;
            this.metroTileNuevo.Text = "Nuevo Ingreso";
            this.metroTileNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileNuevo.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTileNuevo.UseSelectable = true;
            this.metroTileNuevo.Click += new System.EventHandler(this.metroTileNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.ActiveControl = null;
            this.btnGrabar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGrabar.Location = new System.Drawing.Point(752, 0);
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
            this.btnSalir.Location = new System.Drawing.Point(868, 0);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_ModuloEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 497);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ModuloEmpresa";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Módulos";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Frm_ModuloEmpresa_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModulos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTile btnGrabar;
        private MetroFramework.Controls.MetroTile btnSalir;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView dataGridViewModulos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextBoxDescripcion;
        private MetroFramework.Controls.MetroTextBox TextBoxCodigo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTile metroTileNuevo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox TextBoxPuntaje;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduloId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
        private System.Windows.Forms.Label labelModulo;
    }
}