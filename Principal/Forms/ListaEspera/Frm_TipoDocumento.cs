using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Principal.Forms.ListaEspera
{
    public partial class Frm_TipoDocumento : MetroForm
    {
        #region Variables
         SISTMEDEntities _Mod = new  SISTMEDEntities();

        #endregion
        #region Funciones

       
        public Frm_TipoDocumento()
        {
            InitializeComponent();
        }
        private void CargarTipos()
        {
            try
            {
                var _tipos = (from Tipos in _Mod.TipoDocumento
                              orderby Tipos.descripcion
                              select Tipos).ToList();
                 //Carga el combo
                ComboBoxTipoDoc.DisplayMember = "Descripcion";
                ComboBoxTipoDoc.ValueMember = "tipoDocumento_id";
                ComboBoxTipoDoc.DataSource = _tipos.ToArray();
                ComboBoxTipoDoc.SelectedIndex = 0;

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }



        #endregion

        #region Eventos
        private void Frm_TipoDocumento_Load(object sender, EventArgs e)
        {
            CargarTipos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.TextBoxDescripcion.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar una Descripción para el nuevo Tipo de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    TipoDocumento _tipo = new TipoDocumento();
                    _tipo.descripcion = this.TextBoxDescripcion.Text;
                    _Mod.TipoDocumento.Add(_tipo);
                    _Mod.SaveChanges();

                    CargarTipos();
                    MessageBox.Show("Tipo de Documento creado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
