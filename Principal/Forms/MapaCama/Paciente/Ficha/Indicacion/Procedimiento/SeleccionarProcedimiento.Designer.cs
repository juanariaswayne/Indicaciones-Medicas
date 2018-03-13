namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento
{
    partial class SeleccionarProcedimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarProcedimiento));
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewProcedimiento = new System.Windows.Forms.DataGridView();
            this.procedimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProcedimientoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.btSolicitarNuevo = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            // 
            // 
            // 
            this.txtBuscar.CustomButton.Image = null;
            this.txtBuscar.CustomButton.Location = new System.Drawing.Point(689, 1);
            this.txtBuscar.CustomButton.Name = "";
            this.txtBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscar.CustomButton.TabIndex = 1;
            this.txtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscar.CustomButton.UseSelectable = true;
            this.txtBuscar.CustomButton.Visible = false;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(10, 23);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PromptText = "Ingrese aqui el procedimiento a buscar";
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(711, 23);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.WaterMark = "Ingrese aqui el procedimiento a buscar";
            this.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.dataGridViewProcedimiento);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtBuscar);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(734, 476);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(227, 63);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(273, 15);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Doble click para seleccionar el procedimiento a indicar";
            // 
            // dataGridViewProcedimiento
            // 
            this.dataGridViewProcedimiento.AllowUserToAddRows = false;
            this.dataGridViewProcedimiento.AllowUserToDeleteRows = false;
            this.dataGridViewProcedimiento.AllowUserToResizeColumns = false;
            this.dataGridViewProcedimiento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.dataGridViewProcedimiento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProcedimiento.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProcedimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcedimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.procedimientoId,
            this.procedimiento,
            this.tipoProcedimientoId,
            this.tipoProcedimiento});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProcedimiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProcedimiento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewProcedimiento.Location = new System.Drawing.Point(0, 81);
            this.dataGridViewProcedimiento.MultiSelect = false;
            this.dataGridViewProcedimiento.Name = "dataGridViewProcedimiento";
            this.dataGridViewProcedimiento.RowHeadersVisible = false;
            this.dataGridViewProcedimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcedimiento.Size = new System.Drawing.Size(734, 395);
            this.dataGridViewProcedimiento.TabIndex = 3;
            this.dataGridViewProcedimiento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcedimiento_CellDoubleClick);
            this.dataGridViewProcedimiento.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewProcedimiento_CurrentCellDirtyStateChanged);
            // 
            // procedimientoId
            // 
            this.procedimientoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.procedimientoId.HeaderText = "Procedimiento_Id";
            this.procedimientoId.Name = "procedimientoId";
            this.procedimientoId.ReadOnly = true;
            this.procedimientoId.Visible = false;
            // 
            // procedimiento
            // 
            this.procedimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.procedimiento.FillWeight = 203.0457F;
            this.procedimiento.HeaderText = "Procedimiento";
            this.procedimiento.Name = "procedimiento";
            this.procedimiento.ReadOnly = true;
            // 
            // tipoProcedimientoId
            // 
            this.tipoProcedimientoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoProcedimientoId.FillWeight = 65.65145F;
            this.tipoProcedimientoId.HeaderText = "Tipo_ Procedimiento_Id";
            this.tipoProcedimientoId.Name = "tipoProcedimientoId";
            this.tipoProcedimientoId.ReadOnly = true;
            this.tipoProcedimientoId.Visible = false;
            // 
            // tipoProcedimiento
            // 
            this.tipoProcedimiento.HeaderText = "Tipo_Procedimiento";
            this.tipoProcedimiento.Name = "tipoProcedimiento";
            this.tipoProcedimiento.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(9, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 15);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Buscar procedimiento";
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveControl = null;
            this.btnSalir.Location = new System.Drawing.Point(682, 544);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 37);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btSolicitarNuevo
            // 
            this.btSolicitarNuevo.ActiveControl = null;
            this.btSolicitarNuevo.Location = new System.Drawing.Point(23, 545);
            this.btSolicitarNuevo.Name = "btSolicitarNuevo";
            this.btSolicitarNuevo.Size = new System.Drawing.Size(203, 37);
            this.btSolicitarNuevo.Style = MetroFramework.MetroColorStyle.Orange;
            this.btSolicitarNuevo.TabIndex = 13;
            this.btSolicitarNuevo.Text = "Solicitar nuevo procedimiento";
            this.btSolicitarNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSolicitarNuevo.UseCustomBackColor = true;
            this.btSolicitarNuevo.UseSelectable = true;
            this.btSolicitarNuevo.Visible = false;
            this.btSolicitarNuevo.Click += new System.EventHandler(this.btSolicitarNuevo_Click);
            // 
            // SeleccionarProcedimiento
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 586);
            this.Controls.Add(this.btSolicitarNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "SeleccionarProcedimiento";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Seleccione un Procedimiento";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.SeleccionarProcedimiento_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtBuscar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dataGridViewProcedimiento;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProcedimientoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedimientoId;
        private MetroFramework.Controls.MetroTile btnSalir;
        private MetroFramework.Controls.MetroTile btSolicitarNuevo;
    }
}