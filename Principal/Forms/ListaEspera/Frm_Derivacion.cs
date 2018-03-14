using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Principal.Forms.ListaEspera
{
    public partial class Frm_Derivacion : MetroForm
    {
        enum Col_Modulo
        {
            DERIVA_ID = 0,
            DESCRIPCION
            

        }
        SISTMEDEntities _Mod = new SISTMEDEntities();
        int _derivaId = 0;

        #region Funciones

        public Frm_Derivacion()
        {
            InitializeComponent();
        }


        private void CargarDerivaciones()
        {
            try
            {
                var _list = (from M in _Mod.MED_Derivacion

                             select new
                             {
                                 M.DerivaId,
                                 M.Descripcion
                             
                             });
                dataGridViewDerivaciones.Rows.Clear();
                int indice = 0;
                foreach (var item in _list)
                {
                    indice = dataGridViewDerivaciones.Rows.Add();
                    dataGridViewDerivaciones.Rows[indice].Cells[(int)Col_Modulo.DERIVA_ID].Value = item.DerivaId; //CODIGO
                    dataGridViewDerivaciones.Rows[indice].Cells[(int)Col_Modulo.DESCRIPCION].Value = item.Descripcion; //DESCRIPCION
                   
                    indice++;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NuevoIngreso()
        {
            TextBoxDescripcion.Text = string.Empty;
            _derivaId = 0;

        }

        #endregion

        private void Frm_Derivacion_Load(object sender, EventArgs e)
        {
            CargarDerivaciones();


        }

        private void dataGridViewDerivaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                if (e.RowIndex >= 0)
                {
                    _derivaId = Convert.ToInt32(dataGridViewDerivaciones.Rows[e.RowIndex].Cells[(int)Col_Modulo.DERIVA_ID].Value);
                    TextBoxDescripcion.Text = dataGridViewDerivaciones.Rows[e.RowIndex].Cells[(int)Col_Modulo.DESCRIPCION].Value.ToString();
               

                }

            }

            catch (Exception ex)
            {


            }

        }

        private void metroTileNuevo_Click(object sender, EventArgs e)
        {
            NuevoIngreso();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxDescripcion.Text != string.Empty )
                {
                    MED_Derivacion _deriva = new MED_Derivacion(); //TABLA DERIVACION
                    Clases.IndicacionesBLL.Derivacion _saveObj = new Clases.IndicacionesBLL.Derivacion();

                    _deriva.DerivaId = _derivaId;
                    _deriva.Descripcion = TextBoxDescripcion.Text;
                  
                    //VERIFICO SI ESTA DERIVACIÓN YA ESTA DADA DE ALTA.......

                    if (_derivaId == 0)
                    {
                        if (_saveObj.DerivacionNew(_deriva))
                        {
                            NuevoIngreso();
                            CargarDerivaciones();
                            MessageBox.Show("Derivación creada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    else
                    {
                        if (_saveObj.DerivacionUpdate(_deriva))
                        {
                            NuevoIngreso();
                            CargarDerivaciones();
                            MessageBox.Show("Derivación actualizada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                }

                else
                {
                    MessageBox.Show("Debe Ingresar una descripción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
