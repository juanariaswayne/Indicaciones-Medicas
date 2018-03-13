namespace Principal.Forms.ListaEspera
{
    partial class Frm_OtroFactorPonderacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTileNuevoIngreso = new MetroFramework.Controls.MetroTile();
            this.btnGrabar = new MetroFramework.Controls.MetroTile();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewFactores = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxPuntaje = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.btnSalir.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactores)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(20, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 40);
            this.panel1.TabIndex = 24;
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
            this.btnGrabar.Location = new System.Drawing.Point(662, 0);
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
            this.btnSalir.Location = new System.Drawing.Point(778, 0);
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
            this.panel2.Size = new System.Drawing.Size(876, 353);
            this.panel2.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewFactores);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(425, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factores creados";
            // 
            // dataGridViewFactores
            // 
            this.dataGridViewFactores.AllowUserToAddRows = false;
            this.dataGridViewFactores.AllowUserToDeleteRows = false;
            this.dataGridViewFactores.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFactores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFactores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descripcion,
            this.Puntaje});
            this.dataGridViewFactores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFactores.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewFactores.MultiSelect = false;
            this.dataGridViewFactores.Name = "dataGridViewFactores";
            this.dataGridViewFactores.ReadOnly = true;
            this.dataGridViewFactores.RowHeadersVisible = false;
            this.dataGridViewFactores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFactores.Size = new System.Drawing.Size(445, 334);
            this.dataGridViewFactores.TabIndex = 0;
            this.dataGridViewFactores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFactores_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.TextBoxPuntaje);
            this.groupBox1.Controls.Add(this.TextBoxDescripcion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevos Factores";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(88, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Puntaje:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(72, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Descripción:";
            // 
            // TextBoxPuntaje
            // 
            // 
            // 
            // 
            this.TextBoxPuntaje.CustomButton.Image = null;
            this.TextBoxPuntaje.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.TextBoxPuntaje.CustomButton.Name = "";
            this.TextBoxPuntaje.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxPuntaje.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxPuntaje.CustomButton.TabIndex = 1;
            this.TextBoxPuntaje.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxPuntaje.CustomButton.UseSelectable = true;
            this.TextBoxPuntaje.CustomButton.Visible = false;
            this.TextBoxPuntaje.Lines = new string[] {
        "Puntaje"};
            this.TextBoxPuntaje.Location = new System.Drawing.Point(173, 130);
            this.TextBoxPuntaje.MaxLength = 32767;
            this.TextBoxPuntaje.Name = "TextBoxPuntaje";
            this.TextBoxPuntaje.PasswordChar = '\0';
            this.TextBoxPuntaje.PromptText = "Puntaje";
            this.TextBoxPuntaje.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxPuntaje.SelectedText = "";
            this.TextBoxPuntaje.SelectionLength = 0;
            this.TextBoxPuntaje.SelectionStart = 0;
            this.TextBoxPuntaje.ShortcutsEnabled = true;
            this.TextBoxPuntaje.Size = new System.Drawing.Size(120, 23);
            this.TextBoxPuntaje.TabIndex = 1;
            this.TextBoxPuntaje.Text = "Puntaje";
            this.TextBoxPuntaje.UseSelectable = true;
            this.TextBoxPuntaje.WaterMark = "Puntaje";
            this.TextBoxPuntaje.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxPuntaje.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxPuntaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPuntaje_KeyPress);
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
            this.TextBoxDescripcion.Location = new System.Drawing.Point(173, 68);
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
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle5;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Puntaje.DefaultCellStyle = dataGridViewCellStyle6;
            this.Puntaje.HeaderText = "Puntaje";
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.ReadOnly = true;
            // 
            // Frm_OtroFactorPonderacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_OtroFactorPonderacion";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Otros Factores de ponderación (Puntaje lista de Espera)";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Frm_OtroFactorPonderacion_Load);
            this.panel1.ResumeLayout(false);
            this.btnSalir.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactores)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewFactores;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextBoxPuntaje;
        private MetroFramework.Controls.MetroTextBox TextBoxDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
    }
}