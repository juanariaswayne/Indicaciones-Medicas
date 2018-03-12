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

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento
{
    public interface ICargaAditivos
    {
      void cargarAditivos(string id, string aditivo, decimal dosis);
    }
        public partial class PHPV2 : MetroForm, ICargaAditivos
    {
        #region Variables
        public delegate void Indicacion();
        public event Indicacion ActualizarIndicacion;
        public IActuIndicaciones Opener { get; set; }
        private int suministro_procedimiento_id;
        public int Suministro_Procedimiento_Id
        {
            get
            {
                return suministro_procedimiento_id;
            }
            set
            {
                this.suministro_procedimiento_id = value;
            }
        }
        private int procedimiento_id;
        public int Procedimiento_Id
        {
            get
            {
                return procedimiento_id;
            }
            set
            {
                this.procedimiento_id = value;
            }
        }

        private int paciente_id;
        public int Paciente_Id
        {
            get
            {
                return paciente_id;
            }
            set
            {
                this.paciente_id = value;
            }
        }

        private int tipo_procedimiento_id;
        public int Tipo_Procedimiento_Id
        {
            get
            {
                return tipo_procedimiento_id;
            }
            set
            {
                this.tipo_procedimiento_id = value;
            }
        }

        private enum Col_Aditivos
        {
            ID = 0,
            ADITIVO,
            DOSIS,
            X
        }

        SISTMEDEntities E = new SISTMEDEntities();      
        List<PRO_PHPV2_ADITIVO> _listaAditivo = new List<PRO_PHPV2_ADITIVO>();
        int _phpID = 0;
        DateTime _fbja;
        int _suspender = 0;
        #endregion
        #region Funciones
        public PHPV2()
        {
            InitializeComponent();
        }

        public void cargarAditivos(string id, string aditivo, decimal dosis)
        {
            try
            {       
                if(Clases.PHP.Frasco == 1)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridAditivos.RowTemplate.Clone();
                    row.CreateCells(dataGridAditivos, id, aditivo, dosis);
                    dataGridAditivos.Rows.Add(row);
                }
                if (Clases.PHP.Frasco == 2)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridAditivos2.RowTemplate.Clone();
                    row.CreateCells(dataGridAditivos2, id, aditivo, dosis);
                    dataGridAditivos2.Rows.Add(row);
                }
                if (Clases.PHP.Frasco == 3)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridAditivos3.RowTemplate.Clone();
                    row.CreateCells(dataGridAditivos3, id, aditivo, dosis);
                    dataGridAditivos3.Rows.Add(row);
                }
                if (Clases.PHP.Frasco == 4)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridAditivos4.RowTemplate.Clone();
                    row.CreateCells(dataGridAditivos4, id, aditivo, dosis);
                    dataGridAditivos4.Rows.Add(row);
                }
                if (Clases.PHP.Frasco == 5)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridAditivos5.RowTemplate.Clone();
                    row.CreateCells(dataGridAditivos5, id, aditivo, dosis);
                    dataGridAditivos5.Rows.Add(row);
                }
                if (Clases.PHP.Frasco == 6)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridAditivos6.RowTemplate.Clone();
                    row.CreateCells(dataGridAditivos6, id, aditivo, dosis);
                    dataGridAditivos6.Rows.Add(row);
                }
                if (Clases.PHP.Frasco == 7)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridAditivos7.RowTemplate.Clone();
                    row.CreateCells(dataGridAditivos7, id, aditivo, dosis);
                    dataGridAditivos7.Rows.Add(row);
                }
                if (Clases.PHP.Frasco == 8)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridAditivos8.RowTemplate.Clone();
                    row.CreateCells(dataGridAditivos8, id, aditivo, dosis);
                    dataGridAditivos8.Rows.Add(row);
                }
                if (Clases.PHP.Frasco == 9)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridAditivos9.RowTemplate.Clone();
                    row.CreateCells(dataGridAditivos9, id, aditivo, dosis);
                    dataGridAditivos9.Rows.Add(row);
                }
                if (Clases.PHP.Frasco == 10)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridAditivos10.RowTemplate.Clone();
                    row.CreateCells(dataGridAditivos10, id, aditivo, dosis);
                    dataGridAditivos10.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeDiluyentes()
        {
            try
            {
                cboDiluyente.DataSource = E.PRO_PHPV2_DILUYENTE.ToList();
                cboDiluyente.ValueMember = "id_diluyente";
                cboDiluyente.DisplayMember = "descripcion_diluyente";
                cboDiluyente.ResumeLayout();

                cboDiluyente2.DataSource = E.PRO_PHPV2_DILUYENTE.ToList();
                cboDiluyente2.ValueMember = "id_diluyente";
                cboDiluyente2.DisplayMember = "descripcion_diluyente";
                cboDiluyente2.ResumeLayout();

                cboDiluyente3.DataSource = E.PRO_PHPV2_DILUYENTE.ToList();
                cboDiluyente3.ValueMember = "id_diluyente";
                cboDiluyente3.DisplayMember = "descripcion_diluyente";
                cboDiluyente3.ResumeLayout();

                cboDiluyente4.DataSource = E.PRO_PHPV2_DILUYENTE.ToList();
                cboDiluyente4.ValueMember = "id_diluyente";
                cboDiluyente4.DisplayMember = "descripcion_diluyente";
                cboDiluyente4.ResumeLayout();

                cboDiluyente5.DataSource = E.PRO_PHPV2_DILUYENTE.ToList();
                cboDiluyente5.ValueMember = "id_diluyente";
                cboDiluyente5.DisplayMember = "descripcion_diluyente";
                cboDiluyente5.ResumeLayout();

                cboDiluyente6.DataSource = E.PRO_PHPV2_DILUYENTE.ToList();
                cboDiluyente6.ValueMember = "id_diluyente";
                cboDiluyente6.DisplayMember = "descripcion_diluyente";
                cboDiluyente6.ResumeLayout();

                cboDiluyente7.DataSource = E.PRO_PHPV2_DILUYENTE.ToList();
                cboDiluyente7.ValueMember = "id_diluyente";
                cboDiluyente7.DisplayMember = "descripcion_diluyente";
                cboDiluyente7.ResumeLayout();

                cboDiluyente8.DataSource = E.PRO_PHPV2_DILUYENTE.ToList();
                cboDiluyente8.ValueMember = "id_diluyente";
                cboDiluyente8.DisplayMember = "descripcion_diluyente";
                cboDiluyente8.ResumeLayout();

                cboDiluyente9.DataSource = E.PRO_PHPV2_DILUYENTE.ToList();
                cboDiluyente9.ValueMember = "id_diluyente";
                cboDiluyente9.DisplayMember = "descripcion_diluyente";
                cboDiluyente9.ResumeLayout();

                cboDiluyente10.DataSource = E.PRO_PHPV2_DILUYENTE.ToList();
                cboDiluyente10.ValueMember = "id_diluyente";
                cboDiluyente10.DisplayMember = "descripcion_diluyente";
                cboDiluyente10.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TraeGotaHora()
        {
            try
            {
                cboGotaHora.DataSource = E.PRO_Gota_Hora.ToList();
                cboGotaHora.ValueMember = "gotaHora_id";
                cboGotaHora.DisplayMember = "descripcion";
                cboGotaHora.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtieneTamanioFrasco()
        {
            try
            {
                int _frasco = 0;
                foreach(Control c in groupBoxPHP.Controls)
                {
                    if(c is RadioButton)
                    {
                      if(((RadioButton)c).Checked)
                        {
                            _frasco = Convert.ToInt32(((RadioButton)c).Tag);
                        }
                    }
                }

                return _frasco;
            }
            catch (Exception ex)
            {               
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void TraeDatos()
        {
            try
            {
                PRO_PHPV2 _itemPHP = E.PRO_PHPV2.Find(_phpID);
                foreach (Control c in groupBoxPHP.Controls)
                {
                    if(c is RadioButton)
                    {
                        if(Convert.ToInt32(((RadioButton)c).Tag) == _itemPHP.tamanio_frasco.Value)
                        {
                            ((RadioButton)c).Checked = true;
                        }                     
                    }
                }
                cboGotaHora.SelectedValue = _itemPHP.gotas_minuto.Value;
                checkBic.Checked = _itemPHP.bic.Value;
                txtMlHora.Text = _itemPHP.ml_hora.Value.ToString();
                txtObs.Text = _itemPHP.obs;

                cboDiluyente.SelectedValue = _itemPHP.frasco1;
                cboDiluyente2.SelectedValue = _itemPHP.frasco2;
                cboDiluyente3.SelectedValue = _itemPHP.frasco3;
                cboDiluyente4.SelectedValue = _itemPHP.frasco4;
                cboDiluyente5.SelectedValue = _itemPHP.frasco5;
                cboDiluyente6.SelectedValue = _itemPHP.frasco6;
                cboDiluyente7.SelectedValue = _itemPHP.frasco7;
                cboDiluyente8.SelectedValue = _itemPHP.frasco8;
                cboDiluyente9.SelectedValue = _itemPHP.frasco9;
                cboDiluyente10.SelectedValue = _itemPHP.frasco10;

                foreach(var _itemA in E.PRO_PHPV2_ADITIVO.Where(p=>p.id_php == _phpID))
                {
                    int indice;
                    foreach (Control c in groupBoxFrascos.Controls)
                    {
                        if(c is DataGridView)
                        {
                            DataGridView _tablaAditivos = ((DataGridView)c);
                            if(_tablaAditivos.Tag.ToString() == _itemA.id_frasco.ToString())
                            {
                                indice = _tablaAditivos.Rows.Add();
                                _tablaAditivos.Rows[indice].Cells[(int)Col_Aditivos.ID].Value = _itemA.aditivo_id;
                                _tablaAditivos.Rows[indice].Cells[(int)Col_Aditivos.ADITIVO].Value = _itemA.aditivo_desc;
                                _tablaAditivos.Rows[indice].Cells[(int)Col_Aditivos.DOSIS].Value = _itemA.dosis;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #region Eventos
        private void PHPV2_Load(object sender, EventArgs e)
        {
            try
            {
                if(procedimiento_id == 1161)
                {
                    lblPediatria.Visible = true;
                }
                TraeDiluyentes();
                TraeGotaHora();
                if (suministro_procedimiento_id != 0)
                {
                    _phpID = E.PRO_SuministroDeProcedimiento.Find(suministro_procedimiento_id).php_id.Value;
                    TraeDatos();                   
                }
                else
                {
                    radio500ML.Checked = true;

                    foreach(Control cbo in groupBoxFrascos.Controls)
                    {
                        if(cbo is ComboBox)
                        {
                            ((ComboBox)cbo).SelectedIndex = 2;
                        }
                    }
                }                                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Guardar()
        {
            SISTMEDEntities P = new SISTMEDEntities();
            using (var dbContextTransaction = P.Database.BeginTransaction())
                try
                {
                    P.Configuration.ValidateOnSaveEnabled = false;

                    PRO_PHPV2 _itemPHP = new PRO_PHPV2();
                    _itemPHP.tamanio_frasco = ObtieneTamanioFrasco();
                    _itemPHP.bic = checkBic.Checked;
                    _itemPHP.gotas_minuto = Convert.ToInt32(cboGotaHora.SelectedValue);
                    _itemPHP.ml_hora = txtMlHora.Text == ""? 0: Convert.ToInt32(txtMlHora.Text);
                    _itemPHP.fecha_carga = DateTime.Now;
                    _itemPHP.usr_carga = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemPHP.obs = txtObs.Text;
                    if(_suspender == 1)
                    {
                        _itemPHP.fecha_baja = _fbja;
                    }
                    _itemPHP.frasco1 = Convert.ToInt32(cboDiluyente.SelectedValue);
                    _itemPHP.frasco2 = Convert.ToInt32(cboDiluyente2.SelectedValue);
                    _itemPHP.frasco3 = Convert.ToInt32(cboDiluyente3.SelectedValue);
                    _itemPHP.frasco4 = Convert.ToInt32(cboDiluyente4.SelectedValue);
                    _itemPHP.frasco5 = Convert.ToInt32(cboDiluyente5.SelectedValue);
                    _itemPHP.frasco6 = Convert.ToInt32(cboDiluyente6.SelectedValue);
                    _itemPHP.frasco7 = Convert.ToInt32(cboDiluyente7.SelectedValue);
                    _itemPHP.frasco8 = Convert.ToInt32(cboDiluyente8.SelectedValue);
                    _itemPHP.frasco9 = Convert.ToInt32(cboDiluyente9.SelectedValue);
                    _itemPHP.frasco10 = Convert.ToInt32(cboDiluyente10.SelectedValue);

                    if(suministro_procedimiento_id!=0)
                    {
                        _itemPHP.id_php = _phpID;
                        P.Entry(_itemPHP).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        P.PRO_PHPV2.Add(_itemPHP);
                    }

                    if(suministro_procedimiento_id != 0)
                    {
                        P.PRO_PHPV2_ADITIVO.RemoveRange(P.PRO_PHPV2_ADITIVO.Where(a => a.id_php == _phpID));
                    }                  

                    foreach(Control c in groupBoxFrascos.Controls)
                    {
                        if(c is DataGridView)
                        {
                            DataGridView _tablaAditivos = (DataGridView)c;
                            if (_tablaAditivos.Rows.Count > 0)//Tiene algun aditivo
                            {                                
                                for(int i = 0;i < _tablaAditivos.Rows.Count ;i++)
                                {
                                    PRO_PHPV2_ADITIVO _itemAditivo = new PRO_PHPV2_ADITIVO();
                                    _itemAditivo.PRO_PHPV2 = _itemPHP;
                                    _itemAditivo.id_frasco = Convert.ToInt32(_tablaAditivos.Tag);
                                    _itemAditivo.aditivo_id = _tablaAditivos.Rows[i].Cells[(int)Col_Aditivos.ID].Value.ToString();
                                    _itemAditivo.aditivo_desc = _tablaAditivos.Rows[i].Cells[(int)Col_Aditivos.ADITIVO].Value.ToString();
                                    _itemAditivo.dosis = Convert.ToDecimal(_tablaAditivos.Rows[i].Cells[(int)Col_Aditivos.DOSIS].Value);
                                    P.PRO_PHPV2_ADITIVO.Add(_itemAditivo);
                                }
                            }
                            else //No tiene aditivos
                            {
                                PRO_PHPV2_ADITIVO _itemAditivo = new PRO_PHPV2_ADITIVO();
                                _itemAditivo.PRO_PHPV2 = _itemPHP;
                                _itemAditivo.id_frasco = Convert.ToInt32(_tablaAditivos.Tag);
                                _itemAditivo.aditivo_id = "S/A";
                                _itemAditivo.aditivo_desc = "";
                                _itemAditivo.dosis = 0;
                                P.PRO_PHPV2_ADITIVO.Add(_itemAditivo);
                            }
                        }
                    }

                    PRO_SuministroDeProcedimiento _itemSP = new PRO_SuministroDeProcedimiento();
                    _itemSP.paciente_id = Clases.Paciente.PacienteIngresado;
                    _itemSP.procedimiento_id = procedimiento_id;
                    _itemSP.tipoProcedimiento_id = 8;
                    _itemSP.usuario_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemSP.fechaAltaSistema = DateTime.Now;
                    
                    if(_suspender == 1)
                    {
                        _itemSP.fechaBaja = _fbja;
                    }

                    if (suministro_procedimiento_id == 0)
                    {
                        _itemSP.PRO_PHPV2 = _itemPHP;
                        P.PRO_SuministroDeProcedimiento.Add(_itemSP);
                    }
                    else
                    {
                        if (_suspender == 1)
                        {
                            PRO_SuministroDeProcedimiento _itemSuministro = new PRO_SuministroDeProcedimiento {suministroDeProcedimiento_id = suministro_procedimiento_id, fechaBaja = _fbja};
                            P.PRO_SuministroDeProcedimiento.Attach(_itemSuministro);
                            P.Entry(_itemSuministro).Property(s => s.fechaBaja).IsModified = true;
                        }
                    }
                   
                    P.SaveChanges();
                    dbContextTransaction.Commit();
                    MetroMessageBox.Show(this, "Se guardo correctamente");
                    if (suministro_procedimiento_id != 0)
                    { ActualizarIndicacion(); }
                    else
                    { Opener.IActualiza(); }
                    this.Close();
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {               
               Guardar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void checkBic_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(checkBic.Checked)
                {
                    txtMlHora.Visible = true;
                    lblMlHora.Visible = true;
                    cboGotaHora.Visible = false;
                    lblGotaHora.Visible = false;
                }
                else
                {
                    txtMlHora.Visible = false;
                    lblMlHora.Visible = false;
                    cboGotaHora.Visible = true;
                    lblGotaHora.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDiluyente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

       

        private void dataGridAditivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridAditivos.SelectedRows)
                    {
                        dataGridAditivos.Rows.RemoveAt(item.Index);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuspender_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult _dialog = MessageBox.Show("Suspender", "Desea suspender este procedimiento en la fecha indicada?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (_dialog == DialogResult.Yes)
                {
                    _fbja = dateSuspension.Value;
                    _suspender = 1;
                    Guardar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAditivo1_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.PHP.Frasco = 1;
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Aditivos = this;
                _pop._tipo = 'M';
                _pop._aditivo = 'A';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAditivo2_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.PHP.Frasco = 2;
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Aditivos = this;
                _pop._tipo = 'M';
                _pop._aditivo = 'A';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAditivo3_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.PHP.Frasco = 3;
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Aditivos = this;
                _pop._tipo = 'M';
                _pop._aditivo = 'A';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAditivo4_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.PHP.Frasco = 4;
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Aditivos = this;
                _pop._tipo = 'M';
                _pop._aditivo = 'A';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAditivo5_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.PHP.Frasco = 5;
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Aditivos = this;
                _pop._tipo = 'M';
                _pop._aditivo = 'A';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAditivo6_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.PHP.Frasco = 6;
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Aditivos = this;
                _pop._tipo = 'M';
                _pop._aditivo = 'A';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAditivo7_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.PHP.Frasco = 7;
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Aditivos = this;
                _pop._tipo = 'M';
                _pop._aditivo = 'A';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAditivo8_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.PHP.Frasco = 8;
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Aditivos = this;
                _pop._tipo = 'M';
                _pop._aditivo = 'A';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAditivo9_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.PHP.Frasco = 9;
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Aditivos = this;
                _pop._tipo = 'M';
                _pop._aditivo = 'A';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAditivo10_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.PHP.Frasco = 10;
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Aditivos = this;
                _pop._tipo = 'M';
                _pop._aditivo = 'A';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAditivos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridAditivos.SelectedRows)
                    {
                        dataGridAditivos.Rows.RemoveAt(item.Index);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAditivos2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridAditivos2.SelectedRows)
                    {
                        dataGridAditivos2.Rows.RemoveAt(item.Index);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAditivos3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridAditivos3.SelectedRows)
                    {
                        dataGridAditivos3.Rows.RemoveAt(item.Index);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAditivos4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridAditivos4.SelectedRows)
                    {
                        dataGridAditivos4.Rows.RemoveAt(item.Index);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAditivos5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridAditivos5.SelectedRows)
                    {
                        dataGridAditivos5.Rows.RemoveAt(item.Index);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAditivos6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridAditivos6.SelectedRows)
                    {
                        dataGridAditivos6.Rows.RemoveAt(item.Index);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAditivos7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridAditivos7.SelectedRows)
                    {
                        dataGridAditivos7.Rows.RemoveAt(item.Index);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAditivos8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridAditivos8.SelectedRows)
                    {
                        dataGridAditivos8.Rows.RemoveAt(item.Index);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAditivos9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridAditivos9.SelectedRows)
                    {
                        dataGridAditivos9.Rows.RemoveAt(item.Index);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAditivos10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridAditivos10.SelectedRows)
                    {
                        dataGridAditivos10.Rows.RemoveAt(item.Index);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDiluyente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {               
                    if (Convert.ToInt32(cboDiluyente.SelectedIndex) != 2)
                    {
                        dataGridAditivos.Show();
                        lblAditivo.Show();
                        AgregarAditivo1.Show();
                    }
                    else
                    {
                        dataGridAditivos.Hide();
                        dataGridAditivos.Rows.Clear();
                        lblAditivo.Hide();
                        AgregarAditivo1.Hide();
                    }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDiluyente2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(cboDiluyente2.SelectedIndex) != 2)
                {
                    dataGridAditivos2.Show();
                    lblAditivo2.Show();
                    AgregarAditivo2.Show();
                }
                else
                {
                    dataGridAditivos2.Hide();
                    dataGridAditivos2.Rows.Clear();
                    lblAditivo2.Hide();
                    AgregarAditivo2.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDiluyente3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboDiluyente3.SelectedIndex) != 2)
                {
                    dataGridAditivos3.Show();
                    lblAditivo3.Show();
                    AgregarAditivo3.Show();
                }
                else
                {
                    dataGridAditivos3.Hide();
                    dataGridAditivos3.Rows.Clear();
                    lblAditivo3.Hide();
                    AgregarAditivo3.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDiluyente4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboDiluyente4.SelectedIndex) != 2)
                {
                    dataGridAditivos4.Show();
                    lblAditivo4.Show();
                    AgregarAditivo4.Show();
                }
                else
                {
                    dataGridAditivos4.Hide();
                    dataGridAditivos4.Rows.Clear();
                    lblAditivo4.Hide();
                    AgregarAditivo4.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDiluyente5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboDiluyente5.SelectedIndex) != 2)
                {
                    dataGridAditivos5.Show();
                    lblAditivo5.Show();
                    AgregarAditivo5.Show();
                }
                else
                {
                    dataGridAditivos5.Hide();
                    dataGridAditivos5.Rows.Clear();
                    lblAditivo5.Hide();
                    AgregarAditivo5.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDiluyente6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboDiluyente6.SelectedIndex) != 2)
                {
                    dataGridAditivos6.Show();
                    lblAditivo6.Show();
                    AgregarAditivo6.Show();
                }
                else
                {
                    dataGridAditivos6.Hide();
                    dataGridAditivos6.Rows.Clear();
                    lblAditivo6.Hide();
                    AgregarAditivo6.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDiluyente7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboDiluyente7.SelectedIndex) != 2)
                {
                    dataGridAditivos7.Show();
                    lblAditivo7.Show();
                    AgregarAditivo7.Show();
                }
                else
                {
                    dataGridAditivos7.Hide();
                    dataGridAditivos7.Rows.Clear();
                    lblAditivo7.Hide();
                    AgregarAditivo7.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDiluyente8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboDiluyente8.SelectedIndex) != 2)
                {
                    dataGridAditivos8.Show();
                    lblAditivo8.Show();
                    AgregarAditivo8.Show();
                }
                else
                {
                    dataGridAditivos8.Hide();
                    dataGridAditivos8.Rows.Clear();
                    lblAditivo8.Hide();
                    AgregarAditivo8.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDiluyente9_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboDiluyente9.SelectedIndex) != 2)
                {
                    dataGridAditivos9.Show();
                    lblAditivo9.Show();
                    AgregarAditivo9.Show();
                }
                else
                {
                    dataGridAditivos9.Hide();
                    dataGridAditivos9.Rows.Clear();
                    lblAditivo9.Hide();
                    AgregarAditivo9.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDiluyente10_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cboDiluyente10.SelectedIndex) != 2)
                {
                    dataGridAditivos10.Show();
                    lblAditivo10.Show();
                    AgregarAditivo10.Show();
                }
                else
                {
                    dataGridAditivos10.Hide();
                    dataGridAditivos10.Rows.Clear();
                    lblAditivo10.Hide();
                    AgregarAditivo10.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
