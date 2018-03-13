using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.Parametros
{
    public partial class NuevoUsuario : MetroForm
    {
        #region Variables
        private enum Col_Usuario
        {
            USUARIO_ID = 0,
            ID_PERFIL,
            USUARIO,
            CLAVE,
            NOMBRE_USUARIO,
            INACTIVO,
            SECTOR_ID,
            EMAIL,
            MATRICULA,
            FIRMA,
            FOTO
        }
        #endregion

        #region Funciones
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void TraeUsuarios()
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();
                dataGridViewUsuarios.Rows.Clear();
                int indice;
                foreach (var _item in E.TBL_Usuarios)
                {
                    indice = dataGridViewUsuarios.Rows.Add();
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuario.USUARIO_ID].Value = _item.Id_Usuario;
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuario.ID_PERFIL].Value = _item.Id_Perfil;
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuario.USUARIO].Value = _item.IdentificadorUsuario;
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuario.CLAVE].Value = _item.ContraseniaUsuario;
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuario.NOMBRE_USUARIO].Value = _item.NombreUsuario;
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuario.INACTIVO].Value = _item.Inactivo;
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuario.SECTOR_ID].Value = _item.Sector_id;
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuario.EMAIL].Value = _item.Email;
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuario.MATRICULA].Value = _item.matricula;
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuario.FIRMA].Value = _item.firma;
                    dataGridViewUsuarios.Rows[indice].Cells[(int)Col_Usuario.FOTO].Value = _item.foto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPerfiles()
        {
            try
            {
                SISTMEDEntities c = new SISTMEDEntities();

                List<Sectores> _lista = c.Sectores.OrderBy(S => S.Descripcion).ToList();

                cboPerfiles.DataSource = _lista;
                cboPerfiles.ValueMember = "sector_id";
                cboPerfiles.DisplayMember = "Descripcion";              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AlreadyExists(int _IdUsuario)
        {
            SISTMEDEntities A = new SISTMEDEntities();
            if (A.TBL_Usuarios.Find(_IdUsuario) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Guardar()
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();
                TBL_Usuarios _item = new TBL_Usuarios();
                Seguridad.Encriptacion encripta = new Seguridad.Encriptacion();                
                if(Convert.ToInt32(txtId.Text) != -1) //Si es -1 es porque es un ingreso nuevo
                {
                    _item.Id_Usuario = Convert.ToInt32(txtId.Text);
                }
                _item.Id_Perfil = 1;
                _item.IdentificadorUsuario = txtUsuario.Text;
                _item.ContraseniaUsuario = encripta.ENCRIPTAR(txtClave.Text.ToString());
                _item.NombreUsuario = txtDescripcion.Text;
                _item.Inactivo = chckInactivo.Checked;
                _item.Sector_id = Convert.ToInt32(cboPerfiles.SelectedValue);
                _item.Email = txtEmail.Text;
                _item.matricula = txtMatricula.Text;

                E.Entry(_item).State = (AlreadyExists(Convert.ToInt32(txtId.Text)) ? EntityState.Modified : EntityState.Added);
                E.SaveChanges();

                MetroMessageBox.Show(this, "Se guardo correctamente");

                TraeUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            try
            {
                txtId.Text = "-1";
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtDescripcion.Text = "";
                txtEmail.Text = "";
                txtMatricula.Text = "";
                cboPerfiles.SelectedIndex = 0;
                chckInactivo.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Eventos
        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPerfiles();
                TraeUsuarios();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Seguridad.Encriptacion encripta = new Seguridad.Encriptacion();
                txtUsuario.Text = dataGridViewUsuarios.CurrentRow.Cells[(int)Col_Usuario.USUARIO].Value.ToString();
                txtClave.Text = encripta.DESENCRIPTAR(dataGridViewUsuarios.CurrentRow.Cells[(int)Col_Usuario.CLAVE].Value.ToString());
                txtDescripcion.Text = dataGridViewUsuarios.CurrentRow.Cells[(int)Col_Usuario.NOMBRE_USUARIO].Value.ToString();
                txtMatricula.Text = dataGridViewUsuarios.CurrentRow.Cells[(int)Col_Usuario.MATRICULA].Value == null ? "": dataGridViewUsuarios.CurrentRow.Cells[(int)Col_Usuario.MATRICULA].Value.ToString();
                cboPerfiles.SelectedValue = dataGridViewUsuarios.CurrentRow.Cells[(int)Col_Usuario.SECTOR_ID].Value;
                txtId.Text = dataGridViewUsuarios.CurrentRow.Cells[(int)Col_Usuario.USUARIO_ID].Value.ToString();
                chckInactivo.Checked = Convert.ToInt32(dataGridViewUsuarios.CurrentRow.Cells[(int)Col_Usuario.USUARIO_ID].Value) == 1 ? true : false;
                txtEmail.Text = dataGridViewUsuarios.CurrentRow.Cells[(int)Col_Usuario.EMAIL].Value == null ? "": dataGridViewUsuarios.CurrentRow.Cells[(int)Col_Usuario.EMAIL].Value.ToString();
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
                Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
