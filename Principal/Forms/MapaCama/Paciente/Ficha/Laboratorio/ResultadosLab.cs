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

namespace Principal.Forms.MapaCama.Paciente.Ficha.Laboratorio
{
    public partial class ResultadosLab : MetroForm
    {
        #region Variables
        private enum Col_Pedidos
        {
            NUM_SOLICITUD = 0,
            FECHA,
            TIPO,
            OBS,
            OTROSESTUDIOS,
            ESTADO,
            SOLICITA
        }
        private enum Col_Resultados
        {
            NUM_SOLICITUD = 0,
            NRO_ORDEN,
            FECHA,
            TIPO,
            ESTADO,
            SOLICITA
        }
        #endregion

        #region Funciones
        public ResultadosLab()
        {
            InitializeComponent();
        }

        private void TraePedidosPendientes()
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.EST_LABORATORIO_TRAEPEDIDOS _obtieneIndicaciones = new BLL.Procedures.EST_LABORATORIO_TRAEPEDIDOS();
                this.dataGridViewPedidos.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.EST_LABORATORIO_TRAEPEDIDOS item in _obtieneIndicaciones.ItemList(Clases.Paciente.PacienteIngresado,1,0,null, DateTime.Now, DateTime.Now, "RES"))
                {

                    indice = dataGridViewPedidos.Rows.Add();
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.NUM_SOLICITUD].Value = item.id_solicitud;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.FECHA].Value = item.fechasolicitud.ToShortDateString();
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.ESTADO].Value = item.descripcionestado;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.OBS].Value = item.observacionesmed;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.OTROSESTUDIOS].Value = item.otrosestudios;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.TIPO].Value = item.tipodescripcion;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.SOLICITA].Value = item.nombreusuario;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraePedidosOrden()
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.EST_LABORATORIO_TRAEPEDIDOS _obtieneIndicaciones = new BLL.Procedures.EST_LABORATORIO_TRAEPEDIDOS();
                this.dataGridViewResultados.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.EST_LABORATORIO_TRAEPEDIDOS item in _obtieneIndicaciones.ItemList(Clases.Paciente.PacienteIngresado, 1, 0, null, DateTime.Now, DateTime.Now, "ORD"))
                {

                    indice = dataGridViewResultados.Rows.Add();
                    dataGridViewResultados.Rows[indice].Cells[(int)Col_Resultados.NUM_SOLICITUD].Value = item.id_solicitud;
                    dataGridViewResultados.Rows[indice].Cells[(int)Col_Resultados.FECHA].Value = item.fechasolicitud.ToShortDateString();
                    dataGridViewResultados.Rows[indice].Cells[(int)Col_Resultados.ESTADO].Value = item.descripcionestado;                   
                    dataGridViewResultados.Rows[indice].Cells[(int)Col_Resultados.TIPO].Value = item.tipodescripcion;
                    dataGridViewResultados.Rows[indice].Cells[(int)Col_Resultados.SOLICITA].Value = item.nombreusuario;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargaLaboratorios()
        {
            try
            {
                TraePedidosPendientes();
                TraePedidosOrden();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        
        #endregion

        #region Eventos
        private void ResultadosLab_Load(object sender, EventArgs e)
        {
            try
            {
                TraePedidosPendientes();
                TraePedidosOrden();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PedidoLab _pedidoLab = new PedidoLab();
                _pedidoLab.Actualiza = true;
                _pedidoLab.SuministroID = Convert.ToInt32(dataGridViewPedidos.CurrentRow.Cells[(int)Col_Pedidos.NUM_SOLICITUD].Value);
                _pedidoLab.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.MapaCama.Paciente.Ficha.Laboratorio.NuevoPedidoLab _PedidoLab = new NuevoPedidoLab();
                _PedidoLab.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNuevoPedido_MouseEnter(object sender, EventArgs e)
        {
            btnNuevoPedido.Style = MetroFramework.MetroColorStyle.Purple;
        }

        private void btnNuevoPedido_MouseLeave(object sender, EventArgs e)
        {
            btnNuevoPedido.Style = MetroFramework.MetroColorStyle.Blue;
        }

        private void dataGridViewResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PedidoLab _pedidoLab = new PedidoLab();
                _pedidoLab.Actualiza = false;
                _pedidoLab.Visor = true;
                _pedidoLab.SuministroID = Convert.ToInt32(dataGridViewResultados.CurrentRow.Cells[(int)Col_Pedidos.NUM_SOLICITUD].Value);
                _pedidoLab.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void metroTile1_Click(object sender, EventArgs e)
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


    }
}
