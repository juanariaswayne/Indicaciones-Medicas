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

namespace Principal.Forms.Medicamento
{
    public partial class Medicamento : MetroForm
    {
        #region Variables
        private enum Col_Medicamento_Berjerman
        {
            MEDICAMENTO_ID = 0,
            MEDICAMENTO,
            UNIDAD_DE_MEDIDA,
            PRESENTACION
        }
        private enum Col_Medicamento_Pendiente
        {
            MEDICAMENTO_ID = 0,
            MEDICAMENTO,
            UNIDAD_DE_MEDIDA,
            PRESENTACION
        }
        private string medicamento_bejerman_id;      
        private string medicamento_pendiente_id;      
        #endregion

        #region Inicio
        public Medicamento()
        {
            InitializeComponent();
        }
        private void Medicamento_Load(object sender, EventArgs e)
        {
            // Bejerman
            Obtiene_Medicamento_Bejerman("");            
            // Pendientes
            Obtiene_Medicamento_Pendiente("");
        }
        #endregion

        #region Eventos
        // Bejerman
        private void dataGridViewMedicamentoBejerman_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewMedicamentoBejerman.IsCurrentCellDirty)
                dataGridViewMedicamentoBejerman.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void txtBuscarMedicamentoBerjerman_TextChanged(object sender, EventArgs e)
        {
            Obtiene_Medicamento_Bejerman(txtBuscarMedicamentoBerjerman.Text);
        }
        // Pendientes
        private void dataGridViewMedicamentoPendiente_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewMedicamentoPendiente.IsCurrentCellDirty)
                dataGridViewMedicamentoPendiente.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void txtBuscarMedicamentoPendiente_TextChanged(object sender, EventArgs e)
        {
            Obtiene_Medicamento_Pendiente(txtBuscarMedicamentoPendiente.Text);
        }       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Metodos
        // Bejerman
        private void Obtiene_Medicamento_Bejerman(string medicamento_bejerman_id)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.MED_GET_MEDICAMENTO_BEJERMAN _detalle = new BLL.Procedures.MED_GET_MEDICAMENTO_BEJERMAN();
                this.dataGridViewMedicamentoBejerman.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.MED_GET_MEDICAMENTO_BEJERMAN item in _detalle.ItemList(medicamento_bejerman_id))
                {
                    indice = dataGridViewMedicamentoBejerman.Rows.Add();
                    dataGridViewMedicamentoBejerman.Rows[indice].Cells[(int)Col_Medicamento_Berjerman.MEDICAMENTO_ID].Value = item.art_codgen;
                    dataGridViewMedicamentoBejerman.Rows[indice].Cells[(int)Col_Medicamento_Berjerman.MEDICAMENTO].Value = item.art_descgen;
                    dataGridViewMedicamentoBejerman.Rows[indice].Cells[(int)Col_Medicamento_Berjerman.UNIDAD_DE_MEDIDA].Value = item.artele_desc2;
                    dataGridViewMedicamentoBejerman.Rows[indice].Cells[(int)Col_Medicamento_Berjerman.PRESENTACION].Value = item.artele_desc1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Pendientes
        private void Obtiene_Medicamento_Pendiente(string medicamento_pendiente_id)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.MED_GET_MEDICAMENTO_INDICACION_MEDICA _detalle = new BLL.Procedures.MED_GET_MEDICAMENTO_INDICACION_MEDICA();
                this.dataGridViewMedicamentoPendiente.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.MED_GET_MEDICAMENTO_INDICACION_MEDICA item in _detalle.ItemList(medicamento_pendiente_id, false))
                {
                    indice = dataGridViewMedicamentoPendiente.Rows.Add();
                    dataGridViewMedicamentoPendiente.Rows[indice].Cells[(int)Col_Medicamento_Pendiente.MEDICAMENTO_ID].Value = item.medicamento_id;
                    dataGridViewMedicamentoPendiente.Rows[indice].Cells[(int)Col_Medicamento_Pendiente.MEDICAMENTO].Value = item.medicamento;
                    dataGridViewMedicamentoPendiente.Rows[indice].Cells[(int)Col_Medicamento_Pendiente.UNIDAD_DE_MEDIDA].Value = item.unidaddemedida;
                    dataGridViewMedicamentoPendiente.Rows[indice].Cells[(int)Col_Medicamento_Pendiente.PRESENTACION].Value = item.presentacion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
        private void Guardar()
        {
            try
            {
                BLL.Tables.MED_MEDICAMENTO_VIA _Medicamento = new BLL.Tables.MED_MEDICAMENTO_VIA();
                Entities.Tables.MED_MEDICAMENTO_VIA _item = new Entities.Tables.MED_MEDICAMENTO_VIA();

                for (int i = 0; i < this.dataGridViewMedicamentoPendiente.Rows.Count - 1; i++)
                {
                    DataGridViewCheckBoxCell id = dataGridViewMedicamentoPendiente.Rows[i].Cells[(int)Col_Medicamento_Pendiente.MEDICAMENTO_ID] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(id.Value))
                    {
                        _item.MEDICAMENTO_ID = Convert.ToString(dataGridViewMedicamentoPendiente.CurrentRow.Cells[(int)Col_Medicamento_Pendiente.MEDICAMENTO_ID].Value);
                        _item.MEDICAMENTO_ID = dataGridViewMedicamentoPendiente.Rows[i].Cells[(int)Col_Medicamento_Pendiente.MEDICAMENTO_ID].Value.ToString();
                        _item.VIA_ID = 0;
                        //_Medicamento.AddItem(_item);
                    }
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
