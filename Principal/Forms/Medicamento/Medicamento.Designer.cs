namespace Principal.Forms.Medicamento
{
    partial class Medicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroMedicamento = new MetroFramework.Controls.MetroPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupMedicamentoPendiente = new System.Windows.Forms.GroupBox();
            this.dataGridViewMedicamentoPendiente = new System.Windows.Forms.DataGridView();
            this.txtBuscarMedicamentoPendiente = new MetroFramework.Controls.MetroTextBox();
            this.groupMedicamentoBerjerman = new System.Windows.Forms.GroupBox();
            this.dataGridViewMedicamentoBejerman = new System.Windows.Forms.DataGridView();
            this.medicamento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarMedicamentoBerjerman = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroMedicamento.SuspendLayout();
            this.groupMedicamentoPendiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentoPendiente)).BeginInit();
            this.groupMedicamentoBerjerman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentoBejerman)).BeginInit();
            this.SuspendLayout();
            // 
            // metroMedicamento
            // 
            this.metroMedicamento.Controls.Add(this.btnSalir);
            this.metroMedicamento.Controls.Add(this.btnGuardar);
            this.metroMedicamento.Controls.Add(this.groupMedicamentoPendiente);
            this.metroMedicamento.Controls.Add(this.groupMedicamentoBerjerman);
            this.metroMedicamento.HorizontalScrollbarBarColor = true;
            this.metroMedicamento.HorizontalScrollbarHighlightOnWheel = false;
            this.metroMedicamento.HorizontalScrollbarSize = 10;
            this.metroMedicamento.Location = new System.Drawing.Point(5, 53);
            this.metroMedicamento.Name = "metroMedicamento";
            this.metroMedicamento.Size = new System.Drawing.Size(1058, 499);
            this.metroMedicamento.TabIndex = 0;
            this.metroMedicamento.VerticalScrollbarBarColor = true;
            this.metroMedicamento.VerticalScrollbarHighlightOnWheel = false;
            this.metroMedicamento.VerticalScrollbarSize = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.Location = new System.Drawing.Point(926, 466);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 30);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.Location = new System.Drawing.Point(795, 466);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 30);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupMedicamentoPendiente
            // 
            this.groupMedicamentoPendiente.Controls.Add(this.dataGridViewMedicamentoPendiente);
            this.groupMedicamentoPendiente.Controls.Add(this.txtBuscarMedicamentoPendiente);
            this.groupMedicamentoPendiente.Location = new System.Drawing.Point(531, 10);
            this.groupMedicamentoPendiente.Name = "groupMedicamentoPendiente";
            this.groupMedicamentoPendiente.Size = new System.Drawing.Size(520, 450);
            this.groupMedicamentoPendiente.TabIndex = 4;
            this.groupMedicamentoPendiente.TabStop = false;
            this.groupMedicamentoPendiente.Text = "Medicamentos Pendientes";
            // 
            // dataGridViewMedicamentoPendiente
            // 
            this.dataGridViewMedicamentoPendiente.AllowUserToAddRows = false;
            this.dataGridViewMedicamentoPendiente.AllowUserToDeleteRows = false;
            this.dataGridViewMedicamentoPendiente.AllowUserToResizeColumns = false;
            this.dataGridViewMedicamentoPendiente.AllowUserToResizeRows = false;
            this.dataGridViewMedicamentoPendiente.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMedicamentoPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicamentoPendiente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMedicamentoPendiente.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMedicamentoPendiente.Location = new System.Drawing.Point(6, 41);
            this.dataGridViewMedicamentoPendiente.Name = "dataGridViewMedicamentoPendiente";
            this.dataGridViewMedicamentoPendiente.RowHeadersVisible = false;
            this.dataGridViewMedicamentoPendiente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedicamentoPendiente.Size = new System.Drawing.Size(508, 397);
            this.dataGridViewMedicamentoPendiente.TabIndex = 2;
            this.dataGridViewMedicamentoPendiente.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewMedicamentoPendiente_CurrentCellDirtyStateChanged);
            // 
            // txtBuscarMedicamentoPendiente
            // 
            this.txtBuscarMedicamentoPendiente.Lines = new string[0];
            this.txtBuscarMedicamentoPendiente.Location = new System.Drawing.Point(6, 16);
            this.txtBuscarMedicamentoPendiente.MaxLength = 32767;
            this.txtBuscarMedicamentoPendiente.Name = "txtBuscarMedicamentoPendiente";
            this.txtBuscarMedicamentoPendiente.PasswordChar = '\0';
            this.txtBuscarMedicamentoPendiente.PromptText = "Buscar Medicamento";
            this.txtBuscarMedicamentoPendiente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarMedicamentoPendiente.SelectedText = "";
            this.txtBuscarMedicamentoPendiente.Size = new System.Drawing.Size(508, 23);
            this.txtBuscarMedicamentoPendiente.TabIndex = 3;
            this.txtBuscarMedicamentoPendiente.UseSelectable = true;
            this.txtBuscarMedicamentoPendiente.TextChanged += new System.EventHandler(this.txtBuscarMedicamentoPendiente_TextChanged);
            // 
            // groupMedicamentoBerjerman
            // 
            this.groupMedicamentoBerjerman.Controls.Add(this.dataGridViewMedicamentoBejerman);
            this.groupMedicamentoBerjerman.Controls.Add(this.txtBuscarMedicamentoBerjerman);
            this.groupMedicamentoBerjerman.Location = new System.Drawing.Point(5, 10);
            this.groupMedicamentoBerjerman.Name = "groupMedicamentoBerjerman";
            this.groupMedicamentoBerjerman.Size = new System.Drawing.Size(520, 450);
            this.groupMedicamentoBerjerman.TabIndex = 2;
            this.groupMedicamentoBerjerman.TabStop = false;
            this.groupMedicamentoBerjerman.Text = "Medicamentos en Berjerman";
            // 
            // dataGridViewMedicamentoBejerman
            // 
            this.dataGridViewMedicamentoBejerman.AllowUserToAddRows = false;
            this.dataGridViewMedicamentoBejerman.AllowUserToDeleteRows = false;
            this.dataGridViewMedicamentoBejerman.AllowUserToResizeColumns = false;
            this.dataGridViewMedicamentoBejerman.AllowUserToResizeRows = false;
            this.dataGridViewMedicamentoBejerman.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMedicamentoBejerman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicamentoBejerman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicamento_id,
            this.dataGridViewTextBoxColumn1,
            this.unidadDeMedida,
            this.presentacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMedicamentoBejerman.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMedicamentoBejerman.Location = new System.Drawing.Point(6, 41);
            this.dataGridViewMedicamentoBejerman.Name = "dataGridViewMedicamentoBejerman";
            this.dataGridViewMedicamentoBejerman.ReadOnly = true;
            this.dataGridViewMedicamentoBejerman.RowHeadersVisible = false;
            this.dataGridViewMedicamentoBejerman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedicamentoBejerman.Size = new System.Drawing.Size(508, 397);
            this.dataGridViewMedicamentoBejerman.TabIndex = 2;
            this.dataGridViewMedicamentoBejerman.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewMedicamentoBejerman_CurrentCellDirtyStateChanged);
            // 
            // medicamento_id
            // 
            this.medicamento_id.HeaderText = "ID";
            this.medicamento_id.Name = "medicamento_id";
            this.medicamento_id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Medicamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // unidadDeMedida
            // 
            this.unidadDeMedida.HeaderText = "Uni. Medida";
            this.unidadDeMedida.Name = "unidadDeMedida";
            this.unidadDeMedida.ReadOnly = true;
            // 
            // presentacion
            // 
            this.presentacion.HeaderText = "Presentación";
            this.presentacion.Name = "presentacion";
            this.presentacion.ReadOnly = true;
            // 
            // txtBuscarMedicamentoBerjerman
            // 
            this.txtBuscarMedicamentoBerjerman.Lines = new string[0];
            this.txtBuscarMedicamentoBerjerman.Location = new System.Drawing.Point(6, 16);
            this.txtBuscarMedicamentoBerjerman.MaxLength = 32767;
            this.txtBuscarMedicamentoBerjerman.Name = "txtBuscarMedicamentoBerjerman";
            this.txtBuscarMedicamentoBerjerman.PasswordChar = '\0';
            this.txtBuscarMedicamentoBerjerman.PromptText = "Buscar Medicamento";
            this.txtBuscarMedicamentoBerjerman.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarMedicamentoBerjerman.SelectedText = "";
            this.txtBuscarMedicamentoBerjerman.Size = new System.Drawing.Size(508, 23);
            this.txtBuscarMedicamentoBerjerman.TabIndex = 3;
            this.txtBuscarMedicamentoBerjerman.UseSelectable = true;
            this.txtBuscarMedicamentoBerjerman.TextChanged += new System.EventHandler(this.txtBuscarMedicamentoBerjerman_TextChanged);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Medicamento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Uni. Medida";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Presentación";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Medicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 560);
            this.Controls.Add(this.metroMedicamento);
            this.Name = "Medicamento";
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.Medicamento_Load);
            this.metroMedicamento.ResumeLayout(false);
            this.groupMedicamentoPendiente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentoPendiente)).EndInit();
            this.groupMedicamentoBerjerman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentoBejerman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroMedicamento;
        private System.Windows.Forms.GroupBox groupMedicamentoBerjerman;
        private System.Windows.Forms.GroupBox groupMedicamentoPendiente;
        private System.Windows.Forms.DataGridView dataGridViewMedicamentoPendiente;
        private System.Windows.Forms.DataGridView dataGridViewMedicamentoBejerman;
        private MetroFramework.Controls.MetroTextBox txtBuscarMedicamentoBerjerman;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtBuscarMedicamentoPendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}