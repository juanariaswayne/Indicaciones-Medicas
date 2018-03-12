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
    public partial class ProteccionFisica : MetroForm
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

        private int proteccionFisica_id;
        public int ProteccionFisica_Id
        {
            get
            {
                return proteccionFisica_id;
            }
            set
            {
                this.proteccionFisica_id = value;
            }
        }

        #endregion

        #region Inicio
        public ProteccionFisica()
        {
            InitializeComponent();
        }
        private void ProteccionFisica_Load(object sender, EventArgs e)
        {
            try
            {
                if (suministro_procedimiento_id != 0)
                {
                    Get_Proteccion_Fisica(proteccionFisica_id);
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
                    DialogResult dialogResult = MessageBox.Show("Desea guardar el procedimiento?", "Procedimiento - Protección Fisica", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                                Graba_Suministro_Procedimiento_Proteccion_Fisica();
                                Graba_Historial_Suministro_Procedimiento_Proteccion_Fisica();
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
                        DialogResult dialogResult = MessageBox.Show("Seguro que desea supender este procedimiento?", "Procedimiento - Protección Fisica", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {
                                Graba_Historial_Suministro_Procedimiento_Proteccion_Fisica();
                                Modifica_Suministro_Procedimiento_Proteccion_Fisica();
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
                        DialogResult dialogResult = MessageBox.Show("Desea modificar el procedimiento?", "Procedimiento - Protección Fisica", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                                    Graba_Historial_Suministro_Procedimiento_Proteccion_Fisica();
                                    Modifica_Suministro_Procedimiento_Proteccion_Fisica();
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
        // Graba en la tabla PRO_SuministroDeProcedimiento y en la PRO_Proteccion_Fisica
        public void Graba_Suministro_Procedimiento_Proteccion_Fisica()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Proteccion_Fisica")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.PROTECCIONFISICA_ID = Convert.ToInt32(item.id + 1);
                    }
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id;
                    _itemSuministro.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    // Tabla PRO_Proteccion_Fisica
                    Entities.Tables.PRO_PROTECCION_FISICA _itemProteccionFisica = new Entities.Tables.PRO_PROTECCION_FISICA();
                    BLL.Tables.PRO_PROTECCION_FISICA _proteccionFisica = new BLL.Tables.PRO_PROTECCION_FISICA();
                    _itemProteccionFisica.PACIENTE_ID = paciente_id;
                    _itemProteccionFisica.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.radioDeTronco.Checked == true) { _itemProteccionFisica.CONTENCIONFISICA = true; } else { _itemProteccionFisica.CONTENCIONFISICA = false; }
                    if (this.checkColchonAire.Checked == true) { _itemProteccionFisica.COLCHONAIRE = true; } else { _itemProteccionFisica.COLCHONAIRE = false; }
                    if (this.checkBarandaTrabaCama.Checked == true) { _itemProteccionFisica.BARANDASCAMA = true; } else { _itemProteccionFisica.BARANDASCAMA = false; }
                    if (this.checkCascoProteccion.Checked == true) { _itemProteccionFisica.CASCOPROTECCION = true; } else { _itemProteccionFisica.CASCOPROTECCION = false; }
                    if (this.checkChiripaSilla.Checked == true) { _itemProteccionFisica.CHIRIPASILLA = true; } else { _itemProteccionFisica.CHIRIPASILLA = false; }
                    _itemProteccionFisica.OBSERVACION = this.txtObservacion.Text;
                    _itemProteccionFisica.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemProteccionFisica.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemProteccionFisica.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaProteccionFisica(_itemSuministro, _itemProteccionFisica);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Graba en la tabla PRO_Historial_SuministroDeProcedimiento y en la PRO_Historial_Proteccion_Fisica
        public void Graba_Historial_Suministro_Procedimiento_Proteccion_Fisica()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_Historial_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Historial_Proteccion_Fisica")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.PROTECCIONFISICA_ID = Convert.ToInt32(item.id);
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
                    // Tabla PRO_Historial_Proteccion_Fisica
                    Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA _itemProteccionFisica = new Entities.Tables.PRO_HISTORIAL_PROTECCION_FISICA();
                    BLL.Tables.PRO_HISTORIAL_PROTECCION_FISICA _proteccionFisica = new BLL.Tables.PRO_HISTORIAL_PROTECCION_FISICA();
                    _itemProteccionFisica.PACIENTE_ID = paciente_id;
                    _itemProteccionFisica.PROCEDIMIENTO_ID = procedimiento_id;

                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemProteccionFisica.FECHABAJA = System.DateTime.Now;
                        _itemProteccionFisica.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    if (this.radioDeTronco.Checked == true) { _itemProteccionFisica.CONTENCIONFISICA = true; } else { _itemProteccionFisica.CONTENCIONFISICA = false; }
                    if (this.checkColchonAire.Checked == true) { _itemProteccionFisica.COLCHONAIRE = true; } else { _itemProteccionFisica.COLCHONAIRE = false; }
                    if (this.checkBarandaTrabaCama.Checked == true) { _itemProteccionFisica.BARANDASCAMA = true; } else { _itemProteccionFisica.BARANDASCAMA = false; }
                    if (this.checkCascoProteccion.Checked == true) { _itemProteccionFisica.CASCOPROTECCION = true; } else { _itemProteccionFisica.CASCOPROTECCION = false; }
                    if (this.checkChiripaSilla.Checked == true) { _itemProteccionFisica.CHIRIPASILLA = true; } else { _itemProteccionFisica.CHIRIPASILLA = false; }
                    _itemProteccionFisica.OBSERVACION = this.txtObservacion.Text;
                    _itemProteccionFisica.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemProteccionFisica.FECHAALTASISTEMA = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaHistorialProteccionFisica(_itemSuministro, _itemProteccionFisica);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Modifica_Suministro_Procedimiento_Proteccion_Fisica()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PROTECCIONFISICA_ID = proteccionFisica_id;
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
                    // Tabla PRO_Colocacion_Proteccion_Fisica
                    Entities.Tables.PRO_PROTECCION_FISICA _itemProteccionFisica = new Entities.Tables.PRO_PROTECCION_FISICA();
                    BLL.Tables.PRO_PROTECCION_FISICA _proteccionFisica = new BLL.Tables.PRO_PROTECCION_FISICA();
                    _itemProteccionFisica.PACIENTE_ID = paciente_id;
                    _itemProteccionFisica.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemProteccionFisica.FECHABAJA = System.DateTime.Now;
                        _itemProteccionFisica.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    if (this.radioDeTronco.Checked == true) { _itemProteccionFisica.CONTENCIONFISICA = true; } else { _itemProteccionFisica.CONTENCIONFISICA = false; }
                    if (this.checkColchonAire.Checked == true) { _itemProteccionFisica.COLCHONAIRE = true; } else { _itemProteccionFisica.COLCHONAIRE = false; }
                    if (this.checkBarandaTrabaCama.Checked == true) { _itemProteccionFisica.BARANDASCAMA = true; } else { _itemProteccionFisica.BARANDASCAMA = false; }
                    if (this.checkCascoProteccion.Checked == true) { _itemProteccionFisica.CASCOPROTECCION = true; } else { _itemProteccionFisica.CASCOPROTECCION = false; }
                    if (this.checkChiripaSilla.Checked == true) { _itemProteccionFisica.CHIRIPASILLA = true; } else { _itemProteccionFisica.CHIRIPASILLA = false; }
                    _itemProteccionFisica.OBSERVACION = this.txtObservacion.Text;
                    _itemProteccionFisica.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemProteccionFisica.PROTECCIONFISICA_ID = _itemSuministro.PROTECCIONFISICA_ID;
                    _itemProteccionFisica.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.ModificaProteccionFisica(_itemSuministro, _itemProteccionFisica);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        // Recupera Cuidado Oral
        private void Get_Proteccion_Fisica(int proteccionFisica_id)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");

                BLL.Procedures.PRO_GET_PROTECCION_FISICA _itemProteccionFisica = new BLL.Procedures.PRO_GET_PROTECCION_FISICA();
                foreach (Entities.Procedures.PRO_GET_PROTECCION_FISICA item in _itemProteccionFisica.ItemList(proteccionFisica_id))
                {
                    if (item.contencionfisica == true) { this.radioDeTronco.Checked = true; } else { this.radioDeMiembro.Checked = true; }
                    if (item.colchonaire == true) { this.checkColchonAire.Checked = true; } else { this.checkColchonAire.Checked = false; }
                    if (item.barandascama == true) { this.checkBarandaTrabaCama.Checked = true; } else { this.checkBarandaTrabaCama.Checked = false; }
                    if (item.cascoproteccion == true) { this.checkCascoProteccion.Checked = true; } else { this.checkCascoProteccion.Checked = false; }
                    if (item.chiripasilla == true) { this.checkChiripaSilla.Checked = true; } else { this.checkChiripaSilla.Checked = false; }
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
