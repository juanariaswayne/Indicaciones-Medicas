namespace Principal.Forms.Parametros.Medicamento
{
    partial class MedicamentoVia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicamentoVia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMedicamento = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAsociar = new System.Windows.Forms.Button();
            this.groupViaAsociada = new System.Windows.Forms.GroupBox();
            this.dataGridViewViaAsociada = new System.Windows.Forms.DataGridView();
            this.medicamento_via_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desasociar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupViaDisponible = new System.Windows.Forms.GroupBox();
            this.dataGridViewViaDisponible = new System.Windows.Forms.DataGridView();
            this.via_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.via = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupMedicamento = new System.Windows.Forms.GroupBox();
            this.dataGridViewMedicamento = new System.Windows.Forms.DataGridView();
            this.medicamento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarMedicamento = new MetroFramework.Controls.MetroTextBox();
            this.panelMedicamento.SuspendLayout();
            this.groupViaAsociada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViaAsociada)).BeginInit();
            this.groupViaDisponible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViaDisponible)).BeginInit();
            this.groupMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMedicamento
            // 
            this.panelMedicamento.Controls.Add(this.btnSalir);
            this.panelMedicamento.Controls.Add(this.btnAsociar);
            this.panelMedicamento.Controls.Add(this.groupViaAsociada);
            this.panelMedicamento.Controls.Add(this.groupViaDisponible);
            this.panelMedicamento.Controls.Add(this.groupMedicamento);
            this.panelMedicamento.Location = new System.Drawing.Point(6, 60);
            this.panelMedicamento.Name = "panelMedicamento";
            this.panelMedicamento.Size = new System.Drawing.Size(979, 568);
            this.panelMedicamento.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.Location = new System.Drawing.Point(849, 531);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 30);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAsociar
            // 
            this.btnAsociar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAsociar.BackgroundImage")));
            this.btnAsociar.Location = new System.Drawing.Point(718, 531);
            this.btnAsociar.Name = "btnAsociar";
            this.btnAsociar.Size = new System.Drawing.Size(125, 30);
            this.btnAsociar.TabIndex = 1;
            this.btnAsociar.Text = "Guardar";
            this.btnAsociar.UseVisualStyleBackColor = true;
            this.btnAsociar.Click += new System.EventHandler(this.btnAsociar_Click);
            // 
            // groupViaAsociada
            // 
            this.groupViaAsociada.Controls.Add(this.dataGridViewViaAsociada);
            this.groupViaAsociada.Location = new System.Drawing.Point(477, 3);
            this.groupViaAsociada.Name = "groupViaAsociada";
            this.groupViaAsociada.Size = new System.Drawing.Size(494, 259);
            this.groupViaAsociada.TabIndex = 3;
            this.groupViaAsociada.TabStop = false;
            this.groupViaAsociada.Text = "Vías Asociadas";
            // 
            // dataGridViewViaAsociada
            // 
            this.dataGridViewViaAsociada.AllowUserToAddRows = false;
            this.dataGridViewViaAsociada.AllowUserToDeleteRows = false;
            this.dataGridViewViaAsociada.AllowUserToResizeColumns = false;
            this.dataGridViewViaAsociada.AllowUserToResizeRows = false;
            this.dataGridViewViaAsociada.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewViaAsociada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViaAsociada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicamento_via_id,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.desasociar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewViaAsociada.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewViaAsociada.Location = new System.Drawing.Point(11, 19);
            this.dataGridViewViaAsociada.Name = "dataGridViewViaAsociada";
            this.dataGridViewViaAsociada.RowHeadersVisible = false;
            this.dataGridViewViaAsociada.Size = new System.Drawing.Size(473, 226);
            this.dataGridViewViaAsociada.TabIndex = 0;
            this.dataGridViewViaAsociada.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewViasAsociada_CurrentCellDirtyStateChanged);
            // 
            // medicamento_via_id
            // 
            this.medicamento_via_id.HeaderText = "Medicamento Via Id";
            this.medicamento_via_id.Name = "medicamento_via_id";
            this.medicamento_via_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "via_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 246.142F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Vía";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // desasociar
            // 
            this.desasociar.HeaderText = "Desasociar";
            this.desasociar.Name = "desasociar";
            this.desasociar.Width = 75;
            // 
            // groupViaDisponible
            // 
            this.groupViaDisponible.Controls.Add(this.dataGridViewViaDisponible);
            this.groupViaDisponible.Location = new System.Drawing.Point(477, 266);
            this.groupViaDisponible.Name = "groupViaDisponible";
            this.groupViaDisponible.Size = new System.Drawing.Size(494, 259);
            this.groupViaDisponible.TabIndex = 2;
            this.groupViaDisponible.TabStop = false;
            this.groupViaDisponible.Text = "Vías Disponibles";
            // 
            // dataGridViewViaDisponible
            // 
            this.dataGridViewViaDisponible.AllowUserToAddRows = false;
            this.dataGridViewViaDisponible.AllowUserToDeleteRows = false;
            this.dataGridViewViaDisponible.AllowUserToResizeColumns = false;
            this.dataGridViewViaDisponible.AllowUserToResizeRows = false;
            this.dataGridViewViaDisponible.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewViaDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViaDisponible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.via_id,
            this.via,
            this.check});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewViaDisponible.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewViaDisponible.Location = new System.Drawing.Point(11, 24);
            this.dataGridViewViaDisponible.Name = "dataGridViewViaDisponible";
            this.dataGridViewViaDisponible.RowHeadersVisible = false;
            this.dataGridViewViaDisponible.Size = new System.Drawing.Size(473, 221);
            this.dataGridViewViaDisponible.TabIndex = 0;
            this.dataGridViewViaDisponible.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewViasDisponible_CurrentCellDirtyStateChanged);
            // 
            // via_id
            // 
            this.via_id.HeaderText = "via_id";
            this.via_id.Name = "via_id";
            this.via_id.Visible = false;
            // 
            // via
            // 
            this.via.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.via.FillWeight = 246.142F;
            this.via.HeaderText = "Vía";
            this.via.Name = "via";
            this.via.ReadOnly = true;
            // 
            // check
            // 
            this.check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.check.FillWeight = 46.8058F;
            this.check.HeaderText = "Asociar";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupMedicamento
            // 
            this.groupMedicamento.Controls.Add(this.dataGridViewMedicamento);
            this.groupMedicamento.Controls.Add(this.txtBuscarMedicamento);
            this.groupMedicamento.Location = new System.Drawing.Point(7, 3);
            this.groupMedicamento.Name = "groupMedicamento";
            this.groupMedicamento.Size = new System.Drawing.Size(464, 522);
            this.groupMedicamento.TabIndex = 1;
            this.groupMedicamento.TabStop = false;
            this.groupMedicamento.Text = "Medicamentos";
            // 
            // dataGridViewMedicamento
            // 
            this.dataGridViewMedicamento.AllowUserToAddRows = false;
            this.dataGridViewMedicamento.AllowUserToDeleteRows = false;
            this.dataGridViewMedicamento.AllowUserToResizeColumns = false;
            this.dataGridViewMedicamento.AllowUserToResizeRows = false;
            this.dataGridViewMedicamento.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicamento_id,
            this.medicamento,
            this.unidadDeMedida,
            this.presentacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMedicamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMedicamento.Location = new System.Drawing.Point(13, 48);
            this.dataGridViewMedicamento.Name = "dataGridViewMedicamento";
            this.dataGridViewMedicamento.ReadOnly = true;
            this.dataGridViewMedicamento.RowHeadersVisible = false;
            this.dataGridViewMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedicamento.Size = new System.Drawing.Size(439, 460);
            this.dataGridViewMedicamento.TabIndex = 0;
            this.dataGridViewMedicamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicamentos_CellClick);
            this.dataGridViewMedicamento.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewMedicamento_CurrentCellDirtyStateChanged);
            // 
            // medicamento_id
            // 
            this.medicamento_id.HeaderText = "procedimiento_id";
            this.medicamento_id.Name = "medicamento_id";
            this.medicamento_id.ReadOnly = true;
            this.medicamento_id.Visible = false;
            // 
            // medicamento
            // 
            this.medicamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medicamento.HeaderText = "Medicamento";
            this.medicamento.Name = "medicamento";
            this.medicamento.ReadOnly = true;
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
            // txtBuscarMedicamento
            // 
            this.txtBuscarMedicamento.Lines = new string[0];
            this.txtBuscarMedicamento.Location = new System.Drawing.Point(13, 23);
            this.txtBuscarMedicamento.MaxLength = 32767;
            this.txtBuscarMedicamento.Name = "txtBuscarMedicamento";
            this.txtBuscarMedicamento.PasswordChar = '\0';
            this.txtBuscarMedicamento.PromptText = "Buscar Medicamento";
            this.txtBuscarMedicamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarMedicamento.SelectedText = "";
            this.txtBuscarMedicamento.Size = new System.Drawing.Size(439, 23);
            this.txtBuscarMedicamento.TabIndex = 1;
            this.txtBuscarMedicamento.UseSelectable = true;
            this.txtBuscarMedicamento.TextChanged += new System.EventHandler(this.txtBuscarMedicamento_TextChanged);
            // 
            // MedicamentoVia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 637);
            this.Controls.Add(this.panelMedicamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicamentoVia";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Medicamentos / Vías";
            this.Load += new System.EventHandler(this.MedicamentoVia_Load);
            this.panelMedicamento.ResumeLayout(false);
            this.groupViaAsociada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViaAsociada)).EndInit();
            this.groupViaDisponible.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViaDisponible)).EndInit();
            this.groupMedicamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMedicamento;
        private System.Windows.Forms.GroupBox groupMedicamento;
        private System.Windows.Forms.DataGridView dataGridViewMedicamento;
        private System.Windows.Forms.GroupBox groupViaDisponible;
        private System.Windows.Forms.DataGridView dataGridViewViaDisponible;
        private System.Windows.Forms.Button btnAsociar;
        private MetroFramework.Controls.MetroTextBox txtBuscarMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn via_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn via;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupViaAsociada;
        private System.Windows.Forms.DataGridView dataGridViewViaAsociada;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamento_via_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn desasociar;
    }
}