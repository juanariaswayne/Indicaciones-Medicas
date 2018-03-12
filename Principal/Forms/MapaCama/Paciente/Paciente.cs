using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neodynamic.SDK.Printing;

namespace Principal.Forms.MapaCama.Paciente
{
    public interface IActuDiagnosticos
    {
        void ActualizaDiagnosticos();
    }
    public partial class Paciente : MetroForm, IActuDiagnosticos
    {

        #region Variables
        public delegate void MapaCamas();
        public event MapaCamas ActualizarMapa;
        private int _idPaciente;
        public int _act;
        public int _baja;
        public int sede_id;
        public int empresa_id;
        public string empresa;
        public int IdPaciente
        {
            get
            {
                return _idPaciente;
            }

            set
            {
                this._idPaciente = value;
            }
        }
        public int Sede_Id
        {
            get
            {
                return sede_id;
            }

            set
            {
                this.sede_id = value;
            }
        }
        public int Empresa_Id
        {
            get
            {
                return empresa_id;
            }

            set
            {
                this.empresa_id = value;
            }
        }
        public string Empresa
        {
            get
            {
                return empresa;
            }

            set
            {
                this.empresa = value;
            }
        }

        #region Impresora
        double _dpi = 96;
        ThermalLabel _currentThermalLabel = null;

        PrinterSettings _printerSettings = new PrinterSettings();
        int _copies = 1;
        PrintOrientation _printOrientation = PrintOrientation.Portrait;
        #endregion

        #endregion

        #region Pulsera

        private ThermalLabel GenerarPulsera(string _idPaciente, string _nombrePaciente)
        {
            //Define a ThermalLabel object and set unit to inch and label size
            ThermalLabel tLabel = new ThermalLabel(UnitType.Cm, 3, 27); //27
                                                                        //tLabel.GapLength = 0.2;



            ////get ThermalLabel SDk install dir and get the sample images
            //string imgFolder = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Neodynamic\\SDK\\ThermalLabel SDK 5.0 for .NET\\InstallDir").GetValue(null).ToString() + "\\Samples\\Images\\";
            //string imgFolder = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Neodynamic\\SDK\\ThermalLabel SDK 5.0 for .NET\\InstallDir").GetValue(null).ToString() + "\\Samples\\Images\\";
            //string imgFolder = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Neodynamic\\SDK\\ThermalLabel SDK 5.0 for .NET\\InstallDir").GetValue(null).ToString() + "\\Samples\\Images\\";
            //string imgFolder = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Neodynamic\\SDK\\ThermalLabel SDK 5.0 for .NET\\InstallDir").GetValue(null).ToString() + "\\Samples\\Images\\";
            string imgFolder = @"\\192.168.2.50\\Indicaciones Medicas\\Logo\\";

            //Define an ImageItem for AdventureWorks logo
            ImageItem awLogo = new ImageItem(1, 30);//27
            awLogo.SourceFile = imgFolder + "logo.jpg"; // LOGO DE LA ETIQUETA
            awLogo.Width = 2.8;
            awLogo.Height = 2.6;
            awLogo.LockAspectRatio = LockAspectRatio.WidthBased;
            awLogo.MonochromeSettings.DitherMethod = DitherMethod.Threshold;
            awLogo.MonochromeSettings.Threshold = 80;
            awLogo.RotationAngle = 90;

            //Define a TextItem object
            TextItem txtItem = (_nombrePaciente.Length > 17) ? new TextItem(1, 8, 200, 2, _nombrePaciente.ToUpper()) : new TextItem(1, 13, 200, 2, _nombrePaciente.ToUpper()); //define el ancho del texto, tambien la posición 10
            txtItem.RotationAngle = 90; //ROTO EL TEXTO A 90º
                                        //font settings
            txtItem.Font.Name = "Arial";
            txtItem.Font.Unit = FontUnit.Point;
            txtItem.Font.Size = (_nombrePaciente.Length > 17) ? 25 : 36;
            txtItem.TextAlignment = TextAlignment.Left;
            //white text on black background
            //txtItem.BackColor = Neodynamic.SDK.Printing.Color.Black;
            //txtItem.ForeColor = Neodynamic.SDK.Printing.Color.White;
            ////padding
            txtItem.TextPadding = new FrameThickness(0.075, 0.03, 0, 0);




            //Define a BarcodeItem object
            BarcodeItem bcItem = new BarcodeItem(1, 26, 2.5, 2.5, BarcodeSymbology.QRCode, _idPaciente.ToString());
            //Set bars height to .75inch
            bcItem.BarHeight = 1;
            //Set bars width to 0.0104inch
            bcItem.BarWidth = 5;
            //bcItem.RotationAngle = 90;
            bcItem.CodeAlignment = BarcodeTextAlignment.BelowJustify;
            bcItem.BarWidth = 25;
            bcItem.BarHeight = 15;
            bcItem.QuietZone = new FrameThickness(0);
            //bcItem.BarcodeAlignment = BarcodeAlignment.MiddleCenter;
            bcItem.BorderThickness = new FrameThickness(0.05); //RECUADRO
            bcItem.Sizing = BarcodeSizing.Fill;

            //linea vertical
            LineShapeItem l1 = new LineShapeItem(0.5, 0.5, 10, 27);
            l1.StrokeThickness = 0.1;
            l1.Orientation = LineOrientation.Vertical;

            //Add items to ThermalLabel object...
            tLabel.Items.Add(awLogo);
            tLabel.Items.Add(txtItem);
            tLabel.Items.Add(bcItem);
            tLabel.Items.Add(l1);

            return tLabel;
        }

