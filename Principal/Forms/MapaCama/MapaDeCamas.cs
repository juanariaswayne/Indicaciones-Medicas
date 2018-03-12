using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Neodynamic.SDK.Printing;


namespace Principal.Forms.MapaCama
{
    public partial class MapaDeCamas : MetroForm
    {
        #region Variables
        int tiempo = 0;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        private int hora_actual;
        private int una_hora;
        private int dos_horas;
        public int sede_id;
        public string sede;
        public int empresa_id;
        public string empresa;
        public int piso_id;
        private enum Col_Pacientes
        {
            ACOMPANIANTE = 0,
            ITEM_PENDIENTE,
            PRE_ALTA,
            SOLICITUD_ESTUDIO,
            SOLICITUD_TRASLADO,
            INTERCONSULTA_PENDIENTE,
            ALTA_AUTORIZADA,
            HABITACION_ID,
            HABITACION,
            PACIENTE_ID,
            PACIENTE,
            TN,
            HS_23,
            HS_24,
            HS_01,
            HS_02,
            HS_03,
            HS_04,
            HS_05,
            HS_06,
            TM,
            HS_07,
            HS_08,
            HS_09,
            HS_10,
            HS_11,
            HS_12,
            HS_13,
            HS_14,
            TT,
            HS_15,
            HS_16,
            HS_17,
            HS_18,
            HS_19,
            HS_20,
            HS_21,
            HS_22,
            HS_SH
        }       

        public int _idPaciente;
        public int Paciente_Id
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

            #region Impresora
                double _dpi = 96;
                ThermalLabel _currentThermalLabel = null;
         
                PrinterSettings _printerSettings = new PrinterSettings();
                int _copies = 1;
                PrintOrientation _printOrientation = PrintOrientation.Portrait;
            #endregion
        #endregion

        #region Inicio
        public MapaDeCamas()
        {
            InitializeComponent();
        }
        #endregion

        #region Pulsera

