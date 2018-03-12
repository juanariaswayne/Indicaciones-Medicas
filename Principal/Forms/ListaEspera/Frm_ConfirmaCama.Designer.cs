namespace Principal.Forms.ListaEspera
{
    partial class Frm_ConfirmaCama
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerConfirma = new System.Windows.Forms.DateTimePicker();
            this.groupBoxIngreso = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxObs = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTelefonos = new System.Windows.Forms.TextBox();
            this.textBoxVinculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxResponsable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboHabitacionDesocupada = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSede = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGrabar = new MetroFramework.Controls.MetroTile();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.comboBoxSectorMail = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxIngreso.SuspendLayout();
            this.panel2.SuspendLayout();
            this.btnSalir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxIngreso);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 310);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerConfirma);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 69);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Fecha y Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha y hora confirmación:";
            // 
            // dateTimePickerConfirma
            // 
            this.dateTimePickerConfirma.CustomFormat = "dd/MM/yyyy H:mm:ss";
            this.dateTimePickerConfirma.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerConfirma.Location = new System.Drawing.Point(181, 30);
            this.dateTimePickerConfirma.Name = "dateTimePickerConfirma";
            this.dateTimePickerConfirma.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerConfirma.TabIndex = 12;
            // 
            // groupBoxIngreso
            // 
            this.groupBoxIngreso.Controls.Add(this.label1);
            this.groupBoxIngreso.Controls.Add(this.comboBoxSectorMail);
            this.groupBoxIngreso.Controls.Add(this.label8);
            this.groupBoxIngreso.Controls.Add(this.TextBoxObs);
            this.groupBoxIngreso.Controls.Add(this.label7);
            this.groupBoxIngreso.Controls.Add(this.textBoxTelefonos);
            this.groupBoxIngreso.Controls.Add(this.textBoxVinculo);
            this.groupBoxIngreso.Controls.Add(this.label6);
            this.groupBoxIngreso.Controls.Add(this.label5);
            this.groupBoxIngreso.Controls.Add(this.textBoxResponsable);
            this.groupBoxIngreso.Controls.Add(this.label4);
            this.groupBoxIngreso.Controls.Add(this.cboHabitacionDesocupada);
            this.groupBoxIngreso.Controls.Add(this.label3);
            this.groupBoxIngreso.Controls.Add(this.comboBoxSede);
            this.groupBoxIngreso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxIngreso.Location = new System.Drawing.Point(0, 73);
            this.groupBoxIngreso.Name = "groupBoxIngreso";
            this.groupBoxIngreso.Size = new System.Drawing.Size(787, 197);
            this.groupBoxIngreso.TabIndex = 28;
            this.groupBoxIngreso.TabStop = false;
            this.groupBoxIngreso.Text = "Detalle Confirmación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Observación para mail";
            // 
            // TextBoxObs
            // 
            // 
            // 
            // 
            this.TextBoxObs.CustomButton.Image = null;
            this.TextBoxObs.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.TextBoxObs.CustomButton.Name = "";
            this.TextBoxObs.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.TextBoxObs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxObs.CustomButton.TabIndex = 1;
            this.TextBoxObs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxObs.CustomButton.UseSelectable = true;
            this.TextBoxObs.CustomButton.Visible = false;
            this.TextBoxObs.Lines = new string[0];
            this.TextBoxObs.Location = new System.Drawing.Point(462, 121);
            this.TextBoxObs.MaxLength = 32767;
            this.TextBoxObs.Multiline = true;
            this.TextBoxObs.Name = "TextBoxObs";
            this.TextBoxObs.PasswordChar = '\0';
            this.TextBoxObs.PromptText = "Observaciones";
            this.TextBoxObs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxObs.SelectedText = "";
            this.TextBoxObs.SelectionLength = 0;
            this.TextBoxObs.SelectionStart = 0;
            this.TextBoxObs.ShortcutsEnabled = true;
            this.TextBoxObs.Size = new System.Drawing.Size(274, 70);
            this.TextBoxObs.TabIndex = 18;
            this.TextBoxObs.UseSelectable = true;
            this.TextBoxObs.WaterMark = "Observaciones";
            this.TextBoxObs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxObs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Teléfonos:";
            // 
            // textBoxTelefonos
            // 
            this.textBoxTelefonos.Location = new System.Drawing.Point(84, 152);
            this.textBoxTelefonos.Name = "textBoxTelefonos";
            this.textBoxTelefonos.Size = new System.Drawing.Size(349, 20);
            this.textBoxTelefonos.TabIndex = 16;
            // 
            // textBoxVinculo
            // 
            this.textBoxVinculo.Location = new System.Drawing.Point(84, 118);
            this.textBoxVinculo.Name = "textBoxVinculo";
            this.textBoxVinculo.Size = new System.Drawing.Size(201, 20);
            this.textBoxVinculo.TabIndex = 15;
            this.textBoxVinculo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxVinculo_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vínculo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Responsable:";
            // 
            // textBoxResponsable
            // 
            this.textBoxResponsable.Location = new System.Drawing.Point(84, 86);
            this.textBoxResponsable.Name = "textBoxResponsable";
            this.textBoxResponsable.Size = new System.Drawing.Size(349, 20);
            this.textBoxResponsable.TabIndex = 12;
            this.textBoxResponsable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxResponsable_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Habitación:";
            // 
            // cboHabitacionDesocupada
            // 
            this.cboHabitacionDesocupada.FormattingEnabled = true;
            this.cboHabitacionDesocupada.Location = new System.Drawing.Point(240, 49);
            this.cboHabitacionDesocupada.Name = "cboHabitacionDesocupada";
            this.cboHabitacionDesocupada.Size = new System.Drawing.Size(117, 21);
            this.cboHabitacionDesocupada.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sede:";
            // 
            // comboBoxSede
            // 
            this.comboBoxSede.FormattingEnabled = true;
            this.comboBoxSede.Location = new System.Drawing.Point(240, 17);
            this.comboBoxSede.Name = "comboBoxSede";
            this.comboBoxSede.Size = new System.Drawing.Size(237, 21);
            this.comboBoxSede.TabIndex = 8;
            this.comboBoxSede.SelectedIndexChanged += new System.EventHandler(this.comboBoxSede_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnGrabar);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 40);
            this.panel2.TabIndex = 27;
            // 
            // btnGrabar
            // 
            this.btnGrabar.ActiveControl = null;
            this.btnGrabar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGrabar.Location = new System.Drawing.Point(573, 0);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(116, 38);
            this.btnGrabar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGrabar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnGrabar.UseSelectable = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveControl = null;
            this.btnSalir.Controls.Add(this.splitter2);
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Location = new System.Drawing.Point(689, 0);
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
            // comboBoxSectorMail
            // 
            this.comboBoxSectorMail.FormattingEnabled = true;
            this.comboBoxSectorMail.Location = new System.Drawing.Point(565, 17);
            this.comboBoxSectorMail.Name = "comboBoxSectorMail";
            this.comboBoxSectorMail.Size = new System.Drawing.Size(171, 21);
            this.comboBoxSectorMail.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sector Ingreso:";
     
            // 
            // Frm_ConfirmaCama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 390);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ConfirmaCama";
            this.Text = "Confirmación de Cama";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Frm_ConfirmaCama_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxIngreso.ResumeLayout(false);
            this.groupBoxIngreso.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.btnSalir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTile btnGrabar;
        private MetroFramework.Controls.MetroTile btnSalir;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBoxIngreso;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox TextBoxObs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTelefonos;
        private System.Windows.Forms.TextBox textBoxVinculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxResponsable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboHabitacionDesocupada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSede;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerConfirma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSectorMail;
    }
}