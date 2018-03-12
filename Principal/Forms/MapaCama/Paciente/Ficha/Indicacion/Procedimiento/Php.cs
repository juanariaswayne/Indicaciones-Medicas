using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Globalization;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento
{
    public partial class Php : MetroForm
    {
        #region Variables
        public delegate void Indicacion();
        public event Indicacion ActualizarIndicacion;
        public IActuIndicaciones Opener { get; set; }
        private int minutos = 60;
        private int horas = 24;
        private int gotasPorMl = 20;
        
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

        private int php_id;
        public int Php_Id
        {
            get
            {
                return php_id;
            }
            set
            {
                this.php_id = value;
            }
        }

        #endregion

        #region Inicio
        public Php()
        {
            InitializeComponent();
        }
        private void Php_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCboGotaHora();
                CargarCboFrascoUno();
                CargarCboFrascoDos();
                CargarCboFrascoTres();
                CargarCboFrascoCuatro();
                CargarCboFrascoCinco();
                CargarCboFrascoSeis();
                CargarCboFrascoSiete();
                CargarCboFrascoOcho();
                CargarCboFrascoNueve();
                CargarCboFrascoDiez();
                CargarCboAditivoUno();
                CargarCboAditivoDos();
                CargarCboAditivoTres();
                CargarCboAditivoCuatro();
                CargarCboAditivoCinco();
                CargarCboAditivoSeis();
                CargarCboAditivoSiete();
                CargarCboAditivoOcho();
                CargarCboAditivoNueve();
                CargarCboAditivoDiez();

                this.txtMlHora.Enabled = false;
                this.txtMlDia.Enabled = false;
                
                if (suministro_procedimiento_id != 0)
                {
                    Get_Php(php_id);
                    btnGuardar.Enabled = false;
                    btnSalir.Enabled = false;
                    btnModificar.Enabled = true;
                    btnSalir.Enabled = true;
                    this.radio500ML.Checked = true;
                }
                else
                {
                    btnModificar.Enabled = false;
                    this.radio100ML.Checked = true;
                    this.cboFrascoUno.Enabled = false;
                    this.cboAditivoUno.Enabled = false;
                    this.cboFrascoSeis.Enabled = false;
                    this.cboAditivoSeis.Enabled = false;
                    this.cboFrascoDos.Enabled = false;
                    this.cboAditivoDos.Enabled = false;
                    this.cboFrascoSiete.Enabled = false;
                    this.cboAditivoSiete.Enabled = false;
                    this.cboFrascoTres.Enabled = false;
                    this.cboAditivoTres.Enabled = false;
                    this.cboFrascoOcho.Enabled = false;
                    this.cboAditivoOcho.Enabled = false;
                    this.cboFrascoCuatro.Enabled = false;
                    this.cboAditivoCuatro.Enabled = false;
                    this.cboFrascoNueve.Enabled = false;
                    this.cboAditivoNueve.Enabled = false;
                    this.cboFrascoCinco.Enabled = false;
                    this.cboAditivoCinco.Enabled = false;
                    this.cboFrascoDiez.Enabled = false;
                    this.cboAditivoDiez.Enabled = false;
                    this.groupSuspender.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos       
        // Combos
        #region combos
        private void CargarCboGotaHora()
        {
            try
            {
                BLL.Tables.PRO_GOTA_HORA _os = new BLL.Tables.PRO_GOTA_HORA();
                Entities.Tables.PRO_GOTA_HORA _itemSeleccion = new Entities.Tables.PRO_GOTA_HORA();
                List<Entities.Tables.PRO_GOTA_HORA> _ItemsOS = new List<Entities.Tables.PRO_GOTA_HORA>();
                //Limpia el combo
                this.cboGotaHora.SuspendLayout();
                this.cboGotaHora.DataSource = null;
                this.cboGotaHora.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "";
                _itemSeleccion.GOTAHORA_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboGotaHora.DisplayMember = BLL.Tables.PRO_GOTA_HORA.ColumnNames.DESCRIPCION;
                this.cboGotaHora.ValueMember = BLL.Tables.PRO_GOTA_HORA.ColumnNames.GOTAHORA_ID;
                this.cboGotaHora.DataSource = _ItemsOS;
                this.cboGotaHora.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboFrascoUno()
        {
            try
            {
                BLL.Tables.PRO_FRASCO _os = new BLL.Tables.PRO_FRASCO();
                Entities.Tables.PRO_FRASCO _itemSeleccion = new Entities.Tables.PRO_FRASCO();
                List<Entities.Tables.PRO_FRASCO> _ItemsOS = new List<Entities.Tables.PRO_FRASCO>();
                //Limpia el combo
                this.cboFrascoUno.SuspendLayout();
                this.cboFrascoUno.DataSource = null;
                this.cboFrascoUno.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.FRASCO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboFrascoUno.DisplayMember = BLL.Tables.PRO_FRASCO.ColumnNames.DESCRIPCION;
                this.cboFrascoUno.ValueMember = BLL.Tables.PRO_FRASCO.ColumnNames.FRASCO_ID;
                this.cboFrascoUno.DataSource = _ItemsOS;
                this.cboFrascoUno.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboFrascoDos()
        {
            try
            {
                BLL.Tables.PRO_FRASCO _os = new BLL.Tables.PRO_FRASCO();
                Entities.Tables.PRO_FRASCO _itemSeleccion = new Entities.Tables.PRO_FRASCO();
                List<Entities.Tables.PRO_FRASCO> _ItemsOS = new List<Entities.Tables.PRO_FRASCO>();
                //Limpia el combo
                this.cboFrascoDos.SuspendLayout();
                this.cboFrascoDos.DataSource = null;
                this.cboFrascoDos.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.FRASCO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboFrascoDos.DisplayMember = BLL.Tables.PRO_FRASCO.ColumnNames.DESCRIPCION;
                this.cboFrascoDos.ValueMember = BLL.Tables.PRO_FRASCO.ColumnNames.FRASCO_ID;
                this.cboFrascoDos.DataSource = _ItemsOS;
                this.cboFrascoDos.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboFrascoTres()
        {
            try
            {
                BLL.Tables.PRO_FRASCO _os = new BLL.Tables.PRO_FRASCO();
                Entities.Tables.PRO_FRASCO _itemSeleccion = new Entities.Tables.PRO_FRASCO();
                List<Entities.Tables.PRO_FRASCO> _ItemsOS = new List<Entities.Tables.PRO_FRASCO>();
                //Limpia el combo
                this.cboFrascoTres.SuspendLayout();
                this.cboFrascoTres.DataSource = null;
                this.cboFrascoTres.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.FRASCO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboFrascoTres.DisplayMember = BLL.Tables.PRO_FRASCO.ColumnNames.DESCRIPCION;
                this.cboFrascoTres.ValueMember = BLL.Tables.PRO_FRASCO.ColumnNames.FRASCO_ID;
                this.cboFrascoTres.DataSource = _ItemsOS;
                this.cboFrascoTres.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboFrascoCuatro()
        {
            try
            {
                BLL.Tables.PRO_FRASCO _os = new BLL.Tables.PRO_FRASCO();
                Entities.Tables.PRO_FRASCO _itemSeleccion = new Entities.Tables.PRO_FRASCO();
                List<Entities.Tables.PRO_FRASCO> _ItemsOS = new List<Entities.Tables.PRO_FRASCO>();
                //Limpia el combo
                this.cboFrascoCuatro.SuspendLayout();
                this.cboFrascoCuatro.DataSource = null;
                this.cboFrascoCuatro.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.FRASCO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboFrascoCuatro.DisplayMember = BLL.Tables.PRO_FRASCO.ColumnNames.DESCRIPCION;
                this.cboFrascoCuatro.ValueMember = BLL.Tables.PRO_FRASCO.ColumnNames.FRASCO_ID;
                this.cboFrascoCuatro.DataSource = _ItemsOS;
                this.cboFrascoCuatro.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboFrascoCinco()
        {
            try
            {
                BLL.Tables.PRO_FRASCO _os = new BLL.Tables.PRO_FRASCO();
                Entities.Tables.PRO_FRASCO _itemSeleccion = new Entities.Tables.PRO_FRASCO();
                List<Entities.Tables.PRO_FRASCO> _ItemsOS = new List<Entities.Tables.PRO_FRASCO>();
                //Limpia el combo
                this.cboFrascoCinco.SuspendLayout();
                this.cboFrascoCinco.DataSource = null;
                this.cboFrascoCinco.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.FRASCO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboFrascoCinco.DisplayMember = BLL.Tables.PRO_FRASCO.ColumnNames.DESCRIPCION;
                this.cboFrascoCinco.ValueMember = BLL.Tables.PRO_FRASCO.ColumnNames.FRASCO_ID;
                this.cboFrascoCinco.DataSource = _ItemsOS;
                this.cboFrascoCinco.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboFrascoSeis()
        {
            try
            {
                BLL.Tables.PRO_FRASCO _os = new BLL.Tables.PRO_FRASCO();
                Entities.Tables.PRO_FRASCO _itemSeleccion = new Entities.Tables.PRO_FRASCO();
                List<Entities.Tables.PRO_FRASCO> _ItemsOS = new List<Entities.Tables.PRO_FRASCO>();
                //Limpia el combo
                this.cboFrascoSeis.SuspendLayout();
                this.cboFrascoSeis.DataSource = null;
                this.cboFrascoSeis.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.FRASCO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboFrascoSeis.DisplayMember = BLL.Tables.PRO_FRASCO.ColumnNames.DESCRIPCION;
                this.cboFrascoSeis.ValueMember = BLL.Tables.PRO_FRASCO.ColumnNames.FRASCO_ID;
                this.cboFrascoSeis.DataSource = _ItemsOS;
                this.cboFrascoSeis.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboFrascoSiete()
        {
            try
            {
                BLL.Tables.PRO_FRASCO _os = new BLL.Tables.PRO_FRASCO();
                Entities.Tables.PRO_FRASCO _itemSeleccion = new Entities.Tables.PRO_FRASCO();
                List<Entities.Tables.PRO_FRASCO> _ItemsOS = new List<Entities.Tables.PRO_FRASCO>();
                //Limpia el combo
                this.cboFrascoSiete.SuspendLayout();
                this.cboFrascoSiete.DataSource = null;
                this.cboFrascoSiete.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.FRASCO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboFrascoSiete.DisplayMember = BLL.Tables.PRO_FRASCO.ColumnNames.DESCRIPCION;
                this.cboFrascoSiete.ValueMember = BLL.Tables.PRO_FRASCO.ColumnNames.FRASCO_ID;
                this.cboFrascoSiete.DataSource = _ItemsOS;
                this.cboFrascoSiete.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboFrascoOcho()
        {
            try
            {
                BLL.Tables.PRO_FRASCO _os = new BLL.Tables.PRO_FRASCO();
                Entities.Tables.PRO_FRASCO _itemSeleccion = new Entities.Tables.PRO_FRASCO();
                List<Entities.Tables.PRO_FRASCO> _ItemsOS = new List<Entities.Tables.PRO_FRASCO>();
                //Limpia el combo
                this.cboFrascoOcho.SuspendLayout();
                this.cboFrascoOcho.DataSource = null;
                this.cboFrascoOcho.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.FRASCO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboFrascoOcho.DisplayMember = BLL.Tables.PRO_FRASCO.ColumnNames.DESCRIPCION;
                this.cboFrascoOcho.ValueMember = BLL.Tables.PRO_FRASCO.ColumnNames.FRASCO_ID;
                this.cboFrascoOcho.DataSource = _ItemsOS;
                this.cboFrascoOcho.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboFrascoNueve()
        {
            try
            {
                BLL.Tables.PRO_FRASCO _os = new BLL.Tables.PRO_FRASCO();
                Entities.Tables.PRO_FRASCO _itemSeleccion = new Entities.Tables.PRO_FRASCO();
                List<Entities.Tables.PRO_FRASCO> _ItemsOS = new List<Entities.Tables.PRO_FRASCO>();
                //Limpia el combo
                this.cboFrascoNueve.SuspendLayout();
                this.cboFrascoNueve.DataSource = null;
                this.cboFrascoNueve.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.FRASCO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboFrascoNueve.DisplayMember = BLL.Tables.PRO_FRASCO.ColumnNames.DESCRIPCION;
                this.cboFrascoNueve.ValueMember = BLL.Tables.PRO_FRASCO.ColumnNames.FRASCO_ID;
                this.cboFrascoNueve.DataSource = _ItemsOS;
                this.cboFrascoNueve.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboFrascoDiez()
        {
            try
            {
                BLL.Tables.PRO_FRASCO _os = new BLL.Tables.PRO_FRASCO();
                Entities.Tables.PRO_FRASCO _itemSeleccion = new Entities.Tables.PRO_FRASCO();
                List<Entities.Tables.PRO_FRASCO> _ItemsOS = new List<Entities.Tables.PRO_FRASCO>();
                //Limpia el combo
                this.cboFrascoDiez.SuspendLayout();
                this.cboFrascoDiez.DataSource = null;
                this.cboFrascoDiez.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione>";
                _itemSeleccion.FRASCO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboFrascoDiez.DisplayMember = BLL.Tables.PRO_FRASCO.ColumnNames.DESCRIPCION;
                this.cboFrascoDiez.ValueMember = BLL.Tables.PRO_FRASCO.ColumnNames.FRASCO_ID;
                this.cboFrascoDiez.DataSource = _ItemsOS;
                this.cboFrascoDiez.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboAditivoUno()
        {
            try
            {
                BLL.Procedures.PRO_GET_PHP_ADITIVO _os = new BLL.Procedures.PRO_GET_PHP_ADITIVO();
                Entities.Procedures.PRO_GET_PHP_ADITIVO _itemSeleccion = new Entities.Procedures.PRO_GET_PHP_ADITIVO();
                List<Entities.Procedures.PRO_GET_PHP_ADITIVO> _ItemsOS = new List<Entities.Procedures.PRO_GET_PHP_ADITIVO>();
                //Limpia el combo
                this.cboAditivoUno.SuspendLayout();
                this.cboAditivoUno.DataSource = null;
                this.cboAditivoUno.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione>";
                _itemSeleccion.art_codgen = "0";
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAditivoUno.DisplayMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_DESCGEN;
                this.cboAditivoUno.ValueMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_CODGEN;
                this.cboAditivoUno.DataSource = _ItemsOS;
                this.cboAditivoUno.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboAditivoDos()
        {
            try
            {
                BLL.Procedures.PRO_GET_PHP_ADITIVO _os = new BLL.Procedures.PRO_GET_PHP_ADITIVO();
                Entities.Procedures.PRO_GET_PHP_ADITIVO _itemSeleccion = new Entities.Procedures.PRO_GET_PHP_ADITIVO();
                List<Entities.Procedures.PRO_GET_PHP_ADITIVO> _ItemsOS = new List<Entities.Procedures.PRO_GET_PHP_ADITIVO>();
                //Limpia el combo
                this.cboAditivoDos.SuspendLayout();
                this.cboAditivoDos.DataSource = null;
                this.cboAditivoDos.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione>";
                _itemSeleccion.art_codgen = "0";
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAditivoDos.DisplayMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_DESCGEN;
                this.cboAditivoDos.ValueMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_CODGEN;
                this.cboAditivoDos.DataSource = _ItemsOS;
                this.cboAditivoDos.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboAditivoTres()
        {
            try
            {
                BLL.Procedures.PRO_GET_PHP_ADITIVO _os = new BLL.Procedures.PRO_GET_PHP_ADITIVO();
                Entities.Procedures.PRO_GET_PHP_ADITIVO _itemSeleccion = new Entities.Procedures.PRO_GET_PHP_ADITIVO();
                List<Entities.Procedures.PRO_GET_PHP_ADITIVO> _ItemsOS = new List<Entities.Procedures.PRO_GET_PHP_ADITIVO>();
                //Limpia el combo
                this.cboAditivoTres.SuspendLayout();
                this.cboAditivoTres.DataSource = null;
                this.cboAditivoTres.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione>";
                _itemSeleccion.art_codgen = "0";
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAditivoTres.DisplayMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_DESCGEN;
                this.cboAditivoTres.ValueMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_CODGEN;
                this.cboAditivoTres.DataSource = _ItemsOS;
                this.cboAditivoTres.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboAditivoCuatro()
        {
            try
            {
                BLL.Procedures.PRO_GET_PHP_ADITIVO _os = new BLL.Procedures.PRO_GET_PHP_ADITIVO();
                Entities.Procedures.PRO_GET_PHP_ADITIVO _itemSeleccion = new Entities.Procedures.PRO_GET_PHP_ADITIVO();
                List<Entities.Procedures.PRO_GET_PHP_ADITIVO> _ItemsOS = new List<Entities.Procedures.PRO_GET_PHP_ADITIVO>();
                //Limpia el combo
                this.cboAditivoCuatro.SuspendLayout();
                this.cboAditivoCuatro.DataSource = null;
                this.cboAditivoCuatro.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione>";
                _itemSeleccion.art_codgen = "0";
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAditivoCuatro.DisplayMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_DESCGEN;
                this.cboAditivoCuatro.ValueMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_CODGEN;
                this.cboAditivoCuatro.DataSource = _ItemsOS;
                this.cboAditivoCuatro.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboAditivoCinco()
        {
            try
            {
                BLL.Procedures.PRO_GET_PHP_ADITIVO _os = new BLL.Procedures.PRO_GET_PHP_ADITIVO();
                Entities.Procedures.PRO_GET_PHP_ADITIVO _itemSeleccion = new Entities.Procedures.PRO_GET_PHP_ADITIVO();
                List<Entities.Procedures.PRO_GET_PHP_ADITIVO> _ItemsOS = new List<Entities.Procedures.PRO_GET_PHP_ADITIVO>();
                //Limpia el combo
                this.cboAditivoCinco.SuspendLayout();
                this.cboAditivoCinco.DataSource = null;
                this.cboAditivoCinco.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione>";
                _itemSeleccion.art_codgen = "0";
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAditivoCinco.DisplayMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_DESCGEN;
                this.cboAditivoCinco.ValueMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_CODGEN;
                this.cboAditivoCinco.DataSource = _ItemsOS;
                this.cboAditivoCinco.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboAditivoSeis()
        {
            try
            {
                BLL.Procedures.PRO_GET_PHP_ADITIVO _os = new BLL.Procedures.PRO_GET_PHP_ADITIVO();
                Entities.Procedures.PRO_GET_PHP_ADITIVO _itemSeleccion = new Entities.Procedures.PRO_GET_PHP_ADITIVO();
                List<Entities.Procedures.PRO_GET_PHP_ADITIVO> _ItemsOS = new List<Entities.Procedures.PRO_GET_PHP_ADITIVO>();
                //Limpia el combo
                this.cboAditivoSeis.SuspendLayout();
                this.cboAditivoSeis.DataSource = null;
                this.cboAditivoSeis.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione>";
                _itemSeleccion.art_codgen = "0";
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAditivoSeis.DisplayMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_DESCGEN;
                this.cboAditivoSeis.ValueMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_CODGEN;
                this.cboAditivoSeis.DataSource = _ItemsOS;
                this.cboAditivoSeis.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboAditivoSiete()
        {
            try
            {
                BLL.Procedures.PRO_GET_PHP_ADITIVO _os = new BLL.Procedures.PRO_GET_PHP_ADITIVO();
                Entities.Procedures.PRO_GET_PHP_ADITIVO _itemSeleccion = new Entities.Procedures.PRO_GET_PHP_ADITIVO();
                List<Entities.Procedures.PRO_GET_PHP_ADITIVO> _ItemsOS = new List<Entities.Procedures.PRO_GET_PHP_ADITIVO>();
                //Limpia el combo
                this.cboAditivoSiete.SuspendLayout();
                this.cboAditivoSiete.DataSource = null;
                this.cboAditivoSiete.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione>";
                _itemSeleccion.art_codgen = "0";
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAditivoSiete.DisplayMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_DESCGEN;
                this.cboAditivoSiete.ValueMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_CODGEN;
                this.cboAditivoSiete.DataSource = _ItemsOS;
                this.cboAditivoSiete.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboAditivoOcho()
        {
            try
            {
                BLL.Procedures.PRO_GET_PHP_ADITIVO _os = new BLL.Procedures.PRO_GET_PHP_ADITIVO();
                Entities.Procedures.PRO_GET_PHP_ADITIVO _itemSeleccion = new Entities.Procedures.PRO_GET_PHP_ADITIVO();
                List<Entities.Procedures.PRO_GET_PHP_ADITIVO> _ItemsOS = new List<Entities.Procedures.PRO_GET_PHP_ADITIVO>();
                //Limpia el combo
                this.cboAditivoOcho.SuspendLayout();
                this.cboAditivoOcho.DataSource = null;
                this.cboAditivoOcho.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione>";
                _itemSeleccion.art_codgen = "0";
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAditivoOcho.DisplayMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_DESCGEN;
                this.cboAditivoOcho.ValueMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_CODGEN;
                this.cboAditivoOcho.DataSource = _ItemsOS;
                this.cboAditivoOcho.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboAditivoNueve()
        {
            try
            {
                BLL.Procedures.PRO_GET_PHP_ADITIVO _os = new BLL.Procedures.PRO_GET_PHP_ADITIVO();
                Entities.Procedures.PRO_GET_PHP_ADITIVO _itemSeleccion = new Entities.Procedures.PRO_GET_PHP_ADITIVO();
                List<Entities.Procedures.PRO_GET_PHP_ADITIVO> _ItemsOS = new List<Entities.Procedures.PRO_GET_PHP_ADITIVO>();
                //Limpia el combo
                this.cboAditivoNueve.SuspendLayout();
                this.cboAditivoNueve.DataSource = null;
                this.cboAditivoNueve.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione>";
                _itemSeleccion.art_codgen = "0";
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAditivoNueve.DisplayMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_DESCGEN;
                this.cboAditivoNueve.ValueMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_CODGEN;
                this.cboAditivoNueve.DataSource = _ItemsOS;
                this.cboAditivoNueve.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboAditivoDiez()
        {
            try
            {
                BLL.Procedures.PRO_GET_PHP_ADITIVO _os = new BLL.Procedures.PRO_GET_PHP_ADITIVO();
                Entities.Procedures.PRO_GET_PHP_ADITIVO _itemSeleccion = new Entities.Procedures.PRO_GET_PHP_ADITIVO();
                List<Entities.Procedures.PRO_GET_PHP_ADITIVO> _ItemsOS = new List<Entities.Procedures.PRO_GET_PHP_ADITIVO>();
                //Limpia el combo
                this.cboAditivoDiez.SuspendLayout();
                this.cboAditivoDiez.DataSource = null;
                this.cboAditivoDiez.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.art_descgen = "<Seleccione>";
                _itemSeleccion.art_codgen = "0";
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboAditivoDiez.DisplayMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_DESCGEN;
                this.cboAditivoDiez.ValueMember = BLL.Procedures.PRO_GET_PHP_ADITIVO.ColumnNames.ART_CODGEN;
                this.cboAditivoDiez.DataSource = _ItemsOS;
                this.cboAditivoDiez.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion 
        // Botoenes
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DialogResult dialogResult = MessageBox.Show("Desea guardar el procedimiento?", "Procedimiento - Php", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            if ( cboGotaHora.SelectedIndex == 0 || cboFrascoUno.SelectedIndex == 0)
                            {
                                MessageBox.Show("Debe seleccionar la cantidad de gotas y al menos un frasco", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnGuardar.Enabled = true;
                                btnSalir.Enabled = true;
                                btnModificar.Enabled = false;
                            }
                            else
                            {
                                Graba_Historial_Suministro_Procedimiento_Php();
                                Graba_Suministro_Procedimiento_Php();
                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Opener.IActualiza();
                                this.Close();
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    if (this.txtSuspenderMotivo.Text != String.Empty || cboGotaHora.SelectedIndex == 0 || cboFrascoUno.SelectedIndex == 0)
                    {
                        #region Suspender
                        DialogResult dialogResult = MessageBox.Show("Seguro que desea supender este procedimiento?", "Procedimiento - Php", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {
                                Graba_Historial_Suministro_Procedimiento_Php();
                                Modifica_Suministro_Procedimiento_Php();
                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ActualizarIndicacion();
                                this.Close();
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                
                                this.Close();
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        #region Modifica
                        DialogResult dialogResult = MessageBox.Show("Desea modificar el procedimiento?", "Procedimiento - Php", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {                                
                                    
                                    btnGuardar.Enabled = true;
                                    btnSalir.Enabled = true;
                                    btnModificar.Enabled = false;
                             
                                    Graba_Historial_Suministro_Procedimiento_Php();
                                    Modifica_Suministro_Procedimiento_Php();
                                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ActualizarIndicacion();
                                    this.Close();                               
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                //do something else
                            }
                        }
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Valida el ingreso de un numero
        private void cboGotaHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrascoDiez();
        }
        private void txtGotaHora_Leave(object sender, EventArgs e)
        {
            //Calculos();
        }
        private void radio100ML_Click(object sender, EventArgs e)
        {
            //Calculos();
        }
        private void radio250ML_Click(object sender, EventArgs e)
        {
            //Calculos();
        }
        private void radio500ML_Click(object sender, EventArgs e)
        {
            //Calculos();
        }
        private void radio1000ML_Click(object sender, EventArgs e)
        {
            //Calculos();
        }
        #region calculos
        private void Calculos()
        {
            #region Validaciones y Calculo
            int gh = 0;
            int mld = 0;
             if (this.cboGotaHora.SelectedValue != null )
             {
            gh = Convert.ToInt32(this.cboGotaHora.SelectedValue) * minutos / gotasPorMl;
                this.txtMlHora.Text = Convert.ToString(gh);
                mld = gh * horas;
                this.txtMlDia.Text = Convert.ToString(mld);

                #region Frascos de 100ML
                if (this.radio100ML.Checked == true)
                {
                    if (mld <= 100)
                    {
                        FrascoUno();
                    }
                    if (mld > 100 && mld <= 200)
                    {
                        FrascoDos();
                    }
                    if (mld > 200 && mld <= 300)
                    {
                        FrascoTres();
                    }
                    if (mld > 300 && mld <= 400)
                    {
                        FrascoCuatro();
                    }
                    if (mld > 400 && mld <= 500)
                    {
                        FrascoCinco();
                    }
                    if (mld > 500 && mld <= 600)
                    {
                        FrascoSeis();
                    }
                    if (mld > 600 && mld <= 700)
                    {
                        FrascoSiete();
                    }
                    if (mld > 700 && mld <= 800)
                    {
                        FrascoOcho();
                    }
                    if (mld > 800 && mld <= 900)
                    {
                        FrascoNueve();
                    }
                    if (mld > 900 && mld <= 1000)
                    {
                        FrascoDiez();
                    }
                    if (mld > 1000)
                    {
                        MayorFrascoDiez();
                    }
                }
                #endregion

                #region Frascos de 250ML
                if (this.radio250ML.Checked == true)
                {
                    if (mld < 250)
                    {
                        FrascoUno();
                    }
                    if (mld > 250 && mld <= 500)
                    {
                        FrascoDos();
                    }
                    if (mld > 500 && mld <= 750)
                    {
                        FrascoTres();
                    }
                    if (mld > 750 && mld <= 1000)
                    {
                        FrascoCuatro();
                    }
                    if (mld > 1000 && mld <= 1250)
                    {
                        FrascoCinco();
                    }
                    if (mld > 1250 && mld <= 1500)
                    {
                        FrascoSeis();
                    }
                    if (mld > 1500 && mld <= 1750)
                    {
                        FrascoSiete();
                    }
                    if (mld > 1750 && mld <= 2000)
                    {
                        FrascoOcho();
                    }
                    if (mld > 2000 && mld <= 2250)
                    {
                        FrascoNueve();
                    }
                    if (mld > 2250 && mld <= 2500)
                    {
                        FrascoDiez();
                    }
                    if (mld > 2500)
                    {
                        MayorFrascoDiez();
                    }
                }
                #endregion

                #region Frascos de 500ML
                if (this.radio500ML.Checked == true)
                {
                    if (mld < 500)
                    {
                        FrascoUno();
                    }
                    if (mld > 500 && mld <= 1000)
                    {
                        FrascoDos();
                    }
                    if (mld > 1000 && mld <= 1500)
                    {
                        FrascoTres();
                    }
                    if (mld > 1500 && mld <= 2000)
                    {
                        FrascoCuatro();
                    }
                    if (mld > 2000 && mld <= 2500)
                    {
                        FrascoCinco();
                    }
                    if (mld > 2500 && mld <= 3000)
                    {
                        FrascoSeis();
                    }
                    if (mld > 3000 && mld <= 3500)
                    {
                        FrascoSiete();
                    }
                    if (mld > 3500 && mld <= 4000)
                    {
                        FrascoOcho();
                    }
                    if (mld > 4000 && mld <= 4500)
                    {
                        FrascoNueve();
                    }
                    if (mld > 4500 && mld <= 5000)
                    {
                        FrascoDiez();
                    }
                    if (mld > 5000)
                    {
                        MayorFrascoDiez();
                    }
                }
                #endregion

                #region Frascos de 1000ML
                if (this.radio1000ML.Checked == true)
                {
                    if (mld < 1000)
                    {
                        FrascoUno();
                    }
                    if (mld > 1000 && mld <= 2000)
                    {
                        FrascoDos();
                    }
                    if (mld > 2000 && mld <= 3000)
                    {
                        FrascoTres();
                    }
                    if (mld > 3000 && mld <= 4000)
                    {
                        FrascoCuatro();
                    }
                    if (mld > 4000 && mld <= 5000)
                    {
                        FrascoCinco();
                    }
                    if (mld > 5000 && mld <= 6000)
                    {
                        FrascoSeis();
                    }
                    if (mld > 6000 && mld <= 7000)
                    {
                        FrascoSiete();
                    }
                    if (mld > 7000 && mld <= 8000)
                    {
                        FrascoOcho();
                    }
                    if (mld > 8000 && mld <= 9000)
                    {
                        FrascoNueve();
                    }
                    if (mld > 9000 && mld <= 10000)
                    {
                        FrascoDiez();
                    }
                    if (mld > 10000)
                    {
                        MayorFrascoDiez();
                    }
                }
                #endregion
            }
            #endregion
        }
        private void FrascoUno()
        {
            this.cboFrascoUno.Enabled = true;
            this.cboAditivoUno.Enabled = true;

            this.cboFrascoDos.Enabled = false;
            this.cboAditivoDos.Enabled = false;
            this.cboFrascoDos.SelectedValue = 0;
            this.cboAditivoDos.SelectedValue = 0;

            this.cboFrascoTres.Enabled = false;
            this.cboAditivoTres.Enabled = false;
            this.cboFrascoTres.SelectedValue = 0;
            this.cboAditivoTres.SelectedValue = 0;

            this.cboFrascoCuatro.Enabled = false;
            this.cboAditivoCuatro.Enabled = false;
            this.cboFrascoCuatro.SelectedValue = 0;
            this.cboAditivoCuatro.SelectedValue = 0;

            this.cboFrascoCinco.Enabled = false;
            this.cboAditivoCinco.Enabled = false;
            this.cboFrascoCinco.SelectedValue = 0;
            this.cboAditivoCinco.SelectedValue = 0;

            this.cboFrascoSeis.Enabled = false;
            this.cboAditivoSeis.Enabled = false;
            this.cboFrascoSeis.SelectedValue = 0;
            this.cboAditivoSeis.SelectedValue = 0;

            this.cboFrascoSiete.Enabled = false;
            this.cboAditivoSiete.Enabled = false;
            this.cboFrascoSiete.SelectedValue = 0;
            this.cboAditivoSiete.SelectedValue = 0;

            this.cboFrascoOcho.Enabled = false;
            this.cboAditivoOcho.Enabled = false;
            this.cboFrascoOcho.SelectedValue = 0;
            this.cboAditivoOcho.SelectedValue = 0;

            this.cboFrascoNueve.Enabled = false;
            this.cboAditivoNueve.Enabled = false;
            this.cboFrascoNueve.SelectedValue = 0;
            this.cboAditivoNueve.SelectedValue = 0;

            this.cboFrascoDiez.Enabled = false;
            this.cboAditivoDiez.Enabled = false;
            this.cboFrascoDiez.SelectedValue = 0;
            this.cboAditivoDiez.SelectedValue = 0;
        }
        private void FrascoDos()
        {
            this.cboFrascoUno.Enabled = true;
            this.cboAditivoUno.Enabled = true;
            this.cboFrascoDos.Enabled = true;
            this.cboAditivoDos.Enabled = true;

            this.cboFrascoTres.Enabled = false;
            this.cboAditivoTres.Enabled = false;
            this.cboFrascoTres.SelectedValue = 0;
            this.cboAditivoTres.SelectedValue = 0;

            this.cboFrascoCuatro.Enabled = false;
            this.cboAditivoCuatro.Enabled = false;
            this.cboFrascoCuatro.SelectedValue = 0;
            this.cboAditivoCuatro.SelectedValue = 0;

            this.cboFrascoCinco.Enabled = false;
            this.cboAditivoCinco.Enabled = false;
            this.cboFrascoCinco.SelectedValue = 0;
            this.cboAditivoCinco.SelectedValue = 0;

            this.cboFrascoSeis.Enabled = false;
            this.cboAditivoSeis.Enabled = false;
            this.cboFrascoSeis.SelectedValue = 0;
            this.cboAditivoSeis.SelectedValue = 0;

            this.cboFrascoSiete.Enabled = false;
            this.cboAditivoSiete.Enabled = false;
            this.cboFrascoSiete.SelectedValue = 0;
            this.cboAditivoSiete.SelectedValue = 0;

            this.cboFrascoOcho.Enabled = false;
            this.cboAditivoOcho.Enabled = false;
            this.cboFrascoOcho.SelectedValue = 0;
            this.cboAditivoOcho.SelectedValue = 0;

            this.cboFrascoNueve.Enabled = false;
            this.cboAditivoNueve.Enabled = false;
            this.cboFrascoNueve.SelectedValue = 0;
            this.cboAditivoNueve.SelectedValue = 0;

            this.cboFrascoDiez.Enabled = false;
            this.cboAditivoDiez.Enabled = false;
            this.cboFrascoDiez.SelectedValue = 0;
            this.cboAditivoDiez.SelectedValue = 0;
        }
        private void FrascoTres()
        {
            this.cboFrascoUno.Enabled = true;
            this.cboAditivoUno.Enabled = true;
            this.cboFrascoDos.Enabled = true;
            this.cboAditivoDos.Enabled = true;
            this.cboFrascoTres.Enabled = true;
            this.cboAditivoTres.Enabled = true;

            this.cboFrascoCuatro.Enabled = false;
            this.cboAditivoCuatro.Enabled = false;
            this.cboFrascoCuatro.SelectedValue = 0;
            this.cboAditivoCuatro.SelectedValue = 0;

            this.cboFrascoCinco.Enabled = false;
            this.cboAditivoCinco.Enabled = false;
            this.cboFrascoCinco.SelectedValue = 0;
            this.cboAditivoCinco.SelectedValue = 0;

            this.cboFrascoSeis.Enabled = false;
            this.cboAditivoSeis.Enabled = false;
            this.cboFrascoSeis.SelectedValue = 0;
            this.cboAditivoSeis.SelectedValue = 0;

            this.cboFrascoSiete.Enabled = false;
            this.cboAditivoSiete.Enabled = false;
            this.cboFrascoSiete.SelectedValue = 0;
            this.cboAditivoSiete.SelectedValue = 0;

            this.cboFrascoOcho.Enabled = false;
            this.cboAditivoOcho.Enabled = false;
            this.cboFrascoOcho.SelectedValue = 0;
            this.cboAditivoOcho.SelectedValue = 0;

            this.cboFrascoNueve.Enabled = false;
            this.cboAditivoNueve.Enabled = false;
            this.cboFrascoNueve.SelectedValue = 0;
            this.cboAditivoNueve.SelectedValue = 0;

            this.cboFrascoDiez.Enabled = false;
            this.cboAditivoDiez.Enabled = false;
            this.cboFrascoDiez.SelectedValue = 0;
            this.cboAditivoDiez.SelectedValue = 0;
        }
        private void FrascoCuatro()
        {
            this.cboFrascoUno.Enabled = true;
            this.cboAditivoUno.Enabled = true;
            this.cboFrascoDos.Enabled = true;
            this.cboAditivoDos.Enabled = true;
            this.cboFrascoTres.Enabled = true;
            this.cboAditivoTres.Enabled = true;
            this.cboFrascoCuatro.Enabled = true;
            this.cboAditivoCuatro.Enabled = true;

            this.cboFrascoCinco.Enabled = false;
            this.cboAditivoCinco.Enabled = false;
            this.cboFrascoCinco.SelectedValue = 0;
            this.cboAditivoCinco.SelectedValue = 0;

            this.cboFrascoSeis.Enabled = false;
            this.cboAditivoSeis.Enabled = false;
            this.cboFrascoSeis.SelectedValue = 0;
            this.cboAditivoSeis.SelectedValue = 0;

            this.cboFrascoSiete.Enabled = false;
            this.cboAditivoSiete.Enabled = false;
            this.cboFrascoSiete.SelectedValue = 0;
            this.cboAditivoSiete.SelectedValue = 0;

            this.cboFrascoOcho.Enabled = false;
            this.cboAditivoOcho.Enabled = false;
            this.cboFrascoOcho.SelectedValue = 0;
            this.cboAditivoOcho.SelectedValue = 0;

            this.cboFrascoNueve.Enabled = false;
            this.cboAditivoNueve.Enabled = false;
            this.cboFrascoNueve.SelectedValue = 0;
            this.cboAditivoNueve.SelectedValue = 0;

            this.cboFrascoDiez.Enabled = false;
            this.cboAditivoDiez.Enabled = false;
            this.cboFrascoDiez.SelectedValue = 0;
            this.cboAditivoDiez.SelectedValue = 0;
        }
        private void FrascoCinco()
        {
            this.cboFrascoUno.Enabled = true;
            this.cboAditivoUno.Enabled = true;
            this.cboFrascoDos.Enabled = true;
            this.cboAditivoDos.Enabled = true;
            this.cboFrascoTres.Enabled = true;
            this.cboAditivoTres.Enabled = true;
            this.cboFrascoCuatro.Enabled = true;
            this.cboAditivoCuatro.Enabled = true;
            this.cboFrascoCinco.Enabled = true;
            this.cboAditivoCinco.Enabled = true;

            this.cboFrascoSeis.Enabled = false;
            this.cboAditivoSeis.Enabled = false;
            this.cboFrascoSeis.SelectedValue = 0;
            this.cboAditivoSeis.SelectedValue = 0;

            this.cboFrascoSiete.Enabled = false;
            this.cboAditivoSiete.Enabled = false;
            this.cboFrascoSiete.SelectedValue = 0;
            this.cboAditivoSiete.SelectedValue = 0;

            this.cboFrascoOcho.Enabled = false;
            this.cboAditivoOcho.Enabled = false;
            this.cboFrascoOcho.SelectedValue = 0;
            this.cboAditivoOcho.SelectedValue = 0;

            this.cboFrascoNueve.Enabled = false;
            this.cboAditivoNueve.Enabled = false;
            this.cboFrascoNueve.SelectedValue = 0;
            this.cboAditivoNueve.SelectedValue = 0;

            this.cboFrascoDiez.Enabled = false;
            this.cboAditivoDiez.Enabled = false;
            this.cboFrascoDiez.SelectedValue = 0;
            this.cboAditivoDiez.SelectedValue = 0;
        }
        private void FrascoSeis()
        {
            this.cboFrascoUno.Enabled = true;
            this.cboAditivoUno.Enabled = true;
            this.cboFrascoDos.Enabled = true;
            this.cboAditivoDos.Enabled = true;
            this.cboFrascoTres.Enabled = true;
            this.cboAditivoTres.Enabled = true;
            this.cboFrascoCuatro.Enabled = true;
            this.cboAditivoCuatro.Enabled = true;
            this.cboFrascoCinco.Enabled = true;
            this.cboAditivoCinco.Enabled = true;
            this.cboFrascoSeis.Enabled = true;
            this.cboAditivoSeis.Enabled = true;

            this.cboFrascoSiete.Enabled = false;
            this.cboAditivoSiete.Enabled = false;
            this.cboFrascoSiete.SelectedValue = 0;
            this.cboAditivoSiete.SelectedValue = 0;

            this.cboFrascoOcho.Enabled = false;
            this.cboAditivoOcho.Enabled = false;
            this.cboFrascoOcho.SelectedValue = 0;
            this.cboAditivoOcho.SelectedValue = 0;

            this.cboFrascoNueve.Enabled = false;
            this.cboAditivoNueve.Enabled = false;
            this.cboFrascoNueve.SelectedValue = 0;
            this.cboAditivoNueve.SelectedValue = 0;

            this.cboFrascoDiez.Enabled = false;
            this.cboAditivoDiez.Enabled = false;
            this.cboFrascoDiez.SelectedValue = 0;
            this.cboAditivoDiez.SelectedValue = 0;
        }
        private void FrascoSiete()
        {
            this.cboFrascoUno.Enabled = true;
            this.cboAditivoUno.Enabled = true;
            this.cboFrascoDos.Enabled = true;
            this.cboAditivoDos.Enabled = true;
            this.cboFrascoTres.Enabled = true;
            this.cboAditivoTres.Enabled = true;
            this.cboFrascoCuatro.Enabled = true;
            this.cboAditivoCuatro.Enabled = true;
            this.cboFrascoCinco.Enabled = true;
            this.cboAditivoCinco.Enabled = true;
            this.cboFrascoSeis.Enabled = true;
            this.cboAditivoSeis.Enabled = true;
            this.cboFrascoSiete.Enabled = true;
            this.cboAditivoSiete.Enabled = true;

            this.cboFrascoOcho.Enabled = false;
            this.cboAditivoOcho.Enabled = false;
            this.cboFrascoOcho.SelectedValue = 0;
            this.cboAditivoOcho.SelectedValue = 0;

            this.cboFrascoNueve.Enabled = false;
            this.cboAditivoNueve.Enabled = false;
            this.cboFrascoNueve.SelectedValue = 0;
            this.cboAditivoNueve.SelectedValue = 0;

            this.cboFrascoDiez.Enabled = false;
            this.cboAditivoDiez.Enabled = false;
            this.cboFrascoDiez.SelectedValue = 0;
            this.cboAditivoDiez.SelectedValue = 0;
        }
        private void FrascoOcho()
        {
            this.cboFrascoUno.Enabled = true;
            this.cboAditivoUno.Enabled = true;
            this.cboFrascoDos.Enabled = true;
            this.cboAditivoDos.Enabled = true;
            this.cboFrascoTres.Enabled = true;
            this.cboAditivoTres.Enabled = true;
            this.cboFrascoCuatro.Enabled = true;
            this.cboAditivoCuatro.Enabled = true;
            this.cboFrascoCinco.Enabled = true;
            this.cboAditivoCinco.Enabled = true;
            this.cboFrascoSeis.Enabled = true;
            this.cboAditivoSeis.Enabled = true;
            this.cboFrascoSiete.Enabled = true;
            this.cboAditivoSiete.Enabled = true;
            this.cboFrascoOcho.Enabled = true;
            this.cboAditivoOcho.Enabled = true;

            this.cboFrascoNueve.Enabled = false;
            this.cboAditivoNueve.Enabled = false;
            this.cboFrascoNueve.SelectedValue = 0;
            this.cboAditivoNueve.SelectedValue = 0;

            this.cboFrascoDiez.Enabled = false;
            this.cboAditivoDiez.Enabled = false;
            this.cboFrascoDiez.SelectedValue = 0;
            this.cboAditivoDiez.SelectedValue = 0;
        }
        private void FrascoNueve()
        {
            this.cboFrascoUno.Enabled = true;
            this.cboAditivoUno.Enabled = true;
            this.cboFrascoDos.Enabled = true;
            this.cboAditivoDos.Enabled = true;
            this.cboFrascoTres.Enabled = true;
            this.cboAditivoTres.Enabled = true;
            this.cboFrascoCuatro.Enabled = true;
            this.cboAditivoCuatro.Enabled = true;
            this.cboFrascoCinco.Enabled = true;
            this.cboAditivoCinco.Enabled = true;
            this.cboFrascoSeis.Enabled = true;
            this.cboAditivoSeis.Enabled = true;
            this.cboFrascoSiete.Enabled = true;
            this.cboAditivoSiete.Enabled = true;
            this.cboFrascoOcho.Enabled = true;
            this.cboAditivoOcho.Enabled = true;
            this.cboFrascoNueve.Enabled = true;
            this.cboAditivoNueve.Enabled = true;

            this.cboFrascoDiez.Enabled = false;
            this.cboAditivoDiez.Enabled = false;
            this.cboFrascoDiez.SelectedValue = 0;
            this.cboAditivoDiez.SelectedValue = 0;
        }
        private void FrascoDiez()
        {
            this.cboFrascoUno.Enabled = true;
            this.cboAditivoUno.Enabled = true;
            this.cboFrascoDos.Enabled = true;
            this.cboAditivoDos.Enabled = true;
            this.cboFrascoTres.Enabled = true;
            this.cboAditivoTres.Enabled = true;
            this.cboFrascoCuatro.Enabled = true;
            this.cboAditivoCuatro.Enabled = true;
            this.cboFrascoCinco.Enabled = true;
            this.cboAditivoCinco.Enabled = true;
            this.cboFrascoSeis.Enabled = true;
            this.cboAditivoSeis.Enabled = true;
            this.cboFrascoSiete.Enabled = true;
            this.cboAditivoSiete.Enabled = true;
            this.cboFrascoOcho.Enabled = true;
            this.cboAditivoOcho.Enabled = true;
            this.cboFrascoNueve.Enabled = true;
            this.cboAditivoNueve.Enabled = true;
            this.cboFrascoDiez.Enabled = true;
            this.cboAditivoDiez.Enabled = true;
        }
        private void MayorFrascoDiez()
        {
            this.cboFrascoUno.Enabled = false;
            this.cboAditivoUno.Enabled = false;
            this.cboFrascoDos.Enabled = false;
            this.cboAditivoDos.Enabled = false;
            this.cboFrascoTres.Enabled = false;
            this.cboAditivoTres.Enabled = false;
            this.cboFrascoCuatro.Enabled = false;
            this.cboAditivoCuatro.Enabled = false;
            this.cboFrascoCinco.Enabled = false;
            this.cboAditivoCinco.Enabled = false;
            this.cboFrascoSeis.Enabled = false;
            this.cboAditivoSeis.Enabled = false;
            this.cboFrascoSiete.Enabled = false;
            this.cboAditivoSiete.Enabled = false;
            this.cboFrascoOcho.Enabled = false;
            this.cboAditivoOcho.Enabled = false;
            this.cboFrascoNueve.Enabled = false;
            this.cboAditivoNueve.Enabled = false;
            this.cboFrascoDiez.Enabled = false;
            this.cboAditivoDiez.Enabled = false;
            MessageBox.Show("La cantidad de Ml por día superra el maximo de de los fracos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #endregion

        #region Metodos
        public void Limpiar()
        {
            try
            {
                this.txtObservacion.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Graba en la tabla PRO_SuministroDeProcedimiento y en la PRO_Php
        public void Graba_Suministro_Procedimiento_Php()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Php")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.PHP_ID = Convert.ToInt32(item.id + 1);
                    }
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id;
                    _itemSuministro.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    // Tabla PRO_Php
                    Entities.Tables.PRO_PHP _itemPhp = new Entities.Tables.PRO_PHP();
                    BLL.Tables.PRO_PHP _php = new BLL.Tables.PRO_PHP();
                    _itemPhp.PACIENTE_ID = paciente_id;
                    _itemPhp.PROCEDIMIENTO_ID = procedimiento_id;

                    if (this.radio100ML.Checked == true) { _itemPhp.ML_100 = true; } else { _itemPhp.ML_100 = false; }
                    if (this.radio250ML.Checked == true) { _itemPhp.ML_250 = true; } else { _itemPhp.ML_250 = false; }
                    if (this.radio500ML.Checked == true) { _itemPhp.ML_500 = true; } else { _itemPhp.ML_500 = false; }
                    if (this.radio1000ML.Checked == true) { _itemPhp.ML_1000 = true; } else { _itemPhp.ML_1000 = false; }
                    if (this.checkBic.Checked == true) { _itemPhp.BIC = true; } else { _itemPhp.BIC = false; }
                    _itemPhp.GOTAHORA_ID = Convert.ToInt32(this.cboGotaHora.SelectedValue); 
                    _itemPhp.MLHORA = Convert.ToInt32(this.txtMlHora.Text);
                    _itemPhp.MLDIA = Convert.ToInt32(this.txtMlDia.Text);
                    _itemPhp.FRASCOUNO_ID = Convert.ToInt32(this.cboFrascoUno.SelectedValue);
                    _itemPhp.ADITIVOUNO_ID = Convert.ToString(this.cboAditivoUno.SelectedValue);
                    _itemPhp.FRASCODOS_ID = Convert.ToInt32(this.cboFrascoDos.SelectedValue);
                    _itemPhp.ADITIVODOS_ID = Convert.ToString(this.cboAditivoDos.SelectedValue);
                    _itemPhp.FRASCOTRES_ID = Convert.ToInt32(this.cboFrascoTres.SelectedValue);
                    _itemPhp.ADITIVOTRES_ID = Convert.ToString(this.cboAditivoTres.SelectedValue);
                    _itemPhp.FRASCOCUATRO_ID = Convert.ToInt32(this.cboFrascoCuatro.SelectedValue);
                    _itemPhp.ADITIVOCUATRO_ID = Convert.ToString(this.cboAditivoCuatro.SelectedValue);
                    _itemPhp.FRASCOCINCO_ID = Convert.ToInt32(this.cboFrascoCinco.SelectedValue);
                    _itemPhp.ADITIVOCINCO_ID = Convert.ToString(this.cboAditivoCinco.SelectedValue);
                    _itemPhp.FRASCOSEIS_ID = Convert.ToInt32(this.cboFrascoSeis.SelectedValue);
                    _itemPhp.ADITIVOSEIS_ID = Convert.ToString(this.cboAditivoSeis.SelectedValue);
                    _itemPhp.FRASCOSIETE_ID = Convert.ToInt32(this.cboFrascoSiete.SelectedValue);
                    _itemPhp.ADITIVOSIETE_ID = Convert.ToString(this.cboAditivoSiete.SelectedValue);
                    _itemPhp.FRASCOOCHO_ID = Convert.ToInt32(this.cboFrascoOcho.SelectedValue);
                    _itemPhp.ADITIVOOCHO_ID = Convert.ToString(this.cboAditivoOcho.SelectedValue);
                    _itemPhp.FRASCONUEVE_ID = Convert.ToInt32(this.cboFrascoNueve.SelectedValue);
                    _itemPhp.ADITIVONUEVE_ID = Convert.ToString(this.cboAditivoNueve.SelectedValue);
                    _itemPhp.FRASCONUEVE_ID = Convert.ToInt32(this.cboFrascoNueve.SelectedValue);
                    _itemPhp.ADITIVONUEVE_ID = Convert.ToString(this.cboAditivoNueve.SelectedValue);
                    _itemPhp.FRASCODIEZ_ID = Convert.ToInt32(this.cboFrascoDiez.SelectedValue);
                    _itemPhp.ADITIVODIEZ_ID = Convert.ToString(this.cboAditivoDiez.SelectedValue);

                    _itemPhp.OBSERVACION = this.txtObservacion.Text;
                    _itemPhp.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemPhp.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemPhp.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaPhp(_itemSuministro, _itemPhp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Graba en la tabla PRO_Historial_SuministroDeProcedimiento y en la PRO_Historial_Php
        public void Graba_Historial_Suministro_Procedimiento_Php()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_HISTORIAL_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_Historial_SuministroDeProcedimiento
                    BLL.Procedures.OBTIENEULTIMOID _obtieneId = new BLL.Procedures.OBTIENEULTIMOID();
                    foreach (Entities.Procedures.OBTIENEULTIMOID item in _obtieneId.ItemList("PRO_Historial_Php")) // Nombre de la tabla en la que buscara
                    {
                        _itemSuministro.PHP_ID = Convert.ToInt32(item.id);
                    }
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id;// Enfermeria de la tabla PRO_Tipo_Procedimiento
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemSuministro.FECHABAJA = System.DateTime.Now;
                        _itemSuministro.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    _itemSuministro.FECHAALTASISTEMA = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    // Tabla PRO_Historial_Php
                    Entities.Tables.PRO_HISTORIAL_PHP _itemPhp = new Entities.Tables.PRO_HISTORIAL_PHP();
                    BLL.Tables.PRO_HISTORIAL_PHP _php = new BLL.Tables.PRO_HISTORIAL_PHP();
                    _itemPhp.PACIENTE_ID = paciente_id;
                    _itemPhp.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemPhp.FECHABAJA = System.DateTime.Now;
                        _itemPhp.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }

                    if (this.radio100ML.Checked == true) { _itemPhp.ML_100 = true; } else { _itemPhp.ML_100 = false; }
                    if (this.radio250ML.Checked == true) { _itemPhp.ML_250 = true; } else { _itemPhp.ML_250 = false; }
                    if (this.radio500ML.Checked == true) { _itemPhp.ML_500 = true; } else { _itemPhp.ML_500 = false; }
                    if (this.radio1000ML.Checked == true) { _itemPhp.ML_1000 = true; } else { _itemPhp.ML_1000 = false; }
                    if (this.checkBic.Checked == true) { _itemPhp.BIC = true; } else { _itemPhp.BIC = false; }
                    _itemPhp.GOTAHORA_ID = Convert.ToInt32(this.cboGotaHora.SelectedValue);
                    _itemPhp.MLHORA = Convert.ToInt32(this.txtMlHora.Text);
                    _itemPhp.MLDIA = Convert.ToInt32(this.txtMlDia.Text);
                    _itemPhp.FRASCOUNO_ID = Convert.ToInt32(this.cboFrascoUno.SelectedValue);
                    _itemPhp.ADITIVOUNO_ID = Convert.ToString(this.cboAditivoUno.SelectedValue);
                    _itemPhp.FRASCODOS_ID = Convert.ToInt32(this.cboFrascoDos.SelectedValue);
                    _itemPhp.ADITIVODOS_ID = Convert.ToString(this.cboAditivoDos.SelectedValue);
                    _itemPhp.FRASCOTRES_ID = Convert.ToInt32(this.cboFrascoTres.SelectedValue);
                    _itemPhp.ADITIVOTRES_ID = Convert.ToString(this.cboAditivoTres.SelectedValue);
                    _itemPhp.FRASCOCUATRO_ID = Convert.ToInt32(this.cboFrascoCuatro.SelectedValue);
                    _itemPhp.ADITIVOCUATRO_ID = Convert.ToString(this.cboAditivoCuatro.SelectedValue);
                    _itemPhp.FRASCOCINCO_ID = Convert.ToInt32(this.cboFrascoCinco.SelectedValue);
                    _itemPhp.ADITIVOCINCO_ID = Convert.ToString(this.cboAditivoCinco.SelectedValue);
                    _itemPhp.FRASCOSEIS_ID = Convert.ToInt32(this.cboFrascoSeis.SelectedValue);
                    _itemPhp.ADITIVOSEIS_ID = Convert.ToString(this.cboAditivoSeis.SelectedValue);
                    _itemPhp.FRASCOSIETE_ID = Convert.ToInt32(this.cboFrascoSiete.SelectedValue);
                    _itemPhp.ADITIVOSIETE_ID = Convert.ToString(this.cboAditivoSiete.SelectedValue);
                    _itemPhp.FRASCOOCHO_ID = Convert.ToInt32(this.cboFrascoOcho.SelectedValue);
                    _itemPhp.ADITIVOOCHO_ID = Convert.ToString(this.cboAditivoOcho.SelectedValue);
                    _itemPhp.FRASCONUEVE_ID = Convert.ToInt32(this.cboFrascoNueve.SelectedValue);
                    _itemPhp.ADITIVONUEVE_ID = Convert.ToString(this.cboAditivoNueve.SelectedValue);
                    _itemPhp.FRASCONUEVE_ID = Convert.ToInt32(this.cboFrascoNueve.SelectedValue);
                    _itemPhp.ADITIVONUEVE_ID = Convert.ToString(this.cboAditivoNueve.SelectedValue);
                    _itemPhp.FRASCODIEZ_ID = Convert.ToInt32(this.cboFrascoDiez.SelectedValue);
                    _itemPhp.ADITIVODIEZ_ID = Convert.ToString(this.cboAditivoDiez.SelectedValue);

                    _itemPhp.OBSERVACION = this.txtObservacion.Text;
                    _itemPhp.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemPhp.FECHAALTASISTEMA = System.DateTime.Now;
                    _suministroDeProcedimiento.AltaHistorialPhp(_itemSuministro, _itemPhp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Modifica_Suministro_Procedimiento_Php()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _itemSuministro = new Entities.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO _suministroDeProcedimiento = new BLL.Tables.PRO_SUMINISTRODEPROCEDIMIENTO();
                    // Tabla PRO_SuministroDeProcedimiento
                    _itemSuministro.PACIENTE_ID = paciente_id;
                    _itemSuministro.PHP_ID = php_id;
                    _itemSuministro.PROCEDIMIENTO_ID = procedimiento_id;
                    _itemSuministro.TIPOPROCEDIMIENTO_ID = tipo_procedimiento_id; // Enfermeria de la tabla PRO_Tipo_Procedimiento
                    _itemSuministro.FECHAMODIFICIACION = System.DateTime.Now;
                    _itemSuministro.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemSuministro.SUMINISTRODEPROCEDIMIENTO_ID = suministro_procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemSuministro.FECHABAJA = System.DateTime.Now;
                        _itemSuministro.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }
                    // Tabla PRO_Php
                    Entities.Tables.PRO_PHP _itemPhp = new Entities.Tables.PRO_PHP();
                    BLL.Tables.PRO_PHP _php = new BLL.Tables.PRO_PHP();
                    _itemPhp.PACIENTE_ID = paciente_id;
                    _itemPhp.PROCEDIMIENTO_ID = procedimiento_id;
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        _itemPhp.FECHABAJA = System.DateTime.Now;
                        _itemPhp.MOTIVOBAJA = this.txtSuspenderMotivo.Text;
                    }

                    if (this.radio100ML.Checked == true) { _itemPhp.ML_100 = true; } else { _itemPhp.ML_100 = false; }
                    if (this.radio250ML.Checked == true) { _itemPhp.ML_250 = true; } else { _itemPhp.ML_250 = false; }
                    if (this.radio500ML.Checked == true) { _itemPhp.ML_500 = true; } else { _itemPhp.ML_500 = false; }
                    if (this.radio1000ML.Checked == true) { _itemPhp.ML_1000 = true; } else { _itemPhp.ML_1000 = false; }
                    if (this.checkBic.Checked == true) { _itemPhp.BIC = true; } else { _itemPhp.BIC = false; }
                    _itemPhp.GOTAHORA_ID = Convert.ToInt32(this.cboGotaHora.SelectedValue);
                    _itemPhp.MLHORA = Convert.ToInt32(this.txtMlHora.Text);
                    _itemPhp.MLDIA = Convert.ToInt32(this.txtMlDia.Text);
                    _itemPhp.FRASCOUNO_ID = Convert.ToInt32(this.cboFrascoUno.SelectedValue);
                    _itemPhp.ADITIVOUNO_ID = Convert.ToString(this.cboAditivoUno.SelectedValue);
                    _itemPhp.FRASCODOS_ID = Convert.ToInt32(this.cboFrascoDos.SelectedValue);
                    _itemPhp.ADITIVODOS_ID = Convert.ToString(this.cboAditivoDos.SelectedValue);
                    _itemPhp.FRASCOTRES_ID = Convert.ToInt32(this.cboFrascoTres.SelectedValue);
                    _itemPhp.ADITIVOTRES_ID = Convert.ToString(this.cboAditivoTres.SelectedValue);
                    _itemPhp.FRASCOCUATRO_ID = Convert.ToInt32(this.cboFrascoCuatro.SelectedValue);
                    _itemPhp.ADITIVOCUATRO_ID = Convert.ToString(this.cboAditivoCuatro.SelectedValue);
                    _itemPhp.FRASCOCINCO_ID = Convert.ToInt32(this.cboFrascoCinco.SelectedValue);
                    _itemPhp.ADITIVOCINCO_ID = Convert.ToString(this.cboAditivoCinco.SelectedValue);
                    _itemPhp.FRASCOSEIS_ID = Convert.ToInt32(this.cboFrascoSeis.SelectedValue);
                    _itemPhp.ADITIVOSEIS_ID = Convert.ToString(this.cboAditivoSeis.SelectedValue);
                    _itemPhp.FRASCOSIETE_ID = Convert.ToInt32(this.cboFrascoSiete.SelectedValue);
                    _itemPhp.ADITIVOSIETE_ID = Convert.ToString(this.cboAditivoSiete.SelectedValue);
                    _itemPhp.FRASCOOCHO_ID = Convert.ToInt32(this.cboFrascoOcho.SelectedValue);
                    _itemPhp.ADITIVOOCHO_ID = Convert.ToString(this.cboAditivoOcho.SelectedValue);
                    _itemPhp.FRASCONUEVE_ID = Convert.ToInt32(this.cboFrascoNueve.SelectedValue);
                    _itemPhp.ADITIVONUEVE_ID = Convert.ToString(this.cboAditivoNueve.SelectedValue);
                    _itemPhp.FRASCONUEVE_ID = Convert.ToInt32(this.cboFrascoNueve.SelectedValue);
                    _itemPhp.ADITIVONUEVE_ID = Convert.ToString(this.cboAditivoNueve.SelectedValue);
                    _itemPhp.FRASCODIEZ_ID = Convert.ToInt32(this.cboFrascoDiez.SelectedValue);
                    _itemPhp.ADITIVODIEZ_ID = Convert.ToString(this.cboAditivoDiez.SelectedValue);

                    _itemPhp.OBSERVACION = this.txtObservacion.Text;
                    _itemPhp.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemPhp.PHP_ID = _itemSuministro.PHP_ID;
                    _itemPhp.FECHAMODIFICACION = System.DateTime.Now;
                    _suministroDeProcedimiento.ModificaPhp(_itemSuministro, _itemPhp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Recupera Cuidado Oral
        private void Get_Php(int php_id)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");

                BLL.Procedures.PRO_GET_PHP _itemPhp = new BLL.Procedures.PRO_GET_PHP();
                foreach (Entities.Procedures.PRO_GET_PHP item in _itemPhp.ItemList(php_id))
                {
                    if (item.ml_100 == true) { this.radio100ML.Checked = true; } else { this.radio100ML.Checked = false; }
                    if (item.ml_250 == true) { this.radio250ML.Checked = true; } else { this.radio250ML.Checked = false; }
                    if (item.ml_500 == true) { this.radio500ML.Checked = true; } else { this.radio500ML.Checked = false; }
                    if (item.ml_1000 == true) { this.radio1000ML.Checked = true; } else { this.radio1000ML.Checked = false; }
                    if (item.bic == true) { this.checkBic.Checked = true; } else { this.checkBic.Checked = false; }
                    this.cboGotaHora.SelectedValue = item.gotahora_id;
                    this.txtMlHora.Text = Convert.ToString(item.mlhora);
                    this.txtMlDia.Text = Convert.ToString(item.mldia);
                    this.cboFrascoUno.SelectedValue = item.frascouno_id;
                    this.cboAditivoUno.SelectedValue = item.aditivouno_id;
                    this.cboFrascoDos.SelectedValue = item.frascodos_id;
                    this.cboAditivoDos.SelectedValue = item.aditivodos_id;
                    this.cboFrascoTres.SelectedValue = item.frascotres_id;
                    this.cboAditivoTres.SelectedValue = item.aditivotres_id;
                    this.cboFrascoCuatro.SelectedValue = item.frascocuatro_id;
                    this.cboAditivoCuatro.SelectedValue = item.aditivocuatro_id;
                    this.cboFrascoCinco.SelectedValue = item.frascocinco_id;
                    this.cboAditivoCinco.SelectedValue = item.aditivocinco_id;
                    this.cboFrascoSeis.SelectedValue = item.frascoseis_id;
                    this.cboAditivoSeis.SelectedValue = item.aditivoseis_id;
                    this.cboFrascoSiete.SelectedValue = item.frascosiete_id;
                    this.cboAditivoSiete.SelectedValue = item.aditivosiete_id;
                    this.cboFrascoOcho.SelectedValue = item.frascoocho_id;
                    this.cboAditivoOcho.SelectedValue = item.aditivoocho_id;
                    this.cboFrascoNueve.SelectedValue = item.frasconueve_id;
                    this.cboAditivoNueve.SelectedValue = item.aditivonueve_id;
                    this.cboFrascoDiez.SelectedValue = item.frascodiez_id;
                    this.cboAditivoDiez.SelectedValue = item.aditivodiez_id;
                    this.txtObservacion.Text = item.observacion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
