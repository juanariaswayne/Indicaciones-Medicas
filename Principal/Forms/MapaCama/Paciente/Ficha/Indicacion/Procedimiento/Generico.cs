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
    public partial class Generico : MetroForm
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

        private int generico_id;
        public int Generico_Id
        {
            get
            {
                return generico_id;
            }
            set
            {
                this.generico_id = value;
            }
        }

        #endregion

        #region Inicio
        // LOAD
        private void Generico_Load(object sender, EventArgs e)
        {
            try
            {
                if (suministro_procedimiento_id != 0)
                {
                    Get_Generico(generico_id);
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
        public Generico()
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
                    DialogResult dialogResult = MessageBox.Show("Desea guardar el procedimiento?", "Procedimiento - Generico", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                           
                                Graba_Suministro_Procedimiento_Generico();
                                Graba_Historial_Suministro_Procedimiento_Generico();
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
                   if(this.txtSuspenderMotivo.Text!= String.Empty)
                    {
                        #region Suspender
                        DialogResult dialogResult = MessageBox.Show("Seguro que desea supender este procedimiento?", "Procedimiento - Generico", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        {
                            if (dialogResult == DialogResult.Yes)
                            { 
                                    Graba_Historial_Suministro_Procedimiento_Generico();
                                    Modifica_Suministro_Procedimiento_Generico();
                                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);        ;
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
                        DialogResult dialogResult = MessageBox.Show("Desea modificar el procedimiento?", "Procedimiento - Generico", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {
                               
                                    Graba_Historial_Suministro_Procedimiento_Generico();
                                    Modifica_Suministro_Procedimiento_Generico();
                                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ActualizarIndicacion();
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
        // Graba en la tabla PRO_SuministroDeProcedimiento y en la PRO_Generico
        public void Graba_Suministro_Procedimiento_Generico()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Generico")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.GENERICO_ID = Convert.ToInt32(item.id + 1);
                    }
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id;
                    _itemSuministro.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    // Tabla PRO_Generico
                    Entities.Tables.PRO_GENERICO _itemGenerico = new Entities.Tables.PRO_GENERICO();
                    BLL.Tables.PRO_GENERICO _generico = new BLL.Tables.PRO_GENERICO();
                    _itemGenerico.PACIENTE_ID = paciente_id;
                    _itemGenerico.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemGenerico.OBSERVACION = this.txtObservacion.Text;
                    _itemGenerico.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemGenerico.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemGenerico.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaGenerico(_itemSuministro, _itemGenerico);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Graba en la tabla PRO_Historial_SuministroDeProcedimiento y en la PRO_Historial_Poslogia
        public void Graba_Historial_Suministro_Procedimiento_Generico()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_Historial_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Historial_Generico")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.GENERICO_ID = Convert.ToInt32(item.id + 1);
                    }
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id;// Posologia de la tabla PRO_Tipo_Procedimiento
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemSuministro.FECHABAJA = System.DateTime.Now;
                        _itemSuministro.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    _itemSuministro.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    // Tabla PRO_Historial_Generico
                    Entities.Tables.PRO_HISTORIAL_GENERICO _itemGenerico = new Entities.Tables.PRO_HISTORIAL_GENERICO();
                    BLL.Tables.PRO_HISTORIAL_GENERICO _generico = new BLL.Tables.PRO_HISTORIAL_GENERICO();
                    _itemGenerico.PACIENTE_ID = paciente_id;
                    _itemGenerico.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemGenerico.FECHABAJA = System.DateTime.Now;
                        _itemGenerico.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    _itemGenerico.OBSERVACION = this.txtObservacion.Text;
                    _itemGenerico.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemGenerico.FECHAALTASISTEMA = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaHistorialGenerico(_itemSuministro, _itemGenerico);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Modifica_Suministro_Procedimiento_Generico()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.GENERICO_ID = generico_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id; // Generico de la tabla PRO_Tipo_Procedimiento
                    _itemSuministro.FECHAMODIFICIACION = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemSuministro.SUMINISTRODEPROCEDIMIENTO_ID = suministro_procedimiento_id;
                    if(this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemSuministro.FECHABAJA = System.DateTime.Now;
                        _itemSuministro.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    // Tabla PRO_Generico
                    Entities.Tables.PRO_GENERICO _itemGenerico = new Entities.Tables.PRO_GENERICO();
                    BLL.Tables.PRO_GENERICO _generico = new BLL.Tables.PRO_GENERICO();
                    _itemGenerico.PACIENTE_ID = paciente_id;
                    _itemGenerico.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemGenerico.FECHABAJA = System.DateTime.Now;
                        _itemGenerico.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    _itemGenerico.OBSERVACION = this.txtObservacion.Text;
                    _itemGenerico.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemGenerico.GENERICO_ID = _itemSuministro.GENERICO_ID;
                    _itemGenerico.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.ModificaGenerico(_itemSuministro, _itemGenerico);
                    //ActualizarIndicacion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        // Recupera Generico
        private void Get_Generico(int generico_id)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.PRO_GET_GENERICO _itemGenerico = new BLL.Procedures.PRO_GET_GENERICO();
                foreach (Entities.Procedures.PRO_GET_GENERICO item in _itemGenerico.ItemList(generico_id))
                {
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
