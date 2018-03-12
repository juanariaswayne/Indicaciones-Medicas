using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.Parametros.Medicamento
{
    public partial class AsociaCodigoBejerman : MetroForm
    {
        #region Variables
        SISTMEDEntities E = new SISTMEDEntities();
        private enum Col_Medicamentos
        {
            MEDICAMENTO_ID = 0,
            MEDICAMENTO,
            POTENCIA,
            PRESENTACION,
            UNI_MED,
            CODIGO_BEJERMAN,
            X
        }
        #endregion
        #region Funciones
        public AsociaCodigoBejerman()
        {
            InitializeComponent();
        }

        private void TraeMedicamentosPendientes()
        {
            try
            {
                dataGridViewMedicamentos.Rows.Clear();
                int indice;
                foreach (var _item in E.MED_Solicita_Medicamento_Nuevo.Where(s=>s.bejerman_id == null && s.autoriza == true && s.pendiente == false))
                {
                    indice = dataGridViewMedicamentos.Rows.Add();
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.MEDICAMENTO_ID].Value = _item.medicamento_id;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.MEDICAMENTO].Value = _item.medicamento;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.POTENCIA].Value = _item.Potencia;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.PRESENTACION].Value = _item.MED_Presentacion.descripcion;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.UNI_MED].Value = _item.MED_UnidadDeMedida.descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarCodigosEnBase(string _codigoBejerman, int _codigoActual)
        {
            try
            {
              E.Database.ExecuteSqlCommand(
             "ActualizaCodigosBejerman @codigoBejerman, @codigoMedicamentoAnt",
              new SqlParameter("codigoBejerman", _codigoBejerman),
              new SqlParameter("@codigoMedicamentoAnt", _codigoActual));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Eventos
        private void AsociaCodigoBejerman_Load(object sender, EventArgs e)
        {
            try
            {
                TraeMedicamentosPendientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();
                E.Configuration.ValidateOnSaveEnabled = false;
                E.Configuration.ProxyCreationEnabled = false;
                for(int i = 0; i < dataGridViewMedicamentos.Rows.Count; i++)
                {
                    if(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos.CODIGO_BEJERMAN].Value != null)//Verifico que tenga un codigo
                    {
                        string _codigoBejerman = dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos.CODIGO_BEJERMAN].Value.ToString().Trim().PadRight(20);
                        int _codigoMedicamento = Convert.ToInt32(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos.MEDICAMENTO_ID].Value);

                        MED_Solicita_Medicamento_Nuevo _itemSolicita = new MED_Solicita_Medicamento_Nuevo
                        {
                            medicamento_id = _codigoMedicamento,
                            bejerman_id = _codigoBejerman
                        };

                        E.MED_Solicita_Medicamento_Nuevo.Attach(_itemSolicita);
                        E.Entry(_itemSolicita).Property(s => s.bejerman_id).IsModified = true;

                        ActualizarCodigosEnBase(_codigoBejerman,_codigoMedicamento);
                    }
                }

                E.SaveChanges();                

                TraeMedicamentosPendientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            try
            {
                TraeMedicamentosPendientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void dataGridViewMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == (int)Col_Medicamentos.X)
                {
                    DialogResult dialogResult = MetroMessageBox.Show(this, "Desea marcar este medicamento sin Codigo en Bejerman (No se Compra ni Stockea)?", "Sin Codigo Asociado", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SISTMEDEntities E = new SISTMEDEntities();
                        E.Configuration.ValidateOnSaveEnabled = false;
                        E.Configuration.ProxyCreationEnabled = false;                       
                                                          
                        int _codigoMedicamento = Convert.ToInt32(dataGridViewMedicamentos.CurrentRow.Cells[(int)Col_Medicamentos.MEDICAMENTO_ID].Value);

                        MED_Solicita_Medicamento_Nuevo _itemSolicita = new MED_Solicita_Medicamento_Nuevo
                        {
                             medicamento_id = _codigoMedicamento,
                              bejerman_id = "SIN CODIGO"
                        };

                        E.MED_Solicita_Medicamento_Nuevo.Attach(_itemSolicita);
                        E.Entry(_itemSolicita).Property(s => s.bejerman_id).IsModified = true;                         

                        E.SaveChanges();

                        TraeMedicamentosPendientes();
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
