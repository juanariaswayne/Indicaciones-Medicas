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
    public partial class Frm_OtroFactorPonderacion : MetroForm
    {
        #region Variables
        enum Col_Factores
        {
            COL_FACTOR_ID,
            COL_DESCRIPCION,
            COL_PUNTAJE
        }

         SISTMEDEntities _Mod = new  SISTMEDEntities();
        CultureInfo culture = new CultureInfo("en-US");
        int _FactorId;
        #endregion

        #region Funciones
        public Frm_OtroFactorPonderacion()
        {
            InitializeComponent();
        }

        private void TraerOtrosFactores()
        {
            try
            {
                var _list = (from M in _Mod.MED_OtraPonderacionPuntaje

                             select new
                             {
                                 M.Id,
                                 M.Descripcion,
                                 M.puntaje

                             });
                dataGridViewFactores.Rows.Clear();
                int indice = 0;
                foreach (var item in _list)
                {
                    indice = dataGridViewFactores.Rows.Add();
                    dataGridViewFactores.Rows[indice].Cells[(int)Col_Factores.COL_FACTOR_ID].Value = item.Id; //ID
                    dataGridViewFactores.Rows[indice].Cells[(int)Col_Factores.COL_DESCRIPCION].Value = item.Descripcion; //DESCRIPCION
                    dataGridViewFactores.Rows[indice].Cells[(int)Col_Factores.COL_PUNTAJE].Value = item.puntaje; //PUNTAJE

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
            TextBoxPuntaje.Text = string.Empty;
            _FactorId = 0;

        }
        #endregion

        #region Eventos
        private void Frm_OtroFactorPonderacion_Load(object sender, EventArgs e)
        {
            TraerOtrosFactores();
            _FactorId = 0;
        }
        
        private void dataGridViewFactores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    _FactorId = Convert.ToInt32(dataGridViewFactores.Rows[e.RowIndex].Cells[(int)Col_Factores.COL_FACTOR_ID].Value);
                    TextBoxDescripcion.Text = dataGridViewFactores.Rows[e.RowIndex].Cells[(int)Col_Factores.COL_DESCRIPCION].Value.ToString();
                    TextBoxPuntaje.Text = dataGridViewFactores.Rows[e.RowIndex].Cells[(int)Col_Factores.COL_PUNTAJE].Value.ToString().Replace(",", ".").ToString();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
              

        private void metroTileNuevoIngreso_Click(object sender, EventArgs e)
        {
            NuevoIngreso();
        }

        #endregion

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if(TextBoxDescripcion.Text != string.Empty && TextBoxPuntaje.Text != string.Empty)
                {
                    MED_OtraPonderacionPuntaje _itemFactor = new MED_OtraPonderacionPuntaje();
                    _itemFactor.Descripcion = TextBoxDescripcion.Text;
                    _itemFactor.puntaje = Convert.ToDecimal(TextBoxPuntaje.Text, culture);

                    if(_FactorId == 0 )
                    {
                        _Mod.MED_OtraPonderacionPuntaje.Add(_itemFactor);

                    }
                    else
                    {
                        _itemFactor.Id = _FactorId;
                        _Mod.Entry(_itemFactor).State = System.Data.Entity.EntityState.Modified;

                    }

                    _Mod.SaveChanges();
                    TraerOtrosFactores();
                    NuevoIngreso();
                    MessageBox.Show("Factor creado o Modificado correctemente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
