namespace Principal.Forms.MapaCama
{
    partial class PacientesDeAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientesDeAlta));
            this.dataGridViewPacientesAlta = new System.Windows.Forms.DataGridView();
            this.pacienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReincorporar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientesAlta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPacientesAlta
            // 
            this.dataGridViewPacientesAlta.AllowUserToAddRows = false;
            this.dataGridViewPacientesAlta.AllowUserToDeleteRows = false;
            this.dataGridViewPacientesAlta.AllowUserToOrderColumns = true;
            this.dataGridViewPacientesAlta.AllowUserToResizeColumns = false;
            this.dataGridViewPacientesAlta.AllowUserToResizeRows = false;
            this.dataGridViewPacientesAlta.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPacientesAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientesAlta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacienteID,
            this.Nombre,
            this.habitacion});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPacientesAlta.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPacientesAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPacientesAlta.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewPacientesAlta.MultiSelect = false;
            this.dataGridViewPacientesAlta.Name = "dataGridViewPacientesAlta";
            this.dataGridViewPacientesAlta.RowHeadersVisible = false;
            this.dataGridViewPacientesAlta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPacientesAlta.Size = new System.Drawing.Size(341, 525);
            this.dataGridViewPacientesAlta.TabIndex = 0;
            // 
            // pacienteID
            // 
            this.pacienteID.HeaderText = "pacienteID";
            this.pacienteID.Name = "pacienteID";
            this.pacienteID.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // habitacion
            // 
            this.habitacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.habitacion.HeaderText = "Habitacion";
            this.habitacion.Name = "habitacion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReincorporar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 544);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 41);
            this.panel1.TabIndex = 1;
            // 
            // btnReincorporar
            // 
            this.btnReincorporar.ActiveControl = null;
            this.btnReincorporar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReincorporar.Location = new System.Drawing.Point(235, 0);
            this.btnReincorporar.Name = "btnReincorporar";
            this.btnReincorporar.Size = new System.Drawing.Size(106, 41);
            this.btnReincorporar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnReincorporar.TabIndex = 0;
            this.btnReincorporar.Text = "Reincorporar";
            this.btnReincorporar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReincorporar.UseSelectable = true;
            this.btnReincorporar.Click += new System.EventHandler(this.btnReincorporar_Click);
            // 
            // PacientesDeAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewPacientesAlta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PacientesDeAlta";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Altas";
            this.Load += new System.EventHandler(this.PacientesDeAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientesAlta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPacientesAlta;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile btnReincorporar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn habitacion;
    }
}