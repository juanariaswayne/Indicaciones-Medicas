using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.Linq;
using System.Globalization;

namespace Principal.Forms.ListaEspera
{
    public partial class Frm_CostoModulo : MetroForm
    {
        #region Variables
            SISTMEDEntities _Mod = new SISTMEDEntities();
           
            CultureInfo culture = new CultureInfo("en-US");
        #endregion

        #region Funciones
        public Frm_CostoModulo()
        {
            InitializeComponent();
        }
        private void TraeObraSocial()
        {
            try
            {
                SISTMEDEntities _Stored = new SISTMEDEntities();
                var _listObj = (from Tipos in _Stored.TraeObrasSociales()
                                orderby Tipos.cli_RazSoc
                                select Tipos).ToList();

                TraeObrasSociales_Result _itemSeleccion = new TraeObrasSociales_Result();//  ENTITIES QUE GENERA EL E. FRAMEWORK CUANDO ES UN STORED

                //Limpia el combo
                ComboBoxOSocial.SuspendLayout();
                ComboBoxOSocial.DataSource = null;
                ComboBoxOSocial.Items.Clear();

                // Carga el item de Seleccion
                _itemSeleccion.cli_RazSoc = "<Seleccione una Obra Social>";
                _itemSeleccion.cli_Cod = "0";
                _listObj.Insert(0, _itemSeleccion);

                //Carga el combo
                ComboBoxOSocial.DisplayMember = "cli_RazSoc";
                ComboBoxOSocial.ValueMember = "cli_Cod";
                ComboBoxOSocial.DataSource = _listObj.ToArray();
                ComboBoxOSocial.SelectedIndex = 0;

                ComboBoxOSocial.ResumeLayout();

            }

            catch (Exception ex)
            {


            }

        }

