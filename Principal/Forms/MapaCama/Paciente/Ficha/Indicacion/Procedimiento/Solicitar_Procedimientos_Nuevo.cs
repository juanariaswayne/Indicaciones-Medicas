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

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento
{
    public partial class Solicitar_Procedimientos_Nuevo : MetroForm
    {
        #region Variables

        #endregion

        #region Incio
        public Solicitar_Procedimientos_Nuevo()
        {
            InitializeComponent();
        }
        private void Solicitar_Procedimientos_Nuevo_Load(object sender, EventArgs e)
        {
            Cargar_Cbo_Tipo_Procedimiento();
        }
        #endregion

        #region Eventos
        private void Cargar_Cbo_Tipo_Procedimiento()
        {
            try
            {
                BLL.Tables.PRO_TIPO_PROCEDIMIENTO _os = new BLL.Tables.PRO_TIPO_PROCEDIMIENTO();
                Entities.Tables.PRO_TIPO_PROCEDIMIENTO _itemSeleccion = new Entities.Tables.PRO_TIPO_PROCEDIMIENTO();
                List<Entities.Tables.PRO_TIPO_PROCEDIMIENTO> _ItemsOS = new List<Entities.Tables.PRO_TIPO_PROCEDIMIENTO>();
                //Limpia el combo
                this.cboTipoProcedimiento.SuspendLayout();
                this.cboTipoProcedimiento.DataSource = null;
                this.cboTipoProcedimiento.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.TIPOPROCEDIMINETO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboTipoProcedimiento.DisplayMember = BLL.Tables.PRO_TIPO_PROCEDIMIENTO.ColumnNames.DESCRIPCION;
                this.cboTipoProcedimiento.ValueMember = BLL.Tables.PRO_TIPO_PROCEDIMIENTO.ColumnNames.TIPOPROCEDIMINETO_ID;
                this.cboTipoProcedimiento.DataSource = _ItemsOS;
                this.cboTipoProcedimiento.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DialogResult dialogResult = MessageBox.Show("Desea realizar esta solicitud?", "Procedimiento Nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (this.txtNombreMedicamento.Text== string.Empty && this.cboTipoProcedimiento.SelectedIndex == 0)
                            {
                                MessageBox.Show("Todos los campos son obligatoris", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnGuardar.Enabled = true;
                                btnSalir.Enabled = true;
                            }
                            else
                            {
                                Graba_Solicitud_Procedimiento_Nuevo();
                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Metodos
        public void Graba_Solicitud_Procedimiento_Nuevo()
        {
            try
            {
                {
                    //CultureInfo culture = new CultureInfo("en-US");
                    //Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO _itemProcedimientoNuevo = new Entities.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO();
                    //BLL.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO _procedimientoNuevo = new BLL.Tables.MED_SOLICITA_MEDICAMENTO_NUEVO();
                    //_itemProcedimientoNuevo.MEDICAMENTO = this.txtNombreMedicamento.Text.ToUpper(); ;
                    //_itemProcedimientoNuevo.UNIDADDEMEDIDA_ID = Convert.ToInt32(this.cboTipoProcedimiento.SelectedValue);
                    //_itemProcedimientoNuevo.USUARIO_SOLICITA_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    //_itemProcedimientoNuevo.FECHASOLICITA = System.DateTime.Now;
                    //_procedimientoNuevo.Add(_itemProcedimientoNuevo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Envia_Mail()
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion      
    }
}
