namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento
{
    partial class SeleccionarMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarMedicamento));
            this.metroTextBoxBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewMedicamentos = new System.Windows.Forms.DataGridView();
            this.medicamentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Droga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSolMed = new MetroFramework.Controls.MetroTile();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBoxBuscar
            // 
            // 
            // 
            // 
            this.metroTextBoxBuscar.CustomButton.Image = null;
            this.metroTextBoxBuscar.CustomButton.Location = new System.Drawing.Point(509, 1);
            this.metroTextBoxBuscar.CustomButton.Name = "";
            this.metroTextBoxBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxBuscar.CustomButton.TabIndex = 1;
            this.metroTextBoxBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxBuscar.CustomButton.UseSelectable = true;
            this.metroTextBoxBuscar.CustomButton.Visible = false;
            this.metroTextBoxBuscar.Lines = new string[0];
            this.metroTextBoxBuscar.Location = new System.Drawing.Point(10, 23);
            this.metroTextBoxBuscar.MaxLength = 32767;
            this.metroTextBoxBuscar.Name = "metroTextBoxBuscar";
            this.metroTextBoxBuscar.PasswordChar = '\0';
            this.metroTextBoxBuscar.PromptText = "Ingrese aqui el medicamento a buscar";
            this.metroTextBoxBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxBuscar.SelectedText = "";
            this.metroTextBoxBuscar.SelectionLength = 0;
            this.metroTextBoxBuscar.SelectionStart = 0;
            this.metroTextBoxBuscar.ShortcutsEnabled = true;
            this.metroTextBoxBuscar.Size = new System.Drawing.Size(531, 23);
            this.metroTextBoxBuscar.TabIndex = 0;
            this.metroTextBoxBuscar.UseSelectable = true;
            this.metroTextBoxBuscar.WaterMark = "Ingrese aqui el medicamento a buscar";
            this.metroTextBoxBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxBuscar.TextChanged += new System.EventHandler(this.metroTextBoxBuscar_TextChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroCheckBox1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroTextBoxBuscar);
            this.metroPanel1.Controls.Add(this.dataGridViewMedicamentos);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(734, 476);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(210, 63);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(302, 15);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Doble click para seleccionar el medicamento a indicar";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(556, 31);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(175, 15);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroCheckBox1.TabIndex = 6;
            this.metroCheckBox1.Text = "Solo medicamentos en stock";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(9, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 15);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Buscar medicamento";
            // 
            // dataGridViewMedicamentos
            // 
            this.dataGridViewMedicamentos.AllowUserToAddRows = false;
            this.dataGridViewMedicamentos.AllowUserToDeleteRows = false;
            this.dataGridViewMedicamentos.AllowUserToResizeColumns = false;
            this.dataGridViewMedicamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            this.dataGridViewMedicamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMedicamentos.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicamentoID,
            this.Droga,
            this.Potencia,
            this.Presentacion,
            this.enStock});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMedicamentos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMedicamentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewMedicamentos.Location = new System.Drawing.Point(0, 81);
            this.dataGridViewMedicamentos.MultiSelect = false;
            this.dataGridViewMedicamentos.Name = "dataGridViewMedicamentos";
            this.dataGridViewMedicamentos.RowHeadersVisible = false;
            this.dataGridViewMedicamentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedicamentos.Size = new System.Drawing.Size(734, 395);
            this.dataGridViewMedicamentos.TabIndex = 3;
            this.dataGridViewMedicamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicamentos_CellDoubleClick);
            // 
            // medicamentoID
            // 
            this.medicamentoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medicamentoID.HeaderText = "medicamentoID";
            this.medicamentoID.Name = "medicamentoID";
            this.medicamentoID.ReadOnly = true;
            this.medicamentoID.Visible = false;
            // 
            // Droga
            // 
            this.Droga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Droga.FillWeight = 203.0457F;
            this.Droga.HeaderText = "Droga";
            this.Droga.Name = "Droga";
            this.Droga.ReadOnly = true;
            // 
            // Potencia
            // 
            this.Potencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Potencia.FillWeight = 65.65145F;
            this.Potencia.HeaderText = "Potencia";
            this.Potencia.Name = "Potencia";
            this.Potencia.ReadOnly = true;
            // 
            // Presentacion
            // 
            this.Presentacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Presentacion.FillWeight = 65.65145F;
            this.Presentacion.HeaderText = "Presentacion";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            // 
            // enStock
            // 
            this.enStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enStock.FillWeight = 65.65145F;
            this.enStock.HeaderText = "En Stock";
            this.enStock.Name = "enStock";
            this.enStock.ReadOnly = true;
            this.enStock.Visible = false;
            // 
            // btnSolMed
            // 
            this.btnSolMed.ActiveControl = null;
            this.btnSolMed.Location = new System.Drawing.Point(23, 542);
            this.btnSolMed.Name = "btnSolMed";
            this.btnSolMed.Size = new System.Drawing.Size(199, 39);
            this.btnSolMed.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSolMed.TabIndex = 11;
            this.btnSolMed.Text = "El medicamento no esta en la lista";
            this.btnSolMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSolMed.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnSolMed.UseSelectable = true;
            this.btnSolMed.Click += new System.EventHandler(this.btnSolMed_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveControl = null;
            this.btnSalir.Location = new System.Drawing.Point(682, 542);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 39);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // SeleccionarMedicamento
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 584);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnSolMed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "SeleccionarMedicamento";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Seleccione un Medicamento";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.SeleccionarMedicamento_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxBuscar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dataGridViewMedicamentos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Droga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn enStock;
        private MetroFramework.Controls.MetroTile btnSolMed;
        private MetroFramework.Controls.MetroTile btnSalir;
    }
}