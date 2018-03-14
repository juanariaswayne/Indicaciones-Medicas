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
    public partial class ResumenIM : MetroForm
    {

        #region Variables
        SISTMEDEntities E = new SISTMEDEntities();

        private enum Col_Pacientes
        {
            ID = 0,
            HAB,
            PACIENTE
        }

        private enum Col_Medicamento
        {
            ID = 0,
            INICIO,
            ID_SUMINISTRO,
            MEDICAMENTO_ID,
            MEDICAMENTO,
            VIA,
            DILUYENTE,
            ML,
            DOSIS,
            HORARIO,
            DIAS,
            OBS,
            FIN
        }

        private enum Col_Procedimiento
        {          
            ID_PROCEDIMIENTO = 0,
            ID_GENERICO,
            INICIO,
            ID_SUMINISTRO,
            PROCEDIMIENTO,
            HORARIO,
            DIAS,
            OBS,  
            FIN,
            CHECK,
            TIPO
        }

        private enum Col_Descartables
        {
            ID_CIERRE = 0,
            ID_SUMINISTRO,
            COD_DESCARTABLE,
            DESCARTABLE,
            CANTIDAD,
            TIPO
        }
        #endregion

        #region Funciones
        public ResumenIM()
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

        private string HorarioSuministro(MED_Historial_SuministroDeMedicacion _itemMedicamento)
        {
            try
            {
                String _Horario;
                _Horario = "";
                if (_itemMedicamento.HS_24 == true) //Turno Noche
                {
                    _Horario = "24-" + _Horario;
                }
                if (_itemMedicamento.HS_23 == true )
                {
                    _Horario = "23-" + _Horario;
                }
                if (_itemMedicamento.HS_22 == true )
                {
                    _Horario = "22-" + _Horario;
                }
                if (_itemMedicamento.HS_21 == true )
                {
                    _Horario = "21-" + _Horario;
                }
                if (_itemMedicamento.HS_20 == true )
                {
                    _Horario = "20-" + _Horario;
                }
                if (_itemMedicamento.HS_19 == true )
                {
                    _Horario = "19-" + _Horario;
                }
                if (_itemMedicamento.HS_18 == true )
                {
                    _Horario = "18-" + _Horario;
                }
                if (_itemMedicamento.HS_17 == true )
                {
                    _Horario = "17-" + _Horario;
                }
                if (_itemMedicamento.HS_16 == true )
                {
                    _Horario = "16-" + _Horario;
                }
                if (_itemMedicamento.HS_15 == true )
                {
                    _Horario = "15-" + _Horario;
                }
                if (_itemMedicamento.HS_14 == true )
                {
                    _Horario = "14-" + _Horario;
                }
                if (_itemMedicamento.HS_13 == true )
                {
                    _Horario = "13-" + _Horario;
                }
                if (_itemMedicamento.HS_12 == true )
                {
                    _Horario = "12-" + _Horario;
                }
                if (_itemMedicamento.HS_11 == true )
                {
                    _Horario = "11-" + _Horario;
                }
                if (_itemMedicamento.HS_10 == true )
                {
                    _Horario = "10-" + _Horario;
                }
                if (_itemMedicamento.HS_09 == true )
                {
                    _Horario = "09-" + _Horario;
                }
                if (_itemMedicamento.HS_08 == true )
                {
                    _Horario = "08-" + _Horario;
                }
                if (_itemMedicamento.HS_07 == true )
                {
                    _Horario = "07-" + _Horario;
                }
                if (_itemMedicamento.HS_06 == true )
                {
                    _Horario = "06-" + _Horario;
                }
                if (_itemMedicamento.HS_05 == true )
                {
                    _Horario = "05-" + _Horario;
                }
                if (_itemMedicamento.HS_04 == true )
                {
                    _Horario = "04-" + _Horario;
                }
                if (_itemMedicamento.HS_03 == true )
                {
                    _Horario = "03-" + _Horario;
                }
                if (_itemMedicamento.HS_02 == true )
                {
                    _Horario = "02-" + _Horario;
                }
                if (_itemMedicamento.HS_01 == true )
                {
                    _Horario = "01-" + _Horario;
                }
                if (_itemMedicamento.HS_SH == true) //Otro horario
                {
                    _Horario = "Otro";
                }
                if (_itemMedicamento.evento != null)
                {
                    _Horario = _itemMedicamento.evento.ToString();
                }

                return _Horario;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DiasSuministro(MED_Historial_SuministroDeMedicacion _itemMedicamento)
        {
            try
            {
                String _Dias;
                _Dias = "";

                if (_itemMedicamento.L == true )
                {
                    _Dias = "Lunes" + _Dias;
                }
                if (_itemMedicamento.M == true )
                {
                    _Dias = "Martes" + _Dias;
                }
                if (_itemMedicamento.X == true )
                {
                    _Dias = "Miercoles" + _Dias;
                }
                if (_itemMedicamento.J == true)
                {
                    _Dias = "Jueves" + _Dias;
                }
                if (_itemMedicamento.V == true )
                {
                    _Dias = "Viernes" + _Dias;
                }
                if (_itemMedicamento.S == true )
                {
                    _Dias = "Sabado" + _Dias;
                }
                if (_itemMedicamento.D == true )
                {
                    _Dias = "Domingo" + _Dias;
                }
                if (_itemMedicamento.L == true && _itemMedicamento.M == true && _itemMedicamento.X == true && _itemMedicamento.J == true && _itemMedicamento.V == true && _itemMedicamento.S == true && _itemMedicamento.D == true)
                {
                    _Dias = "Todos los dias";
                }
                if (_itemMedicamento.L == false && _itemMedicamento.M == false && _itemMedicamento.X == false && _itemMedicamento.J == false && _itemMedicamento.V == false && _itemMedicamento.S == false && _itemMedicamento.D == false)
                {
                    _Dias = "Segun Necesidad";
                }

                return _Dias;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HorarioSuministroProc(PRO_SuministroDeProcedimiento_Historico _itemProcedimiento)
        {
            try
            {
                String _Horario;
                _Horario = "";
                if (_itemProcedimiento.h00 == true ) //Turno Noche
                {
                    _Horario = "24-" + _Horario;
                }
                if (_itemProcedimiento.h23 == true )
                {
                    _Horario = "23-" + _Horario;
                }
                if (_itemProcedimiento.h22 == true )
                {
                    _Horario = "22-" + _Horario;
                }
                if (_itemProcedimiento.h21 == true )
                {
                    _Horario = "21-" + _Horario;
                }
                if (_itemProcedimiento.h20 == true )
                {
                    _Horario = "20-" + _Horario;
                }
                if (_itemProcedimiento.h19 == true )
                {
                    _Horario = "19-" + _Horario;
                }
                if (_itemProcedimiento.h18 == true )
                {
                    _Horario = "18-" + _Horario;
                }
                if (_itemProcedimiento.h17 == true )
                {
                    _Horario = "17-" + _Horario;
                }
                if (_itemProcedimiento.h16 == true )
                {
                    _Horario = "16-" + _Horario;
                }
                if (_itemProcedimiento.h15 == true )
                {
                    _Horario = "15-" + _Horario;
                }
                if (_itemProcedimiento.h14 == true )
                {
                    _Horario = "14-" + _Horario;
                }
                if (_itemProcedimiento.h13 == true )
                {
                    _Horario = "13-" + _Horario;
                }
                if (_itemProcedimiento.h12 == true )
                {
                    _Horario = "12-" + _Horario;
                }
                if (_itemProcedimiento.h11 == true )
                {
                    _Horario = "11-" + _Horario;
                }
                if (_itemProcedimiento.h10 == true )
                {
                    _Horario = "10-" + _Horario;
                }
                if (_itemProcedimiento.h09 == true )
                {
                    _Horario = "09-" + _Horario;
                }
                if (_itemProcedimiento.h08 == true )
                {
                    _Horario = "08-" + _Horario;
                }
                if (_itemProcedimiento.h07 == true )
                {
                    _Horario = "07-" + _Horario;
                }
                if (_itemProcedimiento.h06 == true )
                {
                    _Horario = "06-" + _Horario;
                }
                if (_itemProcedimiento.h05 == true )
                {
                    _Horario = "05-" + _Horario;
                }
                if (_itemProcedimiento.h04 == true )
                {
                    _Horario = "04-" + _Horario;
                }
                if (_itemProcedimiento.h03 == true )
                {
                    _Horario = "03-" + _Horario;
                }
                if (_itemProcedimiento.h02 == true )
                {
                    _Horario = "02-" + _Horario;
                }
                if (_itemProcedimiento.h01 == true )
                {
                    _Horario = "01-" + _Horario;
                }
                if (_itemProcedimiento.SegunNecesidad == true) //Otro horario
                {
                    _Horario = "Segun Necesidad";
                }
                if (_itemProcedimiento.UnicaVez == true)
                {
                    _Horario = "Unica Vez";
                }
                if (_itemProcedimiento.h01 == false && _itemProcedimiento.h02 == false && _itemProcedimiento.h03 == false && _itemProcedimiento.h04 == false && _itemProcedimiento.h05 == false
                    && _itemProcedimiento.h06 == false && _itemProcedimiento.h07 == false
                    && _itemProcedimiento.h08 == false && _itemProcedimiento.h09 == false && _itemProcedimiento.h10 == false && _itemProcedimiento.h11 == false && _itemProcedimiento.h12 == false
                    && _itemProcedimiento.h13 == false && _itemProcedimiento.h14 == false && _itemProcedimiento.h15 == false && _itemProcedimiento.h16 == false && _itemProcedimiento.h17 == false
                    && _itemProcedimiento.h18 == false && _itemProcedimiento.h19 == false && _itemProcedimiento.h20 == false && _itemProcedimiento.h21 == false
                    && _itemProcedimiento.h22 == false && _itemProcedimiento.h23 == false && _itemProcedimiento.h00 == false && _itemProcedimiento.SegunNecesidad == null && _itemProcedimiento.UnicaVez == null)
                {
                    _Horario = "Segun Necesidadd";
                }

                return _Horario;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DiasSuministroProc(PRO_SuministroDeProcedimiento_Historico _itemProcedimiento)
        {
            try
            {
                String _Dias;
                _Dias = "";

                if (_itemProcedimiento.Lunes == true )
                {
                    _Dias = "Lunes-" + _Dias;
                }
                if (_itemProcedimiento.Martes == true )
                {
                    _Dias = "Martes-" + _Dias;
                }
                if (_itemProcedimiento.Miercoles == true )
                {
                    _Dias = "Miercoles-" + _Dias;
                }
                if (_itemProcedimiento.Jueves == true )
                {
                    _Dias = "Jueves-" + _Dias;
                }
                if (_itemProcedimiento.Viernes == true )
                {
                    _Dias = "Viernes-" + _Dias;
                }
                if (_itemProcedimiento.Sabado == true )
                {
                    _Dias = "Sabado-" + _Dias;
                }
                if (_itemProcedimiento.Domingo == true )
                {
                    _Dias = "Domingo" + _Dias;
                }
                if (_itemProcedimiento.SegunNecesidad == true)
                {
                    _Dias = "Segun Necesidadd" + _Dias;
                }
                if (_itemProcedimiento.Lunes == true && _itemProcedimiento.Martes == true && _itemProcedimiento.Miercoles == true && _itemProcedimiento.Jueves == true && _itemProcedimiento.Viernes == true && _itemProcedimiento.Sabado == true && _itemProcedimiento.Domingo == true)
                {
                    _Dias = "Todos los dias";
                }

                return _Dias;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObservacionNutricion(int _nutricionID)
        {
            try
            {
                string obs = E.PRO_Posologia.Find(_nutricionID).observacion.ToString();
                return obs;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void traeIndicacionMedicamentos(int _paciente)
        {
            try
            {              

                dataGridViewMedicamentos.Rows.Clear();
                int indice;
                foreach(var item in E.MED_Historial_SuministroDeMedicacion.Where(p=>p.paciente_id == _paciente && (p.fechaBaja >= dateDesde.Value && p.fechaBaja <= dateHasta.Value || p.fechaBaja == null)).OrderBy(med=>med.suministro_original))
                {
                    indice = dataGridViewMedicamentos.Rows.Add();
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.ID].Value = item.suministroDeMedicacion_id;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.INICIO].Value = item.fechaInicio.Value.ToShortDateString();
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.ID_SUMINISTRO].Value = item.suministro_original;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.MEDICAMENTO_ID].Value = item.medicamento_id;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.MEDICAMENTO].Value = item.MEDICAMENTO.descripcion_medicamento + " " + item.MEDICAMENTO.presentacion + " " + item.MEDICAMENTO.potencia;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.VIA].Value = item.MED_Via.descripcion;                 
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.DILUYENTE].Value = item.diluyente_id == 0 ? "" : item.MED_Diluyente.descripcion;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.ML].Value = item.ml;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.DOSIS].Value = item.dosis;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.HORARIO].Value = HorarioSuministro(item);
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.DIAS].Value = DiasSuministro(item);
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.OBS].Value = item.observacion;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.FIN].Value = item.fechaBaja == null? "": item.fechaBaja.Value.ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void traeIndicacioneProcedimientos(int _paciente)
        {
            dataGridViewProcedimientos.Rows.Clear();
            dataGridViewDescartables.Rows.Clear();
            int indice;
            foreach (var item in E.PRO_SuministroDeProcedimiento_Historico.Where(pro => pro.paciente_id == _paciente && (pro.fechaBaja >= dateDesde.Value && pro.fechaBaja <= dateHasta.Value || pro.fechaBaja == null)))
            {
                indice = dataGridViewProcedimientos.Rows.Add();
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value = item.suministro_original;
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value = item.procedimiento_id;
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_GENERICO].Value = item.generico_id;
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.INICIO].Value = item.fechaAltaSistema.Value.ToShortDateString();
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.PROCEDIMIENTO].Value = item.procedimiento_id == null? "SIN PROCEDIMIENTO": item.PRO_Procedimiento.descripcion;                         
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.FIN].Value = item.fechaBaja == null? "" : item.fechaBaja.Value.ToShortDateString();
                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.CHECK].Value = true;

                if (item.tipoProcedimiento_id == 3) //Procedimientos comunes
                {
                    if (HorarioSuministroProc(item) == "")
                    {
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = null;
                    }
                    else
                    {
                        string _Horario = HorarioSuministroProc(item).Substring(0, HorarioSuministroProc(item).Length - 1);
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = _Horario;
                    }

                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.DIAS].Value = DiasSuministroProc(item);
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.TIPO].Value = "COM";
                }
                else if (item.tipoProcedimiento_id == 2)//Nutricion
                {
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = "Segun necesidad";
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.DIAS].Value = "Todos los dias";
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value = item.posologia_id;
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.OBS].Value = ObservacionNutricion(item.posologia_id == null ? 0 : Convert.ToInt32(item.posologia_id));
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.TIPO].Value = "NUT";
                }
                else if (item.tipoProcedimiento_id == 8)// PHP
                {
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = "Segun necesidad";
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.DIAS].Value = "Todos los dias";
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value = item.php_id;
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.OBS].Value = "PHP";
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.TIPO].Value = "PHP";
                }

            }
        }
        #endregion

        #region Eventos
        private void ResumenIM_Load(object sender, EventArgs e)
        {
            try
            {
                cboSede.SelectedIndex = 2;
                traePacientes(cboSede.SelectedIndex + 1);
                dateDesde.Value = Convert.ToDateTime("01/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());
                dateHasta.Value = dateDesde.Value.AddMonths(1).AddDays(-1);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void gridPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clases.Paciente.PacienteIngresado = Convert.ToInt32(gridPacientes.Rows[e.RowIndex].Cells[(int)Col_Pacientes.ID].Value);
                traeIndicacionMedicamentos(Clases.Paciente.PacienteIngresado);
                traeIndicacioneProcedimientos(Clases.Paciente.PacienteIngresado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                traeIndicacionMedicamentos(Clases.Paciente.PacienteIngresado);
                traeIndicacioneProcedimientos(Clases.Paciente.PacienteIngresado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                traeIndicacionMedicamentos(Clases.Paciente.PacienteIngresado);
                traeIndicacioneProcedimientos(Clases.Paciente.PacienteIngresado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void gridPacientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //Clases.Paciente.PacienteIngresado = Convert.ToInt32(gridPacientes.CurrentRow.Cells[(int)Col_Pacientes.ID].Value);
                //traeIndicacionMedicamentos(Clases.Paciente.PacienteIngresado);
                //traeIndicacioneProcedimientos(Clases.Paciente.PacienteIngresado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProcedimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_GENERICO].Value != null)
                {
                    Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProcedimientoV2 _Generico = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProcedimientoV2();
                    _Generico.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value);
                    _Generico.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value);
                    _Generico.Tipo_Procedimiento_Id = 3;
                    _Generico.Generico_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_GENERICO].Value);
                    _Generico.Paciente_Id = Clases.Paciente.PacienteIngresado;
                    _Generico.Factu = true;
                    _Generico.ShowDialog();
                }
                else if (dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.TIPO].Value.ToString() == "NUT")
                {
                    Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Nutricion _Nutricion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Nutricion();
                    _Nutricion.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value);
                    _Nutricion.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value);
                    _Nutricion.Tipo_Procedimiento_Id = 2;
                    _Nutricion.Nutricion_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value);
                    _Nutricion.Paciente_Id = Clases.Paciente.PacienteIngresado;
                    _Nutricion.ShowDialog();
                }
                else if (dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.TIPO].Value.ToString() == "PHP")
                {
                    Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.PHPV2 _Php = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.PHPV2();
                    _Php.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value);
                    _Php.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value);
                    _Php.Tipo_Procedimiento_Id = 8;
                    //_Php.Php_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.PHP_ID].Value);
                    _Php.Paciente_Id = Clases.Paciente.PacienteIngresado;                    
                    _Php.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProcedimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                dataGridViewProcedimientos.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeDescartables(int _suministroID)
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();

                
                    var q = from asoc in E.PRO_Asociacion_Procedimiento
                            join art in E.ARTICULO on asoc.articulo_id equals art.art_CodGen
                            where asoc.suministro_procedimiento_id == _suministroID
                            select new { asoc, art };

                    int indice;
                    foreach (var _itemDescartable in q)
                    {
                        indice = dataGridViewDescartables.Rows.Add();
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _itemDescartable.asoc.suministro_procedimiento_id;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemDescartable.asoc.articulo_id;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = _itemDescartable.art.art_DescGen + " " + _itemDescartable.art.artele_Desc1 + " " + _itemDescartable.art.artele_Desc2;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = _itemDescartable.asoc.cantidad;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = _itemDescartable.asoc.tipo_articulo;
                        
                    }
                }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeDescartablesNutricion(int _suministroID, int _nutricionID)
        {
            var q = from n in E.PRO_Posologia
                    where n.posologia_id == _nutricionID
                    select n;

            int indice;
            foreach (var _itemNutricion in q)
            {
                if (_itemNutricion.alimento_id != "0")
                {
                    indice = dataGridViewDescartables.Rows.Add();
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _suministroID;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemNutricion.alimento_id;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = TraeDescripcionArticulo(_itemNutricion.alimento_id.ToString());
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = 1;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = "DES";
                   
                }
            }
            foreach (var _itemNutricion in q)
            {
                if (_itemNutricion.alimento_id2 != "0")
                {
                    indice = dataGridViewDescartables.Rows.Add();
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _suministroID;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemNutricion.alimento_id2;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = TraeDescripcionArticulo(_itemNutricion.alimento_id2.ToString());
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = 1;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = "DES";
                 
                }
            }
            foreach (var _itemNutricion in q)
            {
                if (_itemNutricion.alimento_id3 != "0")
                {
                    indice = dataGridViewDescartables.Rows.Add();
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _suministroID;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemNutricion.alimento_id3;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = TraeDescripcionArticulo(_itemNutricion.alimento_id3.ToString());
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = 1;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = "DES";
                  
                }
            }
            foreach (var _itemNutricion in q)
            {
                if (_itemNutricion.alimento_id4 != "0")
                {
                    indice = dataGridViewDescartables.Rows.Add();
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _suministroID;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemNutricion.alimento_id4;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = TraeDescripcionArticulo(_itemNutricion.alimento_id4.ToString());
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = 1;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = "DES";
                 
                }
            }
        }

        private string TraeDescripcionArticulo(string _articuloID)
        {
            try
            {
                string articulo = E.ARTICULO.Find(_articuloID).art_DescGen + " " + E.ARTICULO.Find(_articuloID).artele_Desc1 + " " + E.ARTICULO.Find(_articuloID).artele_Desc2;
                return articulo;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProcedimientos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == (int)Col_Procedimiento.CHECK)
                {
                    if (dataGridViewProcedimientos.CurrentRow != null)
                    {
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewProcedimientos.Rows[e.RowIndex].Cells[(int)Col_Procedimiento.CHECK] as DataGridViewCheckBoxCell;

                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            if (dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_GENERICO].Value != null)
                            {
                                TraeDescartables(Convert.ToInt32(dataGridViewProcedimientos.Rows[e.RowIndex].Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value));
                            }
                            else
                            {
                                TraeDescartablesNutricion(Convert.ToInt32(dataGridViewProcedimientos.Rows[e.RowIndex].Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value), Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value));
                            }

                        }

                        if (Convert.ToBoolean(cellSelecion.Value) == false)
                        {
                            for (int i = 0; i < dataGridViewDescartables.Rows.Count; i++)
                            {
                                if (Convert.ToInt32(dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value) == Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value))
                                {
                                    dataGridViewDescartables.Rows[i].Visible = false;
                                }
                            }

                            for (int i = 0; i < dataGridViewDescartables.Rows.Count; i++)
                            {
                                if (dataGridViewDescartables.Rows[i].Visible == false)
                                {
                                    dataGridViewDescartables.Rows.RemoveAt(i);
                                }
                            }
                        }
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
