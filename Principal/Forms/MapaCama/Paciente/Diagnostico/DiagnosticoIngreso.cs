using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Forms.MapaCama.Paciente.Diagnostico
{
    public partial class DiagnosticoIngreso : MetroForm
    {
        #region Variables        
        private int _idPaciente;
        private string rubro_id;
        private string subRubro_id;
        private string item_id;
        public int IdPaciente
        {
            get
            {
                return _idPaciente;
            }

            set
            {
                this._idPaciente = value;
            }
        }   
       
        #endregion

        #region Inicio
        public DiagnosticoIngreso()
        {
            InitializeComponent();
        }
        private void DiagnosticoIngreso_Load(object sender, EventArgs e)
        {
            try
            {
                if (_idPaciente == 0)
                {
                    #region DIAGNOSTICO INGRESO
                    // Principal
                    CargarCboDiagnosticoPrincipalCapituloIngreso();
                    CargarCboDiagnosticoPrincipalRubroIngreso(rubro_id);
                    CargarCboDiagnosticoPrincipalSubRubroIngreso(subRubro_id);
                    CargarCboDiagnosticoPrincipalItemIngreso(item_id);
                    this.cboDiagnosticoPrincipalRubroIngreso.Enabled = false;
                    this.cboDiagnosticoPrincipalSubRubroIngreso.Enabled = false;
                    this.cboDiagnosticoPrincipalItemIngreso.Enabled = false;
                    // Secundario 1
                    CargarCboDiagnosticoSecundarioCapituloIngreso();
                    CargarCboDiagnosticoSecundarioRubroIngreso(rubro_id);
                    CargarCboDiagnosticoSecundarioSubRubroIngreso(subRubro_id);
                    CargarCboDiagnosticoSecundarioItemIngreso(item_id);
                    this.cboDiagnosticoSecundarioRubroIngreso.Enabled = false;
                    this.cboDiagnosticoSecundarioSubRubroIngreso.Enabled = false;
                    this.cboDiagnosticoSecundarioItemIngreso.Enabled = false;
                    // Secundario 2
                    CargarCboDiagnosticoTerciarioCapituloIngreso();
                    CargarCboDiagnosticoTerciarioRubroIngreso(rubro_id);
                    CargarCboDiagnosticoTerciarioSubRubroIngreso(subRubro_id);
                    CargarCboDiagnosticoTerciarioItemIngreso(item_id);
                    this.cboDiagnosticoTerciarioRubroIngreso.Enabled = false;
                    this.cboDiagnosticoTerciarioSubRubroIngreso.Enabled = false;
                    this.cboDiagnosticoTerciarioItemIngreso.Enabled = false;
                    #endregion
                    this.btnModificar.Enabled = false;
                }
                else
                {
                    Get_Diagnostico(_idPaciente);
                    this.btnModificar.Enabled = true;
                    this.btnGuardar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        #region DIAGNOSTICO INGRESO
        // Principal
        private void CargarCboDiagnosticoPrincipalCapituloIngreso()
        {
            try 
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO _capitulo = new BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO> _ItemsCapitulo = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO>();
                //Limpia el combo
                this.cboDiagnosticoPrincipalCapituloIngreso.SuspendLayout();
                this.cboDiagnosticoPrincipalCapituloIngreso.DataSource = null;
                this.cboDiagnosticoPrincipalCapituloIngreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.capitulo = "0";
                _ItemsCapitulo = _capitulo.ItemList();
                _ItemsCapitulo.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoPrincipalCapituloIngreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoPrincipalCapituloIngreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO.ColumnNames.GRUPO;
                this.cboDiagnosticoPrincipalCapituloIngreso.DataSource = _ItemsCapitulo;
                this.cboDiagnosticoPrincipalCapituloIngreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoPrincipalRubroIngreso(string rubro_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO _rubro = new BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO> _ItemsRubro = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO>();
                //Limpia el combo
                this.cboDiagnosticoPrincipalRubroIngreso.SuspendLayout();
                this.cboDiagnosticoPrincipalRubroIngreso.DataSource = null;
                this.cboDiagnosticoPrincipalRubroIngreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.capitulo = "0";
                _ItemsRubro = _rubro.ItemList(rubro_id);
                _ItemsRubro.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoPrincipalRubroIngreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoPrincipalRubroIngreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO.ColumnNames.CAPITULO;
                this.cboDiagnosticoPrincipalRubroIngreso.DataSource = _ItemsRubro;
                this.cboDiagnosticoPrincipalRubroIngreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoPrincipalSubRubroIngreso(string subRubro_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO _subRubro = new BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO> _ItemsSubRubro = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO>();
                //Limpia el combo
                this.cboDiagnosticoPrincipalSubRubroIngreso.SuspendLayout();
                this.cboDiagnosticoPrincipalSubRubroIngreso.DataSource = null;
                this.cboDiagnosticoPrincipalSubRubroIngreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.grupo = "0";
                _ItemsSubRubro = _subRubro.ItemList(subRubro_id);
                _ItemsSubRubro.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoPrincipalSubRubroIngreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoPrincipalSubRubroIngreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO.ColumnNames.CAPITULO;
                this.cboDiagnosticoPrincipalSubRubroIngreso.DataSource = _ItemsSubRubro;
                this.cboDiagnosticoPrincipalSubRubroIngreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoPrincipalItemIngreso(string capitulo_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM _item = new BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM();
                Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM> _ItemsItem = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM>();
                //Limpia el combo
                this.cboDiagnosticoPrincipalItemIngreso.SuspendLayout();
                this.cboDiagnosticoPrincipalItemIngreso.DataSource = null;
                this.cboDiagnosticoPrincipalItemIngreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.grupo = "0";
                _ItemsItem = _item.ItemList(capitulo_id);
                _ItemsItem.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoPrincipalItemIngreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoPrincipalItemIngreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM.ColumnNames.CAPITULO;
                this.cboDiagnosticoPrincipalItemIngreso.DataSource = _ItemsItem;
                this.cboDiagnosticoPrincipalItemIngreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Secundario
        private void CargarCboDiagnosticoSecundarioCapituloIngreso()
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO _capitulo = new BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO> _ItemsCapitulo = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO>();
                //Limpia el combo
                this.cboDiagnosticoSecundarioCapituloIngreso.SuspendLayout();
                this.cboDiagnosticoSecundarioCapituloIngreso.DataSource = null;
                this.cboDiagnosticoSecundarioCapituloIngreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.capitulo = "0";
                _ItemsCapitulo = _capitulo.ItemList();
                _ItemsCapitulo.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoSecundarioCapituloIngreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoSecundarioCapituloIngreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO.ColumnNames.GRUPO;
                this.cboDiagnosticoSecundarioCapituloIngreso.DataSource = _ItemsCapitulo;
                this.cboDiagnosticoSecundarioCapituloIngreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoSecundarioRubroIngreso(string rubro_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO _rubro = new BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO> _ItemsRubro = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO>();
                //Limpia el combo
                this.cboDiagnosticoSecundarioRubroIngreso.SuspendLayout();
                this.cboDiagnosticoSecundarioRubroIngreso.DataSource = null;
                this.cboDiagnosticoSecundarioRubroIngreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.capitulo = "0";
                _ItemsRubro = _rubro.ItemList(rubro_id);
                _ItemsRubro.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoSecundarioRubroIngreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoSecundarioRubroIngreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO.ColumnNames.CAPITULO;
                this.cboDiagnosticoSecundarioRubroIngreso.DataSource = _ItemsRubro;
                this.cboDiagnosticoSecundarioRubroIngreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoSecundarioSubRubroIngreso(string subRubro_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO _subRubro = new BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO> _ItemsSubRubro = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO>();
                //Limpia el combo
                this.cboDiagnosticoSecundarioSubRubroIngreso.SuspendLayout();
                this.cboDiagnosticoSecundarioSubRubroIngreso.DataSource = null;
                this.cboDiagnosticoSecundarioSubRubroIngreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.grupo = "0";
                _ItemsSubRubro = _subRubro.ItemList(subRubro_id);
                _ItemsSubRubro.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoSecundarioSubRubroIngreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoSecundarioSubRubroIngreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO.ColumnNames.CAPITULO;
                this.cboDiagnosticoSecundarioSubRubroIngreso.DataSource = _ItemsSubRubro;
                this.cboDiagnosticoSecundarioSubRubroIngreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoSecundarioItemIngreso(string capitulo_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM _item = new BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM();
                Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM> _ItemsItem = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM>();
                //Limpia el combo
                this.cboDiagnosticoSecundarioItemIngreso.SuspendLayout();
                this.cboDiagnosticoSecundarioItemIngreso.DataSource = null;
                this.cboDiagnosticoSecundarioItemIngreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.grupo = "0";
                _ItemsItem = _item.ItemList(capitulo_id);
                _ItemsItem.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoSecundarioItemIngreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoSecundarioItemIngreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM.ColumnNames.CAPITULO;
                this.cboDiagnosticoSecundarioItemIngreso.DataSource = _ItemsItem;
                this.cboDiagnosticoSecundarioItemIngreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Terciario
        private void CargarCboDiagnosticoTerciarioCapituloIngreso()
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO _capitulo = new BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO> _ItemsCapitulo = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO>();
                //Limpia el combo
                this.cboDiagnosticoTerciarioCapituloIngreso.SuspendLayout();
                this.cboDiagnosticoTerciarioCapituloIngreso.DataSource = null;
                this.cboDiagnosticoTerciarioCapituloIngreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.capitulo = "0";
                _ItemsCapitulo = _capitulo.ItemList();
                _ItemsCapitulo.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoTerciarioCapituloIngreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoTerciarioCapituloIngreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO.ColumnNames.GRUPO;
                this.cboDiagnosticoTerciarioCapituloIngreso.DataSource = _ItemsCapitulo;
                this.cboDiagnosticoTerciarioCapituloIngreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoTerciarioRubroIngreso(string rubro_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO _rubro = new BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO> _ItemsRubro = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO>();
                //Limpia el combo
                this.cboDiagnosticoTerciarioRubroIngreso.SuspendLayout();
                this.cboDiagnosticoTerciarioRubroIngreso.DataSource = null;
                this.cboDiagnosticoTerciarioRubroIngreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.capitulo = "0";
                _ItemsRubro = _rubro.ItemList(rubro_id);
                _ItemsRubro.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoTerciarioRubroIngreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoTerciarioRubroIngreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO.ColumnNames.CAPITULO;
                this.cboDiagnosticoTerciarioRubroIngreso.DataSource = _ItemsRubro;
                this.cboDiagnosticoTerciarioRubroIngreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoTerciarioSubRubroIngreso(string subRubro_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO _subRubro = new BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO> _ItemsSubRubro = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO>();
                //Limpia el combo
                this.cboDiagnosticoTerciarioSubRubroIngreso.SuspendLayout();
                this.cboDiagnosticoTerciarioSubRubroIngreso.DataSource = null;
                this.cboDiagnosticoTerciarioSubRubroIngreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.grupo = "0";
                _ItemsSubRubro = _subRubro.ItemList(subRubro_id);
                _ItemsSubRubro.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoTerciarioSubRubroIngreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoTerciarioSubRubroIngreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO.ColumnNames.CAPITULO;
                this.cboDiagnosticoTerciarioSubRubroIngreso.DataSource = _ItemsSubRubro;
                this.cboDiagnosticoTerciarioSubRubroIngreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoTerciarioItemIngreso(string capitulo_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM _item = new BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM();
                Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM> _ItemsItem = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM>();
                //Limpia el combo
                this.cboDiagnosticoTerciarioItemIngreso.SuspendLayout();
                this.cboDiagnosticoTerciarioItemIngreso.DataSource = null;
                this.cboDiagnosticoTerciarioItemIngreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.grupo = "0";
                _ItemsItem = _item.ItemList(capitulo_id);
                _ItemsItem.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoTerciarioItemIngreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoTerciarioItemIngreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM.ColumnNames.CAPITULO;
                this.cboDiagnosticoTerciarioItemIngreso.DataSource = _ItemsItem;
                this.cboDiagnosticoTerciarioItemIngreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #endregion

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Graba_Diagnostico();
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
                Modifica_Diagnostico();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Diagnostico Ingreso
        // Principal
        private void cboDiagnosticoPrincipalCapituloIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nieto_id;           
            nieto_id = Convert.ToString(this.cboDiagnosticoPrincipalCapituloIngreso.SelectedIndex);
            if (nieto_id != "0")
            {
                CargarCboDiagnosticoPrincipalRubroIngreso(nieto_id);
                this.cboDiagnosticoPrincipalRubroIngreso.Enabled = true;
                this.cboDiagnosticoPrincipalSubRubroIngreso.Enabled = false;
                this.cboDiagnosticoPrincipalItemIngreso.Enabled = false;
            }
            else
            {
                this.cboDiagnosticoPrincipalRubroIngreso.Enabled = false;
                this.cboDiagnosticoPrincipalSubRubroIngreso.Enabled = false;
                this.cboDiagnosticoPrincipalItemIngreso.Enabled = false;
            }
        }
        private void cboDiagnosticoPrincipalRubroIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nieto_id;            
            nieto_id = Convert.ToString(this.cboDiagnosticoPrincipalRubroIngreso.SelectedValue);
            if (nieto_id != "0")
            {
                CargarCboDiagnosticoPrincipalSubRubroIngreso(nieto_id);
                this.cboDiagnosticoPrincipalRubroIngreso.Enabled = true;
                this.cboDiagnosticoPrincipalSubRubroIngreso.Enabled = true;
                this.cboDiagnosticoPrincipalItemIngreso.Enabled = false;
            }
            else
            {
                this.cboDiagnosticoPrincipalRubroIngreso.Enabled = false;
                this.cboDiagnosticoPrincipalSubRubroIngreso.Enabled = false;
                this.cboDiagnosticoPrincipalItemIngreso.Enabled = false;
            }
        }
        private void cboDiagnosticoPrincipalSubRubroIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string capitulo_id;
            capitulo_id = Convert.ToString(this.cboDiagnosticoPrincipalSubRubroIngreso.SelectedValue);
            if (capitulo_id != "0")
            {
                CargarCboDiagnosticoPrincipalItemIngreso(capitulo_id);
                this.cboDiagnosticoPrincipalItemIngreso.Enabled = true;
            }
            else
            {
                this.cboDiagnosticoPrincipalRubroIngreso.Enabled = false;
                this.cboDiagnosticoPrincipalSubRubroIngreso.Enabled = false;
                this.cboDiagnosticoPrincipalItemIngreso.Enabled = false;
            }
        }
        // Secundario
        private void cboDiagnosticoSecundarioCapituloIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nieto_id;
            nieto_id = Convert.ToString(this.cboDiagnosticoSecundarioCapituloIngreso.SelectedIndex);
            if (nieto_id != "0")
            {
                CargarCboDiagnosticoSecundarioRubroIngreso(nieto_id);
                this.cboDiagnosticoSecundarioRubroIngreso.Enabled = true;
                this.cboDiagnosticoSecundarioSubRubroIngreso.Enabled = false;
                this.cboDiagnosticoSecundarioItemIngreso.Enabled = false;
            }
            else
            {
                this.cboDiagnosticoSecundarioRubroIngreso.Enabled = false;
                this.cboDiagnosticoSecundarioSubRubroIngreso.Enabled = false;
                this.cboDiagnosticoSecundarioItemIngreso.Enabled = false;
            }
        }
        private void cboDiagnosticoSecundarioRubroIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nieto_id;
            nieto_id = Convert.ToString(this.cboDiagnosticoSecundarioRubroIngreso.SelectedValue);
            if (nieto_id != "0")
            {
                CargarCboDiagnosticoSecundarioSubRubroIngreso(nieto_id);
                this.cboDiagnosticoSecundarioRubroIngreso.Enabled = true;
                this.cboDiagnosticoSecundarioSubRubroIngreso.Enabled = true;
                this.cboDiagnosticoSecundarioItemIngreso.Enabled = false;
            }
            else
            {
                this.cboDiagnosticoSecundarioRubroIngreso.Enabled = false;
                this.cboDiagnosticoSecundarioSubRubroIngreso.Enabled = false;
                this.cboDiagnosticoSecundarioItemIngreso.Enabled = false;
            }
        }
        private void cboDiagnosticoSecundarioSubRubroIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string capitulo_id;
            capitulo_id = Convert.ToString(this.cboDiagnosticoSecundarioSubRubroIngreso.SelectedValue);
            if (capitulo_id != "0")
            {
                CargarCboDiagnosticoSecundarioItemIngreso(capitulo_id);
                this.cboDiagnosticoSecundarioItemIngreso.Enabled = true;
            }
            else
            {
                this.cboDiagnosticoSecundarioRubroIngreso.Enabled = false;
                this.cboDiagnosticoSecundarioSubRubroIngreso.Enabled = false;
                this.cboDiagnosticoSecundarioItemIngreso.Enabled = false;
            }
        }
        // Terciario
        private void cboDiagnosticoTerciarioCapituloIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nieto_id;
            nieto_id = Convert.ToString(this.cboDiagnosticoTerciarioCapituloIngreso.SelectedIndex);
            if (nieto_id != "0")
            {
                CargarCboDiagnosticoTerciarioRubroIngreso(nieto_id);
                this.cboDiagnosticoTerciarioRubroIngreso.Enabled = true;
                this.cboDiagnosticoTerciarioSubRubroIngreso.Enabled = false;
                this.cboDiagnosticoTerciarioItemIngreso.Enabled = false;
            }
            else
            {
                this.cboDiagnosticoTerciarioRubroIngreso.Enabled = false;
                this.cboDiagnosticoTerciarioSubRubroIngreso.Enabled = false;
                this.cboDiagnosticoTerciarioItemIngreso.Enabled = false;
            }
        }
        private void cboDiagnosticoTerciarioRubroIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nieto_id;
            nieto_id = Convert.ToString(this.cboDiagnosticoTerciarioRubroIngreso.SelectedValue);
            if (nieto_id != "0")
            {
                CargarCboDiagnosticoTerciarioSubRubroIngreso(nieto_id);
                this.cboDiagnosticoTerciarioRubroIngreso.Enabled = true;
                this.cboDiagnosticoTerciarioSubRubroIngreso.Enabled = true;
                this.cboDiagnosticoTerciarioItemIngreso.Enabled = false;
            }
            else
            {
                this.cboDiagnosticoTerciarioRubroIngreso.Enabled = false;
                this.cboDiagnosticoTerciarioSubRubroIngreso.Enabled = false;
                this.cboDiagnosticoTerciarioItemIngreso.Enabled = false;
            }
        }
        private void cboDiagnosticoTerciarioSubRubroIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string capitulo_id;
            capitulo_id = Convert.ToString(this.cboDiagnosticoTerciarioSubRubroIngreso.SelectedValue);
            if (capitulo_id != "0")
            {
                CargarCboDiagnosticoTerciarioItemIngreso(capitulo_id);
                this.cboDiagnosticoTerciarioItemIngreso.Enabled = true;
            }
            else
            {
                this.cboDiagnosticoTerciarioRubroIngreso.Enabled = false;
                this.cboDiagnosticoTerciarioSubRubroIngreso.Enabled = false;
                this.cboDiagnosticoTerciarioItemIngreso.Enabled = false;
            }
        }
        #endregion

        #endregion

        #region Metodos
        private void Limpiar()
        {
            try
            {
                this.cboDiagnosticoPrincipalCapituloIngreso.SelectedIndex = 0;
                this.cboDiagnosticoPrincipalRubroIngreso.SelectedIndex = 0;
                this.cboDiagnosticoPrincipalSubRubroIngreso.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Graba_Diagnostico()
        {
            try
            {
                {
                    Entities.Tables.MED_DIAGNOSTICO_PACIENTE _item = new Entities.Tables.MED_DIAGNOSTICO_PACIENTE();
                    BLL.Tables.MED_DIAGNOSTICO_PACIENTE _diagnosticoPaciente = new BLL.Tables.MED_DIAGNOSTICO_PACIENTE();
                    CultureInfo culture = new CultureInfo("en-US");
                    _item.FECHAALTA = System.DateTime.Now;
                    _item.PACIENTE_ID = IdPaciente;
                    // INGRESO
                    _item.PRINCIPALCAPITULOINGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalCapituloIngreso.SelectedValue);
                    _item.PRINCIPALRUBROINGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalRubroIngreso.SelectedValue);
                    _item.PRINCIPALSUBRUBROINGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalSubRubroIngreso.SelectedValue);
                    _item.PRINCIPALITEMINGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalItemIngreso.SelectedValue);
                    _item.SECUNDARIOCAPITULOINGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioCapituloIngreso.SelectedValue);
                    _item.SECUNDARIORUBROINGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioRubroIngreso.SelectedValue);
                    _item.SECUNDARIOSUBRUBROINGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioSubRubroIngreso.SelectedValue);
                    _item.SECUNDARIOITEMINGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioItemIngreso.SelectedValue);
                    _item.TERCIARIOCAPITULOINGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioCapituloIngreso.SelectedValue);
                    _item.TERCIARIORUBROINGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioRubroIngreso.SelectedValue);
                    _item.TERCIARIOSUBRUBROINGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioSubRubroIngreso.SelectedValue);
                    _item.TERCIARIOITEMINGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioItemIngreso.SelectedValue);
                    _item.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _diagnosticoPaciente.Add(_item);                    
                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Modifica_Diagnostico()
        {
            try
            {         
               Entities.Tables.MED_DIAGNOSTICO_PACIENTE _item = new Entities.Tables.MED_DIAGNOSTICO_PACIENTE();
               BLL.Tables.MED_DIAGNOSTICO_PACIENTE _diagnostico = new BLL.Tables.MED_DIAGNOSTICO_PACIENTE();
               CultureInfo culture = new CultureInfo("en-US");
                _item.DIAGNOSTICO_ID = Convert.ToInt32(this.lblDiagnostico_id.Text);
                _item.FECHAALTA = System.DateTime.Now;
                _item.FECHAMODIFICACION = System.DateTime.Now;
                _item.PACIENTE_ID = IdPaciente;
                // INGRESO
                _item.PRINCIPALCAPITULOINGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalCapituloIngreso.SelectedValue);
                _item.PRINCIPALRUBROINGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalRubroIngreso.SelectedValue);
                _item.PRINCIPALSUBRUBROINGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalSubRubroIngreso.SelectedValue);
                _item.PRINCIPALITEMINGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalItemIngreso.SelectedValue);
                _item.SECUNDARIOCAPITULOINGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioCapituloIngreso.SelectedValue);
                _item.SECUNDARIORUBROINGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioRubroIngreso.SelectedValue);
                _item.SECUNDARIOSUBRUBROINGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioSubRubroIngreso.SelectedValue);
                _item.SECUNDARIOITEMINGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioItemIngreso.SelectedValue);
                _item.TERCIARIOCAPITULOINGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioCapituloIngreso.SelectedValue);
                _item.TERCIARIORUBROINGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioRubroIngreso.SelectedValue);
                _item.TERCIARIOSUBRUBROINGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioSubRubroIngreso.SelectedValue);
                _item.TERCIARIOITEMINGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioItemIngreso.SelectedValue);
                _item.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                _diagnostico.Update(_item);
                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.Close();
            }           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Get_Diagnostico(int paciente_id)
        {
            #region DIAGNOSTICO INGRESO
            // Principal
            CargarCboDiagnosticoPrincipalCapituloIngreso();
            CargarCboDiagnosticoPrincipalRubroIngreso(rubro_id);
            CargarCboDiagnosticoPrincipalSubRubroIngreso(subRubro_id);
            CargarCboDiagnosticoPrincipalItemIngreso(item_id);
            // Secundario 1
            CargarCboDiagnosticoSecundarioCapituloIngreso();
            CargarCboDiagnosticoSecundarioRubroIngreso(rubro_id);
            CargarCboDiagnosticoSecundarioSubRubroIngreso(subRubro_id);
            CargarCboDiagnosticoSecundarioItemIngreso(item_id);
            // Secundario 2
            CargarCboDiagnosticoTerciarioCapituloIngreso();
            CargarCboDiagnosticoTerciarioRubroIngreso(rubro_id);
            CargarCboDiagnosticoTerciarioSubRubroIngreso(subRubro_id);
            CargarCboDiagnosticoTerciarioItemIngreso(item_id);
            #endregion
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.MED_GET_DIAGNOSTICO_PACIENTE _obtieneDiagnostico = new BLL.Procedures.MED_GET_DIAGNOSTICO_PACIENTE();
                foreach (Entities.Procedures.MED_GET_DIAGNOSTICO_PACIENTE item in _obtieneDiagnostico.ItemList(paciente_id))
                {
                    // Ingreso
                    this.lblDiagnostico_id.Text = Convert.ToString(item.diagnostico_id);
                    this.cboDiagnosticoPrincipalCapituloIngreso.SelectedValue = Convert.ToString(item.principalcapituloingreso_id);
                    this.cboDiagnosticoPrincipalRubroIngreso.SelectedValue = Convert.ToString(item.principalrubroingreso_id);
                    this.cboDiagnosticoPrincipalSubRubroIngreso.SelectedValue = Convert.ToString(item.principalsubrubroingreso_id);
                    this.cboDiagnosticoPrincipalItemIngreso.SelectedValue = Convert.ToString(item.principalitemingreso_id);
                    this.cboDiagnosticoSecundarioCapituloIngreso.SelectedValue = Convert.ToString(item.secundariocapituloingreso_id);
                    this.cboDiagnosticoSecundarioRubroIngreso.SelectedValue = Convert.ToString(item.secundariorubroingreso_id);
                    this.cboDiagnosticoSecundarioSubRubroIngreso.SelectedValue = Convert.ToString(item.secundariosubrubroingreso_id);
                    this.cboDiagnosticoSecundarioItemIngreso.SelectedValue = Convert.ToString(item.secundarioitemingreso_id);
                    this.cboDiagnosticoTerciarioCapituloIngreso.SelectedValue = Convert.ToString(item.terciariocapituloingreso_id);
                    this.cboDiagnosticoTerciarioRubroIngreso.SelectedValue = Convert.ToString(item.terciariorubroingreso_id);
                    this.cboDiagnosticoTerciarioSubRubroIngreso.SelectedValue = Convert.ToString(item.terciariosubrubroingreso_id);
                    this.cboDiagnosticoTerciarioItemIngreso.SelectedValue = Convert.ToString(item.terciarioitemingreso_id);
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
