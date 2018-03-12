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
    public partial class CuidadoOral : MetroForm
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

        private int cuidadoOral_id;
        public int CuidadoOral_Id
        {
            get
            {
                return cuidadoOral_id;
            }
            set
            {
                this.cuidadoOral_id = value;
            }
        }

        #endregion

        #region Inicio
        public CuidadoOral()
        {
            InitializeComponent();
        }
        private void CuidadoOral_Load(object sender, EventArgs e)
        {
            try
            {
                if (suministro_procedimiento_id != 0)
                {
                    Get_Cuidado_Oral(cuidadoOral_id);
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
        // BOTONES
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DialogResult dialogResult = MessageBox.Show("Desea guardar el procedimiento?", "Procedimiento - Cuidado Oral", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                                Graba_Suministro_Procedimiento_Cuidado_Oral();
                                Graba_Historial_Suministro_Procedimiento_Cuidado_Oral();
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
                        DialogResult dialogResult = MessageBox.Show("Seguro que desea supender este procedimiento?", "Procedimiento - Cuidado Oral", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {
                                Graba_Historial_Suministro_Procedimiento_Cuidado_Oral();
                                Modifica_Suministro_Procedimiento_Cuidado_Oral();
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
                        DialogResult dialogResult = MessageBox.Show("Desea modificar el procedimiento?", "Procedimiento - Cuidado Oral", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                                    Graba_Historial_Suministro_Procedimiento_Cuidado_Oral();
                                    Modifica_Suministro_Procedimiento_Cuidado_Oral();
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
        // Graba en la tabla PRO_SuministroDeProcedimiento y en la PRO_Cuidado_Oral
        public void Graba_Suministro_Procedimiento_Cuidado_Oral()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_CuidadoOral")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.CUIDADOORAL_ID = Convert.ToInt32(item.id + 1);
                    }
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id;
                    _itemSuministro.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    // Tabla PRO_Cuidado_Oral
                    Entities.Tables.PRO_CUIDADO_ORAL _itemCuidadoOral = new Entities.Tables.PRO_CUIDADO_ORAL();
                    BLL.Tables.PRO_CUIDADO_ORAL _cuidadoOral = new BLL.Tables.PRO_CUIDADO_ORAL();
                    _itemCuidadoOral.PACIENTE_ID = paciente_id;
                    _itemCuidadoOral.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.radioPermanente.Checked == true) { _itemCuidadoOral.PLACADESCANSO = true; } else { _itemCuidadoOral.PLACADESCANSO = false; }
                    if (this.checkMordillo.Checked == true) { _itemCuidadoOral.MORDILLO = true; } else { _itemCuidadoOral.MORDILLO = false; }
                    if (this.checkConClorhexidina2.Checked == true) { _itemCuidadoOral.CLORHEXIDINA = true; } else { _itemCuidadoOral.CLORHEXIDINA = false; }
                    if (this.check08.Checked) { _itemCuidadoOral.HS_08 = true; } else { _itemCuidadoOral.HS_08 = false; }
                    if (this.check09.Checked) { _itemCuidadoOral.HS_09 = true; } else { _itemCuidadoOral.HS_09 = false; }
                    if (this.check10.Checked) { _itemCuidadoOral.HS_10 = true; } else { _itemCuidadoOral.HS_10 = false; }
                    if (this.check11.Checked) { _itemCuidadoOral.HS_11 = true; } else { _itemCuidadoOral.HS_11 = false; }
                    if (this.check12.Checked) { _itemCuidadoOral.HS_12 = true; } else { _itemCuidadoOral.HS_12 = false; }
                    if (this.check13.Checked) { _itemCuidadoOral.HS_13 = true; } else { _itemCuidadoOral.HS_13 = false; }
                    if (this.check14.Checked) { _itemCuidadoOral.HS_14 = true; } else { _itemCuidadoOral.HS_14 = false; }
                    if (this.check15.Checked) { _itemCuidadoOral.HS_15 = true; } else { _itemCuidadoOral.HS_15 = false; }
                    if (this.check16.Checked) { _itemCuidadoOral.HS_16 = true; } else { _itemCuidadoOral.HS_16 = false; }
                    if (this.check17.Checked) { _itemCuidadoOral.HS_17 = true; } else { _itemCuidadoOral.HS_17 = false; }
                    if (this.check18.Checked) { _itemCuidadoOral.HS_18 = true; } else { _itemCuidadoOral.HS_18 = false; }
                    if (this.check19.Checked) { _itemCuidadoOral.HS_19 = true; } else { _itemCuidadoOral.HS_19 = false; }
                    if (this.check20.Checked) { _itemCuidadoOral.HS_20 = true; } else { _itemCuidadoOral.HS_20 = false; }
                    if (this.check21.Checked) { _itemCuidadoOral.HS_21 = true; } else { _itemCuidadoOral.HS_21 = false; }
                    if (this.check22.Checked) { _itemCuidadoOral.HS_22 = true; } else { _itemCuidadoOral.HS_22 = false; }
                    if (this.check23.Checked) { _itemCuidadoOral.HS_23 = true; } else { _itemCuidadoOral.HS_23 = false; }
                    if (this.check24.Checked) { _itemCuidadoOral.HS_24 = true; } else { _itemCuidadoOral.HS_24 = false; }
                    if (this.check01.Checked) { _itemCuidadoOral.HS_01 = true; } else { _itemCuidadoOral.HS_01 = false; }
                    if (this.check02.Checked) { _itemCuidadoOral.HS_02 = true; } else { _itemCuidadoOral.HS_02 = false; }
                    if (this.check03.Checked) { _itemCuidadoOral.HS_03 = true; } else { _itemCuidadoOral.HS_03 = false; }
                    if (this.check04.Checked) { _itemCuidadoOral.HS_04 = true; } else { _itemCuidadoOral.HS_04 = false; }
                    if (this.check05.Checked) { _itemCuidadoOral.HS_05 = true; } else { _itemCuidadoOral.HS_05 = false; }
                    if (this.check06.Checked) { _itemCuidadoOral.HS_06 = true; } else { _itemCuidadoOral.HS_06 = false; }
                    if (this.check07.Checked) { _itemCuidadoOral.HS_07 = true; } else { _itemCuidadoOral.HS_07 = false; }
                    _itemCuidadoOral.OBSERVACION = this.txtObservacion.Text;
                    _itemCuidadoOral.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemCuidadoOral.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemCuidadoOral.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaCuidadoOral(_itemSuministro, _itemCuidadoOral);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Graba en la tabla PRO_Historial_SuministroDeProcedimiento y en la PRO_Historial_Cuidado_Oral
        public void Graba_Historial_Suministro_Procedimiento_Cuidado_Oral()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_Historial_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Historial_Cuidado_Oral")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.CUIDADOORAL_ID = Convert.ToInt32(item.id);
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
                    // Tabla PRO_Historial_Cuidado_Oral
                    Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL _itemCuidadoOral = new Entities.Tables.PRO_HISTORIAL_CUIDADO_ORAL();
                    BLL.Tables.PRO_HISTORIAL_CUIDADO_ORAL _cuidadoOral = new BLL.Tables.PRO_HISTORIAL_CUIDADO_ORAL();
                    _itemCuidadoOral.PACIENTE_ID = paciente_id;
                    _itemCuidadoOral.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemCuidadoOral.FECHABAJA = System.DateTime.Now;
                        _itemCuidadoOral.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    if (this.radioPermanente.Checked == true) { _itemCuidadoOral.PLACADESCANSO = true; } else { _itemCuidadoOral.PLACADESCANSO = false; }
                    if (this.checkMordillo.Checked == true) { _itemCuidadoOral.MORDILLO = true; } else { _itemCuidadoOral.MORDILLO = false; }
                    if (this.checkConClorhexidina2.Checked == true) { _itemCuidadoOral.CLORHEXIDINA = true; } else { _itemCuidadoOral.CLORHEXIDINA = false; }
                    if (this.check08.Checked) { _itemCuidadoOral.HS_08 = true; } else { _itemCuidadoOral.HS_08 = false; }
                    if (this.check09.Checked) { _itemCuidadoOral.HS_09 = true; } else { _itemCuidadoOral.HS_09 = false; }
                    if (this.check10.Checked) { _itemCuidadoOral.HS_10 = true; } else { _itemCuidadoOral.HS_10 = false; }
                    if (this.check11.Checked) { _itemCuidadoOral.HS_11 = true; } else { _itemCuidadoOral.HS_11 = false; }
                    if (this.check12.Checked) { _itemCuidadoOral.HS_12 = true; } else { _itemCuidadoOral.HS_12 = false; }
                    if (this.check13.Checked) { _itemCuidadoOral.HS_13 = true; } else { _itemCuidadoOral.HS_13 = false; }
                    if (this.check14.Checked) { _itemCuidadoOral.HS_14 = true; } else { _itemCuidadoOral.HS_14 = false; }
                    if (this.check15.Checked) { _itemCuidadoOral.HS_15 = true; } else { _itemCuidadoOral.HS_15 = false; }
                    if (this.check16.Checked) { _itemCuidadoOral.HS_16 = true; } else { _itemCuidadoOral.HS_16 = false; }
                    if (this.check17.Checked) { _itemCuidadoOral.HS_17 = true; } else { _itemCuidadoOral.HS_17 = false; }
                    if (this.check18.Checked) { _itemCuidadoOral.HS_18 = true; } else { _itemCuidadoOral.HS_18 = false; }
                    if (this.check19.Checked) { _itemCuidadoOral.HS_19 = true; } else { _itemCuidadoOral.HS_19 = false; }
                    if (this.check20.Checked) { _itemCuidadoOral.HS_20 = true; } else { _itemCuidadoOral.HS_20 = false; }
                    if (this.check21.Checked) { _itemCuidadoOral.HS_21 = true; } else { _itemCuidadoOral.HS_21 = false; }
                    if (this.check22.Checked) { _itemCuidadoOral.HS_22 = true; } else { _itemCuidadoOral.HS_22 = false; }
                    if (this.check23.Checked) { _itemCuidadoOral.HS_23 = true; } else { _itemCuidadoOral.HS_23 = false; }
                    if (this.check24.Checked) { _itemCuidadoOral.HS_24 = true; } else { _itemCuidadoOral.HS_24 = false; }
                    if (this.check01.Checked) { _itemCuidadoOral.HS_01 = true; } else { _itemCuidadoOral.HS_01 = false; }
                    if (this.check02.Checked) { _itemCuidadoOral.HS_02 = true; } else { _itemCuidadoOral.HS_02 = false; }
                    if (this.check03.Checked) { _itemCuidadoOral.HS_03 = true; } else { _itemCuidadoOral.HS_03 = false; }
                    if (this.check04.Checked) { _itemCuidadoOral.HS_04 = true; } else { _itemCuidadoOral.HS_04 = false; }
                    if (this.check05.Checked) { _itemCuidadoOral.HS_05 = true; } else { _itemCuidadoOral.HS_05 = false; }
                    if (this.check06.Checked) { _itemCuidadoOral.HS_06 = true; } else { _itemCuidadoOral.HS_06 = false; }
                    if (this.check07.Checked) { _itemCuidadoOral.HS_07 = true; } else { _itemCuidadoOral.HS_07 = false; }
                    _itemCuidadoOral.OBSERVACION = this.txtObservacion.Text;
                    _itemCuidadoOral.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemCuidadoOral.FECHAALTASISTEMA = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaHistorialCuidadoOral(_itemSuministro, _itemCuidadoOral);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Modifica_Suministro_Procedimiento_Cuidado_Oral()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.CUIDADOORAL_ID = cuidadoOral_id;
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
                    // Tabla PRO_Colocacion_Cuidado_Oral
                    Entities.Tables.PRO_CUIDADO_ORAL _itemCuidadoOral = new Entities.Tables.PRO_CUIDADO_ORAL();
                    BLL.Tables.PRO_CUIDADO_ORAL _cuidadoOral = new BLL.Tables.PRO_CUIDADO_ORAL();
                    _itemCuidadoOral.PACIENTE_ID = paciente_id;
                    _itemCuidadoOral.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemCuidadoOral.FECHABAJA = System.DateTime.Now;
                        _itemCuidadoOral.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    if (this.radioPermanente.Checked == true) { _itemCuidadoOral.PLACADESCANSO = true; } else { _itemCuidadoOral.PLACADESCANSO = false; }
                    if (this.checkMordillo.Checked == true) { _itemCuidadoOral.MORDILLO = true; } else { _itemCuidadoOral.MORDILLO = false; }
                    if (this.checkConClorhexidina2.Checked == true) { _itemCuidadoOral.CLORHEXIDINA = true; } else { _itemCuidadoOral.CLORHEXIDINA = false; }
                    if (this.check08.Checked) { _itemCuidadoOral.HS_08 = true; } else { _itemCuidadoOral.HS_08 = false; }
                    if (this.check09.Checked) { _itemCuidadoOral.HS_09 = true; } else { _itemCuidadoOral.HS_09 = false; }
                    if (this.check10.Checked) { _itemCuidadoOral.HS_10 = true; } else { _itemCuidadoOral.HS_10 = false; }
                    if (this.check11.Checked) { _itemCuidadoOral.HS_11 = true; } else { _itemCuidadoOral.HS_11 = false; }
                    if (this.check12.Checked) { _itemCuidadoOral.HS_12 = true; } else { _itemCuidadoOral.HS_12 = false; }
                    if (this.check13.Checked) { _itemCuidadoOral.HS_13 = true; } else { _itemCuidadoOral.HS_13 = false; }
                    if (this.check14.Checked) { _itemCuidadoOral.HS_14 = true; } else { _itemCuidadoOral.HS_14 = false; }
                    if (this.check15.Checked) { _itemCuidadoOral.HS_15 = true; } else { _itemCuidadoOral.HS_15 = false; }
                    if (this.check16.Checked) { _itemCuidadoOral.HS_16 = true; } else { _itemCuidadoOral.HS_16 = false; }
                    if (this.check17.Checked) { _itemCuidadoOral.HS_17 = true; } else { _itemCuidadoOral.HS_17 = false; }
                    if (this.check18.Checked) { _itemCuidadoOral.HS_18 = true; } else { _itemCuidadoOral.HS_18 = false; }
                    if (this.check19.Checked) { _itemCuidadoOral.HS_19 = true; } else { _itemCuidadoOral.HS_19 = false; }
                    if (this.check20.Checked) { _itemCuidadoOral.HS_20 = true; } else { _itemCuidadoOral.HS_20 = false; }
                    if (this.check21.Checked) { _itemCuidadoOral.HS_21 = true; } else { _itemCuidadoOral.HS_21 = false; }
                    if (this.check22.Checked) { _itemCuidadoOral.HS_22 = true; } else { _itemCuidadoOral.HS_22 = false; }
                    if (this.check23.Checked) { _itemCuidadoOral.HS_23 = true; } else { _itemCuidadoOral.HS_23 = false; }
                    if (this.check24.Checked) { _itemCuidadoOral.HS_24 = true; } else { _itemCuidadoOral.HS_24 = false; }
                    if (this.check01.Checked) { _itemCuidadoOral.HS_01 = true; } else { _itemCuidadoOral.HS_01 = false; }
                    if (this.check02.Checked) { _itemCuidadoOral.HS_02 = true; } else { _itemCuidadoOral.HS_02 = false; }
                    if (this.check03.Checked) { _itemCuidadoOral.HS_03 = true; } else { _itemCuidadoOral.HS_03 = false; }
                    if (this.check04.Checked) { _itemCuidadoOral.HS_04 = true; } else { _itemCuidadoOral.HS_04 = false; }
                    if (this.check05.Checked) { _itemCuidadoOral.HS_05 = true; } else { _itemCuidadoOral.HS_05 = false; }
                    if (this.check06.Checked) { _itemCuidadoOral.HS_06 = true; } else { _itemCuidadoOral.HS_06 = false; }
                    if (this.check07.Checked) { _itemCuidadoOral.HS_07 = true; } else { _itemCuidadoOral.HS_07 = false; }
                    _itemCuidadoOral.OBSERVACION = this.txtObservacion.Text;
                    _itemCuidadoOral.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemCuidadoOral.CUIDADOORAL_ID = _itemSuministro.CUIDADOORAL_ID;
                    _itemCuidadoOral.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.ModificaCuidadoOral(_itemSuministro, _itemCuidadoOral);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        // Recupera Cuidado Oral
        private void Get_Cuidado_Oral(int cuidadoOral_id)
        {
            try
            {
                //CultureInfo culture = new CultureInfo("en-US");

                BLL.Procedures.PRO_GET_CUIDADO_ORAL _itemCuidadoOral = new BLL.Procedures.PRO_GET_CUIDADO_ORAL();
                foreach (Entities.Procedures.PRO_GET_CUIDADO_ORAL item in _itemCuidadoOral.ItemList(cuidadoOral_id))
                {
                    if (item.placadescanso == true) { this.radioPermanente.Checked = true; } else { this.radioNocturna.Checked = true; }
                    if (item.mordillo == true) { this.checkMordillo.Checked = true; } else { this.checkMordillo.Checked = false; }
                    if (item.clorhexidina == true) { this.checkConClorhexidina2.Checked = true; } else { this.checkConClorhexidina2.Checked = false; }
                    if (item.hs_08 == true) { this.check08.Checked = true; } else { this.check08.Checked = false; }
                    if (item.hs_09 == true) { this.check09.Checked = true; } else { this.check09.Checked = false; }
                    if (item.hs_10 == true) { this.check10.Checked = true; } else { this.check10.Checked = false; }
                    if (item.hs_11 == true) { this.check11.Checked = true; } else { this.check11.Checked = false; }
                    if (item.hs_12 == true) { this.check12.Checked = true; } else { this.check12.Checked = false; }
                    if (item.hs_13 == true) { this.check13.Checked = true; } else { this.check13.Checked = false; }
                    if (item.hs_14 == true) { this.check14.Checked = true; } else { this.check14.Checked = false; }
                    if (item.hs_15 == true) { this.check15.Checked = true; } else { this.check15.Checked = false; }
                    if (item.hs_16 == true) { this.check16.Checked = true; } else { this.check16.Checked = false; }
                    if (item.hs_17 == true) { this.check17.Checked = true; } else { this.check17.Checked = false; }
                    if (item.hs_18 == true) { this.check18.Checked = true; } else { this.check18.Checked = false; }
                    if (item.hs_19 == true) { this.check19.Checked = true; } else { this.check19.Checked = false; }
                    if (item.hs_20 == true) { this.check20.Checked = true; } else { this.check20.Checked = false; }
                    if (item.hs_21 == true) { this.check21.Checked = true; } else { this.check21.Checked = false; }
                    if (item.hs_22 == true) { this.check22.Checked = true; } else { this.check22.Checked = false; }
                    if (item.hs_23 == true) { this.check23.Checked = true; } else { this.check23.Checked = false; }
                    if (item.hs_24 == true) { this.check24.Checked = true; } else { this.check24.Checked = false; }
                    if (item.hs_01 == true) { this.check01.Checked = true; } else { this.check01.Checked = false; }
                    if (item.hs_02 == true) { this.check02.Checked = true; } else { this.check02.Checked = false; }
                    if (item.hs_03 == true) { this.check03.Checked = true; } else { this.check03.Checked = false; }
                    if (item.hs_04 == true) { this.check04.Checked = true; } else { this.check04.Checked = false; }
                    if (item.hs_05 == true) { this.check05.Checked = true; } else { this.check05.Checked = false; }
                    if (item.hs_06 == true) { this.check06.Checked = true; } else { this.check06.Checked = false; }
                    if (item.hs_07 == true) { this.check07.Checked = true; } else { this.check07.Checked = false; }
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
