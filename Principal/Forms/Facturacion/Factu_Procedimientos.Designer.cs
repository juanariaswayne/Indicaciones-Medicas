namespace Principal.Forms.Facturacion
{
    partial class Factu_Procedimientos
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dateHasta = new MetroFramework.Controls.MetroDateTime();
            this.dateDesde = new MetroFramework.Controls.MetroDateTime();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.dataGridViewProcedimientos = new System.Windows.Forms.DataGridView();
            this.SUMINISTRO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENERICO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INICIOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUMINISTRO_ID_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROCEDIMIENTO_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIAS_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FINP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECK_2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDescartables = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDescartables)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(131, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Hasta";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Desde";
            // 
            // dateHasta
            // 
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHasta.Location = new System.Drawing.Point(134, 26);
            this.dateHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(107, 29);
            this.dateHasta.TabIndex = 5;
            // 
            // dateDesde
            // 
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDesde.Location = new System.Drawing.Point(20, 26);
            this.dateDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(107, 29);
            this.dateDesde.TabIndex = 4;
            this.dateDesde.ValueChanged += new System.EventHandler(this.dateDesde_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTile1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 637);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 46);
            this.panel1.TabIndex = 9;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroTile1.Location = new System.Drawing.Point(1042, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(243, 46);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Imprimir procedimientos historico";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            // 
            // dataGridViewProcedimientos
            // 
            this.dataGridViewProcedimientos.AllowUserToAddRows = false;
            this.dataGridViewProcedimientos.AllowUserToDeleteRows = false;
            this.dataGridViewProcedimientos.AllowUserToOrderColumns = true;
            this.dataGridViewProcedimientos.AllowUserToResizeRows = false;
            this.dataGridViewProcedimientos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcedimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SUMINISTRO_ID,
            this.ID_2,
            this.GENERICO_ID,
            this.INICIOP,
            this.SUMINISTRO_ID_2,
            this.PROCEDIMIENTO_2,
            this.HORARIO_2,
            this.DIAS_2,
            this.OBS_2,
            this.FINP,
            this.CHECK_2,
            this.TIPO});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProcedimientos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProcedimientos.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewProcedimientos.MultiSelect = false;
            this.dataGridViewProcedimientos.Name = "dataGridViewProcedimientos";
            this.dataGridViewProcedimientos.RowHeadersVisible = false;
            this.dataGridViewProcedimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcedimientos.Size = new System.Drawing.Size(980, 577);
            this.dataGridViewProcedimientos.TabIndex = 14;
            this.dataGridViewProcedimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcedimientos_CellContentClick);
            this.dataGridViewProcedimientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcedimientos_CellDoubleClick);
            this.dataGridViewProcedimientos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcedimientos_CellValueChanged);
            // 
            // SUMINISTRO_ID
            // 
            this.SUMINISTRO_ID.HeaderText = "SUMINISTRO_ID";
            this.SUMINISTRO_ID.Name = "SUMINISTRO_ID";
            this.SUMINISTRO_ID.Visible = false;
            // 
            // ID_2
            // 
            this.ID_2.HeaderText = "ID_PROCEDIMIENTO";
            this.ID_2.Name = "ID_2";
            this.ID_2.Visible = false;
            // 
            // GENERICO_ID
            // 
            this.GENERICO_ID.HeaderText = "GENERICO_ID";
            this.GENERICO_ID.Name = "GENERICO_ID";
            this.GENERICO_ID.Visible = false;
            // 
            // INICIOP
            // 
            this.INICIOP.HeaderText = "INICIO";
            this.INICIOP.Name = "INICIOP";
            this.INICIOP.Width = 80;
            // 
            // SUMINISTRO_ID_2
            // 
            this.SUMINISTRO_ID_2.HeaderText = "ID";
            this.SUMINISTRO_ID_2.Name = "SUMINISTRO_ID_2";
            this.SUMINISTRO_ID_2.Width = 80;
            // 
            // PROCEDIMIENTO_2
            // 
            this.PROCEDIMIENTO_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PROCEDIMIENTO_2.HeaderText = "PROCEDIMIENTO";
            this.PROCEDIMIENTO_2.Name = "PROCEDIMIENTO_2";
            this.PROCEDIMIENTO_2.ReadOnly = true;
            // 
            // HORARIO_2
            // 
            this.HORARIO_2.HeaderText = "HORARIO";
            this.HORARIO_2.Name = "HORARIO_2";
            this.HORARIO_2.ReadOnly = true;
            // 
            // DIAS_2
            // 
            this.DIAS_2.HeaderText = "DIAS";
            this.DIAS_2.Name = "DIAS_2";
            this.DIAS_2.ReadOnly = true;
            // 
            // OBS_2
            // 
            this.OBS_2.HeaderText = "OBS";
            this.OBS_2.Name = "OBS_2";
            this.OBS_2.ReadOnly = true;
            this.OBS_2.Width = 200;
            // 
            // FINP
            // 
            this.FINP.HeaderText = "FIN";
            this.FINP.Name = "FINP";
            this.FINP.Width = 80;
            // 
            // CHECK_2
            // 
            this.CHECK_2.HeaderText = "✓";
            this.CHECK_2.Name = "CHECK_2";
            this.CHECK_2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHECK_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CHECK_2.Width = 20;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.Visible = false;
            // 
            // dataGridViewDescartables
            // 
            this.dataGridViewDescartables.AllowUserToAddRows = false;
            this.dataGridViewDescartables.AllowUserToDeleteRows = false;
            this.dataGridViewDescartables.AllowUserToOrderColumns = true;
            this.dataGridViewDescartables.AllowUserToResizeRows = false;
            this.dataGridViewDescartables.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDescartables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDescartables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDescartables.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDescartables.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewDescartables.Location = new System.Drawing.Point(1000, 60);
            this.dataGridViewDescartables.MultiSelect = false;
            this.dataGridViewDescartables.Name = "dataGridViewDescartables";
            this.dataGridViewDescartables.RowHeadersVisible = false;
            this.dataGridViewDescartables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDescartables.Size = new System.Drawing.Size(305, 577);
            this.dataGridViewDescartables.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "ID_CIERRE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "SUMINISTRO_ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.HeaderText = "Cod_Desc";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // Factu_Procedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 703);
            this.Controls.Add(this.dataGridViewProcedimientos);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.dataGridViewDescartables);
            this.Controls.Add(this.panel1);
            this.Name = "Factu_Procedimientos";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Procedimientos";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Factu_Procedimientos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDescartables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dateHasta;
        private MetroFramework.Controls.MetroDateTime dateDesde;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DataGridView dataGridViewProcedimientos;
        private System.Windows.Forms.DataGridView dataGridViewDescartables;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUMINISTRO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENERICO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn INICIOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUMINISTRO_ID_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROCEDIMIENTO_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAS_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
    }
}