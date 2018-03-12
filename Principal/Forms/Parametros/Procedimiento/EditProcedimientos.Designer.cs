namespace Principal.Forms.Parametros.Procedimiento
{
    partial class EditProcedimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProcedimientos));
            this.dataGridViewProc = new System.Windows.Forms.DataGridView();
            this.id_procedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inactivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.buttonActu = new System.Windows.Forms.Button();
            this.txtAgregar = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProc)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProc
            // 
            this.dataGridViewProc.AllowUserToAddRows = false;
            this.dataGridViewProc.AllowUserToDeleteRows = false;
            this.dataGridViewProc.AllowUserToResizeColumns = false;
            this.dataGridViewProc.AllowUserToResizeRows = false;
            this.dataGridViewProc.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_procedimiento,
            this.Descripcion,
            this.TipoProcID,
            this.DescTipo,
            this.Inactivo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProc.Location = new System.Drawing.Point(20, 88);
            this.dataGridViewProc.Name = "dataGridViewProc";
            this.dataGridViewProc.Size = new System.Drawing.Size(677, 415);
            this.dataGridViewProc.TabIndex = 0;
            // 
            // id_procedimiento
            // 
            this.id_procedimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_procedimiento.FillWeight = 41.04718F;
            this.id_procedimiento.HeaderText = "ID";
            this.id_procedimiento.Name = "id_procedimiento";
            this.id_procedimiento.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.FillWeight = 228.496F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // TipoProcID
            // 
            this.TipoProcID.HeaderText = "TipoProcID";
            this.TipoProcID.Name = "TipoProcID";
            this.TipoProcID.Visible = false;
            // 
            // DescTipo
            // 
            this.DescTipo.HeaderText = "DescTipo";
            this.DescTipo.Name = "DescTipo";
            this.DescTipo.Visible = false;
            // 
            // Inactivo
            // 
            this.Inactivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Inactivo.FillWeight = 30.45685F;
            this.Inactivo.HeaderText = "Inactivo";
            this.Inactivo.Name = "Inactivo";
            this.Inactivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Inactivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.buttonGuardar);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 503);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(677, 30);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
            this.buttonGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonGuardar.Location = new System.Drawing.Point(552, 0);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(125, 30);
            this.buttonGuardar.TabIndex = 2;
            this.buttonGuardar.Text = "Actualizar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.txtAgregar);
            this.metroPanel2.Controls.Add(this.buttonActu);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(677, 28);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // buttonActu
            // 
            this.buttonActu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonActu.BackgroundImage")));
            this.buttonActu.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonActu.Location = new System.Drawing.Point(552, 0);
            this.buttonActu.Name = "buttonActu";
            this.buttonActu.Size = new System.Drawing.Size(125, 28);
            this.buttonActu.TabIndex = 3;
            this.buttonActu.Text = "Agregar";
            this.buttonActu.UseVisualStyleBackColor = true;
            this.buttonActu.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAgregar
            // 
            this.txtAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAgregar.Lines = new string[0];
            this.txtAgregar.Location = new System.Drawing.Point(0, 0);
            this.txtAgregar.MaxLength = 32767;
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.PasswordChar = '\0';
            this.txtAgregar.PromptText = "Escriba el procedimiento";
            this.txtAgregar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAgregar.SelectedText = "";
            this.txtAgregar.Size = new System.Drawing.Size(552, 28);
            this.txtAgregar.TabIndex = 2;
            this.txtAgregar.UseSelectable = true;
            // 
            // EditProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 553);
            this.Controls.Add(this.dataGridViewProc);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Name = "EditProcedimientos";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Lista de Procedimientos";
            this.Load += new System.EventHandler(this.EditProcedimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProc)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProc;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button buttonGuardar;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtAgregar;
        private System.Windows.Forms.Button buttonActu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_procedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescTipo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Inactivo;
    }
}