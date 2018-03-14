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
    public partial class EditProcedimientos : MetroForm
    {
        #region Variables
        private enum Col_Procedimiento
        {
            PROCEDIMIENTO_ID = 0,
            PROCEDIMIENTO,
            TIPO_PROCEDIMIENTO_ID,
            TIPO_PROCEDIMIENTO,
            INACTIVO
        }
        #endregion

        #region Funciones
        public EditProcedimientos()
        {
            InitializeComponent();
        }

        private void Get_Procedimiento(string procedimiento)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.PRO_GET_PROCEDIMIENTOTODOS _detalle = new BLL.Procedures.PRO_GET_PROCEDIMIENTOTODOS();
                this.dataGridViewProc.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.PRO_GET_PROCEDIMIENTOTODOS item in _detalle.ItemList(procedimiento))
                {                    
                    indice = dataGridViewProc.Rows.Add();
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewProc.Rows[indice].Cells[(int)Col_Procedimiento.INACTIVO] as DataGridViewCheckBoxCell;
                    dataGridViewProc.Rows[indice].Cells[(int)Col_Procedimiento.PROCEDIMIENTO_ID].Value = item.procedimiento_id;
                    dataGridViewProc.Rows[indice].Cells[(int)Col_Procedimiento.PROCEDIMIENTO].Value = item.descripcion;
                    dataGridViewProc.Rows[indice].Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO_ID].Value = item.tipoprocedimiento_id;
                    dataGridViewProc.Rows[indice].Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO].Value = item.descripciontipo;
                    if (item.inactivo)
                    {
                        cellSelecion.Value = true;
                    }
                    else
                    {
                        cellSelecion.Value = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarProcedimientos()
        {
            BLL.Tables.PRO_PROCEDIMIENTO _proc = new BLL.Tables.PRO_PROCEDIMIENTO();
            Entities.Tables.PRO_PROCEDIMIENTO _item = new Entities.Tables.PRO_PROCEDIMIENTO();            

            for (int i = 0; i < this.dataGridViewProc.Rows.Count - 1; i++)
            {
                DataGridViewCheckBoxCell cellSelecion = dataGridViewProc.Rows[i].Cells[(int)Col_Procedimiento.INACTIVO] as DataGridViewCheckBoxCell;
                _item.PROCEDIMIENTO_ID = Convert.ToInt32(dataGridViewProc.Rows[i].Cells[(int)Col_Procedimiento.PROCEDIMIENTO_ID].Value);
                _item.DESCRIPCION = dataGridViewProc.Rows[i].Cells[(int)Col_Procedimiento.PROCEDIMIENTO].Value.ToString();
                _item.TIPOPROCEDIMIENTO_ID = Convert.ToInt32(dataGridViewProc.Rows[i].Cells[(int)Col_Procedimiento.TIPO_PROCEDIMIENTO_ID].Value); ;
                if (Convert.ToBoolean(cellSelecion.Value) == true)
                {
                    _item.INACTIVO = true;
                }
                else
                {
                    _item.INACTIVO = false;
                }

                _proc.UpdateItem(_item);
            }

            MessageBox.Show("Se actualizaron todos los procedimientos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Get_Procedimiento("");
        }
        #endregion

        #region Eventos
        private void EditProcedimientos_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Get_Procedimiento("");
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GuardarProcedimientos();
            Cursor.Current = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                BLL.Tables.PRO_PROCEDIMIENTO _proc = new BLL.Tables.PRO_PROCEDIMIENTO();
                Entities.Tables.PRO_PROCEDIMIENTO _item = new Entities.Tables.PRO_PROCEDIMIENTO();

                _item.DESCRIPCION = txtAgregar.Text.ToUpper();
                _item.TIPOPROCEDIMIENTO_ID = 3;

                _proc.AddItem(_item);

                MessageBox.Show("Se agrego correctamente el procedimiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Get_Procedimiento("");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
