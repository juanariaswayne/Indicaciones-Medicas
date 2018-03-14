namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento
{
    partial class Solicitar_Medicamentos_Nuevo
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnSolicitar = new MetroFramework.Controls.MetroTile();
            this.lblUnidadMedida = new MetroFramework.Controls.MetroLabel();
            this.cboUnidadDeMedida = new MetroFramework.Controls.MetroComboBox();
            this.lblPresentacion = new MetroFramework.Controls.MetroLabel();
            this.lblNombreMedicamento = new MetroFramework.Controls.MetroLabel();
            this.txtPotencia = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreMedicamento = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtNombreMedicamento);
            this.metroPanel1.Controls.Add(this.txtPotencia);
            this.metroPanel1.Controls.Add(this.btnSolicitar);
            this.metroPanel1.Controls.Add(this.lblUnidadMedida);
            this.metroPanel1.Controls.Add(this.cboUnidadDeMedida);
            this.metroPanel1.Controls.Add(this.lblPresentacion);
            this.metroPanel1.Controls.Add(this.lblNombreMedicamento);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(8, 56);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(683, 106);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.ActiveControl = null;
            this.btnSolicitar.Location = new System.Drawing.Point(539, 70);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(142, 32);
            this.btnSolicitar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSolicitar.TabIndex = 87;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSolicitar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnSolicitar.UseSelectable = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(469, 8);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(83, 19);
            this.lblUnidadMedida.TabIndex = 71;
            this.lblUnidadMedida.Text = "Presentacion";
            // 
            // cboUnidadDeMedida
            // 
            this.cboUnidadDeMedida.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboUnidadDeMedida.FormattingEnabled = true;
            this.cboUnidadDeMedida.ItemHeight = 19;
            this.cboUnidadDeMedida.Location = new System.Drawing.Point(469, 31);
            this.cboUnidadDeMedida.Name = "cboUnidadDeMedida";
            this.cboUnidadDeMedida.Size = new System.Drawing.Size(205, 25);
            this.cboUnidadDeMedida.Style = MetroFramework.MetroColorStyle.Teal;
            this.cboUnidadDeMedida.TabIndex = 70;
            this.cboUnidadDeMedida.UseSelectable = true;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(242, 8);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(58, 19);
            this.lblPresentacion.TabIndex = 69;
            this.lblPresentacion.Text = "Potencia";
            // 
            // lblNombreMedicamento
            // 
            this.lblNombreMedicamento.AutoSize = true;
            this.lblNombreMedicamento.Location = new System.Drawing.Point(14, 8);
            this.lblNombreMedicamento.Name = "lblNombreMedicamento";
            this.lblNombreMedicamento.Size = new System.Drawing.Size(59, 19);
            this.lblNombreMedicamento.TabIndex = 4;
            this.lblNombreMedicamento.Text = "Nombre";
            this.lblNombreMedicamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombreMedicamento.Visible = false;
            // 
            // txtPotencia
            // 
            // 
            // 
            // 
            this.txtPotencia.CustomButton.Image = null;
            this.txtPotencia.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtPotencia.CustomButton.Name = "";
            this.txtPotencia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPotencia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPotencia.CustomButton.TabIndex = 1;
            this.txtPotencia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPotencia.CustomButton.UseSelectable = true;
            this.txtPotencia.CustomButton.Visible = false;
            this.txtPotencia.Lines = new string[0];
            this.txtPotencia.Location = new System.Drawing.Point(242, 33);
            this.txtPotencia.MaxLength = 32767;
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.PasswordChar = '\0';
            this.txtPotencia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPotencia.SelectedText = "";
            this.txtPotencia.SelectionLength = 0;
            this.txtPotencia.SelectionStart = 0;
            this.txtPotencia.ShortcutsEnabled = true;
            this.txtPotencia.Size = new System.Drawing.Size(221, 23);
            this.txtPotencia.TabIndex = 88;
            this.txtPotencia.UseSelectable = true;
            this.txtPotencia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPotencia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombreMedicamento
            // 
            // 
            // 
            // 
            this.txtNombreMedicamento.CustomButton.Image = null;
            this.txtNombreMedicamento.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtNombreMedicamento.CustomButton.Name = "";
            this.txtNombreMedicamento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreMedicamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreMedicamento.CustomButton.TabIndex = 1;
            this.txtNombreMedicamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreMedicamento.CustomButton.UseSelectable = true;
            this.txtNombreMedicamento.CustomButton.Visible = false;
            this.txtNombreMedicamento.Lines = new string[0];
            this.txtNombreMedicamento.Location = new System.Drawing.Point(15, 33);
            this.txtNombreMedicamento.MaxLength = 32767;
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.PasswordChar = '\0';
            this.txtNombreMedicamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreMedicamento.SelectedText = "";
            this.txtNombreMedicamento.SelectionLength = 0;
            this.txtNombreMedicamento.SelectionStart = 0;
            this.txtNombreMedicamento.ShortcutsEnabled = true;
            this.txtNombreMedicamento.Size = new System.Drawing.Size(221, 23);
            this.txtNombreMedicamento.TabIndex = 89;
            this.txtNombreMedicamento.UseSelectable = true;
            this.txtNombreMedicamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreMedicamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Solicitar_Medicamentos_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 168);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "Solicitar_Medicamentos_Nuevo";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Solicitar Medicamento Nuevo";
            this.Load += new System.EventHandler(this.Solicitar_Medicamentos_Nuevo_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblNombreMedicamento;
        private MetroFramework.Controls.MetroLabel lblPresentacion;
        private MetroFramework.Controls.MetroLabel lblUnidadMedida;
        private MetroFramework.Controls.MetroComboBox cboUnidadDeMedida;
        private MetroFramework.Controls.MetroTile btnSolicitar;
        private MetroFramework.Controls.MetroTextBox txtPotencia;
        private MetroFramework.Controls.MetroTextBox txtNombreMedicamento;
    }
}