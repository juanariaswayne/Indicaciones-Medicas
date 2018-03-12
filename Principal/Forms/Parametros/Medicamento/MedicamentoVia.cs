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

namespace Principal.Forms.Parametros.Medicamento
{
    public partial class MedicamentoVia : MetroForm
    {
        #region Variables
        private enum Col_Medicamentos
        {
            MEDICAMENTO_ID = 0,
            MEDICAMENTO,
            UNIDAD_DE_MEDIDA,
            PRESENTACION
        }
        private enum Col_Vias_Asociadas
        {
            MEDICAMENTO_VIA_ID = 0,
            VIA_ID,
            VIA,
            ASOCIAR
        }
        private enum Col_Vias_Disponibles
        {
            VIA_ID = 0,
            VIA,
            ASOCIAR
        }
        private bool inactivo = false;
        private string medicamentoId;
        #endregion

        #region inicio
        public MedicamentoVia()
        {
            InitializeComponent();
        }
        private void MedicamentoVia_Load(object sender, EventArgs e)
        {
            ObtieneMedicamentos("");
            Obtiene_Via_Disponibles("");
            medicamentoId = Convert.ToString(dataGridViewMedicamento.CurrentRow.Cells[(int)Col_Medicamentos.MEDICAMENTO_ID].Value);
            Obtiene_Via_Asociada(medicamentoId);
        }
        #endregion

        #region Eventos
        private void txtBuscarMedicamento_TextChanged(object sender, EventArgs e)
        {
            ObtieneMedicamentos(txtBuscarMedicamento.Text);
        }     
        private void dataGridViewMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            medicamentoId = Convert.ToString(dataGridViewMedicamento.CurrentRow.Cells[(int)Col_Medicamentos.MEDICAMENTO_ID].Value);
            Obtiene_Via_Asociada(medicamentoId);
        }
        private void dataGridViewMedicamento_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewMedicamento.IsCurrentCellDirty)
                dataGridViewMedicamento.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dataGridViewViasAsociada_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewViaAsociada.IsCurrentCellDirty)
                dataGridViewViaAsociada.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dataGridViewViasDisponible_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewViaDisponible.IsCurrentCellDirty)
                dataGridViewViaDisponible.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void btnAsociar_Click(object sender, EventArgs e)
        {
            Guarda_Asociacion();
        }  
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region metodos
        private void Guarda_Asociacion()
        {
            try
            {
                BLL.Tables.MED_MEDICAMENTO_VIA _MedicamentoVia = new BLL.Tables.MED_MEDICAMENTO_VIA();
                Entities.Tables.MED_MEDICAMENTO_VIA _item = new Entities.Tables.MED_MEDICAMENTO_VIA();

                #region Asociar
                for (int i = 0; i < this.dataGridViewViaDisponible.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell asociar = dataGridViewViaDisponible.Rows[i].Cells[(int)Col_Vias_Disponibles.ASOCIAR] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(asociar.Value))
                    {
                        _item.MEDICAMENTO_ID = Convert.ToString(dataGridViewMedicamento.CurrentRow.Cells[(int)Col_Medicamentos.MEDICAMENTO_ID].Value);
                        _item.VIA_ID = Convert.ToInt32(dataGridViewViaDisponible.Rows[i].Cells[(int)Col_Vias_Disponibles.VIA_ID].Value);
                        _MedicamentoVia.AddItem(_item);
                    }
                }
                #endregion

                #region Desasociar
                for (int i = 0; i < this.dataGridViewViaAsociada.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell desasociar = dataGridViewViaAsociada.Rows[i].Cells[(int)Col_Vias_Asociadas.ASOCIAR] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(desasociar.Value))
                    {
                        _item.MEDICAMENTOVIA_ID = Convert.ToInt32(dataGridViewViaAsociada.CurrentRow.Cells[(int)Col_Vias_Asociadas.MEDICAMENTO_VIA_ID].Value);
                        _item.MEDICAMENTO_ID = Convert.ToString(dataGridViewMedicamento.CurrentRow.Cells[(int)Col_Medicamentos.MEDICAMENTO_ID].Value);
                        _item.VIA_ID = Convert.ToInt32(dataGridViewViaAsociada.CurrentRow.Cells[(int)Col_Vias_Asociadas.VIA_ID].Value);
                        _MedicamentoVia.Remove(_item);
                    }
                }
                #endregion
                Obtiene_Via_Asociada(Convert.ToString(dataGridViewMedicamento.CurrentRow.Cells[(int)Col_Medicamentos.MEDICAMENTO_ID].Value));
                Obtiene_Via_Disponibles("");
                MessageBox.Show("Se Guardo la relacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ObtieneMedicamentos(string medicamento)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.TRAEMEDICAMENTOS _detalle = new BLL.Procedures.TRAEMEDICAMENTOS();
                this.dataGridViewMedicamento.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.TRAEMEDICAMENTOS item in _detalle.ItemList(medicamento))
                {
                    indice = dataGridViewMedicamento.Rows.Add();
                    dataGridViewMedicamento.Rows[indice].Cells[(int)Col_Medicamentos.MEDICAMENTO_ID].Value = item.art_codgen;
                    dataGridViewMedicamento.Rows[indice].Cells[(int)Col_Medicamentos.MEDICAMENTO].Value = item.art_descgen + " " + item.artele_desc2 + " " + item.artele_desc1;
                    dataGridViewMedicamento.Rows[indice].Cells[(int)Col_Medicamentos.UNIDAD_DE_MEDIDA].Value = item.artele_desc2;
                    dataGridViewMedicamento.Rows[indice].Cells[(int)Col_Medicamentos.PRESENTACION].Value = item.artele_desc1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Obtiene_Via_Disponibles(string inactivo)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.MED_GET_VIA _detalle = new BLL.Procedures.MED_GET_VIA();
                this.dataGridViewViaDisponible.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.MED_GET_VIA item in _detalle.ItemList(inactivo))
                {
                    indice = dataGridViewViaDisponible.Rows.Add();
                    dataGridViewViaDisponible.Rows[indice].Cells[(int)Col_Vias_Disponibles.VIA_ID].Value = item.via_id;
                    dataGridViewViaDisponible.Rows[indice].Cells[(int)Col_Vias_Disponibles.VIA].Value = item.descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Obtiene_Via_Asociada(string medicamento_id)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.MED_GET_MEDICAMENTO_VIA _detalle = new BLL.Procedures.MED_GET_MEDICAMENTO_VIA();
                dataGridViewViaAsociada.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.MED_GET_MEDICAMENTO_VIA item in _detalle.ItemList(medicamento_id, inactivo))
                {
                    indice = dataGridViewViaAsociada.Rows.Add();
                    dataGridViewViaAsociada.Rows[indice].Cells[(int)Col_Vias_Asociadas.MEDICAMENTO_VIA_ID].Value = item.medicamento_via_id;
                    dataGridViewViaAsociada.Rows[indice].Cells[(int)Col_Vias_Asociadas.VIA_ID].Value = item.via_id;
                    dataGridViewViaAsociada.Rows[indice].Cells[(int)Col_Vias_Asociadas.VIA].Value = item.descripcion;
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
