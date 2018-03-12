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
    public partial class CuidadoPostural : MetroForm
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

        private int cuidadoPostural_id;
        public int CuidadoPostural_Id
        {
            get
            {
                return cuidadoPostural_id;
            }
            set
            {
                this.cuidadoPostural_id = value;
            }
        }

        #endregion

        #region Inicio
        public CuidadoPostural()
        {
            InitializeComponent();
        }
        private void CuidadoPostural_Load(object sender, EventArgs e)
        {
            try
            {
                if (suministro_procedimiento_id != 0)
                {
                    Get_Cuidado_Postural(cuidadoPostural_id);
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
                    DialogResult dialogResult = MessageBox.Show("Desea guardar el procedimiento?", "Procedimiento - Cuidado Postural", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            
                                Graba_Suministro_Procedimiento_Cuidado_Postural();
                                Graba_Historial_Suministro_Procedimiento_Cuidado_Postural();
                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Opener.IActualiza();
                                this.Close();
                            
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
                        DialogResult dialogResult = MessageBox.Show("Seguro que desea supender este procedimiento?", "Procedimiento - Cuidado Postural", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {
                                Graba_Historial_Suministro_Procedimiento_Cuidado_Postural();
                                Modifica_Suministro_Procedimiento_Cuidado_Postural();
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
                        DialogResult dialogResult = MessageBox.Show("Desea modificar el procedimiento?", "Procedimiento - Cuidado Postural", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {
                                
                                    Graba_Historial_Suministro_Procedimiento_Cuidado_Postural();
                                    Modifica_Suministro_Procedimiento_Cuidado_Postural();
                                    ActualizarIndicacion();
                                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);                                  
                                    this.Close();
                                
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
        private void txtCabecera_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtRotar_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
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
        // Graba en la tabla PRO_SuministroDeProcedimiento y en la PRO_Cuidado_Postural
        public void Graba_Suministro_Procedimiento_Cuidado_Postural()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Cuidado_Postural")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.CUIDADOPOSTURAL_ID = Convert.ToInt32(item.id + 1);
                    }
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id;
                    _itemSuministro.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    // Tabla PRO_Cuidado_Postural
                    Entities.Tables.PRO_CUIDADO_POSTURAL _itemCuidadoPostural = new Entities.Tables.PRO_CUIDADO_POSTURAL();
                    BLL.Tables.PRO_CUIDADO_POSTURAL _cuidadoPostural = new BLL.Tables.PRO_CUIDADO_POSTURAL();
                    _itemCuidadoPostural.PACIENTE_ID = paciente_id;
                    _itemCuidadoPostural.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemCuidadoPostural.CABECERA = Convert.ToInt32(this.txtCabecera.Text);
                    _itemCuidadoPostural.ROTAR = Convert.ToInt32(this.txtRotar.Text);
                    if (this.radioSi.Checked == true) { _itemCuidadoPostural.MOVILIZACIONENBLOQUE = true; } else { _itemCuidadoPostural.MOVILIZACIONENBLOQUE = false; }
                    if (this.checkAlmohadon.Checked == true) { _itemCuidadoPostural.ALMOHADON = true; } else { _itemCuidadoPostural.ALMOHADON = false; }
                    if (this.checkElevadorInodoro.Checked == true) { _itemCuidadoPostural.ELEVADORINODOROS = true; } else { _itemCuidadoPostural.ELEVADORINODOROS = false; }
                    if (this.checkTrianguloSeparadorPierna.Checked == true) { _itemCuidadoPostural.TRIANGULOSEPARADORENTREPIERNA = true; } else { _itemCuidadoPostural.TRIANGULOSEPARADORENTREPIERNA = false; }
                    if (this.checkEvitarApoyoTalon.Checked == true) { _itemCuidadoPostural.EVITAAPOYOTALON = true; } else { _itemCuidadoPostural.EVITAAPOYOTALON = false; }
                    _itemCuidadoPostural.OBSERVACION = this.txtObservacion.Text;
                    _itemCuidadoPostural.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemCuidadoPostural.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemCuidadoPostural.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaCuidadoPostural(_itemSuministro, _itemCuidadoPostural);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Graba en la tabla PRO_Historial_SuministroDeProcedimiento y en la PRO_Historial_Cuidado_Postural
        public void Graba_Historial_Suministro_Procedimiento_Cuidado_Postural()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_Historial_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Historial_Cuidado_Postural")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.CUIDADOPOSTURAL_ID = Convert.ToInt32(item.id);
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
                    // Tabla PRO_Historial_Cuidado_Postural
                    Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL _itemCuidadoPostural = new Entities.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL();
                    BLL.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL _cuidadoPostural = new BLL.Tables.PRO_HISTORIAL_CUIDADO_POSTURAL();
                    _itemCuidadoPostural.PACIENTE_ID = paciente_id;
                    _itemCuidadoPostural.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemCuidadoPostural.FECHABAJA = System.DateTime.Now;
                        _itemCuidadoPostural.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    _itemCuidadoPostural.CABECERA = Convert.ToInt32(this.txtCabecera.Text);
                    _itemCuidadoPostural.ROTAR = Convert.ToInt32(this.txtRotar.Text);
                    if (this.radioSi.Checked == true) { _itemCuidadoPostural.MOVILIZACIONENBLOQUE = true; } else { _itemCuidadoPostural.MOVILIZACIONENBLOQUE = false; }
                    if (this.checkAlmohadon.Checked == true) { _itemCuidadoPostural.ALMOHADON = true; } else { _itemCuidadoPostural.ALMOHADON = false; }
                    if (this.checkElevadorInodoro.Checked == true) { _itemCuidadoPostural.ELEVADORINODOROS = true; } else { _itemCuidadoPostural.ELEVADORINODOROS = false; }
                    if (this.checkTrianguloSeparadorPierna.Checked == true) { _itemCuidadoPostural.TRIANGULOSEPARADORENTREPIERNA = true; } else { _itemCuidadoPostural.TRIANGULOSEPARADORENTREPIERNA = false; }
                    if (this.checkEvitarApoyoTalon.Checked == true) { _itemCuidadoPostural.EVITAAPOYOTALON = true; } else { _itemCuidadoPostural.EVITAAPOYOTALON = false; }
                    _itemCuidadoPostural.OBSERVACION = this.txtObservacion.Text;
                    _itemCuidadoPostural.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemCuidadoPostural.FECHAALTASISTEMA = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaHistorialCuidadoPostural(_itemSuministro, _itemCuidadoPostural);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Modifica_Suministro_Procedimiento_Cuidado_Postural()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.CUIDADOPOSTURAL_ID = cuidadoPostural_id;
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
                    // Tabla PRO_Colocacion_Cuidado_Postural
                    Entities.Tables.PRO_CUIDADO_POSTURAL _itemCuidadoPostural = new Entities.Tables.PRO_CUIDADO_POSTURAL();
                    BLL.Tables.PRO_CUIDADO_POSTURAL _cuidadoPostural = new BLL.Tables.PRO_CUIDADO_POSTURAL();
                    _itemCuidadoPostural.PACIENTE_ID = paciente_id;
                    _itemCuidadoPostural.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemCuidadoPostural.FECHABAJA = System.DateTime.Now;
                        _itemCuidadoPostural.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    _itemCuidadoPostural.CABECERA = Convert.ToInt32(this.txtCabecera.Text);
                    _itemCuidadoPostural.ROTAR = Convert.ToInt32(this.txtRotar.Text);
                    if (this.radioSi.Checked == true) { _itemCuidadoPostural.MOVILIZACIONENBLOQUE = true; } else { _itemCuidadoPostural.MOVILIZACIONENBLOQUE = false; }
                    if (this.checkAlmohadon.Checked == true) { _itemCuidadoPostural.ALMOHADON = true; } else { _itemCuidadoPostural.ALMOHADON = false; }
                    if (this.checkElevadorInodoro.Checked == true) { _itemCuidadoPostural.ELEVADORINODOROS = true; } else { _itemCuidadoPostural.ELEVADORINODOROS = false; }
                    if (this.checkTrianguloSeparadorPierna.Checked == true) { _itemCuidadoPostural.TRIANGULOSEPARADORENTREPIERNA = true; } else { _itemCuidadoPostural.TRIANGULOSEPARADORENTREPIERNA = false; }
                    if (this.checkEvitarApoyoTalon.Checked == true) { _itemCuidadoPostural.EVITAAPOYOTALON = true; } else { _itemCuidadoPostural.EVITAAPOYOTALON = false; }
                    _itemCuidadoPostural.OBSERVACION = this.txtObservacion.Text;
                    _itemCuidadoPostural.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemCuidadoPostural.CUIDADOPOSTURAL_ID = _itemSuministro.CUIDADOPOSTURAL_ID;
                    _itemCuidadoPostural.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.ModificaCuidadoPostural(_itemSuministro, _itemCuidadoPostural);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        // Recupera Cuidado Oral
        private void Get_Cuidado_Postural(int cuidadoPostura_id)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");

                BLL.Procedures.PRO_GET_CUIDADO_POSTURAL _itemCuidadoPostural = new BLL.Procedures.PRO_GET_CUIDADO_POSTURAL();
                foreach (Entities.Procedures.PRO_GET_CUIDADO_POSTURAL item in _itemCuidadoPostural.ItemList(cuidadoPostural_id))
                {
                    this.txtCabecera.Text = Convert.ToString(item.cabecera);
                    this.txtRotar.Text = Convert.ToString(item.rotar);
                    if (item.movilizacionenbloque == true) { this.radioSi.Checked  = true; } else { this.radioNo.Checked = true; }
                    if (item.almohadon == true ) { this.checkAlmohadon.Checked = true; } else { this.checkAlmohadon.Checked = false; }
                    if (item.elevadorinodoros == true) { this.checkElevadorInodoro.Checked = true; } else { this.checkElevadorInodoro.Checked = false; }
                    if (item.trianguloseparadorentrepierna == true) { this.checkTrianguloSeparadorPierna.Checked = true; } else { this.checkTrianguloSeparadorPierna.Checked = false; }
                    if (item.evitaapoyotalon == true) { this.checkEvitarApoyoTalon.Checked = true; } else { this.checkEvitarApoyoTalon.Checked = false; }
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
