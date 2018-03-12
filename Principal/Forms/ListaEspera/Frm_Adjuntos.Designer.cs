namespace Principal.Forms.ListaEspera
{
    partial class Frm_Adjuntos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTileNuevoIngreso = new MetroFramework.Controls.MetroTile();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewAdjuntos = new System.Windows.Forms.DataGridView();
            this.pathCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArchivo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Elimina = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.btnSalir.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.metroTileNuevoIngreso);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 40);
            this.panel1.TabIndex = 24;
            // 
            // metroTileNuevoIngreso
            // 
            this.metroTileNuevoIngreso.ActiveControl = null;
            this.metroTileNuevoIngreso.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroTileNuevoIngreso.Location = new System.Drawing.Point(0, 0);
            this.metroTileNuevoIngreso.Name = "metroTileNuevoIngreso";
            this.metroTileNuevoIngreso.Size = new System.Drawing.Size(116, 38);
            this.metroTileNuevoIngreso.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileNuevoIngreso.TabIndex = 7;
            this.metroTileNuevoIngreso.Text = "Borrar Adjuntos";
            this.metroTileNuevoIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileNuevoIngreso.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTileNuevoIngreso.UseSelectable = true;
            this.metroTileNuevoIngreso.Click += new System.EventHandler(this.metroTileNuevoIngreso_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveControl = null;
            this.btnSalir.Controls.Add(this.splitter2);
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Location = new System.Drawing.Point(359, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 38);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 38);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewAdjuntos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 258);
            this.panel2.TabIndex = 25;
            // 
            // dataGridViewAdjuntos
            // 
            this.dataGridViewAdjuntos.AllowUserToAddRows = false;
            this.dataGridViewAdjuntos.AllowUserToDeleteRows = false;
            this.dataGridViewAdjuntos.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdjuntos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAdjuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdjuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pathCompleto,
            this.NombreArchivo,
            this.Elimina});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdjuntos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAdjuntos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAdjuntos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAdjuntos.MultiSelect = false;
            this.dataGridViewAdjuntos.Name = "dataGridViewAdjuntos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdjuntos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAdjuntos.RowHeadersVisible = false;
            this.dataGridViewAdjuntos.Size = new System.Drawing.Size(457, 258);
            this.dataGridViewAdjuntos.TabIndex = 0;
            this.dataGridViewAdjuntos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdjuntos_CellContentClick);
            this.dataGridViewAdjuntos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewAdjuntos_CurrentCellDirtyStateChanged);
            // 
            // pathCompleto
            // 
            this.pathCompleto.HeaderText = "pathCompleto";
            this.pathCompleto.Name = "pathCompleto";
            this.pathCompleto.Visible = false;
            // 
            // NombreArchivo
            // 
            this.NombreArchivo.HeaderText = "Nombre Archivo";
            this.NombreArchivo.Name = "NombreArchivo";
            this.NombreArchivo.Width = 300;
            // 
            // Elimina
            // 
            this.Elimina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Elimina.HeaderText = "Eliminar";
            this.Elimina.Name = "Elimina";
            // 
            // Frm_Adjuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 378);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Adjuntos";
            this.Text = "Adjuntos Cargados";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Frm_Adjuntos_Load);
            this.panel1.ResumeLayout(false);
            this.btnSalir.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjuntos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile metroTileNuevoIngreso;
        private MetroFramework.Controls.MetroTile btnSalir;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewAdjuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathCompleto;
        private System.Windows.Forms.DataGridViewLinkColumn NombreArchivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elimina;
    }
}