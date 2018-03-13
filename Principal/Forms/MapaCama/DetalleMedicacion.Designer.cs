namespace Principal.Forms.MapaCama
{
    partial class DetalleMedicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleMedicacion));
            this.dataGridViewDetalleMedicamento = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtObservacion = new MetroFramework.Controls.MetroTextBox();
            this.groupObservacion = new System.Windows.Forms.GroupBox();
            this.groupSuministro = new System.Windows.Forms.GroupBox();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleMedicamento)).BeginInit();
            this.groupObservacion.SuspendLayout();
            this.groupSuministro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDetalleMedicamento
            // 
            this.dataGridViewDetalleMedicamento.AllowUserToAddRows = false;
            this.dataGridViewDetalleMedicamento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewDetalleMedicamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDetalleMedicamento.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewDetalleMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.Medicamento,
            this.Observaciones});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetalleMedicamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDetalleMedicamento.Location = new System.Drawing.Point(15, 19);
            this.dataGridViewDetalleMedicamento.MultiSelect = false;
            this.dataGridViewDetalleMedicamento.Name = "dataGridViewDetalleMedicamento";
            this.dataGridViewDetalleMedicamento.RowHeadersVisible = false;
            this.dataGridViewDetalleMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetalleMedicamento.Size = new System.Drawing.Size(1193, 155);
            this.dataGridViewDetalleMedicamento.TabIndex = 7;
            this.dataGridViewDetalleMedicamento.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewDetalleMedicamento_CurrentCellDirtyStateChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.Image = global::Principal.Properties.Resources.LogoSalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(1121, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 26);
            this.btnSalir.TabIndex = 86;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(1005, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 26);
            this.btnGuardar.TabIndex = 85;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Lines = new string[0];
            this.txtObservacion.Location = new System.Drawing.Point(15, 19);
            this.txtObservacion.MaxLength = 32767;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.Size = new System.Drawing.Size(1193, 62);
            this.txtObservacion.TabIndex = 87;
            this.txtObservacion.UseSelectable = true;
            // 
            // groupObservacion
            // 
            this.groupObservacion.Controls.Add(this.txtObservacion);
            this.groupObservacion.Location = new System.Drawing.Point(9, 225);
            this.groupObservacion.Name = "groupObservacion";
            this.groupObservacion.Size = new System.Drawing.Size(1221, 91);
            this.groupObservacion.TabIndex = 88;
            this.groupObservacion.TabStop = false;
            this.groupObservacion.Text = "Observaciones";
            // 
            // groupSuministro
            // 
            this.groupSuministro.Controls.Add(this.dataGridViewDetalleMedicamento);
            this.groupSuministro.Location = new System.Drawing.Point(9, 33);
            this.groupSuministro.Name = "groupSuministro";
            this.groupSuministro.Size = new System.Drawing.Size(1221, 187);
            this.groupSuministro.TabIndex = 89;
            this.groupSuministro.TabStop = false;
            this.groupSuministro.Text = "Suministrar Medicamentos";
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Width = 20;
            // 
            // Medicamento
            // 
            this.Medicamento.HeaderText = "Medicamento";
            this.Medicamento.Name = "Medicamento";
            this.Medicamento.ReadOnly = true;
            this.Medicamento.Width = 500;
            // 
            // Observaciones
            // 
            this.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Observaciones.FillWeight = 203.0457F;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // DetalleMedicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 360);
            this.Controls.Add(this.groupSuministro);
            this.Controls.Add(this.groupObservacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Name = "DetalleMedicacion";
            this.Load += new System.EventHandler(this.DetalleMedicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleMedicamento)).EndInit();
            this.groupObservacion.ResumeLayout(false);
            this.groupSuministro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDetalleMedicamento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtObservacion;
        private System.Windows.Forms.GroupBox groupObservacion;
        private System.Windows.Forms.GroupBox groupSuministro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento;
    }
}