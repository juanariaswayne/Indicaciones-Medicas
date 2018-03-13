namespace Principal.Forms.MapaCama.Paciente.Ficha
{
    partial class FichaPaciente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Indicaciones", 9, 9);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Paciente", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichaPaciente));
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.groupDetalle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabContenido = new MetroFramework.Controls.MetroTabControl();
            this.btnSalir = new System.Windows.Forms.Button();
            this.treeFicha = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupFoto = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupFicha = new System.Windows.Forms.GroupBox();
            this.lblHistoriaClinica = new MetroFramework.Controls.MetroLabel();
            this.lblNumeroObraSocial = new MetroFramework.Controls.MetroLabel();
            this.lblTipoDocumento = new MetroFramework.Controls.MetroLabel();
            this.lblFechaNacimiento = new MetroFramework.Controls.MetroLabel();
            this.lblEdad = new MetroFramework.Controls.MetroLabel();
            this.lblDiasInternados = new MetroFramework.Controls.MetroLabel();
            this.lblFechaIngreso = new MetroFramework.Controls.MetroLabel();
            this.lblObraSocial = new MetroFramework.Controls.MetroLabel();
            this.lblHabitacion = new MetroFramework.Controls.MetroLabel();
            this.lblDiagnostico = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.panelGeneral.SuspendLayout();
            this.groupDetalle.SuspendLayout();
            this.groupFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupFicha.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.groupDetalle);
            this.panelGeneral.Controls.Add(this.btnSalir);
            this.panelGeneral.Controls.Add(this.treeFicha);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(20, 171);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1264, 527);
            this.panelGeneral.TabIndex = 10;
            // 
            // groupDetalle
            // 
            this.groupDetalle.Controls.Add(this.label1);
            this.groupDetalle.Controls.Add(this.tabContenido);
            this.groupDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDetalle.Location = new System.Drawing.Point(149, 0);
            this.groupDetalle.Name = "groupDetalle";
            this.groupDetalle.Size = new System.Drawing.Size(1115, 527);
            this.groupDetalle.TabIndex = 9;
            this.groupDetalle.TabStop = false;
            this.groupDetalle.Enter += new System.EventHandler(this.groupDetalle_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doble click sobre la pestaña para cerrarla";
            // 
            // tabContenido
            // 
            this.tabContenido.AllowDrop = true;
            this.tabContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContenido.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabContenido.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabContenido.Location = new System.Drawing.Point(3, 16);
            this.tabContenido.Name = "tabContenido";
            this.tabContenido.Size = new System.Drawing.Size(1109, 508);
            this.tabContenido.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabContenido.TabIndex = 2;
            this.tabContenido.UseSelectable = true;
            this.tabContenido.UseStyleColors = true;
            this.tabContenido.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabContenido_DrawItem);
            this.tabContenido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabContenido_MouseDoubleClick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.Image = global::Principal.Properties.Resources.LogoSalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(1121, 645);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 26);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // treeFicha
            // 
            this.treeFicha.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeFicha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeFicha.HideSelection = false;
            this.treeFicha.ImageIndex = 0;
            this.treeFicha.ImageList = this.imageList1;
            this.treeFicha.Location = new System.Drawing.Point(0, 0);
            this.treeFicha.Name = "treeFicha";
            treeNode1.ForeColor = System.Drawing.Color.Black;
            treeNode1.ImageIndex = 9;
            treeNode1.Name = "Indicacion";
            treeNode1.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.SelectedImageIndex = 9;
            treeNode1.Text = "Indicaciones";
            treeNode2.Checked = true;
            treeNode2.ForeColor = System.Drawing.Color.Black;
            treeNode2.ImageIndex = 4;
            treeNode2.Name = "Paciente";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.SelectedImageIndex = 4;
            treeNode2.Text = "Paciente";
            this.treeFicha.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeFicha.SelectedImageIndex = 0;
            this.treeFicha.ShowRootLines = false;
            this.treeFicha.Size = new System.Drawing.Size(149, 527);
            this.treeFicha.TabIndex = 0;
            this.treeFicha.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeFicha_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file.png");
            this.imageList1.Images.SetKeyName(1, "add.png");
            this.imageList1.Images.SetKeyName(2, "avatar.png");
            this.imageList1.Images.SetKeyName(3, "cardiogram.png");
            this.imageList1.Images.SetKeyName(4, "doctor.png");
            this.imageList1.Images.SetKeyName(5, "dropper.png");
            this.imageList1.Images.SetKeyName(6, "hospital.png");
            this.imageList1.Images.SetKeyName(7, "nurse.png");
            this.imageList1.Images.SetKeyName(8, "people.png");
            this.imageList1.Images.SetKeyName(9, "pill.png");
            this.imageList1.Images.SetKeyName(10, "plus.png");
            this.imageList1.Images.SetKeyName(11, "report.png");
            this.imageList1.Images.SetKeyName(12, "report-1.png");
            this.imageList1.Images.SetKeyName(13, "resume.png");
            this.imageList1.Images.SetKeyName(14, "stethoscope.png");
            this.imageList1.Images.SetKeyName(15, "surgeon.png");
            this.imageList1.Images.SetKeyName(16, "telephone.png");
            this.imageList1.Images.SetKeyName(17, "add.png");
            this.imageList1.Images.SetKeyName(18, "aids.png");
            this.imageList1.Images.SetKeyName(19, "ambulance.png");
            this.imageList1.Images.SetKeyName(20, "apple.png");
            this.imageList1.Images.SetKeyName(21, "archive.png");
            this.imageList1.Images.SetKeyName(22, "atomic.png");
            this.imageList1.Images.SetKeyName(23, "avatar.png");
            this.imageList1.Images.SetKeyName(24, "bed.png");
            this.imageList1.Images.SetKeyName(25, "blood-drop.png");
            this.imageList1.Images.SetKeyName(26, "blood-sample.png");
            this.imageList1.Images.SetKeyName(27, "book.png");
            this.imageList1.Images.SetKeyName(28, "cardiogram.png");
            this.imageList1.Images.SetKeyName(29, "computer.png");
            this.imageList1.Images.SetKeyName(30, "dna.png");
            this.imageList1.Images.SetKeyName(31, "doctor.png");
            this.imageList1.Images.SetKeyName(32, "dropper.png");
            this.imageList1.Images.SetKeyName(33, "electrocardiogram.png");
            this.imageList1.Images.SetKeyName(34, "emergency-kit.png");
            this.imageList1.Images.SetKeyName(35, "eye.png");
            this.imageList1.Images.SetKeyName(36, "file.png");
            this.imageList1.Images.SetKeyName(37, "flag.png");
            this.imageList1.Images.SetKeyName(38, "flask.png");
            this.imageList1.Images.SetKeyName(39, "folder.png");
            this.imageList1.Images.SetKeyName(40, "folder-1.png");
            this.imageList1.Images.SetKeyName(41, "heart.png");
            this.imageList1.Images.SetKeyName(42, "hospital.png");
            this.imageList1.Images.SetKeyName(43, "hospital-1.png");
            this.imageList1.Images.SetKeyName(44, "hospital-2.png");
            this.imageList1.Images.SetKeyName(45, "hospital-3.png");
            this.imageList1.Images.SetKeyName(46, "hospital-4.png");
            this.imageList1.Images.SetKeyName(47, "image.png");
            this.imageList1.Images.SetKeyName(48, "lungs.png");
            this.imageList1.Images.SetKeyName(49, "magnifying-glass.png");
            this.imageList1.Images.SetKeyName(50, "medical-kit.png");
            this.imageList1.Images.SetKeyName(51, "medicine.png");
            this.imageList1.Images.SetKeyName(52, "medicine-1.png");
            this.imageList1.Images.SetKeyName(53, "medicine-2.png");
            this.imageList1.Images.SetKeyName(54, "medicine-3.png");
            this.imageList1.Images.SetKeyName(55, "microscope.png");
            this.imageList1.Images.SetKeyName(56, "molecule.png");
            this.imageList1.Images.SetKeyName(57, "nurse.png");
            this.imageList1.Images.SetKeyName(58, "nurse-1.png");
            this.imageList1.Images.SetKeyName(59, "people.png");
            this.imageList1.Images.SetKeyName(60, "pill.png");
            this.imageList1.Images.SetKeyName(61, "pills.png");
            this.imageList1.Images.SetKeyName(62, "placeholder.png");
            this.imageList1.Images.SetKeyName(63, "plus.png");
            this.imageList1.Images.SetKeyName(64, "report.png");
            this.imageList1.Images.SetKeyName(65, "report-1.png");
            this.imageList1.Images.SetKeyName(66, "resume.png");
            this.imageList1.Images.SetKeyName(67, "scalpel.png");
            this.imageList1.Images.SetKeyName(68, "science.png");
            this.imageList1.Images.SetKeyName(69, "smartphone.png");
            this.imageList1.Images.SetKeyName(70, "stethoscope.png");
            this.imageList1.Images.SetKeyName(71, "strip.png");
            this.imageList1.Images.SetKeyName(72, "surgeon.png");
            this.imageList1.Images.SetKeyName(73, "syringe.png");
            this.imageList1.Images.SetKeyName(74, "tablets.png");
            this.imageList1.Images.SetKeyName(75, "telephone.png");
            this.imageList1.Images.SetKeyName(76, "test-tube.png");
            this.imageList1.Images.SetKeyName(77, "thermometer.png");
            this.imageList1.Images.SetKeyName(78, "tooth.png");
            this.imageList1.Images.SetKeyName(79, "transfusion.png");
            this.imageList1.Images.SetKeyName(80, "water.png");
            this.imageList1.Images.SetKeyName(81, "x-rays.png");
            // 
            // groupFoto
            // 
            this.groupFoto.Controls.Add(this.picLogo);
            this.groupFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupFoto.Location = new System.Drawing.Point(0, 0);
            this.groupFoto.Name = "groupFoto";
            this.groupFoto.Size = new System.Drawing.Size(149, 111);
            this.groupFoto.TabIndex = 16;
            this.groupFoto.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(33, 15);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(86, 86);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
            // 
            // groupFicha
            // 
            this.groupFicha.Controls.Add(this.lblHistoriaClinica);
            this.groupFicha.Controls.Add(this.lblNumeroObraSocial);
            this.groupFicha.Controls.Add(this.lblTipoDocumento);
            this.groupFicha.Controls.Add(this.lblFechaNacimiento);
            this.groupFicha.Controls.Add(this.lblEdad);
            this.groupFicha.Controls.Add(this.lblDiasInternados);
            this.groupFicha.Controls.Add(this.lblFechaIngreso);
            this.groupFicha.Controls.Add(this.lblObraSocial);
            this.groupFicha.Controls.Add(this.lblHabitacion);
            this.groupFicha.Controls.Add(this.lblDiagnostico);
            this.groupFicha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupFicha.Location = new System.Drawing.Point(149, 0);
            this.groupFicha.Name = "groupFicha";
            this.groupFicha.Size = new System.Drawing.Size(1115, 111);
            this.groupFicha.TabIndex = 15;
            this.groupFicha.TabStop = false;
            this.groupFicha.Visible = false;
            // 
            // lblHistoriaClinica
            // 
            this.lblHistoriaClinica.AutoSize = true;
            this.lblHistoriaClinica.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblHistoriaClinica.Location = new System.Drawing.Point(9, 14);
            this.lblHistoriaClinica.Name = "lblHistoriaClinica";
            this.lblHistoriaClinica.Size = new System.Drawing.Size(95, 15);
            this.lblHistoriaClinica.TabIndex = 27;
            this.lblHistoriaClinica.Text = "Nº Historia Clinica";
            // 
            // lblNumeroObraSocial
            // 
            this.lblNumeroObraSocial.AutoSize = true;
            this.lblNumeroObraSocial.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblNumeroObraSocial.Location = new System.Drawing.Point(490, 74);
            this.lblNumeroObraSocial.Name = "lblNumeroObraSocial";
            this.lblNumeroObraSocial.Size = new System.Drawing.Size(21, 15);
            this.lblNumeroObraSocial.TabIndex = 25;
            this.lblNumeroObraSocial.Text = "Nº";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblTipoDocumento.Location = new System.Drawing.Point(156, 14);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(55, 15);
            this.lblTipoDocumento.TabIndex = 20;
            this.lblTipoDocumento.Text = "Tipo Doc.";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(10, 74);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(62, 15);
            this.lblFechaNacimiento.TabIndex = 18;
            this.lblFechaNacimiento.Text = "Fecha Nac.";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblEdad.Location = new System.Drawing.Point(156, 44);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 14;
            this.lblEdad.Text = "Edad";
            // 
            // lblDiasInternados
            // 
            this.lblDiasInternados.AutoSize = true;
            this.lblDiasInternados.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDiasInternados.Location = new System.Drawing.Point(352, 74);
            this.lblDiasInternados.Name = "lblDiasInternados";
            this.lblDiasInternados.Size = new System.Drawing.Size(85, 15);
            this.lblDiasInternados.TabIndex = 12;
            this.lblDiasInternados.Text = "Días Internados";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFechaIngreso.Location = new System.Drawing.Point(352, 14);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(77, 15);
            this.lblFechaIngreso.TabIndex = 9;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblObraSocial.Location = new System.Drawing.Point(352, 44);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(64, 15);
            this.lblObraSocial.TabIndex = 7;
            this.lblObraSocial.Text = "Obra Social";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblHabitacion.Location = new System.Drawing.Point(10, 44);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(60, 15);
            this.lblHabitacion.TabIndex = 5;
            this.lblHabitacion.Text = "Habitación";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDiagnostico.Location = new System.Drawing.Point(156, 74);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(66, 15);
            this.lblDiagnostico.TabIndex = 3;
            this.lblDiagnostico.Text = "Diagnostico";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.groupFicha);
            this.metroPanel1.Controls.Add(this.groupFoto);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1264, 111);
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroTile1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 698);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1264, 36);
            this.metroPanel2.TabIndex = 13;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroTile1.Location = new System.Drawing.Point(1162, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(102, 36);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "Salir";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // FichaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 754);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "FichaPaciente";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Ficha Paciente";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FichaPaciente_Load);
            this.panelGeneral.ResumeLayout(false);
            this.groupDetalle.ResumeLayout(false);
            this.groupDetalle.PerformLayout();
            this.groupFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupFicha.ResumeLayout(false);
            this.groupFicha.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.GroupBox groupFoto;
        private System.Windows.Forms.GroupBox groupFicha;
        private MetroFramework.Controls.MetroLabel lblEdad;
        private MetroFramework.Controls.MetroLabel lblDiasInternados;
        private MetroFramework.Controls.MetroLabel lblFechaIngreso;
        private MetroFramework.Controls.MetroLabel lblObraSocial;
        private MetroFramework.Controls.MetroLabel lblHabitacion;
        private MetroFramework.Controls.MetroLabel lblDiagnostico;
        private System.Windows.Forms.TreeView treeFicha;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupDetalle;
        private MetroFramework.Controls.MetroTabControl tabContenido;
        private MetroFramework.Controls.MetroLabel lblFechaNacimiento;
        private MetroFramework.Controls.MetroLabel lblTipoDocumento;
        private MetroFramework.Controls.MetroLabel lblHistoriaClinica;
        private MetroFramework.Controls.MetroLabel lblNumeroObraSocial;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogo;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}