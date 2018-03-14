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
    public partial class DiagnosticoEgreso : MetroForm
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
        public DiagnosticoEgreso()
        {
            InitializeComponent();
        }
        private void DiagnosticoEgreso_Load(object sender, EventArgs e)
        {
            try
            {
                if (_idPaciente == 0)
                {
                    #region DIAGNOSTICO EGRESO
                    // Principal
                    CargarCboDiagnosticoPrincipalCapituloEgreso();
                    CargarCboDiagnosticoPrincipalRubroEgreso(rubro_id);
                    CargarCboDiagnosticoPrincipalSubRubroEgreso(subRubro_id);
                    CargarCboDiagnosticoPrincipalItemEgreso(item_id);
                    this.cboDiagnosticoPrincipalRubroEgreso.Enabled = false;
                    this.cboDiagnosticoPrincipalSubRubroEgreso.Enabled = false;
                    this.cboDiagnosticoPrincipalItemEgreso.Enabled = false;
                    // Secundario 1
                    CargarCboDiagnosticoSecundarioCapituloEgreso();
                    CargarCboDiagnosticoSecundarioRubroEgreso(rubro_id);
                    CargarCboDiagnosticoSecundarioSubRubroEgreso(subRubro_id);
                    CargarCboDiagnosticoSecundarioItemEgreso(item_id);
                    this.cboDiagnosticoSecundarioRubroEgreso.Enabled = false;
                    this.cboDiagnosticoSecundarioSubRubroEgreso.Enabled = false;
                    this.cboDiagnosticoSecundarioItemEgreso.Enabled = false;
                    // Secundario 2
                    CargarCboDiagnosticoTerciarioCapituloEgreso();
                    CargarCboDiagnosticoTerciarioRubroEgreso(rubro_id);
                    CargarCboDiagnosticoTerciarioSubRubroEgreso(subRubro_id);
                    CargarCboDiagnosticoTerciarioItemEgreso(item_id);
                    this.cboDiagnosticoTerciarioRubroEgreso.Enabled = false;
                    this.cboDiagnosticoTerciarioSubRubroEgreso.Enabled = false;
                    this.cboDiagnosticoTerciarioItemEgreso.Enabled = false;
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
        #region DIAGNOSTICO EGRESO
        // Principal
        private void CargarCboDiagnosticoPrincipalCapituloEgreso()
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO _capitulo = new BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO> _ItemsCapitulo = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO>();
                //Limpia el combo
                this.cboDiagnosticoPrincipalCapituloEgreso.SuspendLayout();
                this.cboDiagnosticoPrincipalCapituloEgreso.DataSource = null;
                this.cboDiagnosticoPrincipalCapituloEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.capitulo = "0";
                _ItemsCapitulo = _capitulo.ItemList();
                _ItemsCapitulo.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoPrincipalCapituloEgreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoPrincipalCapituloEgreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO.ColumnNames.GRUPO;
                this.cboDiagnosticoPrincipalCapituloEgreso.DataSource = _ItemsCapitulo;
                this.cboDiagnosticoPrincipalCapituloEgreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoPrincipalRubroEgreso(string rubro_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO _rubro = new BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO> _ItemsRubro = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO>();
                //Limpia el combo
                this.cboDiagnosticoPrincipalRubroEgreso.SuspendLayout();
                this.cboDiagnosticoPrincipalRubroEgreso.DataSource = null;
                this.cboDiagnosticoPrincipalRubroEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.capitulo = "0";
                _ItemsRubro = _rubro.ItemList(rubro_id);
                _ItemsRubro.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoPrincipalRubroEgreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoPrincipalRubroEgreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO.ColumnNames.CAPITULO;
                this.cboDiagnosticoPrincipalRubroEgreso.DataSource = _ItemsRubro;
                this.cboDiagnosticoPrincipalRubroEgreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoPrincipalSubRubroEgreso(string subRubro_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO _subRubro = new BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO> _ItemsSubRubro = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO>();
                //Limpia el combo
                this.cboDiagnosticoPrincipalSubRubroEgreso.SuspendLayout();
                this.cboDiagnosticoPrincipalSubRubroEgreso.DataSource = null;
                this.cboDiagnosticoPrincipalSubRubroEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.grupo = "0";
                _ItemsSubRubro = _subRubro.ItemList(subRubro_id);
                _ItemsSubRubro.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoPrincipalSubRubroEgreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoPrincipalSubRubroEgreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO.ColumnNames.CAPITULO;
                this.cboDiagnosticoPrincipalSubRubroEgreso.DataSource = _ItemsSubRubro;
                this.cboDiagnosticoPrincipalSubRubroEgreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoPrincipalItemEgreso(string capitulo_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM _item = new BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM();
                Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM> _ItemsItem = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM>();
                //Limpia el combo
                this.cboDiagnosticoPrincipalItemEgreso.SuspendLayout();
                this.cboDiagnosticoPrincipalItemEgreso.DataSource = null;
                this.cboDiagnosticoPrincipalItemEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.grupo = "0";
                _ItemsItem = _item.ItemList(capitulo_id);
                _ItemsItem.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoPrincipalItemEgreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoPrincipalItemEgreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM.ColumnNames.CAPITULO;
                this.cboDiagnosticoPrincipalItemEgreso.DataSource = _ItemsItem;
                this.cboDiagnosticoPrincipalItemEgreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Secundario
        private void CargarCboDiagnosticoSecundarioCapituloEgreso()
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO _capitulo = new BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO> _ItemsCapitulo = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO>();
                //Limpia el combo
                this.cboDiagnosticoSecundarioCapituloEgreso.SuspendLayout();
                this.cboDiagnosticoSecundarioCapituloEgreso.DataSource = null;
                this.cboDiagnosticoSecundarioCapituloEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.capitulo = "0";
                _ItemsCapitulo = _capitulo.ItemList();
                _ItemsCapitulo.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoSecundarioCapituloEgreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoSecundarioCapituloEgreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO.ColumnNames.GRUPO;
                this.cboDiagnosticoSecundarioCapituloEgreso.DataSource = _ItemsCapitulo;
                this.cboDiagnosticoSecundarioCapituloEgreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoSecundarioRubroEgreso(string rubro_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO _rubro = new BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO> _ItemsRubro = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO>();
                //Limpia el combo
                this.cboDiagnosticoSecundarioRubroEgreso.SuspendLayout();
                this.cboDiagnosticoSecundarioRubroEgreso.DataSource = null;
                this.cboDiagnosticoSecundarioRubroEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.capitulo = "0";
                _ItemsRubro = _rubro.ItemList(rubro_id);
                _ItemsRubro.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoSecundarioRubroEgreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoSecundarioRubroEgreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO.ColumnNames.CAPITULO;
                this.cboDiagnosticoSecundarioRubroEgreso.DataSource = _ItemsRubro;
                this.cboDiagnosticoSecundarioRubroEgreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoSecundarioSubRubroEgreso(string subRubro_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO _subRubro = new BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO> _ItemsSubRubro = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO>();
                //Limpia el combo
                this.cboDiagnosticoSecundarioSubRubroEgreso.SuspendLayout();
                this.cboDiagnosticoSecundarioSubRubroEgreso.DataSource = null;
                this.cboDiagnosticoSecundarioSubRubroEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.grupo = "0";
                _ItemsSubRubro = _subRubro.ItemList(subRubro_id);
                _ItemsSubRubro.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoSecundarioSubRubroEgreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoSecundarioSubRubroEgreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO.ColumnNames.CAPITULO;
                this.cboDiagnosticoSecundarioSubRubroEgreso.DataSource = _ItemsSubRubro;
                this.cboDiagnosticoSecundarioSubRubroEgreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoSecundarioItemEgreso(string capitulo_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM _item = new BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM();
                Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM> _ItemsItem = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM>();
                //Limpia el combo
                this.cboDiagnosticoSecundarioItemEgreso.SuspendLayout();
                this.cboDiagnosticoSecundarioItemEgreso.DataSource = null;
                this.cboDiagnosticoSecundarioItemEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.grupo = "0";
                _ItemsItem = _item.ItemList(capitulo_id);
                _ItemsItem.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoSecundarioItemEgreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoSecundarioItemEgreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM.ColumnNames.CAPITULO;
                this.cboDiagnosticoSecundarioItemEgreso.DataSource = _ItemsItem;
                this.cboDiagnosticoSecundarioItemEgreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Terciario
        private void CargarCboDiagnosticoTerciarioCapituloEgreso()
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO _capitulo = new BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO> _ItemsCapitulo = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_CAPITULO>();
                //Limpia el combo
                this.cboDiagnosticoTerciarioCapituloEgreso.SuspendLayout();
                this.cboDiagnosticoTerciarioCapituloEgreso.DataSource = null;
                this.cboDiagnosticoTerciarioCapituloEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.capitulo = "0";
                _ItemsCapitulo = _capitulo.ItemList();
                _ItemsCapitulo.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoTerciarioCapituloEgreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoTerciarioCapituloEgreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_CAPITULO.ColumnNames.GRUPO;
                this.cboDiagnosticoTerciarioCapituloEgreso.DataSource = _ItemsCapitulo;
                this.cboDiagnosticoTerciarioCapituloEgreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoTerciarioRubroEgreso(string rubro_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO _rubro = new BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO> _ItemsRubro = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_RUBRO>();
                //Limpia el combo
                this.cboDiagnosticoTerciarioRubroEgreso.SuspendLayout();
                this.cboDiagnosticoTerciarioRubroEgreso.DataSource = null;
                this.cboDiagnosticoTerciarioRubroEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.capitulo = "0";
                _ItemsRubro = _rubro.ItemList(rubro_id);
                _ItemsRubro.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoTerciarioRubroEgreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoTerciarioRubroEgreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_RUBRO.ColumnNames.CAPITULO;
                this.cboDiagnosticoTerciarioRubroEgreso.DataSource = _ItemsRubro;
                this.cboDiagnosticoTerciarioRubroEgreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoTerciarioSubRubroEgreso(string subRubro_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO _subRubro = new BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO();
                Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO> _ItemsSubRubro = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO>();
                //Limpia el combo
                this.cboDiagnosticoTerciarioSubRubroEgreso.SuspendLayout();
                this.cboDiagnosticoTerciarioSubRubroEgreso.DataSource = null;
                this.cboDiagnosticoTerciarioSubRubroEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.grupo = "0";
                _ItemsSubRubro = _subRubro.ItemList(subRubro_id);
                _ItemsSubRubro.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoTerciarioSubRubroEgreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoTerciarioSubRubroEgreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_SUBRUBRO.ColumnNames.CAPITULO;
                this.cboDiagnosticoTerciarioSubRubroEgreso.DataSource = _ItemsSubRubro;
                this.cboDiagnosticoTerciarioSubRubroEgreso.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCboDiagnosticoTerciarioItemEgreso(string capitulo_id)
        {
            try
            {
                BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM _item = new BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM();
                Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM _itemSeleccion = new Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM();
                List<Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM> _ItemsItem = new List<Entities.Procedures.MED_GET_DIAGNOSTICO_ITEM>();
                //Limpia el combo
                this.cboDiagnosticoTerciarioItemEgreso.SuspendLayout();
                this.cboDiagnosticoTerciarioItemEgreso.DataSource = null;
                this.cboDiagnosticoTerciarioItemEgreso.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione>";
                _itemSeleccion.grupo = "0";
                _ItemsItem = _item.ItemList(capitulo_id);
                _ItemsItem.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboDiagnosticoTerciarioItemEgreso.DisplayMember = BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM.ColumnNames.DESCRIPCION;
                this.cboDiagnosticoTerciarioItemEgreso.ValueMember = BLL.Procedures.MED_GET_DIAGNOSTICO_ITEM.ColumnNames.CAPITULO;
                this.cboDiagnosticoTerciarioItemEgreso.DataSource = _ItemsItem;
                this.cboDiagnosticoTerciarioItemEgreso.ResumeLayout();
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

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Diagnostico Egreso
        // Principal
        private void cboDiagnosticoPrincipalCapituloEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nieto_id;
            nieto_id = Convert.ToString(this.cboDiagnosticoPrincipalCapituloEgreso.SelectedIndex);
            if (nieto_id != "0")
            {
                CargarCboDiagnosticoPrincipalRubroEgreso(nieto_id);
                this.cboDiagnosticoPrincipalRubroEgreso.Enabled = true;
                this.cboDiagnosticoPrincipalSubRubroEgreso.Enabled = false;
                this.cboDiagnosticoPrincipalItemEgreso.Enabled = false;
            }
            else
            {
                this.cboDiagnosticoPrincipalRubroEgreso.Enabled = false;
                this.cboDiagnosticoPrincipalSubRubroEgreso.Enabled = false;
                this.cboDiagnosticoPrincipalItemEgreso.Enabled = false;
            }
        }
        private void cboDiagnosticoPrincipalRubroEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nieto_id;
            nieto_id = Convert.ToString(this.cboDiagnosticoPrincipalRubroEgreso.SelectedValue);
            if (nieto_id != "0")
            {
                CargarCboDiagnosticoPrincipalSubRubroEgreso(nieto_id);
                this.cboDiagnosticoPrincipalRubroEgreso.Enabled = true;
                this.cboDiagnosticoPrincipalSubRubroEgreso.Enabled = true;
                this.cboDiagnosticoPrincipalItemEgreso.Enabled = false;
            }
            else
            {
                this.cboDiagnosticoPrincipalRubroEgreso.Enabled = false;
                this.cboDiagnosticoPrincipalSubRubroEgreso.Enabled = false;
                this.cboDiagnosticoPrincipalItemEgreso.Enabled = false;
            }
        }
        private void cboDiagnosticoPrincipalSubRubroEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string capitulo_id;
            capitulo_id = Convert.ToString(this.cboDiagnosticoPrincipalSubRubroEgreso.SelectedValue);
            if (capitulo_id != "0")
            {
                CargarCboDiagnosticoPrincipalItemEgreso(capitulo_id);
                this.cboDiagnosticoPrincipalItemEgreso.Enabled = true;
            }
            else
            {
                this.cboDiagnosticoPrincipalRubroEgreso.Enabled = false;
                this.cboDiagnosticoPrincipalSubRubroEgreso.Enabled = false;
                this.cboDiagnosticoPrincipalItemEgreso.Enabled = false;
            }
        }
        // Secundario
        private void cboDiagnosticoSecundarioCapituloEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nieto_id;
            nieto_id = Convert.ToString(this.cboDiagnosticoSecundarioCapituloEgreso.SelectedIndex);
            if (nieto_id != "0")
            {
                CargarCboDiagnosticoSecundarioRubroEgreso(nieto_id);
                this.cboDiagnosticoSecundarioRubroEgreso.Enabled = true;
                this.cboDiagnosticoSecundarioSubRubroEgreso.Enabled = false;
                this.cboDiagnosticoSecundarioItemEgreso.Enabled = false;
            }
            else
            {
                this.cboDiagnosticoSecundarioRubroEgreso.Enabled = false;
                this.cboDiagnosticoSecundarioSubRubroEgreso.Enabled = false;
                this.cboDiagnosticoSecundarioItemEgreso.Enabled = false;
            }
        }
        private void cboDiagnosticoSecundarioRubroEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nieto_id;
            nieto_id = Convert.ToString(this.cboDiagnosticoSecundarioRubroEgreso.SelectedValue);
            if (nieto_id != "0")
            {
                CargarCboDiagnosticoSecundarioSubRubroEgreso(nieto_id);
                this.cboDiagnosticoSecundarioRubroEgreso.Enabled = true;
                this.cboDiagnosticoSecundarioSubRubroEgreso.Enabled = true;
                this.cboDiagnosticoSecundarioItemEgreso.Enabled = false;
            }
            else
            {
                this.cboDiagnosticoSecundarioRubroEgreso.Enabled = false;
                this.cboDiagnosticoSecundarioSubRubroEgreso.Enabled = false;
                this.cboDiagnosticoSecundarioItemEgreso.Enabled = false;
            }
        }
        private void cboDiagnosticoSecundarioSubRubroEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string capitulo_id;
            capitulo_id = Convert.ToString(this.cboDiagnosticoSecundarioSubRubroEgreso.SelectedValue);
            if (capitulo_id != "0")
            {
                CargarCboDiagnosticoSecundarioItemEgreso(capitulo_id);
                this.cboDiagnosticoSecundarioItemEgreso.Enabled = true;
            }
            else
            {
                this.cboDiagnosticoSecundarioRubroEgreso.Enabled = false;
                this.cboDiagnosticoSecundarioSubRubroEgreso.Enabled = false;
                this.cboDiagnosticoSecundarioItemEgreso.Enabled = false;
            }
        }
        // Terciario
        private void cboDiagnosticoTerciarioCapituloEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nieto_id;
            nieto_id = Convert.ToString(this.cboDiagnosticoTerciarioCapituloEgreso.SelectedIndex);
            if (nieto_id != "0")
            {
                CargarCboDiagnosticoTerciarioRubroEgreso(nieto_id);
                this.cboDiagnosticoTerciarioRubroEgreso.Enabled = true;
                this.cboDiagnosticoTerciarioSubRubroEgreso.Enabled = false;
                this.cboDiagnosticoTerciarioItemEgreso.Enabled = false;
            }
            else
            {
                this.cboDiagnosticoTerciarioRubroEgreso.Enabled = false;
                this.cboDiagnosticoTerciarioSubRubroEgreso.Enabled = false;
                this.cboDiagnosticoTerciarioItemEgreso.Enabled = false;
            }
        }
        private void cboDiagnosticoTerciarioRubroEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nieto_id;
            nieto_id = Convert.ToString(this.cboDiagnosticoTerciarioRubroEgreso.SelectedValue);
            if (nieto_id != "0")
            {
                CargarCboDiagnosticoTerciarioSubRubroEgreso(nieto_id);
                this.cboDiagnosticoTerciarioRubroEgreso.Enabled = true;
                this.cboDiagnosticoTerciarioSubRubroEgreso.Enabled = true;
                this.cboDiagnosticoTerciarioItemEgreso.Enabled = false;
            }
            else
            {
                this.cboDiagnosticoTerciarioRubroEgreso.Enabled = false;
                this.cboDiagnosticoTerciarioSubRubroEgreso.Enabled = false;
                this.cboDiagnosticoTerciarioItemEgreso.Enabled = false;
            }
        }
        private void cboDiagnosticoTerciarioSubRubroEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string capitulo_id;
            capitulo_id = Convert.ToString(this.cboDiagnosticoTerciarioSubRubroEgreso.SelectedValue);
            if (capitulo_id != "0")
            {
                CargarCboDiagnosticoTerciarioItemEgreso(capitulo_id);
                this.cboDiagnosticoTerciarioItemEgreso.Enabled = true;
            }
            else
            {
                this.cboDiagnosticoTerciarioRubroEgreso.Enabled = false;
                this.cboDiagnosticoTerciarioSubRubroEgreso.Enabled = false;
                this.cboDiagnosticoTerciarioItemEgreso.Enabled = false;
            }
        }
        #endregion

        #endregion

        #region Metodos

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

                    // EGRESO
                    _item.PRINCIPALCAPITULOEGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalCapituloEgreso.SelectedValue);
                    _item.PRINCIPALRUBROEGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalRubroEgreso.SelectedValue);
                    _item.PRINCIPALSUBRUBROEGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalSubRubroEgreso.SelectedValue);
                    _item.PRINCIPALITEMEGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalItemEgreso.SelectedValue);
                    _item.SECUNDARIOCAPITULOEGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioCapituloEgreso.SelectedValue);
                    _item.SECUNDARIORUBROEGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioRubroEgreso.SelectedValue);
                    _item.SECUNDARIOSUBRUBROEGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioSubRubroEgreso.SelectedValue);
                    _item.SECUNDARIOITEMEGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioItemEgreso.SelectedValue);
                    _item.TERCIARIOCAPITULOEGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioCapituloEgreso.SelectedValue);
                    _item.TERCIARIORUBROEGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioRubroEgreso.SelectedValue);
                    _item.TERCIARIOSUBRUBROEGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioSubRubroEgreso.SelectedValue);
                    _item.TERCIARIOITEMEGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioItemEgreso.SelectedValue);

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
                // EGRESO
                _item.PRINCIPALCAPITULOEGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalCapituloEgreso.SelectedValue);
                _item.PRINCIPALRUBROEGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalRubroEgreso.SelectedValue);
                _item.PRINCIPALSUBRUBROEGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalSubRubroEgreso.SelectedValue);
                _item.PRINCIPALITEMEGRESO_ID = Convert.ToString(this.cboDiagnosticoPrincipalItemEgreso.SelectedValue);
                _item.SECUNDARIOCAPITULOEGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioCapituloEgreso.SelectedValue);
                _item.SECUNDARIORUBROEGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioRubroEgreso.SelectedValue);
                _item.SECUNDARIOSUBRUBROEGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioSubRubroEgreso.SelectedValue);
                _item.SECUNDARIOITEMEGRESO_ID = Convert.ToString(this.cboDiagnosticoSecundarioItemEgreso.SelectedValue);
                _item.TERCIARIOCAPITULOEGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioCapituloEgreso.SelectedValue);
                _item.TERCIARIORUBROEGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioRubroEgreso.SelectedValue);
                _item.TERCIARIOSUBRUBROEGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioSubRubroEgreso.SelectedValue);
                _item.TERCIARIOITEMEGRESO_ID = Convert.ToString(this.cboDiagnosticoTerciarioItemEgreso.SelectedValue);

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
            #region DIAGNOSTICO EGRESO
            // Principal
            CargarCboDiagnosticoPrincipalCapituloEgreso();
            CargarCboDiagnosticoPrincipalRubroEgreso(rubro_id);
            CargarCboDiagnosticoPrincipalSubRubroEgreso(subRubro_id);
            CargarCboDiagnosticoPrincipalItemEgreso(item_id);
            // Secundario 1
            CargarCboDiagnosticoSecundarioCapituloEgreso();
            CargarCboDiagnosticoSecundarioRubroEgreso(rubro_id);
            CargarCboDiagnosticoSecundarioSubRubroEgreso(subRubro_id);
            CargarCboDiagnosticoSecundarioItemEgreso(item_id);
            // Secundario 2
            CargarCboDiagnosticoTerciarioCapituloEgreso();
            CargarCboDiagnosticoTerciarioRubroEgreso(rubro_id);
            CargarCboDiagnosticoTerciarioSubRubroEgreso(subRubro_id);
            CargarCboDiagnosticoTerciarioItemEgreso(item_id);
            #endregion

            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.MED_GET_DIAGNOSTICO_PACIENTE _obtieneDiagnostico = new BLL.Procedures.MED_GET_DIAGNOSTICO_PACIENTE();
                foreach (Entities.Procedures.MED_GET_DIAGNOSTICO_PACIENTE item in _obtieneDiagnostico.ItemList(paciente_id))
                {
                    // Egreso
                    this.cboDiagnosticoPrincipalCapituloEgreso.SelectedValue = Convert.ToString(item.principalcapituloegreso_id);
                    this.cboDiagnosticoPrincipalRubroEgreso.SelectedValue = Convert.ToString(item.principalrubroegreso_id);
                    this.cboDiagnosticoPrincipalSubRubroEgreso.SelectedValue = Convert.ToString(item.principalsubrubroegreso_id);
                    this.cboDiagnosticoPrincipalItemEgreso.SelectedValue = Convert.ToString(item.principalitemegreso_id);
                    this.cboDiagnosticoSecundarioCapituloEgreso.SelectedValue = Convert.ToString(item.secundariocapituloegreso_id);
                    this.cboDiagnosticoSecundarioRubroEgreso.SelectedValue = Convert.ToString(item.secundariorubroegreso_id);
                    this.cboDiagnosticoSecundarioSubRubroEgreso.SelectedValue = Convert.ToString(item.secundariosubrubroegreso_id);
                    this.cboDiagnosticoSecundarioItemEgreso.SelectedValue = Convert.ToString(item.secundarioitemegreso_id);
                    this.cboDiagnosticoTerciarioCapituloEgreso.SelectedValue = Convert.ToString(item.terciariocapituloegreso_id);
                    this.cboDiagnosticoTerciarioRubroEgreso.SelectedValue = Convert.ToString(item.terciariorubroegreso_id);
                    this.cboDiagnosticoTerciarioSubRubroEgreso.SelectedValue = Convert.ToString(item.terciariosubrubroegreso_id);
                    this.cboDiagnosticoTerciarioItemEgreso.SelectedValue = Convert.ToString(item.terciarioitemegreso_id);
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
