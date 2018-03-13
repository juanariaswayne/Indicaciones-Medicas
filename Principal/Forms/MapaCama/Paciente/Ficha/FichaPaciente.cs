using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionMethods;
using System.Globalization;

namespace Principal.Forms.MapaCama.Paciente.Ficha
{
    public partial class FichaPaciente : MetroForm
    {
        
        #region Variables
        public int paciente_id;
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
        private Point _imageLocation = new Point(13, 5);
        private Point _imgHitArea = new Point(13, 2);
        bool _tabAbierta;

        Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion  _indicacion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion();
        Forms.MapaCama.Paciente.Ficha.Imagenes.Imagenes  _imagenes = new MapaCama.Paciente.Ficha.Imagenes.Imagenes();
        
        Forms.MapaCama.Paciente.Ficha.HC.HC _HC = new MapaCama.Paciente.Ficha.HC.HC();
        Forms.MapaCama.Paciente.Ficha.HC.Prorroga _Prorroga = new MapaCama.Paciente.Ficha.HC.Prorroga();
        Forms.MapaCama.Paciente.Ficha.HC.Epicrisis _Epicrisis = new MapaCama.Paciente.Ficha.HC.Epicrisis();
        Forms.MapaCama.Paciente.Ficha.Laboratorio.ResultadosLab _Laboratorio = new  Laboratorio.ResultadosLab();

        #endregion

        #region Inicio
        public FichaPaciente()
        {
            InitializeComponent();
        }
    
        #endregion

        #region Eventos
        private void FichaPaciente_Load(object sender, EventArgs e)
        {
            Get_Ficha_Paciente(paciente_id);           
            this.treeFicha.TopNode.Expand();

            Clases.Paciente.PacienteIngresado = Paciente_Id;
            TabPage _newTab = new TabPage("Indicacion");
            _indicacion.panelIndicacion.BackColor = Color.White;
            _indicacion.panelIndicacion.Dock = DockStyle.Fill;
            _newTab.Controls.Add(_indicacion.panelIndicacion);
            _indicacion.CargaIndicaciones();
            tabContenido.TabPages.Add(_newTab);
            tabContenido.SelectedTab = _newTab;
            _tabAbierta = true;
        }
        void ToolStripButton_Click(object sender, EventArgs e)
        {
            ToolStripButton t = (ToolStripButton)(sender);
            ToolStrip ts = t.Owner;
            TabPage tb = (TabPage)
            (ts.Parent); tabContenido.TabPages.Remove(tb);
        }
        private void treeFicha_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "Indicacion")
            {
               
                _tabAbierta = false;
                foreach (TabPage _page in tabContenido.TabPages)
                {
                    if (_page.Text == e.Node.Text)
                    {
                        tabContenido.SelectedTab = _page;                   
                        _tabAbierta = true;
                    }
                }
                if (_tabAbierta == false)
                {
                    Clases.Paciente.PacienteIngresado = Paciente_Id;
                    TabPage _newTab = new TabPage(e.Node.Text);                    
                    _indicacion.panelIndicacion.BackColor = Color.White;
                    _indicacion.panelIndicacion.Dock = DockStyle.Fill;                 
                    _newTab.Controls.Add(_indicacion.panelIndicacion);
                    _indicacion.CargaIndicaciones();                                    
                    tabContenido.TabPages.Add(_newTab);
                    tabContenido.SelectedTab = _newTab;
                }
            }

            if (e.Node.Name == "Archivos")
            {
                Cursor = Cursors.WaitCursor;
                bool _tabAbierta;
                _tabAbierta = false;
                foreach (TabPage _page in tabContenido.TabPages)
                {
                    if (_page.Text == e.Node.Text)
                    {
                        tabContenido.SelectedTab = _page;
                        _tabAbierta = true;
                    }
                }
                if (_tabAbierta == false)
                {
                   
                }
                Cursor = Cursors.Arrow;
            }

            if (e.Node.Name == "H.C")
            {
                bool _tabAbierta;
                _tabAbierta = false;
                foreach (TabPage _page in tabContenido.TabPages)
                {
                    if (_page.Text == e.Node.Text)
                    {
                        tabContenido.SelectedTab = _page;
                        _tabAbierta = true;
                    }
                }
                if (_tabAbierta == false)
                {
                    Clases.Paciente.PacienteIngresado = Paciente_Id;
                    TabPage _newTab = new TabPage(e.Node.Text);
                    _HC.panelHC.BackColor = Color.White;
                    //_prorrogas.CargarProrrogas();
                    _newTab.Controls.Add(_HC.panelHC);                   
                    tabContenido.TabPages.Add(_newTab);
                    tabContenido.SelectedTab = _newTab;
                }
            }

