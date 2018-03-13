using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento
{
    public partial class Enfermeria : MetroForm
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

        private int enfermeria_id;
        public int Enfermeria_Id
        {
            get
            {
                return enfermeria_id;
            }
            set
            {
                this.enfermeria_id = value;
            }
        }

        #endregion

        #region Inicio
        // LOAD
        private void Enfermeria_Load(object sender, EventArgs e)
        {
            try
            {
                if (suministro_procedimiento_id != 0)
                {
                    Get_Enfermeria(enfermeria_id);
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
        public Enfermeria()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos              
        // BOTONES
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DialogResult dialogResult = MessageBox.Show("Desea guardar el procedimiento?", "Procedimiento - Enfermeria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                                if (this.checkControlVital.Checked == false && this.checkFrecuenciaCardiaca.Checked == false && this.checkFrecuenciaRespiratoria.Checked == false 
                                && this.checkTemperatura.Checked == false && this.checkDiuresis.Checked == false && this.checkGlucemia.Checked == false
                                && this.checkMultistick.Checked == false && this.checkControlSaturacion.Checked == false && this.checkMedicion.Checked == false 
                                && this.checkEcg.Checked == false || this.txtObservacion.Text == string.Empty )
                                {
                                    MessageBox.Show("Debe seleccionar algun ítem y agregar una observación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btnGuardar.Enabled = true;
                                    btnSalir.Enabled = true;
                                    btnModificar.Enabled = false;
                                }
                                else
                                {
                                    Graba_Suministro_Procedimiento_Enfermeria();
                                    Graba_Historial_Suministro_Procedimiento_Enfermeria();
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
                        DialogResult dialogResult = MessageBox.Show("Seguro que desea supender este procedimiento?", "Procedimiento - Enfermeria", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {
                                Graba_Historial_Suministro_Procedimiento_Enfermeria();
                                Modifica_Suministro_Procedimiento_Enfermeria();
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
                    DialogResult dialogResult = MessageBox.Show("Desea modificar el procedimiento?", "Procedimiento - Enfermeria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (this.checkControlVital.Checked == false && this.checkFrecuenciaCardiaca.Checked == false && this.checkFrecuenciaRespiratoria.Checked == false
                                && this.checkTemperatura.Checked == false && this.checkDiuresis.Checked == false && this.checkGlucemia.Checked == false
                                && this.checkMultistick.Checked == false && this.checkControlSaturacion.Checked == false && this.checkMedicion.Checked == false
                                && this.checkEcg.Checked == false || this.txtObservacion.Text == string.Empty)
                            {
                                MessageBox.Show("Debe seleccionar algun ítem y agregar una observación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnGuardar.Enabled = false;
                                btnSalir.Enabled = true;
                                btnModificar.Enabled = true;
                            }
                            else
                            {
                                Graba_Historial_Suministro_Procedimiento_Enfermeria();
                                Modifica_Suministro_Procedimiento_Enfermeria();
                                    ActualizarIndicacion();
                                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);                                 
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
        // Graba en la tabla PRO_SuministroDeProcedimiento y en la PRO_Enfermeria
        public void Graba_Suministro_Procedimiento_Enfermeria()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Enfermeria")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.ENFERMERIA_ID = Convert.ToInt32(item.id+1);
                    }
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id;
                    _itemSuministro.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID= Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    // Tabla PRO_Enfermeria
                    Entities.Tables.PRO_ENFERMERIA _itemEnfermeria = new Entities.Tables.PRO_ENFERMERIA();
                    BLL.Tables.PRO_ENFERMERIA _enfermeria = new BLL.Tables.PRO_ENFERMERIA();
                    _itemEnfermeria.PACIENTE_ID = paciente_id;
                    _itemEnfermeria.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.checkControlVital.Checked) { _itemEnfermeria.CONTROLVITAL = true; } else { _itemEnfermeria.CONTROLVITAL = false; }
                    if (this.checkFrecuenciaCardiaca.Checked) { _itemEnfermeria.FRECUENCIACARDIACA = true; } else { _itemEnfermeria.FRECUENCIACARDIACA = false; }
                    if (this.checkFrecuenciaRespiratoria.Checked) { _itemEnfermeria.FRECUENCIARESPIRATORIA = true; } else { _itemEnfermeria.FRECUENCIARESPIRATORIA = false; }
                    if(this.checkTemperatura.Checked) { _itemEnfermeria.TEMPERATURAAXILAR = true; } else { _itemEnfermeria.TEMPERATURAAXILAR = false; }
                    if(this.checkDiuresis.Checked) { _itemEnfermeria.DIURESIS = true; } else { _itemEnfermeria.DIURESIS = false; }
                    if(this.checkGlucemia.Checked) { _itemEnfermeria.GLUCEMIACAPILAR = true; } else { _itemEnfermeria.GLUCEMIACAPILAR = false; }
                    if(this.checkMultistick.Checked) { _itemEnfermeria.MULTISTICKORINA = true; } else { _itemEnfermeria.MULTISTICKORINA = false; }
                    if(this.checkControlSaturacion.Checked ) { _itemEnfermeria.CONTROLSATURACION = true; } else { _itemEnfermeria.CONTROLSATURACION = false; }
                    if(this.checkMedicion.Checked ) { _itemEnfermeria.MEDICIONRESIDUOSGASTRICO = true; } else { _itemEnfermeria.MEDICIONRESIDUOSGASTRICO = false; }
                    if(this.checkEcg.Checked) { _itemEnfermeria.ECG = true; } else { _itemEnfermeria.ECG = false; }
                    _itemEnfermeria.OBSERVACION = this.txtObservacion.Text;
                    _itemEnfermeria.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemEnfermeria.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemEnfermeria.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaEnfermeria (_itemSuministro, _itemEnfermeria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Graba en la tabla PRO_Historial_SuministroDeProcedimiento y en la PRO_Historial_Enfermeria
        public void Graba_Historial_Suministro_Procedimiento_Enfermeria()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_Historial_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Historial_Enfermeria")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.ENFERMERIA_ID = Convert.ToInt32(item.id);
                    }
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id;// Enfermeria de la tabla PRO_Tipo_Procedimiento
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemSuministro.FECHABAJA = System.DateTime.Now;
                        _itemSuministro.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    _itemSuministro.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    // Tabla PRO_Historial_Enfermeria
                    Entities.Tables.PRO_HISTORIAL_ENFERMERIA _itemEnfermeria = new Entities.Tables.PRO_HISTORIAL_ENFERMERIA();
                    BLL.Tables.PRO_HISTORIAL_ENFERMERIA _enfermeria = new BLL.Tables.PRO_HISTORIAL_ENFERMERIA();
                    _itemEnfermeria.PACIENTE_ID = paciente_id;
                    _itemEnfermeria.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemEnfermeria.FECHABAJA = System.DateTime.Now;
                        _itemEnfermeria.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    if (this.checkControlVital.Checked) { _itemEnfermeria.CONTROLVITAL = true; } else { _itemEnfermeria.CONTROLVITAL = false; }
                    if (this.checkFrecuenciaCardiaca.Checked) { _itemEnfermeria.FRECUENCIACARDIACA = true; } else { _itemEnfermeria.FRECUENCIACARDIACA = false; }
                    if (this.checkFrecuenciaRespiratoria.Checked) { _itemEnfermeria.FRECUENCIARESPIRATORIA = true; } else { _itemEnfermeria.FRECUENCIARESPIRATORIA = false; }
                    if (this.checkTemperatura.Checked) { _itemEnfermeria.TEMPERATURAAXILAR = true; } else { _itemEnfermeria.TEMPERATURAAXILAR = false; }
                    if (this.checkDiuresis.Checked) { _itemEnfermeria.DIURESIS = true; } else { _itemEnfermeria.DIURESIS = false; }
                    if (this.checkGlucemia.Checked) { _itemEnfermeria.GLUCEMIACAPILAR = true; } else { _itemEnfermeria.GLUCEMIACAPILAR = false; }
                    if (this.checkMultistick.Checked) { _itemEnfermeria.MULTISTICKORINA = true; } else { _itemEnfermeria.MULTISTICKORINA = false; }
                    if (this.checkControlSaturacion.Checked) { _itemEnfermeria.CONTROLSATURACION = true; } else { _itemEnfermeria.CONTROLSATURACION = false; }
                    if (this.checkMedicion.Checked) { _itemEnfermeria.MEDICIONRESIDUOSGASTRICO = true; } else { _itemEnfermeria.MEDICIONRESIDUOSGASTRICO = false; }
                    if (this.checkEcg.Checked) { _itemEnfermeria.ECG = true; } else { _itemEnfermeria.ECG = false; }
                    _itemEnfermeria.OBSERVACION = this.txtObservacion.Text;
                    _itemEnfermeria.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemEnfermeria.FECHAALTASISTEMA = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaHistorialEnfermeria(_itemSuministro, _itemEnfermeria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Modifica_Suministro_Procedimiento_Enfermeria()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.ENFERMERIA_ID = enfermeria_id;
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
                    // Tabla PRO_Enfermeria
                    Entities.Tables.PRO_ENFERMERIA _itemEnfermeria = new Entities.Tables.PRO_ENFERMERIA();
                    BLL.Tables.PRO_ENFERMERIA _enfermeria = new BLL.Tables.PRO_ENFERMERIA();
                    _itemEnfermeria.PACIENTE_ID = paciente_id;
                    _itemEnfermeria.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemEnfermeria.FECHABAJA = System.DateTime.Now;
                        _itemEnfermeria.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    if (this.checkControlVital.Checked) { _itemEnfermeria.CONTROLVITAL = true; } else { _itemEnfermeria.CONTROLVITAL = false; }
                    if (this.checkFrecuenciaCardiaca.Checked) { _itemEnfermeria.FRECUENCIACARDIACA = true; } else { _itemEnfermeria.FRECUENCIACARDIACA = false; }
                    if (this.checkFrecuenciaRespiratoria.Checked) { _itemEnfermeria.FRECUENCIARESPIRATORIA = true; } else { _itemEnfermeria.FRECUENCIARESPIRATORIA = false; }
                    if (this.checkTemperatura.Checked) { _itemEnfermeria.TEMPERATURAAXILAR = true; } else { _itemEnfermeria.TEMPERATURAAXILAR = false; }
                    if (this.checkDiuresis.Checked) { _itemEnfermeria.DIURESIS = true; } else { _itemEnfermeria.DIURESIS = false; }
                    if (this.checkGlucemia.Checked) { _itemEnfermeria.GLUCEMIACAPILAR = true; } else { _itemEnfermeria.GLUCEMIACAPILAR = false; }
                    if (this.checkMultistick.Checked) { _itemEnfermeria.MULTISTICKORINA = true; } else { _itemEnfermeria.MULTISTICKORINA = false; }
                    if (this.checkControlSaturacion.Checked) { _itemEnfermeria.CONTROLSATURACION = true; } else { _itemEnfermeria.CONTROLSATURACION = false; }
                    if (this.checkMedicion.Checked) { _itemEnfermeria.MEDICIONRESIDUOSGASTRICO = true; } else { _itemEnfermeria.MEDICIONRESIDUOSGASTRICO = false; }
                    if (this.checkEcg.Checked) { _itemEnfermeria.ECG = true; } else { _itemEnfermeria.ECG = false; }
                    _itemEnfermeria.OBSERVACION = this.txtObservacion.Text;
                    _itemEnfermeria.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemEnfermeria.ENFERMERIA_ID = _itemSuministro.ENFERMERIA_ID;
                    _itemEnfermeria.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.ModificaEnfermeria(_itemSuministro, _itemEnfermeria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
        // Recupera Enfermeria
        private void Get_Enfermeria(int enfermeria_id)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");

                BLL.Procedures.PRO_GET_ENFERMERIA _itemEnfermeria = new BLL.Procedures.PRO_GET_ENFERMERIA();
                foreach (Entities.Procedures.PRO_GET_ENFERMERIA item in _itemEnfermeria.ItemList(enfermeria_id))
                {
                    this.checkControlVital.Checked = item.controlvital;
                    this.checkFrecuenciaCardiaca.Checked = item.frecuenciacardiaca;
                    this.checkFrecuenciaRespiratoria.Checked = item.frecuenciarespiratoria;
                    this.checkTemperatura.Checked = item.temperaturaaxilar;
                    this.checkDiuresis.Checked = item.diuresis;
                    this.checkGlucemia.Checked = item.glucemiacapilar;
                    this.checkMultistick.Checked = item.multistickorina;
                    this.checkControlSaturacion.Checked = item.controlsaturacion;
                    this.checkMedicion.Checked = item.medicionresiduosgastrico;
                    this.checkEcg.Checked = item.ecg;
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
