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

namespace Principal.Forms.MapaCama.Paciente.Ficha.HC
{
    public partial class Prorroga : MetroForm
    {
        #region Variables

        public delegate void DatosProrroga();
        public event DatosProrroga Datos;      

       

        private enum Col_Prorroga
        { ID = 0,          
          FECHA,
          MEDICO_ID,
          SERVICIO,
          TIPO,
          TEXTO
        }
          

        #endregion

        #region Funciones
        public Prorroga()
        {
            InitializeComponent();
        }
      

        private void GuardaProrroga()
        {
            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el Tipo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BLL.Tables.HC _prorrogas = new BLL.Tables.HC();
                Entities.Tables.HC _item = new Entities.Tables.HC();

                _item.PACIENTE_ID = Clases.Paciente.PacienteIngresado;
                _item.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                _item.FECHA = DateTime.Now;
                _item.TEXTO = this.txtProrroga.Text;
                if (cboTipo.SelectedIndex == 0)
                {
                    _item.TIPO = "RE";
                }
                if (cboTipo.SelectedIndex == 1)
                {
                    _item.TIPO = "PR";
                }

                _prorrogas.AddItem(_item);
                MessageBox.Show("Se agrego correctamente un nuevo registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Datos();
                TraeProrrogas();
                //this.Close();

            }

        }

        public void TraeProrrogas()
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.HC_TRAEDATOS _obtieneProrrogas = new BLL.Procedures.HC_TRAEDATOS();
                this.dataGridViewProrrogas.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.HC_TRAEDATOS item in _obtieneProrrogas.ItemList(Clases.Paciente.PacienteIngresado,"RP"))
                {
                    indice = dataGridViewProrrogas.Rows.Add();
                    dataGridViewProrrogas.Rows[indice].Cells[(int)Col_Prorroga.ID].Value = item.hc_id;
                    dataGridViewProrrogas.Rows[indice].Cells[(int)Col_Prorroga.MEDICO_ID].Value = item.nombreusuario;
                    dataGridViewProrrogas.Rows[indice].Cells[(int)Col_Prorroga.SERVICIO].Value = item.sector;
                    if (item.tipo == "PR")
                    {
                        dataGridViewProrrogas.Rows[indice].Cells[(int)Col_Prorroga.TIPO].Value = "Prorroga";
                    }
                    if (item.tipo == "RE")
                    {
                        dataGridViewProrrogas.Rows[indice].Cells[(int)Col_Prorroga.TIPO].Value = "Resumen";
                    }
                    dataGridViewProrrogas.Rows[indice].Cells[(int)Col_Prorroga.TEXTO].Value = item.texto;
                    dataGridViewProrrogas.Rows[indice].Cells[(int)Col_Prorroga.FECHA].Value = item.fecha.ToShortDateString();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Eventos
        private void Evolucion_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #endregion

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardaProrroga();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewProrrogas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtProrroga.Text = dataGridViewProrrogas.CurrentRow.Cells[(int)Col_Prorroga.TEXTO].Value.ToString();
                if (dataGridViewProrrogas.CurrentRow.Cells[(int)Col_Prorroga.TIPO].Value.ToString() == "Resumen")
                {
                    this.cboTipo.SelectedIndex = 0;
                }
                if (dataGridViewProrrogas.CurrentRow.Cells[(int)Col_Prorroga.TIPO].Value.ToString() == "Prorroga")
                {
                    this.cboTipo.SelectedIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            Forms.MapaCama.Paciente.Ficha.HC.ImprimeHC _imprime = new ImprimeHC();
            _imprime.ShowDialog();
        }
    }
}
