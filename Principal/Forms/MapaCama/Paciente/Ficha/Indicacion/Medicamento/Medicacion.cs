using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Globalization;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento
{
    public partial class Medicacion : MetroForm
    {
        #region Variables

        public IActuIndicaciones Opener { get; set; }

       // MED_SuministroDeMedicacion _itemSuministroOriginal;
        
        private int suministro_medicacion_id;
        private int paciente_id;
        private string paciente;
        private string medicamento_id;
        private string medicamento;
        private string presentacion;
        private string potencia;
        private bool inactivo = false;
        public int Suministro_Medicacion_Id
        {
            get
            {
                return suministro_medicacion_id;
            }
            set
            {
                this.suministro_medicacion_id = value;
            }
        }
        public int Paciente_Id
        {
            get
            {
                return paciente_id;
            }
            set
            {
                this.paciente_id = value;
            }
        }
        public string Paciente
        {
            get
            {
                return paciente;
            }
            set
            {
                this.paciente = value;
            }
        }
        public string Medicamento_Id
        {
            get
            {
                return medicamento_id;
            }
            set
            {
                this.medicamento_id = value;
            }
        }
        public string Medicamento
        {
            get
            {
                return medicamento;
            }
            set
            {
                this.medicamento = value;
            }
        }
        public string Presentacion
        {
            get
            {
                return presentacion;
            }
            set
            {
                this.presentacion = value;
            }
        }
        public string Potencia
        {
            get
            {
                return potencia;
            }
            set
            {
                this.potencia = value;
            }
        }
        #endregion

        #region Eventos
        //--------------------------------------------------------------------------------------------------------------------- LOAD
        public Medicacion()
        {
            InitializeComponent();
            //Inicializa
            radioHorarioFijo.Checked = true;
            dtpLapsoHasta.Enabled = false;
            txtViaOtro.Enabled = false;
            dtpInicio.Focus();
        }
        private void Medicacion_Load(object sender, EventArgs e)
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();
                if (suministro_medicacion_id != 0)
                {
                    GetIndicacionesResumen(suministro_medicacion_id, paciente_id, medicamento_id, "MED");
                    btnGuardar.Hide();
                    dtpInicio.Enabled = false;
                   // _itemSuministroOriginal = E.MED_SuministroDeMedicacion.Find(suministro_medicacion_id);
                }
                else
                {
                    btnModificar.Hide();
                    this.groupSuspender.Enabled = false;
                    this.txtEvento.Enabled = false;
                    // Carga Combos
                    CargarCboVia(medicamento_id, inactivo);
                    CargarCboDiluyente();
                    CargarCboDurante();
                    CargaCboPeriodo();
                    CargarCboDuranteInternacion();
                    CargaCboPeriodoInternacion();
                    // Completo TextBox con datos del formulario SeleccionarMedicamento
                    txtPresentacion.Text = presentacion;
                    lblPotencia.Text = potencia;
                    lblNombreDeMedicamento.Text = medicamento + " - " + potencia;
                    if (this.txtPresentacion.Text == "AEROSOL") { this.lblUnidadDeMedida.Text = "APLICACIONES"; }
                    if (this.txtPresentacion.Text == "AMPOLLA") { this.lblUnidadDeMedida.Text = "AMPOLLAS"; }
                    if (this.txtPresentacion.Text == "BOTELLA") { this.lblUnidadDeMedida.Text = "ML"; }
                    if (this.txtPresentacion.Text == "CAPSULAS") { this.lblUnidadDeMedida.Text = "CAPSULAS"; }
                    if (this.txtPresentacion.Text == "COMPRIMIDO") { this.lblUnidadDeMedida.Text = "COMPRIMIDOS"; }
                    if (this.txtPresentacion.Text == "CREMA") { this.lblUnidadDeMedida.Text = "APLICACIONES"; }
                    if (this.txtPresentacion.Text == "DOSIS") { this.lblUnidadDeMedida.Text = "DOSIS"; }
                    if (this.txtPresentacion.Text == "ELIXIR") { this.lblUnidadDeMedida.Text = ""; } // (sin valor)
                    if (this.txtPresentacion.Text == "EMULSION") { this.lblUnidadDeMedida.Text = "ML"; }
                    if (this.txtPresentacion.Text == "FRASCO") { this.lblUnidadDeMedida.Text = "ML/GR"; }
                    if (this.txtPresentacion.Text == "FRASCO/AMPOLLA") { this.lblUnidadDeMedida.Text = "FRASCO/AMPOLLA"; }
                    if (this.txtPresentacion.Text == "GEL") { this.lblUnidadDeMedida.Text = "APLICACIONES"; }
                    if (this.txtPresentacion.Text == "GOTAS") { this.lblUnidadDeMedida.Text = "GOTAS"; }
                    if (this.txtPresentacion.Text == "GRAGEAS") { this.lblUnidadDeMedida.Text = "GRAGEAS"; }
                    if (this.txtPresentacion.Text == "JALEA") { this.lblUnidadDeMedida.Text = "ML"; }
                    if (this.txtPresentacion.Text == "JARABE") { this.lblUnidadDeMedida.Text = "ML"; }
                    if (this.txtPresentacion.Text == "JERINGA PRELLEN") { this.lblUnidadDeMedida.Text = "UNIDADES"; }
                    if (this.txtPresentacion.Text == "JERINGA/CARTUCH") { this.lblUnidadDeMedida.Text = "UNIDADES"; }
                    if (this.txtPresentacion.Text == "LACA") { this.lblUnidadDeMedida.Text = "ML"; }
                    if (this.txtPresentacion.Text == "LAPICERA") { this.lblUnidadDeMedida.Text = ""; } // (sin valor)
                    if (this.txtPresentacion.Text == "LAPIZ") { this.lblUnidadDeMedida.Text = ""; } // (sin valor)
                    if (this.txtPresentacion.Text == "LIQUIDO") { this.lblUnidadDeMedida.Text = "ML"; }
                    if (this.txtPresentacion.Text == "LOCION") { this.lblUnidadDeMedida.Text = "ML"; }
                    if (this.txtPresentacion.Text == "OVULOS") { this.lblUnidadDeMedida.Text = "OVULOS"; }
                    if (this.txtPresentacion.Text == "PARCHE") { this.lblUnidadDeMedida.Text = "PARCHES"; }
                    if (this.txtPresentacion.Text == "POLVO") { this.lblUnidadDeMedida.Text = "GR"; }
                    if (this.txtPresentacion.Text == "POMADA") { this.lblUnidadDeMedida.Text = "APLICACIONES"; }
                    if (this.txtPresentacion.Text == "SACHET") { this.lblUnidadDeMedida.Text = "ML"; }
                    if (this.txtPresentacion.Text == "SHAMPOO") { this.lblUnidadDeMedida.Text = "APLICACIONES"; }
                    if (this.txtPresentacion.Text == "SOBRES") { this.lblUnidadDeMedida.Text = "UNIDADES"; }
                    if (this.txtPresentacion.Text == "SOLUCION") { this.lblUnidadDeMedida.Text = "GOTAS"; }
                    if (this.txtPresentacion.Text == "SPRAY") { this.lblUnidadDeMedida.Text = "PUFF"; }
                    if (this.txtPresentacion.Text == "SUPOSITORIO") { this.lblUnidadDeMedida.Text = "UNIDADES"; }
                    if (this.txtPresentacion.Text == "SUSPENSION") { this.lblUnidadDeMedida.Text = "ML"; }
                    if (this.txtPresentacion.Text == "TIRAS") { this.lblUnidadDeMedida.Text = "TIRAS"; }
                    if (this.txtPresentacion.Text == "UI 5000") { this.lblUnidadDeMedida.Text = "UI"; }
                    if (this.txtPresentacion.Text == "UNGUENTO") { this.lblUnidadDeMedida.Text = "APLICACIONES"; }
                    if (this.txtPresentacion.Text == "UNIDAD") { this.lblUnidadDeMedida.Text = "UNIDADES"; }

                    chckL.Checked = true;
                    chckM.Checked = true;
                    chckX.Checked = true;
                    chckJ.Checked = true;
                    chckV.Checked = true;
                    chckS.Checked = true;
                    chckD.Checked = true;

                    radioIndeterminado.Checked = true;                    
                }

                dtpLapsoHasta.MinDate = dtpInicio.Value; //La fecha de finalizacion no puede ser menor a la de inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------------------------------------------------------------------------------------- RADIO BUTTON
        // Poseen la tabla IND_HorarioDeSuministro asociada. 
        private void radioHorarioFijo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHorarioFijo.Checked)
            {
                panelFijo.Visible = true;
                panelTurno.Visible = false;
                panelEvento.Visible = false;
                panelIntervalo.Visible = false;
                panelComida.Visible = false;
                panelOtro.Visible = false;
            }
        } // Horarios fijos = 1
        private void radioTurno_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTurno.Checked)
            {
                panelFijo.Visible = false;
                panelTurno.Visible = true;
                panelEvento.Visible = false;
                panelIntervalo.Visible = false;
                panelComida.Visible = false;
                panelOtro.Visible = false;
            }
        } // Turnos = 2
        private void radioAnteUnEvento_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAnteUnEvento.Checked)
            {
                panelFijo.Visible = false;
                panelTurno.Visible = false;
                panelEvento.Visible = true;
                panelIntervalo.Visible = false;
                panelComida.Visible = false;
                panelOtro.Visible = false;
            }
        } // Ante Un Evento = 3
        private void radioIntervaloDeTiempo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIntervaloDeTiempo.Checked)
            {
                panelFijo.Visible = false;
                panelTurno.Visible = false;
                panelEvento.Visible = false;
                panelIntervalo.Visible = true;
                panelComida.Visible = false;
                panelOtro.Visible = false;
            }
        } // Intervalos De Tiempo = 4
        private void radioHorarioDeComida_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHorarioDeComida.Checked)
            {
                panelFijo.Visible = false;
                panelTurno.Visible = false;
                panelEvento.Visible = false;
                panelIntervalo.Visible = false;
                panelComida.Visible = true;
                panelOtro.Visible = false;
            }
        } // Horarios De Comidas = 5
        private void radioOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOtro.Checked)
            {
                panelFijo.Visible = false;
                panelTurno.Visible = false;
                panelEvento.Visible = false;
                panelIntervalo.Visible = false;
                panelComida.Visible = false;
                panelOtro.Visible = true;
            }
        } // Otros = 6
        private void radioSin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSin.Checked)
            {
                radioCon.Checked = false;
                this.txtEvento.Enabled = true;
            }
        }
        private void radioCon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCon.Checked)
            {
                radioSin.Checked = false;
                this.txtEvento.Enabled = true;
            }
        }
        // ******************************* VALIDACIONES
        private void checkDeterminarlapsoDeTiempo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDeterminarLapsoDeTiempo.Checked)
            {
                dtpLapsoHasta.Enabled = true;
            }
            else
            {
                dtpLapsoHasta.Enabled = false;
            }
        }
        private void checkViaOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkViaTieneOtro.Checked)
            {
                this.cboVia.Enabled = false;
                this.txtViaOtro.Enabled = true;
                this.txtMl.Text = string.Empty;
                this.cboVia.SelectedValue = 6; // Otro
                CargarCboDiluyente();
                CargarCboDurante();
                CargaCboPeriodo();
            }
            else
            {
                CargarCboVia(medicamento_id, inactivo);
                CargarCboDiluyente();
                CargarCboDurante();
                CargaCboPeriodo();
                this.cboVia.Enabled = true;
                this.txtViaOtro.Enabled = false;
                this.txtViaOtro.Text = string.Empty;
            }
        }
        private void txtDosis_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)44 || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtMl_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)46 || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void cboVia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.cboVia.Text == "ENDOVENOSA") // Tabla MED_Via via_id = 6 descripocion = Otra
            {
                checkViaEndovenosa.Visible = true;
                if(checkViaEndovenosa.Checked)
                {
                    CargarCboViasEndovenosa();
                }               
                cboTipoVia.Visible = true;             
                this.cboDiluyente.Enabled = true;
                this.txtMl.Enabled = true;
                this.cboDurante.Enabled = true;
                this.cboPeriodo.Enabled = true;
                radioOtro.Checked = true;
            }
            else
            {
                this.cboDiluyente.Enabled = false;
                this.txtMl.Enabled = false;
                this.cboDurante.Enabled = false;
                this.cboPeriodo.Enabled = false;
                cboTipoVia.Visible = false;
                checkViaEndovenosa.Visible = false;
                radioHorarioFijo.Checked = true;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------- COMBOS
        private void CargarCboVia(string medicamento_id, bool inactivo)
        {
            try
            {
                BLL.Procedures.MED_GET_MEDICAMENTO_VIA _via = new BLL.Procedures.MED_GET_MEDICAMENTO_VIA();
                Entities.Procedures.MED_GET_MEDICAMENTO_VIA _itemSeleccion = new Entities.Procedures.MED_GET_MEDICAMENTO_VIA();
                List<Entities.Procedures.MED_GET_MEDICAMENTO_VIA> _ItemsVia = new List<Entities.Procedures.MED_GET_MEDICAMENTO_VIA>();
                //Limpia el combo
                this.cboVia.SuspendLayout();
                this.cboVia.DataSource = null;
                this.cboVia.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.via_id = 0;
                _ItemsVia = _via.ItemList(medicamento_id, inactivo); 
                _ItemsVia.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboVia.DisplayMember = BLL.Procedures.MED_GET_VIA.ColumnNames.DESCRIPCION;
                this.cboVia.ValueMember = BLL.Procedures.MED_GET_VIA.ColumnNames.VIA_ID;
                this.cboVia.DataSource = _ItemsVia;
                this.cboVia.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCboViasEndovenosa()
        {
            SISTMEDEntities E = new SISTMEDEntities();
            cboTipoVia.DataSource = E.MED_Via_Endovenosa.ToList();
            cboTipoVia.ValueMember = "via_id";
            cboTipoVia.DisplayMember = "descripcionVia";
            cboTipoVia.ResumeLayout();
        }

        private void CargarCboDiluyente()
        {
            try
            {
                BLL.Tables.MED_DILUYENTE _os = new BLL.Tables.MED_DILUYENTE();
                Entities.Tables.MED_DILUYENTE _itemSeleccion = new Entities.Tables.MED_DILUYENTE();
                List<Entities.Tables.MED_DILUYENTE> _ItemsOS = new List<Entities.Tables.MED_DILUYENTE>();
                //Limpia el combo
                this.cboDiluyente.SuspendLayout();
                this.cboDiluyente.DataSource = null;
                this.cboDiluyente.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.DILUYENTE_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiluyente.DisplayMember = BLL.Tables.MED_DILUYENTE.ColumnNames.DESCRIPCION;
                this.cboDiluyente.ValueMember = BLL.Tables.MED_DILUYENTE.ColumnNames.DILUYENTE_ID;
                this.cboDiluyente.DataSource = _ItemsOS;
                this.cboDiluyente.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDurante()
        {
            try
            {
                BLL.Tables.MED_NUMERO _os = new BLL.Tables.MED_NUMERO();
                Entities.Tables.MED_NUMERO _itemSeleccion = new Entities.Tables.MED_NUMERO();
                List<Entities.Tables.MED_NUMERO> _ItemsOS = new List<Entities.Tables.MED_NUMERO>();
                //Limpia el combo
                this.cboDurante.SuspendLayout();
                this.cboDurante.DataSource = null;
                this.cboDurante.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.NUMERO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDurante.DisplayMember = BLL.Tables.MED_NUMERO.ColumnNames.DESCRIPCION;
                this.cboDurante.ValueMember = BLL.Tables.MED_NUMERO.ColumnNames.NUMERO_ID;
                this.cboDurante.DataSource = _ItemsOS;
                this.cboDurante.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargaCboPeriodo()
        {
            try
            {
                BLL.Tables.MED_PERIODO _os = new BLL.Tables.MED_PERIODO();
                Entities.Tables.MED_PERIODO _itemSeleccion = new Entities.Tables.MED_PERIODO();
                List<Entities.Tables.MED_PERIODO> _ItemsOS = new List<Entities.Tables.MED_PERIODO>();
                //Limpia el combo
                this.cboPeriodo.SuspendLayout();
                this.cboPeriodo.DataSource = null;
                this.cboPeriodo.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.PERIODO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboPeriodo.DisplayMember = BLL.Tables.MED_PERIODO.ColumnNames.DESCRIPCION;
                this.cboPeriodo.ValueMember = BLL.Tables.MED_PERIODO.ColumnNames.PERIODO_ID;
                this.cboPeriodo.DataSource = _ItemsOS;
                this.cboPeriodo.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDuranteInternacion()
        {
            try
            {
                BLL.Tables.MED_NUMERO _os = new BLL.Tables.MED_NUMERO();
                Entities.Tables.MED_NUMERO _itemSeleccion = new Entities.Tables.MED_NUMERO();
                List<Entities.Tables.MED_NUMERO> _ItemsOS = new List<Entities.Tables.MED_NUMERO>();
                //Limpia el combo
                this.cboDuranteIntervalo.SuspendLayout();
                this.cboDuranteIntervalo.DataSource = null;
                this.cboDuranteIntervalo.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.NUMERO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDuranteIntervalo.DisplayMember = BLL.Tables.MED_NUMERO.ColumnNames.DESCRIPCION;
                this.cboDuranteIntervalo.ValueMember = BLL.Tables.MED_NUMERO.ColumnNames.NUMERO_ID;
                this.cboDuranteIntervalo.DataSource = _ItemsOS;
                this.cboDuranteIntervalo.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargaCboPeriodoInternacion()
        {
            try
            {
                BLL.Tables.MED_PERIODO _os = new BLL.Tables.MED_PERIODO();
                Entities.Tables.MED_PERIODO _itemSeleccion = new Entities.Tables.MED_PERIODO();
                List<Entities.Tables.MED_PERIODO> _ItemsOS = new List<Entities.Tables.MED_PERIODO>();
                //Limpia el combo
                this.cboPeriodoIntervalo.SuspendLayout();
                this.cboPeriodoIntervalo.DataSource = null;
                this.cboPeriodoIntervalo.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.PERIODO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboPeriodoIntervalo.DisplayMember = BLL.Tables.MED_PERIODO.ColumnNames.DESCRIPCION;
                this.cboPeriodoIntervalo.ValueMember = BLL.Tables.MED_PERIODO.ColumnNames.PERIODO_ID;
                this.cboPeriodoIntervalo.DataSource = _ItemsOS;
                this.cboPeriodoIntervalo.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------------------------------------------------------------------------------------- BOTONES
        private void btnModificar_Click(object sender, EventArgs e)
        {
           

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Limpiar();
            Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        #region Metodos

        //--------------------------------------------------------------------------------------------------------------------- GRABA SUMINISTRO
        //private void GrabaSuministro(object paciente_id, object medicamento_id)
        //{
        //    try
        //    {    
        //        // ******************************* TABLA SUMINISTRO DE SUMINISTRO DE MEDICACIÓN
        //        Entities.Tables.MED_SUMINISTRODEMEDICACION _item = new Entities.Tables.MED_SUMINISTRODEMEDICACION();
        //        BLL.Tables.MED_SUMINISTRODEMEDICACION _suministroDeMedicacion = new BLL.Tables.MED_SUMINISTRODEMEDICACION();
        //        CultureInfo culture = new CultureInfo("en-US");
        //        // Seteo Datos
        //        _item.FECHAALTASISTEMA = System.DateTime.Now;
        //        _item.PACIENTE_ID = this.paciente_id;
        //        _item.MEDICAMENTO_ID = this.medicamento_id;
        //        _item.FECHAINICIO = this.dtpInicio.Value;
        //        if (this.txtDosis.Text == string.Empty) { _item.DOSIS = 0; } else { _item.DOSIS = Convert.ToDecimal(this.txtDosis.Text,culture); }
        //        // Cambia el varchar que recupera con el stored _IND_GetSuministroMedicacion por el int correspondiente de la tabla IND_Presentacion e inserta la unidad de medida correspondiente tabla IND_UnidadDeMedida 
        //        if (this.txtPresentacion.Text == "AEROSOL") { _item.PRESENTACION_ID = 1; _item.UNIDADDEMEDIDA_ID = 2; } // 2 Aplicaciones
        //        if (this.txtPresentacion.Text == "AMPOLLA") { _item.PRESENTACION_ID = 2; _item.UNIDADDEMEDIDA_ID = 1; } // Ampollas
        //        if (this.txtPresentacion.Text == "BOTELLA") { _item.PRESENTACION_ID = 3; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
        //        if (this.txtPresentacion.Text == "CAPSULAS") { _item.PRESENTACION_ID = 4; _item.UNIDADDEMEDIDA_ID = 3; } // Capsula
        //        if (this.txtPresentacion.Text == "COMPRIMIDO") { _item.PRESENTACION_ID = 5; _item.UNIDADDEMEDIDA_ID = 4; } // Comprimidos
        //        if (this.txtPresentacion.Text == "CREMA") { _item.PRESENTACION_ID = 6; _item.UNIDADDEMEDIDA_ID = 2; } // Aplicaciones
        //        if (this.txtPresentacion.Text == "DOSIS") { _item.PRESENTACION_ID = 7; _item.UNIDADDEMEDIDA_ID = 5; } // Dosis
        //        if (this.txtPresentacion.Text == "ELIXIR") { _item.PRESENTACION_ID = 8; _item.UNIDADDEMEDIDA_ID = 0; } // (sin valor)
        //        if (this.txtPresentacion.Text == "EMULSION") { _item.PRESENTACION_ID = 9; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
        //        if (this.txtPresentacion.Text == "FRASCO") { _item.PRESENTACION_ID = 10; _item.UNIDADDEMEDIDA_ID = 10; } // Kg
        //        if (this.txtPresentacion.Text == "FRASCO/AMPOLLA") { _item.PRESENTACION_ID = 11; _item.UNIDADDEMEDIDA_ID = 6; } // Fras/Ampolla
        //        if (this.txtPresentacion.Text == "GEL") { _item.PRESENTACION_ID = 12; _item.UNIDADDEMEDIDA_ID = 2; } // Aplicaciones
        //        if (this.txtPresentacion.Text == "GOTAS") { _item.PRESENTACION_ID = 13; _item.UNIDADDEMEDIDA_ID = 7; } // Gotas
        //        if (this.txtPresentacion.Text == "GRAGEAS") { _item.PRESENTACION_ID = 14; _item.UNIDADDEMEDIDA_ID = 9; } // Grageas
        //        if (this.txtPresentacion.Text == "JALEA") { _item.PRESENTACION_ID = 15; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
        //        if (this.txtPresentacion.Text == "JARABE") { _item.PRESENTACION_ID = 16; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
        //        if (this.txtPresentacion.Text == "JERINGA PRELLEN") { _item.PRESENTACION_ID = 17; _item.UNIDADDEMEDIDA_ID = 17; } // Unidades
        //        if (this.txtPresentacion.Text == "JERINGA/CARTUCH") { _item.PRESENTACION_ID = 18; _item.UNIDADDEMEDIDA_ID = 17; } //Unidades
        //        if (this.txtPresentacion.Text == "LACA") { _item.PRESENTACION_ID = 19; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
        //        if (this.txtPresentacion.Text == "LAPICERA") { _item.PRESENTACION_ID = 20; _item.UNIDADDEMEDIDA_ID = 0; } // (sin valor)
        //        if (this.txtPresentacion.Text == "LAPIZ") { _item.PRESENTACION_ID = 21; _item.UNIDADDEMEDIDA_ID = 0; } // (sin valor)
        //        if (this.txtPresentacion.Text == "LIQUIDO") { _item.PRESENTACION_ID = 22; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
        //        if (this.txtPresentacion.Text == "LOCION") { _item.PRESENTACION_ID = 23; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
        //        if (this.txtPresentacion.Text == "OVULOS") { _item.PRESENTACION_ID = 24; _item.UNIDADDEMEDIDA_ID = 12; } //
        //        if (this.txtPresentacion.Text == "PARCHE") { _item.PRESENTACION_ID = 25; _item.UNIDADDEMEDIDA_ID = 13; } // Parche
        //        if (this.txtPresentacion.Text == "POLVO") { _item.PRESENTACION_ID = 26; _item.UNIDADDEMEDIDA_ID = 8; } // Gr
        //        if (this.txtPresentacion.Text == "POMADA") { _item.PRESENTACION_ID = 27; _item.UNIDADDEMEDIDA_ID = 2; } // Aplicaciones
        //        if (this.txtPresentacion.Text == "SACHET") { _item.PRESENTACION_ID = 28; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
        //        if (this.txtPresentacion.Text == "SHAMPOO") { _item.PRESENTACION_ID = 29; _item.UNIDADDEMEDIDA_ID = 2; } // Aplicaciones
        //        if (this.txtPresentacion.Text == "SOBRES") { _item.PRESENTACION_ID = 30; _item.UNIDADDEMEDIDA_ID = 17; } // Unidades
        //        if (this.txtPresentacion.Text == "SOLUCION") { _item.PRESENTACION_ID = 31; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
        //        if (this.txtPresentacion.Text == "SPRAY") { _item.PRESENTACION_ID = 32; _item.UNIDADDEMEDIDA_ID = 14; } // Puff
        //        if (this.txtPresentacion.Text == "SUPOSITORIO") { _item.PRESENTACION_ID = 33; _item.UNIDADDEMEDIDA_ID = 17; } // Unidades
        //        if (this.txtPresentacion.Text == "SUSPENSION") { _item.PRESENTACION_ID = 34; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
        //        if (this.txtPresentacion.Text == "TIRAS") { _item.PRESENTACION_ID = 35; _item.UNIDADDEMEDIDA_ID = 15; } // Tiras
        //        if (this.txtPresentacion.Text == "UI 5000") { _item.PRESENTACION_ID = 36; _item.UNIDADDEMEDIDA_ID = 16; } // UI
        //        if (this.txtPresentacion.Text == "UNGUENTO") { _item.PRESENTACION_ID = 37; _item.UNIDADDEMEDIDA_ID = 2; } // Aplicaciones
        //        if (this.txtPresentacion.Text == "UNIDAD") { _item.PRESENTACION_ID = 38; _item.UNIDADDEMEDIDA_ID = 17; } // Unidades
        //        _item.POTENCIA = this.lblPotencia.Text;
        //        if (checkViaTieneOtro.Checked) { _item.VIA_ID = 3; _item.VIATIENEOTRO = true; } else { _item.VIA_ID = Convert.ToInt32(this.cboVia.SelectedValue); _item.VIATIENEOTRO = false; } // 3 es Otro en la tabla IND_Via
        //        _item.VIAOTRO = this.txtViaOtro.Text;
        //        _item.DILUYENTE_ID = Convert.ToInt32(this.cboDiluyente.SelectedValue);
        //        if (this.txtMl.Text == string.Empty) { _item.ML = 0; } else { _item.ML = Convert.ToDecimal(this.txtMl.Text); }
        //        _item.DURANTE_ID = Convert.ToInt32(this.cboDurante.SelectedValue);
        //        _item.PERIODO_ID = Convert.ToInt32(this.cboPeriodo.SelectedValue);
        //        if (this.radioHorarioFijo.Checked) { _item.HORARIODESUMINISTRO_ID = 1; }
        //        if (this.radioTurno.Checked) { _item.HORARIODESUMINISTRO_ID = 2; }
        //        if (this.radioAnteUnEvento.Checked) { _item.HORARIODESUMINISTRO_ID = 3; }
        //        if (this.radioIntervaloDeTiempo.Checked) { _item.HORARIODESUMINISTRO_ID = 4; }
        //        if (this.radioHorarioDeComida.Checked) { _item.HORARIODESUMINISTRO_ID = 5; }
        //        if (this.radioOtro.Checked) { _item.HORARIODESUMINISTRO_ID = 6; }
        //        // Evaluo si modifica
        //        if (this.txtSuspenderMotivo.Text != String.Empty)
        //        {
        //            _item.FECHABAJA = System.DateTime.Now;
        //            _item.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
        //        }
        //        if (this.checkDeterminarLapsoDeTiempo.Checked)
        //        {
        //            _item.LAPSODETIEMPO = true;
        //            _item.LAPSODETIEMPOHASTA = this.dtpLapsoHasta.Value;
        //            _item.FECHABAJA = this.dtpLapsoHasta.Value;
        //        }
        //        else
        //        {
        //            _item.LAPSODETIEMPO = false;
        //            _item.LAPSODETIEMPOHASTA = System.DateTime.MinValue;
        //        }
        //        _item.OBSERVACION = this.txtObservacion.Text;
        //        _item.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;


        //        if (_item.HORARIODESUMINISTRO_ID == 1) //Guarda Horario Fijo
        //        {                    
        //            if (this.check08.Checked) { _item.HS_08 = true; } else { _item.HS_08 = false; }
        //            if (this.check09.Checked) { _item.HS_09 = true; } else { _item.HS_09 = false; }
        //            if (this.check10.Checked) { _item.HS_10 = true; } else { _item.HS_10 = false; }
        //            if (this.check11.Checked) { _item.HS_11 = true; } else { _item.HS_11 = false; }
        //            if (this.check12.Checked) { _item.HS_12 = true; } else { _item.HS_12 = false; }
        //            if (this.check13.Checked) { _item.HS_13 = true; } else { _item.HS_13 = false; }
        //            if (this.check14.Checked) { _item.HS_14 = true; } else { _item.HS_14 = false; }
        //            if (this.check15.Checked) { _item.HS_15 = true; } else { _item.HS_15 = false; }
        //            if (this.check16.Checked) { _item.HS_16 = true; } else { _item.HS_16 = false; }
        //            if (this.check17.Checked) { _item.HS_17 = true; } else { _item.HS_17 = false; }
        //            if (this.check18.Checked) { _item.HS_18 = true; } else { _item.HS_18 = false; }
        //            if (this.check19.Checked) { _item.HS_19 = true; } else { _item.HS_19 = false; }
        //            if (this.check20.Checked) { _item.HS_20 = true; } else { _item.HS_20 = false; }
        //            if (this.check21.Checked) { _item.HS_21 = true; } else { _item.HS_21 = false; }
        //            if (this.check22.Checked) { _item.HS_22 = true; } else { _item.HS_22 = false; }
        //            if (this.check23.Checked) { _item.HS_23 = true; } else { _item.HS_23 = false; }
        //            if (this.check24.Checked) { _item.HS_24 = true; } else { _item.HS_24 = false; }
        //            if (this.check01.Checked) { _item.HS_01 = true; } else { _item.HS_01 = false; }
        //            if (this.check02.Checked) { _item.HS_02 = true; } else { _item.HS_02 = false; }
        //            if (this.check03.Checked) { _item.HS_03 = true; } else { _item.HS_03 = false; }
        //            if (this.check04.Checked) { _item.HS_04 = true; } else { _item.HS_04 = false; }
        //            if (this.check05.Checked) { _item.HS_05 = true; } else { _item.HS_05 = false; }
        //            if (this.check06.Checked) { _item.HS_06 = true; } else { _item.HS_06 = false; }
        //            if (this.check07.Checked) { _item.HS_07 = true; } else { _item.HS_07 = false; }
        //        }
                
        //        if (_item.HORARIODESUMINISTRO_ID == 2) //Guarda Turnos
        //        {
        //           if(this.checkManiana.Checked) { _item.HS_09 = true; } else { _item.HS_09 = false; }
        //           if (this.checkTarde.Checked) { _item.HS_16 = true; } else { _item.HS_16 = false; }
        //           if (this.checkNoche.Checked) { _item.HS_21 = true; } else { _item.HS_21 = false; }
        //        }

        //        if (_item.HORARIODESUMINISTRO_ID == 3)//Evento
        //        {
        //            _item.EVENTO = this.txtEvento.Text;
        //            _item.HS_SH = true;
        //            if (radioCon.Checked)
        //            {
        //                _item.HORARIOEVENTO = "C";
        //            }
        //            if (radioSin.Checked)
        //            {
        //                _item.HORARIOEVENTO = "S";
        //            }                 
        //        }

        //        if (_item.HORARIODESUMINISTRO_ID == 5) // Horario Comidas
        //        {
        //            if (this.checkDesayuno.Checked) { _item.HS_08 = true; } else { _item.HS_08 = false; }
        //            if (this.checkAlmuerzo.Checked) { _item.HS_12 = true; } else { _item.HS_12 = false; }
        //            if (this.checkMerienda.Checked) { _item.HS_16 = true; } else { _item.HS_16 = false; }
        //            if (this.checkCena.Checked) { _item.HS_21 = true; } else { _item.HS_21 = false; }
        //        }

        //        if (_item.HORARIODESUMINISTRO_ID == 5)//Otro
        //        {
        //            _item.HORARIOOTRO = this.txtHorarioObservacion.Text;
        //            _item.HS_SH = true;
        //        }
        //        _item.L = chckL.Checked ? true : false;
        //        _item.M = chckM.Checked ? true : false;
        //        _item.X = chckX.Checked ? true : false;
        //        _item.J = chckJ.Checked ? true : false;
        //        _item.V = chckV.Checked ? true : false;
        //        _item.S = chckS.Checked ? true : false;
        //        _item.D = chckD.Checked ? true : false;
        //        // Graba Datos En Ambas Tablas
        //        Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION _item2 = new Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION();
        //        BLL.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION _suministroDeMedicacion2 = new BLL.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION();
        //        _item2.FECHAALTASISTEMA = _item.FECHAALTASISTEMA;
        //        _item2.DOSIS = _item.DOSIS;
        //        _item2.PACIENTE_ID = _item.PACIENTE_ID;
        //        _item2.MEDICAMENTO_ID = _item.MEDICAMENTO_ID;
        //        _item2.FECHAINICIO = _item.FECHAINICIO;
        //        _item2.PRESENTACION_ID = _item.PRESENTACION_ID;
        //        _item2.UNIDADDEMEDIDA_ID = Convert.ToInt32(_item.UNIDADDEMEDIDA_ID); //Generar Objetos No ser Villero
        //        _item2.POTENCIA = _item.POTENCIA;
        //        _item2.VIA_ID = _item.VIA_ID;
        //        _item2.VIATIENEOTRO = _item.VIATIENEOTRO;
        //        _item2.VIAOTRO = _item.VIAOTRO;
        //        _item2.DILUYENTE_ID = _item.DILUYENTE_ID;
        //        _item2.DURANTE_ID = _item.DURANTE_ID;
        //        _item2.PERIODO_ID = _item.PERIODO_ID;
        //        _item2.HORARIODESUMINISTRO_ID = _item.HORARIODESUMINISTRO_ID;
        //        _item2.HS_08 = _item.HS_08;
        //        _item2.HS_09 = _item.HS_09;
        //        _item2.HS_10 = _item.HS_10;
        //        _item2.HS_11 = _item.HS_11;
        //        _item2.HS_12 = _item.HS_12;
        //        _item2.HS_13 = _item.HS_13;
        //        _item2.HS_14 = _item.HS_14;
        //        _item2.HS_15 = _item.HS_15;
        //        _item2.HS_16 = _item.HS_16;
        //        _item2.HS_17 = _item.HS_17;
        //        _item2.HS_18 = _item.HS_18;
        //        _item2.HS_19 = _item.HS_19;
        //        _item2.HS_20 = _item.HS_20;
        //        _item2.HS_21 = _item.HS_21;
        //        _item2.HS_22 = _item.HS_22;
        //        _item2.HS_23 = _item.HS_23;
        //        _item2.HS_24 = _item.HS_24;
        //        _item2.HS_01 = _item.HS_01;
        //        _item2.HS_02 = _item.HS_02;
        //        _item2.HS_03 = _item.HS_03;
        //        _item2.HS_04 = _item.HS_04;
        //        _item2.HS_05 = _item.HS_05;
        //        _item2.HS_06 = _item.HS_06;
        //        _item2.HS_07 = _item.HS_07;
        //        _item2.L = _item.L;
        //        _item2.M = _item.M;
        //        _item2.X = _item.X;
        //        _item2.J = _item.J;
        //        _item2.V = _item.V;
        //        _item2.S = _item.S;
        //        _item2.D = _item.D;
        //        _item2.LAPSODETIEMPO = _item.LAPSODETIEMPO;
        //        _item2.LAPSODETIEMPOHASTA = _item.LAPSODETIEMPOHASTA;
        //        _item2.OBSERVACION = _item.OBSERVACION;
        //        _item2.USUARIO_ID = _item.USUARIO_ID;
        //        _item2.FECHABAJA = _item.FECHABAJA;
        //        _item2.MOTIVOBAJA = _item.MOTIVOBAJA;
        //        _suministroDeMedicacion.AltaSuministroDeMedicacion(_item, _item2);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //--------------------------------------------------------------------------------------------------------------------- GRABA HISTORIAL SUMINISTRO
        private void GrabaHistorialSuministro(object paciente_id, object medicamento_id)
        {
            try
            {
                // ******************************* TABLA SUMINISTRO DE SUMINISTRO DE MEDICACIÓN
                Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION _item = new Entities.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION();
                BLL.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION _suministroDeMedicacion = new BLL.Tables.MED_HISTORIAL_SUMINISTRODEMEDICACION();
                CultureInfo culture = new CultureInfo("en-US");
                // Seteo Datos
                _item.FECHAALTASISTEMA = System.DateTime.Now;
                _item.PACIENTE_ID = this.paciente_id;
                _item.MEDICAMENTO_ID = this.medicamento_id;
                _item.FECHAINICIO = this.dtpInicio.Value;
                if (this.txtDosis.Text == string.Empty) { _item.DOSIS = 0; } else { _item.DOSIS = Convert.ToDecimal(this.txtDosis.Text.Replace(",","."),culture); }
                // Cambia el varchar que recupera con el stored _IND_GetSuministroMedicacion por el int correspondiente de la tabla IND_Presentacion e inserta la unidad de medida correspondiente tabla IND_UnidadDeMedida 
                if (this.txtPresentacion.Text == "AEROSOL") { _item.PRESENTACION_ID = 1; _item.UNIDADDEMEDIDA_ID = 2; } // 2 Aplicaciones
                if (this.txtPresentacion.Text == "AMPOLLA") { _item.PRESENTACION_ID = 2; _item.UNIDADDEMEDIDA_ID = 1; } // Ampollas
                if (this.txtPresentacion.Text == "BOTELLA") { _item.PRESENTACION_ID = 3; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
                if (this.txtPresentacion.Text == "CAPSULAS") { _item.PRESENTACION_ID = 4; _item.UNIDADDEMEDIDA_ID = 3; } // Capsula
                if (this.txtPresentacion.Text == "COMPRIMIDO") { _item.PRESENTACION_ID = 5; _item.UNIDADDEMEDIDA_ID = 4; } // Comprimidos
                if (this.txtPresentacion.Text == "CREMA") { _item.PRESENTACION_ID = 6; _item.UNIDADDEMEDIDA_ID = 8; } // Gr
                if (this.txtPresentacion.Text == "DOSIS") { _item.PRESENTACION_ID = 7; _item.UNIDADDEMEDIDA_ID = 5; } // Dosis
                if (this.txtPresentacion.Text == "ELIXIR") { _item.PRESENTACION_ID = 8; _item.UNIDADDEMEDIDA_ID = 0; } // (sin valor)
                if (this.txtPresentacion.Text == "EMULSION") { _item.PRESENTACION_ID = 9; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
                if (this.txtPresentacion.Text == "FRASCO") { _item.PRESENTACION_ID = 10; _item.UNIDADDEMEDIDA_ID = 10; } // Kg
                if (this.txtPresentacion.Text == "FRASCO/AMPOLLA") { _item.PRESENTACION_ID = 11; _item.UNIDADDEMEDIDA_ID = 6; } // Fras/Ampolla
                if (this.txtPresentacion.Text == "GEL") { _item.PRESENTACION_ID = 12; _item.UNIDADDEMEDIDA_ID = 8; } // Gr
                if (this.txtPresentacion.Text == "GOTAS") { _item.PRESENTACION_ID = 13; _item.UNIDADDEMEDIDA_ID = 7; } // Gotas
                if (this.txtPresentacion.Text == "GRAGEAS") { _item.PRESENTACION_ID = 14; _item.UNIDADDEMEDIDA_ID = 9; } // Grageas
                if (this.txtPresentacion.Text == "JALEA") { _item.PRESENTACION_ID = 15; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
                if (this.txtPresentacion.Text == "JARABE") { _item.PRESENTACION_ID = 16; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
                if (this.txtPresentacion.Text == "JERINGA PRELLEN") { _item.PRESENTACION_ID = 17; _item.UNIDADDEMEDIDA_ID = 17; } // Unidades
                if (this.txtPresentacion.Text == "JERINGA/CARTUCH") { _item.PRESENTACION_ID = 18; _item.UNIDADDEMEDIDA_ID = 17; } //Unidades
                if (this.txtPresentacion.Text == "LACA") { _item.PRESENTACION_ID = 19; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
                if (this.txtPresentacion.Text == "LAPICERA") { _item.PRESENTACION_ID = 20; _item.UNIDADDEMEDIDA_ID = 0; } // (sin valor)
                if (this.txtPresentacion.Text == "LAPIZ") { _item.PRESENTACION_ID = 21; _item.UNIDADDEMEDIDA_ID = 0; } // (sin valor)
                if (this.txtPresentacion.Text == "LIQUIDO") { _item.PRESENTACION_ID = 22; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
                if (this.txtPresentacion.Text == "LOCION") { _item.PRESENTACION_ID = 23; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
                if (this.txtPresentacion.Text == "OVULOS") { _item.PRESENTACION_ID = 24; _item.UNIDADDEMEDIDA_ID = 12; } //
                if (this.txtPresentacion.Text == "PARCHE") { _item.PRESENTACION_ID = 25; _item.UNIDADDEMEDIDA_ID = 13; } // Parche
                if (this.txtPresentacion.Text == "POLVO") { _item.PRESENTACION_ID = 26; _item.UNIDADDEMEDIDA_ID = 8; } // Gr
                if (this.txtPresentacion.Text == "POMADA") { _item.PRESENTACION_ID = 27; _item.UNIDADDEMEDIDA_ID = 8; } // Gr
                if (this.txtPresentacion.Text == "SACHET") { _item.PRESENTACION_ID = 28; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
                if (this.txtPresentacion.Text == "SHAMPOO") { _item.PRESENTACION_ID = 29; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
                if (this.txtPresentacion.Text == "SOBRES") { _item.PRESENTACION_ID = 30; _item.UNIDADDEMEDIDA_ID = 17; } // Unidades
                if (this.txtPresentacion.Text == "SOLUCION") { _item.PRESENTACION_ID = 31; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
                if (this.txtPresentacion.Text == "SPRAY") { _item.PRESENTACION_ID = 32; _item.UNIDADDEMEDIDA_ID = 14; } // Puff
                if (this.txtPresentacion.Text == "SUPOSITORIO") { _item.PRESENTACION_ID = 33; _item.UNIDADDEMEDIDA_ID = 17; } // Unidades
                if (this.txtPresentacion.Text == "SUSPENSION") { _item.PRESENTACION_ID = 34; _item.UNIDADDEMEDIDA_ID = 11; } // Ml
                if (this.txtPresentacion.Text == "TIRAS") { _item.PRESENTACION_ID = 35; _item.UNIDADDEMEDIDA_ID = 15; } // Tiras
                if (this.txtPresentacion.Text == "UI 5000") { _item.PRESENTACION_ID = 36; _item.UNIDADDEMEDIDA_ID = 16; } // UI
                if (this.txtPresentacion.Text == "UNGUENTO") { _item.PRESENTACION_ID = 37; _item.UNIDADDEMEDIDA_ID = 8; } // Gr
                if (this.txtPresentacion.Text == "UNIDAD") { _item.PRESENTACION_ID = 38; _item.UNIDADDEMEDIDA_ID = 17; } // Unidades
                _item.POTENCIA = this.lblPotencia.Text;
                if (checkViaTieneOtro.Checked) { _item.VIA_ID = 3; _item.VIATIENEOTRO = true; } else { _item.VIA_ID = Convert.ToInt32(this.cboVia.SelectedValue); _item.VIATIENEOTRO = false; } // 3 es Otro en la tabla IND_Via
                _item.VIAOTRO = this.txtViaOtro.Text;
                _item.DILUYENTE_ID = Convert.ToInt32(this.cboDiluyente.SelectedValue);
                if (this.txtMl.Text == string.Empty) { _item.ML = 0; } else { _item.ML = Convert.ToDecimal(this.txtMl.Text.Replace(",","."),culture); }
                _item.DURANTE_ID = Convert.ToInt32(this.cboDurante.SelectedValue);
                _item.PERIODO_ID = Convert.ToInt32(this.cboPeriodo.SelectedValue);
                if (this.radioHorarioFijo.Checked) { _item.HORARIODESUMINISTRO_ID = 1; }
                if (this.radioTurno.Checked) { _item.HORARIODESUMINISTRO_ID = 2; }
                if (this.radioAnteUnEvento.Checked) { _item.HORARIODESUMINISTRO_ID = 3; }
                if (this.radioIntervaloDeTiempo.Checked) { _item.HORARIODESUMINISTRO_ID = 4; }
                if (this.radioHorarioDeComida.Checked) { _item.HORARIODESUMINISTRO_ID = 5; }
                if (this.radioOtro.Checked) { _item.HORARIODESUMINISTRO_ID = 6; }
                // Evaluo si modifica
                if (this.txtSuspenderMotivo.Text != String.Empty)
                {
                    _item.FECHABAJA = System.DateTime.Now;
                    _item.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                }
                if (this.checkDeterminarLapsoDeTiempo.Checked)
                {
                    _item.LAPSODETIEMPO = true;
                    _item.LAPSODETIEMPOHASTA = this.dtpLapsoHasta.Value;
                    _item.FECHABAJA = this.dtpLapsoHasta.Value;
                }
                else
                {
                    _item.LAPSODETIEMPO = false;
                    _item.LAPSODETIEMPOHASTA = System.DateTime.MinValue;                    

                }
                _item.OBSERVACION = this.txtObservacion.Text + this.txtEvento.Text;
                _item.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                if (_item.HORARIODESUMINISTRO_ID == 1) //Guarda Horario Fijo
                {
                    if (this.check08.Checked) { _item.HS_08 = true; } else { _item.HS_08 = false; }
                    if (this.check09.Checked) { _item.HS_09 = true; } else { _item.HS_09 = false; }
                    if (this.check10.Checked) { _item.HS_10 = true; } else { _item.HS_10 = false; }
                    if (this.check11.Checked) { _item.HS_11 = true; } else { _item.HS_11 = false; }
                    if (this.check12.Checked) { _item.HS_12 = true; } else { _item.HS_12 = false; }
                    if (this.check13.Checked) { _item.HS_13 = true; } else { _item.HS_13 = false; }
                    if (this.check14.Checked) { _item.HS_14 = true; } else { _item.HS_14 = false; }
                    if (this.check15.Checked) { _item.HS_15 = true; } else { _item.HS_15 = false; }
                    if (this.check16.Checked) { _item.HS_16 = true; } else { _item.HS_16 = false; }
                    if (this.check17.Checked) { _item.HS_17 = true; } else { _item.HS_17 = false; }
                    if (this.check18.Checked) { _item.HS_18 = true; } else { _item.HS_18 = false; }
                    if (this.check19.Checked) { _item.HS_19 = true; } else { _item.HS_19 = false; }
                    if (this.check20.Checked) { _item.HS_20 = true; } else { _item.HS_20 = false; }
                    if (this.check21.Checked) { _item.HS_21 = true; } else { _item.HS_21 = false; }
                    if (this.check22.Checked) { _item.HS_22 = true; } else { _item.HS_22 = false; }
                    if (this.check23.Checked) { _item.HS_23 = true; } else { _item.HS_23 = false; }
                    if (this.check24.Checked) { _item.HS_24 = true; } else { _item.HS_24 = false; }
                    if (this.check01.Checked) { _item.HS_01 = true; } else { _item.HS_01 = false; }
                    if (this.check02.Checked) { _item.HS_02 = true; } else { _item.HS_02 = false; }
                    if (this.check03.Checked) { _item.HS_03 = true; } else { _item.HS_03 = false; }
                    if (this.check04.Checked) { _item.HS_04 = true; } else { _item.HS_04 = false; }
                    if (this.check05.Checked) { _item.HS_05 = true; } else { _item.HS_05 = false; }
                    if (this.check06.Checked) { _item.HS_06 = true; } else { _item.HS_06 = false; }
                    if (this.check07.Checked) { _item.HS_07 = true; } else { _item.HS_07 = false; }
                }

                if (_item.HORARIODESUMINISTRO_ID == 2) //Guarda Turnos
                {
                    if (this.checkManiana.Checked) { _item.HS_09 = true; } else { _item.HS_09 = false; }
                    if (this.checkTarde.Checked) { _item.HS_16 = true; } else { _item.HS_16 = false; }
                    if (this.checkNoche.Checked) { _item.HS_21 = true; } else { _item.HS_21 = false; }
                }
                if (_item.HORARIODESUMINISTRO_ID == 3)//Evento
                {
                    _item.EVENTO = this.txtEvento.Text;
                    _item.HS_SH = true;
                    if (radioCon.Checked)
                    {
                        _item.HORARIOEVENTO = "C";
                    }
                    if (radioSin.Checked)
                    {
                        _item.HORARIOEVENTO = "S";
                    }
                }
                if (_item.HORARIODESUMINISTRO_ID == 5) // Horario Comidas
                {
                    if (this.checkDesayuno.Checked) { _item.HS_08 = true; } else { _item.HS_08 = false; }
                    if (this.checkAlmuerzo.Checked) { _item.HS_12 = true; } else { _item.HS_12 = false; }
                    if (this.checkMerienda.Checked) { _item.HS_16 = true; } else { _item.HS_16 = false; }
                    if (this.checkCena.Checked) { _item.HS_21 = true; } else { _item.HS_21 = false; }
                }
                if (_item.HORARIODESUMINISTRO_ID == 5)//Otro
                {
                    _item.HORARIOOTRO = this.txtHorarioObservacion.Text;
                    _item.HS_SH = true;
                }
                _item.L = chckL.Checked ? true : false;
                _item.M = chckM.Checked ? true : false;
                _item.X = chckX.Checked ? true : false;
                _item.J = chckJ.Checked ? true : false;
                _item.V = chckV.Checked ? true : false;
                _item.S = chckS.Checked ? true : false;
                _item.D = chckD.Checked ? true : false;
                // Graba Datos En Ambas Tablas
                Entities.Tables.MED_SUMINISTRODEMEDICACION _item2 = new Entities.Tables.MED_SUMINISTRODEMEDICACION();
                BLL.Tables.MED_SUMINISTRODEMEDICACION _suministroDeMedicacion2 = new BLL.Tables.MED_SUMINISTRODEMEDICACION();
                _item2.SUMINISTRODEMEDICACION_ID = suministro_medicacion_id;
                _item2.FECHAALTASISTEMA = _item.FECHAALTASISTEMA;
                _item2.DOSIS = _item.DOSIS;
                _item2.PACIENTE_ID = _item.PACIENTE_ID;
                _item2.MEDICAMENTO_ID = _item.MEDICAMENTO_ID;
                _item2.FECHAINICIO = _item.FECHAINICIO;
                _item2.PRESENTACION_ID = _item.PRESENTACION_ID;
                _item2.UNIDADDEMEDIDA_ID = Convert.ToInt32(_item.UNIDADDEMEDIDA_ID); //Generar Objetos No ser Villero
                _item2.POTENCIA = _item.POTENCIA;
                _item2.VIA_ID = _item.VIA_ID;
                _item2.VIATIENEOTRO = _item.VIATIENEOTRO;
                _item2.VIAOTRO = _item.VIAOTRO;
                _item2.DILUYENTE_ID = _item.DILUYENTE_ID;
                _item2.DURANTE_ID = _item.DURANTE_ID;
                _item2.PERIODO_ID = _item.PERIODO_ID;
                _item2.HORARIOEVENTO = _item.HORARIOEVENTO;
                _item2.HORARIODESUMINISTRO_ID = _item.HORARIODESUMINISTRO_ID;
                _item2.HS_08 = _item.HS_08;
                _item2.HS_09 = _item.HS_09;
                _item2.HS_10 = _item.HS_10;
                _item2.HS_11 = _item.HS_11;
                _item2.HS_12 = _item.HS_12;
                _item2.HS_13 = _item.HS_13;
                _item2.HS_14 = _item.HS_14;
                _item2.HS_15 = _item.HS_15;
                _item2.HS_16 = _item.HS_16;
                _item2.HS_17 = _item.HS_17;
                _item2.HS_18 = _item.HS_18;
                _item2.HS_19 = _item.HS_19;
                _item2.HS_20 = _item.HS_20;
                _item2.HS_21 = _item.HS_21;
                _item2.HS_22 = _item.HS_22;
                _item2.HS_23 = _item.HS_23;
                _item2.HS_24 = _item.HS_24;
                _item2.HS_01 = _item.HS_01;
                _item2.HS_02 = _item.HS_02;
                _item2.HS_03 = _item.HS_03;
                _item2.HS_04 = _item.HS_04;
                _item2.HS_05 = _item.HS_05;
                _item2.HS_06 = _item.HS_06;
                _item2.HS_07 = _item.HS_07;
                _item2.L = _item.L;
                _item2.M = _item.M;
                _item2.X = _item.X;
                _item2.J = _item.J;
                _item2.V = _item.V;
                _item2.S = _item.S;
                _item2.D = _item.D;
                _item2.LAPSODETIEMPO = _item.LAPSODETIEMPO;
                _item2.LAPSODETIEMPOHASTA = _item.LAPSODETIEMPOHASTA;
                _item2.OBSERVACION = _item.OBSERVACION;
                _item2.USUARIO_ID = _item.USUARIO_ID;
                _item2.FECHABAJA = _item.FECHABAJA;
                _item2.MOTIVOBAJA = _item.MOTIVOBAJA;
                _item2.EVENTO = _item.EVENTO;
                _suministroDeMedicacion2.ModificaSuministroDeMedicacion(_item2,_item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
        //--------------------------------------------------------------------------------------------------------------------- RECUPERA SUMINISTRO
        private void GetIndicacionesResumen(int suministro_medicacion_id, int paciente_id, string medicamento_id, string tipo_get)
        {
            CargarCboVia(medicamento_id, inactivo );
            CargarCboDiluyente();
            CargarCboDurante();
            CargaCboPeriodo();
            CargarCboDuranteInternacion();
            CargaCboPeriodoInternacion();

            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.MED_GET_SUMINISTRO_MEDICACION _obtieneIndicaciones = new BLL.Procedures.MED_GET_SUMINISTRO_MEDICACION();
                foreach (Entities.Procedures.MED_GET_SUMINISTRO_MEDICACION item in _obtieneIndicaciones.ItemList(suministro_medicacion_id, paciente_id,  medicamento_id, tipo_get))
                {
                    this.dtpInicio.Text = Convert.ToString(item.fechainicio);
                    // MEDICAMENTO
                    this.dtpInicio.Text = Convert.ToString(item.fechainicio);
                    this.lblNombreDeMedicamento.Text = item.droga + " "+ item.potenciaart + " " + item.presentacionart;
                    if(item.dosis == 0)
                    {                        
                        chckDemanda.Checked = true;
                    }
                    this.txtDosis.Text = Convert.ToString(item.dosis);
                    this.lblUnidadDeMedida.Text = item.unimed;
                    this.lblPotencia.Text = item.potencia;
                    this.txtPresentacion.Text = Convert.ToString(item.presentacion);
                    this.lblUnidadDeMedida.Text = Convert.ToString(item.unimed);
                    this.cboVia.SelectedValue = Convert.ToInt32(item.via_id);
                    this.checkViaTieneOtro.Checked = item.viatieneotro;
                    this.txtViaOtro.Text = item.viaotro;
                    this.cboDiluyente.SelectedValue = Convert.ToInt32(item.diluyente_id);
                    this.txtMl.Text = Convert.ToString(item.ml);
                    this.cboDurante.SelectedValue = Convert.ToInt32(item.durante_id);
                    this.cboPeriodo.SelectedValue = Convert.ToInt32(item.periodo_id);
                    this.txtObservacion.Text = item.observacion;
                    this.checkDeterminarLapsoDeTiempo.Checked = item.lapsodetiempo;
                    if (item.lapsodetiempohasta == DateTime.MinValue)
                    {
                        this.radioIndeterminado.Checked = true;
                        this.dtpLapsoHasta.Value = System.DateTime.Now;
                    }
                    else
                    {
                        this.checkDeterminarLapsoDeTiempo.Checked = true;
                        this.dtpLapsoHasta.Value = item.lapsodetiempohasta;
                    }

                    chckL.Checked = item.l;
                    chckM.Checked = item.m;
                    chckX.Checked = item.x;
                    chckJ.Checked = item.j;
                    chckV.Checked = item.v;
                    chckS.Checked = item.s;
                    chckD.Checked = item.d;

                    if (item.horariodesuministro_id == 1) //Horario Fijo
                    {
                        this.radioHorarioFijo.Checked = true;
                        if(item.hs_08 != false) {this.check08.Checked = true ; } else { this.check08.Checked = false; }
                        if (item.hs_09 != false) { this.check09.Checked = true; } else { this.check09.Checked = false; }
                        if (item.hs_10 != false) { this.check10.Checked = true; } else { this.check10.Checked = false; }
                        if (item.hs_11 != false) { this.check11.Checked = true; } else { this.check11.Checked = false; }
                        if (item.hs_12 != false) { this.check12.Checked = true; } else { this.check12.Checked = false; }
                        if (item.hs_13 != false) { this.check13.Checked = true; } else { this.check13.Checked = false; }
                        if (item.hs_14 != false) { this.check14.Checked = true; } else { this.check14.Checked = false; }
                        if (item.hs_15 != false) { this.check15.Checked = true; } else { this.check15.Checked = false; }
                        if (item.hs_16 != false) { this.check16.Checked = true; } else { this.check16.Checked = false; }
                        if (item.hs_17 != false) { this.check17.Checked = true; } else { this.check17.Checked = false; }
                        if (item.hs_18 != false) { this.check18.Checked = true; } else { this.check18.Checked = false; }
                        if (item.hs_19 != false) { this.check19.Checked = true; } else { this.check19.Checked = false; }
                        if (item.hs_20 != false) { this.check20.Checked = true; } else { this.check20.Checked = false; }
                        if (item.hs_21 != false) { this.check21.Checked = true; } else { this.check21.Checked = false; }
                        if (item.hs_22 != false) { this.check22.Checked = true; } else { this.check22.Checked = false; }
                        if (item.hs_23 != false) { this.check23.Checked = true; } else { this.check23.Checked = false; }
                        if (item.hs_24 != false) { this.check24.Checked = true; } else { this.check24.Checked = false; }
                        if (item.hs_01 != false) { this.check01.Checked = true; } else { this.check01.Checked = false; }
                        if (item.hs_02 != false) { this.check02.Checked = true; } else { this.check02.Checked = false; }
                        if (item.hs_03 != false) { this.check03.Checked = true; } else { this.check03.Checked = false; }
                        if (item.hs_04 != false) { this.check04.Checked = true; } else { this.check04.Checked = false; }
                        if (item.hs_05 != false) { this.check05.Checked = true; } else { this.check05.Checked = false; }
                        if (item.hs_06 != false) { this.check06.Checked = true; } else { this.check06.Checked = false; }
                        if (item.hs_07 != false) { this.check07.Checked = true; } else { this.check07.Checked = false; }
                    }
                    if (item.horariodesuministro_id == 2) //Horario Turnos
                    {
                        this.radioTurno.Checked = true;
                        if (item.hs_09 != false) { this.checkManiana.Checked = true; } else { this.checkManiana.Checked = false; }
                        if (item.hs_16 != false) { this.checkTarde.Checked = true; } else { this.checkTarde.Checked = false; }
                        if (item.hs_21 != false) { this.checkNoche.Checked = true; } else { this.checkNoche.Checked = false; }
                    }
                    if (item.horariodesuministro_id == 3) //Horario Evento
                    {
                        if (item.horarioevento == "C")
                        {
                            this.radioCon.Checked = true;
                        }
                        if (item.horarioevento == "S")
                        {
                            this.radioSin.Checked = true;
                        }

                        this.radioAnteUnEvento.Checked = true;
                        this.txtEvento.Text = item.evento;
                    }
                    if (item.horariodesuministro_id == 4) //Horario Comidas
                    {
                        this.radioHorarioDeComida.Checked = true;
                        if (item.hs_08 != false) { this.checkDesayuno.Checked = true; } else { this.checkDesayuno.Checked = false; }
                        if (item.hs_12 != false) { this.checkAlmuerzo.Checked = true; } else { this.checkAlmuerzo.Checked = false; }
                        if (item.hs_16 != false) { this.checkMerienda.Checked = true; } else { this.checkMerienda.Checked = false; }
                        if (item.hs_21 != false) { this.checkCena.Checked = true; } else { this.checkCena.Checked = false; }
                    }
                    if (item.horariodesuministro_id == 6)// Horario otro
                    {
                        this.radioOtro.Checked = true;
                        this.txtHorarioObservacion.Text = item.horariootro;
                    }
                }
                //objetoSuministroMedicacion 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------------------------------------------------------------------------------------- LIMPIA
        private void Limpiar()
        {
            // Limpia Variables Generales 
            this.paciente_id = 0;
            this.medicamento_id = string.Empty;
            // Limpia Medicacion
            this.dtpInicio.Text = string.Empty;
            this.txtDosis.Text = string.Empty;
            this.txtPresentacion.Text = string.Empty;
            this.lblUnidadDeMedida.Text = string.Empty;
            this.lblPotencia.Text = string.Empty;
            //this.cboVia.SelectedIndex = 0;
            this.checkViaTieneOtro.Checked = false;
            this.txtViaOtro.Text = string.Empty;
            //this.cboDiluyente.SelectedIndex = 0;
            this.txtMl.Text = string.Empty;
            //this.cboDurante.SelectedIndex = 0;
            //this.cboPeriodo.SelectedIndex = 0;
            // Limpia Horarios Fijos
            this.check08.Checked = false;
            this.check09.Checked = false;
            this.check10.Checked = false;
            this.check11.Checked = false;
            this.check12.Checked = false;
            this.check13.Checked = false;
            this.check14.Checked = false;
            this.check15.Checked = false;
            this.check16.Checked = false;
            this.check17.Checked = false;
            this.check18.Checked = false;
            this.check19.Checked = false;
            this.check20.Checked = false;
            this.check21.Checked = false;
            this.check22.Checked = false;
            this.check23.Checked = false;
            this.check24.Checked = false;
            // Limpia Turno
            this.checkManiana.Checked = false;
            this.checkTarde.Checked = false;
            this.checkNoche.Checked = false;
            //this.checkMadrugada.Checked = false;
            // Limpia Ante Un Evento
            this.radioCon.Checked = false;
            this.radioSin.Checked = false;
            // Limpia Intervalo De Tiempo
            //this.cboDuranteIntervalo.SelectedIndex = 0;
            //this.cboPeriodoIntervalo.SelectedIndex = 0;
            // Limpia Horario De Comida
            this.checkDesayuno.Checked = false;
            this.checkAlmuerzo.Checked = false;
            this.checkMerienda.Checked = false;
            this.checkCena.Checked = false;
            // Limpia Otro
            this.txtHorarioObservacion.Text = string.Empty;
            // Limpia Lapso De Tiempo
            this.checkDeterminarLapsoDeTiempo.Checked = false;
            this.dtpLapsoHasta.Text = string.Empty;
            // Limpia Indicación
            this.txtHorarioObservacion.Text = string.Empty;
        }


        private void GrabaSuministroEF(object paciente_id, object medicamento_id)
        {          
                SISTMEDEntities E = new SISTMEDEntities();
                MED_SuministroDeMedicacion _itemSuministroOriginal = E.MED_SuministroDeMedicacion.Find(suministro_medicacion_id);
                using (var dbContextTransaction = E.Database.BeginTransaction())
                try
                {
                    #region AddMedicamento
                    MED_SuministroDeMedicacion _item = new MED_SuministroDeMedicacion();
                
                    CultureInfo culture = new CultureInfo("en-US");
                    // Seteo Datos
                    if(suministro_medicacion_id != 0)
                    {
                        _item.fechaAltaSistema = _itemSuministroOriginal.fechaAltaSistema;
                    }
                    else
                    {
                        _item.fechaAltaSistema = System.DateTime.Now;
                    }
                    
                    _item.paciente_id = this.paciente_id;
                    _item.medicamento_id = this.medicamento_id;
                    _item.fechaInicio = this.dtpInicio.Value;
                    if (this.txtDosis.Text == string.Empty) { _item.dosis = 0; } else { _item.dosis = Convert.ToDecimal(this.txtDosis.Text); }
                    // Cambia el varchar que recupera con el stored _IND_GetSuministroMedicacion por el int correspondiente de la tabla IND_Presentacion e inserta la unidad de medida correspondiente tabla IND_UnidadDeMedida 
                    if (this.txtPresentacion.Text == "AEROSOL") { _item.presentacion_id = 1; _item.unidadDeMedida_id = 2; } // 2 Aplicaciones
                    if (this.txtPresentacion.Text == "AMPOLLA") { _item.presentacion_id = 2; _item.unidadDeMedida_id = 1; } // Ampollas
                    if (this.txtPresentacion.Text == "BOTELLA") { _item.presentacion_id = 3; _item.unidadDeMedida_id = 11; } // Ml
                    if (this.txtPresentacion.Text == "CAPSULAS") { _item.presentacion_id = 4; _item.unidadDeMedida_id = 3; } // Capsula
                    if (this.txtPresentacion.Text == "COMPRIMIDO") { _item.presentacion_id = 5; _item.unidadDeMedida_id = 4; } // Comprimidos
                    if (this.txtPresentacion.Text == "CREMA") { _item.presentacion_id = 6; _item.unidadDeMedida_id = 2; } // Aplicaciones
                    if (this.txtPresentacion.Text == "DOSIS") { _item.presentacion_id = 7; _item.unidadDeMedida_id = 5; } // Dosis
                    if (this.txtPresentacion.Text == "ELIXIR") { _item.presentacion_id = 8; _item.unidadDeMedida_id = 0; } // (sin valor)
                    if (this.txtPresentacion.Text == "EMULSION") { _item.presentacion_id = 9; _item.unidadDeMedida_id = 11; } // Ml
                    if (this.txtPresentacion.Text == "FRASCO") { _item.presentacion_id = 10; _item.unidadDeMedida_id = 10; } // Kg
                    if (this.txtPresentacion.Text == "FRASCO/AMPOLLA") { _item.presentacion_id = 11; _item.unidadDeMedida_id = 6; } // Fras/Ampolla
                    if (this.txtPresentacion.Text == "GEL") { _item.presentacion_id = 12; _item.unidadDeMedida_id = 2; } // Aplicaciones
                    if (this.txtPresentacion.Text == "GOTAS") { _item.presentacion_id = 13; _item.unidadDeMedida_id = 7; } // Gotas
                    if (this.txtPresentacion.Text == "GRAGEAS") { _item.presentacion_id = 14; _item.unidadDeMedida_id = 9; } // Grageas
                    if (this.txtPresentacion.Text == "JALEA") { _item.presentacion_id = 15; _item.unidadDeMedida_id = 11; } // Ml
                    if (this.txtPresentacion.Text == "JARABE") { _item.presentacion_id = 16; _item.unidadDeMedida_id = 11; } // Ml
                    if (this.txtPresentacion.Text == "JERINGA PRELLEN") { _item.presentacion_id = 17; _item.unidadDeMedida_id = 17; } // Unidades
                    if (this.txtPresentacion.Text == "JERINGA/CARTUCH") { _item.presentacion_id = 18; _item.unidadDeMedida_id = 17; } //Unidades
                    if (this.txtPresentacion.Text == "LACA") { _item.presentacion_id = 19; _item.unidadDeMedida_id = 11; } // Ml
                    if (this.txtPresentacion.Text == "LAPICERA") { _item.presentacion_id = 20; _item.unidadDeMedida_id = 0; } // (sin valor)
                    if (this.txtPresentacion.Text == "LAPIZ") { _item.presentacion_id = 21; _item.unidadDeMedida_id = 0; } // (sin valor)
                    if (this.txtPresentacion.Text == "LIQUIDO") { _item.presentacion_id = 22; _item.unidadDeMedida_id = 11; } // Ml
                    if (this.txtPresentacion.Text == "LOCION") { _item.presentacion_id = 23; _item.unidadDeMedida_id = 11; } // Ml
                    if (this.txtPresentacion.Text == "OVULOS") { _item.presentacion_id = 24; _item.unidadDeMedida_id = 12; } //
                    if (this.txtPresentacion.Text == "PARCHE") { _item.presentacion_id = 25; _item.unidadDeMedida_id = 13; } // Parche
                    if (this.txtPresentacion.Text == "POLVO") { _item.presentacion_id = 26; _item.unidadDeMedida_id = 8; } // Gr
                    if (this.txtPresentacion.Text == "POMADA") { _item.presentacion_id = 27; _item.unidadDeMedida_id = 2; } // Aplicaciones
                    if (this.txtPresentacion.Text == "SACHET") { _item.presentacion_id = 28; _item.unidadDeMedida_id = 11; } // Ml
                    if (this.txtPresentacion.Text == "SHAMPOO") { _item.presentacion_id = 29; _item.unidadDeMedida_id = 2; } // Aplicaciones
                    if (this.txtPresentacion.Text == "SOBRES") { _item.presentacion_id = 30; _item.unidadDeMedida_id = 17; } // Unidades
                    if (this.txtPresentacion.Text == "SOLUCION") { _item.presentacion_id = 31; _item.unidadDeMedida_id = 11; } // Ml
                    if (this.txtPresentacion.Text == "SPRAY") { _item.presentacion_id = 32; _item.unidadDeMedida_id = 14; } // Puff
                    if (this.txtPresentacion.Text == "SUPOSITORIO") { _item.presentacion_id = 33; _item.unidadDeMedida_id = 17; } // Unidades
                    if (this.txtPresentacion.Text == "SUSPENSION") { _item.presentacion_id = 34; _item.unidadDeMedida_id = 11; } // Ml
                    if (this.txtPresentacion.Text == "TIRAS") { _item.presentacion_id = 35; _item.unidadDeMedida_id = 15; } // Tiras
                    if (this.txtPresentacion.Text == "UI 5000") { _item.presentacion_id = 36; _item.unidadDeMedida_id = 16; } // UI
                    if (this.txtPresentacion.Text == "UNGUENTO") { _item.presentacion_id = 37; _item.unidadDeMedida_id = 2; } // Aplicaciones
                    if (this.txtPresentacion.Text == "UNIDAD") { _item.presentacion_id = 38; _item.unidadDeMedida_id = 17; } // Unidades
                    _item.potencia = this.lblPotencia.Text;
                    if (checkViaTieneOtro.Checked) { _item.via_id = 3; _item.viaTieneOtro = true; } else { _item.via_id = Convert.ToInt32(this.cboVia.SelectedValue); _item.viaTieneOtro = false; } // 3 es Otro en la tabla IND_Via
                    _item.viaOtro = this.txtViaOtro.Text;
                    _item.diluyente_id = Convert.ToInt32(this.cboDiluyente.SelectedValue);
                    if (this.txtMl.Text == string.Empty) { _item.ml = 0; } else { _item.ml = Convert.ToDecimal(this.txtMl.Text); }
                    _item.durante_id = Convert.ToInt32(this.cboDurante.SelectedValue);
                    _item.periodo_id = Convert.ToInt32(this.cboPeriodo.SelectedValue);
                    if (this.radioHorarioFijo.Checked) { _item.horarioDeSuministro_id = 1; }
                    if (this.radioTurno.Checked) { _item.horarioDeSuministro_id = 2; }
                    if (this.radioAnteUnEvento.Checked) { _item.horarioDeSuministro_id = 3; }
                    if (this.radioIntervaloDeTiempo.Checked) { _item.horarioDeSuministro_id = 4; }
                    if (this.radioHorarioDeComida.Checked) { _item.horarioDeSuministro_id = 5; }
                    if (this.radioOtro.Checked) { _item.horarioDeSuministro_id = 6; }
                    // Evaluo si modifica
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _item.fechaBaja = System.DateTime.Now;
                        _item.motivoBaja = this.txtSuspenderMotivo.Text;
                    }
                    if (this.checkDeterminarLapsoDeTiempo.Checked)
                    {
                        _item.lapsoDeTiempo = true;
                        _item.lapsoDeTiempoHasta = this.dtpLapsoHasta.Value;
                        _item.fechaBaja = this.dtpLapsoHasta.Value;
                    }
                    else
                    {
                        _item.lapsoDeTiempo = false;
                        //_item.lapsoDeTiempoHasta = System.DateTime.MinValue;
                    }
                    _item.observacion = this.txtObservacion.Text;
                    _item.usuario_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;


                    if (_item.horarioDeSuministro_id == 1) //Guarda Horario Fijo
                    {
                        if (this.check08.Checked) { _item.HS_08 = true; } else { _item.HS_08 = false; }
                        if (this.check09.Checked) { _item.HS_09 = true; } else { _item.HS_09 = false; }
                        if (this.check10.Checked) { _item.HS_10 = true; } else { _item.HS_10 = false; }
                        if (this.check11.Checked) { _item.HS_11 = true; } else { _item.HS_11 = false; }
                        if (this.check12.Checked) { _item.HS_12 = true; } else { _item.HS_12 = false; }
                        if (this.check13.Checked) { _item.HS_13 = true; } else { _item.HS_13 = false; }
                        if (this.check14.Checked) { _item.HS_14 = true; } else { _item.HS_14 = false; }
                        if (this.check15.Checked) { _item.HS_15 = true; } else { _item.HS_15 = false; }
                        if (this.check16.Checked) { _item.HS_16 = true; } else { _item.HS_16 = false; }
                        if (this.check17.Checked) { _item.HS_17 = true; } else { _item.HS_17 = false; }
                        if (this.check18.Checked) { _item.HS_18 = true; } else { _item.HS_18 = false; }
                        if (this.check19.Checked) { _item.HS_19 = true; } else { _item.HS_19 = false; }
                        if (this.check20.Checked) { _item.HS_20 = true; } else { _item.HS_20 = false; }
                        if (this.check21.Checked) { _item.HS_21 = true; } else { _item.HS_21 = false; }
                        if (this.check22.Checked) { _item.HS_22 = true; } else { _item.HS_22 = false; }
                        if (this.check23.Checked) { _item.HS_23 = true; } else { _item.HS_23 = false; }
                        if (this.check24.Checked) { _item.HS_24 = true; } else { _item.HS_24 = false; }
                        if (this.check01.Checked) { _item.HS_01 = true; } else { _item.HS_01 = false; }
                        if (this.check02.Checked) { _item.HS_02 = true; } else { _item.HS_02 = false; }
                        if (this.check03.Checked) { _item.HS_03 = true; } else { _item.HS_03 = false; }
                        if (this.check04.Checked) { _item.HS_04 = true; } else { _item.HS_04 = false; }
                        if (this.check05.Checked) { _item.HS_05 = true; } else { _item.HS_05 = false; }
                        if (this.check06.Checked) { _item.HS_06 = true; } else { _item.HS_06 = false; }
                        if (this.check07.Checked) { _item.HS_07 = true; } else { _item.HS_07 = false; }
                    }

                    if (_item.horarioDeSuministro_id == 2) //Guarda Turnos
                    {
                        if (this.checkManiana.Checked) { _item.HS_09 = true; } else { _item.HS_09 = false; }
                        if (this.checkTarde.Checked) { _item.HS_16 = true; } else { _item.HS_16 = false; }
                        if (this.checkNoche.Checked) { _item.HS_21 = true; } else { _item.HS_21 = false; }
                    }

                    if (_item.horarioDeSuministro_id == 3)//Evento
                    {
                        _item.evento = this.txtEvento.Text;
                        _item.HS_SH = true;
                        if (radioCon.Checked)
                        {
                            _item.horarioEvento = "C";
                        }
                        if (radioSin.Checked)
                        {
                            _item.horarioEvento = "S";
                        }
                    }

                    if (_item.horarioDeSuministro_id == 5) // Horario Comidas
                    {
                        if (this.checkDesayuno.Checked) { _item.HS_08 = true; } else { _item.HS_08 = false; }
                        if (this.checkAlmuerzo.Checked) { _item.HS_12 = true; } else { _item.HS_12 = false; }
                        if (this.checkMerienda.Checked) { _item.HS_16 = true; } else { _item.HS_16 = false; }
                        if (this.checkCena.Checked) { _item.HS_21 = true; } else { _item.HS_21 = false; }
                    }

                    if (_item.horarioDeSuministro_id == 6)//Otro
                    {
                        _item.horarioOtro = this.txtHorarioObservacion.Text;
                        _item.HS_SH = true;
                    }
                    _item.L = chckL.Checked ? true : false;
                    _item.M = chckM.Checked ? true : false;
                    _item.X = chckX.Checked ? true : false;
                    _item.J = chckJ.Checked ? true : false;
                    _item.V = chckV.Checked ? true : false;
                    _item.S = chckS.Checked ? true : false;
                    _item.D = chckD.Checked ? true : false;
                    _item.viaBomba = Convert.ToInt32(cboTipoVia.SelectedValue);

                    if (E.MED_SuministroDeMedicacion.Find(suministro_medicacion_id) != null) //Existe el suministro
                    {
                        _item.suministroDeMedicacion_id = suministro_medicacion_id;
                        _item.fechaInicio = dtpInicio.Value; 
                        E.Entry(E.MED_SuministroDeMedicacion.Find(suministro_medicacion_id)).CurrentValues.SetValues(_item);
                    }
                    else
                    {
                        _item.fechaInicio = dtpInicio.Value;
                        E.MED_SuministroDeMedicacion.Add(_item);
                    }

                    #endregion

                    #region AddHistorico
                    MED_Historial_SuministroDeMedicacion _itemHistorial = new MED_Historial_SuministroDeMedicacion();
                    _itemHistorial.suministroDeMedicacion_id = _item.suministroDeMedicacion_id;                
                    _itemHistorial.paciente_id = _item.paciente_id;
                    _itemHistorial.medicamento_id = _item.medicamento_id;
                    _itemHistorial.fechaInicio = _item.fechaInicio;
                    _itemHistorial.dosis = _item.dosis;
                    _itemHistorial.presentacion_id = _item.presentacion_id;
                    _itemHistorial.unidadDeMedida_id = Convert.ToInt32(_item.unidadDeMedida_id);
                    _itemHistorial.potencia = _item.potencia;
                    _itemHistorial.via_id = _item.via_id;
                    _itemHistorial.viaTieneOtro = _item.viaTieneOtro;
                    _itemHistorial.viaOtro = _item.viaOtro;
                    _itemHistorial.diluyente_id = _item.diluyente_id;
                    _itemHistorial.ml = _item.ml;
                    _itemHistorial.durante_id = _item.durante_id;
                    _itemHistorial.periodo_id = _item.periodo_id;
                    _itemHistorial.lapsoDeTiempo = _item.lapsoDeTiempo; //Si modifico tiene fecha de finalizacion a hoy
                    _itemHistorial.lapsoDeTiempoHasta = _item.lapsoDeTiempoHasta; //Guardo como finalizacion la fecha que modifica
                    _itemHistorial.horarioDeSuministro_id = _item.horarioDeSuministro_id;
                    _itemHistorial.horarioEvento = _item.horarioEvento;
                    _itemHistorial.evento = _item.evento;
                    _itemHistorial.horarioOtro = _item.horarioOtro;
                    _itemHistorial.observacion = _item.observacion;
                    _itemHistorial.usuario_id = _item.usuario_id; //Usuario original que cargo la indicacion 
                   
                                     
                                                   
                   
                    _itemHistorial.fechaModificacion = DateTime.Now; //Se modifico en ese momento           


                  

                    if (suministro_medicacion_id != 0)//Es una actualizacion
                    {
                        _itemHistorial.motivoBaja = "Modifica Indicacion: " + Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                    }                    
                    else
                    {
                        _itemHistorial.motivoBaja = "Agrega Indicacion: " + Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                    }
                    if (_item.fechaBaja != null)
                    {
                        _itemHistorial.motivoBaja = "Suspende Indicacion: " + Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                        _itemHistorial.fechaBaja = _item.fechaBaja;
                    }
                    _itemHistorial.HS_01 = _item.HS_01;
                    _itemHistorial.HS_02 = _item.HS_02;
                    _itemHistorial.HS_03 = _item.HS_03;
                    _itemHistorial.HS_04 = _item.HS_04;
                    _itemHistorial.HS_05 = _item.HS_05;
                    _itemHistorial.HS_06 = _item.HS_06;
                    _itemHistorial.HS_07 = _item.HS_07;
                    _itemHistorial.HS_08 = _item.HS_08;
                    _itemHistorial.HS_09 = _item.HS_09;
                    _itemHistorial.HS_10 = _item.HS_10;
                    _itemHistorial.HS_11 = _item.HS_11;
                    _itemHistorial.HS_12 = _item.HS_12;
                    _itemHistorial.HS_13 = _item.HS_13;
                    _itemHistorial.HS_14 = _item.HS_14;
                    _itemHistorial.HS_15 = _item.HS_15;
                    _itemHistorial.HS_16 = _item.HS_16;
                    _itemHistorial.HS_17 = _item.HS_17;
                    _itemHistorial.HS_18 = _item.HS_18;
                    _itemHistorial.HS_19 = _item.HS_19;
                    _itemHistorial.HS_20 = _item.HS_20;
                    _itemHistorial.HS_21 = _item.HS_21;
                    _itemHistorial.HS_22 = _item.HS_22;
                    _itemHistorial.HS_23 = _item.HS_23;
                    _itemHistorial.HS_24 = _item.HS_24;
                    _itemHistorial.HS_SH = _item.HS_SH;
                    _itemHistorial.L = _item.L;
                    _itemHistorial.M = _item.M;
                    _itemHistorial.X = _item.X;
                    _itemHistorial.J = _item.J;
                    _itemHistorial.V = _item.V;
                    _itemHistorial.S = _item.S;
                    _itemHistorial.D = _item.D;

                    if(suministro_medicacion_id != 0)
                    {
                        _itemHistorial.suministro_original = _itemSuministroOriginal.suministroDeMedicacion_id;
                    }
                    else
                    {
                        _itemHistorial.MED_SuministroDeMedicacion = _item;                   
                    }

                    if(suministro_medicacion_id != 0)
                    {
                        _itemHistorial.fechaAltaSistema = DateTime.Now;
                    }
                    else
                    {
                        _itemHistorial.fechaAltaSistema = dtpInicio.Value;
                    }
                   
                    E.MED_Historial_SuministroDeMedicacion.Add(_itemHistorial);

                    //Verifico el registro anterior para cambiar fecha de baja si es una nueva no hay registros anteriores
                    if (suministro_medicacion_id != 0)
                    {
                        var _suministroAnterior = E.MED_Historial_SuministroDeMedicacion.AsNoTracking().Where(s => s.suministro_original == suministro_medicacion_id).OrderByDescending(f => f.fechaModificacion).FirstOrDefault();
                       
                            MED_Historial_SuministroDeMedicacion MED = new MED_Historial_SuministroDeMedicacion { suministroDeMedicacion_id = _suministroAnterior.suministroDeMedicacion_id, fechaBaja = DateTime.Now };
                            E.MED_Historial_SuministroDeMedicacion.Attach(MED);
                            E.Entry(MED).Property(f => f.fechaBaja).IsModified = true;                                    
                        
                    }
                    #endregion

                    E.SaveChanges();
                    dbContextTransaction.Commit();
                }
            catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        #endregion

        private bool ExisteDroga()
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();
                bool _existe = E.MED_SuministroDeMedicacion.Where(p => p.paciente_id == Clases.Paciente.PacienteIngresado && p.medicamento_id == medicamento_id && (p.fechaBaja == null || p.fechaBaja > DateTime.Now)).Count() > 0;
                return _existe;
            }
            catch (Exception ex)
            {
                return false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool _guardar = true;
                if(ExisteDroga())
                {
                    DialogResult dialogResult = MessageBox.Show("Ya existe una indicacion con esta droga, desea indicarla de todas formas?", "Indicacion Duplicada", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _guardar = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        _guardar = false;
                        this.Close();
                    }
                }
                if (_guardar)
                {
                    decimal parsedValue;
                    if (this.txtDosis.Text == string.Empty || !decimal.TryParse(txtDosis.Text, out parsedValue))
                    {
                        MessageBox.Show("El campo Dosis es obligatorio y debe ser decimal (0.00)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        if (cboVia.SelectedIndex == 0 && this.txtViaOtro.Text == string.Empty)
                        {
                            MessageBox.Show("El campo Via es obligatorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (this.cboVia.Text == "ENDOVENOSA" && (checkViaEndovenosa.Checked == false || cboDiluyente.SelectedIndex == 0 || txtMl.Text == ""))
                            {
                                MessageBox.Show("Debe completar todos los datos para la administracion Endovenosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                DialogResult dialogResult = MessageBox.Show("Desea guardar la indicación?", "Indicación Medicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                {
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        if (this.radioHorarioFijo.Checked)
                                        {
                                            if (this.check08.Checked == false && this.check09.Checked == false && this.check10.Checked == false && this.check11.Checked == false && this.check12.Checked == false && this.check13.Checked == false
                                                && this.check14.Checked == false && this.check15.Checked == false && this.check16.Checked == false && this.check17.Checked == false && this.check18.Checked == false && this.check19.Checked == false
                                                && this.check20.Checked == false && this.check21.Checked == false && this.check22.Checked == false && this.check23.Checked == false && this.check24.Checked == false && this.check01.Checked == false
                                                && this.check02.Checked == false && this.check03.Checked == false && this.check04.Checked == false && this.check05.Checked == false && this.check06.Checked == false && this.check07.Checked == false)
                                            {
                                                MessageBox.Show("Debe seleccionar horarios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                btnGuardar.Show();
                                            }
                                            else
                                            {
                                                GrabaSuministroEF(paciente_id, medicamento_id);

                                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                btnGuardar.Hide();
                                                btnModificar.Hide();
                                                this.Opener.IActualiza();
                                                this.Close();
                                                this.Dispose();
                                            }
                                        }
                                        if (this.radioTurno.Checked)
                                        {
                                            if (this.checkManiana.Checked == false && this.checkTarde.Checked == false && this.checkNoche.Checked == false)
                                            {
                                                MessageBox.Show("Debe seleccionar turnos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                            {
                                                GrabaSuministroEF(paciente_id, medicamento_id);
                                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                btnGuardar.Hide(); ;
                                                btnModificar.Hide();
                                                this.Opener.IActualiza();
                                                this.Close();
                                                this.Dispose();
                                            }
                                        }
                                        if (this.radioAnteUnEvento.Checked)
                                        {
                                            if (this.radioCon.Checked == false && this.radioSin.Checked == false || this.txtEvento.Text == String.Empty)
                                            {
                                                MessageBox.Show("Debe seleccionar la condición y el evento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                            {
                                                GrabaSuministroEF(paciente_id, medicamento_id);
                                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                btnGuardar.Hide(); ;
                                                btnModificar.Hide();
                                                this.Opener.IActualiza();
                                                this.Close();
                                                this.Dispose();
                                            }
                                        }
                                        if (this.radioIntervaloDeTiempo.Checked)
                                        {
                                            if (cboDuranteIntervalo.SelectedIndex == 0 || cboPeriodoIntervalo.SelectedIndex == 0)
                                            {
                                                MessageBox.Show("Debe seleccionar un periodo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                            {
                                                GrabaSuministroEF(paciente_id, medicamento_id);
                                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                btnGuardar.Hide(); ;
                                                btnModificar.Hide();
                                                this.Opener.IActualiza();
                                                this.Close();
                                                this.Dispose();
                                            }

                                        }
                                        if (this.radioHorarioDeComida.Checked)
                                        {
                                            if (this.checkDesayuno.Checked == false && this.checkAlmuerzo.Checked == false && this.checkMerienda.Checked == false && this.checkCena.Checked == false)
                                            {
                                                MessageBox.Show("Debe seleccionar las comidas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                            {
                                                GrabaSuministroEF(paciente_id, medicamento_id);
                                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                btnGuardar.Hide(); ;
                                                btnModificar.Hide();
                                                this.Close();
                                            }
                                        }
                                        if (this.radioOtro.Checked)
                                        {
                                            GrabaSuministroEF(paciente_id, medicamento_id);
                                            MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            btnGuardar.Hide(); ;
                                            btnModificar.Hide();
                                            this.Opener.IActualiza();
                                            this.Close();
                                            this.Dispose();
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.txtSuspenderMotivo.Text != String.Empty)
                {
                    #region Suspender
                    DialogResult dialogResult = MessageBox.Show("Seguro que desea supender este suministro?", "Procedimiento - Enfermeria", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (this.radioHorarioFijo.Checked)
                            {
                                GrabaSuministroEF(paciente_id, medicamento_id);
                                btnModificar.Hide();
                                btnGuardar.Hide();;
                            }
                            if (this.radioTurno.Checked)
                            {
                                GrabaSuministroEF(paciente_id, medicamento_id);
                                btnModificar.Hide();
                                btnGuardar.Hide();;
                            }
                            if (this.radioAnteUnEvento.Checked)
                            {
                                GrabaSuministroEF(paciente_id, medicamento_id);
                                btnModificar.Hide();
                                btnGuardar.Hide();;
                            }
                            if (this.radioIntervaloDeTiempo.Checked)
                            {
                                GrabaSuministroEF(paciente_id, medicamento_id);
                                btnModificar.Hide();
                                btnGuardar.Hide();;
                            }
                            if (this.radioHorarioDeComida.Checked)
                            {
                                GrabaSuministroEF(paciente_id, medicamento_id);
                                btnModificar.Hide();
                                btnGuardar.Hide();;
                            }
                            if (this.radioOtro.Checked)
                            {
                                GrabaSuministroEF(paciente_id, medicamento_id);
                                btnModificar.Hide();
                                btnGuardar.Hide();;
                            }
                            MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Opener.IActualiza();
                            this.Close();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            this.Opener.IActualiza();
                            this.Close();
                        }
                    }
                    #endregion
                }
                else
                {
                    #region Modifica
                    if (this.txtDosis.Text == null)
                    {
                        MessageBox.Show("Debe ingresar la dosis", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Desea modificar la indicación?", "Indicación Medicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {
                                if (this.radioHorarioFijo.Checked)
                                {
                                    if (this.check08.Checked == false && this.check09.Checked == false && this.check10.Checked == false && this.check11.Checked == false && this.check12.Checked == false && this.check13.Checked == false
                                        && this.check14.Checked == false && this.check15.Checked == false && this.check16.Checked == false && this.check17.Checked == false && this.check18.Checked == false && this.check19.Checked == false
                                        && this.check20.Checked == false && this.check21.Checked == false && this.check22.Checked == false && this.check23.Checked == false && this.check24.Checked == false && this.check01.Checked == false
                                        && this.check02.Checked == false && this.check03.Checked == false && this.check04.Checked == false && this.check05.Checked == false && this.check06.Checked == false && this.check07.Checked == false)
                                    {
                                        MessageBox.Show("Debe seleccionar horarios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                    else
                                    {
                                        GrabaSuministroEF(paciente_id, medicamento_id);                                           
                                        btnModificar.Hide();
                                        btnGuardar.Hide();

                                        MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Opener.IActualiza();
                                        this.Close();
                                    }
                                }
                                else if (this.radioTurno.Checked)
                                {
                                    if (this.checkManiana.Checked == false && this.checkTarde.Checked == false && this.checkNoche.Checked == false)
                                    {
                                        MessageBox.Show("Debe seleccionar turnos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        GrabaSuministroEF(paciente_id, medicamento_id);
                                        btnModificar.Hide();
                                        btnGuardar.Hide();

                                        MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Opener.IActualiza();
                                        this.Close();
                                    }
                                }
                                else if (this.radioAnteUnEvento.Checked)
                                {
                                    if (this.radioCon.Checked == false && this.radioSin.Checked == false || this.txtEvento.Text == String.Empty)
                                    {
                                        MessageBox.Show("Debe seleccionar la condición y el evento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        GrabaSuministroEF(paciente_id, medicamento_id);
                                        btnModificar.Hide();
                                        btnGuardar.Hide();

                                        MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Opener.IActualiza();
                                        this.Close();
                                    }
                                }
                                else if (this.radioIntervaloDeTiempo.Checked)
                                {
                                    GrabaSuministroEF(paciente_id, medicamento_id);
                                    btnModificar.Hide();
                                    btnGuardar.Hide();

                                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Opener.IActualiza();
                                    this.Close();
                                }
                                else if (this.radioHorarioDeComida.Checked)
                                {
                                    if (this.checkDesayuno.Checked == false && this.checkAlmuerzo.Checked == false && this.checkMerienda.Checked == false && this.checkCena.Checked == false)
                                    {
                                        MessageBox.Show("Debe seleccionar las comidas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        GrabaSuministroEF(paciente_id, medicamento_id);
                                        btnModificar.Hide();
                                        btnGuardar.Hide();

                                        MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Opener.IActualiza();
                                        this.Close();
                                    }
                                }
                                else if (this.radioOtro.Checked)
                                {
                                    if (txtHorarioObservacion.Text == string.Empty)
                                    {
                                        MessageBox.Show("Debe ingresar algo en este tipo de horario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        GrabaSuministroEF(paciente_id, medicamento_id);
                                        btnModificar.Hide();
                                        btnGuardar.Hide();

                                        MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Opener.IActualiza();
                                        this.Close();
                                    }
                                }

                               
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                this.Opener.IActualiza();
                                this.Close();
                            }
                        }
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckMedio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtDosis.Text = "0,50";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckCuarto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtDosis.Text = "0,25";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckTresCuartos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtDosis.Text = "0,75";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckSuspender_CheckedChanged(object sender, EventArgs e)
        {
            if(chckSuspender.Checked)
            {
                this.txtSuspenderMotivo.Text = "Se suspende el suministro de esta medicacion el dia " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + " por " + Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                this.dtpLapsoHasta.Value = DateTime.Now;
            }
            else
            {
                this.txtSuspenderMotivo.Text = "";
            }
            
        }

        private void cboTipoVia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtHorarioObservacion.Text = cboTipoVia.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtHorarioObservacion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //txtObservacion.Text = cboTipoVia.Text + " " + txtHorarioObservacion.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHorarioObservacion_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cboVia.Text == "ENDOVENOSA")
                {
                    txtObservacion.Text = txtHorarioObservacion.Text + " Diluido en: " + cboDiluyente.Text + " " + txtMl.Text + "ml";
                }
                else
                {
                    txtObservacion.Text = txtHorarioObservacion.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckDemanda_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(chckDemanda.Checked)
                {
                    txtHorarioObservacion.Text = " A demanda";
                    txtDosis.Text = "0";
                    txtDosis.Enabled = false;
                }
                else
                {
                    txtHorarioObservacion.Text = "";
                    txtDosis.Text = "";
                    txtDosis.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDiluyente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cboVia.Text == "ENDOVENOSA")
                {
                    txtObservacion.Text = txtHorarioObservacion.Text + " Diluido en: " + cboDiluyente.Text + " " + txtMl.Text + "ml";
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMl.Text != string.Empty)
                {
                    txtObservacion.Text = txtHorarioObservacion.Text+" Diluido en: " + cboDiluyente.Text + " " + txtMl.Text + "ml";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkDeterminarLapsoDeTiempo_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if(checkDeterminarLapsoDeTiempo.Checked)
                {
                    dtpLapsoHasta.Enabled = true;
                    dtpLapsoHasta.Visible = true;
                }
                else
                {                    
                    dtpLapsoHasta.Visible = false;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkViaEndovenosa_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(checkViaEndovenosa.Checked)
                {
                    CargarCboViasEndovenosa();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMl_Click(object sender, EventArgs e)
        {

        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpLapsoHasta.MinDate = dtpInicio.Value; //La fecha de finalizacion no puede ser menor a la de inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckUnicaVez_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(chckUnicaVez.Checked)
                {
                    checkDeterminarLapsoDeTiempo.Checked = true;
                    dtpLapsoHasta.Value = DateTime.Now.AddDays(1);

                    if(DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                    {
                        chckL.Checked = true;
                        chckM.Checked = false;
                        chckX.Checked = false;
                        chckJ.Checked = false;
                        chckV.Checked = false;
                        chckS.Checked = false;
                        chckD.Checked = false;
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        chckL.Checked = false;
                        chckM.Checked = true;
                        chckX.Checked = false;
                        chckJ.Checked = false;
                        chckV.Checked = false;
                        chckS.Checked = false;
                        chckD.Checked = false;
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        chckL.Checked = false;
                        chckM.Checked = false;
                        chckX.Checked = true;
                        chckJ.Checked = false;
                        chckV.Checked = false;
                        chckS.Checked = false;
                        chckD.Checked = false;
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                    {
                        chckL.Checked = false;
                        chckM.Checked = false;
                        chckX.Checked = false;
                        chckJ.Checked = true;
                        chckV.Checked = false;
                        chckS.Checked = false;
                        chckD.Checked = false;
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                    {
                        chckL.Checked = false;
                        chckM.Checked = false;
                        chckX.Checked = false;
                        chckJ.Checked = false;
                        chckV.Checked = true;
                        chckS.Checked = false;
                        chckD.Checked = false;
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                    {
                        chckL.Checked = false;
                        chckM.Checked = false;
                        chckX.Checked = false;
                        chckJ.Checked = false;
                        chckV.Checked = false;
                        chckS.Checked = true;
                        chckD.Checked = false;
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                    {
                        chckL.Checked = false;
                        chckM.Checked = false;
                        chckX.Checked = false;
                        chckJ.Checked = false;
                        chckV.Checked = false;
                        chckS.Checked = false;
                        chckD.Checked = true;
                    }

                    txtObservacion.Text = txtObservacion.Text + " Unica Vez";
                }
                else
                {
                    checkDeterminarLapsoDeTiempo.Checked = false;
                    dtpLapsoHasta.Value = DateTime.Now;
                    chckL.Checked = true;
                    chckM.Checked = true;
                    chckX.Checked = true;
                    chckJ.Checked = true;
                    chckV.Checked = true;
                    chckS.Checked = true;
                    chckD.Checked = true;

                    txtObservacion.Text = txtObservacion.Text.Replace("Unica Vez","");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
