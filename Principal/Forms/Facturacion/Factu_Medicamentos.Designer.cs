namespace Principal.Forms.Facturacion
{
    partial class Factu_Medicamentos
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
            this.dateDesde = new MetroFramework.Controls.MetroDateTime();
            this.dateHasta = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataGridViewMedicamentos = new System.Windows.Forms.DataGridView();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diluyente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateDesde
            // 
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDesde.Location = new System.Drawing.Point(23, 28);
            this.dateDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(107, 29);
            this.dateDesde.TabIndex = 0;
            this.dateDesde.ValueChanged += new System.EventHandler(this.dateDesde_ValueChanged);
            // 
            // dateHasta
            // 
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHasta.Location = new System.Drawing.Point(136, 28);
            this.dateHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(107, 29);
            this.dateHasta.TabIndex = 1;
            this.dateHasta.ValueChanged += new System.EventHandler(this.dateHasta_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Desde";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(136, 7);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Hasta";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dataGridViewMedicamentos);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1292, 590);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dataGridViewMedicamentos
            // 
            this.dataGridViewMedicamentos.AllowUserToAddRows = false;
            this.dataGridViewMedicamentos.AllowUserToDeleteRows = false;
            this.dataGridViewMedicamentos.AllowUserToOrderColumns = true;
            this.dataGridViewMedicamentos.AllowUserToResizeRows = false;
            this.dataGridViewMedicamentos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Inicio,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.Diluyente,
            this.ML,
            this.dataGridViewTextBoxColumn7,
            this.DIA,
            this.OBS_3,
            this.FIN,
            this.MEDICO,
            this.check});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMedicamentos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMedicamentos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMedicamentos.MultiSelect = false;
            this.dataGridViewMedicamentos.Name = "dataGridViewMedicamentos";
            this.dataGridViewMedicamentos.RowHeadersVisible = false;
            this.dataGridViewMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedicamentos.Size = new System.Drawing.Size(1292, 590);
            this.dataGridViewMedicamentos.TabIndex = 15;
            this.dataGridViewMedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicamentos_CellContentClick);
            this.dataGridViewMedicamentos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicamentos_CellValueChanged);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroTile1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 650);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1292, 45);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroTile1.Location = new System.Drawing.Point(1076, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(216, 45);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Imprimir medicacion historico";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Inicio
            // 
            this.Inicio.HeaderText = "INICIO";
            this.Inicio.Name = "Inicio";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_SUM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "PRODUCTO_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "MEDICAMENTO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "DOSIS";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "VIA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // Diluyente
            // 
            this.Diluyente.HeaderText = "DIL.";
            this.Diluyente.Name = "Diluyente";
            this.Diluyente.Width = 80;
            // 
            // ML
            // 
            this.ML.HeaderText = "ML";
            this.ML.Name = "ML";
            this.ML.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "HORARIO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // DIA
            // 
            this.DIA.HeaderText = "DIAS";
            this.DIA.Name = "DIA";
            this.DIA.ReadOnly = true;
            // 
            // OBS_3
            // 
            this.OBS_3.HeaderText = "OBS";
            this.OBS_3.Name = "OBS_3";
            this.OBS_3.ReadOnly = true;
            this.OBS_3.Width = 150;
            // 
            // FIN
            // 
            this.FIN.HeaderText = "FIN";
            this.FIN.Name = "FIN";
            // 
            // MEDICO
            // 
            this.MEDICO.HeaderText = "MED.";
            this.MEDICO.Name = "MEDICO";
            // 
            // check
            // 
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.check.HeaderText = "IMP";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.Width = 30;
            // 
            // Factu_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 715);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Name = "Factu_Medicamentos";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Medicamentos indicados";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Factu_Medicamentos_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dateDesde;
        private MetroFramework.Controls.MetroDateTime dateHasta;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.DataGridView dataGridViewMedicamentos;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diluyente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ML;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDICO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}