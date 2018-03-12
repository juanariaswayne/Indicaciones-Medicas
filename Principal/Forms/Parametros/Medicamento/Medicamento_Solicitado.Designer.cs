namespace Principal.Forms.Parametros.Medicamento
{
    partial class Medicamento_Solicitado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupMedicamentoSolicitado = new System.Windows.Forms.GroupBox();
            this.dataGridViewMedicamentos = new System.Windows.Forms.DataGridView();
            this.metroMedicamentoSolicitado = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.PacienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pac_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.berjeman_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacion_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDeMedida_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad_de_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_solicita_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicita_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suministra = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SumPaciente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.no_autoriza = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_autoriza_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoriza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_usuario_autoriza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupMedicamentoSolicitado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).BeginInit();
            this.metroMedicamentoSolicitado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMedicamentoSolicitado
            // 
            this.groupMedicamentoSolicitado.Controls.Add(this.dataGridViewMedicamentos);
            this.groupMedicamentoSolicitado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMedicamentoSolicitado.Location = new System.Drawing.Point(0, 0);
            this.groupMedicamentoSolicitado.Name = "groupMedicamentoSolicitado";
            this.groupMedicamentoSolicitado.Size = new System.Drawing.Size(1321, 541);
            this.groupMedicamentoSolicitado.TabIndex = 0;
            this.groupMedicamentoSolicitado.TabStop = false;
            this.groupMedicamentoSolicitado.Text = "Medicamentos Solicitados";
            // 
            // dataGridViewMedicamentos
            // 
            this.dataGridViewMedicamentos.AllowUserToAddRows = false;
            this.dataGridViewMedicamentos.AllowUserToDeleteRows = false;
            this.dataGridViewMedicamentos.AllowUserToResizeColumns = false;
            this.dataGridViewMedicamentos.AllowUserToResizeRows = false;
            this.dataGridViewMedicamentos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PacienteId,
            this.pac_id,
            this.medicamento_id,
            this.Medicamento,
            this.berjeman_id,
            this.presentacion_id,
            this.presentacion,
            this.unidadDeMedida_Id,
            this.unidad_de_medida,
            this.usuario_solicita_id,
            this.solicita,
            this.solicita_fecha,
            this.suministra,
            this.SumPaciente,
            this.no_autoriza,
            this.pendiente,
            this.usuario_autoriza_id,
            this.autoriza,
            this.fecha_usuario_autoriza});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMedicamentos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMedicamentos.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewMedicamentos.Name = "dataGridViewMedicamentos";
            this.dataGridViewMedicamentos.RowHeadersVisible = false;
            this.dataGridViewMedicamentos.Size = new System.Drawing.Size(1315, 522);
            this.dataGridViewMedicamentos.TabIndex = 1;
            this.dataGridViewMedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicamentos_CellContentClick);
            this.dataGridViewMedicamentos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewMedicamentos_CurrentCellDirtyStateChanged);
            // 
            // metroMedicamentoSolicitado
            // 
            this.metroMedicamentoSolicitado.Controls.Add(this.groupMedicamentoSolicitado);
            this.metroMedicamentoSolicitado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroMedicamentoSolicitado.HorizontalScrollbarBarColor = true;
            this.metroMedicamentoSolicitado.HorizontalScrollbarHighlightOnWheel = false;
            this.metroMedicamentoSolicitado.HorizontalScrollbarSize = 10;
            this.metroMedicamentoSolicitado.Location = new System.Drawing.Point(20, 60);
            this.metroMedicamentoSolicitado.Name = "metroMedicamentoSolicitado";
            this.metroMedicamentoSolicitado.Size = new System.Drawing.Size(1321, 541);
            this.metroMedicamentoSolicitado.TabIndex = 1;
            this.metroMedicamentoSolicitado.VerticalScrollbarBarColor = true;
            this.metroMedicamentoSolicitado.VerticalScrollbarHighlightOnWheel = false;
            this.metroMedicamentoSolicitado.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(20, 10);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(171, 40);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 88;
            this.metroTile1.Text = "Guardar Autorizaciones";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // PacienteId
            // 
            this.PacienteId.HeaderText = "Paciente";
            this.PacienteId.Name = "PacienteId";
            this.PacienteId.Width = 200;
            // 
            // pac_id
            // 
            this.pac_id.HeaderText = "paci_id";
            this.pac_id.Name = "pac_id";
            this.pac_id.Visible = false;
            // 
            // medicamento_id
            // 
            this.medicamento_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medicamento_id.FillWeight = 41.04718F;
            this.medicamento_id.HeaderText = "medicamento_id";
            this.medicamento_id.Name = "medicamento_id";
            this.medicamento_id.ReadOnly = true;
            this.medicamento_id.Visible = false;
            // 
            // Medicamento
            // 
            this.Medicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medicamento.FillWeight = 228.496F;
            this.Medicamento.HeaderText = "Medicamento";
            this.Medicamento.Name = "Medicamento";
            // 
            // berjeman_id
            // 
            this.berjeman_id.HeaderText = "Berjeman_id";
            this.berjeman_id.Name = "berjeman_id";
            this.berjeman_id.Visible = false;
            // 
            // presentacion_id
            // 
            this.presentacion_id.HeaderText = "Presentacion_Id";
            this.presentacion_id.Name = "presentacion_id";
            this.presentacion_id.Visible = false;
            // 
            // presentacion
            // 
            this.presentacion.HeaderText = "Presentación";
            this.presentacion.Name = "presentacion";
            // 
            // unidadDeMedida_Id
            // 
            this.unidadDeMedida_Id.HeaderText = "UnidadDeMedida_Id";
            this.unidadDeMedida_Id.Name = "unidadDeMedida_Id";
            this.unidadDeMedida_Id.Visible = false;
            // 
            // unidad_de_medida
            // 
            this.unidad_de_medida.HeaderText = "Potencia";
            this.unidad_de_medida.Name = "unidad_de_medida";
            // 
            // usuario_solicita_id
            // 
            this.usuario_solicita_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usuario_solicita_id.HeaderText = "Solicita_Id";
            this.usuario_solicita_id.Name = "usuario_solicita_id";
            this.usuario_solicita_id.Visible = false;
            // 
            // solicita
            // 
            this.solicita.HeaderText = "Solicita";
            this.solicita.Name = "solicita";
            // 
            // solicita_fecha
            // 
            this.solicita_fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.solicita_fecha.DefaultCellStyle = dataGridViewCellStyle5;
            this.solicita_fecha.HeaderText = "Fecha";
            this.solicita_fecha.Name = "solicita_fecha";
            this.solicita_fecha.Width = 75;
            // 
            // suministra
            // 
            this.suministra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.suministra.FillWeight = 30.45685F;
            this.suministra.HeaderText = "Aut. Todos";
            this.suministra.Name = "suministra";
            this.suministra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.suministra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.suministra.Width = 80;
            // 
            // SumPaciente
            // 
            this.SumPaciente.HeaderText = "Solo Este Pac.";
            this.SumPaciente.Name = "SumPaciente";
            this.SumPaciente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SumPaciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SumPaciente.Width = 80;
            // 
            // no_autoriza
            // 
            this.no_autoriza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.no_autoriza.HeaderText = "No Autoriza";
            this.no_autoriza.Name = "no_autoriza";
            this.no_autoriza.Width = 75;
            // 
            // pendiente
            // 
            this.pendiente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pendiente.HeaderText = "Pendiente";
            this.pendiente.Name = "pendiente";
            this.pendiente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pendiente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pendiente.Visible = false;
            this.pendiente.Width = 75;
            // 
            // usuario_autoriza_id
            // 
            this.usuario_autoriza_id.HeaderText = "Autoriza_Id";
            this.usuario_autoriza_id.Name = "usuario_autoriza_id";
            this.usuario_autoriza_id.Visible = false;
            // 
            // autoriza
            // 
            this.autoriza.HeaderText = "Autoriza";
            this.autoriza.Name = "autoriza";
            this.autoriza.Visible = false;
            // 
            // fecha_usuario_autoriza
            // 
            this.fecha_usuario_autoriza.HeaderText = "Fecha Autoriza";
            this.fecha_usuario_autoriza.Name = "fecha_usuario_autoriza";
            this.fecha_usuario_autoriza.Visible = false;
            // 
            // Medicamento_Solicitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 621);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroMedicamentoSolicitado);
            this.Name = "Medicamento_Solicitado";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Medicamentos Solicitados";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Medicamento_Solicitado_Load);
            this.groupMedicamentoSolicitado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamentos)).EndInit();
            this.metroMedicamentoSolicitado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMedicamentoSolicitado;
        private MetroFramework.Controls.MetroPanel metroMedicamentoSolicitado;
        private System.Windows.Forms.DataGridView dataGridViewMedicamentos;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn pac_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn berjeman_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacion_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDeMedida_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad_de_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_solicita_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicita;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicita_fecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn suministra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SumPaciente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn no_autoriza;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_autoriza_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoriza;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_usuario_autoriza;
    }
}