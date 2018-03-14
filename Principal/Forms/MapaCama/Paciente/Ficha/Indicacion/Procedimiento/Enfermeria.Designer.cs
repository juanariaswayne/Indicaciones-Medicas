namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento
{
    partial class Enfermeria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enfermeria));
            this.panelEnfermeria = new MetroFramework.Controls.MetroPanel();
            this.groupSuspender = new System.Windows.Forms.GroupBox();
            this.txtSuspenderMotivo = new MetroFramework.Controls.MetroTextBox();
            this.groupObservacion = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new MetroFramework.Controls.MetroTextBox();
            this.groupOral = new System.Windows.Forms.GroupBox();
            this.checkControlVital = new MetroFramework.Controls.MetroCheckBox();
            this.checkDiuresis = new MetroFramework.Controls.MetroCheckBox();
            this.checkMedicion = new MetroFramework.Controls.MetroCheckBox();
            this.checkFrecuenciaCardiaca = new MetroFramework.Controls.MetroCheckBox();
            this.checkControlSaturacion = new MetroFramework.Controls.MetroCheckBox();
            this.checkGlucemia = new MetroFramework.Controls.MetroCheckBox();
            this.checkTemperatura = new MetroFramework.Controls.MetroCheckBox();
            this.checkEcg = new MetroFramework.Controls.MetroCheckBox();
            this.checkFrecuenciaRespiratoria = new MetroFramework.Controls.MetroCheckBox();
            this.checkMultistick = new MetroFramework.Controls.MetroCheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelEnfermeria.SuspendLayout();
            this.groupSuspender.SuspendLayout();
            this.groupObservacion.SuspendLayout();
            this.groupOral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEnfermeria
            // 
            this.panelEnfermeria.Controls.Add(this.groupSuspender);
            this.panelEnfermeria.Controls.Add(this.groupObservacion);
            this.panelEnfermeria.Controls.Add(this.groupOral);
            this.panelEnfermeria.HorizontalScrollbarBarColor = true;
            this.panelEnfermeria.HorizontalScrollbarHighlightOnWheel = false;
            this.panelEnfermeria.HorizontalScrollbarSize = 10;
            this.panelEnfermeria.Location = new System.Drawing.Point(12, 54);
            this.panelEnfermeria.Name = "panelEnfermeria";
            this.panelEnfermeria.Size = new System.Drawing.Size(536, 457);
            this.panelEnfermeria.TabIndex = 0;
            this.panelEnfermeria.VerticalScrollbarBarColor = true;
            this.panelEnfermeria.VerticalScrollbarHighlightOnWheel = false;
            this.panelEnfermeria.VerticalScrollbarSize = 10;
            // 
            // groupSuspender
            // 
            this.groupSuspender.Controls.Add(this.txtSuspenderMotivo);
            this.groupSuspender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSuspender.Location = new System.Drawing.Point(17, 361);
            this.groupSuspender.Name = "groupSuspender";
            this.groupSuspender.Size = new System.Drawing.Size(513, 92);
            this.groupSuspender.TabIndex = 69;
            this.groupSuspender.TabStop = false;
            this.groupSuspender.Text = "Suspender - Motivo";
            // 
            // txtSuspenderMotivo
            // 
            this.txtSuspenderMotivo.Lines = new string[0];
            this.txtSuspenderMotivo.Location = new System.Drawing.Point(15, 29);
            this.txtSuspenderMotivo.MaxLength = 32767;
            this.txtSuspenderMotivo.Multiline = true;
            this.txtSuspenderMotivo.Name = "txtSuspenderMotivo";
            this.txtSuspenderMotivo.PasswordChar = '\0';
            this.txtSuspenderMotivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSuspenderMotivo.SelectedText = "";
            this.txtSuspenderMotivo.Size = new System.Drawing.Size(484, 53);
            this.txtSuspenderMotivo.TabIndex = 0;
            this.txtSuspenderMotivo.UseSelectable = true;
            // 
            // groupObservacion
            // 
            this.groupObservacion.Controls.Add(this.txtObservacion);
            this.groupObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupObservacion.Location = new System.Drawing.Point(275, 9);
            this.groupObservacion.Name = "groupObservacion";
            this.groupObservacion.Size = new System.Drawing.Size(255, 346);
            this.groupObservacion.TabIndex = 67;
            this.groupObservacion.TabStop = false;
            this.groupObservacion.Text = "Observaciones";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Lines = new string[0];
            this.txtObservacion.Location = new System.Drawing.Point(14, 29);
            this.txtObservacion.MaxLength = 32767;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.Size = new System.Drawing.Size(227, 306);
            this.txtObservacion.TabIndex = 0;
            this.txtObservacion.UseSelectable = true;
            // 
            // groupOral
            // 
            this.groupOral.Controls.Add(this.checkControlVital);
            this.groupOral.Controls.Add(this.checkDiuresis);
            this.groupOral.Controls.Add(this.checkMedicion);
            this.groupOral.Controls.Add(this.checkFrecuenciaCardiaca);
            this.groupOral.Controls.Add(this.checkControlSaturacion);
            this.groupOral.Controls.Add(this.checkGlucemia);
            this.groupOral.Controls.Add(this.checkTemperatura);
            this.groupOral.Controls.Add(this.checkEcg);
            this.groupOral.Controls.Add(this.checkFrecuenciaRespiratoria);
            this.groupOral.Controls.Add(this.checkMultistick);
            this.groupOral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOral.Location = new System.Drawing.Point(17, 9);
            this.groupOral.Name = "groupOral";
            this.groupOral.Size = new System.Drawing.Size(252, 346);
            this.groupOral.TabIndex = 2;
            this.groupOral.TabStop = false;
            this.groupOral.Text = "Oral";
            // 
            // checkControlVital
            // 
            this.checkControlVital.AutoSize = true;
            this.checkControlVital.Location = new System.Drawing.Point(19, 34);
            this.checkControlVital.Name = "checkControlVital";
            this.checkControlVital.Size = new System.Drawing.Size(205, 15);
            this.checkControlVital.TabIndex = 45;
            this.checkControlVital.Text = "Control de signos vitales por turno";
            this.checkControlVital.UseSelectable = true;
            // 
            // checkDiuresis
            // 
            this.checkDiuresis.AutoSize = true;
            this.checkDiuresis.Location = new System.Drawing.Point(19, 162);
            this.checkDiuresis.Name = "checkDiuresis";
            this.checkDiuresis.Size = new System.Drawing.Size(89, 15);
            this.checkDiuresis.TabIndex = 46;
            this.checkDiuresis.Text = "Diuresis (ml)";
            this.checkDiuresis.UseSelectable = true;
            // 
            // checkMedicion
            // 
            this.checkMedicion.AutoSize = true;
            this.checkMedicion.Location = new System.Drawing.Point(19, 289);
            this.checkMedicion.Name = "checkMedicion";
            this.checkMedicion.Size = new System.Drawing.Size(186, 15);
            this.checkMedicion.TabIndex = 47;
            this.checkMedicion.Text = "Medición de residuos gástricos";
            this.checkMedicion.UseSelectable = true;
            // 
            // checkFrecuenciaCardiaca
            // 
            this.checkFrecuenciaCardiaca.AutoSize = true;
            this.checkFrecuenciaCardiaca.Location = new System.Drawing.Point(19, 65);
            this.checkFrecuenciaCardiaca.Name = "checkFrecuenciaCardiaca";
            this.checkFrecuenciaCardiaca.Size = new System.Drawing.Size(170, 15);
            this.checkFrecuenciaCardiaca.TabIndex = 48;
            this.checkFrecuenciaCardiaca.Text = "Frecuencia cardíaca (1xmin)";
            this.checkFrecuenciaCardiaca.UseSelectable = true;
            // 
            // checkControlSaturacion
            // 
            this.checkControlSaturacion.AutoSize = true;
            this.checkControlSaturacion.Location = new System.Drawing.Point(19, 257);
            this.checkControlSaturacion.Name = "checkControlSaturacion";
            this.checkControlSaturacion.Size = new System.Drawing.Size(155, 15);
            this.checkControlSaturacion.TabIndex = 55;
            this.checkControlSaturacion.Text = "Control de saturación O2";
            this.checkControlSaturacion.UseSelectable = true;
            // 
            // checkGlucemia
            // 
            this.checkGlucemia.AutoSize = true;
            this.checkGlucemia.Location = new System.Drawing.Point(19, 193);
            this.checkGlucemia.Name = "checkGlucemia";
            this.checkGlucemia.Size = new System.Drawing.Size(155, 15);
            this.checkGlucemia.TabIndex = 49;
            this.checkGlucemia.Text = "Glucemia capilar (mg/dl)";
            this.checkGlucemia.UseSelectable = true;
            // 
            // checkTemperatura
            // 
            this.checkTemperatura.AutoSize = true;
            this.checkTemperatura.Location = new System.Drawing.Point(19, 129);
            this.checkTemperatura.Name = "checkTemperatura";
            this.checkTemperatura.Size = new System.Drawing.Size(144, 15);
            this.checkTemperatura.TabIndex = 54;
            this.checkTemperatura.Text = "Temperatura axilar (ºC)";
            this.checkTemperatura.UseSelectable = true;
            // 
            // checkEcg
            // 
            this.checkEcg.AutoSize = true;
            this.checkEcg.Location = new System.Drawing.Point(19, 320);
            this.checkEcg.Name = "checkEcg";
            this.checkEcg.Size = new System.Drawing.Size(45, 15);
            this.checkEcg.TabIndex = 50;
            this.checkEcg.Text = "ECG";
            this.checkEcg.UseSelectable = true;
            // 
            // checkFrecuenciaRespiratoria
            // 
            this.checkFrecuenciaRespiratoria.AutoSize = true;
            this.checkFrecuenciaRespiratoria.Location = new System.Drawing.Point(19, 96);
            this.checkFrecuenciaRespiratoria.Name = "checkFrecuenciaRespiratoria";
            this.checkFrecuenciaRespiratoria.Size = new System.Drawing.Size(200, 15);
            this.checkFrecuenciaRespiratoria.TabIndex = 51;
            this.checkFrecuenciaRespiratoria.Text = "Frecuencia respiratoria (res x min)";
            this.checkFrecuenciaRespiratoria.UseSelectable = true;
            // 
            // checkMultistick
            // 
            this.checkMultistick.AutoSize = true;
            this.checkMultistick.Location = new System.Drawing.Point(19, 224);
            this.checkMultistick.Name = "checkMultistick";
            this.checkMultistick.Size = new System.Drawing.Size(121, 15);
            this.checkMultistick.TabIndex = 52;
            this.checkMultistick.Text = "Multistick en orina";
            this.checkMultistick.UseSelectable = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.Image = global::Principal.Properties.Resources.LogoSalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(434, 517);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 26);
            this.btnSalir.TabIndex = 75;
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
            this.btnGuardar.Location = new System.Drawing.Point(318, 517);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 26);
            this.btnGuardar.TabIndex = 74;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.Image = global::Principal.Properties.Resources.LogoEncuesta;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(202, 517);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 26);
            this.btnModificar.TabIndex = 73;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Enfermeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 553);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.panelEnfermeria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Enfermeria";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Enfermeria";
            this.Load += new System.EventHandler(this.Enfermeria_Load);
            this.panelEnfermeria.ResumeLayout(false);
            this.groupSuspender.ResumeLayout(false);
            this.groupObservacion.ResumeLayout(false);
            this.groupOral.ResumeLayout(false);
            this.groupOral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelEnfermeria;
        private System.Windows.Forms.GroupBox groupOral;
        private MetroFramework.Controls.MetroCheckBox checkControlVital;
        private MetroFramework.Controls.MetroCheckBox checkDiuresis;
        private MetroFramework.Controls.MetroCheckBox checkMedicion;
        private MetroFramework.Controls.MetroCheckBox checkFrecuenciaCardiaca;
        private MetroFramework.Controls.MetroCheckBox checkControlSaturacion;
        private MetroFramework.Controls.MetroCheckBox checkGlucemia;
        private MetroFramework.Controls.MetroCheckBox checkTemperatura;
        private MetroFramework.Controls.MetroCheckBox checkEcg;
        private MetroFramework.Controls.MetroCheckBox checkFrecuenciaRespiratoria;
        private MetroFramework.Controls.MetroCheckBox checkMultistick;
        private System.Windows.Forms.GroupBox groupObservacion;
        private MetroFramework.Controls.MetroTextBox txtObservacion;
        private System.Windows.Forms.GroupBox groupSuspender;
        private MetroFramework.Controls.MetroTextBox txtSuspenderMotivo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}