            if (e.Node.Name == "Prorrogas")
            {
                bool _tabAbierta;
                _tabAbierta = false;
                foreach (TabPage _page in tabContenido.TabPages)
                {
                    if (_page.Text == e.Node.Text)
                    {
                        tabContenido.SelectedTab = _page;
                        _tabAbierta = true;
                    }
                }
                if (_tabAbierta == false)
                {
                    Clases.Paciente.PacienteIngresado = Paciente_Id;
                    TabPage _newTab = new TabPage(e.Node.Text);
                    _Prorroga.panelProrrogas.BackColor = Color.White;
                    _Prorroga.TraeProrrogas();
                    _newTab.Controls.Add(_Prorroga.panelProrrogas);
                    tabContenido.TabPages.Add(_newTab);
                    tabContenido.SelectedTab = _newTab;
                }
            }

            if (e.Node.Name == "Epicrisis")
            {
                bool _tabAbierta;
                _tabAbierta = false;
                foreach (TabPage _page in tabContenido.TabPages)
                {
                    if (_page.Text == e.Node.Text)
                    {
                        tabContenido.SelectedTab = _page;
                        _tabAbierta = true;
                    }
                }
                if (_tabAbierta == false)
                {
                    Clases.Paciente.PacienteIngresado = Paciente_Id;
                    TabPage _newTab = new TabPage(e.Node.Text);
                    _Epicrisis.panelEpicrisis.BackColor = Color.White;
                    _Epicrisis.TraeEpicrisis();
                    _newTab.Controls.Add(_Epicrisis.panelEpicrisis);
                    tabContenido.TabPages.Add(_newTab);
                    tabContenido.SelectedTab = _newTab;
                }
            }

            if (e.Node.Name == "Laboratorio")
            {
                bool _tabAbierta;
                _tabAbierta = false;
                foreach (TabPage _page in tabContenido.TabPages)
                {
                    if (_page.Text == e.Node.Text)
                    {
                        tabContenido.SelectedTab = _page;
                        _tabAbierta = true;
                    }
                }
                if (_tabAbierta == false)
                {
                    Clases.Paciente.PacienteIngresado = Paciente_Id;
                    TabPage _newTab = new TabPage(e.Node.Text);
                    _Laboratorio.panelLab.BackColor = Color.White;
                    _Laboratorio.CargaLaboratorios();
                    _newTab.Controls.Add(_Laboratorio.panelLab);
                    tabContenido.TabPages.Add(_newTab);
                    tabContenido.SelectedTab = _newTab;
                }
            }
        }
      
        private void tabContenido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tabContenido.TabPages.Count == 0) return;
            tabContenido.TabPages.Remove(tabContenido.SelectedTab);
        }
        private void tabContenido_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabContenido.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }
        private void DrawOnTab(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabContenido.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Metodos
        private void Get_Ficha_Paciente(int paciente_id)
        {
           
            try
            {
                this.Text = Clases.Paciente.PacienteNombre;
                //CultureInfo culture = new CultureInfo("en-US");
                //BLL.Procedures.GET_PACIENTE _obtienePaciente = new BLL.Procedures.GET_PACIENTE();
                //foreach (Entities.Procedures.GET_PACIENTE item in _obtienePaciente.ItemList(paciente_id))
                //{
                //    DateTime fechaActual = DateTime.Now;
                //    this.lblHistoriaClinica.Text = "HC: "+  Convert.ToString(item.paciente_id);
                //    //this.txtNumeroInternacion.Text = Convert.ToString(item.numerointernacion);
                //    this.lblHabitacion.Text = "Habitacion: "+item.habitacion;
                //    this.Text = item.nombre+" "+item.apellido;
                //    DateTime fechaNacimiento = Convert.ToDateTime(item.fechanacimiento.ToShortDateString());
                //    TimeSpan edad = fechaActual - fechaNacimiento;
                //    this.lblEdad.Text = "Edad: "+Convert.ToString(edad.Days/365);
                //    this.lblTipoDocumento.Text = "Doc.: "+item.documento.ToString() +" "+ Convert.ToString(item.numerodocumento);
                    
                //    this.lblDiagnostico.Text = "Diagnostico: "+item.diagnostico_id;
                //    this.lblFechaIngreso.Text = "Fecha Ingreso: "+Convert.ToString(item.fechaingreso.ToShortDateString());
                //    DateTime fechaIngreso = Convert.ToDateTime(item.fechaingreso);
                //    TimeSpan diasInternado = fechaActual - fechaIngreso;
                //    this.lblDiasInternados.Text = "Dias Internado: "+Convert.ToString(diasInternado.Days);
                //    this.lblObraSocial.Text = "Obra Social: "+item.obrasocial;
                //    //this.lblNumeroObraSocial.Text = "Num. Afiliado: "+Convert.ToString(item.numeroobrasocial);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void groupDetalle_Enter(object sender, EventArgs e)
        {

        }
       
        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
