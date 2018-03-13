using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.MapaCama.Paciente
{
    public partial class Nuevo_Diagnostico : MetroForm
    {
        #region Variables
        public IActuDiagnosticos Opener { get; set; }
        #endregion

        #region Funciones
        public Nuevo_Diagnostico()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos        
        private void Nuevo_Diagnostico_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiagnostico.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar un diagnostico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SISTMEDEntities E = new SISTMEDEntities();
                    MED_Diagnosticos _item = new MED_Diagnosticos();
                    _item.Diagnostico = txtDiagnostico.Text;

                    E.Entry(_item).State = System.Data.Entity.EntityState.Added;
                    E.SaveChanges();
                    Opener.ActualizaDiagnosticos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
