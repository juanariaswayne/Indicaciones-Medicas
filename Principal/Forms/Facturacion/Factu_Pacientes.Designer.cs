namespace Principal.Forms.Facturacion
{
    partial class Factu_Pacientes
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
            this.cboSede = new MetroFramework.Controls.MetroComboBox();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.idPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSede
            // 
            this.cboSede.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboSede.FormattingEnabled = true;
            this.cboSede.ItemHeight = 19;
            this.cboSede.Items.AddRange(new object[] {
            "Venezuela",
            "Mexico",
            "Catamarca"});
            this.cboSede.Location = new System.Drawing.Point(322, 33);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(234, 25);
            this.cboSede.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboSede.TabIndex = 0;
            this.cboSede.UseSelectable = true;
            this.cboSede.SelectedIndexChanged += new System.EventHandler(this.cboSede_SelectedIndexChanged);
            // 
            // gridPacientes
            // 
            this.gridPacientes.AllowUserToAddRows = false;
            this.gridPacientes.AllowUserToOrderColumns = true;
            this.gridPacientes.AllowUserToResizeColumns = false;
            this.gridPacientes.AllowUserToResizeRows = false;
            this.gridPacientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaciente,
            this.Habitacion,
            this.Paciente});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPacientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPacientes.Location = new System.Drawing.Point(20, 60);
            this.gridPacientes.MultiSelect = false;
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.ReadOnly = true;
            this.gridPacientes.RowHeadersVisible = false;
            this.gridPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPacientes.Size = new System.Drawing.Size(553, 667);
            this.gridPacientes.TabIndex = 3;
            this.gridPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPacientes_CellDoubleClick);
            this.gridPacientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridPacientes_MouseClick);
            // 
            // idPaciente
            // 
            this.idPaciente.HeaderText = "ID";
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.ReadOnly = true;
            this.idPaciente.Visible = false;
            // 
            // Habitacion
            // 
            this.Habitacion.HeaderText = "Hab";
            this.Habitacion.Name = "Habitacion";
            this.Habitacion.ReadOnly = true;
            this.Habitacion.Width = 70;
            // 
            // Paciente
            // 
            this.Paciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            // 
            // txtBuscar
            // 
            // 
            // 
            // 
            this.txtBuscar.CustomButton.Image = null;
            this.txtBuscar.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txtBuscar.CustomButton.Name = "";
            this.txtBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscar.CustomButton.TabIndex = 1;
            this.txtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscar.CustomButton.UseSelectable = true;
            this.txtBuscar.CustomButton.Visible = false;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(322, 7);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PromptText = "Buscar paciente";
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(234, 23);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.WaterMark = "Buscar paciente";
            this.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // Factu_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 747);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.gridPacientes);
            this.Controls.Add(this.cboSede);
            this.MaximizeBox = false;
            this.Name = "Factu_Pacientes";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Pacientes Internados";
            this.Load += new System.EventHandler(this.Factu_Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboSede;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private MetroFramework.Controls.MetroTextBox txtBuscar;
    }
}