using MetroFramework;
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
    public partial class RecepcionMuestras : MetroForm
    {
        #region Variables
        private enum Col_Pedidos
        {
            IMPRIMIR = 0,
            FECHA ,
            NUM_SOLICITUD,
            ID_TIPO,
            TIPO,
            SOLICITA,
            PACIENTE_ID,
            PACIENTE,
            HAB,            
            ESTADO,
            OTROSESTUDIOS,
            OBSERVACIONESMED,
            OBSERVACIONESBIOQ,
            USUARIO_ID
        }

        private enum Col_Estudios
        {
            ESTUDIO_ID = 0,
            ESTUDIODESC            
        }

        private int _Tipo;
        private int _Estado;
        private string _Sector;
        private DateTime _Fecha;
        private DateTime _FechaHasta;
        #endregion

        #region Funciones
        public RecepcionMuestras()
        {
            InitializeComponent();
        }

        private void TraePedidosPendientes(int _Paciente, int _Estado, int _Tipo, string _Sector, DateTime _Fecha, DateTime _FechaHasta, string _Informe)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.EST_LABORATORIO_TRAEPEDIDOS _obtieneIndicaciones = new BLL.Procedures.EST_LABORATORIO_TRAEPEDIDOS();
                this.dataGridViewPedidos.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.EST_LABORATORIO_TRAEPEDIDOS item in _obtieneIndicaciones.ItemList(_Paciente, _Estado, _Tipo, _Sector, _Fecha, _FechaHasta, _Informe))
                {

                    indice = dataGridViewPedidos.Rows.Add();
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.NUM_SOLICITUD].Value = item.id_solicitud;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.FECHA].Value = item.fechasolicitud.ToShortDateString();
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.ESTADO].Value = item.estado_id;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.PACIENTE_ID].Value = item.paciente_id;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.ID_TIPO].Value = item.tipo;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.TIPO].Value = item.tipodescripcion;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.SOLICITA].Value = item.nombreusuario;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.PACIENTE].Value = item.nombre + " " + item.apellido;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.HAB].Value = item.hab;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.OTROSESTUDIOS].Value = item.otrosestudios;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.OBSERVACIONESMED].Value = item.observacionesmed;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.OBSERVACIONESBIOQ].Value = item.observacionesbioq;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.USUARIO_ID].Value = item.id_usuario;

                    //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.RECIBIDO];
                    //if (item.estado_id != 1)
                    //{
                    //    chk.Value = true;
                    //}

                    //DataGridViewRow row = dataGridViewPedidos.Rows[indice];
                    //DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Pedidos.ESTADO] as DataGridViewComboBoxCell;
                    //CargarEstados(comboboxColumnSector);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeDatosLaboratorio(int _pedidoLab)
        {
            try
            {

                dataGridViewEstudios.Rows.Clear();
                BLL.Procedures.EST_LABORATORIO_TRAEUNPEDIDO _obtieneIndicaciones = new BLL.Procedures.EST_LABORATORIO_TRAEUNPEDIDO();
                int indice;
                foreach (Entities.Procedures.EST_LABORATORIO_TRAEUNPEDIDO item in _obtieneIndicaciones.ItemList(_pedidoLab))
                {                     

                        indice = dataGridViewEstudios.Rows.Add();
                        dataGridViewEstudios.Rows[indice].Cells[(int)Col_Estudios.ESTUDIO_ID].Value = item.estudio_id;
                        dataGridViewEstudios.Rows[indice].Cells[(int)Col_Estudios.ESTUDIODESC].Value = item.descestudio;                  
                    

                }
                dataGridViewEstudios.ReadOnly = true;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ActualizaMuestras()
        {
            try
            {
                Entities.Tables.EST_LABORATORIOCAB _item = new Entities.Tables.EST_LABORATORIOCAB();
                BLL.Tables.EST_LABORATORIOCAB _lab = new BLL.Tables.EST_LABORATORIOCAB();
                for (int i = 0; i < this.dataGridViewPedidos.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.IMPRIMIR] as DataGridViewCheckBoxCell;

                    _item.ID_SOLICITUD = Convert.ToInt32(dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.NUM_SOLICITUD].Value);
                    _item.PACIENTE_ID = Convert.ToInt32(dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.PACIENTE_ID].Value);
                    _item.FECHASOLICITUD = Convert.ToDateTime(dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.FECHA].Value);
                    _item.TIPO = Convert.ToInt32(dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.ID_TIPO].Value);
                    _item.ESTADO_ID = Convert.ToInt32(dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.ESTADO].Value);
                    _item.OTROSESTUDIOS = dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.OTROSESTUDIOS].Value.ToString();
                    _item.OBSERVACIONESMED = dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.OBSERVACIONESMED].Value.ToString();
                    _item.OBSERVACIONESBIOQ = dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.OBSERVACIONESBIOQ].Value.ToString();
                    _item.USUARIO_ID = Convert.ToInt32(dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.USUARIO_ID].Value);

                    _lab.UpdateItem(_item);
                }

                MetroMessageBox.Show(this,"Se actualizaron correctamente los pedidos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region Eventos
        private void RecepcionMuestras_Load(object sender, EventArgs e)
        {
            try
            {
                 dateTimeHasta.Value = dateTimeHasta.Value.AddDays(1);
                _Fecha = this.dateTimeDesde.Value;
                _FechaHasta = this.dateTimeHasta.Value;
                _Sector = "1";               
                _Tipo = 1;
                _Estado = 1;

                TraePedidosPendientes(0, _Estado, _Tipo, _Sector, _Fecha, _FechaHasta, "TOD");
                TraeDatosLaboratorio(Convert.ToInt32(dataGridViewPedidos.CurrentRow.Cells[(int)Col_Pedidos.NUM_SOLICITUD].Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecepcionMuestras_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {
            _Fecha = this.dateTimeDesde.Value;
            _FechaHasta = this.dateTimeHasta.Value;
            TraePedidosPendientes(0, _Estado, _Tipo, _Sector, _Fecha, _FechaHasta, "TOD");
        }
        private void dateTimeHasta_ValueChanged(object sender, EventArgs e)
        {
            _Fecha = this.dateTimeDesde.Value;
            _FechaHasta = this.dateTimeHasta.Value;
            TraePedidosPendientes(0, _Estado, _Tipo, _Sector, _Fecha, _FechaHasta, "TOD");
        }

        private void dataGridViewPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                int _Pedido = Convert.ToInt32(dataGridViewPedidos.Rows[e.RowIndex].Cells[(int)Col_Pedidos.NUM_SOLICITUD].Value);
                TraeDatosLaboratorio(_Pedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void chckSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chckSelectAll.Checked)
                {
                    for (int i = 0; i < this.dataGridViewPedidos.Rows.Count; i++)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.IMPRIMIR];
                        chk.Value = true;
                    }
                }
                else
                {
                    for (int i = 0; i < this.dataGridViewPedidos.Rows.Count; i++)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.IMPRIMIR];
                        chk.Value = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
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