        private void TraerModulos()
        {
            try
            {
                var _listObj = (from M in _Mod.MED_Modulo select M).ToList();

                            
               MED_Modulo _itemSeleccion = new MED_Modulo();
                
                //Limpia el combo
                comboBoxModulo.SuspendLayout();
                comboBoxModulo.DataSource = null;
                comboBoxModulo.Items.Clear();

                // Carga el item de Seleccion
                _itemSeleccion.Descripcion = "<Seleccione un Módulo>";
                _itemSeleccion.modulo_id = "0";
                _listObj.Insert(0, _itemSeleccion);

                //Carga el combo
                comboBoxModulo.DisplayMember = "Descripcion";
                comboBoxModulo.ValueMember = "modulo_id";
                comboBoxModulo.DataSource = _listObj.ToArray();
                comboBoxModulo.SelectedIndex = 0;

                comboBoxModulo.ResumeLayout();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarModulosCosto(string codEmp)
        {

            SISTMEDEntities _Stored = new SISTMEDEntities();
            string Modulo_Id = "0";
            string ModuloName = string.Empty;
            TreeNode newNode = new TreeNode();
            TreeNode newModulo = new TreeNode();
            int image_id = 0;
            TreeNode node_root = new TreeNode();
            string _obraSocial = string.Empty;
            try
            {
                var _listModulo = (from M in  _Stored.MED_TraeModuloEmpresaCosto(codEmp) select M).ToList();

                node_root.Nodes.Clear();
                newNode.Nodes.Clear();
                newModulo.Nodes.Clear();
                treeViewModulos.Nodes.Clear();

                if (_listModulo.Count > 0)
                {
                    //recupero el id del modulo del primer registro
                    Modulo_Id = _listModulo.First().modulo_id;
                    //recupero el nombre de ese módulo
                    ModuloName = _listModulo.First().Descripcion + "                    ";
                    //agrego ese modulo como nodo raiz
                    node_root = new TreeNode();

                    node_root = treeViewModulos.Nodes.Add(Modulo_Id.ToString(), ModuloName, image_id);
                    node_root.NodeFont = new Font(treeViewModulos.Font, FontStyle.Bold);
                    // node_root.NodeFont = new Font(treeViewCars.Font.Size,_tamaño);
                    node_root.Expand();

                    //VOY AGREGANDO LAS OBRAS SOCIALES ** MED_TraeModuloEmpresaCosto_Result ES LA ENTITIES DE ESE STORED
                    foreach (MED_TraeModuloEmpresaCosto_Result item in _listModulo)
                    {
                        _obraSocial = string.Empty;
                        //pregunto si cambio el modulo
                        if (Modulo_Id.Trim() == item.modulo_id.Trim())
                        {
                            //sigo en el mismo modulo, agrego las obras sociales y los costos
                            image_id = 1;
                            _obraSocial = "[" + item.ObraSocial.ToString() + "]" + " - " + "Costo: " +  item.costo.ToString().Replace(",", "."); //+ " - " + "Marca: " + item.Marca.ToString() + " - " + "Transponder Nro.: " + item.Transponder.ToString();
                            newNode = new TreeNode(_obraSocial, image_id, image_id);
                            newNode.Name = item.ObraSocial.ToString();
                            newNode.ToolTipText = item.ObraSocial.ToString();
                            //lleno esta estructura para salvar estos datos, para el evento click del Treview
                            newNode.Tag = item;
                            //agrego el nodo

                            node_root.Nodes.Add(newNode);

                            // ***** Muestro piloto *****
                            //image_id = 1;
                            //_carsString = "Piloto: " + item.apellidoynombre.ToString();
                            //newPilot = new TreeNode(_carsString, image_id, image_id);
                            //newPilot.Name = item.apellidoynombre.ToString();
                            //newPilot.ToolTipText = item.apellidoynombre.ToString();
                            ////lleno esta estructura para salvar estos datos, para el evento click del Treview
                            //newPilot.Tag = item;
                            ////agrego el nodo
                            //newPilot.ForeColor = Color.Blue;
                            //newNode.Nodes.Add(newPilot);

                        }
                        else
                        {
                            //cambió el módulo, paso el nuevo a las variables y asigno al nodo raiz al nuevo módulo
                            image_id = 0;
                            Modulo_Id = item.modulo_id;
                            //lleno esta estructura para salvar estos datos, para el evento click del Treview
                            //creo el nodo Modulo
                            node_root = new TreeNode();
                            node_root = treeViewModulos.Nodes.Add(item.modulo_id.ToString(), item.Descripcion + "                    ", image_id);
                            node_root.NodeFont = new Font(treeViewModulos.Font, FontStyle.Bold);
                            //creo las obras sociales
                            image_id = 1;
                            _obraSocial = "[" + item.ObraSocial.ToString() + "]" + " - " + "Costo: " + item.costo.ToString().Replace(",", "."); //+ " - " + "Marca: " + item.Marca.ToString() + " - " + "Transponder Nro.: " + item.Transponder.ToString();
                            newNode = new TreeNode(_obraSocial, image_id, image_id);
                            newNode.Name = item.ObraSocial.ToString();
                            newNode.ToolTipText = item.ObraSocial.ToString();
                            //lleno esta estructura para salvar estos datos, para el evento click del Treview
                            newNode.Tag = item;
                            //if (!item.ACTIVO)
                            //{ newNode.ForeColor = Color.Red; }
                            node_root.Nodes.Add(newNode);

                            // ***** Muestro piloto *****
                            //image_id = 1;
                            //_carsString = "Piloto: " + item.apellidoynombre.ToString();
                            //newPilot = new TreeNode(_carsString, image_id, image_id);
                            //newPilot.Name = item.apellidoynombre.ToString();
                            //newPilot.ToolTipText = item.apellidoynombre.ToString();
                            ////lleno esta estructura para salvar estos datos, para el evento click del Treview
                            //newPilot.Tag = item;
                            ////agrego el nodo
                            //newPilot.ForeColor = Color.Blue;
                            //newNode.Nodes.Add(newPilot);

                        }

                        treeViewModulos.ExpandAll();
                    }


                }
                else
                {
                    node_root.Nodes.Clear();
                    newNode.Nodes.Clear();
                    newModulo.Nodes.Clear();
                    treeViewModulos.Nodes.Clear();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidarIngreso()
        {
            try
            {
                if (TextBoxCosto.Text == string.Empty)
                {
                    errorProvider1.SetError(TextBoxCosto, "Debe ingresar un Costo");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(TextBoxCosto, "");
                }

                if (comboBoxModulo.SelectedIndex == 0)
                {
                    errorProvider1.SetError(comboBoxModulo, "Debe seleccionar un Módulo");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(comboBoxModulo, "");
                }

                if (ComboBoxOSocial.SelectedIndex == 0)
                {
                    errorProvider1.SetError(ComboBoxOSocial, "Debe seleccionar una Obra social");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(ComboBoxOSocial, "");
                }

             

                return true;
            }

            catch (Exception ex)
            {
                return false;

            }

        }

        private void NuevoIngreso()
        {
            comboBoxModulo.SelectedIndex = 0;
            ComboBoxOSocial.SelectedIndex = 0;
            TextBoxCosto.Text = string.Empty;
            dateTimeFechaVigencia.Value = DateTime.Now;
            CargarModulosCosto(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
        }

        #endregion


        #region Eventos
        private void Frm_CostoModulo_Load(object sender, EventArgs e)
        {
            labelEmpresa.Text = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
            TraeObraSocial();
            TraerModulos();
            dateTimeFechaVigencia.Value = Convert.ToDateTime(DateTime.Now);
            CargarModulosCosto(Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString());
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

   

        private void treeViewModulos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node_selected = new TreeNode();
            MED_TraeModuloEmpresaCosto_Result _modulo = new MED_TraeModuloEmpresaCosto_Result();

            try
            {
                //primero verifico si hizo click en una Obra Social y no en un nodo raiz que es el módulo
                node_selected = treeViewModulos.SelectedNode;
                if (node_selected != null && node_selected.Tag != null)
                {
                    _modulo = (MED_TraeModuloEmpresaCosto_Result)node_selected.Tag;
                    //PASO A LA GRILLA PARA SU EDICION
                    comboBoxModulo.SelectedValue = _modulo.modulo_id.ToString();
                    ComboBoxOSocial.SelectedValue = _modulo.obraSocial_id.ToString();
                    TextBoxCosto.Text = _modulo.costo.ToString();
                    dateTimeFechaVigencia.Value = _modulo.fechaVigencia;

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarIngreso())
                {
                    MED_ModuloEmpresa _mod = new MED_ModuloEmpresa();
                    SISTMEDEntities _newCosto = new SISTMEDEntities();

                    _mod.codEmp = Clases.Usuario.EmpresaLogeada.EmpresaIngresada.ToString();
                    _mod.fechaAlta = DateTime.Now;
                    _mod.fechaVigencia = dateTimeFechaVigencia.Value;
                    _mod.modulo_id = comboBoxModulo.SelectedValue.ToString();
                    _mod.obraSocial_id = ComboBoxOSocial.SelectedValue.ToString();
                    _mod.costo = Convert.ToDouble(TextBoxCosto.Text.ToString(), culture);

                    _newCosto.MED_ModuloEmpresa.Add(_mod);
                    _newCosto.SaveChanges();
                    NuevoIngreso();
                    MessageBox.Show("Costo actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == culture.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void metroTileNuevo_Click(object sender, EventArgs e)
        {
            NuevoIngreso();
                
        }
    }
}
