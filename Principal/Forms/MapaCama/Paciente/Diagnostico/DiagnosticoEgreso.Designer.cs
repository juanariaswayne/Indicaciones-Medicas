namespace Principal.Forms.MapaCama.Paciente.Diagnostico
{
    partial class DiagnosticoEgreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticoEgreso));
            this.panelDiagnostico = new MetroFramework.Controls.MetroPanel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblDiagnostico_id = new MetroFramework.Controls.MetroLabel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupDiagnosticoEgreso = new System.Windows.Forms.GroupBox();
            this.groupDiagnosticoTerciarioEgreso = new System.Windows.Forms.GroupBox();
            this.cboDiagnosticoTerciarioItemEgreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoTerciarioCapituloEgreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoTerciarioSubRubroEgreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoTerciarioRubroEgreso = new MetroFramework.Controls.MetroComboBox();
            this.groupDiagnosticoSecundarioEgreso = new System.Windows.Forms.GroupBox();
            this.cboDiagnosticoSecundarioItemEgreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoSecundarioCapituloEgreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoSecundarioSubRubroEgreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoSecundarioRubroEgreso = new MetroFramework.Controls.MetroComboBox();
            this.groupDiagnosticoPrincipalEgreso = new System.Windows.Forms.GroupBox();
            this.cboDiagnosticoPrincipalItemEgreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoPrincipalCapituloEgreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoPrincipalSubRubroEgreso = new MetroFramework.Controls.MetroComboBox();
            this.cboDiagnosticoPrincipalRubroEgreso = new MetroFramework.Controls.MetroComboBox();
            this.panelDiagnostico.SuspendLayout();
            this.groupDiagnosticoEgreso.SuspendLayout();
            this.groupDiagnosticoTerciarioEgreso.SuspendLayout();
            this.groupDiagnosticoSecundarioEgreso.SuspendLayout();
            this.groupDiagnosticoPrincipalEgreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDiagnostico
            // 
            this.panelDiagnostico.Controls.Add(this.btnModificar);
            this.panelDiagnostico.Controls.Add(this.lblDiagnostico_id);
            this.panelDiagnostico.Controls.Add(this.btnSalir);
            this.panelDiagnostico.Controls.Add(this.btnGuardar);
            this.panelDiagnostico.Controls.Add(this.groupDiagnosticoEgreso);
            this.panelDiagnostico.HorizontalScrollbarBarColor = true;
            this.panelDiagnostico.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDiagnostico.HorizontalScrollbarSize = 10;
            this.panelDiagnostico.Location = new System.Drawing.Point(10, 22);
            this.panelDiagnostico.Name = "panelDiagnostico";
            this.panelDiagnostico.Size = new System.Drawing.Size(829, 612);
            this.panelDiagnostico.TabIndex = 1;
            this.panelDiagnostico.VerticalScrollbarBarColor = true;
            this.panelDiagnostico.VerticalScrollbarHighlightOnWheel = false;
            this.panelDiagnostico.VerticalScrollbarSize = 10;
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
            // groupDiagnosticoEgreso
            // 
            this.groupDiagnosticoEgreso.Controls.Add(this.groupDiagnosticoTerciarioEgreso);
            this.groupDiagnosticoEgreso.Controls.Add(this.groupDiagnosticoSecundarioEgreso);
            this.groupDiagnosticoEgreso.Controls.Add(this.groupDiagnosticoPrincipalEgreso);
            this.groupDiagnosticoEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDiagnosticoEgreso.Location = new System.Drawing.Point(3, 3);
            this.groupDiagnosticoEgreso.Name = "groupDiagnosticoEgreso";
            this.groupDiagnosticoEgreso.Size = new System.Drawing.Size(822, 576);
            this.groupDiagnosticoEgreso.TabIndex = 0;
            this.groupDiagnosticoEgreso.TabStop = false;
            this.groupDiagnosticoEgreso.Text = "Diagnosticos Egreso";
            // 
            // groupDiagnosticoTerciarioEgreso
            // 
            this.groupDiagnosticoTerciarioEgreso.Controls.Add(this.cboDiagnosticoTerciarioItemEgreso);
            this.groupDiagnosticoTerciarioEgreso.Controls.Add(this.cboDiagnosticoTerciarioCapituloEgreso);
            this.groupDiagnosticoTerciarioEgreso.Controls.Add(this.cboDiagnosticoTerciarioSubRubroEgreso);
            this.groupDiagnosticoTerciarioEgreso.Controls.Add(this.cboDiagnosticoTerciarioRubroEgreso);
            this.groupDiagnosticoTerciarioEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDiagnosticoTerciarioEgreso.Location = new System.Drawing.Point(10, 393);
            this.groupDiagnosticoTerciarioEgreso.Name = "groupDiagnosticoTerciarioEgreso";
            this.groupDiagnosticoTerciarioEgreso.Size = new System.Drawing.Size(801, 173);
            this.groupDiagnosticoTerciarioEgreso.TabIndex = 98;
            this.groupDiagnosticoTerciarioEgreso.TabStop = false;
            this.groupDiagnosticoTerciarioEgreso.Text = "Diagnostico Secundario 2";
            // 
            // cboDiagnosticoTerciarioItemEgreso
            // 
            this.cboDiagnosticoTerciarioItemEgreso.FormattingEnabled = true;
            this.cboDiagnosticoTerciarioItemEgreso.ItemHeight = 23;
            this.cboDiagnosticoTerciarioItemEgreso.Location = new System.Drawing.Point(10, 132);
            this.cboDiagnosticoTerciarioItemEgreso.Name = "cboDiagnosticoTerciarioItemEgreso";
            this.cboDiagnosticoTerciarioItemEgreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoTerciarioItemEgreso.TabIndex = 10;
            this.cboDiagnosticoTerciarioItemEgreso.UseSelectable = true;
            // 
            // cboDiagnosticoTerciarioCapituloEgreso
            // 
            this.cboDiagnosticoTerciarioCapituloEgreso.FormattingEnabled = true;
            this.cboDiagnosticoTerciarioCapituloEgreso.ItemHeight = 23;
            this.cboDiagnosticoTerciarioCapituloEgreso.Location = new System.Drawing.Point(10, 27);
            this.cboDiagnosticoTerciarioCapituloEgreso.Name = "cboDiagnosticoTerciarioCapituloEgreso";
            this.cboDiagnosticoTerciarioCapituloEgreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoTerciarioCapituloEgreso.TabIndex = 1;
            this.cboDiagnosticoTerciarioCapituloEgreso.UseSelectable = true;
            this.cboDiagnosticoTerciarioCapituloEgreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoTerciarioCapituloEgreso_SelectedIndexChanged);
            // 
            // cboDiagnosticoTerciarioSubRubroEgreso
            // 
            this.cboDiagnosticoTerciarioSubRubroEgreso.FormattingEnabled = true;
            this.cboDiagnosticoTerciarioSubRubroEgreso.ItemHeight = 23;
            this.cboDiagnosticoTerciarioSubRubroEgreso.Location = new System.Drawing.Point(10, 97);
            this.cboDiagnosticoTerciarioSubRubroEgreso.Name = "cboDiagnosticoTerciarioSubRubroEgreso";
            this.cboDiagnosticoTerciarioSubRubroEgreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoTerciarioSubRubroEgreso.TabIndex = 8;
            this.cboDiagnosticoTerciarioSubRubroEgreso.UseSelectable = true;
            this.cboDiagnosticoTerciarioSubRubroEgreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoTerciarioSubRubroEgreso_SelectedIndexChanged);
            // 
            // cboDiagnosticoTerciarioRubroEgreso
            // 
            this.cboDiagnosticoTerciarioRubroEgreso.FormattingEnabled = true;
            this.cboDiagnosticoTerciarioRubroEgreso.ItemHeight = 23;
            this.cboDiagnosticoTerciarioRubroEgreso.Location = new System.Drawing.Point(10, 62);
            this.cboDiagnosticoTerciarioRubroEgreso.Name = "cboDiagnosticoTerciarioRubroEgreso";
            this.cboDiagnosticoTerciarioRubroEgreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoTerciarioRubroEgreso.TabIndex = 7;
            this.cboDiagnosticoTerciarioRubroEgreso.UseSelectable = true;
            this.cboDiagnosticoTerciarioRubroEgreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoTerciarioRubroEgreso_SelectedIndexChanged);
            // 
            // groupDiagnosticoSecundarioEgreso
            // 
            this.groupDiagnosticoSecundarioEgreso.Controls.Add(this.cboDiagnosticoSecundarioItemEgreso);
            this.groupDiagnosticoSecundarioEgreso.Controls.Add(this.cboDiagnosticoSecundarioCapituloEgreso);
            this.groupDiagnosticoSecundarioEgreso.Controls.Add(this.cboDiagnosticoSecundarioSubRubroEgreso);
            this.groupDiagnosticoSecundarioEgreso.Controls.Add(this.cboDiagnosticoSecundarioRubroEgreso);
            this.groupDiagnosticoSecundarioEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDiagnosticoSecundarioEgreso.Location = new System.Drawing.Point(10, 209);
            this.groupDiagnosticoSecundarioEgreso.Name = "groupDiagnosticoSecundarioEgreso";
            this.groupDiagnosticoSecundarioEgreso.Size = new System.Drawing.Size(801, 173);
            this.groupDiagnosticoSecundarioEgreso.TabIndex = 97;
            this.groupDiagnosticoSecundarioEgreso.TabStop = false;
            this.groupDiagnosticoSecundarioEgreso.Text = "Diagnostico Secundario 1";
            // 
            // cboDiagnosticoSecundarioItemEgreso
            // 
            this.cboDiagnosticoSecundarioItemEgreso.FormattingEnabled = true;
            this.cboDiagnosticoSecundarioItemEgreso.ItemHeight = 23;
            this.cboDiagnosticoSecundarioItemEgreso.Location = new System.Drawing.Point(10, 132);
            this.cboDiagnosticoSecundarioItemEgreso.Name = "cboDiagnosticoSecundarioItemEgreso";
            this.cboDiagnosticoSecundarioItemEgreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoSecundarioItemEgreso.TabIndex = 10;
            this.cboDiagnosticoSecundarioItemEgreso.UseSelectable = true;
            // 
            // cboDiagnosticoSecundarioCapituloEgreso
            // 
            this.cboDiagnosticoSecundarioCapituloEgreso.FormattingEnabled = true;
            this.cboDiagnosticoSecundarioCapituloEgreso.ItemHeight = 23;
            this.cboDiagnosticoSecundarioCapituloEgreso.Location = new System.Drawing.Point(10, 27);
            this.cboDiagnosticoSecundarioCapituloEgreso.Name = "cboDiagnosticoSecundarioCapituloEgreso";
            this.cboDiagnosticoSecundarioCapituloEgreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoSecundarioCapituloEgreso.TabIndex = 1;
            this.cboDiagnosticoSecundarioCapituloEgreso.UseSelectable = true;
            this.cboDiagnosticoSecundarioCapituloEgreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoSecundarioCapituloEgreso_SelectedIndexChanged);
            // 
            // cboDiagnosticoSecundarioSubRubroEgreso
            // 
            this.cboDiagnosticoSecundarioSubRubroEgreso.FormattingEnabled = true;
            this.cboDiagnosticoSecundarioSubRubroEgreso.ItemHeight = 23;
            this.cboDiagnosticoSecundarioSubRubroEgreso.Location = new System.Drawing.Point(10, 97);
            this.cboDiagnosticoSecundarioSubRubroEgreso.Name = "cboDiagnosticoSecundarioSubRubroEgreso";
            this.cboDiagnosticoSecundarioSubRubroEgreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoSecundarioSubRubroEgreso.TabIndex = 8;
            this.cboDiagnosticoSecundarioSubRubroEgreso.UseSelectable = true;
            this.cboDiagnosticoSecundarioSubRubroEgreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoSecundarioSubRubroEgreso_SelectedIndexChanged);
            // 
            // cboDiagnosticoSecundarioRubroEgreso
            // 
            this.cboDiagnosticoSecundarioRubroEgreso.FormattingEnabled = true;
            this.cboDiagnosticoSecundarioRubroEgreso.ItemHeight = 23;
            this.cboDiagnosticoSecundarioRubroEgreso.Location = new System.Drawing.Point(10, 62);
            this.cboDiagnosticoSecundarioRubroEgreso.Name = "cboDiagnosticoSecundarioRubroEgreso";
            this.cboDiagnosticoSecundarioRubroEgreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoSecundarioRubroEgreso.TabIndex = 7;
            this.cboDiagnosticoSecundarioRubroEgreso.UseSelectable = true;
            this.cboDiagnosticoSecundarioRubroEgreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoSecundarioRubroEgreso_SelectedIndexChanged);
            // 
            // groupDiagnosticoPrincipalEgreso
            // 
            this.groupDiagnosticoPrincipalEgreso.Controls.Add(this.cboDiagnosticoPrincipalItemEgreso);
            this.groupDiagnosticoPrincipalEgreso.Controls.Add(this.cboDiagnosticoPrincipalCapituloEgreso);
            this.groupDiagnosticoPrincipalEgreso.Controls.Add(this.cboDiagnosticoPrincipalSubRubroEgreso);
            this.groupDiagnosticoPrincipalEgreso.Controls.Add(this.cboDiagnosticoPrincipalRubroEgreso);
            this.groupDiagnosticoPrincipalEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDiagnosticoPrincipalEgreso.Location = new System.Drawing.Point(10, 27);
            this.groupDiagnosticoPrincipalEgreso.Name = "groupDiagnosticoPrincipalEgreso";
            this.groupDiagnosticoPrincipalEgreso.Size = new System.Drawing.Size(801, 173);
            this.groupDiagnosticoPrincipalEgreso.TabIndex = 96;
            this.groupDiagnosticoPrincipalEgreso.TabStop = false;
            this.groupDiagnosticoPrincipalEgreso.Text = "Diagnostico Principal";
            // 
            // cboDiagnosticoPrincipalItemEgreso
            // 
            this.cboDiagnosticoPrincipalItemEgreso.FormattingEnabled = true;
            this.cboDiagnosticoPrincipalItemEgreso.ItemHeight = 23;
            this.cboDiagnosticoPrincipalItemEgreso.Location = new System.Drawing.Point(10, 132);
            this.cboDiagnosticoPrincipalItemEgreso.Name = "cboDiagnosticoPrincipalItemEgreso";
            this.cboDiagnosticoPrincipalItemEgreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoPrincipalItemEgreso.TabIndex = 9;
            this.cboDiagnosticoPrincipalItemEgreso.UseSelectable = true;
            // 
            // cboDiagnosticoPrincipalCapituloEgreso
            // 
            this.cboDiagnosticoPrincipalCapituloEgreso.FormattingEnabled = true;
            this.cboDiagnosticoPrincipalCapituloEgreso.ItemHeight = 23;
            this.cboDiagnosticoPrincipalCapituloEgreso.Location = new System.Drawing.Point(10, 27);
            this.cboDiagnosticoPrincipalCapituloEgreso.Name = "cboDiagnosticoPrincipalCapituloEgreso";
            this.cboDiagnosticoPrincipalCapituloEgreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoPrincipalCapituloEgreso.TabIndex = 1;
            this.cboDiagnosticoPrincipalCapituloEgreso.UseSelectable = true;
            this.cboDiagnosticoPrincipalCapituloEgreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoPrincipalCapituloEgreso_SelectedIndexChanged);
            // 
            // cboDiagnosticoPrincipalSubRubroEgreso
            // 
            this.cboDiagnosticoPrincipalSubRubroEgreso.FormattingEnabled = true;
            this.cboDiagnosticoPrincipalSubRubroEgreso.ItemHeight = 23;
            this.cboDiagnosticoPrincipalSubRubroEgreso.Location = new System.Drawing.Point(10, 97);
            this.cboDiagnosticoPrincipalSubRubroEgreso.Name = "cboDiagnosticoPrincipalSubRubroEgreso";
            this.cboDiagnosticoPrincipalSubRubroEgreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoPrincipalSubRubroEgreso.TabIndex = 8;
            this.cboDiagnosticoPrincipalSubRubroEgreso.UseSelectable = true;
            this.cboDiagnosticoPrincipalSubRubroEgreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoPrincipalSubRubroEgreso_SelectedIndexChanged);
            // 
            // cboDiagnosticoPrincipalRubroEgreso
            // 
            this.cboDiagnosticoPrincipalRubroEgreso.FormattingEnabled = true;
            this.cboDiagnosticoPrincipalRubroEgreso.ItemHeight = 23;
            this.cboDiagnosticoPrincipalRubroEgreso.Location = new System.Drawing.Point(10, 62);
            this.cboDiagnosticoPrincipalRubroEgreso.Name = "cboDiagnosticoPrincipalRubroEgreso";
            this.cboDiagnosticoPrincipalRubroEgreso.Size = new System.Drawing.Size(781, 29);
            this.cboDiagnosticoPrincipalRubroEgreso.TabIndex = 7;
            this.cboDiagnosticoPrincipalRubroEgreso.UseSelectable = true;
            this.cboDiagnosticoPrincipalRubroEgreso.SelectedIndexChanged += new System.EventHandler(this.cboDiagnosticoPrincipalRubroEgreso_SelectedIndexChanged);
            // 
            // DiagnosticoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 644);
            this.Controls.Add(this.panelDiagnostico);
            this.Name = "DiagnosticoEgreso";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Load += new System.EventHandler(this.DiagnosticoEgreso_Load);
            this.panelDiagnostico.ResumeLayout(false);
            this.panelDiagnostico.PerformLayout();
            this.groupDiagnosticoEgreso.ResumeLayout(false);
            this.groupDiagnosticoTerciarioEgreso.ResumeLayout(false);
            this.groupDiagnosticoSecundarioEgreso.ResumeLayout(false);
            this.groupDiagnosticoPrincipalEgreso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelDiagnostico;
        private System.Windows.Forms.Button btnModificar;
        private MetroFramework.Controls.MetroLabel lblDiagnostico_id;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupDiagnosticoEgreso;
        private System.Windows.Forms.GroupBox groupDiagnosticoTerciarioEgreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoTerciarioItemEgreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoTerciarioCapituloEgreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoTerciarioSubRubroEgreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoTerciarioRubroEgreso;
        private System.Windows.Forms.GroupBox groupDiagnosticoSecundarioEgreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoSecundarioItemEgreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoSecundarioCapituloEgreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoSecundarioSubRubroEgreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoSecundarioRubroEgreso;
        private System.Windows.Forms.GroupBox groupDiagnosticoPrincipalEgreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoPrincipalItemEgreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoPrincipalCapituloEgreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoPrincipalSubRubroEgreso;
        private MetroFramework.Controls.MetroComboBox cboDiagnosticoPrincipalRubroEgreso;
    }
}