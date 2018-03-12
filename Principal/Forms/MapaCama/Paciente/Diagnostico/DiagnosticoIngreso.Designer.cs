namespace Principal.Forms.MapaCama.Paciente.Diagnostico
{
    partial class DiagnosticoIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticoIngreso));
            this.panelIngreso = new MetroFramework.Controls.MetroPanel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblDiagnostico_id = new MetroFramework.Controls.MetroLabel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupDiagnosticoIngreso = new System.Windows.Forms.GroupBox();
            this.groupDiagnosticoTerciarioIngreso = new System.Windows.Forms.GroupBox();
            this.cboDiagnosticoTerciarioItemIngreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoTerciarioCapituloIngreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoTerciarioSubRubroIngreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoTerciarioRubroIngreso = new MetroFramework.Controls.MetroComboBox();
            this.groupDiagnosticoSecundarioIngreso = new System.Windows.Forms.GroupBox();
            this.cboDiagnosticoSecundarioItemIngreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoSecundarioCapituloIngreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoSecundarioSubRubroIngreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoSecundarioRubroIngreso = new MetroFramework.Controls.MetroComboBox();
            this.groupDiagnosticoPrincipalIngreso = new System.Windows.Forms.GroupBox();
            this.cboDiagnosticoPrincipalItemIngreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoPrincipalCapituloIngreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoPrincipalSubRubroIngreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoPrincipalRubroIngreso = new MetroFramework.Controls.MetroComboBox();
            this.panelIngreso.SuspendLayout();
            this.groupDiagnosticoIngreso.SuspendLayout();
            this.groupDiagnosticoTerciarioIngreso.SuspendLayout();
            this.groupDiagnosticoSecundarioIngreso.SuspendLayout();
            this.groupDiagnosticoPrincipalIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIngreso
            // 
            this.panelIngreso.Controls.Add(this.btnModificar);
            this.panelIngreso.Controls.Add(this.lblDiagnostico_id);
            this.panelIngreso.Controls.Add(this.btnSalir);
            this.panelIngreso.Controls.Add(this.btnGuardar);
            this.panelIngreso.Controls.Add(this.groupDiagnosticoIngreso);
            this.panelIngreso.HorizontalScrollbarBarColor = true;
            this.panelIngreso.HorizontalScrollbarHighlightOnWheel = false;
            this.panelIngreso.HorizontalScrollbarSize = 10;
            this.panelIngreso.Location = new System.Drawing.Point(10, 22);
            this.panelIngreso.Name = "panelIngreso";
            this.panelIngreso.Size = new System.Drawing.Size(829, 612);
            this.panelIngreso.TabIndex = 0;
            this.panelIngreso.VerticalScrollbarBarColor = true;
            this.panelIngreso.VerticalScrollbarHighlightOnWheel = false;
            this.panelIngreso.VerticalScrollbarSize = 10;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.Image = global::Principal.Properties.Resources.LogoEncuesta;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(484, 583);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 26);
            this.btnModificar.TabIndex = 96;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblDiagnostico_id
            // 
            this.lblDiagnostico_id.AutoSize = true;
            this.lblDiagnostico_id.Location = new System.Drawing.Point(334, 586);
            this.lblDiagnostico_id.Name = "lblDiagnostico_id";
            this.lblDiagnostico_id.Size = new System.Drawing.Size(93, 19);
            this.lblDiagnostico_id.TabIndex = 17;
            this.lblDiagnostico_id.Text = "diagnostico_id";
            this.lblDiagnostico_id.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.Image = global::Principal.Properties.Resources.LogoSalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(716, 583);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 26);
            this.btnSalir.TabIndex = 3;
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
            this.btnGuardar.Location = new System.Drawing.Point(600, 583);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 26);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupDiagnosticoIngreso
            // 
            this.groupDiagnosticoIngreso.Controls.Add(this.groupDiagnosticoTerciarioIngreso);
            this.groupDiagnosticoIngreso.Controls.Add(this.groupDiagnosticoSecundarioIngreso);
            this.groupDiagnosticoIngreso.Controls.Add(this.groupDiagnosticoPrincipalIngreso);
            this.groupDiagnosticoIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDiagnosticoIngreso.Location = new System.Drawing.Point(3, 3);
            this.groupDiagnosticoIngreso.Name = "groupDiagnosticoIngreso";
            this.groupDiagnosticoIngreso.Size = new System.Drawing.Size(822, 576);
            this.groupDiagnosticoIngreso.TabIndex = 0;
            this.groupDiagnosticoIngreso.TabStop = false;
            this.groupDiagnosticoIngreso.Text = "Diagnosticos Ingreso";
            // 
            // groupDiagnosticoTerciarioIngreso
            // 
            this.groupDiagnosticoTerciarioIngreso.Controls.Add(this.cboDiagnosticoTerciarioItemIngreso);
            this.groupDiagnosticoTerciarioIngreso.Controls.Add(this.cboDiagnosticoTerciarioCapituloIngreso);
            this.groupDiagnosticoTerciarioIngreso.Controls.Add(this.cboDiagnosticoTerciarioSubRubroIngreso);
            this.groupDiagnosticoTerciarioIngreso.Controls.Add(this.cboDiagnosticoTerciarioRubroIngreso);
            this.groupDiagnosticoTerciarioIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDiagnosticoTerciarioIngreso.Location = new System.Drawing.Point(10, 393);
            this.groupDiagnosticoTerciarioIngreso.Name = "groupDiagnosticoTerciarioIngreso";
            this.groupDiagnosticoTerciarioIngreso.Size = new System.Drawing.Size(801, 173);
            this.groupDiagnosticoTerciarioIngreso.TabIndex = 98;
            this.groupDiagnosticoTerciarioIngreso.TabStop = false;
            this.groupDiagnosticoTerciarioIngreso.Text = "Diagnostico Secundario 2";
            // 
            // cboDiagnosticoTerciarioItemIngreso
            // 
            this.cboDiagnosticoTerciarioItemIngreso.FormattingEnabled = true;
            this.cboDiagnosticoTerciarioItemIngreso.ItemHeight = 23;
            this.cboDiagnosticoTerciarioItemIngreso.Location = new System.Drawing.Point(10, 132);
            this.cboDiagnosticoTerciarioItemIngreso.Name = "cboDiagnosticoTerciarioItemIngreso";
            this.cboDiagnosticoTerciarioItemIngreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoTerciarioItemIngreso.TabIndex = 10;
            this.cboDiagnosticoTerciarioItemIngreso.UseSelectable = true;
            // 
            // cboDiagnosticoTerciarioCapituloIngreso
            // 
            this.cboDiagnosticoTerciarioCapituloIngreso.FormattingEnabled = true;
            this.cboDiagnosticoTerciarioCapituloIngreso.ItemHeight = 23;
            this.cboDiagnosticoTerciarioCapituloIngreso.Location = new System.Drawing.Point(10, 27);
            this.cboDiagnosticoTerciarioCapituloIngreso.Name = "cboDiagnosticoTerciarioCapituloIngreso";
            this.cboDiagnosticoTerciarioCapituloIngreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoTerciarioCapituloIngreso.TabIndex = 1;
            this.cboDiagnosticoTerciarioCapituloIngreso.UseSelectable = true;
            this.cboDiagnosticoTerciarioCapituloIngreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoTerciarioCapituloIngreso_SelectedIndexChanged);
            // 
            // cboDiagnosticoTerciarioSubRubroIngreso
            // 
            this.cboDiagnosticoTerciarioSubRubroIngreso.FormattingEnabled = true;
            this.cboDiagnosticoTerciarioSubRubroIngreso.ItemHeight = 23;
            this.cboDiagnosticoTerciarioSubRubroIngreso.Location = new System.Drawing.Point(10, 97);
            this.cboDiagnosticoTerciarioSubRubroIngreso.Name = "cboDiagnosticoTerciarioSubRubroIngreso";
            this.cboDiagnosticoTerciarioSubRubroIngreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoTerciarioSubRubroIngreso.TabIndex = 8;
            this.cboDiagnosticoTerciarioSubRubroIngreso.UseSelectable = true;
            this.cboDiagnosticoTerciarioSubRubroIngreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoTerciarioSubRubroIngreso_SelectedIndexChanged);
            // 
            // cboDiagnosticoTerciarioRubroIngreso
            // 
            this.cboDiagnosticoTerciarioRubroIngreso.FormattingEnabled = true;
            this.cboDiagnosticoTerciarioRubroIngreso.ItemHeight = 23;
            this.cboDiagnosticoTerciarioRubroIngreso.Location = new System.Drawing.Point(10, 62);
            this.cboDiagnosticoTerciarioRubroIngreso.Name = "cboDiagnosticoTerciarioRubroIngreso";
            this.cboDiagnosticoTerciarioRubroIngreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoTerciarioRubroIngreso.TabIndex = 7;
            this.cboDiagnosticoTerciarioRubroIngreso.UseSelectable = true;
            this.cboDiagnosticoTerciarioRubroIngreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoTerciarioRubroIngreso_SelectedIndexChanged);
            // 
            // groupDiagnosticoSecundarioIngreso
            // 
            this.groupDiagnosticoSecundarioIngreso.Controls.Add(this.cboDiagnosticoSecundarioItemIngreso);
            this.groupDiagnosticoSecundarioIngreso.Controls.Add(this.cboDiagnosticoSecundarioCapituloIngreso);
            this.groupDiagnosticoSecundarioIngreso.Controls.Add(this.cboDiagnosticoSecundarioSubRubroIngreso);
            this.groupDiagnosticoSecundarioIngreso.Controls.Add(this.cboDiagnosticoSecundarioRubroIngreso);
            this.groupDiagnosticoSecundarioIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDiagnosticoSecundarioIngreso.Location = new System.Drawing.Point(10, 209);
            this.groupDiagnosticoSecundarioIngreso.Name = "groupDiagnosticoSecundarioIngreso";
            this.groupDiagnosticoSecundarioIngreso.Size = new System.Drawing.Size(801, 173);
            this.groupDiagnosticoSecundarioIngreso.TabIndex = 97;
            this.groupDiagnosticoSecundarioIngreso.TabStop = false;
            this.groupDiagnosticoSecundarioIngreso.Text = "Diagnostico Secundario 1";
            // 
            // cboDiagnosticoSecundarioItemIngreso
            // 
            this.cboDiagnosticoSecundarioItemIngreso.FormattingEnabled = true;
            this.cboDiagnosticoSecundarioItemIngreso.ItemHeight = 23;
            this.cboDiagnosticoSecundarioItemIngreso.Location = new System.Drawing.Point(10, 132);
            this.cboDiagnosticoSecundarioItemIngreso.Name = "cboDiagnosticoSecundarioItemIngreso";
            this.cboDiagnosticoSecundarioItemIngreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoSecundarioItemIngreso.TabIndex = 10;
            this.cboDiagnosticoSecundarioItemIngreso.UseSelectable = true;
            // 
            // cboDiagnosticoSecundarioCapituloIngreso
            // 
            this.cboDiagnosticoSecundarioCapituloIngreso.FormattingEnabled = true;
            this.cboDiagnosticoSecundarioCapituloIngreso.ItemHeight = 23;
            this.cboDiagnosticoSecundarioCapituloIngreso.Location = new System.Drawing.Point(10, 27);
            this.cboDiagnosticoSecundarioCapituloIngreso.Name = "cboDiagnosticoSecundarioCapituloIngreso";
            this.cboDiagnosticoSecundarioCapituloIngreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoSecundarioCapituloIngreso.TabIndex = 1;
            this.cboDiagnosticoSecundarioCapituloIngreso.UseSelectable = true;
            this.cboDiagnosticoSecundarioCapituloIngreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoSecundarioCapituloIngreso_SelectedIndexChanged);
            // 
            // cboDiagnosticoSecundarioSubRubroIngreso
            // 
            this.cboDiagnosticoSecundarioSubRubroIngreso.FormattingEnabled = true;
            this.cboDiagnosticoSecundarioSubRubroIngreso.ItemHeight = 23;
            this.cboDiagnosticoSecundarioSubRubroIngreso.Location = new System.Drawing.Point(10, 97);
            this.cboDiagnosticoSecundarioSubRubroIngreso.Name = "cboDiagnosticoSecundarioSubRubroIngreso";
            this.cboDiagnosticoSecundarioSubRubroIngreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoSecundarioSubRubroIngreso.TabIndex = 8;
            this.cboDiagnosticoSecundarioSubRubroIngreso.UseSelectable = true;
            this.cboDiagnosticoSecundarioSubRubroIngreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoSecundarioSubRubroIngreso_SelectedIndexChanged);
            // 
            // cboDiagnosticoSecundarioRubroIngreso
            // 
            this.cboDiagnosticoSecundarioRubroIngreso.FormattingEnabled = true;
            this.cboDiagnosticoSecundarioRubroIngreso.ItemHeight = 23;
            this.cboDiagnosticoSecundarioRubroIngreso.Location = new System.Drawing.Point(10, 62);
            this.cboDiagnosticoSecundarioRubroIngreso.Name = "cboDiagnosticoSecundarioRubroIngreso";
            this.cboDiagnosticoSecundarioRubroIngreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoSecundarioRubroIngreso.TabIndex = 7;
            this.cboDiagnosticoSecundarioRubroIngreso.UseSelectable = true;
            this.cboDiagnosticoSecundarioRubroIngreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoSecundarioRubroIngreso_SelectedIndexChanged);
            // 
            // groupDiagnosticoPrincipalIngreso
            // 
            this.groupDiagnosticoPrincipalIngreso.Controls.Add(this.cboDiagnosticoPrincipalItemIngreso);
            this.groupDiagnosticoPrincipalIngreso.Controls.Add(this.cboDiagnosticoPrincipalCapituloIngreso);
            this.groupDiagnosticoPrincipalIngreso.Controls.Add(this.cboDiagnosticoPrincipalSubRubroIngreso);
            this.groupDiagnosticoPrincipalIngreso.Controls.Add(this.cboDiagnosticoPrincipalRubroIngreso);
            this.groupDiagnosticoPrincipalIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDiagnosticoPrincipalIngreso.Location = new System.Drawing.Point(10, 27);
            this.groupDiagnosticoPrincipalIngreso.Name = "groupDiagnosticoPrincipalIngreso";
            this.groupDiagnosticoPrincipalIngreso.Size = new System.Drawing.Size(801, 173);
            this.groupDiagnosticoPrincipalIngreso.TabIndex = 96;
            this.groupDiagnosticoPrincipalIngreso.TabStop = false;
            this.groupDiagnosticoPrincipalIngreso.Text = "Diagnostico Principal";
            // 
            // cboDiagnosticoPrincipalItemIngreso
            // 
            this.cboDiagnosticoPrincipalItemIngreso.FormattingEnabled = true;
            this.cboDiagnosticoPrincipalItemIngreso.ItemHeight = 23;
            this.cboDiagnosticoPrincipalItemIngreso.Location = new System.Drawing.Point(10, 132);
            this.cboDiagnosticoPrincipalItemIngreso.Name = "cboDiagnosticoPrincipalItemIngreso";
            this.cboDiagnosticoPrincipalItemIngreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoPrincipalItemIngreso.TabIndex = 9;
            this.cboDiagnosticoPrincipalItemIngreso.UseSelectable = true;
            // 
            // cboDiagnosticoPrincipalCapituloIngreso
            // 
            this.cboDiagnosticoPrincipalCapituloIngreso.FormattingEnabled = true;
            this.cboDiagnosticoPrincipalCapituloIngreso.ItemHeight = 23;
            this.cboDiagnosticoPrincipalCapituloIngreso.Location = new System.Drawing.Point(10, 27);
            this.cboDiagnosticoPrincipalCapituloIngreso.Name = "cboDiagnosticoPrincipalCapituloIngreso";
            this.cboDiagnosticoPrincipalCapituloIngreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoPrincipalCapituloIngreso.TabIndex = 1;
            this.cboDiagnosticoPrincipalCapituloIngreso.UseSelectable = true;
            this.cboDiagnosticoPrincipalCapituloIngreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoPrincipalCapituloIngreso_SelectedIndexChanged);
            // 
            // cboDiagnosticoPrincipalSubRubroIngreso
            // 
            this.cboDiagnosticoPrincipalSubRubroIngreso.FormattingEnabled = true;
            this.cboDiagnosticoPrincipalSubRubroIngreso.ItemHeight = 23;
            this.cboDiagnosticoPrincipalSubRubroIngreso.Location = new System.Drawing.Point(10, 97);
            this.cboDiagnosticoPrincipalSubRubroIngreso.Name = "cboDiagnosticoPrincipalSubRubroIngreso";
            this.cboDiagnosticoPrincipalSubRubroIngreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoPrincipalSubRubroIngreso.TabIndex = 8;
            this.cboDiagnosticoPrincipalSubRubroIngreso.UseSelectable = true;
            this.cboDiagnosticoPrincipalSubRubroIngreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoPrincipalSubRubroIngreso_SelectedIndexChanged);
            // 
            // cboDiagnosticoPrincipalRubroIngreso
            // 
            this.cboDiagnosticoPrincipalRubroIngreso.FormattingEnabled = true;
            this.cboDiagnosticoPrincipalRubroIngreso.ItemHeight = 23;
            this.cboDiagnosticoPrincipalRubroIngreso.Location = new System.Drawing.Point(10, 62);
            this.cboDiagnosticoPrincipalRubroIngreso.Name = "cboDiagnosticoPrincipalRubroIngreso";
            this.cboDiagnosticoPrincipalRubroIngreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoPrincipalRubroIngreso.TabIndex = 7;
            this.cboDiagnosticoPrincipalRubroIngreso.UseSelectable = true;
            this.cboDiagnosticoPrincipalRubroIngreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoPrincipalRubroIngreso_SelectedIndexChanged);
            // 
            // DiagnosticoIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 644);
            this.Controls.Add(this.panelIngreso);
            this.Name = "DiagnosticoIngreso";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.DiagnosticoIngreso_Load);
            this.panelIngreso.ResumeLayout(false);
            this.panelIngreso.PerformLayout();
            this.groupDiagnosticoIngreso.ResumeLayout(false);
            this.groupDiagnosticoTerciarioIngreso.ResumeLayout(false);
            this.groupDiagnosticoSecundarioIngreso.ResumeLayout(false);
            this.groupDiagnosticoPrincipalIngreso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDiagnosticoIngreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoPrincipalCapituloIngreso;
        private MetroFramework.Controls.MetroPanel panelIngreso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoPrincipalRubroIngreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoPrincipalSubRubroIngreso;
        private System.Windows.Forms.GroupBox groupDiagnosticoPrincipalIngreso;
        private System.Windows.Forms.GroupBox groupDiagnosticoTerciarioIngreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoTerciarioCapituloIngreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoTerciarioSubRubroIngreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoTerciarioRubroIngreso;
        private System.Windows.Forms.GroupBox groupDiagnosticoSecundarioIngreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoSecundarioCapituloIngreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoSecundarioSubRubroIngreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoSecundarioRubroIngreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoTerciarioItemIngreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoSecundarioItemIngreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoPrincipalItemIngreso;
        private MetroFramework.Controls.MetroLabel lblDiagnostico_id;
        private System.Windows.Forms.Button btnModificar;
    }
}