namespace Principal.Forms.Parametros.Medicamento
{
    partial class Edita_Via
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edita_Via));
            this.dataGridViewVias = new System.Windows.Forms.DataGridView();
            this.id_via = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inactivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtAgregar = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVias)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVias
            // 
            this.dataGridViewVias.AllowUserToAddRows = false;
            this.dataGridViewVias.AllowUserToDeleteRows = false;
            this.dataGridViewVias.AllowUserToResizeColumns = false;
            this.dataGridViewVias.AllowUserToResizeRows = false;
            this.dataGridViewVias.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewVias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_via,
            this.Descripcion,
            this.Inactivo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVias.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVias.Location = new System.Drawing.Point(20, 88);
            this.dataGridViewVias.Name = "dataGridViewVias";
            this.dataGridViewVias.Size = new System.Drawing.Size(365, 415);
            this.dataGridViewVias.TabIndex = 0;
            // 
            // id_via
            // 
            this.id_via.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_via.FillWeight = 41.04718F;
            this.id_via.HeaderText = "Id";
            this.id_via.Name = "id_via";
            this.id_via.ReadOnly = true;
            this.id_via.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.FillWeight = 228.496F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Inactivo
            // 
            this.Inactivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Inactivo.FillWeight = 30.45685F;
            this.Inactivo.HeaderText = "Inactivo";
            this.Inactivo.Name = "Inactivo";
            this.Inactivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Inactivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Inactivo.Width = 70;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnActualizar);
            this.metroPanel1.Controls.Add(this.btnSalir);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 503);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(365, 30);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.Location = new System.Drawing.Point(115, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 30);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Location = new System.Drawing.Point(240, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.txtAgregar);
            this.metroPanel2.Controls.Add(this.btnAgregar);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(365, 28);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // txtAgregar
            // 
            this.txtAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAgregar.Lines = new string[0];
            this.txtAgregar.Location = new System.Drawing.Point(0, 0);
            this.txtAgregar.MaxLength = 32767;
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.PasswordChar = '\0';
            this.txtAgregar.PromptText = "Escriba la vía";
            this.txtAgregar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAgregar.SelectedText = "";
            this.txtAgregar.Size = new System.Drawing.Size(240, 28);
            this.txtAgregar.TabIndex = 2;
            this.txtAgregar.UseSelectable = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.Location = new System.Drawing.Point(240, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Edita_Via
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 553);
            this.Controls.Add(this.dataGridViewVias);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Name = "Edita_Via";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Lista de Vías";
            this.Load += new System.EventHandler(this.Edita_Via_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVias)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVias;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_via;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Inactivo;
    }
}