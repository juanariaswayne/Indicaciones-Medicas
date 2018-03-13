using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Globalization;
namespace Principal.Forms.ListaEspera
{
    public partial class Frm_ModuloEmpresa : MetroForm
    {
        #region Variables
        SISTMEDEntities _Mod = new SISTMEDEntities();

        enum Col_Modulo
        {
            CODIGO=0,
            DESCRIPCION,
            PUNTAJE

        }
        CultureInfo culture = new CultureInfo("en-US");
        #endregion
        #region Funciones
        public Frm_ModuloEmpresa()
        {
            InitializeComponent();
        }

        private void CargarModulosEmpresa()
        {
            try
            {
                var _list = (from M in _Mod.MED_Modulo
                            
                             select new
                             {
                                 M.modulo_id,
                                 M.Descripcion,
                                 M.puntaje
                             
                                 

                             });
                dataGridViewModulos.Rows.Clear();
                int indice = 0;
                foreach ( var item in _list)
                {
                    indice = dataGridViewModulos.Rows.Add();
                    dataGridViewModulos.Rows[indice].Cells[(int)Col_Modulo.CODIGO].Value = item.modulo_id; //CODIGO
                    dataGridViewModulos.Rows[indice].Cells[(int)Col_Modulo.DESCRIPCION].Value = item.Descripcion; //DESCRIPCION
                    dataGridViewModulos.Rows[indice].Cells[(int)Col_Modulo.PUNTAJE].Value = item.puntaje; //PUNTAJE
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
            TextBoxCodigo.Text = string.Empty;
            TextBoxDescripcion.Text = string.Empty;
            labelModulo.Text = string.Empty;
            TextBoxPuntaje.Text = string.Empty;
        }

        private bool ValidarIngreso()
        {
            try
            {
                if(TextBoxCodigo.Text == string.Empty)
                {
                    errorProvider1.SetError(TextBoxCodigo, "Debe ingresar un código");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(TextBoxCodigo,"");
                }

                if (TextBoxDescripcion.Text == string.Empty)
                {
                    errorProvider1.SetError(TextBoxDescripcion, "Debe ingresar una Descripcion");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(TextBoxDescripcion, "");
                }

                if (TextBoxPuntaje.Text == string.Empty)
                {
                    errorProvider1.SetError(TextBoxPuntaje, "Debe ingresar puntaje");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(TextBoxPuntaje, "");
                }

                return true;
            }

            catch(Exception ex)
            {
                return false;

            }

        }



        #endregion

        #region Eventos

        private void Frm_ModuloEmpresa_Load(object sender, EventArgs e)
        {
            CargarModulosEmpresa();
            labelModulo.Text = string.Empty;
        }

        #endregion

        private void dataGridViewModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    TextBoxCodigo.Text = dataGridViewModulos.Rows[e.RowIndex].Cells[(int)Col_Modulo.CODIGO].Value.ToString();
                    TextBoxDescripcion.Text = dataGridViewModulos.Rows[e.RowIndex].Cells[(int)Col_Modulo.DESCRIPCION].Value.ToString();
                    //GUARDO EL CODIGO EN ESTA VARIABLE, PARA DETERMINAR SI ESTA MODIFICANDO O DANDO DE ALTA UNO NUEVO
                    labelModulo.Text = dataGridViewModulos.Rows[e.RowIndex].Cells[(int)Col_Modulo.CODIGO].Value.ToString();
                    TextBoxPuntaje.Text = dataGridViewModulos.Rows[e.RowIndex].Cells[(int)Col_Modulo.PUNTAJE].Value.ToString().Replace(",", ".").ToString();
                   
                }
                
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTileNuevo_Click(object sender, EventArgs e)
        {
            NuevoIngreso();
            TextBoxCodigo.Focus();
        }

        private void TextBoxCostoRSC_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == culture.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TextBoxCostoEGES_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == culture.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // decimal _precio = Convert.ToDecimal(dataGridViewOCItem.Rows[i].Cells[(int)Col_OCItem.PRECIO].Value.ToString(), culture);
            // dataGridViewOCItem.Rows[indice].Cells[(int)Col_OCItem.CANTIDAD].Value = item.cantidad.ToString().Replace(",", ".");//CANTIDAD  
            try
            {
                if(ValidarIngreso())
                {
                    MED_Modulo _modulo = new MED_Modulo(); //TABLA MED_MODULO
                    Clases.IndicacionesBLL.Modulo _saveObj = new Clases.IndicacionesBLL.Modulo();

                    _modulo.modulo_id = TextBoxCodigo.Text;
                    _modulo.Descripcion = TextBoxDescripcion.Text;
                    _modulo.puntaje = Convert.ToDecimal(TextBoxPuntaje.Text.ToString(),culture);
                    
                    //VERIFICO SI ESTE MÓDULO YA ESTA DADO DE ALTA.......

                    if (labelModulo.Text == string.Empty)
                    {
                        if (_saveObj.ModuloNew(_modulo))
                        {
                            NuevoIngreso();
                            CargarModulosEmpresa();
                            MessageBox.Show("Módulo creado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    else
                    {
                        if (_saveObj.ModuloUpdate(_modulo))
                        {
                            NuevoIngreso();
                            CargarModulosEmpresa();
                            MessageBox.Show("Módulo actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SOLO INGRESO MAYUSCULAS
            if (e.KeyChar.ToString() == e.KeyChar.ToString().ToUpper())
                return;

            e.Handled = true;
            SendKeys.Send(e.KeyChar.ToString().ToUpper());
        }

        private void dataGridViewModulos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewModulos.IsCurrentCellDirty)
                dataGridViewModulos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void TextBoxPuntaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ACEPTA SOLO NUMEROS
            //if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    e.Handled = true;
            //    return;
            //}

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == culture.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
