namespace Principal.Forms.MapaCama.Paciente.Ficha.HC
{
    partial class Epicrisis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Epicrisis));
            this.panelEpicrisis = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEpicrisis = new System.Windows.Forms.TextBox();
            this.dataGridViewEpicrisis = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.panelEpicrisis.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEpicrisis)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEpicrisis
            // 
            this.panelEpicrisis.Controls.Add(this.groupBox1);
            this.panelEpicrisis.Controls.Add(this.dataGridViewEpicrisis);
            this.panelEpicrisis.Controls.Add(this.panel1);
            this.panelEpicrisis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEpicrisis.Location = new System.Drawing.Point(20, 60);
            this.panelEpicrisis.Name = "panelEpicrisis";
            this.panelEpicrisis.Size = new System.Drawing.Size(745, 303);
            this.panelEpicrisis.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEpicrisis);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(321, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de epicrisis";
            // 
            // txtEpicrisis
            // 
            this.txtEpicrisis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEpicrisis.Location = new System.Drawing.Point(3, 16);
            this.txtEpicrisis.Multiline = true;
            this.txtEpicrisis.Name = "txtEpicrisis";
            this.txtEpicrisis.Size = new System.Drawing.Size(418, 253);
            this.txtEpicrisis.TabIndex = 0;
            // 
            // dataGridViewEpicrisis
            // 
            this.dataGridViewEpicrisis.AllowUserToAddRows = false;
            this.dataGridViewEpicrisis.AllowUserToDeleteRows = false;
            this.dataGridViewEpicrisis.AllowUserToOrderColumns = true;
            this.dataGridViewEpicrisis.AllowUserToResizeColumns = false;
            this.dataGridViewEpicrisis.AllowUserToResizeRows = false;
            this.dataGridViewEpicrisis.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewEpicrisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEpicrisis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fecha,
            this.Medico,
            this.Servicio,
            this.Tipo,
            this.Texto});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEpicrisis.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEpicrisis.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewEpicrisis.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEpicrisis.Name = "dataGridViewEpicrisis";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEpicrisis.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEpicrisis.RowHeadersVisible = false;
            this.dataGridViewEpicrisis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEpicrisis.Size = new System.Drawing.Size(321, 272);
            this.dataGridViewEpicrisis.TabIndex = 2;
            this.dataGridViewEpicrisis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEpicrisis_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // Medico
            // 
            this.Medico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medico.HeaderText = "Medico";
            this.Medico.Name = "Medico";
            // 
            // Servicio
            // 
            this.Servicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Visible = false;
            // 
            // Texto
            // 
            this.Texto.HeaderText = "Texto";
            this.Texto.Name = "Texto";
            this.Texto.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonImprimir);
            this.panel1.Controls.Add(this.buttonGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 31);
            this.panel1.TabIndex = 0;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
            this.buttonGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonGuardar.Location = new System.Drawing.Point(629, 0);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(116, 31);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonImprimir.BackgroundImage")));
            this.buttonImprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonImprimir.Location = new System.Drawing.Point(0, 0);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(116, 31);
            this.buttonImprimir.TabIndex = 1;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // Epicrisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 383);
            this.Controls.Add(this.panelEpicrisis);
            this.Name = "Epicrisis";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Nueva Epicrisis";
            this.Load += new System.EventHandler(this.Epicrisis_Load);
            this.panelEpicrisis.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEpicrisis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEpicrisis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridViewEpicrisis;
        public System.Windows.Forms.Panel panelEpicrisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Texto;
        private System.Windows.Forms.Button buttonImprimir;
    }
}