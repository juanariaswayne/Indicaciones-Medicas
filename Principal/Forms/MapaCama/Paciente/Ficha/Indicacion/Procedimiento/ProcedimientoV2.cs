using MetroFramework;
using MetroFramework.Forms;
using Principal.Forms.Farmacia;
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

    public interface ICargaDatos
    {
        void CargarDatos(char _tipo, string _codigo, string _descripcion, decimal _cantidad);
    }

    public partial class ProcedimientoV2 : MetroForm, ICargaDatos
    {
        #region Variables
        SISTMEDEntities P = new SISTMEDEntities();
        private enum Col_Descartables
        {
            ID_DESC = 0,
            DESCARTABLE,
            CANTIDAD,
            X
        }

        private enum Col_Medicamentos
        {
            ID_MED = 0,
            MEDICAMENTO,
            DOSIS,
            X
        }

        private enum Col_Procedimientos
        {
            ID_PROC = 0,
            PROCEDIMIENTO,
            X
        }

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

        private int generico_id;
        public int Generico_Id
        {
            get
            {
                return generico_id;
            }
            set
            {
                this.generico_id = value;
            }
        }

        public bool Factu { get => _factu; set => _factu = value; }

        private bool _factu;

        private Farm_Principal form_Farm_Principal; // Para mandarle los datos al formulario anterior

        #endregion

        #region Funciones
        public ProcedimientoV2()
        {
            InitializeComponent();
        }

        public void recibirReferenciaFormularioAnterior(Farm_Principal f)
        {
            this.form_Farm_Principal = f;
        }

        public void CargarDatos(char _tipo, string _codigo, string _descripcion, decimal _cantidad)
        {
            try
            {
                if (_tipo == 'D')
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewDescartables.RowTemplate.Clone();
                    row.CreateCells(dataGridViewDescartables, _codigo, _descripcion, _cantidad);
                    dataGridViewDescartables.Rows.Add(row);
                }
                else if (_tipo == 'M')
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewMedicamentos.RowTemplate.Clone();
                    row.CreateCells(dataGridViewMedicamentos, _codigo, _descripcion, _cantidad);
                    dataGridViewMedicamentos.Rows.Add(row);
                }
                else if (_tipo == 'P')
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1Procedimientos.RowTemplate.Clone();
                    row.CreateCells(dataGridView1Procedimientos, _codigo, _descripcion);
                    dataGridView1Procedimientos.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeDescartables()
        {
            try
            {
                cboDesc.DataSource = P.TRAEDESCARTABLES("").ToList();
                cboDesc.ValueMember = "art_CodGen";
                cboDesc.DisplayMember = "art_DescGen";               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeMedicamentos()
        {
            try
            {
                var q = from pac in P.TRAEMEDICAMENTOS("")
                        orderby pac.art_DescGen
                        select new
                        {
                            codigo = pac.art_CodGen,
                            descripcion = (pac.art_DescGen.ToString() + " " + pac.artele_Desc2.ToString() + " " + pac.artele_Desc1.ToString())
                        };
                cboMed.DataSource = q.ToList();
                cboMed.ValueMember = "codigo";
                cboMed.DisplayMember = "descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeProcedimientos()
        {
            try
            {
                var q = from pro in P.PRO_Procedimiento select pro;

                cboProc.DataSource = q.ToList();
                cboProc.ValueMember = "procedimiento_id";
                cboProc.DisplayMember = "descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtieneMedicamento(string _medicamentoID)
        {
            try
            {
                string _medicamento = P.MEDICAMENTO.Find(_medicamentoID).descripcion_medicamento;
                return _medicamento;
            }
            catch (Exception ex)
            {
                return "";                
            }
        }

        private void TraeMedicamentosAsociados()
        {
            try
            {
               
                if (suministro_procedimiento_id != 0) //Es una actualizacion, sino trago vacio los campos
                {

                    var q = from m in P.TRAEMEDICAMENTOS("").ToList()
                            join med in P.PRO_Asociacion_Procedimiento on m.art_CodGen equals med.articulo_id
                            where med.suministro_procedimiento_id == suministro_procedimiento_id && med.tipo_articulo == "MED"
                            select new
                            {
                                codigo = m.art_CodGen,
                                descripcion = m.art_DescGen.ToString() + " " + m.artele_Desc1.ToString() + " " + m.artele_Desc2.ToString(),
                                cantidad = med.cantidad
                            };
                    int indice;
            
                    foreach (var item in q)
                    {
                        indice = dataGridViewMedicamentos.Rows.Add();
                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.ID_MED].Value = item.codigo;
                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.MEDICAMENTO].Value = item.descripcion.ToString();
                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.DOSIS].Value = item.cantidad;
                    }
                }
                else
                {
                    var q = from m in P.TRAEMEDICAMENTOS("").ToList()
                            join med in P.PRO_Asociacion_Procedimiento on m.art_CodGen equals med.articulo_id
                            where med.procedimiento_id == procedimiento_id && med.suministro_procedimiento_id is null && med.tipo_articulo == "MED"
                            select new
                            {
                                codigo = m.art_CodGen,
                                descripcion = m.art_DescGen.ToString() + " " + m.artele_Desc1.ToString() + " " + m.artele_Desc2.ToString(),
                                cantidad = med.cantidad
                            };

                    int indice;

                    foreach (var item in q)
                    {
                        indice = dataGridViewMedicamentos.Rows.Add();
                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.ID_MED].Value = item.codigo;
                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.MEDICAMENTO].Value = item.descripcion.ToString();
                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos.DOSIS].Value = item.cantidad;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeDescartablesAsociados()
        {
            try
            {
                
                if (suministro_procedimiento_id != 0) //Es una actualizacion, sino trago vacio los campos
                {

                    var q = from m in P.TRAEDESCARTABLES("").ToList()
                            join med in P.PRO_Asociacion_Procedimiento on m.art_CodGen equals med.articulo_id
                            where med.suministro_procedimiento_id == suministro_procedimiento_id && med.tipo_articulo == "DESC"
                            select new
                            {
                                codigo = m.art_CodGen,
                                descripcion = m.art_DescGen.ToString() + " " + m.artele_Desc1.ToString() + " " + m.artele_Desc2.ToString(),
                                cantidad = med.cantidad
                            };
                    int indice;

                    foreach (var item in q.ToList())
                    {
                        indice = dataGridViewDescartables.Rows.Add();
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_DESC].Value = item.codigo;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = item.descripcion;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = item.cantidad;
                    }
                }
                else
                {
                    var q = from m in P.TRAEDESCARTABLES("").ToList()
                            join med in P.PRO_Asociacion_Procedimiento on m.art_CodGen equals med.articulo_id
                            where med.procedimiento_id == procedimiento_id && med.suministro_procedimiento_id is null && med.tipo_articulo == "DESC"
                            select new
                            {
                                codigo = m.art_CodGen,
                                descripcion = m.art_DescGen.ToString() + " " + m.artele_Desc1.ToString() + " " + m.artele_Desc2.ToString(),
                                cantidad = med.cantidad
                            };
                    int indice;

                    foreach (var item in q.ToList())
                    {
                        indice = dataGridViewDescartables.Rows.Add();
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_DESC].Value = item.codigo;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = item.descripcion;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = item.cantidad;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeDatosProcedimiento()
        {
            try
            {
                if (suministro_procedimiento_id != 0) //Es una actualizacion, sino trago vacio los campos
                {
                    var item = P.PRO_SuministroDeProcedimiento.Where(s => s.suministroDeProcedimiento_id == suministro_procedimiento_id).Single();
                    
                        h00.Checked = item.h00.Value;
                        h01.Checked = item.h01.Value;
                        h02.Checked = item.h02.Value;
                        h03.Checked = item.h03.Value;
                        h04.Checked = item.h04.Value;
                        h05.Checked = item.h05.Value;
                        h06.Checked = item.h06.Value;
                        h07.Checked = item.h07.Value;
                        h08.Checked = item.h08.Value;
                        h09.Checked = item.h09.Value;
                        h10.Checked = item.h10.Value;
                        h11.Checked = item.h11.Value;
                        h12.Checked = item.h12.Value;
                        h13.Checked = item.h13.Value;
                        h14.Checked = item.h14.Value;
                        h15.Checked = item.h15.Value;
                        h16.Checked = item.h16.Value;
                        h17.Checked = item.h17.Value;
                        h18.Checked = item.h18.Value;
                        h19.Checked = item.h19.Value;
                        h20.Checked = item.h20.Value;
                        h21.Checked = item.h21.Value;
                        h22.Checked = item.h22.Value;
                        h23.Checked = item.h23.Value;
                        chckLunes.Checked = item.Lunes.Value;
                        chckMartes.Checked = item.Martes.Value;
                        chckMiercoles.Checked = item.Miercoles.Value;
                        chckJueves.Checked = item.Jueves.Value;
                        chckViernes.Checked = item.Viernes.Value;
                        chckSabado.Checked = item.Sabado.Value;
                        chckDomingo.Checked = item.Domingo.Value;
                        chckSegunNEcesidad.Checked = item.SegunNecesidad == null? false: item.SegunNecesidad.Value;
                   
                        txtObs.Text = item.PRO_Generico.observacion;
                        this.Text = item.PRO_Procedimiento.descripcion.ToString();

                        dateSuspender.Value = item.fechaBaja.Value;
                   
                }
                else
                {
                    this.Text = P.PRO_Procedimiento.Where(p => p.procedimiento_id == procedimiento_id).Single().descripcion.ToString();
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        

        private void TraeProcedimientosAsociados()
        {
            try
            {
                
                if (suministro_procedimiento_id != 0) //Es una actualizacion, sino trago vacio los campos
                {                   
                    int indice;

                    foreach (var item in P.PRO_Asociacion_Procedimiento_Proc.Where(p => p.suministro_procedimiento_id == suministro_procedimiento_id).ToList())
                    {
                        indice = dataGridView1Procedimientos.Rows.Add();
                        dataGridView1Procedimientos.Rows[indice].Cells[(int)Col_Procedimientos.ID_PROC].Value = item.procedimiento_id2;
                        dataGridView1Procedimientos.Rows[indice].Cells[(int)Col_Procedimientos.PROCEDIMIENTO].Value = P.PRO_Procedimiento.Where(p=>p.procedimiento_id == item.procedimiento_id2).SingleOrDefault().descripcion;
                    }
                }
                else
                {
                    int indice;

                    foreach (var item in P.PRO_Asociacion_Procedimiento_Proc.Where(p => p.suministro_procedimiento_id == null && p.procedimiento_id == procedimiento_id).ToList())
                    {
                        indice = dataGridView1Procedimientos.Rows.Add();
                        dataGridView1Procedimientos.Rows[indice].Cells[(int)Col_Procedimientos.ID_PROC].Value = item.procedimiento_id2;
                        dataGridView1Procedimientos.Rows[indice].Cells[(int)Col_Procedimientos.PROCEDIMIENTO].Value = P.PRO_Procedimiento.Where(p => p.procedimiento_id == item.procedimiento_id2).SingleOrDefault().descripcion;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guarda_Procedimiento_Asociados(int _idProcedimiento)
        {
            try
            {
                SISTMEDEntities P = new SISTMEDEntities();

                PRO_Generico genItem = new PRO_Generico();
                genItem.paciente_id = Clases.Paciente.PacienteIngresado;
                genItem.procedimiento_id = procedimiento_id;
                genItem.observacion = "";
                genItem.usuario_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                genItem.fechaAltaSistema = DateTime.Now;
                genItem.fechaModificacion = DateTime.Now;

                PRO_SuministroDeProcedimiento sp = new PRO_SuministroDeProcedimiento();

                P.PRO_Generico.Add(genItem);

                sp.PRO_Generico = genItem;
                sp.paciente_id = paciente_id;
                sp.procedimiento_id = _idProcedimiento;
                sp.tipoProcedimiento_id = tipo_procedimiento_id;
                sp.usuario_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                sp.fechaAltaSistema = DateTime.Now;
                sp.fechaModificiacion = DateTime.Now;
                sp.h00 = h00.Checked;
                sp.h01 = h01.Checked;
                sp.h02 = h02.Checked;
                sp.h03 = h03.Checked;
                sp.h04 = h04.Checked;
                sp.h05 = h05.Checked;
                sp.h06 = h06.Checked;
                sp.h07 = h07.Checked;
                sp.h08 = h08.Checked;
                sp.h09 = h09.Checked;
                sp.h10 = h10.Checked;
                sp.h11 = h11.Checked;
                sp.h12 = h12.Checked;
                sp.h13 = h13.Checked;
                sp.h14 = h14.Checked;
                sp.h15 = h15.Checked;
                sp.h16 = h16.Checked;
                sp.h17 = h17.Checked;
                sp.h18 = h18.Checked;
                sp.h19 = h19.Checked;
                sp.h20 = h20.Checked;
                sp.h21 = h21.Checked;
                sp.h22 = h22.Checked;
                sp.h23 = h23.Checked;
                sp.Lunes = chckLunes.Checked;
                sp.Martes = chckMartes.Checked;
                sp.Miercoles = chckMiercoles.Checked;
                sp.Jueves = chckJueves.Checked;
                sp.Viernes = chckViernes.Checked;
                sp.Sabado = chckSabado.Checked;
                sp.Domingo = chckDomingo.Checked;

                P.PRO_SuministroDeProcedimiento.Add(sp);
                P.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Borra_Procedimientos_Asociados(int _idSumninistroProcedimiento)
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

        #region Eventos
        private void ProcedimientoV2_Load(object sender, EventArgs e)
        {
            try
            {
                if(Clases.Usuario.UsuarioLogeado.Id_Sector != 8) //medico coordinador o supervisor de enfermeria
                {
                    if (Clases.Usuario.UsuarioLogeado.Id_Sector != 13) //medico coordinador o supervisor de enfermeria
                    {
                        chckAutomatico.Hide();
                    }
                    else if(Clases.Usuario.UsuarioLogeado.Id_Sector == 13)//Usuario de farmacia
                    {
                        dataGridView1Procedimientos.Enabled = false;
                        dataGridViewMedicamentos.Enabled = false;
                        txtObs.Enabled = false;

                        // Checkboxs horas
                        h00.Enabled = false; h01.Enabled = false; h02.Enabled = false; h03.Enabled = false; h04.Enabled = false; h05.Enabled = false;
                        h06.Enabled = false; h07.Enabled = false; h08.Enabled = false; h09.Enabled = false; h10.Enabled = false; h11.Enabled = false;
                        h12.Enabled = false; h13.Enabled = false; h14.Enabled = false; h15.Enabled = false; h16.Enabled = false; h17.Enabled = false;
                        h18.Enabled = false; h19.Enabled = false; h20.Enabled = false; h21.Enabled = false; h22.Enabled = false; h23.Enabled = false;

                        // Checkboxes dias
                        chckLunes.Enabled = false; chckMartes.Enabled = false; chckMiercoles.Enabled = false; chckJueves.Enabled = false;
                        chckViernes.Enabled = false; chckSabado.Enabled = false; chckDomingo.Enabled = false;

                        chckUnicaVez.Enabled = false;
                        chckSegunNEcesidad.Enabled = false;
                        btnSuspender.Enabled = false;
                        dateSuspender.Enabled = false;
                        btMedicamento.Enabled = false;
                        btnProc.Enabled = false;
                        btnGuardar.Enabled = false;
                    }
                }

               
                TraeMedicamentosAsociados();
                TraeDescartablesAsociados();
                TraeProcedimientosAsociados();             

                if (suministro_procedimiento_id != 0)
                {
                    TraeDatosProcedimiento();
                }
                else
                {
                    chckUnicaVez.Checked = true;
                    chckUnicaVez.Checked = false;
                    chckSegunNEcesidad.Checked = true;
                    this.Text = P.PRO_Procedimiento.Find(procedimiento_id).descripcion.ToString();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnDescartable_Click(object sender, EventArgs e)
        {
            try
            {
                bool _Ingresado;
                _Ingresado = false;
                for (int i = 0; i < this.dataGridViewDescartables.Rows.Count; i++)
                {

                    string _V1 = dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.ID_DESC].Value.ToString();
                    string _V2 = cboDesc.SelectedValue.ToString();
                    if (_V1 == _V2)
                    {
                        MetroMessageBox.Show(this, "Este descartable ya esta asociado", "Alerta", MessageBoxButtons.OK);
                        _Ingresado = true;
                    }
                }
                if (_Ingresado == false)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewDescartables.RowTemplate.Clone();
                    row.CreateCells(dataGridViewDescartables, cboDesc.SelectedValue, cboDesc.Text);
                    dataGridViewDescartables.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDescartables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridViewDescartables.SelectedRows)
                    {
                        dataGridViewDescartables.Rows.RemoveAt(item.Index);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            try
            {
                bool _Ingresado;
                _Ingresado = false;
                for (int i = 0; i < this.dataGridViewMedicamentos.Rows.Count; i++)
                {
                    string _V1 = dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos.ID_MED].Value.ToString();
                    string _V2 = cboMed.SelectedValue.ToString();
                    if (_V1 == _V2)
                    {
                        MetroMessageBox.Show(this, "Este medicamento ya esta asociado", "Alerta", MessageBoxButtons.OK);
                        _Ingresado = true;
                    }
                }
                if (_Ingresado == false)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewMedicamentos.RowTemplate.Clone();
                    row.CreateCells(dataGridViewMedicamentos, cboMed.SelectedValue, cboMed.Text);
                    dataGridViewMedicamentos.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridViewMedicamentos.SelectedRows)
                    {
                        dataGridViewMedicamentos.Rows.RemoveAt(item.Index);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnProcedimiento_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult _result = MessageBox.Show("Al asociar un procedimiento se asigna de forma automatica al paciente con los mismos dias y horarios que el procedimiento actual." +
                    " Desea continuar?", "Alerta", MessageBoxButtons.YesNo);
                if (_result == DialogResult.Yes)
                {
                    bool _Ingresado;
                    _Ingresado = false;
                    for (int i = 0; i < this.dataGridView1Procedimientos.Rows.Count; i++)
                    {
                        string _V1 = dataGridView1Procedimientos.Rows[i].Cells[(int)Col_Procedimientos.ID_PROC].Value.ToString();
                        string _V2 = cboProc.SelectedValue.ToString();
                        if (_V1 == _V2)
                        {
                            MetroMessageBox.Show(this, "Este procedimiento ya esta asociado", "Alerta", MessageBoxButtons.OK);
                            _Ingresado = true;
                        }
                    }
                    if (_Ingresado == false)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1Procedimientos.RowTemplate.Clone();
                        row.CreateCells(dataGridView1Procedimientos, cboProc.SelectedValue, cboProc.Text);
                        dataGridView1Procedimientos.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1Procedimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    foreach (DataGridViewRow item in this.dataGridView1Procedimientos.SelectedRows)
                    {
                        dataGridView1Procedimientos.Rows.RemoveAt(item.Index);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ExisteProcedimiento()
        {
            try
            {
                if(suministro_procedimiento_id == 0)
                {
                    bool _existe = P.PRO_SuministroDeProcedimiento.Where(p => p.paciente_id == Clases.Paciente.PacienteIngresado && p.procedimiento_id == procedimiento_id && (p.fechaBaja == null || p.fechaBaja > DateTime.Now)).Count() > 0;
                    return _existe;
                }
                else
                {
                    return false;
                }
               
            }
            catch (Exception ex)
            {
                return false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if(dataGridViewDescartables.Rows.Count > 0)
            {
                int indice;
                bool filaRepetida = false;
                foreach (DataGridViewRow fila in dataGridViewDescartables.Rows)
                {
                    for(int i = 0; i < this.form_Farm_Principal.dataGridViewDescartables.Rows.Count; i++)
                    {
                        if (this.form_Farm_Principal.dataGridViewDescartables.Rows[i].Cells[3].Value.ToString().Trim() == fila.Cells["Descartable"].Value.ToString().Trim())
                        {
                            filaRepetida = true;
                            break;
                        }
                    }

                    if(filaRepetida == false)
                    {
                        indice = this.form_Farm_Principal.dataGridViewDescartables.Rows.Add();
                        this.form_Farm_Principal.dataGridViewDescartables.Rows[indice].Cells[3].Value = fila.Cells["Descartable"].Value;
                        this.form_Farm_Principal.dataGridViewDescartables.Rows[indice].Cells[4].Value = fila.Cells["Cantidad"].Value;
                    }
                    filaRepetida = false;
                }
            }

            SISTMEDEntities P = new SISTMEDEntities();
            
            using (var dbContextTransaction = P.Database.BeginTransaction())
            
                try
                {
                    bool _guardar = true;
                    P.Configuration.ValidateOnSaveEnabled = false;

                    if(ExisteProcedimiento())
                    {
                        DialogResult dialogResult = MessageBox.Show("Ya existe un procedimiento igual indicado, desea indicarlo de todas formas?", "Indicacion Duplicada", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogResult == DialogResult.Yes)
                        {
                            _guardar = true;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            _guardar = false;
                            this.Close();
                        }
                    }
                    if (_guardar)
                    {
                        #region Suministro Original

                        PRO_Generico genItem = new PRO_Generico();
                        genItem.paciente_id = Clases.Paciente.PacienteIngresado;
                        genItem.procedimiento_id = procedimiento_id;
                        genItem.observacion = txtObs.Text;
                        genItem.usuario_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                        genItem.fechaAltaSistema = DateTime.Now; 


                        if (suministro_procedimiento_id != 0) //Verifico antes para ver si es un nuevo procedimiento o una actualizacion
                        {
                            genItem.fechaModificacion = DateTime.Now;
                            genItem.generico_id = generico_id;
                            P.Entry(genItem).State = System.Data.Entity.EntityState.Modified;
                        }
                        else
                        {
                            P.PRO_Generico.Add(genItem);
                        }

                        PRO_SuministroDeProcedimiento spItem = new PRO_SuministroDeProcedimiento();

                        

                        spItem.paciente_id = Clases.Paciente.PacienteIngresado;
                        spItem.procedimiento_id = procedimiento_id;
                        spItem.tipoProcedimiento_id = tipo_procedimiento_id;
                        spItem.fechaAltaSistema = DateTime.Now;
                        spItem.usuario_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                        spItem.h00 = h00.Checked;
                        spItem.h01 = h01.Checked;
                        spItem.h02 = h02.Checked;
                        spItem.h03 = h03.Checked;
                        spItem.h04 = h04.Checked;
                        spItem.h05 = h05.Checked;
                        spItem.h06 = h06.Checked;
                        spItem.h07 = h07.Checked;
                        spItem.h08 = h08.Checked;
                        spItem.h09 = h09.Checked;
                        spItem.h10 = h10.Checked;
                        spItem.h11 = h11.Checked;
                        spItem.h12 = h12.Checked;
                        spItem.h13 = h13.Checked;
                        spItem.h14 = h14.Checked;
                        spItem.h15 = h15.Checked;
                        spItem.h16 = h16.Checked;
                        spItem.h17 = h17.Checked;
                        spItem.h18 = h18.Checked;
                        spItem.h19 = h19.Checked;
                        spItem.h20 = h20.Checked;
                        spItem.h21 = h21.Checked;
                        spItem.h22 = h22.Checked;
                        spItem.h23 = h23.Checked;
                        spItem.Lunes = chckLunes.Checked;
                        spItem.Martes = chckMartes.Checked;
                        spItem.Miercoles = chckMiercoles.Checked;
                        spItem.Jueves = chckJueves.Checked;
                        spItem.Viernes = chckViernes.Checked;
                        spItem.Sabado = chckSabado.Checked;
                        spItem.Domingo = chckDomingo.Checked;
                        spItem.SegunNecesidad = chckSegunNEcesidad.Checked;

                        if (chckUnicaVez.Checked)//Lo da de baja al dia siguiente
                        {
                            spItem.UnicaVez = chckUnicaVez.Checked;
                            spItem.fechaBaja = DateTime.Now.AddDays(1);
                        }

                        if (suministro_procedimiento_id != 0) //Verifico antes para ver si es un nuevo procedimiento o una actualizacion
                        {                            
                            spItem.generico_id = generico_id;
                            spItem.suministroDeProcedimiento_id = suministro_procedimiento_id;
                            P.Entry(spItem).State = System.Data.Entity.EntityState.Modified;
                        }
                        else
                        {
                            spItem.PRO_Generico = genItem;
                            P.PRO_SuministroDeProcedimiento.Add(spItem);
                        }

                        #endregion

                        #region Asocia Medicacion y Descartables

                        PRO_Asociacion_Procedimiento aProItem = new PRO_Asociacion_Procedimiento();


                        if (suministro_procedimiento_id != 0) //Verifico antes para ver si es un nuevo procedimiento o una actualizacion
                        {
                            P.PRO_Asociacion_Procedimiento.RemoveRange(P.PRO_Asociacion_Procedimiento.Where(x => x.suministro_procedimiento_id == suministro_procedimiento_id));
                        }

                        for (int i = 0; i < dataGridViewDescartables.Rows.Count; i++)
                        {
                            aProItem = new PRO_Asociacion_Procedimiento();
                            aProItem.procedimiento_id = Procedimiento_Id;
                            aProItem.articulo_id = dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.ID_DESC].Value.ToString();
                            aProItem.tipo_articulo = "DESC";
                            aProItem.cantidad = Convert.ToDecimal(dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.CANTIDAD].Value);

                            if (suministro_procedimiento_id != 0) //Verifico antes para ver si es un nuevo procedimiento o una actualizacion
                            {
                                aProItem.suministro_procedimiento_id = suministro_procedimiento_id;
                            }
                            else
                            {
                                aProItem.PRO_SuministroDeProcedimiento = spItem;
                            }

                            P.PRO_Asociacion_Procedimiento.Add(aProItem);

                            if (chckAutomatico.Checked)
                            {
                                P.PRO_Asociacion_Procedimiento.RemoveRange(P.PRO_Asociacion_Procedimiento.Where(p => p.procedimiento_id == procedimiento_id && p.suministro_procedimiento_id == null));
                                aProItem = new PRO_Asociacion_Procedimiento();
                                aProItem.procedimiento_id = Procedimiento_Id;
                                aProItem.articulo_id = dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.ID_DESC].Value.ToString();
                                aProItem.tipo_articulo = "DESC";
                                aProItem.cantidad = Convert.ToDecimal(dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.CANTIDAD].Value);
                                aProItem.suministro_procedimiento_id = null;
                                P.PRO_Asociacion_Procedimiento.Add(aProItem);
                            }

                        }
                        for (int i = 0; i < dataGridViewMedicamentos.Rows.Count; i++)
                        {
                            P.PRO_Asociacion_Procedimiento.RemoveRange(P.PRO_Asociacion_Procedimiento.Where(p => p.procedimiento_id == procedimiento_id && p.suministro_procedimiento_id == null));
                            aProItem = new PRO_Asociacion_Procedimiento();
                            aProItem.procedimiento_id = Procedimiento_Id;
                            aProItem.articulo_id = dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos.ID_MED].Value.ToString();
                            aProItem.tipo_articulo = "MED";
                            aProItem.cantidad = Convert.ToDecimal(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos.DOSIS].Value);

                            if (suministro_procedimiento_id != 0) //Verifico antes para ver si es un nuevo procedimiento o una actualizacion
                            {
                                aProItem.suministro_procedimiento_id = suministro_procedimiento_id;
                            }
                            else
                            {
                                aProItem.PRO_SuministroDeProcedimiento = spItem;
                            }

                            P.PRO_Asociacion_Procedimiento.Add(aProItem);

                            if (chckAutomatico.Checked)
                            {
                                P.PRO_Asociacion_Procedimiento.RemoveRange(P.PRO_Asociacion_Procedimiento.Where(p => p.procedimiento_id == procedimiento_id && p.suministro_procedimiento_id == null));
                                aProItem = new PRO_Asociacion_Procedimiento();
                                aProItem.procedimiento_id = Procedimiento_Id;
                                aProItem.articulo_id = dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos.ID_MED].Value.ToString();
                                aProItem.tipo_articulo = "MED";
                                aProItem.cantidad = Convert.ToDecimal(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos.DOSIS].Value);
                                aProItem.suministro_procedimiento_id = null;
                                P.PRO_Asociacion_Procedimiento.Add(aProItem);
                            }
                        }
                        #endregion

                        #region Asocia Procedimientos

                        PRO_Asociacion_Procedimiento_Proc asocProcItem = new PRO_Asociacion_Procedimiento_Proc();


                        if (suministro_procedimiento_id != 0)
                        {
                            P.PRO_Asociacion_Procedimiento_Proc.RemoveRange(P.PRO_Asociacion_Procedimiento_Proc.Where(x => x.suministro_procedimiento_id == suministro_procedimiento_id));
                        }

                        for (int i = 0; i < dataGridView1Procedimientos.Rows.Count; i++)
                        {
                            asocProcItem = new PRO_Asociacion_Procedimiento_Proc();
                            asocProcItem.procedimiento_id = procedimiento_id;
                            asocProcItem.procedimiento_id2 = Convert.ToInt32(dataGridView1Procedimientos.Rows[i].Cells[(int)Col_Procedimientos.ID_PROC].Value);


                            if (suministro_procedimiento_id != 0)
                            {
                                asocProcItem.suministro_procedimiento_id = suministro_procedimiento_id;
                            }
                            else
                            {
                                asocProcItem.PRO_SuministroDeProcedimiento = spItem;
                            }

                            P.PRO_Asociacion_Procedimiento_Proc.Add(asocProcItem);

                            if (chckAutomatico.Checked)
                            {
                                P.PRO_Asociacion_Procedimiento_Proc.RemoveRange(P.PRO_Asociacion_Procedimiento_Proc.Where(p => p.procedimiento_id == procedimiento_id && p.suministro_procedimiento_id == null));
                                asocProcItem = new PRO_Asociacion_Procedimiento_Proc();
                                asocProcItem.procedimiento_id = procedimiento_id;
                                asocProcItem.procedimiento_id2 = Convert.ToInt32(dataGridView1Procedimientos.Rows[i].Cells[(int)Col_Procedimientos.ID_PROC].Value);
                                asocProcItem.suministro_procedimiento_id = null;
                                P.PRO_Asociacion_Procedimiento_Proc.Add(asocProcItem);
                            }

                            if (suministro_procedimiento_id == 0)
                            {
                                Guarda_Procedimiento_Asociados(asocProcItem.procedimiento_id2);
                            }
                        }

                        #endregion

                        #region Historico 

                        PRO_SuministroDeProcedimiento_Historico _itemHistorico = new PRO_SuministroDeProcedimiento_Historico();

                        _itemHistorico.suministroDeProcedimiento_id = spItem.suministroDeProcedimiento_id;
                        _itemHistorico.paciente_id = spItem.paciente_id;
                        _itemHistorico.tipoProcedimiento_id = spItem.tipoProcedimiento_id;
                        _itemHistorico.usuario_id = spItem.usuario_id;
                        //_itemHistorico.fechaAltaSistema = spItem.fechaAltaSistema;
                        //_itemHistorico.fechaModificiacion = DateTime.Now;
                        //_itemHistorico.fechaBaja = spItem.fechaBaja;
                        _itemHistorico.motivoBaja = spItem.motivoBaja;
                        _itemHistorico.enfermeria_id = spItem.enfermeria_id;
                        _itemHistorico.posologia_id = spItem.posologia_id;
                        _itemHistorico.generico_id = spItem.generico_id;
                        _itemHistorico.colocacionViaPeriferica_id = spItem.colocacionViaPeriferica_id;
                        _itemHistorico.cuidadoOral_id = spItem.cuidadoOral_id;
                        _itemHistorico.cuidadoPostural_id = spItem.cuidadoPostural_id;
                        _itemHistorico.php_id = spItem.php_id;
                        _itemHistorico.proteccionFisica_id = spItem.proteccionFisica_id;
                        _itemHistorico.h00 = spItem.h00;
                        _itemHistorico.h01 = spItem.h01;
                        _itemHistorico.h02 = spItem.h02;
                        _itemHistorico.h03 = spItem.h03;
                        _itemHistorico.h04 = spItem.h04;
                        _itemHistorico.h05 = spItem.h05;
                        _itemHistorico.h06 = spItem.h06;
                        _itemHistorico.h07 = spItem.h07;
                        _itemHistorico.h08 = spItem.h08;
                        _itemHistorico.h09 = spItem.h09;
                        _itemHistorico.h10 = spItem.h10;
                        _itemHistorico.h11 = spItem.h11;
                        _itemHistorico.h12 = spItem.h12;
                        _itemHistorico.h13 = spItem.h13;
                        _itemHistorico.h14 = spItem.h14;
                        _itemHistorico.h15 = spItem.h15;
                        _itemHistorico.h16 = spItem.h16;
                        _itemHistorico.h17 = spItem.h17;
                        _itemHistorico.h18 = spItem.h18;
                        _itemHistorico.h19 = spItem.h19;
                        _itemHistorico.h20 = spItem.h20;
                        _itemHistorico.h21 = spItem.h21;
                        _itemHistorico.h22 = spItem.h22;
                        _itemHistorico.h23 = spItem.h23;
                        _itemHistorico.Lunes = spItem.Lunes;
                        _itemHistorico.Martes = spItem.Martes;
                        _itemHistorico.Miercoles = spItem.Miercoles;
                        _itemHistorico.Jueves = spItem.Jueves;
                        _itemHistorico.Viernes = spItem.Viernes;
                        _itemHistorico.Sabado = spItem.Sabado;
                        _itemHistorico.Domingo = spItem.Domingo;
                        _itemHistorico.SegunNecesidad = spItem.SegunNecesidad;
                        _itemHistorico.UnicaVez = spItem.UnicaVez;
                        _itemHistorico.procedimiento_id = Procedimiento_Id;

                        PRO_SuministroDeProcedimiento _itemSuministroOriginal = P.PRO_SuministroDeProcedimiento.AsNoTracking().Where(ssp=>ssp.suministroDeProcedimiento_id == suministro_procedimiento_id).SingleOrDefault();
                        if (suministro_procedimiento_id != 0)
                        {
                            
                            _itemHistorico.fechaAltaSistema = _itemSuministroOriginal.fechaAltaSistema;
                        }
                        else
                        {
                            _itemHistorico.fechaAltaSistema = spItem.fechaAltaSistema;
                        }

                        _itemHistorico.fechaModificiacion = DateTime.Now; //Se modifico en ese momento      

                        if (suministro_procedimiento_id != 0)//Es una actualizacion
                        {
                            _itemHistorico.motivoBaja = "Modifica Indicacion: " + Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                        }
                        else
                        {
                            _itemHistorico.motivoBaja = "Agrega Indicacion: " + Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                        }
                        if (spItem.fechaBaja != null)
                        {
                            _itemHistorico.motivoBaja = "Suspende Indicacion: " + Clases.Usuario.UsuarioLogeado.usuario_Logeado;
                            _itemHistorico.fechaBaja = spItem.fechaBaja;
                        }


                        if (suministro_procedimiento_id != 0)
                        {
                            _itemHistorico.suministro_original = _itemSuministroOriginal.suministroDeProcedimiento_id;
                        }
                        else
                        {
                            _itemHistorico.PRO_SuministroDeProcedimiento = spItem;
                        }

                        P.PRO_SuministroDeProcedimiento_Historico.Add(_itemHistorico);

                        //Verifico el registro anterior para cambiar fecha de baja si es una nueva no hay registros anteriores
                        if (suministro_procedimiento_id != 0)
                        {
                            var _suministroAnterior = P.PRO_SuministroDeProcedimiento_Historico.AsNoTracking().Where(s => s.suministro_original == suministro_procedimiento_id).OrderByDescending(f => f.fechaModificiacion).FirstOrDefault();

                            if(_suministroAnterior != null)
                            {
                                PRO_SuministroDeProcedimiento_Historico MED = new PRO_SuministroDeProcedimiento_Historico { suministroDeProcedimiento_id = _suministroAnterior.suministroDeProcedimiento_id, fechaBaja = DateTime.Now };
                                P.PRO_SuministroDeProcedimiento_Historico.Attach(MED);
                                P.Entry(MED).Property(f => f.fechaBaja).IsModified = true;
                            }                            
                        }

                        #endregion

                        P.SaveChanges();
                        dbContextTransaction.Commit();

                        if(_factu == false)
                        {
                            if (suministro_procedimiento_id != 0)
                            { ActualizarIndicacion(); }
                            else
                            { Opener.IActualiza(); }
                            // MetroMessageBox.Show(this,"Se agrego correctamente el procedimiento");   
                        }

                        this.Close();
                    }
                }
                
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void EliminaRelaciones(int _suministroID)
        {
            try
            {
               

                
                
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
                SISTMEDEntities P = new SISTMEDEntities();
                P.Configuration.ValidateOnSaveEnabled = false;

                DialogResult _result = MessageBox.Show("Desea suspender el procedimiento?", "Suspender", MessageBoxButtons.YesNo);
                if (_result == DialogResult.Yes)
                {
                    PRO_SuministroDeProcedimiento sp = new PRO_SuministroDeProcedimiento { suministroDeProcedimiento_id = suministro_procedimiento_id, fechaBaja = dateSuspender.Value };
                    P.PRO_SuministroDeProcedimiento.Attach(sp);
                    P.Entry(sp).Property(p => p.fechaBaja).IsModified = true;

                    var _listaProcedimientosEliminar = P.PRO_Asociacion_Procedimiento_Proc.Where(pro => pro.suministro_procedimiento_id == suministro_procedimiento_id);

                    foreach (var _itemProcedimientoElim in _listaProcedimientosEliminar)
                    {
                        var procedimientosSuspender = P.PRO_SuministroDeProcedimiento.Where(pro => pro.paciente_id == Clases.Paciente.PacienteIngresado && pro.procedimiento_id == _itemProcedimientoElim.procedimiento_id2 && pro.fechaBaja == null);

                        foreach (var _itemSuspender in procedimientosSuspender)
                        {
                            _itemSuspender.fechaBaja = dateSuspender.Value;
                            P.Entry(_itemSuspender).State = System.Data.Entity.EntityState.Modified;
                        }
                    }

                    P.SaveChanges();
                    if (suministro_procedimiento_id != 0)
                    {
                        ActualizarIndicacion();
                    }
                    else
                    { Opener.IActualiza(); }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckUnicaVez_CheckedChanged(object sender, EventArgs e)
        {
            dateSuspender.Value = DateTime.Now.AddDays(1);
            if(chckUnicaVez.Checked)
            {
                labelFinaliza.Visible = true;
                foreach(Control c in groupBoxDias.Controls)
                {
                    if(c is CheckBox && ((CheckBox)c).Name != chckUnicaVez.Name)
                    {
                        ((CheckBox)c).Enabled = false;
                        ((CheckBox)c).Checked = false;
                    }
                }         

            }
            else
            {
                labelFinaliza.Visible = false;
                foreach (Control c in groupBoxDias.Controls)
                {
                    if (c is CheckBox && ((CheckBox)c).Name != chckUnicaVez.Name)
                    {
                        ((CheckBox)c).Enabled = true;
                        ((CheckBox)c).Checked = true;
                    }
                }
            }                                                                                                                                                                                                                                                                                                                                                   
            
        }

        private void chckSegunNEcesidad_CheckedChanged(object sender, EventArgs e)
        {
            if (chckSegunNEcesidad.Checked)
            {
             
                foreach (Control c in groupBoxHorarios.Controls)
                {
                    if (c is CheckBox && ((CheckBox)c).Name != chckSegunNEcesidad.Name)
                    {
                        ((CheckBox)c).Enabled = false;
                        ((CheckBox)c).Checked = false;
                    }
                }

            }
            else
            {              
                foreach (Control c in groupBoxHorarios.Controls)
                {
                    if (c is CheckBox && ((CheckBox)c).Name != chckSegunNEcesidad.Name)
                    {
                        ((CheckBox)c).Enabled = true;                       
                    }
                }
            }
        }

        private void bbtnDescartables_Click(object sender, EventArgs e)
        {
            try
            {
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Datos = this;
                _pop._tipo = 'D';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btMedicamento_Click(object sender, EventArgs e)
        {
            try
            {
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Datos = this;
                _pop._tipo = 'M';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            try
            {
                ProcedimientoV2_PopUP _pop = new ProcedimientoV2_PopUP();
                _pop._Datos = this;
                _pop._tipo = 'P';
                _pop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDescartables_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Console.WriteLine("Se agregaron: " + e.RowCount + " filas");
            btnGuardar.Enabled = true;
        }
    }
 }