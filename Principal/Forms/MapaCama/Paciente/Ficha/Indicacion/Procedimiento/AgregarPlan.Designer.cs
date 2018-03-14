namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento
{
    partial class AgregarPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagridAlimentosSeleccionados = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alimentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregarAlimentos = new MetroFramework.Controls.MetroTile();
            this.groupObservacion = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new MetroFramework.Controls.MetroTextBox();
            this.cmbBoxHorarioAdministracion = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnGuardar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAlimentosSeleccionados)).BeginInit();
            this.groupObservacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridAlimentosSeleccionados
            // 
            this.datagridAlimentosSeleccionados.AllowUserToAddRows = false;
            this.datagridAlimentosSeleccionados.AllowUserToDeleteRows = false;
            this.datagridAlimentosSeleccionados.AllowUserToOrderColumns = true;
            this.datagridAlimentosSeleccionados.AllowUserToResizeRows = false;
            this.datagridAlimentosSeleccionados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagridAlimentosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAlimentosSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Alimentos,
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridAlimentosSeleccionados.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridAlimentosSeleccionados.Location = new System.Drawing.Point(23, 123);
            this.datagridAlimentosSeleccionados.MultiSelect = false;
            this.datagridAlimentosSeleccionados.Name = "datagridAlimentosSeleccionados";
            this.datagridAlimentosSeleccionados.RowHeadersVisible = false;
            this.datagridAlimentosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridAlimentosSeleccionados.Size = new System.Drawing.Size(509, 427);
            this.datagridAlimentosSeleccionados.TabIndex = 17;
            this.datagridAlimentosSeleccionados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridAlimentosSeleccionados_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Alimentos
            // 
            this.Alimentos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Alimentos.HeaderText = "Alimentos";
            this.Alimentos.Name = "Alimentos";
            this.Alimentos.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "X";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "X";
            this.Eliminar.ToolTipText = "Eliminar alimento";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 20;
            // 
            // btnAgregarAlimentos
            // 
            this.btnAgregarAlimentos.ActiveControl = null;
            this.btnAgregarAlimentos.Location = new System.Drawing.Point(111, 683);
            this.btnAgregarAlimentos.Name = "btnAgregarAlimentos";
            this.btnAgregarAlimentos.Size = new System.Drawing.Size(134, 40);
            this.btnAgregarAlimentos.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAgregarAlimentos.TabIndex = 83;
            this.btnAgregarAlimentos.Text = "Agregar alimentos";
            this.btnAgregarAlimentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarAlimentos.UseSelectable = true;
            this.btnAgregarAlimentos.Click += new System.EventHandler(this.btnAgregarAlimentos_Click);
            // 
            // groupObservacion
            // 
            this.groupObservacion.Controls.Add(this.txtObservacion);
            this.groupObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupObservacion.Location = new System.Drawing.Point(23, 568);
            this.groupObservacion.Name = "groupObservacion";
            this.groupObservacion.Size = new System.Drawing.Size(509, 98);
            this.groupObservacion.TabIndex = 84;
            this.groupObservacion.TabStop = false;
            this.groupObservacion.Text = "Observaciones";
            // 
            // txtObservacion
            // 
            // 
            // 
            // 
            this.txtObservacion.CustomButton.Image = null;
            this.txtObservacion.CustomButton.Location = new System.Drawing.Point(441, 1);
            this.txtObservacion.CustomButton.Name = "";
            this.txtObservacion.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.txtObservacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservacion.CustomButton.TabIndex = 1;
            this.txtObservacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservacion.CustomButton.UseSelectable = true;
            this.txtObservacion.CustomButton.Visible = false;
            this.txtObservacion.Lines = new string[0];
            this.txtObservacion.Location = new System.Drawing.Point(12, 28);
            this.txtObservacion.MaxLength = 32767;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.SelectionLength = 0;
            this.txtObservacion.SelectionStart = 0;
            this.txtObservacion.ShortcutsEnabled = true;
            this.txtObservacion.Size = new System.Drawing.Size(491, 51);
            this.txtObservacion.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtObservacion.TabIndex = 0;
            this.txtObservacion.UseSelectable = true;
            this.txtObservacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbBoxHorarioAdministracion
            // 
            this.cmbBoxHorarioAdministracion.FormattingEnabled = true;
            this.cmbBoxHorarioAdministracion.ItemHeight = 23;
            this.cmbBoxHorarioAdministracion.Location = new System.Drawing.Point(198, 82);
            this.cmbBoxHorarioAdministracion.Name = "cmbBoxHorarioAdministracion";
            this.cmbBoxHorarioAdministracion.Size = new System.Drawing.Size(250, 29);
            this.cmbBoxHorarioAdministracion.TabIndex = 85;
            this.cmbBoxHorarioAdministracion.UseSelectable = true;
            this.cmbBoxHorarioAdministracion.SelectedIndexChanged += new System.EventHandler(this.cmbBoxHorarioAdministracion_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(162, 19);
            this.metroLabel3.TabIndex = 109;
            this.metroLabel3.Text = "Horario de administración";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveControl = null;
            this.btnGuardar.Location = new System.Drawing.Point(297, 683);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 40);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnGuardar.TabIndex = 110;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // AgregarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 746);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbBoxHorarioAdministracion);
            this.Controls.Add(this.groupObservacion);
            this.Controls.Add(this.btnAgregarAlimentos);
            this.Controls.Add(this.datagridAlimentosSeleccionados);
            this.Name = "AgregarPlan";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Plan de alimentación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarPlan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.datagridAlimentosSeleccionados)).EndInit();
            this.groupObservacion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridAlimentosSeleccionados;
        private MetroFramework.Controls.MetroTile btnAgregarAlimentos;
        private System.Windows.Forms.GroupBox groupObservacion;
        private MetroFramework.Controls.MetroTextBox txtObservacion;
        private MetroFramework.Controls.MetroComboBox cmbBoxHorarioAdministracion;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alimentos;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}