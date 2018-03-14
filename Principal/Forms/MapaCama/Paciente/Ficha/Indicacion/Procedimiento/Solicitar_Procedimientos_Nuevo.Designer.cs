namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento
{
    partial class Solicitar_Procedimientos_Nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitar_Procedimientos_Nuevo));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTipoProcedimiento = new MetroFramework.Controls.MetroLabel();
            this.cboTipoProcedimiento = new MetroFramework.Controls.MetroComboBox();
            this.lblNombreMedicamento = new MetroFramework.Controls.MetroLabel();
            this.txtNombreMedicamento = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnSalir);
            this.metroPanel1.Controls.Add(this.btnGuardar);
            this.metroPanel1.Controls.Add(this.lblTipoProcedimiento);
            this.metroPanel1.Controls.Add(this.cboTipoProcedimiento);
            this.metroPanel1.Controls.Add(this.lblNombreMedicamento);
            this.metroPanel1.Controls.Add(this.txtNombreMedicamento);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(8, 56);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(743, 106);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.Image = global::Principal.Properties.Resources.LogoSalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(623, 69);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 26);
            this.btnSalir.TabIndex = 86;
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
            this.btnGuardar.Location = new System.Drawing.Point(507, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 26);
            this.btnGuardar.TabIndex = 85;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTipoProcedimiento
            // 
            this.lblTipoProcedimiento.AutoSize = true;
            this.lblTipoProcedimiento.Location = new System.Drawing.Point(512, 8);
            this.lblTipoProcedimiento.Name = "lblTipoProcedimiento";
            this.lblTipoProcedimiento.Size = new System.Drawing.Size(125, 19);
            this.lblTipoProcedimiento.TabIndex = 71;
            this.lblTipoProcedimiento.Text = "Tipo Procedimiento";
            // 
            // cboTipoProcedimiento
            // 
            this.cboTipoProcedimiento.FormattingEnabled = true;
            this.cboTipoProcedimiento.ItemHeight = 23;
            this.cboTipoProcedimiento.Location = new System.Drawing.Point(507, 31);
            this.cboTipoProcedimiento.Name = "cboTipoProcedimiento";
            this.cboTipoProcedimiento.Size = new System.Drawing.Size(226, 29);
            this.cboTipoProcedimiento.TabIndex = 70;
            this.cboTipoProcedimiento.UseSelectable = true;
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
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Lines = new string[0];
            this.txtNombreMedicamento.Location = new System.Drawing.Point(9, 31);
            this.txtNombreMedicamento.MaxLength = 32767;
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.PasswordChar = '\0';
            this.txtNombreMedicamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreMedicamento.SelectedText = "";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(478, 29);
            this.txtNombreMedicamento.TabIndex = 2;
            this.txtNombreMedicamento.UseSelectable = true;
            // 
            // Solicitar_Procedimientos_Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 174);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Solicitar_Procedimientos_Nuevo";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Solicitar Procedimientos Nuevo";
            this.Load += new System.EventHandler(this.Solicitar_Procedimientos_Nuevo_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtNombreMedicamento;
        private MetroFramework.Controls.MetroLabel lblNombreMedicamento;
        private MetroFramework.Controls.MetroLabel lblTipoProcedimiento;
        private MetroFramework.Controls.MetroComboBox cboTipoProcedimiento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
    }
}