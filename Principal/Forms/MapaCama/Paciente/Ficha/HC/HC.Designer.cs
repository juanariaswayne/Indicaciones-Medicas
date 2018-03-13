namespace Principal.Forms.MapaCama.Paciente.Ficha.HC
{
    partial class HC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HC));
            this.panelHC = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHC = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataGridViewHC = new System.Windows.Forms.DataGridView();
            this.panelHC.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHC
            // 
            this.panelHC.Controls.Add(this.groupBox1);
            this.panelHC.Controls.Add(this.panel2);
            this.panelHC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHC.Location = new System.Drawing.Point(20, 60);
            this.panelHC.Name = "panelHC";
            this.panelHC.Size = new System.Drawing.Size(809, 431);
            this.panelHC.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHC);
            this.groupBox1.Controls.Add(this.dataGridViewHC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historia Clinica / Evoluciones";
            // 
            // txtHC
            // 
            this.txtHC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHC.Lines = new string[0];
            this.txtHC.Location = new System.Drawing.Point(219, 16);
            this.txtHC.MaxLength = 32767;
            this.txtHC.Multiline = true;
            this.txtHC.Name = "txtHC";
            this.txtHC.PasswordChar = '\0';
            this.txtHC.PromptText = "Ingrese aqui la evolucion del paciente o el inicio de H.C";
            this.txtHC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHC.SelectedText = "";
            this.txtHC.Size = new System.Drawing.Size(587, 382);
            this.txtHC.TabIndex = 0;
            this.txtHC.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 30);
            this.panel2.TabIndex = 2;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
            this.buttonGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonGuardar.Location = new System.Drawing.Point(691, 0);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(118, 30);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dataGridViewHC
            // 
            this.dataGridViewHC.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHC.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewHC.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewHC.Name = "dataGridViewHC";
            this.dataGridViewHC.Size = new System.Drawing.Size(216, 382);
            this.dataGridViewHC.TabIndex = 1;
            // 
            // HC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.Controls.Add(this.panelHC);
            this.Name = "HC";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Nueva Historia Clinica";
            this.Load += new System.EventHandler(this.NuevaProrroga_Load);
            this.panelHC.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtHC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridViewHC;
        public System.Windows.Forms.Panel panelHC;
    }
}