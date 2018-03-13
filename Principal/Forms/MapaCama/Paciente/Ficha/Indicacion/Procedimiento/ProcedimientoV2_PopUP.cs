using MetroFramework.Forms;
using Principal.Forms.Farmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento
{
    public partial class ProcedimientoV2_PopUP : MetroForm
    {
        #region Variables
        public ICargaDatos _Datos { get; set; }
        public ICargaAditivos _Aditivos { get; set; }       
        string _codigo;
        string _descripcion;
        decimal _cantidad;
        public char _tipo;
        public char _aditivo;
        private enum Col_Lista
        {
            ID=0,
            DESCRIPCION,        
            AGREGAR
        }
        SISTMEDEntities E = new SISTMEDEntities();
        #endregion

        #region Funciones
        public ProcedimientoV2_PopUP()
        {
            InitializeComponent();
        }

        private void CargarListaDescartables(String _filtro)
        {
            try
            {
                int indice;
                foreach(var item in E.TRAEDESCARTABLES(_filtro))
                {
                    indice = dataGridListado.Rows.Add();
                    dataGridListado.Rows[indice].Cells[(int)Col_Lista.ID].Value = item.art_CodGen;
                    dataGridListado.Rows[indice].Cells[(int)Col_Lista.DESCRIPCION].Value = item.art_DescGen + " "+ item.artele_Desc2 + " "+item.artele_Desc1;                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarListaMedicacion(String _filtro)
        {
            try
            {
                int indice;
                foreach (var item in E.TRAEMEDICAMENTOS(_filtro))
                {
                    indice = dataGridListado.Rows.Add();
                    dataGridListado.Rows[indice].Cells[(int)Col_Lista.ID].Value = item.art_CodGen;
                    dataGridListado.Rows[indice].Cells[(int)Col_Lista.DESCRIPCION].Value = item.art_DescGen + " " + item.artele_Desc2 + " " + item.artele_Desc1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListaProcedimientos(String _filtro)
        {
            try
            {
                int indice;
                foreach (var item in E.PRO_Get_Procedimiento(_filtro))
                {
                    indice = dataGridListado.Rows.Add();
                    dataGridListado.Rows[indice].Cells[(int)Col_Lista.ID].Value = item.procedimiento_id;
                    dataGridListado.Rows[indice].Cells[(int)Col_Lista.DESCRIPCION].Value = item.descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos
        private void ProcedimientoV2_PopUP_Load(object sender, EventArgs e)
        {
            try
            {
               
                if(_tipo == 'D')
                {
                    CargarListaDescartables("");
                }
                else if(_tipo == 'M')
                {
                    CargarListaMedicacion("");
                }
                else if(_tipo == 'P')
                {
                    CargarListaProcedimientos("");
                }
                else if(_tipo == 'F')
                {
                    CargarListaDescartables("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridListado.Rows.Count; i++)
                {              
                    _codigo = dataGridListado.Rows[i].Cells[(int)Col_Lista.ID].Value.ToString();
                    _descripcion = dataGridListado.Rows[i].Cells[(int)Col_Lista.DESCRIPCION].Value.ToString();
                    _cantidad = 1;
                    DataGridViewCheckBoxCell cellSelecion = dataGridListado.Rows[i].Cells[(int)Col_Lista.AGREGAR] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value) == true && _aditivo != 'A')
                    {
                        _Datos.CargarDatos(_tipo, _codigo, _descripcion, _cantidad);
                    }
                    else if (Convert.ToBoolean(cellSelecion.Value) == true && _aditivo == 'A')
                    {
                        _Aditivos.cargarAditivos(_codigo,_descripcion,_cantidad);
                    }                   

                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCheckBoxCell cellSelecion = dataGridListado.Rows[e.RowIndex].Cells[(int)Col_Lista.AGREGAR] as DataGridViewCheckBoxCell;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int u = 0; u < dataGridListado.RowCount; u++)
                {
                    if(dataGridListado.Rows[u].Cells[(int)Col_Lista.DESCRIPCION].Value.ToString().Trim().ToUpper().Contains(metroTextBox1.Text.ToUpper()))
                    {
                        dataGridListado.Rows[u].Visible = true;
                    }
                    else
                    {
                        dataGridListado.Rows[u].Visible = false;
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
