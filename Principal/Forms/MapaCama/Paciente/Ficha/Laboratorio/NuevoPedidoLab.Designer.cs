namespace Principal.Forms.MapaCama.Paciente.Ficha.Laboratorio
{
    partial class NuevoPedidoLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPedidoLab));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxMicro = new System.Windows.Forms.GroupBox();
            this.chckUrgente = new MetroFramework.Controls.MetroCheckBox();
            this.btnExdeLCR = new MetroFramework.Controls.MetroTile();
            this.btnCoprocultivo = new MetroFramework.Controls.MetroTile();
            this.btnHisRectal = new MetroFramework.Controls.MetroTile();
            this.btnHisNasal = new MetroFramework.Controls.MetroTile();
            this.btnCdePtaCateter = new MetroFramework.Controls.MetroTile();
            this.btnCdeAspTraqueal = new MetroFramework.Controls.MetroTile();
            this.btnUrocultivo = new MetroFramework.Controls.MetroTile();
            this.btnHemocultivo = new MetroFramework.Controls.MetroTile();
            this.panelDivisor = new System.Windows.Forms.Panel();
            this.btnAnalisisSangre = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.groupBoxMicro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxMicro);
            this.panel1.Controls.Add(this.panelDivisor);
            this.panel1.Controls.Add(this.btnAnalisisSangre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 381);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxMicro
            // 
            this.groupBoxMicro.Controls.Add(this.chckUrgente);
            this.groupBoxMicro.Controls.Add(this.btnExdeLCR);
            this.groupBoxMicro.Controls.Add(this.btnCoprocultivo);
            this.groupBoxMicro.Controls.Add(this.btnHisRectal);
            this.groupBoxMicro.Controls.Add(this.btnHisNasal);
            this.groupBoxMicro.Controls.Add(this.btnCdePtaCateter);
            this.groupBoxMicro.Controls.Add(this.btnCdeAspTraqueal);
            this.groupBoxMicro.Controls.Add(this.btnUrocultivo);
            this.groupBoxMicro.Controls.Add(this.btnHemocultivo);
            this.groupBoxMicro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMicro.Location = new System.Drawing.Point(0, 71);
            this.groupBoxMicro.Name = "groupBoxMicro";
            this.groupBoxMicro.Size = new System.Drawing.Size(297, 310);
            this.groupBoxMicro.TabIndex = 2;
            this.groupBoxMicro.TabStop = false;
            this.groupBoxMicro.Text = "Microbiologia";
            // 
            // chckUrgente
            // 
            this.chckUrgente.AutoSize = true;
            this.chckUrgente.Location = new System.Drawing.Point(6, 24);
            this.chckUrgente.Name = "chckUrgente";
            this.chckUrgente.Size = new System.Drawing.Size(143, 15);
            this.chckUrgente.Style = MetroFramework.MetroColorStyle.Red;
            this.chckUrgente.TabIndex = 6;
            this.chckUrgente.Text = "Este pedido es Urgente";
            this.chckUrgente.UseSelectable = true;
            // 
            // btnExdeLCR
            // 
            this.btnExdeLCR.ActiveControl = null;
            this.btnExdeLCR.Location = new System.Drawing.Point(150, 238);
            this.btnExdeLCR.Name = "btnExdeLCR";
            this.btnExdeLCR.Size = new System.Drawing.Size(135, 55);
            this.btnExdeLCR.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnExdeLCR.TabIndex = 5;
            this.btnExdeLCR.Text = "Ex. de LCR";
            this.btnExdeLCR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExdeLCR.UseSelectable = true;
            this.btnExdeLCR.Click += new System.EventHandler(this.btnExdeLCR_Click);
            this.btnExdeLCR.MouseEnter += new System.EventHandler(this.btnExdeLCR_MouseEnter);
            this.btnExdeLCR.MouseLeave += new System.EventHandler(this.btnExdeLCR_MouseLeave);
            // 
            // btnCoprocultivo
            // 
            this.btnCoprocultivo.ActiveControl = null;
            this.btnCoprocultivo.Location = new System.Drawing.Point(6, 238);
            this.btnCoprocultivo.Name = "btnCoprocultivo";
            this.btnCoprocultivo.Size = new System.Drawing.Size(135, 55);
            this.btnCoprocultivo.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCoprocultivo.TabIndex = 4;
            this.btnCoprocultivo.Text = "Coprocultivo";
            this.btnCoprocultivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCoprocultivo.UseSelectable = true;
            this.btnCoprocultivo.Click += new System.EventHandler(this.btnCoprocultivo_Click);
            this.btnCoprocultivo.MouseEnter += new System.EventHandler(this.btnCoprocultivo_MouseEnter);
            this.btnCoprocultivo.MouseLeave += new System.EventHandler(this.btnCoprocultivo_MouseLeave);
            // 
            // btnHisRectal
            // 
            this.btnHisRectal.ActiveControl = null;
            this.btnHisRectal.Location = new System.Drawing.Point(150, 117);
            this.btnHisRectal.Name = "btnHisRectal";
            this.btnHisRectal.Size = new System.Drawing.Size(135, 55);
            this.btnHisRectal.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnHisRectal.TabIndex = 2;
            this.btnHisRectal.Text = "Hisopado rectal";
            this.btnHisRectal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHisRectal.UseSelectable = true;
            this.btnHisRectal.Click += new System.EventHandler(this.btnHisRectal_Click);
            this.btnHisRectal.MouseEnter += new System.EventHandler(this.btnHisRectal_MouseEnter);
            this.btnHisRectal.MouseLeave += new System.EventHandler(this.btnHisRectal_MouseLeave);
            // 
            // btnHisNasal
            // 
            this.btnHisNasal.ActiveControl = null;
            this.btnHisNasal.Location = new System.Drawing.Point(6, 116);
            this.btnHisNasal.Name = "btnHisNasal";
            this.btnHisNasal.Size = new System.Drawing.Size(135, 55);
            this.btnHisNasal.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnHisNasal.TabIndex = 1;
            this.btnHisNasal.Text = "Hisopado nasal";
            this.btnHisNasal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHisNasal.UseSelectable = true;
            this.btnHisNasal.Click += new System.EventHandler(this.btnHisNasal_Click);
            this.btnHisNasal.MouseEnter += new System.EventHandler(this.btnHisNasal_MouseEnter);
            this.btnHisNasal.MouseLeave += new System.EventHandler(this.btnHisNasal_MouseLeave);
            // 
            // btnCdePtaCateter
            // 
            this.btnCdePtaCateter.ActiveControl = null;
            this.btnCdePtaCateter.Location = new System.Drawing.Point(6, 177);
            this.btnCdePtaCateter.Name = "btnCdePtaCateter";
            this.btnCdePtaCateter.Size = new System.Drawing.Size(135, 55);
            this.btnCdePtaCateter.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCdePtaCateter.TabIndex = 3;
            this.btnCdePtaCateter.Text = "C. de pta cateter";
            this.btnCdePtaCateter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCdePtaCateter.UseSelectable = true;
            this.btnCdePtaCateter.Click += new System.EventHandler(this.btnCdePtaCateter_Click);
            this.btnCdePtaCateter.MouseEnter += new System.EventHandler(this.btnCdePtaCateter_MouseEnter);
            this.btnCdePtaCateter.MouseLeave += new System.EventHandler(this.btnCdePtaCateter_MouseLeave);
            // 
            // btnCdeAspTraqueal
            // 
            this.btnCdeAspTraqueal.ActiveControl = null;
            this.btnCdeAspTraqueal.Location = new System.Drawing.Point(150, 178);
            this.btnCdeAspTraqueal.Name = "btnCdeAspTraqueal";
            this.btnCdeAspTraqueal.Size = new System.Drawing.Size(135, 54);
            this.btnCdeAspTraqueal.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCdeAspTraqueal.TabIndex = 2;
            this.btnCdeAspTraqueal.Text = "C. de asp. traqueal";
            this.btnCdeAspTraqueal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCdeAspTraqueal.UseSelectable = true;
            this.btnCdeAspTraqueal.Click += new System.EventHandler(this.btnCdeAspTraqueal_Click);
            this.btnCdeAspTraqueal.MouseEnter += new System.EventHandler(this.btnCdeAspTraqueal_MouseEnter);
            this.btnCdeAspTraqueal.MouseLeave += new System.EventHandler(this.btnCdeAspTraqueal_MouseLeave);
            // 
            // btnUrocultivo
            // 
            this.btnUrocultivo.ActiveControl = null;
            this.btnUrocultivo.Location = new System.Drawing.Point(150, 56);
            this.btnUrocultivo.Name = "btnUrocultivo";
            this.btnUrocultivo.Size = new System.Drawing.Size(135, 55);
            this.btnUrocultivo.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnUrocultivo.TabIndex = 1;
            this.btnUrocultivo.Text = "Urocultivo";
            this.btnUrocultivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUrocultivo.UseSelectable = true;
            this.btnUrocultivo.Click += new System.EventHandler(this.btnUrocultivo_Click);
            this.btnUrocultivo.MouseEnter += new System.EventHandler(this.btnUrocultivo_MouseEnter);
            this.btnUrocultivo.MouseLeave += new System.EventHandler(this.btnUrocultivo_MouseLeave);
            // 
            // btnHemocultivo
            // 
            this.btnHemocultivo.ActiveControl = null;
            this.btnHemocultivo.Location = new System.Drawing.Point(6, 55);
            this.btnHemocultivo.Name = "btnHemocultivo";
            this.btnHemocultivo.Size = new System.Drawing.Size(135, 55);
            this.btnHemocultivo.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnHemocultivo.TabIndex = 0;
            this.btnHemocultivo.Text = "Hemocultivo";
            this.btnHemocultivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHemocultivo.UseSelectable = true;
            this.btnHemocultivo.Click += new System.EventHandler(this.btnHemocultivo_Click);
            this.btnHemocultivo.MouseEnter += new System.EventHandler(this.btnHemocultivo_MouseEnter);
            this.btnHemocultivo.MouseLeave += new System.EventHandler(this.btnHemocultivo_MouseLeave);
            // 
            // panelDivisor
            // 
            this.panelDivisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDivisor.Location = new System.Drawing.Point(0, 45);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.Size = new System.Drawing.Size(297, 26);
            this.panelDivisor.TabIndex = 0;
            // 
            // btnAnalisisSangre
            // 
            this.btnAnalisisSangre.ActiveControl = null;
            this.btnAnalisisSangre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalisisSangre.Location = new System.Drawing.Point(0, 0);
            this.btnAnalisisSangre.Name = "btnAnalisisSangre";
            this.btnAnalisisSangre.Size = new System.Drawing.Size(297, 45);
            this.btnAnalisisSangre.Style = MetroFramework.MetroColorStyle.Red;
            this.btnAnalisisSangre.TabIndex = 1;
            this.btnAnalisisSangre.Text = "Analisis de sangre";
            this.btnAnalisisSangre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnalisisSangre.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnAnalisisSangre.UseSelectable = true;
            this.btnAnalisisSangre.Click += new System.EventHandler(this.btnAnalisisSangre_Click);
            this.btnAnalisisSangre.MouseEnter += new System.EventHandler(this.btnAnalisisSangre_MouseEnter);
            this.btnAnalisisSangre.MouseLeave += new System.EventHandler(this.btnAnalisisSangre_MouseLeave);
            // 
            // NuevoPedidoLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 461);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(317, 455);
            this.Name = "NuevoPedidoLab";
            this.Resizable = false;
            this.Text = "Nuevo pedido de analisis";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.NuevoPedidoLab_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxMicro.ResumeLayout(false);
            this.groupBoxMicro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile btnAnalisisSangre;
        private System.Windows.Forms.GroupBox groupBoxMicro;
        private System.Windows.Forms.Panel panelDivisor;
        private MetroFramework.Controls.MetroTile btnUrocultivo;
        private MetroFramework.Controls.MetroTile btnHemocultivo;
        private MetroFramework.Controls.MetroTile btnExdeLCR;
        private MetroFramework.Controls.MetroTile btnCoprocultivo;
        private MetroFramework.Controls.MetroTile btnHisRectal;
        private MetroFramework.Controls.MetroTile btnHisNasal;
        private MetroFramework.Controls.MetroTile btnCdePtaCateter;
        private MetroFramework.Controls.MetroTile btnCdeAspTraqueal;
        private MetroFramework.Controls.MetroCheckBox chckUrgente;
    }
}