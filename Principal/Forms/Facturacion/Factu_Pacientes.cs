using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.Facturacion
{
    public partial class Factu_Pacientes : MetroForm
    {
        SISTMEDEntities E = new SISTMEDEntities();

        private enum Col_Pacientes
        {
            ID = 0,
            HAB,
            PACIENTE
        }

        public Factu_Pacientes()
        {
            InitializeComponent();
        }

        private void traePacientes(int _sede)
        {
            try
            {
                gridPacientes.Rows.Clear();
                int indice;
                foreach (var _itemPaciente in E.Pacientes.Where(p => p.Habitaciones.sede_id == _sede && (p.fechaEgreso == null || p.fechaEgreso > DateTime.Now)).OrderBy(pac => pac.Habitaciones.descripcion))
                {
                    indice = gridPacientes.Rows.Add();

                    if (calculaAlertasMed(_itemPaciente.paciente_id) || calculaAlertasPro(_itemPaciente.paciente_id))
                    {
                        gridPacientes.Rows[indice].DefaultCellStyle.BackColor = Color.Yellow;

                        if(calculaAlertasMed(_itemPaciente.paciente_id))
                        {
                            _itemPaciente.nombre = _itemPaciente.nombre + " - (Med) ";
                        }
                        if (calculaAlertasPro(_itemPaciente.paciente_id))
                        {
                            _itemPaciente.nombre = _itemPaciente.nombre + " - (Proc) ";
                        }
                    }

                    gridPacientes.Rows[indice].Cells[(int)Col_Pacientes.ID].Value = _itemPaciente.paciente_id;
                    gridPacientes.Rows[indice].Cells[(int)Col_Pacientes.PACIENTE].Value = _itemPaciente.apellido.ToString().Trim() + " " + _itemPaciente.nombre.ToString().Trim();
                    gridPacientes.Rows[indice].Cells[(int)Col_Pacientes.HAB].Value = _itemPaciente.Habitaciones.descripcion.ToString();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool calculaAlertasMed(int _idPaciente)
        {
            try
            {
                DateTime _fechaAyer = DateTime.Now.AddDays(-1);
                bool _tieneAlerta = E.MED_Historial_SuministroDeMedicacion.Where(pac => pac.paciente_id == _idPaciente && pac.fechaModificacion.Value >= _fechaAyer).Count() > 0;               
                return _tieneAlerta ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;               
            }
        }

        private bool calculaAlertasPro(int _idPaciente)
        {
            try
            {
                DateTime _fechaAyer = DateTime.Now.AddDays(-1);               
                bool _tieneAlertaProc = E.PRO_SuministroDeProcedimiento_Historico.Where(pac => pac.paciente_id == _idPaciente && pac.fechaModificiacion.Value >= _fechaAyer).Count() > 0;
                return _tieneAlertaProc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void Factu_Pacientes_Load(object sender, EventArgs e)
        {
            traePacientes(cboSede.SelectedIndex + 1);

        }

        private void cboSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                traePacientes(cboSede.SelectedIndex + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void gridPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clases.Paciente.PacienteIngresado = Convert.ToInt32(gridPacientes.Rows[e.RowIndex].Cells[(int)Col_Pacientes.ID].Value);
                Clases.Paciente.PacienteNombre = gridPacientes.Rows[e.RowIndex].Cells[(int)Col_Pacientes.PACIENTE].Value.ToString();

                Facturacion.Factu_selectorPaciente _selector = new Factu_selectorPaciente();
                _selector.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridPacientes_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
