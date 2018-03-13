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
    public partial class SeleccionarProcedimiento : MetroForm
    {
        #region Variables
       private int paciente_id;
       private string paciente;
       private int procedimiento_id;
       private int tipo_procedimiento_id;
       private string procedimientos;

        private Form _Indicacion; // Guardo la instancia del formulario principal para no perderla al llamar al resto de los formularios
        public Form Indicacion
        {
            get
            {
                return _Indicacion;
            }

            set
            {
                this._Indicacion = value;
            }
        }
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
        public string Paciente
        {
            get
            {
                return paciente;
            }

            set
            {
                this.paciente = value;
            }
        }
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
        private enum Col_Procedimiento
        {
            PROCEDIMIENTO_ID = 0,
            PROCEDIMIENTO,
            TIPO_PROCEDIMIENTO_ID,
            TIPO_PROCEDIMIENTO
        }

        #endregion

        #region Inicio
        public SeleccionarProcedimiento()
        {
            InitializeComponent();
        }
        private void SeleccionarProcedimiento_Load(object sender, EventArgs e)
        {
            try
            {
                procedimientos = "";
                Get_Procedimiento(procedimientos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                procedimientos = this.txtBuscar.Text;
                Get_Procedimiento(procedimientos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewProcedimiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int tipo = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO_ID].Value);
                switch (tipo)
                {
                    case 1:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Enfermeria _Enfermeria = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Enfermeria();
                        _Enfermeria.Paciente_Id = paciente_id;
                        _Enfermeria.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.PROCEDIMIENTO_ID].Value.ToString());
                        _Enfermeria.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO_ID].Value.ToString());
                        _Enfermeria.Opener = (Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion)_Indicacion; //Le paso a la variable Opener la instancia del formulario principal
                        _Enfermeria.ShowDialog();
                        break;

                    case 2:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Nutricion _Nutricion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Nutricion();
                        _Nutricion.Paciente_Id = paciente_id;
                        _Nutricion.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.PROCEDIMIENTO_ID].Value.ToString());
                        _Nutricion.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO_ID].Value.ToString());
                        _Nutricion.Opener = (Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion)_Indicacion; //Le paso a la variable Opener la instancia del formulario principal
                        _Nutricion.ShowDialog();
                        break;

                    case 3:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProcedimientoV2 _Generico = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProcedimientoV2();
                        _Generico.Paciente_Id = paciente_id;
                        _Generico.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.PROCEDIMIENTO_ID].Value.ToString());
                        _Generico.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO_ID].Value.ToString());
                       
                        _Generico.Opener = (Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion)_Indicacion; //Le paso a la variable Opener la instancia del formulario principal
                        _Generico.ShowDialog();
                        break;

                    case 4:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ColocacionViaPeriferica _ColocacionViaPeriferica = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ColocacionViaPeriferica();
                        _ColocacionViaPeriferica.Paciente_Id = paciente_id;
                        _ColocacionViaPeriferica.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.PROCEDIMIENTO_ID].Value.ToString());
                        _ColocacionViaPeriferica.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO_ID].Value.ToString());
                        _ColocacionViaPeriferica.Opener = (Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion)_Indicacion; //Le paso a la variable Opener la instancia del formulario principal
                        _ColocacionViaPeriferica.ShowDialog();
                        break;

                    case 5:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.CuidadoOral _CuidadoOral = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.CuidadoOral();
                        _CuidadoOral.Paciente_Id = paciente_id;
                        _CuidadoOral.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.PROCEDIMIENTO_ID].Value.ToString());
                        _CuidadoOral.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO_ID].Value.ToString());
                        _CuidadoOral.Opener = (Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion)_Indicacion; //Le paso a la variable Opener la instancia del formulario principal
                        _CuidadoOral.ShowDialog();
                        break;

                    case 6:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.CuidadoPostural _CuidadoPostural = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.CuidadoPostural();
                        _CuidadoPostural.Paciente_Id = paciente_id;
                        _CuidadoPostural.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.PROCEDIMIENTO_ID].Value.ToString());
                        _CuidadoPostural.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO_ID].Value.ToString());
                        _CuidadoPostural.Opener = (Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion)_Indicacion; //Le paso a la variable Opener la instancia del formulario principal
                        _CuidadoPostural.ShowDialog();
                        break;
                        
                    case 7:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProteccionFisica _ProteccionFisica = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProteccionFisica();
                        _ProteccionFisica.Paciente_Id = paciente_id;
                        _ProteccionFisica.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.PROCEDIMIENTO_ID].Value.ToString());
                        _ProteccionFisica.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO_ID].Value.ToString());
                        _ProteccionFisica.Opener = (Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion)_Indicacion; //Le paso a la variable Opener la instancia del formulario principal
                        _ProteccionFisica.ShowDialog();
                        break;

                    case 8:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.PHPV2 _Php = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.PHPV2();
                        _Php.Paciente_Id = paciente_id;
                        _Php.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.PROCEDIMIENTO_ID].Value.ToString());
                        _Php.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO_ID].Value.ToString());
                        _Php.Opener = (Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion)_Indicacion; //Le paso a la variable Opener la instancia del formulario principal
                        _Php.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewProcedimiento_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewProcedimiento.IsCurrentCellDirty)
                dataGridViewProcedimiento.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
          

        #endregion

        #region Metodos
        private void Get_Procedimiento(string procedimiento)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.PRO_GET_PROCEDIMIENTO _detalle = new BLL.Procedures.PRO_GET_PROCEDIMIENTO();
                this.dataGridViewProcedimiento.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.PRO_GET_PROCEDIMIENTO item in _detalle.ItemList(procedimiento))
                {
                    indice = dataGridViewProcedimiento.Rows.Add();
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimiento.PROCEDIMIENTO_ID].Value = item.procedimiento_id;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimiento.PROCEDIMIENTO].Value = item.descripcion;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO_ID].Value = item.tipoprocedimiento_id;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO].Value = item.descripciontipo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btSolicitarNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Solicitar_Procedimientos_Nuevo _Solicita_Procedimiento_Nuevo = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Solicitar_Procedimientos_Nuevo();
                _Solicita_Procedimiento_Nuevo.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
