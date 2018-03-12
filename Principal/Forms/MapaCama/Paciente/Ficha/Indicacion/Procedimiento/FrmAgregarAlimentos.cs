using MetroFramework.Forms;
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
    public partial class FrmAgregarAlimentos : MetroForm
    {
        // Lista que almacena los alimentos que se seleccionan con los checkbox
        //public List<string> AlimentosSeleccionados { get; set; }
        AgregarPlan formAnterior;
        


        public FrmAgregarAlimentos(AgregarPlan formAnterior)
        {
            InitializeComponent(); // Aca esta el problema
            this.formAnterior = formAnterior;

            SISTMEDEntities E = new SISTMEDEntities();

            // Obtengo los alimentos disponibles
            var alimentos = from a in E.PRO_Alimento select new { a.alimento_id, a.descripcion };

            // Los pongo en el datagridview
            int indice;
            foreach (var alimento in alimentos)
            {
                indice = datagridAlimentos.Rows.Add();
                datagridAlimentos.Rows[indice].Cells["id"].Value = alimento.alimento_id;
                datagridAlimentos.Rows[indice].Cells["Alimento"].Value = alimento.descripcion; // habia un 1 en cells
            }
        }


        private void datagridAlimentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                datagridAlimentos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Recorro la lista para ver cuales alimentos fueron seleccionados
            for (int i = 0; i < datagridAlimentos.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell cellSelecion = datagridAlimentos.Rows[i].Cells[2] as DataGridViewCheckBoxCell;
                
                if (Convert.ToBoolean(cellSelecion.Value) == true) // si está seleccionado...
                {
                    if(formAnterior.alimentosAAgregar.ContainsKey(Convert.ToInt32(datagridAlimentos.Rows[i].Cells["id"].Value)) == false)
                        formAnterior.alimentosAAgregar.Add(Convert.ToInt32(datagridAlimentos.Rows[i].Cells["id"].Value), datagridAlimentos.Rows[i].Cells["Alimento"].Value.ToString());
                }
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
