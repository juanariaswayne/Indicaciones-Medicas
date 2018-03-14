namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Impresion
{
    partial class Impresion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impresion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckVertical = new System.Windows.Forms.CheckBox();
            this.radioHE = new MetroFramework.Controls.MetroRadioButton();
            this.radioIM = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioTodos = new MetroFramework.Controls.MetroRadioButton();
            this.radioEstePac = new MetroFramework.Controls.MetroRadioButton();
            this.checkImpresionDirecta = new MetroFramework.Controls.MetroCheckBox();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckVertical);
            this.groupBox1.Controls.Add(this.radioHE);
            this.groupBox1.Controls.Add(this.radioIM);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione hoja a imprimir";
            // 
            // chckVertical
            // 
            this.chckVertical.AutoSize = true;
            this.chckVertical.Location = new System.Drawing.Point(163, 67);
            this.chckVertical.Name = "chckVertical";
            this.chckVertical.Size = new System.Drawing.Size(101, 17);
            this.chckVertical.TabIndex = 2;
            this.chckVertical.Text = "Formato vertical";
            this.chckVertical.UseVisualStyleBackColor = true;
            // 
            // radioHE
            // 
            this.radioHE.AutoSize = true;
            this.radioHE.Location = new System.Drawing.Point(17, 66);
            this.radioHE.Name = "radioHE";
            this.radioHE.Size = new System.Drawing.Size(124, 15);
            this.radioHE.TabIndex = 1;
            this.radioHE.Text = "Hoja de Enfermeria";
            this.radioHE.UseSelectable = true;
            // 
            // radioIM
            // 
            this.radioIM.AutoSize = true;
            this.radioIM.Location = new System.Drawing.Point(17, 34);
            this.radioIM.Name = "radioIM";
            this.radioIM.Size = new System.Drawing.Size(136, 15);
            this.radioIM.TabIndex = 0;
            this.radioIM.Text = "Indicaciones Medicas";
            this.radioIM.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioTodos);
            this.groupBox2.Controls.Add(this.radioEstePac);
            this.groupBox2.Location = new System.Drawing.Point(6, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione tipo de impresion";
            this.groupBox2.Visible = false;
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Location = new System.Drawing.Point(14, 57);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(126, 15);
            this.radioTodos.TabIndex = 1;
            this.radioTodos.Text = "Todos los pacientes";
            this.radioTodos.UseSelectable = true;
            // 
            // radioEstePac
            // 
            this.radioEstePac.AutoSize = true;
            this.radioEstePac.Location = new System.Drawing.Point(14, 28);
            this.radioEstePac.Name = "radioEstePac";
            this.radioEstePac.Size = new System.Drawing.Size(92, 15);
            this.radioEstePac.TabIndex = 0;
            this.radioEstePac.Text = "Este Paciente";
            this.radioEstePac.UseSelectable = true;
            // 
            // checkImpresionDirecta
            // 
            this.checkImpresionDirecta.AutoSize = true;
            this.checkImpresionDirecta.Location = new System.Drawing.Point(9, 286);
            this.checkImpresionDirecta.Name = "checkImpresionDirecta";
            this.checkImpresionDirecta.Size = new System.Drawing.Size(116, 15);
            this.checkImpresionDirecta.TabIndex = 3;
            this.checkImpresionDirecta.Text = "Impresion Directa";
            this.checkImpresionDirecta.UseSelectable = true;
            this.checkImpresionDirecta.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.Location = new System.Drawing.Point(6, 318);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 36);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Impresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 358);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.checkImpresionDirecta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Impresion";
            this.Resizable = false;
            this.Text = "Impresion";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Impresion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton radioHE;
        private MetroFramework.Controls.MetroRadioButton radioIM;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroRadioButton radioTodos;
        private MetroFramework.Controls.MetroRadioButton radioEstePac;
        private MetroFramework.Controls.MetroCheckBox checkImpresionDirecta;
        private MetroFramework.Controls.MetroTile btnPrint;
        private System.Windows.Forms.CheckBox chckVertical;
    }
}