        #endregion

        #region Inicio
        public Paciente()
        {
            InitializeComponent();
        }

        public void ActualizaDiagnosticos()
        {
            CargarDiagnosticos();
        }
        private void Paciente_Load(object sender, EventArgs e)
        {
         
            try

            {
                
                this.cboSedeHabitacionDestino.Enabled = false;
                this.cboHabitacionDestino.Enabled = false;
                this.radioMasculino.Checked = true;
                this.cboMotivoEgreso.Enabled = false;
                if (_idPaciente == 0)
                {
                    CargarDiagnosticos();
                    CargarCboTipoDocumento();
                    CargarCboObrasSociales();
                    CargarCboHabitacionDesocupada(sede_id, 0, 0);
                    CargarCboHabitacionDestino(sede_id, 0, 0);
                    this.checkMigrarPaciente.Enabled = false;
                    this.checkMotivoAlta.Enabled = false;
                    this.cboMotivoEgreso.Enabled = false;
                    this.btnModificar.Enabled = false;
                    this.btnPulsera.Enabled = false;
                    _act = 0;
                }
                else
                {
                    CargarDiagnosticos();
                    this.btnGuardar.Enabled = false;
                    this.cboHabitacionDesocupada.Enabled = false;
                    CargarCboTipoDocumento();
                    CargarCboObrasSociales();
                    CargarCboMotivoEgreso();
                    Get_Paciente(_idPaciente);
                    this.btnPulsera.Enabled = true;
                    _act = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboTipoDocumento()
        {
            try
            {
                BLL.Tables.TIPODOCUMENTO _os = new BLL.Tables.TIPODOCUMENTO();
                Entities.Tables.TIPODOCUMENTO _itemSeleccion = new Entities.Tables.TIPODOCUMENTO();
                List<Entities.Tables.TIPODOCUMENTO> _ItemsOS = new List<Entities.Tables.TIPODOCUMENTO>();
                //Limpia el combo
                this.cboTipoDocumento.SuspendLayout();
                this.cboTipoDocumento.DataSource = null;
                this.cboTipoDocumento.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.TIPODOCUMENTO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboTipoDocumento.DisplayMember = BLL.Tables.TIPODOCUMENTO.ColumnNames.DESCRIPCION;
                this.cboTipoDocumento.ValueMember = BLL.Tables.TIPODOCUMENTO.ColumnNames.TIPODOCUMENTO_ID;
                this.cboTipoDocumento.DataSource = _ItemsOS;
                this.cboTipoDocumento.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboHabitacion()
        {
            try
            {
                BLL.Tables.HABITACIONES _os = new BLL.Tables.HABITACIONES();
                Entities.Tables.HABITACIONES _itemSeleccion = new Entities.Tables.HABITACIONES();
                List<Entities.Tables.HABITACIONES> _ItemsOS = new List<Entities.Tables.HABITACIONES>();
                //Limpia el combo
                this.cboHabitacionDesocupada.SuspendLayout();
                this.cboHabitacionDesocupada.DataSource = null;
                this.cboHabitacionDesocupada.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.HABITACION_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboHabitacionDesocupada.DisplayMember = BLL.Tables.HABITACIONES.ColumnNames.DESCRIPCION;
                this.cboHabitacionDesocupada.ValueMember = BLL.Tables.HABITACIONES.ColumnNames.HABITACION_ID;
                this.cboHabitacionDesocupada.DataSource = _ItemsOS;
                this.cboHabitacionDesocupada.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboObrasSociales()
        {
            try
            {
                BLL.Procedures.TRAEOBRASSOCIALES _os = new BLL.Procedures.TRAEOBRASSOCIALES();
                Entities.Procedures.TRAEOBRASSOCIALES _itemSeleccion = new Entities.Procedures.TRAEOBRASSOCIALES();
                List<Entities.Procedures.TRAEOBRASSOCIALES> _ItemsOS = new List<Entities.Procedures.TRAEOBRASSOCIALES>();
                //Limpia el combo
                this.cboObraSocial.SuspendLayout();
                this.cboObraSocial.DataSource = null;
                this.cboObraSocial.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.cli_razsoc = "<Seleccione>";
                _itemSeleccion.cli_cod = "0";
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboObraSocial.DisplayMember = BLL.Procedures.TRAEOBRASSOCIALES.ColumnNames.CLI_RAZSOC;
                this.cboObraSocial.ValueMember = BLL.Procedures.TRAEOBRASSOCIALES.ColumnNames.CLI_COD;
                this.cboObraSocial.DataSource = _ItemsOS;
                this.cboObraSocial.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboHabitacionDesocupada(int _sede, int _actualiza, int habID)
        {
            try
            {
                BLL.Procedures.TRAEHABITACIONESLIBRES _hab = new BLL.Procedures.TRAEHABITACIONESLIBRES();
                Entities.Procedures.TRAEHABITACIONESLIBRES _itemSeleccion = new Entities.Procedures.TRAEHABITACIONESLIBRES();
                List<Entities.Procedures.TRAEHABITACIONESLIBRES> _ItemsHab = new List<Entities.Procedures.TRAEHABITACIONESLIBRES>();
                //Limpia el combo
                this.cboHabitacionDesocupada.SuspendLayout();
                this.cboHabitacionDesocupada.DataSource = null;
                this.cboHabitacionDesocupada.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.habitacion_id = 0;
                _ItemsHab = _hab.ItemList(_sede, _actualiza, habID); //Carga la lista para llenar el combo Hardcodeo 1 que es la sede;
                _ItemsHab.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboHabitacionDesocupada.DisplayMember = BLL.Procedures.TRAEHABITACIONESLIBRES.ColumnNames.DESCRIPCION;
                this.cboHabitacionDesocupada.ValueMember = BLL.Procedures.TRAEHABITACIONESLIBRES.ColumnNames.HABITACION_ID;
                this.cboHabitacionDesocupada.DataSource = _ItemsHab;
                this.cboHabitacionDesocupada.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboSedeHabitacionDestino(int _sede, int _actualiza, int habID)
        {
            try
            {
                BLL.Procedures.TRAEHABITACIONESLIBRES _hab = new BLL.Procedures.TRAEHABITACIONESLIBRES();
                Entities.Procedures.TRAEHABITACIONESLIBRES _itemSeleccion = new Entities.Procedures.TRAEHABITACIONESLIBRES();
                List<Entities.Procedures.TRAEHABITACIONESLIBRES> _ItemsHab = new List<Entities.Procedures.TRAEHABITACIONESLIBRES>();
                //Limpia el combo
                this.cboSedeHabitacionDestino.SuspendLayout();
                this.cboSedeHabitacionDestino.DataSource = null;
                this.cboSedeHabitacionDestino.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.habitacion_id = 0;
                _ItemsHab = _hab.ItemList(_sede, _actualiza, habID); //Carga la lista para llenar el combo Hardcodeo 1 que es la sede;
                _ItemsHab.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboSedeHabitacionDestino.DisplayMember = BLL.Procedures.TRAEHABITACIONESLIBRES.ColumnNames.DESCRIPCION;
                this.cboSedeHabitacionDestino.ValueMember = BLL.Procedures.TRAEHABITACIONESLIBRES.ColumnNames.HABITACION_ID;
                this.cboSedeHabitacionDestino.DataSource = _ItemsHab;
                this.cboSedeHabitacionDestino.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboMotivoEgreso()
        {
            try
            {
                BLL.Tables.MOTIVOEGRESO _os = new BLL.Tables.MOTIVOEGRESO();
                Entities.Tables.MOTIVOEGRESO _itemSeleccion = new Entities.Tables.MOTIVOEGRESO();
                List<Entities.Tables.MOTIVOEGRESO> _ItemsOS = new List<Entities.Tables.MOTIVOEGRESO>();
                //Limpia el combo
                this.cboMotivoEgreso.SuspendLayout();
                this.cboMotivoEgreso.DataSource = null;
                this.cboMotivoEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.MOTIVOEGRESO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboMotivoEgreso.DisplayMember = BLL.Tables.MOTIVOEGRESO.ColumnNames.DESCRIPCION;
                this.cboMotivoEgreso.ValueMember = BLL.Tables.MOTIVOEGRESO.ColumnNames.MOTIVOEGRESO_ID;
                this.cboMotivoEgreso.DataSource = _ItemsOS;
                this.cboMotivoEgreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboHabitacionDestino(int _sede, int _actualiza, int habID)
        {
            try
            {
                BLL.Procedures.TRAEHABITACIONESLIBRES _hab = new BLL.Procedures.TRAEHABITACIONESLIBRES();
                Entities.Procedures.TRAEHABITACIONESLIBRES _itemSeleccion = new Entities.Procedures.TRAEHABITACIONESLIBRES();
                List<Entities.Procedures.TRAEHABITACIONESLIBRES> _ItemsHab = new List<Entities.Procedures.TRAEHABITACIONESLIBRES>();
                //Limpia el combo
                this.cboHabitacionDestino.SuspendLayout();
                this.cboHabitacionDestino.DataSource = null;
                this.cboHabitacionDestino.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.habitacion_id = 0;
                _ItemsHab = _hab.ItemList(_sede, _actualiza, habID); //Carga la lista para llenar el combo Hardcodeo 1 que es la sede;
                _ItemsHab.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboHabitacionDestino.DisplayMember = BLL.Procedures.TRAEHABITACIONESLIBRES.ColumnNames.DESCRIPCION;
                this.cboHabitacionDestino.ValueMember = BLL.Procedures.TRAEHABITACIONESLIBRES.ColumnNames.HABITACION_ID;
                this.cboHabitacionDestino.DataSource = _ItemsHab;
                this.cboHabitacionDestino.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkMigrarPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkMigrarPaciente.Checked == true)
            {
                this.cboSedeHabitacionDestino.Enabled = true;
                this.cboHabitacionDestino.Enabled = true;
            }
            else
            {
                this.cboSedeHabitacionDestino.Enabled = false;
                this.cboHabitacionDestino.Enabled = false;
            }
        }
        private void CargarDiagnosticos()
        {
            try
            {
                SISTMEDEntities c = new SISTMEDEntities();

                var _lista = c.MED_Diagnosticos.ToList();
                _lista = _lista.OrderBy(s => s.Diagnostico).ToList();

                cboDiagnosticos.DataSource = _lista;
                cboDiagnosticos.ValueMember = "diagnostico_id";
                cboDiagnosticos.DisplayMember = "Diagnostico";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos
        private void btnSeleccionarDiagnostico_Click(object sender, EventArgs e)
        {
            Forms.MapaCama.Paciente.Diagnostico.DiagnosticoIngreso  _DiagnosticoIngreso = new Forms.MapaCama.Paciente.Diagnostico.DiagnosticoIngreso();
            _DiagnosticoIngreso.IdPaciente = _idPaciente;
            _DiagnosticoIngreso.ShowDialog();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                {                   
                    Graba_Paciente_Nuevo();                                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {               
                    
                        Modifica_Paciente_Nuevo(IdPaciente);                   
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkMotivoAlta_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkMotivoAlta.Checked == true)
            {
                _baja = 1;
                this.cboMotivoEgreso.Enabled = true;
                //Forms.MapaCama.Paciente.Diagnostico.DiagnosticoEgreso _DiagnosticoEgreso = new Forms.MapaCama.Paciente.Diagnostico.DiagnosticoEgreso();
                //_DiagnosticoEgreso.IdPaciente = _idPaciente;
                //_DiagnosticoEgreso.ShowDialog();

            }
            else
            {
                this.cboMotivoEgreso.Enabled = false;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cboSedeHabitacionDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.cboSedeHabitacionDestino.SelectedIndex == 0)
            {
                CargarCboHabitacionDestino(1, 1, 0);
                this.lblSede.Text = Convert.ToString(1);
            }
            if (this.cboSedeHabitacionDestino.SelectedIndex == 1)
            {
                CargarCboHabitacionDestino(2, 1, 0);
                this.lblSede.Text = Convert.ToString(2);
            }
            if (this.cboSedeHabitacionDestino.SelectedIndex == 2)
            {
                CargarCboHabitacionDestino(3, 1, 0);
                this.lblSede.Text = Convert.ToString(3);
            }
        }
        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtNumeroObraSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        #endregion

        #region Metodos
        private void Limpiar()
        {
            try
            {
                this.txtNombre.Text = String.Empty;
                this.txtApellido.Text = String.Empty;
                this.cboTipoDocumento.SelectedIndex = 0;
                this.txtNumeroDocumento.Text = String.Empty;
                this.cboObraSocial.SelectedIndex = 0;
                this.txtNumeroObraSocial.Text = String.Empty;
                this.radioMasculino.Checked = true;
                this.radioFemenino.Checked = true;
                this.cboHabitacionDesocupada.SelectedIndex = 0;
               // this.buttonAlta.Hide();
                this.cboMotivoEgreso.Hide();
                this.cboSedeHabitacionDestino.Hide();
                this.cboHabitacionDestino.Hide();
                this.labelHabitacion.Hide();
                this.labelMigrarSede.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Graba_Paciente_Nuevo()
        {
            try
            {
                {
                    Entities.Tables.PACIENTES _item = new Entities.Tables.PACIENTES();
                    BLL.Tables.PACIENTES _paciente = new BLL.Tables.PACIENTES();
                    CultureInfo culture = new CultureInfo("en-US");
                    BLL.Procedures.OBTIENEULTIMAHISTORIACLINICA _obtieneUltimaHistoriaClinica = new BLL.Procedures.OBTIENEULTIMAHISTORIACLINICA();
                    foreach (Entities.Procedures.OBTIENEULTIMAHISTORIACLINICA _itemHistoriaClinica in _obtieneUltimaHistoriaClinica.ItemList(empresa_id)) 
                    {
                        _item.NUMEROHISTORIACLINICA = txtHclinica.Text == string.Empty?0:Convert.ToInt32(txtHclinica.Text);
                    }
                    if (this.checkAcompaniante.Checked == true) { _item.ACOMPANIANTE = true; } else { _item.ACOMPANIANTE = false; }
                    if (this.checkItemPendiente.Checked == true) { _item.ITEMPENDIENTE = true; } else { _item.ITEMPENDIENTE = false; }
                    if (this.checkPreAlta.Checked == true) { _item.PREALTA = true; } else { _item.PREALTA = false; }
                    if (this.checkSolicitudEstudio.Checked == true) { _item.SOLICITUDESTUDIO = true; } else { _item.SOLICITUDESTUDIO = false; }
                    if (this.checkSolicitudTraslado.Checked == true) { _item.SOLICITUDTRASLADO = true; } else { _item.SOLICITUDTRASLADO = false; }
                    if (this.checkInterconsultaPendiente.Checked == true) { _item.INTERCONSULTAPENDIENTE = true; } else { _item.INTERCONSULTAPENDIENTE = false; }
                    if (this.checkAltaAutorizada.Checked == true) { _item.ALTAAUTORIZADA = true; } else { _item.ALTAAUTORIZADA = false; }
                    _item.FECHAINGRESO = dateIngreso.Value;
                    _item.NOMBRE = this.txtNombre.Text.ToUpper();
                    _item.APELLIDO = this.txtApellido.Text.ToUpper();
                    _item.TIPODOCUMENTO_ID = Convert.ToInt32(this.cboTipoDocumento.SelectedValue);
                    _item.NUMERODOCUMENTO = Convert.ToInt32(this.txtNumeroDocumento.Text);
                    _item.FECHANACIMIENTO = dateNacimiento.Value;
                    _item.OBRASOCIAL_ID = Convert.ToString(this.cboObraSocial.SelectedValue);
                    _item.NUMEROOBRASOCIAL = txtNumeroObraSocial.Text;
                    if (this.radioMasculino.Checked == true) { _item.GENERO = true; } else { _item.GENERO = false; }
                    _item.SEDE_ID = Convert.ToInt32(sede_id);
                    _item.HABITACION_ID = Convert.ToInt32(this.cboHabitacionDesocupada.SelectedValue);
                    if (this.checkRespira.Checked == true) { _item.RESPIRA  = true; } else { _item.RESPIRA = false; }
                    if (this.checkContacto.Checked == true) { _item.CONTACTO = true; } else { _item.CONTACTO = false; }
                    if (this.checkTqt.Checked == true) { _item.TQT = true; } else { _item.TQT = false; }
                    if (this.checkArm.Checked == true) { _item.ARM = true; } else { _item.ARM = false; }
                    if (this.checkOxigenoTerapia.Checked == true) { _item.OXIGENO = true; } else { _item.OXIGENO = false; }
                    if (this.checkVo.Checked == true) { _item.VO = true; } else { _item.VO = false; }
                    if (this.checkSng.Checked == true) { _item.SNG = true; } else { _item.SNG = false; }
                    if (this.checkGastro.Checked == true) { _item.GASTRO = true; } else { _item.GASTRO = false; }
                    if (this.checkSv.Checked == true) { _item.SV  = true; } else { _item.SV = false; }
                    if (this.checkCat.Checked == true) { _item.CAT = true; } else { _item.CAT = false; }
                    if (this.checkTalla.Checked == true) { _item.TALLA = true; } else { _item.TALLA = false; }
                    if (this.checkTalon.Checked == true) { _item.TALON = true; } else { _item.TALON = false; }
                    if (this.checkSac.Checked == true) { _item.SAC = true; } else { _item.SAC = false; }
                    if (this.checkIsq.Checked == true) { _item.ISQ = true; } else { _item.ISQ = false; }
                    _item.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _item.DIAGNOSTICO_ID = Convert.ToInt32(cboDiagnosticos.SelectedValue);
                    _item.PACIENTE_JUDICIALIZADO = (chckJudicializado.Checked) ? true : false;
                    _item.TXTPACJUDICIALIZADO = txtJudicializado.Text;
                    _item.PACIENTE_TRAUMATICO = (chckTraumatico.Checked) ? true : false;
                    _item.TXTPACTRAUMATICO = txtTraumatico.Text;
                    _item.PEDIATRICO = chckPediatrico.Checked;
                    
                    // Tabla Empresa
                    Entities.Tables.EMPRESA _itemEmpresa = new Entities.Tables.EMPRESA();
                    BLL.Tables.EMPRESA _empresa = new BLL.Tables.EMPRESA();
                    _itemEmpresa.EMPRESA_ID = empresa_id;
                    _itemEmpresa.DESCRIPCION = empresa;
                    _itemEmpresa.ULTIMAHISTORIACLINICA = _item.NUMEROHISTORIACLINICA;

                    if (_act == 0)
                    {
                        _paciente.IngresoPaciente(_item, _itemEmpresa);
                    }
                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Datos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Modifica_Paciente_Nuevo(int paciente_id)
        {
            try
            {         
                    Entities.Tables.PACIENTES_HISTORIAL _item = new Entities.Tables.PACIENTES_HISTORIAL();
                    BLL.Tables.PACIENTES_HISTORIAL _paciente = new BLL.Tables.PACIENTES_HISTORIAL();
                    CultureInfo culture = new CultureInfo("en-US");
                    if (this.checkAcompaniante.Checked == true) { _item.ACOMPANIANTE = true; } else { _item.ACOMPANIANTE = false; }
                    if (this.checkItemPendiente.Checked == true) { _item.ITEMPENDIENTE = true; } else { _item.ITEMPENDIENTE = false; }
                    if (this.checkPreAlta.Checked == true) { _item.PREALTA = true; } else { _item.PREALTA = false; }
                    if (this.checkSolicitudEstudio.Checked == true) { _item.SOLICITUDESTUDIO = true; } else { _item.SOLICITUDESTUDIO = false; }
                    if (this.checkSolicitudTraslado.Checked == true) { _item.SOLICITUDTRASLADO = true; } else { _item.SOLICITUDTRASLADO = false; }
                    if (this.checkInterconsultaPendiente.Checked == true) { _item.INTERCONSULTAPENDIENTE = true; } else { _item.INTERCONSULTAPENDIENTE = false; }
                    if (this.checkAltaAutorizada.Checked == true) { _item.ALTAAUTORIZADA = true; } else { _item.ALTAAUTORIZADA = false; }
                    _item.FECHAINGRESO = Convert.ToDateTime(this.dateIngreso.Value);
                    _item.NUMEROHISTORIACLINICA = txtHclinica.Text == string.Empty ? 0 : Convert.ToInt32(txtHclinica.Text);
                    _item.NOMBRE = this.txtNombre.Text;
                    _item.APELLIDO = this.txtApellido.Text;
                    _item.TIPODOCUMENTO_ID = Convert.ToInt32(this.cboTipoDocumento.SelectedValue);
                    _item.NUMERODOCUMENTO = Convert.ToInt32(this.txtNumeroDocumento.Text);
                    _item.FECHANACIMIENTO = dateNacimiento.Value;
                    _item.OBRASOCIAL_ID = Convert.ToString(this.cboObraSocial.SelectedValue);
                    _item.NUMEROOBRASOCIAL = txtNumeroObraSocial.Text;
                    if (this.radioMasculino.Checked == true) { _item.GENERO = true; } else { _item.GENERO = false; }

                    //_item.DIAGNOSTICO_ID = Convert.ToInt32(this.cboDiagnostico.SelectedValue);

                    _item.SEDE_ID = Convert.ToInt32(this.lblSede.Text); 
                    _item.HABITACION_ID = Convert.ToInt32(this.cboHabitacionDesocupada.SelectedValue);
                    if (this.checkMigrarPaciente.Checked == true)
                    {
                        _item.SEDE_ID = Convert.ToInt32(this.lblSede.Text); ;
                        _item.HABITACION_ID = Convert.ToInt32(this.cboHabitacionDestino.SelectedValue);
                    }
                    if (this.checkMotivoAlta.Checked == true)
                    {
                        _item.MOTIVOEGRESO_ID = Convert.ToInt32(this.cboMotivoEgreso.SelectedValue);
                        _item.FECHAEGRESO = System.DateTime.Now;
                        _item.HABITACION_ID = -1;
                    }
                    if (this.checkRespira.Checked == true) { _item.RESPIRA = true; } else { _item.RESPIRA = false; }
                    if (this.checkContacto.Checked == true) { _item.CONTACTO = true; } else { _item.CONTACTO = false; }
                    if (this.checkTqt.Checked == true) { _item.TQT = true; } else { _item.TQT = false; }
                    if (this.checkArm.Checked == true) { _item.ARM = true; } else { _item.ARM = false; }
                    if (this.checkOxigenoTerapia.Checked == true) { _item.OXIGENO = true; } else { _item.OXIGENO = false; }
                    if (this.checkVo.Checked == true) { _item.VO = true; } else { _item.VO = false; }
                    if (this.checkSng.Checked == true) { _item.SNG = true; } else { _item.SNG = false; }
                    if (this.checkGastro.Checked == true) { _item.GASTRO = true; } else { _item.GASTRO = false; }
                    if (this.checkSv.Checked == true) { _item.SV = true; } else { _item.SV = false; }
                    if (this.checkCat.Checked == true) { _item.CAT = true; } else { _item.CAT = false; }
                    if (this.checkTalla.Checked == true) { _item.TALLA = true; } else { _item.TALLA = false; }
                    if (this.checkTalon.Checked == true) { _item.TALON = true; } else { _item.TALON = false; }
                    if (this.checkSac.Checked == true) { _item.SAC = true; } else { _item.SAC = false; }
                    if (this.checkIsq.Checked == true) { _item.ISQ = true; } else { _item.ISQ = false; }
                    _item.FECHAMODIFICACION = System.DateTime.Now;
                    _item.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _item.PACIENTE_ID = paciente_id;
                    _item.DIAGNOSTICO_ID = Convert.ToInt32(cboDiagnosticos.SelectedValue);
                    _item.PACIENTE_JUDICIALIZADO = (chckJudicializado.Checked) ? true : false;
                    _item.TXTPACJUDICIALIZADO = txtJudicializado.Text;
                    _item.PACIENTE_TRAUMATICO = (chckTraumatico.Checked) ? true : false;
                    _item.TXTPACTRAUMATICO = txtTraumatico.Text;
                    

                Entities.Tables.PACIENTES _item2 = new Entities.Tables.PACIENTES();
                    BLL.Tables.PACIENTES _paciente2 = new BLL.Tables.PACIENTES();
                    _item2.ACOMPANIANTE = _item.ACOMPANIANTE;
                    _item2.ITEMPENDIENTE = _item.ITEMPENDIENTE;
                    _item2.PREALTA = _item.PREALTA;
                    _item2.SOLICITUDESTUDIO = _item.SOLICITUDESTUDIO;
                    _item2.SOLICITUDTRASLADO = _item.SOLICITUDTRASLADO;
                    _item2.INTERCONSULTAPENDIENTE = _item.INTERCONSULTAPENDIENTE;
                    _item2.ALTAAUTORIZADA = _item.ALTAAUTORIZADA;
                    _item2.NUMEROHISTORIACLINICA = _item.NUMEROHISTORIACLINICA;
                    _item2.FECHAINGRESO = _item.FECHAINGRESO;
                    _item2.NOMBRE = _item.NOMBRE;
                    _item2.APELLIDO = _item.APELLIDO;
                    _item2.TIPODOCUMENTO_ID = _item.TIPODOCUMENTO_ID;
                    _item2.NUMERODOCUMENTO = _item.NUMERODOCUMENTO;
                    _item2.FECHANACIMIENTO = _item.FECHANACIMIENTO;
                    _item2.OBRASOCIAL_ID = _item.OBRASOCIAL_ID;
                    _item2.NUMEROOBRASOCIAL = _item.NUMEROOBRASOCIAL;
                    _item2.GENERO = _item.GENERO;
                    _item2.DIAGNOSTICO_ID = _item.DIAGNOSTICO_ID;
                    _item2.SEDE_ID = _item.SEDE_ID;
                    _item2.HABITACION_ID = _item.HABITACION_ID;
                    if (this.checkMigrarPaciente.Checked == true)
                    {
                        _item2.SEDE_ID = _item.SEDE_ID;
                        _item2.HABITACION_ID = _item.HABITACION_ID;
                    }
                    if (this.checkMotivoAlta.Checked == true)
                    {
                        _item2.MOTIVOEGRESO_ID = _item.MOTIVOEGRESO_ID;
                        _item2.FECHAEGRESO = _item.FECHAEGRESO;
                        _item2.HABITACION_ID = _item.HABITACION_ID;
                    }
                    _item2.RESPIRA = _item.RESPIRA;
                    _item2.CONTACTO = _item.CONTACTO;
                    _item2.TQT = _item.TQT;
                    _item2.ARM = _item.ARM;
                    _item2.OXIGENO = _item.OXIGENO;
                    _item2.VO = _item.VO;
                    _item2.SNG = _item.SNG;
                    _item2.GASTRO = _item.GASTRO;
                    _item2.SV = _item.SV;
                    _item2.CAT = _item.CAT;
                    _item2.TALLA = _item.TALLA;
                    _item2.TALON = _item.TALON;
                    _item2.SAC = _item.SAC;
                    _item2.ISQ = _item.ISQ;
                    _item2.FECHAMODIFICACION = _item.FECHAMODIFICACION;
                    _item2.USUARIO_ID = _item.USUARIO_ID;
                    _item2.PACIENTE_ID = _item.PACIENTE_ID;
                    _item2.PEDIATRICO = chckPediatrico.Checked;
                   
                       #region AltaPaciente Tipo, se va de la clinica!
                        if (_baja == 1)
                        {
                        DialogResult result = MessageBox.Show("Se dara de ALTA al Paciente " + this.txtNombre.Text + " " + this.txtApellido.Text, "Salir", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            if (this.cboMotivoEgreso.SelectedIndex == 0)
                            {
                                MessageBox.Show("Debe seleccionar un motivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                _paciente2.ModificaIngresoPaciente(_item, _item2);
                            }
                        }
                    }
                    #endregion
                   
                       #region Modifica Paciente
                       if (_act == 1)
                       {
                       _paciente2.ModificaIngresoPaciente(_item, _item2);
                       }
                       #endregion
                            
                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarMapa();
                this.Close();
            }           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Get_Paciente(int paciente_id)
        {
            CargarCboObrasSociales();
            CargarCboTipoDocumento();
            CargarCboHabitacion();
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                SISTMEDEntities E = new SISTMEDEntities();
                
                foreach (var item in E.Get_Paciente(paciente_id))
                {
                    if (item.acompaniante == true) { this.checkAcompaniante.Checked = true; } else { this.checkAcompaniante.Checked = false; }
                    if (item.itemPendiente == true) { this.checkItemPendiente.Checked = true; } else { this.checkItemPendiente.Checked = false; }
                    if (item.preAlta == true) { this.checkPreAlta.Checked = true; } else { this.checkPreAlta.Checked = false; }
                    if (item.solicitudEstudio == true) { this.checkSolicitudEstudio.Checked = true; } else { this.checkSolicitudEstudio.Checked = false; }
                    if (item.solicitudTraslado == true) { this.checkSolicitudTraslado.Checked = true; } else { this.checkSolicitudTraslado.Checked = false; }
                    if (item.interconsultaPendiente == true) { this.checkInterconsultaPendiente.Checked = true; } else { this.checkInterconsultaPendiente.Checked = false; }
                    if (item.altaAutorizada == true) { this.checkAltaAutorizada.Checked = true; } else { this.checkAltaAutorizada.Checked = false; }
                    this.lblFechaIngreso.Text = Convert.ToString(item.fechaIngreso);
                    this.dateIngreso.Value = item.fechaIngreso.Value;
                    this.lblSede.Text = Convert.ToString(item.sede_id);
                    this.lblNumeroHistoriaClinica.Text = Convert.ToString(item.numeroHistoriaClinica);
                    txtHclinica.Text = Convert.ToString(item.numeroHistoriaClinica);
                    this.txtNombre.Text = item.nombre;
                    this.txtApellido.Text = item.apellido;
                    this.cboTipoDocumento.SelectedValue = item.tipoDocumento_id;
                    this.txtNumeroDocumento.Text = Convert.ToString(item.numeroDocumento);
                    this.dateNacimiento.Value = item.fechaNacimiento.Value;
                    this.cboObraSocial.Text = Convert.ToString(item.obraSocial);
                    this.txtNumeroObraSocial.Text = Convert.ToString(item.numeroObraSocial);
                    if(item.genero  == true) { this.radioMasculino.Checked = true; this.radioFemenino.Checked = false; } else { this.radioMasculino.Checked = false; this.radioFemenino.Checked = true; }
                    if (item.respira == true) { this.checkRespira.Checked = true; } else { this.checkRespira.Checked = false; }
                    if (item.contacto == true) { this.checkContacto.Checked = true; } else { this.checkContacto.Checked = false; }
                    if (item.tqt == true) { this.checkTqt.Checked = true; } else { this.checkTqt.Checked = false; }
                    if (item.arm == true) { this.checkArm.Checked = true; } else { this.checkArm.Checked = false; }
                    if (item.oxigeno == true) { this.checkOxigenoTerapia.Checked = true; } else { this.checkOxigenoTerapia.Checked = false; }
                    if (item.vo == true) { this.checkVo.Checked = true; } else { this.checkVo.Checked = false; }
                    if (item.sng == true) { this.checkSng.Checked = true; } else { this.checkSng.Checked = false; }
                    if (item.gastro == true) { this.checkGastro.Checked = true; } else { this.checkGastro.Checked = false; }
                    if (item.sv == true) { this.checkSv.Checked = true; } else { this.checkSv.Checked = false; }
                    if (item.cat == true) { this.checkCat.Checked = true; } else { this.checkCat.Checked = false; }
                    if (item.talla == true) { this.checkTalla.Checked = true; } else { this.checkTalla.Checked = false; }
                    if (item.talon == true) { this.checkTalon.Checked = true; } else { this.checkTalon.Checked = false; }
                    if (item.sac == true) { this.checkSac.Checked = true; } else { this.checkSac.Checked = false; }
                    if (item.isq == true) { this.checkIsq.Checked = true; } else { this.checkIsq.Checked = false; }
                    this.cboHabitacionDesocupada.SelectedValue = item.habitacion_id;
                    this.cboDiagnosticos.SelectedValue = item.diagnostico_id;
                    chckJudicializado.Checked = item.paciente_judicializado.Value;
                    chckTraumatico.Checked = item.paciente_traumatico.Value;
                    txtJudicializado.Text = item.txtPacJudicializado;
                    txtTraumatico.Text = item.txtPacTraumatico;
                    chckPediatrico.Checked = item.Pediatrico == null? false: item.Pediatrico.Value;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnNuevoDiagnostico_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.MapaCama.Paciente.Nuevo_Diagnostico N = new Nuevo_Diagnostico();
                N.Opener = this;
                N.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPulsera_Click(object sender, EventArgs e)
        {
            if(_idPaciente != 0)
            {
                PrintDialog printDialog1 = new PrintDialog();
                //printDialog1.Document = printDocument1;
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    { 

                    _printerSettings.Communication.CommunicationType = CommunicationType.USB;
                    _printerSettings.PrinterName = printDialog1.PrinterSettings.PrinterName.ToString();
                    _printerSettings.Dpi = 203;
                    _printerSettings.ProgrammingLanguage = ProgrammingLanguage.ZPL; //  (ProgrammingLanguage)Enum.Parse(typeof(ProgrammingLanguage), "ZPL");
                    _copies = 1;
                    _printOrientation = PrintOrientation.Portrait;  //(PrintOrientation)Enum.Parse(typeof(PrintOrientation), "Portrait");

                    _currentThermalLabel = GenerarPulsera(_idPaciente.ToString(), txtApellido.Text + ' ' + txtNombre.Text);

                    using (PrintJob pj = new PrintJob(_printerSettings))
                    {
                        pj.Copies = 1; // set copies
                        pj.PrintOrientation = _printOrientation; //set orientation
                        pj.ThermalLabel = _currentThermalLabel; // set the ThermalLabel object
                        pj.Print(); // print the ThermalLabel object                    
                    }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Abort;
                    }
                }

            }
        }
    }
}
