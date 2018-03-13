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

namespace Principal.Forms.MapaCama
{
    public partial class DetalleMedicacion : MetroForm
    {
        #region Variables
        public int paciente_id;
        public string hora;
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
        public string Hora
        {
            get
            {
                return hora;
            }

            set
            {
                this.hora = value;
            }
        }
        private enum Col_Horario_Medicamentos
        {
            CHECK = 0,
            MEDICAMENTO,
            OBSERVACIONES
        }
        #endregion

        #region Inicio
        public DetalleMedicacion()
        {
            InitializeComponent();
        }
        private void DetalleMedicacion_Load(object sender, EventArgs e)
        {
            try
            {
                Get_Detalle_Medicamento(paciente_id, hora); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        private void dataGridViewDetalleMedicamento_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewDetalleMedicamento.IsCurrentCellDirty)
                dataGridViewDetalleMedicamento.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Metodo
        private void Get_Detalle_Medicamento(int paciente_id, string hora)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.MAP_GET_HORARIO_MEDICAMENTO _obtieneMedicamento = new BLL.Procedures.MAP_GET_HORARIO_MEDICAMENTO();
                this.dataGridViewDetalleMedicamento.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.MAP_GET_HORARIO_MEDICAMENTO item in _obtieneMedicamento.ItemList(paciente_id, hora))
                {
                    indice = dataGridViewDetalleMedicamento.Rows.Add();
                    dataGridViewDetalleMedicamento.Rows[indice].Cells[(int)Col_Horario_Medicamentos.CHECK].ToString();
                    dataGridViewDetalleMedicamento.Rows[indice].Cells[(int)Col_Horario_Medicamentos.MEDICAMENTO].Value = item.droga + " ( " + item.dosis + "  " + item.presentacion + " )";
                    dataGridViewDetalleMedicamento.Rows[indice].Cells[(int)Col_Horario_Medicamentos.OBSERVACIONES].Value = item.observacion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Up_HorariosPaciente(object paciente_id)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                Entities.Tables.PACIENTES _item = new Entities.Tables.PACIENTES();
                BLL.Tables.PACIENTES _paciente = new BLL.Tables.PACIENTES();
                BLL.Procedures.MED_UP_HORARIOS_PACIENTE _obtieneHorarios = new BLL.Procedures.MED_UP_HORARIOS_PACIENTE();
                _item.PACIENTE_ID = this.paciente_id;
                             
                if (this.txtObservacion.Text != string.Empty) { _item.HS_SH = 1; } else { _item.HS_SH = 0; }
                
                _obtieneHorarios.ItemList(this.paciente_id, _item.HS_08, _item.HS_09, _item.HS_10, _item.HS_11, _item.HS_12, _item.HS_13, _item.HS_14, _item.HS_15, _item.HS_16, _item.HS_17, _item.HS_18, _item.HS_19, _item.HS_20, _item.HS_21, _item.HS_22, _item.HS_23, _item.HS_24, _item.HS_01, _item.HS_02, _item.HS_03, _item.HS_04, _item.HS_05, _item.HS_06, _item.HS_07, _item.HS_SH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

      
    }
}
