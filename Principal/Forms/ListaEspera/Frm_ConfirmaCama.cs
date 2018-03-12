using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Principal.Forms.ListaEspera
{
    public partial class Frm_ConfirmaCama : MetroForm
    {
        #region Variables
        SISTMEDEntities _Mod = new SISTMEDEntities();
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
        #endregion

        #region Funciones

        public Frm_ConfirmaCama()
        {
            InitializeComponent();
        }

        private void CargarSedes()
        {
            try
            {

                var _listObj = (from sede in _Mod.Sedes orderby sede.descripcion select sede).ToList();

                Sedes _itemSeleccion = new Sedes();

                //Limpia el combo
                this.comboBoxSede.SuspendLayout();
                this.comboBoxSede.DataSource = null;
                this.comboBoxSede.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione una Sede>";
                _itemSeleccion.sede_id = 0;
                _listObj.Insert(0, _itemSeleccion);
                //Carga el combo
                this.comboBoxSede.DisplayMember = "descripcion";
                this.comboBoxSede.ValueMember = "sede_id";
                this.comboBoxSede.DataSource = _listObj;
                this.comboBoxSede.ResumeLayout();

                comboBoxSede.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCboHabitacionDesocupada(int _sede)
        {
            try
            {
                //var restuls = db.Produtos.Where(p => p.enterpriseID == '00000000000191'
                // && p.productId != 14
                // && !db.SimilarProducts.Any(sp => sp.SimilarId == p.productId));

                //select* from Habitaciones
                //where not exists (select * from Pacientes where Habitaciones.habitacion_id = Pacientes.habitacion_id AND
                //Habitaciones.sede_id = Pacientes.sede_id AND Pacientes.habitacion_id <> -1)
                //AND Habitaciones.sede_id = 1 AND Habitaciones.habitacion_id <> -1

                //USO DEL NOT EXISTS
                var _listObj = (_Mod.Habitaciones.Where(h => h.sede_id == _sede && h.habitacion_id != -1 && !_Mod.Pacientes.Any(p => p.habitacion_id == h.habitacion_id
                && p.sede_id == h.sede_id && p.habitacion_id != -1))).ToList();

                Habitaciones _itemSeleccion = new Habitaciones();

                //Limpia el combo
                this.cboHabitacionDesocupada.SuspendLayout();
                this.cboHabitacionDesocupada.DataSource = null;
                this.cboHabitacionDesocupada.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.habitacion_id = 0;
                _listObj.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboHabitacionDesocupada.DisplayMember = "descripcion";
                this.cboHabitacionDesocupada.ValueMember = "habitacion_id";
                this.cboHabitacionDesocupada.DataSource = _listObj;
                this.cboHabitacionDesocupada.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarSectoresEnvioMail(int _sede)
        {
            try
            {
               

                //USO DEL NOT EXISTS
                var _listObj = (_Mod.MED_SectorMails.Where (S=> S.sede_id == _sede)).ToList();

                MED_SectorMails _itemSeleccion = new MED_SectorMails();

                //Limpia el combo
                this.comboBoxSectorMail.SuspendLayout();
                this.comboBoxSectorMail.DataSource = null;
                this.comboBoxSectorMail.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione Sector de Ingreso>";
                _itemSeleccion.sector_id = 0;
                _listObj.Insert(0, _itemSeleccion);
                //Carga el combo
                this.comboBoxSectorMail.DisplayMember = "descripcion";
                this.comboBoxSectorMail.ValueMember = "sector_id";
                this.comboBoxSectorMail.DataSource = _listObj;
                this.comboBoxSectorMail.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaConfirmacion()
        {
            try
            {
            
                    if (comboBoxSede.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Debe seleccionar una Sede", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }


                if (comboBoxSectorMail.SelectedIndex <= 0)
                {
                    MessageBox.Show("Debe seleccionar una Sector para el envío de Mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        private void EnviarMail(int espera_id)
        {
            try
            {
                //VERIFICO SI TIENE ARCHIVOS ADJUNTOS..
                string _adjuntos = string.Empty;
                string pathString = System.IO.Path.Combine(@"\\192.168.2.50\\Indicaciones Medicas\\AdjuntosListaEspera\\", espera_id.ToString()); //ENVIO EL DIRECTORIO PARA LLEER LOS ARCHIVOS CARGADOS

                if (Directory.Exists(pathString))
                {
                    DirectoryInfo di = new DirectoryInfo(pathString);
                   

                    foreach (var fi in di.GetFiles())
                    {
                        if (_adjuntos == string.Empty)
                        {
                            _adjuntos = fi.FullName.ToString(); //PATH COMPLETO 
                        }

                        else
                        {
                            _adjuntos = _adjuntos.ToString() + ";" + fi.FullName.ToString(); //PATH COMPLETO 
                           
                        }                      
                    }


                }
                else
                {
                    MessageBox.Show("Este paciente no tiene archivos adjuntos asociados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                //FIN ARCHIVOS ADJUNTOS

                // _Mod.EnviaMailNuevoIngreso(espera_id, TextBoxObs.Text, Convert.ToInt32(comboBoxSectorMail.SelectedValue), _adjuntos);
                _Mod.Database.ExecuteSqlCommand("EnviaMailNuevoIngreso @espera_id,@Obs,@sectorMail,@adjuntos",
                 new SqlParameter("@espera_id", espera_id),
                  new SqlParameter("@Obs", TextBoxObs.Text),
                  new SqlParameter("@sectorMail", Convert.ToInt32(comboBoxSectorMail.SelectedValue)),
                   new SqlParameter("@adjuntos", _adjuntos));
            


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void Frm_ConfirmaCama_Load(object sender, EventArgs e)
        {
            dateTimePickerConfirma.Value = DateTime.Now;
            CargarSedes();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSede.SelectedIndex > 0)
            {

                CargarCboHabitacionDesocupada(Convert.ToInt32(comboBoxSede.SelectedValue));
                CargarSectoresEnvioMail(Convert.ToInt32(comboBoxSede.SelectedValue));//CARGO LOS SECTORES A LOS CUALES VA EL MAIL

                textBoxResponsable.Focus();
            }



        }

        private void textBoxResponsable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxVinculo.Focus();
            }
        }

        private void textBoxVinculo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxTelefonos.Focus();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidaConfirmacion())
                {
                    MED_ListaEspera _espera = new MED_ListaEspera();
                    _espera.confirmaCama = true;
                    _espera.espera_id = _listaEsperaId;
                    _espera.sedeSugerida = Convert.ToInt32(comboBoxSede.SelectedValue);
                    _espera.responsable = textBoxResponsable.Text;
                    _espera.vinculo = textBoxVinculo.Text;
                    _espera.telefonos = textBoxTelefonos.Text;
                    _espera.fechaConfirmacionCama = dateTimePickerConfirma.Value;
                    if(cboHabitacionDesocupada.SelectedIndex > 0)
                    {
                        _espera.habitacion_id = Convert.ToInt32(cboHabitacionDesocupada.SelectedValue);
                    }

                    //ESTAS 2 LINEAS DE ABAJO ES IMPORTANTE PARA PODER MODIFICAR SOLO ALGUNOS CAMPOS
                    _Mod.Configuration.AutoDetectChangesEnabled = false;
                    _Mod.Configuration.ValidateOnSaveEnabled = false;

                    //AHORA MARCO LOS CAMPOS QUE SE MODIFICAN
                    _Mod.MED_ListaEspera.Attach(_espera);

                    _Mod.Entry(_espera).Property(m => m.confirmaCama).IsModified = true;
                    _Mod.Entry(_espera).Property(m => m.sedeSugerida).IsModified = true;
                    _Mod.Entry(_espera).Property(m => m.responsable).IsModified = true;
                    _Mod.Entry(_espera).Property(m => m.vinculo).IsModified = true;
                    _Mod.Entry(_espera).Property(m => m.telefonos).IsModified = true;
                    _Mod.Entry(_espera).Property(m => m.fechaConfirmacionCama).IsModified = true;
                    if (cboHabitacionDesocupada.SelectedIndex > 0)
                    {
                        _Mod.Entry(_espera).Property(m => m.habitacion_id).IsModified = true;
                    }

                    _Mod.SaveChanges();
                    MessageBox.Show("Cama confirmada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EnviarMail(_listaEsperaId);
                    Close();


                }

            }

            catch(Exception ex)

            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

      
    }
}
