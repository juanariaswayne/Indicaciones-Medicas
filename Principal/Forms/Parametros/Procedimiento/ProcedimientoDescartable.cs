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

namespace Principal.Forms.Parametros.Procedimiento
{
    public partial class ProcedimientoDescartable : MetroForm
    {
        #region Variables
        private enum Col_Procedimientos
        {
            IDPROCEDIMIENTO = 0,
            PROCEDIMIENTODESC
        }
        private enum Col_Descartables
        {
            IDDESCARTABLE = 0,
            DESCARTABLE,
            CANTIDAD,
            ASOCIAR,
            IMPRIMIBLE
        }
        #endregion

        #region funciones
        public ProcedimientoDescartable()
        {
            InitializeComponent();
        }

        private void ObtieneProcedimientos(string procedimiento)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.PRO_GET_PROCEDIMIENTO _detalle = new BLL.Procedures.PRO_GET_PROCEDIMIENTO();
                this.dataGridViewProcedimientos.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.PRO_GET_PROCEDIMIENTO item in _detalle.ItemList(procedimiento))
                {
                    indice = dataGridViewProcedimientos.Rows.Add();
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimientos.IDPROCEDIMIENTO].Value = item.procedimiento_id;
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimientos.PROCEDIMIENTODESC].Value = item.descripcion;                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ObtieneDescartables(string procedimiento)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.TRAEDESCARTABLES _detalle = new BLL.Procedures.TRAEDESCARTABLES();
                this.dataGridViewDesc.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.TRAEDESCARTABLES item in _detalle.ItemList(procedimiento))
                {
                    indice = dataGridViewDesc.Rows.Add();
                    dataGridViewDesc.Rows[indice].Cells[(int)Col_Descartables.IDDESCARTABLE].Value = item.art_codgen;
                    dataGridViewDesc.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = item.art_descgen;                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtieneDatosProcedimiento(int _procedimientoID)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.TRAEDESCARTABLESPROCEDIMIENTO _detalle = new BLL.Procedures.TRAEDESCARTABLESPROCEDIMIENTO();

                dataGridViewDesc.Rows.Clear();
                ObtieneDescartables("");
                foreach (Entities.Procedures.TRAEDESCARTABLESPROCEDIMIENTO item in _detalle.ItemList(_procedimientoID))
                {
                    for (int i = 0; i < this.dataGridViewDesc.Rows.Count - 1; i++)
                    {
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewDesc.Rows[i].Cells[(int)Col_Descartables.ASOCIAR] as DataGridViewCheckBoxCell;
                        DataGridViewCheckBoxCell cellSelecion2 = dataGridViewDesc.Rows[i].Cells[(int)Col_Descartables.IMPRIMIBLE] as DataGridViewCheckBoxCell;

                        if (dataGridViewDesc.Rows[i].Cells[(int)Col_Descartables.IDDESCARTABLE].Value.ToString() == item.descartable_id)
                        {
                            dataGridViewDesc.Rows[i].Cells[(int)Col_Descartables.CANTIDAD].Value = item.cantidad;
                            cellSelecion.Value = true;

                            if (item.imprimible == true)
                            {
                                cellSelecion2.Value = true;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GuardarAsoc()
        {
            try
            {
                BLL.Tables.PRO_PROCEDIMIENTODESCARTABLE _ProDesc = new BLL.Tables.PRO_PROCEDIMIENTODESCARTABLE();
                Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE _item = new Entities.Tables.PRO_PROCEDIMIENTODESCARTABLE();

                BLL.Procedures._PRO_BORRARDESCARTABLESPROC _BorraDesc = new BLL.Procedures._PRO_BORRARDESCARTABLESPROC();
                _BorraDesc.ItemList(Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimientos.IDPROCEDIMIENTO].Value));

                for (int i = 0; i < this.dataGridViewDesc.Rows.Count - 1; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewDesc.Rows[i].Cells[(int)Col_Descartables.ASOCIAR] as DataGridViewCheckBoxCell;
                    DataGridViewCheckBoxCell cellSelecion2 = dataGridViewDesc.Rows[i].Cells[(int)Col_Descartables.IMPRIMIBLE] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        _item.PROCEDIMIENTO_ID = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimientos.IDPROCEDIMIENTO].Value);
                        _item.DESCARTABLE_ID = dataGridViewDesc.Rows[i].Cells[(int)Col_Descartables.IDDESCARTABLE].Value.ToString();
                        _item.CANTIDAD = Convert.ToInt32(dataGridViewDesc.Rows[i].Cells[(int)Col_Descartables.CANTIDAD].Value);
                        if (Convert.ToBoolean(cellSelecion2.Value))
                        {
                            _item.IMPRIMIBLE = true;
                        }
                        else
                        {
                            _item.IMPRIMIBLE = false;
                        }
                        
                        _ProDesc.AddItem(_item);
                       
                    }
                    
                }
                ObtieneDatosProcedimiento(Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimientos.IDPROCEDIMIENTO].Value));
                MessageBox.Show("Se Guardo la relacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region Eventos
        private void ProcedimientoDescartable_Load(object sender, EventArgs e)
        {
            ObtieneProcedimientos("");
            ObtieneDescartables("");
        }
        #endregion

        private void txtBuscarPro_TextChanged(object sender, EventArgs e)
        {
            ObtieneProcedimientos(txtBuscarPro.Text);
        }

        private void txtDescartable_TextChanged(object sender, EventArgs e)
        {
            ObtieneDescartables(txtDescartable.Text);
        }

        private void ProcedimientoDescartable_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
        }

        private void buttonAsociar_Click(object sender, EventArgs e)
        {
            GuardarAsoc();
        }

        private void dataGridViewProcedimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtieneDatosProcedimiento(Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimientos.IDPROCEDIMIENTO].Value));
        }
    }
}
