using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.OleDb;
namespace Principal.Forms.ListaEspera
{
    public partial class Frm_Mails : MetroForm
    {
        #region Variables
        enum Col_Mails
        {
            COL_SEDE_ID,
            COL_SECTOR_ID,
            COL_INACTIVO,
            COL_NOMBRE,
            COL_EMAIL
        }
        SISTMEDEntities _Mod = new SISTMEDEntities();

        #endregion

        #region Funciones

        public Frm_Mails()
        {
            InitializeComponent();
        }


        private void CargarSedes()
        {
            try
            {

                var _listObj = (from sede in _Mod.Sedes orderby sede.descripcion select sede).ToList();

                Sedes _itemSeleccion = new Sedes();

                //Limpia el combo
                this.comboBoxSede.SuspendLayout();
                this.comboBoxSede.DataSource = null;
                this.comboBoxSede.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione una Sede>";
                _itemSeleccion.sede_id = 0;
                _listObj.Insert(0, _itemSeleccion);
                //Carga el combo
                this.comboBoxSede.DisplayMember = "descripcion";
                this.comboBoxSede.ValueMember = "sede_id";
                this.comboBoxSede.DataSource = _listObj;
                this.comboBoxSede.ResumeLayout();

                comboBoxSede.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraerSectores(int _sede)
        {
            try
            {
                var _listObj = (from M in _Mod.MED_SectorMails where M.sede_id == _sede orderby M.descripcion select M).ToList();

                MED_SectorMails _itemSeleccion = new MED_SectorMails();

                //Limpia el combo
                this.comboBoxSectores.SuspendLayout();
                this.comboBoxSectores.DataSource = null;
                this.comboBoxSectores.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione un Sector>";
                _itemSeleccion.sector_id = 0;
                _listObj.Insert(0, _itemSeleccion);
                //Carga el combo
                this.comboBoxSectores.DisplayMember = "descripcion";
                this.comboBoxSectores.ValueMember = "sector_id";
                this.comboBoxSectores.DataSource = _listObj;
                this.comboBoxSectores.ResumeLayout();

                comboBoxSectores.SelectedIndex = 0;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TraerMails(int _sede, int _sector)
        {
            try
            {
                var _list = (from M in _Mod.MED_Mails where M.sede_id == _sede && M.sector_id == _sector orderby M.email select M).ToList();

                dataGridViewMails.Rows.Clear();
                int indice = 0;
                foreach (var item in _list)
                {
                    indice = dataGridViewMails.Rows.Add();
                    dataGridViewMails.Rows[indice].Cells[(int)Col_Mails.COL_SEDE_ID].Value = item.sede_id; //sede ID
                    dataGridViewMails.Rows[indice].Cells[(int)Col_Mails.COL_SECTOR_ID].Value = item.sector_id; //SECTOR_ID
                    dataGridViewMails.Rows[indice].Cells[(int)Col_Mails.COL_INACTIVO].Value = item.inactivo; //ESTADO
                    dataGridViewMails.Rows[indice].Cells[(int)Col_Mails.COL_NOMBRE].Value = item.nombre; //nombre
                    dataGridViewMails.Rows[indice].Cells[(int)Col_Mails.COL_EMAIL].Value = item.email; //email

                    indice++;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LLenarGrid(string archivo, string hoja)
        {
            //declaramos las variables         
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select * from [" + hoja + "$]";

            //esta cadena es para archivos excel 2007 y 2010
            //string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            //para archivos de 97-2003 usar la siguiente cadena
            string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";

            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            {
                try
                {
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                    dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
                    dataGridViewMails.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    dataGridViewMails.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }

        #endregion


        #region Eventos
        private void Frm_Mails_Load(object sender, EventArgs e)
        {

            CargarSedes();

        }


        #endregion

        private void comboBoxSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSede.SelectedIndex > 0)
            {
                dataGridViewMails.Rows.Clear();
                TraerSectores(Convert.ToInt32(comboBoxSede.SelectedValue));
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxSectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSectores.SelectedIndex > 0 && comboBoxSede.SelectedIndex > 0)
            {
                TraerMails(Convert.ToInt32(comboBoxSede.SelectedValue), Convert.ToInt32(comboBoxSectores.SelectedValue));

            }
          
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                MED_Mails _email = new MED_Mails();
                List<MED_Mails> _listaMail = new List<MED_Mails>();
                if(comboBoxSede.SelectedIndex > 0 && comboBoxSectores.SelectedIndex > 0 )
                {

                    if(dataGridViewMails.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridViewMails.Rows.Count -1; i++)
                        {
                            _email = new MED_Mails();
                            _email.sede_id = Convert.ToInt32(comboBoxSede.SelectedValue);
                            _email.sector_id = Convert.ToInt32(comboBoxSectores.SelectedValue);
                            _email.inactivo = Convert.ToBoolean(dataGridViewMails.Rows[i].Cells[(int)Col_Mails.COL_INACTIVO].Value);
                            _email.email = dataGridViewMails.Rows[i].Cells[(int)Col_Mails.COL_EMAIL].Value.ToString();
                            _email.nombre = dataGridViewMails.Rows[i].Cells[(int)Col_Mails.COL_NOMBRE].Value.ToString();
                            _listaMail.Add(_email);
                        }

                       if(_listaMail.Count > 0)
                        {
                            Clases.IndicacionesBLL.Mail _guardar = new Clases.IndicacionesBLL.Mail();
                            if( _guardar.IngresaMail(_listaMail, Convert.ToInt32(comboBoxSede.SelectedValue), Convert.ToInt32(comboBoxSectores.SelectedValue)))
                            {
                                MessageBox.Show("Emails guardados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("Error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                    }

                    else
                    {
                        MessageBox.Show("No existen mails para grabar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }
                
                else
                {
                    MessageBox.Show("Debe seleccionar una Sede y un Sector", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }


            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMails_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewMails.IsCurrentCellDirty)
                dataGridViewMails.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LLenarGrid("@@C:\\Proyectos\\Hector.xls", "Hoja1");
        }

        private void metroTileNuevo_Click(object sender, EventArgs e)
        {
            dataGridViewMails.Rows.Clear();
            comboBoxSede.SelectedIndex = 0;
        }
    }
}
