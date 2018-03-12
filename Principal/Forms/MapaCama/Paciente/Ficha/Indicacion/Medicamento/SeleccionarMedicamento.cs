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

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento
{
    public partial class SeleccionarMedicamento : MetroForm
    {
        #region Variables
        SISTMEDEntities E = new SISTMEDEntities();
       private int _idPaciente;
       private string _paciente;
       private string _idMedicamento;

        private Form _Indicacion; // Guardo la instancia del formulario principal para no perderla al llamar al formulario Medicacion
      
        public int IdPaciente
        {
            get
            {
                return _idPaciente;
            }

            set
            {
                this._idPaciente = value;
            }
        }
        public string Paciente
        {
            get
            {
                return _paciente;
            }

            set
            {
                this._paciente = value;
            }
        }

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

        private enum Col_Medicamentos
        {
            MEDICAMENTOID = 0,
            DROGA,
            POTENCIA,
            PRESENTACION,
            ENSTOCK
        }

        #endregion

        #region Funciones
        public SeleccionarMedicamento()
        {
            InitializeComponent();
        }
        private void TraeMedicacionPaciente(string _idMedicamento)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");                
                this.dataGridViewMedicamentos.Rows.Clear();
                int indice;
                foreach (var item in E.TRAEMEDICAMENTOS(_idMedicamento).ToList())
                {
                    indice = dataGridViewMedicamentos.Rows.Add();
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.MEDICAMENTOID].Value = item.art_CodGen;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.DROGA].Value = item.art_DescGen;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.POTENCIA].Value = item.artele_Desc2;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.PRESENTACION].Value = item.artele_Desc1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  
        #endregion

        #region Eventos
        private void SeleccionarMedicamento_Load(object sender, EventArgs e)
        {
            try
            {
            _idMedicamento = "";
            TraeMedicacionPaciente(_idMedicamento);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void metroTextBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {

                for (int u = 0; u < dataGridViewMedicamentos.RowCount; u++)
                {
                    if (dataGridViewMedicamentos.Rows[u].Cells[(int)Col_Medicamentos.DROGA].Value.ToString().Trim().ToUpper().Contains(metroTextBoxBuscar.Text.ToUpper()))
                    {
                        dataGridViewMedicamentos.Rows[u].Visible = true;
                    }
                    else
                    {
                        dataGridViewMedicamentos.Rows[u].Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewMedicamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.Medicacion _Medicacion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.Medicacion();
                _Medicacion.Paciente_Id = _idPaciente;
                _Medicacion.Paciente = _paciente;
                _Medicacion.Medicamento_Id = dataGridViewMedicamentos.CurrentRow.Cells[(int)Col_Medicamentos.MEDICAMENTOID].Value.ToString();
                _Medicacion.Medicamento = dataGridViewMedicamentos.CurrentRow.Cells[(int)Col_Medicamentos.DROGA].Value.ToString();
                _Medicacion.Presentacion = dataGridViewMedicamentos.CurrentRow.Cells[(int)Col_Medicamentos.PRESENTACION].Value.ToString();
                _Medicacion.Potencia = dataGridViewMedicamentos.CurrentRow.Cells[(int)Col_Medicamentos.POTENCIA].Value.ToString();
                _Medicacion.Opener =(Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion) _Indicacion; //Le paso a la variable Opener la instancia del formulario principal
                _Medicacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSolocitarMedicamentoNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.Solicitar_Medicamentos_Nuevo _Solicita_Medicacion_Nuevo = new Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.Solicitar_Medicamentos_Nuevo();
                _Solicita_Medicacion_Nuevo.ShowDialog();
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

        private void btnSolMed_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.Solicitar_Medicamentos_Nuevo _Solicita_Medicacion_Nuevo = new Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.Solicitar_Medicamentos_Nuevo();
                _Solicita_Medicacion_Nuevo.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