        private ThermalLabel GenerarPulsera(string _idPaciente, string _nombrePaciente)
        {
            SISTMEDEntities E = new SISTMEDEntities();
            bool _pediatrico = E.Pacientes.Find(Clases.Paciente.PacienteIngresado).pediatrico == null? false: E.Pacientes.Find(Clases.Paciente.PacienteIngresado).pediatrico.Value;
            //Define a ThermalLabel object and set unit to inch and label size
            //Consulto previamente el Piso y Sede para saber si es pediatria
            ThermalLabel tLabelPediatria = new ThermalLabel(UnitType.Cm, 3, 16); //16
            ThermalLabel tLabelAdulto = new ThermalLabel(UnitType.Cm, 3, 27); //27
            ThermalLabel tLabel;
            if (_pediatrico)//Sede Catamarca Y segundo Piso
            {
                tLabel = tLabelPediatria;
            }
            else
            {
                tLabel = tLabelAdulto;
            }            
            //tLabel.GapLength = 0.2;
            
            ////get ThermalLabel SDk install dir and get the sample images
            //string imgFolder = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Neodynamic\\SDK\\ThermalLabel SDK 5.0 for .NET\\InstallDir").GetValue(null).ToString() + "\\Samples\\Images\\";
            //string imgFolder = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Neodynamic\\SDK\\ThermalLabel SDK 5.0 for .NET\\InstallDir").GetValue(null).ToString() + "\\Samples\\Images\\";
            //string imgFolder = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Neodynamic\\SDK\\ThermalLabel SDK 5.0 for .NET\\InstallDir").GetValue(null).ToString() + "\\Samples\\Images\\";
            //string imgFolder = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Neodynamic\\SDK\\ThermalLabel SDK 5.0 for .NET\\InstallDir").GetValue(null).ToString() + "\\Samples\\Images\\";
            string imgFolder = @"\\192.168.2.50\\Indicaciones Medicas\\Logo\\";

            //Define an ImageItem for AdventureWorks logo
            ImageItem awLogoPediatria = new ImageItem(1, 18);//16
            ImageItem awLogoAdulto = new ImageItem(1, 30);//27
            ImageItem awLogo;
            if (_pediatrico)
            {
                awLogo = awLogoPediatria;
            }
            else
            {
                awLogo = awLogoAdulto;
            }
            awLogo.SourceFile = imgFolder + "logo.jpg"; // LOGO DE LA ETIQUETA
            awLogo.Width = 2.8;
            awLogo.Height = 2.6;
            awLogo.LockAspectRatio = LockAspectRatio.WidthBased;
            awLogo.MonochromeSettings.DitherMethod = DitherMethod.Threshold;
            awLogo.MonochromeSettings.Threshold = 80;
            awLogo.RotationAngle = 90;

            //Define a TextItem object
            TextItem txtItemAdulto = (_nombrePaciente.Length > 17) ? new TextItem(1, 8, 200, 2, _nombrePaciente.ToUpper()) : new TextItem(1, 13, 200, 2, _nombrePaciente.ToUpper()); //define el ancho del texto, tambien la posición
            TextItem txtItemPediatria = (_nombrePaciente.Length > 17) ? new TextItem(1, 2, 200, 2, _nombrePaciente.ToUpper()) : new TextItem(1, 2, 200, 2, _nombrePaciente.ToUpper()); //define el ancho del texto, tambien la posición
            TextItem txtItem;
            if (_pediatrico)
            {
                txtItem = txtItemPediatria;
                txtItem.Font.Size = (_nombrePaciente.Length > 17) ? 17 : 22;
            }
            else
            {
                txtItem = txtItemAdulto;
                txtItem.Font.Size = (_nombrePaciente.Length > 17) ? 25 : 36;
            }
            txtItem.RotationAngle = 90; //ROTO EL TEXTO A 90º
            //font settings
            txtItem.Font.Name = "Arial";
            txtItem.Font.Unit = FontUnit.Point;
            txtItem.TextAlignment = TextAlignment.Left;
            //white text on black background
            //txtItem.BackColor = Neodynamic.SDK.Printing.Color.Black;
            //txtItem.ForeColor = Neodynamic.SDK.Printing.Color.White;
            ////padding
            txtItem.TextPadding = new FrameThickness(0.075, 0.03, 0, 0);


            //Define a BarcodeItem object
            BarcodeItem bcItemAdulto = new BarcodeItem(1, 26, 2.5, 2.5, BarcodeSymbology.QRCode, _idPaciente.ToString());
            BarcodeItem bcItemPediatria = new BarcodeItem(1, 15, 2.5, 2.5, BarcodeSymbology.QRCode, _idPaciente.ToString());
            BarcodeItem bcItem;
            if (_pediatrico)
            {
                bcItem = bcItemPediatria;                
            }
            else
            {
                bcItem = bcItemAdulto;               
            }
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

        #region Eventos
        // Inicio
        private void MapaDeCamas_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuario.Text = Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                if(Clases.Usuario.UsuarioLogeado.Id_Sector == 4)
                {
                    btnEditar.Hide();
                    btnNuevoPaciente.Hide();
                    btnAltas.Hide();
                }
                CargarCboPiso(sede_id);
                if (sede_id == 1)
                { Trae_Pacientes(sede_id, 1); }
                if (sede_id == 2)
                { Trae_Pacientes(sede_id, 3); }
                if (sede_id == 3)
                { Trae_Pacientes(sede_id, 3); }
                time();
                this.Text = sede;
                this.MaximizeBox = false;
                this.ShowInTaskbar = true;
                this.ShowIcon = true;
                this.btnConfiguracion.Hide();
                if (Clases.Usuario.UsuarioLogeado.Id_Sector == 8)
                {
                    this.btnConfiguracion.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewMapa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Clases.Usuario.UsuarioLogeado.Id_Sector == 1 || Clases.Usuario.UsuarioLogeado.Id_Sector == 1002 || Clases.Usuario.UsuarioLogeado.Id_Sector == 8 || Clases.Usuario.UsuarioLogeado.Id_Sector == 6 || Clases.Usuario.UsuarioLogeado.Id_Sector == 6) //Medicos y supervisores
                {
                    Clases.Paciente.PacienteNombre = dataGridViewMapa.Rows[e.RowIndex].Cells[(int)Col_Pacientes.PACIENTE].Value.ToString();
                    Forms.MapaCama.Paciente.Ficha.FichaPaciente _FichaPaciente = new Forms.MapaCama.Paciente.Ficha.FichaPaciente();
                    _FichaPaciente.Paciente_Id = Convert.ToInt32(dataGridViewMapa.CurrentRow.Cells[(int)Col_Pacientes.PACIENTE_ID].Value);
                    _FichaPaciente.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewMapa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clases.Paciente.PacienteIngresado = Convert.ToInt32(dataGridViewMapa.Rows[e.RowIndex].Cells[(int)Col_Pacientes.PACIENTE_ID].Value);
                Clases.Paciente.PacienteNombre = dataGridViewMapa.Rows[e.RowIndex].Cells[(int)Col_Pacientes.PACIENTE].Value.ToString();
                Clases.Paciente.PacientePiso = Convert.ToInt32(cboPiso.SelectedValue);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewMapa_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMapa.IsCurrentCellDirty)
                    dataGridViewMapa.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botones
       
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.MapaCama.Paciente.Ficha.Indicacion.Impresion.Impresion _Impresion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Impresion.Impresion();
                _Impresion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFarmacia_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
           
        }
        private void cboPiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                piso_id = Convert.ToInt32(this.cboPiso.SelectedValue);
                Trae_Pacientes(sede_id, piso_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos
       
        public void Trae_Pacientes(int sede_id, int piso_id)
        {
           
            try
            {
                BLL.Procedures.GET_PACIENTE_POR_SEDE _pacientes = new BLL.Procedures.GET_PACIENTE_POR_SEDE();
                this.dataGridViewMapa.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.GET_PACIENTE_POR_SEDE item in _pacientes.ItemList(sede_id,piso_id)) //HARDCODEO EL 1 SEDE VENEZUELA
                {
                    indice = dataGridViewMapa.Rows.Add();
                    #region Estados
                    //Acompañante
                    if (item.acompaniante != false)
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.ACOMPANIANTE].Value = Convert.ToString(item.acompaniante) == String.Empty  ?  Convert.ToString(item.acompaniante): String.Empty ;
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.ACOMPANIANTE].Style.BackColor = System.Drawing.Color.Tan;
                    }
                    else
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.ACOMPANIANTE].Value = Convert.ToString(item.acompaniante) == String.Empty ? Convert.ToString(item.acompaniante) : String.Empty;
                    }
                    //ItemPendiente
                    if (item.itempendiente != false)
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.ITEM_PENDIENTE].Value = Convert.ToString(item.itempendiente) == String.Empty ? Convert.ToString(item.itempendiente) : String.Empty;
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.ITEM_PENDIENTE].Style.BackColor = System.Drawing.Color.OliveDrab  ;
                    }
                    else
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.ITEM_PENDIENTE].Value = Convert.ToString(item.itempendiente) == String.Empty ? Convert.ToString(item.itempendiente) : String.Empty;
                    }
                    //PreAlta
                    if (item.prealta != false)
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.PRE_ALTA].Value = Convert.ToString(item.prealta) == String.Empty ? Convert.ToString(item.prealta) : String.Empty;
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.PRE_ALTA].Style.BackColor = System.Drawing.Color.Chocolate;
                    }
                    else
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.PRE_ALTA].Value = Convert.ToString(item.prealta) == String.Empty ? Convert.ToString(item.prealta) : String.Empty;
                    }
                    //Solicitud Estudio
                    if (item.solicitudestudio != false)
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.SOLICITUD_ESTUDIO].Value = Convert.ToString(item.solicitudestudio) == String.Empty ? Convert.ToString(item.solicitudestudio) : String.Empty;
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.SOLICITUD_ESTUDIO].Style.BackColor = System.Drawing.Color.Sienna ;
                    }
                    else
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.SOLICITUD_ESTUDIO].Value = Convert.ToString(item.solicitudestudio) == String.Empty ? Convert.ToString(item.solicitudestudio) : String.Empty;
                    }
                    //Solicitud Traslado
                    if (item.solicitudtraslado != false)
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.SOLICITUD_TRASLADO].Value = Convert.ToString(item.solicitudtraslado) == String.Empty ? Convert.ToString(item.solicitudtraslado) : String.Empty;
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.SOLICITUD_TRASLADO].Style.BackColor = System.Drawing.Color.Gold ;
                    }
                    else
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.SOLICITUD_TRASLADO].Value = Convert.ToString(item.solicitudtraslado) == String.Empty ? Convert.ToString(item.solicitudtraslado) : String.Empty;
                    }
                    //Inter Consulta Pendiente
                    if (item.interconsultapendiente != false)
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.INTERCONSULTA_PENDIENTE].Value = Convert.ToString(item.interconsultapendiente) == String.Empty ? Convert.ToString(item.interconsultapendiente) : String.Empty;
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.INTERCONSULTA_PENDIENTE].Style.BackColor = System.Drawing.Color.Tomato;
                    }
                    else
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.INTERCONSULTA_PENDIENTE].Value = Convert.ToString(item.interconsultapendiente) == String.Empty ? Convert.ToString(item.interconsultapendiente) : String.Empty;
                    }
                    //Alta Autorizada
                    if (item.altaautorizada != false)
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.ALTA_AUTORIZADA].Value = Convert.ToString(item.altaautorizada) == String.Empty ? Convert.ToString(item.altaautorizada) : String.Empty;
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.ALTA_AUTORIZADA].Style.BackColor = System.Drawing.Color.Teal;
                    }
                    else
                    {
                        dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.ALTA_AUTORIZADA].Value = Convert.ToString(item.altaautorizada) == String.Empty ? Convert.ToString(item.altaautorizada) : String.Empty;
                    }
                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HABITACION_ID].Value = item.habitacion_id;
                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HABITACION].Value = item.habitacion;
                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.PACIENTE_ID].Value = item.paciente_id;
                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.PACIENTE].Value = item.apellido.Trim() + " " + item.nombre.Trim();
                    #endregion

                    #region  Horarios
                    // Hora actual
                    hora_actual = Convert.ToInt32(System.DateTime.Now.Hour.ToString() );
                    una_hora = 1;
                    dos_horas = 2;
                    //08
                    switch(item.hs_08)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Value = Convert.ToString(item.hs_08) == String.Empty ? Convert.ToString(item.hs_08) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Tag = "08";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                                int h8 = 8;
                                int resultado = hora_actual - h8;
                                if (resultado < una_hora)
                                {
                                    // Medicamento pendiente (color verde)
                                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Value = Convert.ToString(item.hs_08) == String.Empty ? Convert.ToString(item.hs_08) : String.Empty;
                                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Tag = "08";
                                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Style.BackColor = System.Drawing.Color.Green;
                                }
                                if (resultado == una_hora)
                                {
                                    // Hasta 1hs de atraso (color amarillo)
                                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Value = Convert.ToString(item.hs_08) == String.Empty ? Convert.ToString(item.hs_08) : String.Empty;
                                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Tag = "08";
                                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Style.BackColor = System.Drawing.Color.Yellow;
                                    
                                }
                                if (resultado >= dos_horas)
                                {
                                    // Mas de 1hs de atraso (color rojo)
                                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Value = Convert.ToString(item.hs_08) == String.Empty ? Convert.ToString(item.hs_08) : String.Empty;
                                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Tag = "08";
                                    dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Style.BackColor = System.Drawing.Color.Red;
                                }
                            break;          
                        case 2:
                                // Medicamento suministrado parcialmente (color rosa)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Value = Convert.ToString(item.hs_08) == String.Empty ? Convert.ToString(item.hs_08) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Tag = "08";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                                // Medicamento suministrado totalmente (color azul)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Value = Convert.ToString(item.hs_08) == String.Empty ? Convert.ToString(item.hs_08) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Tag = "08";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_08].Style.BackColor = System.Drawing.Color.Blue;
                            break; 

                }
                    //09
                    switch (item.hs_09)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Value = Convert.ToString(item.hs_09) == String.Empty ? Convert.ToString(item.hs_09) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Tag = "09";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h9 = 9;
                            int resultado = hora_actual - h9;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (System.Drawing.Color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Value = Convert.ToString(item.hs_09) == String.Empty ? Convert.ToString(item.hs_09) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Tag = "09";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (System.Drawing.Color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Value = Convert.ToString(item.hs_09) == String.Empty ? Convert.ToString(item.hs_09) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Tag = "09";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (System.Drawing.Color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Value = Convert.ToString(item.hs_09) == String.Empty ? Convert.ToString(item.hs_09) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Tag = "09";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Value = Convert.ToString(item.hs_09) == String.Empty ? Convert.ToString(item.hs_09) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Tag = "09";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Value = Convert.ToString(item.hs_09) == String.Empty ? Convert.ToString(item.hs_09) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Tag = "09";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_09].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //10
                    switch (item.hs_10)
                    {
                        case 0:
                            // Sin medicamento asignado (sin System.Drawing.Color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Value = Convert.ToString(item.hs_10) == String.Empty ? Convert.ToString(item.hs_10) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Tag = "10";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h10 = 10;
                            int resultado = hora_actual - h10;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Value = Convert.ToString(item.hs_10) == String.Empty ? Convert.ToString(item.hs_10) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Tag = "10";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Value = Convert.ToString(item.hs_10) == String.Empty ? Convert.ToString(item.hs_10) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Tag = "10";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Value = Convert.ToString(item.hs_10) == String.Empty ? Convert.ToString(item.hs_10) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Tag = "10";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Value = Convert.ToString(item.hs_10) == String.Empty ? Convert.ToString(item.hs_10) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Tag = "10";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Value = Convert.ToString(item.hs_10) == String.Empty ? Convert.ToString(item.hs_10) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Tag = "10";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_10].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //11
                    switch (item.hs_11)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Value = Convert.ToString(item.hs_11) == String.Empty ? Convert.ToString(item.hs_11) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Tag = "11";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h11 = 11;
                            int resultado = hora_actual - h11;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Value = Convert.ToString(item.hs_11) == String.Empty ? Convert.ToString(item.hs_11) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Tag = "11";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Value = Convert.ToString(item.hs_11) == String.Empty ? Convert.ToString(item.hs_11) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Tag = "11";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Value = Convert.ToString(item.hs_11) == String.Empty ? Convert.ToString(item.hs_11) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Tag = "11";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Value = Convert.ToString(item.hs_11) == String.Empty ? Convert.ToString(item.hs_11) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Tag = "11";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Value = Convert.ToString(item.hs_11) == String.Empty ? Convert.ToString(item.hs_11) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Tag = "11";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_11].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //12
                    switch (item.hs_12)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Value = Convert.ToString(item.hs_12) == String.Empty ? Convert.ToString(item.hs_12) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Tag = "12";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h12 = 12;
                            int resultado = hora_actual - h12;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Value = Convert.ToString(item.hs_12) == String.Empty ? Convert.ToString(item.hs_12) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Tag = "12";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Value = Convert.ToString(item.hs_12) == String.Empty ? Convert.ToString(item.hs_12) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Tag = "12";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Value = Convert.ToString(item.hs_12) == String.Empty ? Convert.ToString(item.hs_12) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Tag = "12";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Value = Convert.ToString(item.hs_12) == String.Empty ? Convert.ToString(item.hs_12) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Tag = "12";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Value = Convert.ToString(item.hs_12) == String.Empty ? Convert.ToString(item.hs_12) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Tag = "12";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_12].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //13
                    switch (item.hs_13)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Value = Convert.ToString(item.hs_13) == String.Empty ? Convert.ToString(item.hs_13) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Tag = "13";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h13 = 13;
                            int resultado = hora_actual - h13;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Value = Convert.ToString(item.hs_13) == String.Empty ? Convert.ToString(item.hs_13) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Tag = "13";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Value = Convert.ToString(item.hs_13) == String.Empty ? Convert.ToString(item.hs_13) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Tag = "13";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Value = Convert.ToString(item.hs_13) == String.Empty ? Convert.ToString(item.hs_13) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Tag = "13";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Value = Convert.ToString(item.hs_13) == String.Empty ? Convert.ToString(item.hs_13) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Tag = "13";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Value = Convert.ToString(item.hs_13) == String.Empty ? Convert.ToString(item.hs_13) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Tag = "13";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_13].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //14
                    switch (item.hs_14)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Value = Convert.ToString(item.hs_14) == String.Empty ? Convert.ToString(item.hs_14) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Tag = "14";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h14 = 14;
                            int resultado = hora_actual - h14;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Value = Convert.ToString(item.hs_14) == String.Empty ? Convert.ToString(item.hs_14) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Tag = "14";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Style.BackColor = System.Drawing.Color.Green;   
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Value = Convert.ToString(item.hs_14) == String.Empty ? Convert.ToString(item.hs_14) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Tag = "14";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Value = Convert.ToString(item.hs_14) == String.Empty ? Convert.ToString(item.hs_14) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Tag = "14";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Value = Convert.ToString(item.hs_14) == String.Empty ? Convert.ToString(item.hs_14) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Tag = "14";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Value = Convert.ToString(item.hs_14) == String.Empty ? Convert.ToString(item.hs_14) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Tag = "14";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_14].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //15
                    switch (item.hs_15)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Value = Convert.ToString(item.hs_15) == String.Empty ? Convert.ToString(item.hs_15) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Tag = "15";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h15 = 15;
                            int resultado = hora_actual - h15;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Value = Convert.ToString(item.hs_15) == String.Empty ? Convert.ToString(item.hs_15) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Tag = "15";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Value = Convert.ToString(item.hs_15) == String.Empty ? Convert.ToString(item.hs_15) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Tag = "15";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Value = Convert.ToString(item.hs_15) == String.Empty ? Convert.ToString(item.hs_15) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Tag = "15";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Value = Convert.ToString(item.hs_15) == String.Empty ? Convert.ToString(item.hs_15) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Tag = "15";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Value = Convert.ToString(item.hs_15) == String.Empty ? Convert.ToString(item.hs_15) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Tag = "15";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_15].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //16
                    switch (item.hs_16)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Value = Convert.ToString(item.hs_16) == String.Empty ? Convert.ToString(item.hs_16) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Tag = "16";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h16 = 16;
                            int resultado = hora_actual - h16;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Value = Convert.ToString(item.hs_16) == String.Empty ? Convert.ToString(item.hs_16) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Tag = "16";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Value = Convert.ToString(item.hs_16) == String.Empty ? Convert.ToString(item.hs_16) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Tag = "16";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Value = Convert.ToString(item.hs_16) == String.Empty ? Convert.ToString(item.hs_16) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Tag = "16";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Value = Convert.ToString(item.hs_16) == String.Empty ? Convert.ToString(item.hs_16) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Tag = "16";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Value = Convert.ToString(item.hs_16) == String.Empty ? Convert.ToString(item.hs_16) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Tag = "16";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_16].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //17
                    switch (item.hs_17)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Value = Convert.ToString(item.hs_17) == String.Empty ? Convert.ToString(item.hs_17) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Tag = "17";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h17 = 17;
                            int resultado = hora_actual - h17;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Value = Convert.ToString(item.hs_17) == String.Empty ? Convert.ToString(item.hs_17) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Tag = "17";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Value = Convert.ToString(item.hs_17) == String.Empty ? Convert.ToString(item.hs_17) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Tag = "17";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Value = Convert.ToString(item.hs_17) == String.Empty ? Convert.ToString(item.hs_17) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Tag = "17";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Value = Convert.ToString(item.hs_17) == String.Empty ? Convert.ToString(item.hs_17) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Tag = "17";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Value = Convert.ToString(item.hs_17) == String.Empty ? Convert.ToString(item.hs_17) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Tag = "17";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_17].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //18
                    switch (item.hs_18)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Value = Convert.ToString(item.hs_18) == String.Empty ? Convert.ToString(item.hs_18) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Tag = "18";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h18 = 18;
                            int resultado = hora_actual - h18;

                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Value = Convert.ToString(item.hs_18) == String.Empty ? Convert.ToString(item.hs_18) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Tag = "18";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Style.BackColor = System.Drawing.Color.Green;

                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Value = Convert.ToString(item.hs_18) == String.Empty ? Convert.ToString(item.hs_18) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Tag = "18";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Value = Convert.ToString(item.hs_18) == String.Empty ? Convert.ToString(item.hs_18) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Tag = "18";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Value = Convert.ToString(item.hs_18) == String.Empty ? Convert.ToString(item.hs_18) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Tag = "18";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Value = Convert.ToString(item.hs_18) == String.Empty ? Convert.ToString(item.hs_18) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Tag = "18";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_18].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //19
                    switch (item.hs_19)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Value = Convert.ToString(item.hs_19) == String.Empty ? Convert.ToString(item.hs_19) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Tag = "19";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h19 = 19;
                            int resultado = hora_actual - h19;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Value = Convert.ToString(item.hs_19) == String.Empty ? Convert.ToString(item.hs_19) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Tag = "19";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Value = Convert.ToString(item.hs_19) == String.Empty ? Convert.ToString(item.hs_19) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Tag = "19";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Value = Convert.ToString(item.hs_19) == String.Empty ? Convert.ToString(item.hs_19) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Tag = "19";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Value = Convert.ToString(item.hs_19) == String.Empty ? Convert.ToString(item.hs_19) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Tag = "19";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Value = Convert.ToString(item.hs_19) == String.Empty ? Convert.ToString(item.hs_19) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Tag = "19";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_19].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //20
                    switch (item.hs_20)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Value = Convert.ToString(item.hs_20) == String.Empty ? Convert.ToString(item.hs_20) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Tag = "20";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h20 = 20;
                            int resultado = hora_actual - h20;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Value = Convert.ToString(item.hs_20) == String.Empty ? Convert.ToString(item.hs_20) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Tag = "20";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Value = Convert.ToString(item.hs_20) == String.Empty ? Convert.ToString(item.hs_20) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Tag = "20";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Value = Convert.ToString(item.hs_20) == String.Empty ? Convert.ToString(item.hs_20) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Tag = "20";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Value = Convert.ToString(item.hs_20) == String.Empty ? Convert.ToString(item.hs_20) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Tag = "20";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Value = Convert.ToString(item.hs_20) == String.Empty ? Convert.ToString(item.hs_20) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Tag = "20";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_20].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //21
                    switch (item.hs_21)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Value = Convert.ToString(item.hs_21) == String.Empty ? Convert.ToString(item.hs_21) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Tag = "21";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h21 = 21;
                            int resultado = hora_actual - h21;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Value = Convert.ToString(item.hs_21) == String.Empty ? Convert.ToString(item.hs_21) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Tag = "21";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Value = Convert.ToString(item.hs_21) == String.Empty ? Convert.ToString(item.hs_21) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Tag = "21";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Value = Convert.ToString(item.hs_21) == String.Empty ? Convert.ToString(item.hs_21) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Tag = "21";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Value = Convert.ToString(item.hs_21) == String.Empty ? Convert.ToString(item.hs_21) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Tag = "21";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Value = Convert.ToString(item.hs_21) == String.Empty ? Convert.ToString(item.hs_21) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Tag = "21";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_21].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //22
                    switch (item.hs_22)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Value = Convert.ToString(item.hs_22) == String.Empty ? Convert.ToString(item.hs_22) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Tag = "22";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h22 = 22;
                            int resultado = hora_actual - h22;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Value = Convert.ToString(item.hs_22) == String.Empty ? Convert.ToString(item.hs_22) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Tag = "22";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Style.BackColor = System.Drawing.Color.Green;

                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Value = Convert.ToString(item.hs_22) == String.Empty ? Convert.ToString(item.hs_22) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Tag = "22";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Value = Convert.ToString(item.hs_22) == String.Empty ? Convert.ToString(item.hs_22) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Tag = "22";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Value = Convert.ToString(item.hs_22) == String.Empty ? Convert.ToString(item.hs_22) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Tag = "22";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Value = Convert.ToString(item.hs_22) == String.Empty ? Convert.ToString(item.hs_22) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Tag = "22";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_22].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //23
                    switch (item.hs_23)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Value = Convert.ToString(item.hs_23) == String.Empty ? Convert.ToString(item.hs_23) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Tag = "23";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h23 = 23;
                            int resultado = hora_actual - h23;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Value = Convert.ToString(item.hs_23) == String.Empty ? Convert.ToString(item.hs_23) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Tag = "23";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Value = Convert.ToString(item.hs_23) == String.Empty ? Convert.ToString(item.hs_23) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Tag = "23";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Value = Convert.ToString(item.hs_23) == String.Empty ? Convert.ToString(item.hs_23) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Tag = "23";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Value = Convert.ToString(item.hs_23) == String.Empty ? Convert.ToString(item.hs_23) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Tag = "23";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Value = Convert.ToString(item.hs_23) == String.Empty ? Convert.ToString(item.hs_23) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Tag = "23";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_23].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //24
                    switch (item.hs_24)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Value = Convert.ToString(item.hs_24) == String.Empty ? Convert.ToString(item.hs_24) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Tag = "24";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h24 = 24;
                            int resultado = hora_actual - h24;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Value = Convert.ToString(item.hs_24) == String.Empty ? Convert.ToString(item.hs_24) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Tag = "24";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Value = Convert.ToString(item.hs_24) == String.Empty ? Convert.ToString(item.hs_24) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Tag = "24";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Value = Convert.ToString(item.hs_24) == String.Empty ? Convert.ToString(item.hs_24) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Tag = "24";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Value = Convert.ToString(item.hs_24) == String.Empty ? Convert.ToString(item.hs_24) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Tag = "24";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Value = Convert.ToString(item.hs_24) == String.Empty ? Convert.ToString(item.hs_24) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Tag = "24";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_24].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //01
                    switch (item.hs_01)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Value = Convert.ToString(item.hs_01) == String.Empty ? Convert.ToString(item.hs_01) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Tag = "01";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h01 = 1;
                            int resultado = hora_actual - h01;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Value = Convert.ToString(item.hs_01) == String.Empty ? Convert.ToString(item.hs_01) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Tag = "01";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Value = Convert.ToString(item.hs_01) == String.Empty ? Convert.ToString(item.hs_01) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Tag = "01";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Value = Convert.ToString(item.hs_01) == String.Empty ? Convert.ToString(item.hs_01) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Tag = "01";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Value = Convert.ToString(item.hs_01) == String.Empty ? Convert.ToString(item.hs_01) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Tag = "01";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Value = Convert.ToString(item.hs_01) == String.Empty ? Convert.ToString(item.hs_01) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Tag = "01";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_01].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //02
                    switch (item.hs_02)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Value = Convert.ToString(item.hs_02) == String.Empty ? Convert.ToString(item.hs_02) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Tag = "02";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h02 = 2;
                            int resultado = hora_actual - h02;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Value = Convert.ToString(item.hs_02) == String.Empty ? Convert.ToString(item.hs_02) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Tag = "02";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Value = Convert.ToString(item.hs_02) == String.Empty ? Convert.ToString(item.hs_02) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Tag = "02";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Style.BackColor = System.Drawing.Color.Yellow;
                            }

                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Value = Convert.ToString(item.hs_02) == String.Empty ? Convert.ToString(item.hs_02) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Tag = "02";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Value = Convert.ToString(item.hs_02) == String.Empty ? Convert.ToString(item.hs_02) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Tag = "02";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Value = Convert.ToString(item.hs_02) == String.Empty ? Convert.ToString(item.hs_02) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Tag = "02";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_02].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //03
                    switch (item.hs_03)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Value = Convert.ToString(item.hs_03) == String.Empty ? Convert.ToString(item.hs_03) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Tag = "03";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h03 = 3;
                            int resultado = hora_actual - h03;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Value = Convert.ToString(item.hs_03) == String.Empty ? Convert.ToString(item.hs_03) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Tag = "03";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Value = Convert.ToString(item.hs_03) == String.Empty ? Convert.ToString(item.hs_03) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Tag = "03";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Value = Convert.ToString(item.hs_03) == String.Empty ? Convert.ToString(item.hs_03) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Tag = "03";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Value = Convert.ToString(item.hs_03) == String.Empty ? Convert.ToString(item.hs_03) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Tag = "03";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Value = Convert.ToString(item.hs_03) == String.Empty ? Convert.ToString(item.hs_03) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Tag = "03";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_03].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //04
                    switch (item.hs_04)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Value = Convert.ToString(item.hs_04) == String.Empty ? Convert.ToString(item.hs_04) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Tag = "04";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h04 = 4;
                            int resultado = hora_actual - h04;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Value = Convert.ToString(item.hs_04) == String.Empty ? Convert.ToString(item.hs_04) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Tag = "04";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Value = Convert.ToString(item.hs_04) == String.Empty ? Convert.ToString(item.hs_04) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Tag = "04";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Value = Convert.ToString(item.hs_04) == String.Empty ? Convert.ToString(item.hs_04) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Tag = "04";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Value = Convert.ToString(item.hs_04) == String.Empty ? Convert.ToString(item.hs_04) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Tag = "04";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Value = Convert.ToString(item.hs_04) == String.Empty ? Convert.ToString(item.hs_04) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Tag = "04";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_04].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //05
                    switch (item.hs_05)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Value = Convert.ToString(item.hs_05) == String.Empty ? Convert.ToString(item.hs_05) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Tag = "05";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h05 = 5;
                            int resultado = hora_actual - h05;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Value = Convert.ToString(item.hs_05) == String.Empty ? Convert.ToString(item.hs_05) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Tag = "05";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Value = Convert.ToString(item.hs_05) == String.Empty ? Convert.ToString(item.hs_05) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Tag = "05";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Value = Convert.ToString(item.hs_05) == String.Empty ? Convert.ToString(item.hs_05) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Tag = "05";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Value = Convert.ToString(item.hs_05) == String.Empty ? Convert.ToString(item.hs_05) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Tag = "05";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Value = Convert.ToString(item.hs_05) == String.Empty ? Convert.ToString(item.hs_05) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Tag = "05";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_05].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //06
                    switch (item.hs_06)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Value = Convert.ToString(item.hs_06) == String.Empty ? Convert.ToString(item.hs_06) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Tag = "06";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h06 = 6;
                            int resultado = hora_actual - h06;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Value = Convert.ToString(item.hs_06) == String.Empty ? Convert.ToString(item.hs_06) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Tag = "06";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Value = Convert.ToString(item.hs_06) == String.Empty ? Convert.ToString(item.hs_06) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Tag = "06";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Value = Convert.ToString(item.hs_06) == String.Empty ? Convert.ToString(item.hs_06) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Tag = "06";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Value = Convert.ToString(item.hs_06) == String.Empty ? Convert.ToString(item.hs_06) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Tag = "06";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Value = Convert.ToString(item.hs_06) == String.Empty ? Convert.ToString(item.hs_06) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Tag = "06";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_06].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                    //07
                    switch (item.hs_07)
                    {
                        case 0:
                            // Sin medicamento asignado (sin color)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Value = Convert.ToString(item.hs_07) == String.Empty ? Convert.ToString(item.hs_07) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Tag = "07";
                            break;
                        case 1:
                            // Evaluo si tiene alguna medicación para este horario
                            int h07 = 7;
                            int resultado = hora_actual - h07;
                            if (resultado < una_hora)
                            {
                                // Medicamento pendiente (color verde)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Value = Convert.ToString(item.hs_07) == String.Empty ? Convert.ToString(item.hs_07) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Tag = "07";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Style.BackColor = System.Drawing.Color.Green;
                            }
                            if (resultado == una_hora)
                            {
                                // Hasta 1hs de atraso (color amarillo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Value = Convert.ToString(item.hs_07) == String.Empty ? Convert.ToString(item.hs_07) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Tag = "07";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Style.BackColor = System.Drawing.Color.Yellow;
                            }
                            if (resultado >= dos_horas)
                            {
                                // Mas de 1hs de atraso (color rojo)
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Value = Convert.ToString(item.hs_07) == String.Empty ? Convert.ToString(item.hs_07) : String.Empty;
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Tag = "07";
                                dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Style.BackColor = System.Drawing.Color.Red;
                            }
                            break;
                        case 2:
                            // Medicamento suministrado parcialmente (color rosa)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Value = Convert.ToString(item.hs_07) == String.Empty ? Convert.ToString(item.hs_07) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Tag = "07";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Style.BackColor = System.Drawing.Color.Pink;
                            break;
                        case 3:
                            // Medicamento suministrado totalmente (color azul)
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Value = Convert.ToString(item.hs_07) == String.Empty ? Convert.ToString(item.hs_07) : String.Empty;
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Tag = "07";
                            dataGridViewMapa.Rows[indice].Cells[(int)Col_Pacientes.HS_07].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }

                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboPiso(int _sede)
        {
            try
            {
                BLL.Procedures.GET_PISO_POR_SEDE _hab = new BLL.Procedures.GET_PISO_POR_SEDE();
                Entities.Procedures.GET_PISO_POR_SEDE _itemSeleccion = new Entities.Procedures.GET_PISO_POR_SEDE();
                List<Entities.Procedures.GET_PISO_POR_SEDE> _ItemsHab = new List<Entities.Procedures.GET_PISO_POR_SEDE>();
                //Limpia el combo
                this.cboPiso.SuspendLayout();
                this.cboPiso.DataSource = null;
                this.cboPiso.Items.Clear();
                //Carga el item de Seleccion
                //_itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.piso_id = 1;
                _ItemsHab = _hab.ItemList(_sede); //Carga la lista para llenar el combo Hardcodeo 1 que es la sede;
                //_ItemsHab.Insert(1, _itemSeleccion);
                //Carga el combo
                this.cboPiso.DisplayMember = BLL.Procedures.GET_PISO_POR_SEDE.ColumnNames.DESCRIPCION;
                this.cboPiso.ValueMember = BLL.Procedures.GET_PISO_POR_SEDE.ColumnNames.PISO_ID;
                this.cboPiso.DataSource = _ItemsHab;
                this.cboPiso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarMapa()
        {
            try
            {
                Trae_Pacientes(sede_id, piso_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void time()
        {
            try
            {
                t.Interval = 30000; // 60000 = 1min
                t.Tick += new EventHandler(timer_Tick);
                t.Start();

                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                Trae_Pacientes(sede_id, piso_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                if (tiempo == 30)
                {
                    tiempo = 0;
                    tiempo++;
                    lblTimer.Text = (tiempo).ToString();
                }
                else
                {
                    tiempo++;
                    lblTimer.Text = (tiempo).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void MapaDeCamas_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            try
            {
                CambioClave C = new CambioClave();
                C.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.Parametros.Configuraciones C = new Parametros.Configuraciones();
                C.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInternaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.MapaCama.Paciente.Paciente _NuevoPaciente = new Forms.MapaCama.Paciente.Paciente();
                _NuevoPaciente.Sede_Id = sede_id;
                _NuevoPaciente.Empresa_Id = empresa_id;
                _NuevoPaciente.Empresa = empresa;
                _NuevoPaciente.ActualizarMapa += new Forms.MapaCama.Paciente.Paciente.MapaCamas(ActualizarMapa);
                _NuevoPaciente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Forms.MapaCama.Paciente.Paciente _EditaPaciente = new Forms.MapaCama.Paciente.Paciente();
                _EditaPaciente.IdPaciente = Convert.ToInt32(dataGridViewMapa.Rows[dataGridViewMapa.CurrentRow.Index].Cells[(int)Col_Pacientes.PACIENTE_ID].Value);
                _EditaPaciente.ActualizarMapa += new Forms.MapaCama.Paciente.Paciente.MapaCamas(ActualizarMapa);
                _EditaPaciente.ShowDialog();
                this.Cursor = Cursors.Arrow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            try
            {
                Forms.MapaCama.Paciente.Ficha.Indicacion.Impresion.Impresion _imp = new Paciente.Ficha.Indicacion.Impresion.Impresion();
                _imp.Paciente_id = Clases.Paciente.PacienteIngresado;
                _imp.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                PacientesDeAlta P = new PacientesDeAlta();
                P.ShowDialog();
                Cursor = Cursors.Arrow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkInstructivos_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTilePulsera_Click(object sender, EventArgs e)
        {

            if (Clases.Paciente.PacienteIngresado.ToString() != string.Empty)
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

                        _currentThermalLabel = GenerarPulsera(Clases.Paciente.PacienteIngresado.ToString(), Clases.Paciente.PacienteNombre.ToString());

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
            else
            {
                MessageBox.Show("Debe seleccionar un Paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
