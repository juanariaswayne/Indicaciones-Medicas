using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
namespace Principal.Forms.ListaEspera
{
    public partial class Frm_Adjuntos : MetroForm
    {
        bool _conFirmaCama = false;

        public Frm_Adjuntos()
        {
            InitializeComponent();
        }

        private void CargaAdjuntos()
        {

            dataGridViewAdjuntos.Rows.Clear();
            int indice = 0;

            DirectoryInfo di = new DirectoryInfo(Directorio);

            foreach (var fi in di.GetFiles())
            {
                indice = dataGridViewAdjuntos.Rows.Add();
                dataGridViewAdjuntos.Rows[indice].Cells[0].Value = fi.FullName.ToString(); //PATH COMPLETO 
                dataGridViewAdjuntos.Rows[indice].Cells[1].Value = fi.Name.ToString(); //NOMBRE DEL ARCHIVO

                indice++;
            }
        }
    

        private string _directorio;

        public string Directorio { get => _directorio; set => _directorio = value; }

        private void Frm_Adjuntos_Load(object sender, EventArgs e)
        {
            try
            {

                CargaAdjuntos();

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewAdjuntos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewAdjuntos.IsCurrentCellDirty)
                dataGridViewAdjuntos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewAdjuntos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              // File.Open(dataGridViewAdjuntos.Rows[e.RowIndex].Cells[0].Value.ToString(),FileMode.Open,FileAccess.ReadWrite);
              
            }

            catch(Exception ex)

            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTileNuevoIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean _selecciono = false;
                for (int i = 0; i < this.dataGridViewAdjuntos.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewAdjuntos.Rows[i].Cells[2] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        _selecciono = true;
                        string _path = dataGridViewAdjuntos.Rows[i].Cells[0].Value.ToString();
                        
                        File.Delete(_path);

                    }

                    
                }
                if (_selecciono)
                {
                    CargaAdjuntos();
                    MessageBox.Show("Adjunto eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un adjunto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
