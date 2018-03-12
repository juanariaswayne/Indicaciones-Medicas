using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Mail;
using System.Net;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento
{
    public partial class Solicitar_Medicamentos_Nuevo : MetroForm
    {
        #region Variables

        #endregion

        #region Incio
        public Solicitar_Medicamentos_Nuevo()
        {
            InitializeComponent();
        }
        private void Solicitar_Medicamentos_Nuevo_Load(object sender, EventArgs e)
        {
            //Cargar_Cbo_Presentacion();
            Cargar_Cbo_Unidad_De_Medida();
        }
        #endregion

        #region Eventos
      
        private void Cargar_Cbo_Unidad_De_Medida()
        {
            try
            {
                BLL.Tables.MED_PRESENTACION _os = new BLL.Tables.MED_PRESENTACION();
                Entities.Tables.MED_PRESENTACION _itemSeleccion = new Entities.Tables.MED_PRESENTACION();
                List<Entities.Tables.MED_PRESENTACION> _ItemsOS = new List<Entities.Tables.MED_PRESENTACION>();
                //Limpia el combo
                this.cboUnidadDeMedida.SuspendLayout();
                this.cboUnidadDeMedida.DataSource = null;
                this.cboUnidadDeMedida.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.UNIDADDEMEDIDA_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboUnidadDeMedida.DisplayMember = BLL.Tables.MED_PRESENTACION.ColumnNames.DESCRIPCION;
                this.cboUnidadDeMedida.ValueMember = BLL.Tables.MED_PRESENTACION.ColumnNames.PRESENTACION_ID;
                this.cboUnidadDeMedida.DataSource = _ItemsOS;
                this.cboUnidadDeMedida.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Metodos
        public void Graba_Solicitud_Medicamento_Nuevo()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    SISTMEDEntities E = new SISTMEDEntities();

                    MED_Solicita_Medicamento_Nuevo _itemMedicamentoNuevo = new MED_Solicita_Medicamento_Nuevo();
                    _itemMedicamentoNuevo.medicamento = this.txtNombreMedicamento.Text.ToUpper();
                    _itemMedicamentoNuevo.presentacion_id = Convert.ToInt32(this.cboUnidadDeMedida.SelectedValue);
                    _itemMedicamentoNuevo.unidadDeMedida_id = 1;                    
                    _itemMedicamentoNuevo.fechaSolicita = System.DateTime.Now;
                    _itemMedicamentoNuevo.Potencia = txtPotencia.Text;
                    _itemMedicamentoNuevo.autoriza = false;
                    _itemMedicamentoNuevo.pendiente = true;
                    _itemMedicamentoNuevo.usuarioSolicita_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemMedicamentoNuevo.paciente_id = Clases.Paciente.PacienteIngresado;
                    E.MED_Solicita_Medicamento_Nuevo.Add(_itemMedicamentoNuevo);
                    E.SaveChanges();

                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        #endregion

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DialogResult dialogResult = MessageBox.Show("Desea realizar esta solicitud?", "Medicamento Nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (this.txtNombreMedicamento.Text == string.Empty && this.cboUnidadDeMedida.SelectedIndex == 0 && txtPotencia.Text == string.Empty)
                            {
                                MessageBox.Show("Todos los campos son obligatoris", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             
                            }
                            else
                            {
                                Graba_Solicitud_Medicamento_Nuevo();                      
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
    }
}
