using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Principal.Forms.Internacion.Hoteleria
{
    public partial class Hoteleria : MetroForm
    {
        #region Variables
        int _idPaciente;
        private enum Col_Pacientes
        {
            pertenenciaId = 0,
            pacienteId,
            motivoAltaId,
            estadoId,
            paciente,
            fechaEgreso,
            supEnfermeria,
            gobernante,
            cantBolsas,
            observaciones,
            estado,
            sede
        }
        #endregion

        #region Funciones
        public Hoteleria()
        {
            InitializeComponent();
        }

        public void TraePacientes()
        {
            try
            {
                BLL.Procedures.TRAEPACIENTESPERTENECIA _pacientes = new BLL.Procedures.TRAEPACIENTESPERTENECIA();
                this.dataGridViewPertenencias.Rows.Clear();
                int indice;
                if (_pacientes.ItemList().Count() == 0)
                {
                    MessageBox.Show("No existen registros de pertenencias guardadas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.ExitThread();
                }
                else
                {
                    foreach (Entities.Procedures.TRAEPACIENTESPERTENECIA item in _pacientes.ItemList())
                    {
                        indice = dataGridViewPertenencias.Rows.Add();
                        dataGridViewPertenencias.Rows[indice].Cells[(int)Col_Pacientes.pertenenciaId].Value = item.id;
                        dataGridViewPertenencias.Rows[indice].Cells[(int)Col_Pacientes.motivoAltaId].Value = item.estado_id;
                        dataGridViewPertenencias.Rows[indice].Cells[(int)Col_Pacientes.estadoId].Value = item.estado_id;
                        dataGridViewPertenencias.Rows[indice].Cells[(int)Col_Pacientes.pacienteId].Value = item.paciente_id;
                        dataGridViewPertenencias.Rows[indice].Cells[(int)Col_Pacientes.paciente].Value = item.nombrepaciente;
                        dataGridViewPertenencias.Rows[indice].Cells[(int)Col_Pacientes.fechaEgreso].Value = item.fechaalta;
                        dataGridViewPertenencias.Rows[indice].Cells[(int)Col_Pacientes.supEnfermeria].Value = item.supenfermeria;
                        dataGridViewPertenencias.Rows[indice].Cells[(int)Col_Pacientes.gobernante].Value = item.gobernante;
                        dataGridViewPertenencias.Rows[indice].Cells[(int)Col_Pacientes.cantBolsas].Value = item.cantbolsas;
                        dataGridViewPertenencias.Rows[indice].Cells[(int)Col_Pacientes.observaciones].Value = item.obssede;
                        dataGridViewPertenencias.Rows[indice].Cells[(int)Col_Pacientes.estado].Value = item.descripcion;
                        dataGridViewPertenencias.Rows[indice].Cells[(int)Col_Pacientes.sede].Value = item.sede;
                    }
                    _idPaciente = Convert.ToInt32(dataGridViewPertenencias.Rows[0].Cells[(int)Col_Pacientes.pacienteId].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstado()
        {
            try
            {
                BLL.Tables.ESTADOSPERTENENCIASPACIENTE _estado = new BLL.Tables.ESTADOSPERTENENCIASPACIENTE();
                _estado.ItemList();
                Entities.Tables.ESTADOSPERTENENCIASPACIENTE _itemSeleccion = new Entities.Tables.ESTADOSPERTENENCIASPACIENTE();

                //Limpia el combo
                this.cboEstado.SuspendLayout();
                this.cboEstado.DataSource = null;
                this.cboEstado.Items.Clear();

                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione Estado>";
                _itemSeleccion.ESTADO_ID = 0;
                _estado.Result.Insert(0, _itemSeleccion);

                //Carga el combo
                this.cboEstado.DisplayMember = BLL.Tables.ESTADOSPERTENENCIASPACIENTE.ColumnNames.DESCRIPCION;
                this.cboEstado.ValueMember = BLL.Tables.ESTADOSPERTENENCIASPACIENTE.ColumnNames.ESTADO_ID;
                this.cboEstado.DataSource = _estado.Result.ToArray();
                this.cboEstado.ResumeLayout();
                this.cboEstado.SelectedIndex = 0;             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpiar()
        {
            try
            {
                this.txtGobernante.Text = "";
                this.txtSupervisor.Text = "";
                this.metroTextBoxBolsas.Text = "";
                this.metroTextBoxObservacion.Text = "";
                this.cboEstado.ResumeLayout();
                this.cboEstado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        private void Hoteleria_Load(object sender, EventArgs e)
        {
            TraePacientes();
            CargarEstado();
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                {
                    Entities.Tables.PERTENENCIASPACIENTE _item = new Entities.Tables.PERTENENCIASPACIENTE();
                    BLL.Tables.PERTENENCIASPACIENTE _pertenenciaPaciente = new BLL.Tables.PERTENENCIASPACIENTE();
                    CultureInfo culture = new CultureInfo("en-US");
                    _item.ID = Convert.ToInt32(dataGridViewPertenencias.CurrentRow.Cells[(int)Col_Pacientes.pertenenciaId].Value);
                    _item.MOTIVOALTA_ID = Convert.ToInt32(dataGridViewPertenencias.CurrentRow.Cells[(int)Col_Pacientes.motivoAltaId].Value);                   
                    _item.PACIENTE_ID = Convert.ToInt32(dataGridViewPertenencias.CurrentRow.Cells[(int)Col_Pacientes.pacienteId].Value);
                    _item.NOMBREPACIENTE = dataGridViewPertenencias.CurrentRow.Cells[(int)Col_Pacientes.paciente].Value.ToString();
                    _item.FECHA_ALTA = Convert.ToDateTime(dataGridViewPertenencias.CurrentRow.Cells[(int)Col_Pacientes.fechaEgreso].Value.ToString());
                    _item.GOBERNANTE = this.txtGobernante.Text;
                    _item.SUPERVISORENF = this.txtSupervisor.Text;
                    _item.CANTBOLSAS = Convert.ToInt32(this.metroTextBoxBolsas.Text);
                    _item.OBSSEDE = this.metroTextBoxObservacion.Text;
                    _item.ESTADO_ID = Convert.ToInt32(this.cboEstado.SelectedValue);
                    _item.SEDE = dataGridViewPertenencias.CurrentRow.Cells[(int)Col_Pacientes.sede].Value.ToString();
                    _pertenenciaPaciente.UpdateItem(_item);
                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TraePacientes();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPertenencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0) {
                this.txtGobernante.Text = (dataGridViewPertenencias.Rows[e.RowIndex].Cells[(int)Col_Pacientes.gobernante].Value == null)? string.Empty: dataGridViewPertenencias.Rows[e.RowIndex].Cells[(int)Col_Pacientes.gobernante].Value.ToString();
                this.txtSupervisor.Text = (dataGridViewPertenencias.Rows[e.RowIndex].Cells[(int)Col_Pacientes.supEnfermeria].Value == null)? string.Empty: dataGridViewPertenencias.Rows[e.RowIndex].Cells[(int)Col_Pacientes.supEnfermeria].Value.ToString();
                this.metroTextBoxBolsas.Text = (dataGridViewPertenencias.Rows[e.RowIndex].Cells[(int)Col_Pacientes.cantBolsas].Value == null) ? string.Empty : dataGridViewPertenencias.Rows[e.RowIndex].Cells[(int)Col_Pacientes.cantBolsas].Value.ToString();
                this.metroTextBoxObservacion.Text = (dataGridViewPertenencias.Rows[e.RowIndex].Cells[(int)Col_Pacientes.observaciones].Value == null) ? string.Empty : dataGridViewPertenencias.Rows[e.RowIndex].Cells[(int)Col_Pacientes.observaciones].Value.ToString();
                this.metroLabelNombrePac.Text = (dataGridViewPertenencias.Rows[e.RowIndex].Cells[(int)Col_Pacientes.paciente].Value == null) ? string.Empty : dataGridViewPertenencias.Rows[e.RowIndex].Cells[(int)Col_Pacientes.paciente].Value.ToString();
                //this.cboEstado.SelectedIndex = Clases.Functions.SelectItemByValue(this.cboEstado, dataGridViewPertenencias.Rows[e.RowIndex].Cells[(int)Col_Pacientes.estadoId].Value.ToString()); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTextBoxBolsas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        private void Hoteleria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void dataGridViewPertenencias_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewPertenencias.IsCurrentCellDirty)
                dataGridViewPertenencias.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
