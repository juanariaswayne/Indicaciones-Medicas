using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Principal.Forms.ListaEspera
{
    public partial class Frm_EgresoListaEspera : MetroForm
    {
        #region Variables
        private int _listaEsperaId;


        public int ListaEsperaId
        {
            get
            {
                return _listaEsperaId;
            }

            set
            {
                _listaEsperaId = value;
            }
        }


        SISTMEDEntities _Mod = new SISTMEDEntities();

        #endregion

        #region Funciones
        public Frm_EgresoListaEspera()
        {
            InitializeComponent();
        }

     

        private void CargarMotivosEgreso()
        {
            try
            {
                // SOLO TRAIGO LOS MOTIVOS DEL TIPO LISTA DE ESPERA
                var _listObj = (from motivo in _Mod.MotivoEgreso where motivo.tipo_id == 1 orderby motivo.Descripcion select motivo).ToList();

                MotivoEgreso _itemSeleccion = new MotivoEgreso();

                //Limpia el combo
                this.comboBoxMotivoEgreso.SuspendLayout();
                this.comboBoxMotivoEgreso.DataSource = null;
                this.comboBoxMotivoEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.Descripcion = "<Seleccione un motivo>";
                _itemSeleccion.motivoEgreso_id = 0;
                _listObj.Insert(0, _itemSeleccion);
                //Carga el combo
                this.comboBoxMotivoEgreso.DisplayMember = "Descripcion";
                this.comboBoxMotivoEgreso.ValueMember = "motivoEgreso_id";
                this.comboBoxMotivoEgreso.DataSource = _listObj;
                this.comboBoxMotivoEgreso.ResumeLayout();

                comboBoxMotivoEgreso.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaEgreos(bool ingresa)
        {
            try
            {
                if (!ingresa) //ES UNA BAJA DE LA LISTA
                {

                    if (comboBoxMotivoEgreso.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Debe seleccionar un Motivo de egreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                //if (ingresa) //INGRESA COMO PACIENTE
                //{
                //    if (comboBoxSede.SelectedIndex <= 0)
                //    {
                //        MessageBox.Show("Debe seleccionar una Sede", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //        return false;

                //    }
                //}


                return true;
            }

            catch (Exception ex)
            {

                return false;
            }


        }

   

        #endregion

        #region Eventos
        private void Frm_EgresoListaEspera_Load(object sender, EventArgs e)
        {
            comboBoxTipoEgreso.SelectedIndex = 0;
            comboBoxMotivoEgreso.Visible = false;
            labelMotivo.Visible = false;
        }





        #endregion

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTipoEgreso.SelectedIndex > 0)
                {
                    if (comboBoxTipoEgreso.SelectedIndex == 2)
                    {
                        //ES UNA BAJA DE LA LISTA... NO INGRESA COMO PACIENTE
                        if (ValidaEgreos(false))
                        {
                            MED_ListaEspera _espera = new MED_ListaEspera();
                            _espera.motivoEgreso_id = Convert.ToInt32(comboBoxMotivoEgreso.SelectedValue);
                            _espera.fechaEgreso = Convert.ToDateTime(DateTime.Now);
                            // _espera.obs = (textBoxObs.Text != string.Empty) ? textBoxObs.Text : string.Empty;
                            _espera.espera_id = _listaEsperaId;

                            //ESTAS 2 LINEAS DE ABAJO ES IMPORTANTE PARA PODER MODIFICAR SOLO ALGUNOS CAMPOS
                            _Mod.Configuration.AutoDetectChangesEnabled = false;
                            _Mod.Configuration.ValidateOnSaveEnabled = false;

                            //AHORA MARCO LOS CAMPOS QUE SE MODIFICAN
                            _Mod.MED_ListaEspera.Attach(_espera);

                            _Mod.Entry(_espera).Property(m => m.motivoEgreso_id).IsModified = true;
                            _Mod.Entry(_espera).Property(m => m.fechaEgreso).IsModified = true;

                            _Mod.SaveChanges();
                            MessageBox.Show("Egreso de lista de espera correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();

                        }

                    }
                    else
                    {
                        //ES UN INGRESO A INTERNACION, DOY DE ALTA EN TABLA PACIENTES Y PACEINTE MODULO

                        Pacientes _newPaciente = new Pacientes();
                        Clases.IndicacionesBLL.Paciente _IngresoPaciente = new Clases.IndicacionesBLL.Paciente();
                        //TRAIGO TODOS LOS DATOS DE LA LISTA DE ESPERA
                        //var _pac = _Mod.MED_ListaEspera.Where(a => a.espera_id == _listaEsperaId).SingleOrDefault();
                        var _listObj = (from lista in _Mod.MED_ListaEspera
                                        where lista.espera_id == _listaEsperaId
                                        select new
                                        {
                                            nombre = lista.nombre,
                                            apellido = lista.apellido,
                                            genero = lista.genero,
                                            fechaNacimiento = lista.fechaNacimiento,
                                            tipoDocumento_id = lista.tipoDocumento_id,
                                            numeroDocumento = lista.numeroDocumento,
                                            diagnostico_id = lista.diagnostico_id,
                                            obraSocial_id = lista.obraSocial_id,
                                            nroAfiliado = lista.nroAfiliado,
                                            listaEsperaId = lista.espera_id, //LA UTILIZO PARA ACTUALIZAR TABLA Y MARCARLA COMO EGRESO            
                                            responsable = lista.responsable,
                                            vinculo = lista.vinculo,
                                            telefonos = lista.telefonos,
                                            sede = lista.sedeSugerida,
                                            habitacion_id = lista.habitacion_id
                                        }).FirstOrDefault();

                        //PASO AL OBJETO PACIENTE
                         _newPaciente.sede_id = _listObj.sede;
                        _newPaciente.habitacion_id = _listObj.habitacion_id;
                        _newPaciente.nombre = _listObj.nombre;
                        _newPaciente.apellido = _listObj.apellido;
                        _newPaciente.genero = (_listObj.genero == "M") ? true : false; //CORREGIR EN TABLA PARA QUE ACEPTE UN CHAR
                        _newPaciente.fechaNacimiento = _listObj.fechaNacimiento;
                        _newPaciente.tipoDocumento_id = _listObj.tipoDocumento_id;
                        _newPaciente.numeroDocumento = _listObj.numeroDocumento;
                        _newPaciente.diagnostico_id = Convert.ToInt32(_listObj.diagnostico_id);
                        _newPaciente.fechaIngreso = DateTime.Now;
                        _newPaciente.obraSocial_id = _listObj.obraSocial_id;
                        _newPaciente.numeroObraSocial = _listObj.nroAfiliado;
                        _newPaciente.usuario_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                        _newPaciente.responsabe = _listObj.responsable;
                        _newPaciente.vinculo = _listObj.vinculo;
                        _newPaciente.telefono = _listObj.telefonos;

                        //AHORA TRAIGO LOS MODULOS CARGADOS PARA ESTE POSIBLE PACIENTE
                        var _pac = _Mod.MED_ListaEsperaModulo.Where(a => a.espera_id == _listaEsperaId).ToList();
                        MED_PacienteModulo _pacModulo;
                        List<MED_PacienteModulo> _listModPac = new List<MED_PacienteModulo>();
                        foreach (MED_ListaEsperaModulo item in _pac)
                        {
                            _pacModulo = new MED_PacienteModulo();
                            _pacModulo.modulo_id = item.modulo_id;
                            _listModPac.Add(_pacModulo);
                        }

                        if (_IngresoPaciente.IngresaPaciente(_newPaciente, _listModPac, _listObj.listaEsperaId))
                        {
                            MessageBox.Show("Paciente ingresado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           // EnviarMail(_listObj.listaEsperaId);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al Ingresar Paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }


                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Tipo y un Motivo de Egreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxTipoEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoEgreso.SelectedIndex == 1)
            {
                //groupBoxIngreso.Visible = true;
                labelMotivo.Visible = false;
                comboBoxMotivoEgreso.Visible = false;

                //CargarSedes();


            }
            else
            {
                CargarMotivosEgreso();

                //groupBoxIngreso.Visible = false;
                labelMotivo.Visible = true;
                comboBoxMotivoEgreso.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboHabitacionDesocupada_SelectedValueChanged(object sender, EventArgs e)
        {
            //textBoxResponsable.Focus();
        }

        private void textBoxResponsable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //textBoxVinculo.Focus();
            }
        }

        private void textBoxVinculo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //textBoxTelefonos.Focus();
            }
        }
    }
}
