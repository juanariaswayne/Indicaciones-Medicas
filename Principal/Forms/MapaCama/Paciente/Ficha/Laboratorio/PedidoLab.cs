using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Laboratorio
{
    public partial class PedidoLab : MetroForm
    {
        #region Variables
        private bool _Actualiza;
        private int _SuministroID;
        private int _NSolicitud;
        private bool _Visor;

        public bool Actualiza
        {
            get
            {
                return _Actualiza;
            }

            set
            {
                this._Actualiza = value;
            }
        }

        public int SuministroID
        {
            get
            {
                return _SuministroID;
            }

            set
            {
                this._SuministroID = value;
            }
        }

        public bool Visor
        {
            get
            {
                return _Visor;
            }

            set
            {
                this._Visor = value;
            }
        }

        private enum Col_Estudios
        {
            ESTUDIO_ID = 0,
            ESTUDIODESC,
            X,
            NRO_ITEM
        }
        #endregion

        #region Funciones
        public PedidoLab()
        {
            InitializeComponent();
        }

        private void permisosEdicion(int _idPermiso)
        {
           
        }

        private void GuardaPedido()
        {
            try
            {
                BLL.Tables.EST_LABORATORIOCAB _cabLab = new BLL.Tables.EST_LABORATORIOCAB();
                Entities.Tables.EST_LABORATORIOCAB _itemCab = new Entities.Tables.EST_LABORATORIOCAB();

                BLL.Tables.EST_LABORATORIOITEMS _itemLab = new BLL.Tables.EST_LABORATORIOITEMS();
                List<Entities.Tables.EST_LABORATORIOITEMS> _itemLabItems = new List<Entities.Tables.EST_LABORATORIOITEMS>();
                //Entities.Tables.EST_LABORATORIOITEMS _itemItems = new Entities.Tables.EST_LABORATORIOITEMS();

                _itemCab.FECHASOLICITUD = this.dateFecha.Value;
                _itemCab.ESTADO_ID = 1;
                _itemCab.OBSERVACIONESMED = this.txtObsMedico.Text;
                _itemCab.OTROSESTUDIOS = this.txtOtrosAnalisis.Text;
                _itemCab.OBSERVACIONESBIOQ = this.txtObsBioq.Text;
                if (chckUrgente.Checked)
                { _itemCab.TIPO = 2; }
                else { _itemCab.TIPO = 1; }
                _itemCab.PACIENTE_ID = Clases.Paciente.PacienteIngresado;
                _itemCab.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;

                
                for (int i = 0; i < this.dataGridViewPedido.Rows.Count; i++)
                {
                    Entities.Tables.EST_LABORATORIOITEMS _itemItems = new Entities.Tables.EST_LABORATORIOITEMS();
                    _itemItems.ESTUDIO_ID = Convert.ToInt32(dataGridViewPedido.Rows[i].Cells[(int)Col_Estudios.ESTUDIO_ID].Value);
                    _itemLabItems.Add(_itemItems);
                }                   

                _cabLab.GrabaLaboratorio(_itemLabItems, _itemCab);//Graba lista de Items y cabecera
                MetroMessageBox.Show(this,"Se realizo correctamente el pedido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizaPedido(int _pedidoID)
        {
            try
            {
                BLL.Tables.EST_LABORATORIOCAB _cabLab = new BLL.Tables.EST_LABORATORIOCAB();
                Entities.Tables.EST_LABORATORIOCAB _itemCab = new Entities.Tables.EST_LABORATORIOCAB();

                BLL.Tables.EST_LABORATORIOITEMS _itemLab = new BLL.Tables.EST_LABORATORIOITEMS();
                List<Entities.Tables.EST_LABORATORIOITEMS> _itemLabItems = new List<Entities.Tables.EST_LABORATORIOITEMS>();
                //Entities.Tables.EST_LABORATORIOITEMS _itemItems = new Entities.Tables.EST_LABORATORIOITEMS();

                _itemCab.FECHASOLICITUD = this.dateFecha.Value;
                _itemCab.ESTADO_ID = 1;
                _itemCab.OBSERVACIONESMED = this.txtObsMedico.Text;
                _itemCab.OTROSESTUDIOS = this.txtOtrosAnalisis.Text;
                _itemCab.OBSERVACIONESBIOQ = this.txtObsBioq.Text;
                if (chckUrgente.Checked)
                { _itemCab.TIPO = 2; }
                else { _itemCab.TIPO = 1; }
                _itemCab.PACIENTE_ID = Clases.Paciente.PacienteIngresado;
                _itemCab.ID_SOLICITUD = _NSolicitud;
                _itemCab.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;

                for (int i = 0; i < this.dataGridViewPedido.Rows.Count; i++)
                {
                    Entities.Tables.EST_LABORATORIOITEMS _itemItems = new Entities.Tables.EST_LABORATORIOITEMS();
                    _itemItems.ESTUDIO_ID = Convert.ToInt32(dataGridViewPedido.Rows[i].Cells[(int)Col_Estudios.ESTUDIO_ID].Value);
                    _itemItems.ID_SOLICITUD = _NSolicitud;
                    _itemItems.NROITEM = Convert.ToInt32(dataGridViewPedido.Rows[i].Cells[(int)Col_Estudios.NRO_ITEM].Value);
                    _itemLabItems.Add(_itemItems);
                }

                _cabLab.ActualizaLaboratorio(_itemLabItems, _itemCab);//Graba lista de Items y cabecera
                MetroMessageBox.Show(this,"Se actualizo correctamente el pedido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

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
                
                                            
                BLL.Procedures.EST_LABORATORIO_TRAEUNPEDIDO _obtieneIndicaciones = new BLL.Procedures.EST_LABORATORIO_TRAEUNPEDIDO();
                int indice;
                foreach (Entities.Procedures.EST_LABORATORIO_TRAEUNPEDIDO item in _obtieneIndicaciones.ItemList(_pedidoLab))
                {
                    if (item.tipoestudio_id == 3)
                    {
                        MetroMessageBox.Show(this, "Se solicito un " + item.descestudio + " el dia " + item.fechasolicitud.ToShortDateString(), "Solicitud",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        _NSolicitud = item.id_solicitud;
                        lblSolicitud.Text = "Solicitud Num.:" + " " + item.id_solicitud.ToString();
                        txtObsBioq.Text = item.observacionesbioq;
                        txtObsMedico.Text = item.observacionesmed;
                        txtOtrosAnalisis.Text = item.otrosestudios;
                        dateFecha.Value = item.fechasolicitud;
                        dateFecha.Enabled = false;

                        indice = dataGridViewPedido.Rows.Add();
                        dataGridViewPedido.Rows[indice].Cells[(int)Col_Estudios.ESTUDIO_ID].Value = item.estudio_id;
                        dataGridViewPedido.Rows[indice].Cells[(int)Col_Estudios.ESTUDIODESC].Value = item.descestudio;
                        dataGridViewPedido.Rows[indice].Cells[(int)Col_Estudios.NRO_ITEM].Value = item.nroitem;
                    }

                }

                dataGridViewPedido.ReadOnly = true;

                this.buttonGuardar.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TraeDatosLaboratorioVisor(int _pedidoLab)
        {
            try
            {


                BLL.Procedures.EST_LABORATORIO_TRAEUNPEDIDO _obtieneIndicaciones = new BLL.Procedures.EST_LABORATORIO_TRAEUNPEDIDO();
                foreach (Entities.Procedures.EST_LABORATORIO_TRAEUNPEDIDO item in _obtieneIndicaciones.ItemList(_pedidoLab))
                {
                    _NSolicitud = item.id_solicitud;
                    lblSolicitud.Text = "Solicitud Num.:" + " " + item.id_solicitud.ToString();
                    txtObsBioq.Text = item.observacionesbioq;
                    txtObsMedico.Text = item.observacionesmed;
                    txtOtrosAnalisis.Text = item.otrosestudios;
                    dateFecha.Value = item.fechasolicitud;
                    dateFecha.Enabled = false;                    
                    txtObsMedico.Enabled = false;
                    txtOtrosAnalisis.Enabled = false;
                    buttonModifica.Hide();               
                }

                this.buttonGuardar.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarCboAnalisisClinica()
        {
            try
            {
                BLL.Procedures.EST_LABORATORIO_TRAEANALISISCLINICA _os = new BLL.Procedures.EST_LABORATORIO_TRAEANALISISCLINICA();
                Entities.Procedures.EST_LABORATORIO_TRAEANALISISCLINICA _itemSeleccion = new Entities.Procedures.EST_LABORATORIO_TRAEANALISISCLINICA();
                List<Entities.Procedures.EST_LABORATORIO_TRAEANALISISCLINICA> _ItemsOS = new List<Entities.Procedures.EST_LABORATORIO_TRAEANALISISCLINICA>();
                //Limpia el combo
                this.cboAnalisisClinica.SuspendLayout();
                this.cboAnalisisClinica.DataSource = null;
                this.cboAnalisisClinica.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descestudio = "<Seleccione>";
                _itemSeleccion.estudio_id = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAnalisisClinica.DisplayMember = BLL.Procedures.EST_LABORATORIO_TRAEANALISISCLINICA.ColumnNames.DESCESTUDIO;
                this.cboAnalisisClinica.ValueMember = BLL.Procedures.EST_LABORATORIO_TRAEANALISISCLINICA.ColumnNames.ESTUDIO_ID;
                this.cboAnalisisClinica.DataSource = _ItemsOS;
                this.cboAnalisisClinica.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCboAnalisisDerivados()
        {
            try
            {
                BLL.Procedures.EST_LABORATORIO_TRAEANALISISDERIVADOS _os = new BLL.Procedures.EST_LABORATORIO_TRAEANALISISDERIVADOS();
                Entities.Procedures.EST_LABORATORIO_TRAEANALISISDERIVADOS _itemSeleccion = new Entities.Procedures.EST_LABORATORIO_TRAEANALISISDERIVADOS();
                List<Entities.Procedures.EST_LABORATORIO_TRAEANALISISDERIVADOS> _ItemsOS = new List<Entities.Procedures.EST_LABORATORIO_TRAEANALISISDERIVADOS>();
                //Limpia el combo
                this.cboAnalisisDeriv.SuspendLayout();
                this.cboAnalisisDeriv.DataSource = null;
                this.cboAnalisisDeriv.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descestudio = "<Seleccione>";
                _itemSeleccion.estudio_id = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAnalisisDeriv.DisplayMember = BLL.Procedures.EST_LABORATORIO_TRAEANALISISDERIVADOS.ColumnNames.DESCESTUDIO;
                this.cboAnalisisDeriv.ValueMember = BLL.Procedures.EST_LABORATORIO_TRAEANALISISDERIVADOS.ColumnNames.ESTUDIO_ID;
                this.cboAnalisisDeriv.DataSource = _ItemsOS;
                this.cboAnalisisDeriv.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        private void PedidoLab_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCboAnalisisClinica();
                CargarCboAnalisisDerivados();
                permisosEdicion(Clases.Usuario.UsuarioLogeado.Id_Sector);
                if (_Actualiza)
                {
                    TraeDatosLaboratorio(_SuministroID);
                    chckRutinaIngreso.Enabled = false;
                    chckUrgente.Enabled = false;
                }
                else
                {
                    if (_Visor)
                    {
                        TraeDatosLaboratorioVisor(_SuministroID);
                        this.lblSolicitud.Show();                        
                    }
                    else
                    {
                        this.lblSolicitud.Hide();
                        this.lblLeyenda.Hide();
                        this.buttonModifica.Hide();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void chckRutinaIngreso_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboAnalisisClinica.SelectedIndex == 0)
                { MetroMessageBox.Show(this, "Debe seleccionar un analisis", "Alerta", MessageBoxButtons.OK); }
                else
                {
                    bool _Ingresado;
                    _Ingresado = false;
                    for (int i = 0; i < this.dataGridViewPedido.Rows.Count; i++)
                    {

                        int _V1 = Convert.ToInt32(dataGridViewPedido.Rows[i].Cells[(int)Col_Estudios.ESTUDIO_ID].Value);
                        int _V2 = Convert.ToInt32(cboAnalisisClinica.SelectedValue);
                        if (_V1 == _V2)
                        {
                            MetroMessageBox.Show(this, "Este estudio ya esta ingresado", "Alerta", MessageBoxButtons.OK);
                            _Ingresado = true;
                        }
                    }
                    if (_Ingresado == false)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewPedido.RowTemplate.Clone();
                        row.CreateCells(dataGridViewPedido, cboAnalisisClinica.SelectedValue, cboAnalisisClinica.Text);
                        dataGridViewPedido.Rows.Add(row);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboAnalisisDeriv.SelectedIndex == 0)
                {
                    MetroMessageBox.Show(this, "Debe seleccionar un analisis", "Alerta", MessageBoxButtons.OK);
                }
                else
                {
                    bool _Ingresado;
                    _Ingresado = false;
                    for (int i = 0; i < this.dataGridViewPedido.Rows.Count; i++)
                    {

                        int _V1 = Convert.ToInt32(dataGridViewPedido.Rows[i].Cells[(int)Col_Estudios.ESTUDIO_ID].Value);
                        int _V2 = Convert.ToInt32(cboAnalisisDeriv.SelectedValue);
                        if (_V1 == _V2)
                        {
                            MetroMessageBox.Show(this, "Este estudio ya esta ingresado", "Alerta", MessageBoxButtons.OK);
                            _Ingresado = true;
                        }
                    }
                    if (_Ingresado == false)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewPedido.RowTemplate.Clone();
                        row.CreateCells(dataGridViewPedido, cboAnalisisDeriv.SelectedValue, cboAnalisisDeriv.Text);
                        dataGridViewPedido.Rows.Add(row);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    if (_Actualiza)
                    {
                        MetroMessageBox.Show(this, "No se pueden eliminar estudios previos");
                    }
                    else
                    {
                        foreach (DataGridViewRow item in this.dataGridViewPedido.SelectedRows)
                        {
                            dataGridViewPedido.Rows.RemoveAt(item.Index);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                GuardaPedido();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonModifica_Click_1(object sender, EventArgs e)
        {
            try
            {
                ActualizaPedido(_SuministroID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion
    }
}
