namespace Principal.Forms.Parametros.Procedimiento
{
    partial class ProcedimientoDescartable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcedimientoDescartable));
            this.panelProDesc = new System.Windows.Forms.Panel();
            this.dataGridViewProcedimientos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.procedimiento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDesc = new System.Windows.Forms.DataGridView();
            this.buttonAsociar = new System.Windows.Forms.Button();
            this.txtBuscarPro = new MetroFramework.Controls.MetroTextBox();
            this.txtDescartable = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descartable_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imprimible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelProDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedimientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProDesc
            // 
            this.panelProDesc.Controls.Add(this.groupBox2);
            this.panelProDesc.Controls.Add(this.groupBox1);
            this.panelProDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProDesc.Location = new System.Drawing.Point(20, 60);
            this.panelProDesc.Name = "panelProDesc";
            this.panelProDesc.Size = new System.Drawing.Size(860, 405);
            this.panelProDesc.TabIndex = 0;
            // 
            // dataGridViewProcedimientos
            // 
            this.dataGridViewProcedimientos.AllowUserToAddRows = false;
            this.dataGridViewProcedimientos.AllowUserToDeleteRows = false;
            this.dataGridViewProcedimientos.AllowUserToResizeColumns = false;
            this.dataGridViewProcedimientos.AllowUserToResizeRows = false;
            this.dataGridViewProcedimientos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcedimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.procedimiento_id,
            this.DescPro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProcedimientos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProcedimientos.Location = new System.Drawing.Point(3, 39);
            this.dataGridViewProcedimientos.Name = "dataGridViewProcedimientos";
            this.dataGridViewProcedimientos.ReadOnly = true;
            this.dataGridViewProcedimientos.RowHeadersVisible = false;
            this.dataGridViewProcedimientos.Size = new System.Drawing.Size(439, 363);
            this.dataGridViewProcedimientos.TabIndex = 0;
            this.dataGridViewProcedimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcedimientos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewProcedimientos);
            this.groupBox1.Controls.Add(this.txtBuscarPro);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 405);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procedimientos";
            // 
            // procedimiento_id
            // 
            this.procedimiento_id.HeaderText = "procedimiento_id";
            this.procedimiento_id.Name = "procedimiento_id";
            this.procedimiento_id.ReadOnly = true;
            this.procedimiento_id.Visible = false;
            // 
            // DescPro
            // 
            this.DescPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescPro.HeaderText = "Procedimiento";
            this.DescPro.Name = "DescPro";
            this.DescPro.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDesc);
            this.groupBox2.Controls.Add(this.txtDescartable);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(445, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 405);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descartables";
            // 
            // dataGridViewDesc
            // 
            this.dataGridViewDesc.AllowUserToAddRows = false;
            this.dataGridViewDesc.AllowUserToDeleteRows = false;
            this.dataGridViewDesc.AllowUserToResizeColumns = false;
            this.dataGridViewDesc.AllowUserToResizeRows = false;
            this.dataGridViewDesc.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDesc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descartable_id,
            this.DesDesc,
            this.cantidad,
            this.check,
            this.imprimible});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDesc.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDesc.Location = new System.Drawing.Point(3, 39);
            this.dataGridViewDesc.Name = "dataGridViewDesc";
            this.dataGridViewDesc.RowHeadersVisible = false;
            this.dataGridViewDesc.Size = new System.Drawing.Size(409, 363);
            this.dataGridViewDesc.TabIndex = 0;
            // 
            // buttonAsociar
            // 
            this.buttonAsociar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAsociar.BackgroundImage")));
            this.buttonAsociar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAsociar.Location = new System.Drawing.Point(735, 0);
            this.buttonAsociar.Name = "buttonAsociar";
            this.buttonAsociar.Size = new System.Drawing.Size(125, 30);
            this.buttonAsociar.TabIndex = 1;
            this.buttonAsociar.Text = "Asociar";
            this.buttonAsociar.UseVisualStyleBackColor = true;
            this.buttonAsociar.Click += new System.EventHandler(this.buttonAsociar_Click);
            // 
            // txtBuscarPro
            // 
            this.txtBuscarPro.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBuscarPro.Lines = new string[0];
            this.txtBuscarPro.Location = new System.Drawing.Point(3, 16);
            this.txtBuscarPro.MaxLength = 32767;
            this.txtBuscarPro.Name = "txtBuscarPro";
            this.txtBuscarPro.PasswordChar = '\0';
            this.txtBuscarPro.PromptText = "Buscar Procedimiento";
            this.txtBuscarPro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarPro.SelectedText = "";
            this.txtBuscarPro.Size = new System.Drawing.Size(439, 23);
            this.txtBuscarPro.TabIndex = 1;
            this.txtBuscarPro.UseSelectable = true;
            this.txtBuscarPro.TextChanged += new System.EventHandler(this.txtBuscarPro_TextChanged);
            // 
            // txtDescartable
            // 
            this.txtDescartable.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescartable.Lines = new string[0];
            this.txtDescartable.Location = new System.Drawing.Point(3, 16);
            this.txtDescartable.MaxLength = 32767;
            this.txtDescartable.Name = "txtDescartable";
            this.txtDescartable.PasswordChar = '\0';
            this.txtDescartable.PromptText = "Buscar Descartable";
            this.txtDescartable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescartable.SelectedText = "";
            this.txtDescartable.Size = new System.Drawing.Size(409, 23);
            this.txtDescartable.TabIndex = 2;
            this.txtDescartable.UseSelectable = true;
            this.txtDescartable.TextChanged += new System.EventHandler(this.txtDescartable_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAsociar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 30);
            this.panel1.TabIndex = 2;
            // 
            // descartable_id
            // 
            this.descartable_id.HeaderText = "descartable_id";
            this.descartable_id.Name = "descartable_id";
            this.descartable_id.Visible = false;
            // 
            // DesDesc
            // 
            this.DesDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DesDesc.FillWeight = 246.142F;
            this.DesDesc.HeaderText = "Descartable";
            this.DesDesc.Name = "DesDesc";
            this.DesDesc.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.FillWeight = 60.9137F;
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
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
            // imprimible
            // 
            this.imprimible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imprimible.FillWeight = 46.13855F;
            this.imprimible.HeaderText = "Imprime";
            this.imprimible.Name = "imprimible";
            this.imprimible.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imprimible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProcedimientoDescartable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 515);
            this.Controls.Add(this.panelProDesc);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcedimientoDescartable";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Procedimientos / Descartables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcedimientoDescartable_FormClosed);
            this.Load += new System.EventHandler(this.ProcedimientoDescartable_Load);
            this.panelProDesc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedimientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewProcedimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn procedimiento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescPro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewDesc;
        private System.Windows.Forms.Button buttonAsociar;
        private MetroFramework.Controls.MetroTextBox txtBuscarPro;
        private MetroFramework.Controls.MetroTextBox txtDescartable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descartable_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewCheckBoxColumn imprimible;
    }
}