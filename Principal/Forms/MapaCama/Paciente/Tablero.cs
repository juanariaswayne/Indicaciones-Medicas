using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.MapaCama.Paciente
{
    public partial class Tablero : MetroForm
    {
        #region Variables
        #endregion

        #region Funciones
        public Tablero()
        {
            InitializeComponent();
        }

        private void CargarPacientes()
        {
            try
            {

                SISTMEDEntities E = new SISTMEDEntities();
                foreach (var _item in E.Pacientes)
                {
                    int _hab = _item.paciente_id; 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        #endregion


        private void Tablero_Load(object sender, EventArgs e)
        {                      
            try
            {
                CargarPacientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
