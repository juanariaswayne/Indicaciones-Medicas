namespace Principal.Forms.ListaEspera
{
    partial class Frm_Derivacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroTileNuevo = new MetroFramework.Controls.MetroTile();
            this.btnGrabar = new MetroFramework.Controls.MetroTile();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewDerivaciones = new System.Windows.Forms.DataGridView();
            this.DerivaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDerivaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.metroTileNuevo);
            this.panel2.Controls.Add(this.btnGrabar);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 40);
            this.panel2.TabIndex = 25;
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
            this.btnGrabar.Location = new System.Drawing.Point(664, 0);
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
            this.btnSalir.Location = new System.Drawing.Point(780, 0);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.TextBoxDescripcion);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewDerivaciones);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(878, 355);
            this.splitContainer1.SplitterDistance = 425;
            this.splitContainer1.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 31);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Editar / Crear Derivación";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 31);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Derivaciones Creadas";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 165);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Descripción:";
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
            this.TextBoxDescripcion.Location = new System.Drawing.Point(101, 163);
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
            this.TextBoxDescripcion.TabIndex = 4;
            this.TextBoxDescripcion.UseSelectable = true;
            this.TextBoxDescripcion.WaterMark = "Descripción";
            this.TextBoxDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridViewDerivaciones
            // 
            this.dataGridViewDerivaciones.AllowUserToAddRows = false;
            this.dataGridViewDerivaciones.AllowUserToDeleteRows = false;
            this.dataGridViewDerivaciones.AllowUserToResizeRows = false;
            this.dataGridViewDerivaciones.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDerivaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewDerivaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDerivaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DerivaId,
            this.Descripcion});
            this.dataGridViewDerivaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDerivaciones.Location = new System.Drawing.Point(0, 31);
            this.dataGridViewDerivaciones.MultiSelect = false;
            this.dataGridViewDerivaciones.Name = "dataGridViewDerivaciones";
            this.dataGridViewDerivaciones.ReadOnly = true;
            this.dataGridViewDerivaciones.RowHeadersVisible = false;
            this.dataGridViewDerivaciones.Size = new System.Drawing.Size(449, 324);
            this.dataGridViewDerivaciones.TabIndex = 2;
            this.dataGridViewDerivaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDerivaciones_CellClick);
            // 
            // DerivaId
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DerivaId.DefaultCellStyle = dataGridViewCellStyle11;
            this.DerivaId.HeaderText = "Deriva";
            this.DerivaId.Name = "DerivaId";
            this.DerivaId.ReadOnly = true;
            this.DerivaId.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle12;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Frm_Derivacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 475);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_Derivacion";
            this.Text = "Origen Derivación";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Frm_Derivacion_Load);
            this.panel2.ResumeLayout(false);
            this.btnSalir.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDerivaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTile metroTileNuevo;
        private MetroFramework.Controls.MetroTile btnGrabar;
        private MetroFramework.Controls.MetroTile btnSalir;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TextBoxDescripcion;
        private System.Windows.Forms.DataGridView dataGridViewDerivaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn DerivaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}