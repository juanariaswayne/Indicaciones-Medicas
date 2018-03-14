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
    public partial class Frm_SectoresMails : MetroForm
    {
        #region Variables

        enum Col_Factores
        {
            COL_SEDE_ID,
            COL_SECTOR_ID,
            COL_DESCRIPCION
        }


        SISTMEDEntities _Mod = new SISTMEDEntities();

        #endregion
        #region Funciones
        public Frm_SectoresMails()
        {
            InitializeComponent();
        }

        private void CargarSedes()
        {
            try
            {

                var _listObj = (from sede in _Mod.Sedes orderby sede.descripcion select sede).ToList();

                Sedes _itemSeleccion = new Sedes();

                //Limpia el combo
                this.comboBoxSede.SuspendLayout();
                this.comboBoxSede.DataSource = null;
                this.comboBoxSede.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione una Sede>";
                _itemSeleccion.sede_id = 0;
                _listObj.Insert(0, _itemSeleccion);
                //Carga el combo
                this.comboBoxSede.DisplayMember = "descripcion";
                this.comboBoxSede.ValueMember = "sede_id";
                this.comboBoxSede.DataSource = _listObj;
                this.comboBoxSede.ResumeLayout();

                comboBoxSede.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraerSectores(int _sede)
        {
            try
            {
                var _list = (from M in _Mod.MED_SectorMails where M.sede_id == _sede select  M).ToList();

                dataGridViewSectores.Rows.Clear();
                int indice = 0;
                foreach (var item in _list)
                {
                    indice = dataGridViewSectores.Rows.Add();
                    dataGridViewSectores.Rows[indice].Cells[(int)Col_Factores.COL_SEDE_ID].Value = item.sede_id; //sede ID
                    dataGridViewSectores.Rows[indice].Cells[(int)Col_Factores.COL_SECTOR_ID].Value = item.sector_id; //SECTOR_ID
                    dataGridViewSectores.Rows[indice].Cells[(int)Col_Factores.COL_DESCRIPCION].Value = item.descripcion; //DESCRIPCION

                    indice++;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Eventos

        private void Frm_SectoresMails_Load(object sender, EventArgs e)
        {

            CargarSedes();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }




        #endregion

        private void comboBoxSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxSede.SelectedIndex > 0)
                {
                    TraerSectores(Convert.ToInt32(comboBoxSede.SelectedValue));
                    
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxSede.SelectedIndex > 0 && textBoxDescripcion.Text != string.Empty)
                {
                    _Mod.MED_ingresoSectorMail(Convert.ToInt32(comboBoxSede.SelectedValue), textBoxDescripcion.Text);

                    MessageBox.Show("Sector creado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TraerSectores(Convert.ToInt32(comboBoxSede.SelectedValue));
                    textBoxDescripcion.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Debe seleccionar una Sede e ingresar una Descripción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxDescripcion.Focus();
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void metroTileNuevo_Click(object sender, EventArgs e)
        {
            textBoxDescripcion.Text = string.Empty;
        }

        private void dataGridViewSectores_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewSectores.IsCurrentCellDirty)
                dataGridViewSectores.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
