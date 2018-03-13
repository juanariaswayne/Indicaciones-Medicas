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
    public partial class Edita_Via : MetroForm
    {
        #region Variables
        private string inactivo = null;
        private enum Col_Via
        {
            VIA_ID = 0,
            VIA,
            INACTIVO
        }
        #endregion

        #region inicio
        public Edita_Via()
        {
            InitializeComponent();
        }
        private void Edita_Via_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Get_Via(inactivo);
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Metodos
        private void Get_Via(string inactivo)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.MED_GET_VIA _detalle = new BLL.Procedures.MED_GET_VIA();
                this.dataGridViewVias.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.MED_GET_VIA item in _detalle.ItemList(inactivo))
                {                    
                    indice = dataGridViewVias.Rows.Add();
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewVias.Rows[indice].Cells[(int)Col_Via.INACTIVO] as DataGridViewCheckBoxCell;
                    dataGridViewVias.Rows[indice].Cells[(int)Col_Via.VIA_ID].Value = item.via_id;
                    dataGridViewVias.Rows[indice].Cells[(int)Col_Via.VIA].Value = item.descripcion;
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
        private void Guardar_Via()
        {
            BLL.Tables.MED_VIA _via = new BLL.Tables.MED_VIA();
            Entities.Tables.MED_VIA _item = new Entities.Tables.MED_VIA();            

            for (int i = 0; i < this.dataGridViewVias.Rows.Count - 0; i++)
            {
                
                _item.VIA_ID = Convert.ToInt32(dataGridViewVias.Rows[i].Cells[(int)Col_Via.VIA_ID].Value);
                _item.DESCRIPCION = dataGridViewVias.Rows[i].Cells[(int)Col_Via.VIA].Value.ToString();
                DataGridViewCheckBoxCell cellSelecion = dataGridViewVias.Rows[i].Cells[(int)Col_Via.INACTIVO] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cellSelecion.Value) == true)
                {
                    _item.INACTIVO = true;
                }
                else
                {
                    _item.INACTIVO = false;
                }

                _via.UpdateItem(_item);
            }

            MessageBox.Show("Se actualizaron todas las vías", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Get_Via(inactivo);
        }
        #endregion

        #region Eventos       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                BLL.Tables.MED_VIA _via = new BLL.Tables.MED_VIA();
                Entities.Tables.MED_VIA _item = new Entities.Tables.MED_VIA();
                _item.DESCRIPCION = txtAgregar.Text.ToUpper();
                _via.AddItem(_item);
                MessageBox.Show("Se agrego correctamente la vía", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Get_Via(inactivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Guardar_Via();
            Cursor.Current = Cursors.Default;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
