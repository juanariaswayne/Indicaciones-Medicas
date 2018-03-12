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
    public partial class AutorizacionLab : MetroForm
    {
        #region Variables
        private enum Col_Pedidos
        {
            FECHA = 0,
            NUM_SOLICITUD,
            ID_TIPO,
            TIPO,
            SOLICITA,
            PACIENTE_ID,
            PACIENTE,
            HAB,
            RECIBIDO,
            ESTADO,
            OTROSESTUDIOS,
            OBSERVACIONESMED,
            OBSERVACIONESBIOQ,
            USUARIO_ID
        }

        private int _Tipo;
        private int _Estado;
        private string _Sector;
        private DateTime _Fecha;
        private DateTime _FechaHasta;
        #endregion

        #region Funciones
        public AutorizacionLab()
        {
            InitializeComponent();
        }
        
        private void TraePedidosPendientes(int _Paciente,int _Estado, int _Tipo,string _Sector, DateTime _Fecha, DateTime _FechaHasta, string _Informe)
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
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.PACIENTE].Value = item.nombre+" "+item.apellido;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.HAB].Value = item.hab;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.OTROSESTUDIOS].Value = item.otrosestudios;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.OBSERVACIONESMED].Value = item.observacionesmed;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.OBSERVACIONESBIOQ].Value = item.observacionesbioq;
                    dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.USUARIO_ID].Value = item.id_usuario;

                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridViewPedidos.Rows[indice].Cells[(int)Col_Pedidos.RECIBIDO];
                    if (item.estado_id != 1)
                    {
                        chk.Value = true;
                    }

                    DataGridViewRow row = dataGridViewPedidos.Rows[indice];
                    DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Pedidos.ESTADO] as DataGridViewComboBoxCell;
                    CargarEstados(comboboxColumnSector);                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCboEstados()
        {
            try
            {
                BLL.Tables.EST_LABORATORIOESTADOS _os = new BLL.Tables.EST_LABORATORIOESTADOS();
                Entities.Tables.EST_LABORATORIOESTADOS _itemSeleccion = new Entities.Tables.EST_LABORATORIOESTADOS();
                List<Entities.Tables.EST_LABORATORIOESTADOS> _ItemsOS = new List<Entities.Tables.EST_LABORATORIOESTADOS>();
                //Limpia el combo
                this.cboEstado.SuspendLayout();
                this.cboEstado.DataSource = null;
                this.cboEstado.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCIONESTADO = "<Seleccione>";
                _itemSeleccion.ESTADO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboEstado.DisplayMember = BLL.Tables.EST_LABORATORIOESTADOS.ColumnNames.DESCRIPCIONESTADO;
                this.cboEstado.ValueMember = BLL.Tables.EST_LABORATORIOESTADOS.ColumnNames.ESTADO_ID;
                this.cboEstado.DataSource = _ItemsOS;
                this.cboEstado.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstados(DataGridViewComboBoxCell comboboxColumnSector)
        {
            try
            {
                BLL.Tables.EST_LABORATORIOESTADOS _est = new BLL.Tables.EST_LABORATORIOESTADOS();
                Entities.Tables.EST_LABORATORIOESTADOS _itemSeleccion = new Entities.Tables.EST_LABORATORIOESTADOS();                
                List<Entities.Tables.EST_LABORATORIOESTADOS> _miMarca = new List<Entities.Tables.EST_LABORATORIOESTADOS>();

                
                comboboxColumnSector.DataSource = null;
                comboboxColumnSector.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCIONESTADO = "<Sin Definir>";// (_miMarca.Count > 0) ? "<Seleccione una Marca>" : "<Sin Definir>";
                _itemSeleccion.ESTADO_ID = 0;
                _miMarca = _est.ItemList();
                _miMarca.Insert(0, _itemSeleccion);

                //Carga el combo
                
                comboboxColumnSector.DisplayMember = BLL.Tables.EST_LABORATORIOESTADOS.ColumnNames.DESCRIPCIONESTADO;
                comboboxColumnSector.ValueMember = BLL.Tables.EST_LABORATORIOESTADOS.ColumnNames.ESTADO_ID;
                comboboxColumnSector.DataSource = _miMarca.ToArray();

                //FIN CARGO COMBO TIPO RECLAMO

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion

        #region Eventos
        private void AutorizacionLab_Load(object sender, EventArgs e)
        {
            try
            {
                _Fecha = this.DateFecha.Value;
                _FechaHasta = this.dateHasta.Value;
                this.dateHasta.Hide();
                CargarCboEstados();
                this.cboSector.SelectedIndex = 0;
                this.cboTipoPedido.SelectedIndex = 0;
                this.cboEstado.SelectedIndex = 1;
                _Tipo = this.cboTipoPedido.SelectedIndex +1 ;
                _Estado = Convert.ToInt32(cboEstado.SelectedValue);
                if (cboSector.SelectedIndex == 0)
                { _Sector = "GEN"; }
                if (cboSector.SelectedIndex == 1)
                { _Sector = "MIC"; }

                TraePedidosPendientes(0, _Estado, _Tipo, _Sector, _Fecha, _FechaHasta, "FEC");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
      

        private void AutorizacionLab_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DateFecha_ValueChanged(object sender, EventArgs e)
        {
            if (chckLapsoTiempo.Checked == false)
            {
                _Fecha = this.DateFecha.Value;
                _FechaHasta = this.DateFecha.Value;
            }
            else
            {
                _Fecha = this.DateFecha.Value;
                _FechaHasta = this.dateHasta.Value;
            }
                             
             TraePedidosPendientes(0, _Estado, _Tipo, _Sector, _Fecha, _FechaHasta, "FEC");                        
        }

        private void chckLapsoTiempo_CheckedChanged(object sender, EventArgs e)
        {
            if (chckLapsoTiempo.Checked)
            {
                dateHasta.Show();
            }
            else
            {
                dateHasta.Hide();
            }
        }

        private void cboSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSector.SelectedIndex == 0)
            {
                _Sector = "GEN";
                TraePedidosPendientes(0, _Estado, _Tipo, _Sector, _Fecha, _FechaHasta, "FEC");
            }
            else
            {
                _Sector = "MIC";
                TraePedidosPendientes(0, _Estado, _Tipo, _Sector, _Fecha, _FechaHasta, "FEC");
            }
        }

        private void cboTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Tipo = cboTipoPedido.SelectedIndex + 1;
            TraePedidosPendientes(0, _Estado, _Tipo, _Sector, _Fecha, _FechaHasta, "FEC");
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Estado = Convert.ToInt32(cboEstado.SelectedValue);
            TraePedidosPendientes(0, _Estado, _Tipo, _Sector, _Fecha, _FechaHasta, "FEC");
        }

        private void dateHasta_ValueChanged(object sender, EventArgs e)
        {
            _Fecha = this.DateFecha.Value;
            _FechaHasta = this.dateHasta.Value;
            TraePedidosPendientes(0, _Estado, _Tipo, _Sector, _Fecha, _FechaHasta, "FEC");

        }

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Orange;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Red;
        }

        private void btnImprimir_MouseEnter(object sender, EventArgs e)
        {
            this.btnImprimir.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            this.btnImprimir.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void dataGridViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == (int)Col_Pedidos.RECIBIDO)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewPedidos.Rows[e.RowIndex].Cells[(int)Col_Pedidos.RECIBIDO] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        dataGridViewPedidos.Rows[e.RowIndex].Cells[(int)Col_Pedidos.ESTADO].Value = 2;
                    }

                    if (Convert.ToBoolean(cellSelecion.Value) == false)
                    {
                        dataGridViewPedidos.Rows[e.RowIndex].Cells[(int)Col_Pedidos.ESTADO].Value = 1;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewPedidos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewPedidos.IsCurrentCellDirty)
                dataGridViewPedidos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }      

        private void dataGridViewPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clases.Paciente.PacienteIngresado = Convert.ToInt32(dataGridViewPedidos.CurrentRow.Cells[(int)Col_Pedidos.PACIENTE_ID].Value);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.Tables.EST_LABORATORIOCAB _item = new Entities.Tables.EST_LABORATORIOCAB();
                BLL.Tables.EST_LABORATORIOCAB _lab = new BLL.Tables.EST_LABORATORIOCAB();
                for (int i = 0; i < this.dataGridViewPedidos.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewPedidos.Rows[i].Cells[(int)Col_Pedidos.RECIBIDO] as DataGridViewCheckBoxCell;

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

                MessageBox.Show("Se actualizaron correctamente los pedidos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Forms.MapaCama.Paciente.Ficha.Laboratorio.ImpresionLab _ImpLab = new ImpresionLab();
                _ImpLab.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion


    }
}
