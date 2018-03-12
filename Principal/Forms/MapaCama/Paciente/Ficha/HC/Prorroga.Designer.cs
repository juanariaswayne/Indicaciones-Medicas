namespace Principal.Forms.MapaCama.Paciente.Ficha.HC
{
    partial class Prorroga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prorroga));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProrroga = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboTipo = new MetroFramework.Controls.MetroComboBox();
            this.dataGridViewProrrogas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.panelProrrogas = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProrrogas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelProrrogas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProrroga);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.dataGridViewProrrogas);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prorrogas / Resumen";
            // 
            // txtProrroga
            // 
            this.txtProrroga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProrroga.Lines = new string[0];
            this.txtProrroga.Location = new System.Drawing.Point(351, 56);
            this.txtProrroga.MaxLength = 32767;
            this.txtProrroga.Multiline = true;
            this.txtProrroga.Name = "txtProrroga";
            this.txtProrroga.PasswordChar = '\0';
            this.txtProrroga.PromptText = "Ingrese aqui el texto";
            this.txtProrroga.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProrroga.SelectedText = "";
            this.txtProrroga.Size = new System.Drawing.Size(448, 289);
            this.txtProrroga.TabIndex = 0;
            this.txtProrroga.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.cboTipo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(351, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 40);
            this.panel2.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel1.Location = new System.Drawing.Point(246, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Tipo";
            // 
            // cboTipo
            // 
            this.cboTipo.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 23;
            this.cboTipo.Items.AddRange(new object[] {
            "Resumen",
            "Prorroga"});
            this.cboTipo.Location = new System.Drawing.Point(281, 0);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(167, 29);
            this.cboTipo.TabIndex = 0;
            this.cboTipo.UseSelectable = true;
            // 
            // dataGridViewProrrogas
            // 
            this.dataGridViewProrrogas.AllowUserToAddRows = false;
            this.dataGridViewProrrogas.AllowUserToDeleteRows = false;
            this.dataGridViewProrrogas.AllowUserToResizeColumns = false;
            this.dataGridViewProrrogas.AllowUserToResizeRows = false;
            this.dataGridViewProrrogas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProrrogas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProrrogas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fecha,
            this.Medico,
            this.Servicio,
            this.TipoPro,
            this.Texto});
            this.dataGridViewProrrogas.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewProrrogas.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewProrrogas.MultiSelect = false;
            this.dataGridViewProrrogas.Name = "dataGridViewProrrogas";
            this.dataGridViewProrrogas.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProrrogas.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProrrogas.RowHeadersVisible = false;
            this.dataGridViewProrrogas.RowHeadersWidth = 30;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewProrrogas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProrrogas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProrrogas.Size = new System.Drawing.Size(348, 329);
            this.dataGridViewProrrogas.TabIndex = 1;
            this.dataGridViewProrrogas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProrrogas_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // Medico
            // 
            this.Medico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medico.HeaderText = "Medico";
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            // 
            // Servicio
            // 
            this.Servicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            // 
            // TipoPro
            // 
            this.TipoPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoPro.HeaderText = "Tipo";
            this.TipoPro.Name = "TipoPro";
            this.TipoPro.ReadOnly = true;
            // 
            // Texto
            // 
            this.Texto.HeaderText = "Texto";
            this.Texto.Name = "Texto";
            this.Texto.ReadOnly = true;
            this.Texto.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonImprimir);
            this.panel1.Controls.Add(this.buttonGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 33);
            this.panel1.TabIndex = 2;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonImprimir.BackgroundImage")));
            this.buttonImprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonImprimir.Location = new System.Drawing.Point(0, 0);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(117, 33);
            this.buttonImprimir.TabIndex = 1;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
            this.buttonGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonGuardar.Location = new System.Drawing.Point(685, 0);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(117, 33);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // panelProrrogas
            // 
            this.panelProrrogas.Controls.Add(this.groupBox1);
            this.panelProrrogas.Controls.Add(this.panel1);
            this.panelProrrogas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProrrogas.Location = new System.Drawing.Point(20, 60);
            this.panelProrrogas.Name = "panelProrrogas";
            this.panelProrrogas.Size = new System.Drawing.Size(802, 381);
            this.panelProrrogas.TabIndex = 3;
            // 
            // Prorroga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 461);
            this.Controls.Add(this.panelProrrogas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prorroga";
            this.Text = "Nueva Prorroga";
            this.Load += new System.EventHandler(this.Evolucion_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProrrogas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelProrrogas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtProrroga;
        private System.Windows.Forms.Button buttonGuardar;
        public System.Windows.Forms.Panel panelProrrogas;
        private System.Windows.Forms.DataGridView dataGridViewProrrogas;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texto;
        private System.Windows.Forms.Button buttonImprimir;
    }
}