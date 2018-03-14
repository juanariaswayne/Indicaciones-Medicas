namespace Principal.Forms.MapaCama.Paciente
{
    partial class Nuevo_Diagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_Diagnostico));
            this.txtDiagnostico = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // txtDiagnostico
            // 
            // 
            // 
            // 
            this.txtDiagnostico.CustomButton.Image = null;
            this.txtDiagnostico.CustomButton.Location = new System.Drawing.Point(491, 1);
            this.txtDiagnostico.CustomButton.Name = "";
            this.txtDiagnostico.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDiagnostico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiagnostico.CustomButton.TabIndex = 1;
            this.txtDiagnostico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiagnostico.CustomButton.UseSelectable = true;
            this.txtDiagnostico.CustomButton.Visible = false;
            this.txtDiagnostico.Lines = new string[0];
            this.txtDiagnostico.Location = new System.Drawing.Point(23, 76);
            this.txtDiagnostico.MaxLength = 32767;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.PasswordChar = '\0';
            this.txtDiagnostico.PromptText = "Ingrese el diagnostico";
            this.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiagnostico.SelectedText = "";
            this.txtDiagnostico.SelectionLength = 0;
            this.txtDiagnostico.SelectionStart = 0;
            this.txtDiagnostico.ShortcutsEnabled = true;
            this.txtDiagnostico.Size = new System.Drawing.Size(513, 23);
            this.txtDiagnostico.TabIndex = 0;
            this.txtDiagnostico.UseSelectable = true;
            this.txtDiagnostico.WaterMark = "Ingrese el diagnostico";
            this.txtDiagnostico.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiagnostico.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveControl = null;
            this.btnGuardar.Location = new System.Drawing.Point(437, 116);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 38);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Nuevo_Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 156);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDiagnostico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nuevo_Diagnostico";
            this.Resizable = false;
            this.Text = "Nuevo diagnostico";
            this.Load += new System.EventHandler(this.Nuevo_Diagnostico_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtDiagnostico;
        private MetroFramework.Controls.MetroTile btnGuardar;
    }
}