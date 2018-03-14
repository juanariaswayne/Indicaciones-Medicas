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

namespace Principal.Forms.MapaCama
{
    public partial class CambioClave : MetroForm
    {
        #region Variables        
        #endregion

        #region Funciones
        public CambioClave()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void CambioClave_Load(object sender, EventArgs e)
        {
            try
            {            

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                
                Seguridad.Encriptacion encripta = new Seguridad.Encriptacion();
                SISTMEDEntities E = new SISTMEDEntities();
                var clave = (from U in E.TBL_Usuarios
                        where U.Id_Usuario == Clases.Usuario.UsuarioLogeado.id_usuario_Logeado                     
                        select new {U.ContraseniaUsuario}).Single();

                if(txtClaveActual.Text.Trim() != encripta.DESENCRIPTAR(clave.ContraseniaUsuario))
                {
                    MetroMessageBox.Show(this, "La clave ingresada como actual es incorrecta");
                }
                else if (txtClaveNueva.Text.Trim() != txtClaveNueva2.Text.Trim())
                {
                    MetroMessageBox.Show(this, "Los campos de nueva clave deben ser iguales");
                }
                else
                {
                    E.Configuration.ValidateOnSaveEnabled = false;
                    TBL_Usuarios U = new TBL_Usuarios { Id_Usuario = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado,  ContraseniaUsuario = encripta.ENCRIPTAR(txtClaveNueva.Text)};
                    E.TBL_Usuarios.Attach(U);
                    E.Entry(U).Property(p => p.ContraseniaUsuario).IsModified = true;
                    E.SaveChanges();                   
                    this.Close();                    
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
