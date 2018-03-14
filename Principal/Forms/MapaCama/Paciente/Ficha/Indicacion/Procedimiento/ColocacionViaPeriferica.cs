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

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento
{
    public partial class ColocacionViaPeriferica : MetroForm
    {
        #region Variables
        public delegate void Indicacion();
        public event Indicacion ActualizarIndicacion;
        public IActuIndicaciones Opener { get; set; }
        private int suministro_procedimiento_id;
        public int Suministro_Procedimiento_Id
        {
            get
            {
                return suministro_procedimiento_id;
            }
            set
            {
                this.suministro_procedimiento_id = value;
            }
        }

        private int procedimiento_id;
        public int Procedimiento_Id
        {
            get
            {
                return procedimiento_id;
            }
            set
            {
                this.procedimiento_id = value;
            }
        }

        private int paciente_id;
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

        private int tipo_procedimiento_id;
        public int Tipo_Procedimiento_Id
        {
            get
            {
                return tipo_procedimiento_id;
            }
            set
            {
                this.tipo_procedimiento_id = value;
            }
        }

        private int colocacionViaPeriferica_id;
        public int ColocacionViaPeriferica_Id
        {
            get
            {
                return colocacionViaPeriferica_id;
            }
            set
            {
                this.colocacionViaPeriferica_id = value;
            }
        }

        #endregion

        #region Inicio
        public ColocacionViaPeriferica()
        {
            InitializeComponent();
        }
        private void ColocacionViaPeriferica_Load(object sender, EventArgs e)
        {
            CargarCboAbocathNumero();
            try
            {
                if (suministro_procedimiento_id != 0)
                {
                    Get_Colocacion_Via_Periferica(colocacionViaPeriferica_id);
                    btnGuardar.Enabled = false;
                    btnSalir.Enabled = false;
                    btnModificar.Enabled = true;
                    btnSalir.Enabled = true;
                }
                else
                {
                    btnModificar.Enabled = false;
                    this.groupSuspender.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos  
        private void CargarCboAbocathNumero()
        {
            try
            {
                BLL.Procedures.PRO_GET_ABOCATH_NUMERO _os = new BLL.Procedures.PRO_GET_ABOCATH_NUMERO();
                Entities.Procedures.PRO_GET_ABOCATH_NUMERO _itemSeleccion = new Entities.Procedures.PRO_GET_ABOCATH_NUMERO();
                List<Entities.Procedures.PRO_GET_ABOCATH_NUMERO> _ItemsOS = new List<Entities.Procedures.PRO_GET_ABOCATH_NUMERO>();
                //Limpia el combo
                this.cboAbocath.SuspendLayout();
                this.cboAbocath.DataSource = null;
                this.cboAbocath.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.art_descgen  = "<Seleccione>";
                _itemSeleccion.art_codgen = "0";
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAbocath.DisplayMember = BLL.Procedures.PRO_GET_ABOCATH_NUMERO.ColumnNames.ART_DESCGEN;
                this.cboAbocath.ValueMember = BLL.Procedures.PRO_GET_ABOCATH_NUMERO.ColumnNames.ART_CODGEN;
                this.cboAbocath.DataSource = _ItemsOS;
                this.cboAbocath.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // BOTONES
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DialogResult dialogResult = MessageBox.Show("Desea guardar el procedimiento?", "Procedimiento - Colocación Vía Periferica", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (this.txtObservacion.Text == string.Empty)
                            {
                                MessageBox.Show("Debe agregar una observación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnGuardar.Enabled = true;
                                btnSalir.Enabled = true;
                                btnModificar.Enabled = false;
                            }
                            else
                            {
                                Graba_Suministro_Procedimiento_Colocacion_Via_Periferica();
                                Graba_Historial_Suministro_Procedimiento_Colocacion_Via_Periferica();
                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Opener.IActualiza();
                                this.Close();
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }
                    }
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
                {
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        #region Suspender
                        DialogResult dialogResult = MessageBox.Show("Seguro que desea supender este procedimiento?", "Procedimiento - Colocación Vía Periferica", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {
                                Graba_Historial_Suministro_Procedimiento_Colocacion_Via_Periferica();
                                Modifica_Suministro_Procedimiento_Colocacion_Via_Periferica();
                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ActualizarIndicacion();
                                this.Close();
                            }
                            else if (dialogResult == DialogResult.No)
                            {                               
                                this.Close();
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        #region Modifica
                        DialogResult dialogResult = MessageBox.Show("Desea modificar el procedimiento?", "Procedimiento - Colocación Vía Periferica", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {
                                if (this.txtObservacion.Text == string.Empty)
                                {
                                    MessageBox.Show("Debe agregar una observación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btnGuardar.Enabled = true;
                                    btnSalir.Enabled = true;
                                    btnModificar.Enabled = false;
                                }
                                else
                                {
                                    Graba_Historial_Suministro_Procedimiento_Colocacion_Via_Periferica();
                                    Modifica_Suministro_Procedimiento_Colocacion_Via_Periferica();
                                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ActualizarIndicacion();
                                    this.Close();
                                }
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                //do something else
                            }
                        }
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        #endregion

        #region Metodos
        public void Limpiar()
        {
            try
            {
                this.txtObservacion.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Graba en la tabla PRO_SuministroDeProcedimiento y en la PRO_Colocacion_Via_Periferica
        public void Graba_Suministro_Procedimiento_Colocacion_Via_Periferica()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Colocacion_Via_Periferica")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.COLOCACIONVIAPERIFERICA_ID = Convert.ToInt32(item.id + 1);
                    }
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id;
                    _itemSuministro.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    // Tabla PRO_Colocacion_Via_Periferica
                    Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA _itemColocacionViaPeriferica = new Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA();
                    BLL.Tables.PRO_COLOCACION_VIA_PERIFERICA _colocacionViaPeriferica = new BLL.Tables.PRO_COLOCACION_VIA_PERIFERICA();
                    _itemColocacionViaPeriferica.PACIENTE_ID = paciente_id;
                    _itemColocacionViaPeriferica.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemColocacionViaPeriferica.ABOCATHNUMERO_ID = Convert.ToString(this.cboAbocath.SelectedValue);
                    if (this.checkParche.Checked == true) { _itemColocacionViaPeriferica.PARCHETEGADERM = true; } else { _itemColocacionViaPeriferica.PARCHETEGADERM = false; }
                    if (this.radioInfusionPermanente.Checked == true) { _itemColocacionViaPeriferica.INFUSION = true; } else { _itemColocacionViaPeriferica.INFUSION = false; }
                    if (this.radioIntravenosa.Checked == true) { _itemColocacionViaPeriferica.VIA = true; } else { _itemColocacionViaPeriferica.VIA = false; }
                    _itemColocacionViaPeriferica.OBSERVACION = this.txtObservacion.Text;
                    _itemColocacionViaPeriferica.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemColocacionViaPeriferica.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemColocacionViaPeriferica.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaColocacionViaPeriferica(_itemSuministro, _itemColocacionViaPeriferica);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Graba en la tabla PRO_Historial_SuministroDeProcedimiento y en la PRO_Historial_Colocacion_Via_Periferica
        public void Graba_Historial_Suministro_Procedimiento_Colocacion_Via_Periferica()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_Historial_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Historial_Colocacion_Via_Periferica")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.COLOCACIONVIAPERIFERICA_ID = Convert.ToInt32(item.id);
                    }
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id; // Enfermeria de la tabla PRO_Tipo_Procedimiento
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemSuministro.FECHABAJA = System.DateTime.Now;
                        _itemSuministro.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    _itemSuministro.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    // Tabla PRO_Historial_Colocacion_Via_Periferica
                    Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA _itemColocacionViaPeriferica = new Entities.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA();
                    BLL.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA _colocacionViaPeriferica = new BLL.Tables.PRO_HISTORIAL_COLOCACION_VIA_PERIFERICA();
                    _itemColocacionViaPeriferica.PACIENTE_ID = paciente_id;
                    _itemColocacionViaPeriferica.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemColocacionViaPeriferica.FECHABAJA = System.DateTime.Now;
                        _itemColocacionViaPeriferica.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    _itemColocacionViaPeriferica.ABOCATHNUMERO_ID = Convert.ToString(this.cboAbocath.SelectedValue);
                    if (this.checkParche.Checked == true) { _itemColocacionViaPeriferica.PARCHETEGADERM = true; } else { _itemColocacionViaPeriferica.PARCHETEGADERM = false; }
                    if (this.radioInfusionPermanente.Checked == true) { _itemColocacionViaPeriferica.INFUSION = true; } else { _itemColocacionViaPeriferica.INFUSION = false; }
                    if (this.radioIntravenosa.Checked == true) { _itemColocacionViaPeriferica.VIA = true; } else { _itemColocacionViaPeriferica.VIA = false; }
                    _itemColocacionViaPeriferica.OBSERVACION = this.txtObservacion.Text;
                    _itemColocacionViaPeriferica.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemColocacionViaPeriferica.FECHAALTASISTEMA = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaHistorialColocacionViaPeriferica(_itemSuministro, _itemColocacionViaPeriferica);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Modifica_Suministro_Procedimiento_Colocacion_Via_Periferica()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.COLOCACIONVIAPERIFERICA_ID = colocacionViaPeriferica_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id; // Enfermeria de la tabla PRO_Tipo_Procedimiento
                    _itemSuministro.FECHAMODIFICIACION = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemSuministro.SUMINISTRODEPROCEDIMIENTO_ID = suministro_procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemSuministro.FECHABAJA = System.DateTime.Now;
                        _itemSuministro.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    // Tabla PRO_Colocacion_Via_Periferica
                    Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA _itemColocacionViaPeriferica = new Entities.Tables.PRO_COLOCACION_VIA_PERIFERICA();
                    BLL.Tables.PRO_COLOCACION_VIA_PERIFERICA _colocacionViaPeriferica = new BLL.Tables.PRO_COLOCACION_VIA_PERIFERICA();
                    _itemColocacionViaPeriferica.PACIENTE_ID = paciente_id;
                    _itemColocacionViaPeriferica.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemColocacionViaPeriferica.FECHABAJA = System.DateTime.Now;
                        _itemColocacionViaPeriferica.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    _itemColocacionViaPeriferica.ABOCATHNUMERO_ID = Convert.ToString(this.cboAbocath.SelectedValue);
                    if (this.checkParche.Checked == true) { _itemColocacionViaPeriferica.PARCHETEGADERM = true; } else { _itemColocacionViaPeriferica.PARCHETEGADERM = false; }
                    if (this.radioInfusionPermanente.Checked == true) { _itemColocacionViaPeriferica.INFUSION = true; } else { _itemColocacionViaPeriferica.INFUSION = false; }
                    if (this.radioIntravenosa.Checked == true) { _itemColocacionViaPeriferica.VIA = true; } else { _itemColocacionViaPeriferica.VIA = false; }
                    _itemColocacionViaPeriferica.OBSERVACION = this.txtObservacion.Text;
                    _itemColocacionViaPeriferica.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemColocacionViaPeriferica.COLOCACIONVIAPERIFERICA_ID = _itemSuministro.COLOCACIONVIAPERIFERICA_ID;
                    _itemColocacionViaPeriferica.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.ModificaColocacionViaPeriferica(_itemSuministro, _itemColocacionViaPeriferica);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        // Recupera Colocación Vía Perifericas
        private void Get_Colocacion_Via_Periferica(int colocacionViaPeriferica_id)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");

                BLL.Procedures.PRO_GET_COLOCACION_VIA_PERIFERICA _itemColocacionViaPeriferica = new BLL.Procedures.PRO_GET_COLOCACION_VIA_PERIFERICA();
                foreach (Entities.Procedures.PRO_GET_COLOCACION_VIA_PERIFERICA item in _itemColocacionViaPeriferica.ItemList(colocacionViaPeriferica_id))
                {
                    this.cboAbocath.SelectedValue = item.abocathnumero_id;
                    if (item.parchetegaderm == true) { this.checkParche.Checked = true; } else { this.checkParche.Checked = false; }
                    if(item.infusion == true) { this.radioInfusionPermanente.Checked = true; } else { this.radioInfusionIntermitente.Checked = true; }
                    if (item.via == true) { this.radioIntravenosa.Checked = true; } else { this.radioSubcutanea.Checked = true; }
                    this.txtObservacion.Text = item.observacion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        #endregion     
    }
}
