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
    public partial class PacientesDeAlta : MetroForm
    {

        #region Variables
        private enum Col_Pacietnes
        {
            PACIENTE_ID = 0,
            NOMBRE,
            HABITACION
        }

        SISTMEDEntities E = new SISTMEDEntities();
        SISTMEDEntities T = new SISTMEDEntities();
        
        #endregion

        #region Funciones
        public PacientesDeAlta()
        {
            InitializeComponent();
        }

        private void CargarHabitacionesLibres(DataGridViewComboBoxCell comboboxColumnSector, int _Sede)
        {
            try
            {
                List<TraeHabitacionesLibres_Result> _lista = T.TraeHabitacionesLibres(Clases.Paciente.PacienteSede,0,0).ToList();

                comboboxColumnSector.DataSource = null;
                comboboxColumnSector.Items.Clear();

                comboboxColumnSector.DataSource = _lista;
                comboboxColumnSector.ValueMember = "habitacion_id";
                comboboxColumnSector.DisplayMember = "descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        private void PacientesDeAlta_Load(object sender, EventArgs e)
        {
            try
            {
                                
                E.Pacientes.AsNoTracking();
                int indice;
                foreach (var _item in E.Pacientes.Where(p=>p.fechaEgreso != null)) //Traigo todos los pacientes de alta
                {
                    indice = dataGridViewPacientesAlta.Rows.Add();                   

                    dataGridViewPacientesAlta.Rows[indice].Cells[(int)Col_Pacietnes.PACIENTE_ID].Value = _item.paciente_id;
                    dataGridViewPacientesAlta.Rows[indice].Cells[(int)Col_Pacietnes.NOMBRE].Value = _item.apellido + " "+ _item.nombre;
                    //dataGridViewPacientesAlta.Rows[indice].Cells[(int)Col_Pacietnes.HABITACION].Value = _item.Habitaciones.descripcion;

                    DataGridViewRow row = dataGridViewPacientesAlta.Rows[indice];
                    DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Pacietnes.HABITACION] as DataGridViewComboBoxCell;
                    CargarHabitacionesLibres(comboboxColumnSector, Clases.Paciente.PacienteSede);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void btnReincorporar_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i = 0; i < dataGridViewPacientesAlta.Rows.Count; i++)
                {
                    if (dataGridViewPacientesAlta.Rows[i].Cells[(int)Col_Pacietnes.HABITACION].Value != null)
                    {
                        SISTMEDEntities E = new SISTMEDEntities();
                        E.Configuration.ValidateOnSaveEnabled = false;
                        Pacientes P = new Pacientes
                        {
                            paciente_id = Convert.ToInt32(dataGridViewPacientesAlta.Rows[i].Cells[(int)Col_Pacietnes.PACIENTE_ID].Value),
                            fechaEgreso = null,
                            habitacion_id = Convert.ToInt32(dataGridViewPacientesAlta.Rows[i].Cells[(int)Col_Pacietnes.HABITACION].Value),
                            sede_id = Clases.Paciente.PacienteSede
                        };
                        E.Pacientes.Attach(P);
                        E.Entry(P).Property(u => u.fechaEgreso).IsModified = true;
                        E.Entry(P).Property(u => u.sede_id).IsModified = true;
                        E.Entry(P).Property(u => u.habitacion_id).IsModified = true;
                        E.SaveChanges();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
