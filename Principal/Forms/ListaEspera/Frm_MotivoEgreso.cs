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
    public partial class Frm_MotivoEgreso : MetroForm
    {
        #region Variables
        enum Col_Motivos
        {
            COL_ID,
            COL_DESCRIPCION,
            ID_TIPO,
            TIPO_MOTIVO
            
        }

        SISTMEDEntities _Mod = new SISTMEDEntities();
        int _motivoID = 0;
        #endregion

        #region Funciones
        public Frm_MotivoEgreso()
        {
            InitializeComponent();
        }

        private void TraerMotivos()
        {
            try
            {
                //var _list = (from M in _Mod.MotivoEgreso orderby M.Descripcion

                //             select new
                //             {
                //                 M.motivoEgreso_id,
                //                 M.Descripcion

                //             });
                SISTMEDEntities _ModEgreso = new SISTMEDEntities();
                var _list = (from M in _ModEgreso.MotivoEgreso
                             orderby M.Descripcion  select M).ToList();

                dataGridViewMotivos.Rows.Clear();
                int indice = 0;
                foreach (var item in _list)
                {
                    indice = dataGridViewMotivos.Rows.Add();
                    dataGridViewMotivos.Rows[indice].Cells[(int)Col_Motivos.COL_ID].Value = item.motivoEgreso_id; //ID
                    dataGridViewMotivos.Rows[indice].Cells[(int)Col_Motivos.COL_DESCRIPCION].Value = item.Descripcion; //DESCRIPCION
                    dataGridViewMotivos.Rows[indice].Cells[(int)Col_Motivos.ID_TIPO].Value = item.tipo_id; // ID TIPO MOTIVO EGRESO
                    dataGridViewMotivos.Rows[indice].Cells[(int)Col_Motivos.TIPO_MOTIVO].Value = item.MED_TipoEgreso.Descripcion; //DESCRIPCION TIPO MOTIVO

                    indice++;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TraeTipoEgreso()
        {
            try
            {
                var _listObj = (from Tipos in _Mod.MED_TipoEgreso
                                orderby Tipos.Descripcion
                                select Tipos).ToList();

                MED_TipoEgreso _itemSeleccion = new MED_TipoEgreso();

                //Limpia el combo
                comboBoxDesde.SuspendLayout();
                comboBoxDesde.DataSource = null;
                comboBoxDesde.Items.Clear();

                // Carga el item de Seleccion
                _itemSeleccion.Descripcion = "<Seleccione un Tipo de Egreso>";
                _itemSeleccion.tipo_id = 0;
                _listObj.Insert(0, _itemSeleccion);

                //Carga el combo
                comboBoxDesde.DisplayMember = "Descripcion";
                comboBoxDesde.ValueMember = "tipo_id";
                comboBoxDesde.DataSource = _listObj.ToArray();
                comboBoxDesde.SelectedIndex = 0;

                comboBoxDesde.ResumeLayout();

            }

            catch (Exception ex)
            {


            }
        }
        #endregion

        private void Frm_MotivoEgreso_Load(object sender, EventArgs e)
        {

            TraerMotivos();

            TraeTipoEgreso();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTileNuevoIngreso_Click(object sender, EventArgs e)
        {
            TextBoxDescripcion.Text = string.Empty;
        }

        private void dataGridViewMotivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    _motivoID = Convert.ToInt32(dataGridViewMotivos.Rows[e.RowIndex].Cells[(int)Col_Motivos.COL_ID].Value);
                    TextBoxDescripcion.Text = dataGridViewMotivos.Rows[e.RowIndex].Cells[(int)Col_Motivos.COL_DESCRIPCION].Value.ToString();
                   comboBoxDesde.SelectedValue  = dataGridViewMotivos.Rows[e.RowIndex].Cells[(int)Col_Motivos.ID_TIPO].Value;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxDescripcion.Text != string.Empty && comboBoxDesde.SelectedIndex > 0)
                {
                    MotivoEgreso _newitemMotivo = new MotivoEgreso();
                    _newitemMotivo.Descripcion = TextBoxDescripcion.Text;
                    _newitemMotivo.tipo_id = Convert.ToInt32(comboBoxDesde.SelectedValue);

                    _Mod.Configuration.AutoDetectChangesEnabled = false;
                    _Mod.Configuration.ValidateOnSaveEnabled = false;


                    if (_motivoID == 0)
                    {
                       
                        _Mod.MotivoEgreso.Add(_newitemMotivo);

                    }
                    else
                    {
                        //_newitemMotivo.motivoEgreso_id = _motivoID;
                        //_Mod.MotivoEgreso.Attach(_newitemMotivo);

                        //_Mod.Entry(_newitemMotivo).Property(m => m.Descripcion).IsModified = true;


                        //LLAMO AL STORED QUE ACTUALIZA       
                       // _Mod.Entry(_newitemMotivo).State = System.Data.Entity.EntityState.Modified;

                        _Mod.MED_ActualizaMotivoEgreso(_motivoID, TextBoxDescripcion.Text, _newitemMotivo.tipo_id);


                    }

                    _Mod.SaveChanges();
                    TraerMotivos();
                    comboBoxDesde.SelectedIndex = 0;
                    TextBoxDescripcion.Text = string.Empty;
                    MessageBox.Show("Motivo creado o Modificado correctemente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                else
                {
                    MessageBox.Show("Debe ingresar Descripción y Tipo de Egreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
