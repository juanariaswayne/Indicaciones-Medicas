namespace Principal.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.lblContrasenia = new MetroFramework.Controls.MetroLabel();
            this.txtContrasenia = new MetroFramework.Controls.MetroTextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSede = new MetroFramework.Controls.MetroLabel();
            this.cboSede = new MetroFramework.Controls.MetroComboBox();
            this.btnIngresar = new MetroFramework.Controls.MetroTile();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.btnTest = new MetroFramework.Controls.MetroLink();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(72, 85);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(129, 80);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(175, 29);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(50, 126);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(75, 19);
            this.lblContrasenia.TabIndex = 0;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // txtContrasenia
            // 
            // 
            // 
            // 
            this.txtContrasenia.CustomButton.Image = null;
            this.txtContrasenia.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtContrasenia.CustomButton.Name = "";
            this.txtContrasenia.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtContrasenia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContrasenia.CustomButton.TabIndex = 1;
            this.txtContrasenia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContrasenia.CustomButton.UseSelectable = true;
            this.txtContrasenia.CustomButton.Visible = false;
            this.txtContrasenia.Lines = new string[0];
            this.txtContrasenia.Location = new System.Drawing.Point(129, 121);
            this.txtContrasenia.MaxLength = 32767;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '●';
            this.txtContrasenia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasenia.SelectedText = "";
            this.txtContrasenia.SelectionLength = 0;
            this.txtContrasenia.SelectionStart = 0;
            this.txtContrasenia.ShortcutsEnabled = true;
            this.txtContrasenia.Size = new System.Drawing.Size(175, 29);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.UseSelectable = true;
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContrasenia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasenia_KeyDown);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(176, 18);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(70, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // lblSede
            // 
            this.lblSede.AutoSize = true;
            this.lblSede.Location = new System.Drawing.Point(87, 168);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(38, 19);
            this.lblSede.TabIndex = 0;
            this.lblSede.Text = "Sede";
            // 
            // cboSede
            // 
            this.cboSede.FormattingEnabled = true;
            this.cboSede.ItemHeight = 23;
            this.cboSede.Location = new System.Drawing.Point(129, 163);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(175, 29);
            this.cboSede.Style = MetroFramework.MetroColorStyle.Purple;
            this.cboSede.TabIndex = 3;
            this.cboSede.UseSelectable = true;
            this.cboSede.SelectedIndexChanged += new System.EventHandler(this.cboSede_SelectedIndexChanged);
            this.cboSede.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboSede_KeyDown);
            // 
            // btnIngresar
            // 
            this.btnIngresar.ActiveControl = null;
            this.btnIngresar.Location = new System.Drawing.Point(129, 208);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(99, 38);
            this.btnIngresar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveControl = null;
            this.btnSalir.Location = new System.Drawing.Point(234, 208);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 38);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTest
            // 
            this.btnTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTest.Location = new System.Drawing.Point(4, 13);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(121, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test Lista de Espera";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.UseCustomForeColor = true;
            this.btnTest.UseSelectable = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(311, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Manual de uso";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(394, 259);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.cboSede);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(394, 259);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 259);
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel lblContrasenia;
        private MetroFramework.Controls.MetroTextBox txtContrasenia;
        private System.Windows.Forms.PictureBox picLogo;
        private MetroFramework.Controls.MetroLabel lblSede;
        private MetroFramework.Controls.MetroComboBox cboSede;
        private MetroFramework.Controls.MetroTile btnIngresar;
        private MetroFramework.Controls.MetroTile btnSalir;
        private MetroFramework.Controls.MetroLink btnTest;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}