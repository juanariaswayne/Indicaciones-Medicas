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
    public partial class Epicrisis : MetroForm
    {
        #region Variables
        public delegate void DatosEvolucion();
        public event DatosEvolucion Datos;

        private enum Col_Epicrisis
        {
            ID = 0,
            FECHA,
            MEDICO_ID,
            SERVICIO,
            TIPO,
            TEXTO
        }
        #endregion
        #region Funciones
        public Epicrisis()
        {
            InitializeComponent();
        }

        public void TraeEpicrisis()
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.HC_TRAEDATOS _obtieneProrrogas = new BLL.Procedures.HC_TRAEDATOS();
                this.dataGridViewEpicrisis.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.HC_TRAEDATOS item in _obtieneProrrogas.ItemList(Clases.Paciente.PacienteIngresado, "EP"))
                {
                    indice = dataGridViewEpicrisis.Rows.Add();
                    dataGridViewEpicrisis.Rows[indice].Cells[(int)Col_Epicrisis.ID].Value = item.hc_id;
                    dataGridViewEpicrisis.Rows[indice].Cells[(int)Col_Epicrisis.MEDICO_ID].Value = item.nombreusuario;
                    dataGridViewEpicrisis.Rows[indice].Cells[(int)Col_Epicrisis.SERVICIO].Value = item.sector;                    
                    dataGridViewEpicrisis.Rows[indice].Cells[(int)Col_Epicrisis.TIPO].Value = item.tipo;                    
                    dataGridViewEpicrisis.Rows[indice].Cells[(int)Col_Epicrisis.TEXTO].Value = item.texto;
                    dataGridViewEpicrisis.Rows[indice].Cells[(int)Col_Epicrisis.FECHA].Value = item.fecha.ToShortDateString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardaEpicrisis()
        {
           
                BLL.Tables.HC _prorrogas = new BLL.Tables.HC();
                Entities.Tables.HC _item = new Entities.Tables.HC();

                _item.PACIENTE_ID = Clases.Paciente.PacienteIngresado;
                _item.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                _item.FECHA = DateTime.Now;
                _item.TEXTO = this.txtEpicrisis.Text;
                _item.TIPO = "EP";               

                _prorrogas.AddItem(_item);
                MessageBox.Show("Se agrego correctamente un nuevo registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Datos();
                TraeEpicrisis();
                //this.Close();

            

        }

        #endregion
        #region Eventos
        private void Epicrisis_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            GuardaEpicrisis();
        }

        #endregion

        private void dataGridViewEpicrisis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtEpicrisis.Text = dataGridViewEpicrisis.CurrentRow.Cells[(int)Col_Epicrisis.TEXTO].Value.ToString();
               
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
