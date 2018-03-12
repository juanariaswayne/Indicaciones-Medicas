using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using MetroFramework.Forms;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Imagenes
{

    public partial class Imagenes : MetroForm
    {
            private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;
            int locX = 20;
            int locY = 10;
            int sizeWidth = 30;
            int sizeHeight = 30;
        public Imagenes()
        {
            InitializeComponent();
        }

        public void CargarImagenes()
        {
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            locX = 20;
            locY = 10;
            sizeWidth = 30;
            sizeHeight = 30;

            TraeImagenesPaciente();
            TamanioGrande();
        }

        // Adds an ACL entry on the specified directory for the specified account.
        public static void AddDirectorySecurity(string FileName, string Account, FileSystemRights Rights, AccessControlType ControlType)
        {
            // Create a new DirectoryInfo object.
            DirectoryInfo dInfo = new DirectoryInfo(FileName);

            // Get a DirectorySecurity object that represents the 
            // current security settings.
            DirectorySecurity dSecurity = dInfo.GetAccessControl();

            // Add the FileSystemAccessRule to the security settings. 
            dSecurity.AddAccessRule(new FileSystemAccessRule(Account,
                                                            Rights,
                                                            ControlType));

            // Set the new access settings.
            dInfo.SetAccessControl(dSecurity);

        }

        public static void RemoveDirectorySecurity(string FileName, string Account, FileSystemRights Rights, AccessControlType ControlType)
        {
            // Create a new DirectoryInfo object.
            DirectoryInfo dInfo = new DirectoryInfo(FileName);

            // Get a DirectorySecurity object that represents the 
            // current security settings.
            DirectorySecurity dSecurity = dInfo.GetAccessControl();

            // Add the FileSystemAccessRule to the security settings. 
            dSecurity.RemoveAccessRule(new FileSystemAccessRule(Account,
                                                            Rights,
                                                            ControlType));

            // Set the new access settings.
            dInfo.SetAccessControl(dSecurity);

        }
        private void TamanioGrande()

        {
            int SaveVal = 0;
            locX = 20;
            locY = 10;
            sizeWidth = 160;
            sizeHeight = 160;
            foreach (Control p in pnControls.Controls)
            {
                SaveVal = SaveVal + 1;
            }
            if (SaveVal > 0)
            {
                loadControls();
            }
        }


        private void TraeImagenesPaciente()
        {
            DirectoryInfo Folder;
            FileInfo[] Images;

            string pacienteID = Clases.Paciente.PacienteIngresado.ToString();
            string path = @"\\192.168.2.50\iim\" + pacienteID;
            string pathRoot = @"\\192.168.2.50\iim\";

            if (!Directory.Exists(path)) // Si No existe la carpeta a guardar imagenes del paciente
            {                
                Directory.CreateDirectory(path);
                AddDirectorySecurity(path, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                AddDirectorySecurity(pathRoot, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
            }
            else
            {
                AddDirectorySecurity(path, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                AddDirectorySecurity(pathRoot, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                Folder = new DirectoryInfo(path);
                Images = Folder.GetFiles();

                pnControls.Controls.Clear();

                int locnewX = locX;
                int locnewY = locY;
                foreach (FileInfo img in Images)
                {

                    if (img.Extension.ToLower() == ".png" || img.Extension.ToLower() == ".jpg" || img.Extension.ToLower() == ".gif" || img.Extension.ToLower() == ".jpeg" || img.Extension.ToLower() == ".bmp" || img.Extension.ToLower() == ".tif")
                    {

                        if (locnewX >= pnControls.Width - sizeWidth - 10)
                        {
                            locnewX = locX;
                            locY = locY + sizeHeight + 30;
                            locnewY = locY;
                        }
                        else
                        {

                            locnewY = locY;
                        }

                        loadImagestoPanel(img.Name, img.FullName, locnewX, locnewY);
                        locnewY = locY + sizeHeight + 10;
                        locnewX = locnewX + sizeWidth + 10;



                    }
                }
            }

           RemoveDirectorySecurity(path, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
           RemoveDirectorySecurity(pathRoot, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);

        }

        private void GuardaImagenesPaciente()

        {
                       

            DirectoryInfo Folder;
            FileInfo[] Images;
            this.folderBrowserDlg.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDlg.ShowNewFolderButton = false;
            DialogResult result = this.folderBrowserDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Folder = new DirectoryInfo(folderBrowserDlg.SelectedPath);
                Images = Folder.GetFiles();

                string pacienteID = Clases.Paciente.PacienteIngresado.ToString();
                string path = @"\\192.168.2.50\iim\" + pacienteID; //Poner pacienteID como nombre de carpeta
                string pathRoot = @"\\192.168.2.50\iim\";

                if (!Directory.Exists(path)) // Si No existe la carpeta a guardar imagenes del paciente
                {
                    Directory.CreateDirectory(path);
                    AddDirectorySecurity(path, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                    AddDirectorySecurity(pathRoot, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                    foreach (FileInfo img in Images)
                    {

                        if (img.Extension.ToLower() == ".png" || img.Extension.ToLower() == ".jpg" || img.Extension.ToLower() == ".gif" || img.Extension.ToLower() == ".jpeg" || img.Extension.ToLower() == ".bmp" || img.Extension.ToLower() == ".tif")
                        {

                            Bitmap _image = new Bitmap(img.FullName);
                            path = path + img.Name;
                            _image.Save(path);

                        }
                    }

                    RemoveDirectorySecurity(path, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                    RemoveDirectorySecurity(pathRoot, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                }

                else //Ya existe la carpeta a guardar documentos Paciente_id
                {
                    AddDirectorySecurity(path, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                    AddDirectorySecurity(pathRoot, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                    foreach (FileInfo img in Images)
                    {

                        if (img.Extension.ToLower() == ".png" || img.Extension.ToLower() == ".jpg" || img.Extension.ToLower() == ".gif" || img.Extension.ToLower() == ".jpeg" || img.Extension.ToLower() == ".bmp" || img.Extension.ToLower() == ".tif")
                        {
                            Bitmap _image = new Bitmap(img.FullName);
                            string _newPath = path + "\\" + img.Name;
                            _image.Save(_newPath);
                        }
                    }
                    RemoveDirectorySecurity(path, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                    RemoveDirectorySecurity(pathRoot, @"Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                }
            }

        
        }
  
       
        private void loadImagestoPanel(String imageName,String ImageFullName,int newLocX,int newLocY)
        {      
                PictureBox ctrl = new PictureBox();
                ctrl.Image = Image.FromFile(ImageFullName);
                ctrl.Name = ImageFullName;
                ctrl.BackColor = Color.Black;
                ctrl.Location = new Point(newLocX, newLocY);
                ctrl.Size = new System.Drawing.Size(sizeWidth, sizeHeight);
                ctrl.SizeMode = PictureBoxSizeMode.StretchImage;
                ctrl.MouseClick += new MouseEventHandler(control_MouseClick);
                pnControls.Controls.Add(ctrl);            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            locX = 20;
            locY = 10;
            sizeWidth = 30;
            sizeHeight = 30;

            TraeImagenesPaciente();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {           
            locX = 20;
            locY = 10;
            sizeWidth = 30;
            sizeHeight = 30;
            if (pnControls.Controls.Count > 0)
            {
                loadControls();                
            }
         
        }

        private void loadControls()
        {
            int locnewX = locX;
            int locnewY = locY;

            foreach (Control p in pnControls.Controls)
            {
                if (locnewX >= pnControls.Width - sizeWidth - 10)
                {
                    locnewX = locX;
                    locY = locY + sizeHeight + 30;
                    locnewY = locY;
                }
                else
                {

                    locnewY = locY;
                }
                p.Location = new Point(locnewX, locnewY);
                p.Size = new System.Drawing.Size(sizeWidth, sizeHeight);

                locnewY = locY + sizeHeight + 10;
                locnewX = locnewX + sizeWidth + 10;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int SaveVal = 0;
            locX = 20;
            locY = 10;
            sizeWidth =50;
            sizeHeight = 50;
            foreach (Control p in pnControls.Controls)
            {
                SaveVal = SaveVal + 1;
            }
            if (SaveVal > 0)
            {
                loadControls();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int SaveVal = 0;
            locX = 20;
            locY = 10;
            sizeWidth = 80;
            sizeHeight = 80;
            foreach (Control p in pnControls.Controls)
            {
                SaveVal = SaveVal + 1;
            }
            if (SaveVal > 0)
            {
                loadControls();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int SaveVal = 0;
            locX = 20;
            locY = 10;
            sizeWidth = 120;
            sizeHeight = 120;
            foreach (Control p in pnControls.Controls)
            {
                SaveVal = SaveVal + 1;
            }
            if (SaveVal > 0)
            {
                loadControls();
            }
        }

        private void control_MouseClick(object sender, MouseEventArgs e)
        {
           
                Control control = (Control)sender;
                PictureBox pic = (PictureBox)control;
                pictureBox1.Image = pic.Image;
                pictureBox1.Name = pic.Name;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pnControls.Width, pnControls.Height);
            pnControls.DrawToBitmap(bmp, new Rectangle(0, 0, pnControls.Width, pnControls.Height));
            SaveFileDialog dlg = new SaveFileDialog();
            // dlg.Filter = "JPG Files (*.JPG)|*.JPG";
            dlg.FileName = "*";
            dlg.DefaultExt = "bmp";
            dlg.ValidateNames = true;
            dlg.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |Png Image (.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(dlg.FileName);
            }           
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            int SaveVal = 0;
            locX = 20;
            locY = 10;
            sizeWidth = 160;
            sizeHeight = 160;
            foreach (Control p in pnControls.Controls)
            {
                SaveVal = SaveVal + 1;
            }
            if (SaveVal > 0)
            {
                loadControls();
            }
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Desea eliminar la imagen?", "Borrar imagen", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string _path = pictureBox1.Name;
                    pictureBox1.Image.Dispose();
                    System.IO.File.Delete(_path);

                    TraeImagenesPaciente();
                }               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GuardaImagenesPaciente();
            TraeImagenesPaciente();
        }
    }
}
