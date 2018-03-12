namespace Principal.Forms.Parametros.Medicamento
{
    partial class AsociaCodigoBejerman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsociaCodigoBejerman));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataGridViewMedicamentos = new System.Windows.Forms.DataGridView();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnGuardar = new MetroFramework.Controls.MetroTile();
            this.btnActualiza = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Medicamento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBejerman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewButtonColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dataGridViewMedicamentos);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(668, 636);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dataGridViewMedicamentos
            // 
            this.dataGridViewMedicamentos.AllowUserToAddRows = false;
            this.dataGridViewMedicamentos.AllowUserToDeleteRows = false;
            this.dataGridViewMedicamentos.AllowUserToOrderColumns = true;
            this.dataGridViewMedicamentos.AllowUserToResizeColumns = false;
            this.dataGridViewMedicamentos.AllowUserToResizeRows = false;
            this.dataGridViewMedicamentos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicamento_id,
            this.Medicamento,
            this.Potencia,
            this.presentacion,
            this.UniMed,
            this.CodigoBejerman,
            this.X});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMedicamentos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMedicamentos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMedicamentos.Name = "dataGridViewMedicamentos";
            this.dataGridViewMedicamentos.RowHeadersVisible = false;
            this.dataGridViewMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedicamentos.Size = new System.Drawing.Size(668, 589);
            this.dataGridViewMedicamentos.TabIndex = 3;
            this.dataGridViewMedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicamentos_CellContentClick);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnGuardar);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 589);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(668, 47);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveControl = null;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.Location = new System.Drawing.Point(540, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(128, 47);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualiza
            // 
            this.btnActualiza.ActiveControl = null;
            this.btnActualiza.Location = new System.Drawing.Point(20, 20);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(90, 38);
            this.btnActualiza.Style = MetroFramework.MetroColorStyle.Green;
            this.btnActualiza.TabIndex = 1;
            this.btnActualiza.Text = "Actualizar";
            this.btnActualiza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualiza.UseSelectable = true;
            this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(491, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Medicamento_id
            // 
            this.Medicamento_id.HeaderText = "Medicamento_id";
            this.Medicamento_id.Name = "Medicamento_id";
            this.Medicamento_id.Visible = false;
            // 
            // Medicamento
            // 
            this.Medicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medicamento.HeaderText = "Medicamento";
            this.Medicamento.Name = "Medicamento";
            this.Medicamento.ReadOnly = true;
            // 
            // Potencia
            // 
            this.Potencia.HeaderText = "Potencia";
            this.Potencia.Name = "Potencia";
            this.Potencia.ReadOnly = true;
            // 
            // presentacion
            // 
            this.presentacion.HeaderText = "Presentacion";
            this.presentacion.Name = "presentacion";
            this.presentacion.ReadOnly = true;
            // 
            // UniMed
            // 
            this.UniMed.HeaderText = "UniMed";
            this.UniMed.Name = "UniMed";
            this.UniMed.ReadOnly = true;
            this.UniMed.Width = 80;
            // 
            // CodigoBejerman
            // 
            this.CodigoBejerman.HeaderText = "Cod Bejerman";
            this.CodigoBejerman.Name = "CodigoBejerman";
            // 
            // X
            // 
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.X.Text = "X";
            this.X.ToolTipText = "X";
            this.X.UseColumnTextForButtonValue = true;
            this.X.Width = 20;
            // 
            // AsociaCodigoBejerman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 716);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnActualiza);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AsociaCodigoBejerman";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Medicamentos sin codigo";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AsociaCodigoBejerman_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.DataGridView dataGridViewMedicamentos;
        private MetroFramework.Controls.MetroTile btnGuardar;
        private MetroFramework.Controls.MetroTile btnActualiza;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBejerman;
        private System.Windows.Forms.DataGridViewButtonColumn X;
    }
}