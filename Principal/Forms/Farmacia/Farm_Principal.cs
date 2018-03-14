using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace Principal.Forms.Farmacia
{
    
    public partial class Farm_Principal : MetroForm
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
            ID_CIERRE=0,
            ID_SUMINISTRO,
            ID_PROD,
            MEDICAMENTO,
            VIA,
            DOSIS,
            HORARIO,
            DIAS,
            OBS,
            CANT_APLICACIONES,
            MOTIVO,
            URGENCIA,
            MEDICO_URGENCIA,
            CHECK
        }

        private enum Col_Procedimiento
        {
            ID_CIERRE = 0,
            ID_SUMINISTRO,
            ID_PROCEDIMIENTO,
            ID_GENERICO,
            PROCEDIMIENTO,
            HORARIO,
            DIAS,
            OBS,
            APLICACIONES,
            MOTIVO,
            CHECK
        }

        private enum Col_Descartables
        {
            ID_CIERRE = 0,
            ID_SUMINISTRO,
            COD_DESCARTABLE,
            DESCARTABLE,
            CANTIDAD,
            TIPO,
            APLICACIONES,
            MOTIVO,
            CHECK
        }

        int _cantAplicaciones;
        bool _pvez = true;

        DataGridViewRowCollection colleccion_filas;


        #endregion

        #region Funciones

       
        public Farm_Principal()
        {
            InitializeComponent();
        }

        private void traePacientes(int _sede)
        {           
            try
            {
                int indice;
                foreach(var _itemPaciente in E.Pacientes.Where(p=>p.Habitaciones.sede_id == _sede && (p.fechaEgreso == null || p.fechaEgreso > DateTime.Now)).OrderBy(pac => pac.Habitaciones.descripcion))
                {
                    indice = gridPacientes.Rows.Add();
                    gridPacientes.Rows[indice].Cells[(int)Col_Pacientes.ID].Value = _itemPaciente.paciente_id;
                    gridPacientes.Rows[indice].Cells[(int)Col_Pacientes.PACIENTE].Value = _itemPaciente.apellido.ToString().Trim() +" "+ _itemPaciente.nombre.ToString().Trim();
                    gridPacientes.Rows[indice].Cells[(int)Col_Pacientes.HAB].Value = _itemPaciente.Habitaciones.descripcion.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HorarioSuministro(MED_SuministroDeMedicacion _itemMedicamento)
        {
            try
            {
                String _Horario;
                _Horario = "";
                if (_itemMedicamento.HS_24 == true && cboHorarios.SelectedIndex == 2) //Turno Noche
                {
                    _Horario = "24-" + _Horario;
                }
                if (_itemMedicamento.HS_23 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "23-" + _Horario;
                }
                if (_itemMedicamento.HS_22 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "22-" + _Horario;
                }
                if (_itemMedicamento.HS_21 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "21-" + _Horario;
                }
                if (_itemMedicamento.HS_20 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "20-" + _Horario;
                }
                if (_itemMedicamento.HS_19 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "19-" + _Horario;
                }
                if (_itemMedicamento.HS_18 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "18-" + _Horario;
                }
                if (_itemMedicamento.HS_17 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "17-" + _Horario;
                }
                if (_itemMedicamento.HS_16 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "16-" + _Horario;
                }
                if (_itemMedicamento.HS_15 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "15-" + _Horario;
                }
                if (_itemMedicamento.HS_14 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "14-" + _Horario;
                }
                if (_itemMedicamento.HS_13 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "13-" + _Horario;
                }
                if (_itemMedicamento.HS_12 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "12-" + _Horario;
                }
                if (_itemMedicamento.HS_11 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "11-" + _Horario;
                }
                if (_itemMedicamento.HS_10 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "10-" + _Horario;
                }
                if (_itemMedicamento.HS_09 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "09-" + _Horario;
                }
                if (_itemMedicamento.HS_08 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "08-" + _Horario;
                }
                if (_itemMedicamento.HS_07 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "07-" + _Horario;
                }
                if (_itemMedicamento.HS_06 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "06-" + _Horario;
                }
                if (_itemMedicamento.HS_05 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "05-" + _Horario;
                }
                if (_itemMedicamento.HS_04 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "04-" + _Horario;
                }
                if (_itemMedicamento.HS_03 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "03-" + _Horario;
                }
                if (_itemMedicamento.HS_02 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "02-" + _Horario;
                }
                if (_itemMedicamento.HS_01 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "01-" + _Horario;
                }
                if (_itemMedicamento.HS_SH == true) //Otro horario
                {
                    _Horario = "Otro";
                }
                if(_itemMedicamento.evento != null)
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

        private string DiasSuministro(MED_SuministroDeMedicacion _itemMedicamento)
        {
            try
            {
                String _Dias;
                _Dias = "";

                if (_itemMedicamento.L == true && dateFecha.Value.DayOfWeek == DayOfWeek.Monday)
                {
                    _Dias = "Lunes" + _Dias;
                }
                if (_itemMedicamento.M == true && dateFecha.Value.DayOfWeek == DayOfWeek.Tuesday)
                {
                    _Dias = "Martes" + _Dias;
                }
                if (_itemMedicamento.X == true && dateFecha.Value.DayOfWeek == DayOfWeek.Wednesday)
                {
                    _Dias = "Miercoles" + _Dias;
                }
                if (_itemMedicamento.J == true && dateFecha.Value.DayOfWeek == DayOfWeek.Thursday)
                {
                    _Dias = "Jueves" + _Dias;
                }
                if (_itemMedicamento.V == true && dateFecha.Value.DayOfWeek == DayOfWeek.Friday)
                {
                    _Dias = "Viernes" + _Dias;
                }
                if (_itemMedicamento.S == true && dateFecha.Value.DayOfWeek == DayOfWeek.Saturday)
                {
                    _Dias = "Sabado" + _Dias;
                }
                if (_itemMedicamento.D == true && dateFecha.Value.DayOfWeek == DayOfWeek.Sunday)
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

        private string HorarioSuministroProc(PRO_SuministroDeProcedimiento _itemProcedimiento)
        {
            try
            {
                String _Horario;
                _Horario = "";
                if (_itemProcedimiento.h00 == true && cboHorarios.SelectedIndex == 2) //Turno Noche
                {
                    _Horario = "24-" + _Horario;
                }
                if (_itemProcedimiento.h23 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "23-" + _Horario;
                }
                if (_itemProcedimiento.h22 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "22-" + _Horario;
                }
                if (_itemProcedimiento.h21 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "21-" + _Horario;
                }
                if (_itemProcedimiento.h20 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "20-" + _Horario;
                }
                if (_itemProcedimiento.h19 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "19-" + _Horario;
                }
                if (_itemProcedimiento.h18 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "18-" + _Horario;
                }
                if (_itemProcedimiento.h17 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "17-" + _Horario;
                }
                if (_itemProcedimiento.h16 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "16-" + _Horario;
                }
                if (_itemProcedimiento.h15 == true && cboHorarios.SelectedIndex == 1)
                {
                    _Horario = "15-" + _Horario;
                }
                if (_itemProcedimiento.h14 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "14-" + _Horario;
                }
                if (_itemProcedimiento.h13 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "13-" + _Horario;
                }
                if (_itemProcedimiento.h12 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "12-" + _Horario;
                }
                if (_itemProcedimiento.h11 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "11-" + _Horario;
                }
                if (_itemProcedimiento.h10 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "10-" + _Horario;
                }
                if (_itemProcedimiento.h09 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "09-" + _Horario;
                }
                if (_itemProcedimiento.h08 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "08-" + _Horario;
                }
                if (_itemProcedimiento.h07 == true && cboHorarios.SelectedIndex == 0)
                {
                    _Horario = "07-" + _Horario;
                }
                if (_itemProcedimiento.h06 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "06-" + _Horario;
                }
                if (_itemProcedimiento.h05 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "05-" + _Horario;
                }
                if (_itemProcedimiento.h04 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "04-" + _Horario;
                }
                if (_itemProcedimiento.h03 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "03-" + _Horario;
                }
                if (_itemProcedimiento.h02 == true && cboHorarios.SelectedIndex == 2)
                {
                    _Horario = "02-" + _Horario;
                }
                if (_itemProcedimiento.h01 == true && cboHorarios.SelectedIndex == 2)
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
                if(_itemProcedimiento.h01 == false && _itemProcedimiento.h02 == false && _itemProcedimiento.h03 == false && _itemProcedimiento.h04 == false && _itemProcedimiento.h05 == false 
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

        private string DiasSuministroProc(PRO_SuministroDeProcedimiento _itemProcedimiento)
        {
            try
            {
                String _Dias;
                _Dias = "";

                if (_itemProcedimiento.Lunes == true && dateFecha.Value.DayOfWeek == DayOfWeek.Monday)
                {
                    _Dias = "Lunes" + _Dias;
                }
                if (_itemProcedimiento.Martes == true && dateFecha.Value.DayOfWeek == DayOfWeek.Tuesday)
                {
                    _Dias = "Martes" + _Dias;
                }
                if (_itemProcedimiento.Miercoles == true && dateFecha.Value.DayOfWeek == DayOfWeek.Wednesday)
                {
                    _Dias = "Miercoles" + _Dias;
                }
                if (_itemProcedimiento.Jueves == true && dateFecha.Value.DayOfWeek == DayOfWeek.Thursday)
                {
                    _Dias = "Jueves" + _Dias;
                }
                if (_itemProcedimiento.Viernes == true && dateFecha.Value.DayOfWeek == DayOfWeek.Friday)
                {
                    _Dias = "Viernes" + _Dias;
                }
                if (_itemProcedimiento.Sabado == true && dateFecha.Value.DayOfWeek == DayOfWeek.Saturday)
                {
                    _Dias = "Sabado" + _Dias;
                }
                if (_itemProcedimiento.Domingo == true && dateFecha.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    _Dias = "Domingo" + _Dias;
                }
                if (_itemProcedimiento.SegunNecesidad == true)
                {
                    _Dias = "Segun Necesidad" + _Dias;
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

        private void CargarEstados(DataGridViewComboBoxCell comboboxColumnSector)
        {
            try
            {              

                //Carga el combo
                comboboxColumnSector.DataSource = E.FARM_MOTIVO.ToList();
                comboboxColumnSector.DisplayMember = "descripcion_motivo";
                comboboxColumnSector.ValueMember = "id_motivo";
                

                //FIN CARGO COMBO TIPO RECLAMO

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void TraeMedicacionPorTurno()
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();
                dataGridViewMedicamentos.Rows.Clear();

                var existeFecha = (from f in E.FARM_DIARIO select new
                {
                    cierre=f.id_cierre,                    
                    fechaCarga = f.fecha_carga,
                    paciente = f.paciente_id,
                    turno = f.Turno,
                    tipo = f.tipo
                    
                }).ToList().Select(x=> new
                {
                    cierre = x.cierre,
                    fechaCarga = string.Format("{0:dd/MM/yyyy}", x.fechaCarga),
                    paciente = x.paciente,
                    turno = x.turno,
                    tipo = x.tipo
                });

                    if (E.FARM_DIARIO.Count() > 0 && existeFecha.ToList().Where(f => f.fechaCarga == dateFecha.Value.ToShortDateString() && f.paciente == Clases.Paciente.PacienteIngresado && f.turno == cboHorarios.Text && f.tipo == "MED").Count() > 0) //Ya existe algun ingreso para ese paciente
                    {
                        var q = (from ci in E.FARM_DIARIO
                                join sm in E.MED_SuministroDeMedicacion on ci.suministro_id equals sm.suministroDeMedicacion_id
                                join mel in E.MEDICAMENTO on ci.producto_id equals mel.medicamento_id
                                join v in E.MED_Via on sm.via_id equals v.via_id
                                where ci.paciente_id == Clases.Paciente.PacienteIngresado && ci.Turno == cboHorarios.Text && ci.tipo == "MED"
                                select new { sm, ci, mel,v, fecha=ci.fecha_carga }).ToList().Select(x=> new
                                {
                                    sm = x.sm,
                                    ci = x.ci,
                                    mel = x.mel,
                                    v = x.v,
                                    fecha = string.Format("{0:dd/MM/yyyy}", x.fecha)
                                }                                
                                );

                        int indice;
                        foreach (var _itemMedicamento in q.Where(f=>f.fecha == dateFecha.Value.ToShortDateString()))
                        {
                            indice = dataGridViewMedicamentos.Rows.Add();
                            dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.ID_CIERRE].Value = _itemMedicamento.ci.id_cierre;
                            dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.ID_SUMINISTRO].Value = _itemMedicamento.sm.suministroDeMedicacion_id;
                            dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.ID_PROD].Value = _itemMedicamento.sm.medicamento_id; //ACA LUEGO HACER RELACION CON TABLA MEDICAMENTO
                            dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.MEDICAMENTO].Value = _itemMedicamento.mel.descripcion_medicamento +" "+ _itemMedicamento.mel.potencia+" "+"("+_itemMedicamento.sm.dosis+" "+ _itemMedicamento.mel.presentacion+")"; //ACA LUEGO HACER RELACION CON TABLA MEDICAMENTO
                            dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.VIA].Value = _itemMedicamento.v.descripcion; //ACA HACER RELACION CON TABLA DE VIA
                            dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.DOSIS].Value = _itemMedicamento.sm.dosis;
                            dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.OBS].Value = _itemMedicamento.sm.observacion;
                            dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.CANT_APLICACIONES].Value = _itemMedicamento.ci.cantidad_aplicaciones;
                            
                            _cantAplicaciones = Convert.ToInt32(_itemMedicamento.ci.cantidad_aplicaciones);

                        if (_itemMedicamento.ci.cantidad_aplicaciones > 0)
                            {
                                dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.CHECK].Value = true;
                            }

                            if (HorarioSuministro(_itemMedicamento.sm) == "")
                            {
                                dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.HORARIO].Value = null;
                            }
                            else
                            {
                                if (HorarioSuministro(_itemMedicamento.sm) == "Otro")
                                {
                                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.HORARIO].Value = _itemMedicamento.sm.horarioOtro.ToUpper();
                                }
                                else
                                {
                                    string _Horario = HorarioSuministro(_itemMedicamento.sm).Substring(0, HorarioSuministro(_itemMedicamento.sm).Length - 1);
                                    if (_itemMedicamento.sm.viaTieneOtro == true)
                                    {
                                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.HORARIO].Value = _Horario + " // " + _itemMedicamento.sm.viaOtro.ToUpper();
                                    }
                                    else
                                    {
                                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.HORARIO].Value = _Horario;
                                    }
                                }
                            }

                            dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.DIAS].Value = DiasSuministro(_itemMedicamento.sm);

                        DataGridViewRow row = dataGridViewMedicamentos.Rows[indice];
                        DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Medicamento.MOTIVO] as DataGridViewComboBoxCell;
                        CargarEstados(comboboxColumnSector);

                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.MOTIVO].Value = _itemMedicamento.ci.motivo;
                    }
                        chckCierre.Show();                       
                }                
                else
                {
                    int indice;
                    var q = from med in E.MED_SuministroDeMedicacion
                            join m in E.MEDICAMENTO on med.medicamento_id equals m.medicamento_id
                            join v in E.MED_Via on med.via_id equals v.via_id
                            where med.paciente_id == Clases.Paciente.PacienteIngresado && (med.fechaBaja > DateTime.Now || med.fechaBaja == null)
                            select new { med, m, v };

                    foreach (var _itemMedicamento in q)
                    {
                        indice = dataGridViewMedicamentos.Rows.Add();
                        //dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.ID_CIERRE].Value = -1; //Todavia no seteo el cierre
                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.ID_SUMINISTRO].Value = _itemMedicamento.med.suministroDeMedicacion_id;
                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.ID_PROD].Value = _itemMedicamento.med.medicamento_id; //ACA LUEGO HACER RELACION CON TABLA MEDICAMENTO
                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.MEDICAMENTO].Value = _itemMedicamento.m.descripcion_medicamento + " " + _itemMedicamento.m.potencia + " "+"("+_itemMedicamento.med.dosis+" "+ _itemMedicamento.m.presentacion+")"; //ACA LUEGO HACER RELACION CON TABLA MEDICAMENTO
                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.VIA].Value = _itemMedicamento.v.descripcion; //ACA HACER RELACION CON TABLA DE VIA
                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.DOSIS].Value = _itemMedicamento.med.dosis;
                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.OBS].Value = _itemMedicamento.med.observacion;

                        if (HorarioSuministro(_itemMedicamento.med) == "")
                        {
                            dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.HORARIO].Value = null;
                        }
                        else
                        {
                            if (HorarioSuministro(_itemMedicamento.med) == "Otro")
                            {
                                dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.HORARIO].Value = _itemMedicamento.med.horarioOtro.ToUpper();
                            }
                            else
                            {
                                string _Horario = HorarioSuministro(_itemMedicamento.med).Substring(0, HorarioSuministro(_itemMedicamento.med).Length - 1);
                                if (_itemMedicamento.med.viaTieneOtro == true)
                                {
                                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.HORARIO].Value = _Horario + " // " + _itemMedicamento.med.viaOtro.ToUpper();
                                }
                                else
                                {
                                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.HORARIO].Value = _Horario;
                                }
                            }
                        }

                        dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.DIAS].Value = DiasSuministro(_itemMedicamento.med);

                    }

                    chckCierre.Hide();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeProcedimientosPorTurno()
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();
                dataGridViewProcedimientos.Rows.Clear();

                var existeFecha = (from f in E.FARM_DIARIO
                                   select new
                                   {
                                       cierre = f.id_cierre,
                                       fechaCarga = f.fecha_carga,
                                       paciente = f.paciente_id,
                                       turno = f.Turno,
                                       tipo = f.tipo

                                   }).ToList().Select(x => new
                                   {
                                       cierre = x.cierre,
                                       fechaCarga = string.Format("{0:dd/MM/yyyy}", x.fechaCarga),
                                       paciente = x.paciente,
                                       turno = x.turno,
                                       tipo = x.tipo
                                   });

                if (E.FARM_DIARIO.Count() > 0 && existeFecha.ToList().Where(f => f.fechaCarga == dateFecha.Value.ToShortDateString() && f.paciente == Clases.Paciente.PacienteIngresado && f.turno == cboHorarios.Text && f.tipo == "PRO").Count() > 0) //Ya existe algun ingreso para ese paciente
                {
                    var q = (from ci in E.FARM_DIARIO
                             join sm in E.PRO_SuministroDeProcedimiento on ci.suministro_id equals sm.suministroDeProcedimiento_id
                             join gen in E.PRO_Generico on sm.generico_id equals gen.generico_id
                             where ci.paciente_id == Clases.Paciente.PacienteIngresado && ci.Turno == cboHorarios.Text && ci.tipo == "PRO"
                             select new { sm, ci,gen, fecha = ci.fecha_carga }).ToList().Select(x => new
                             {
                                 sm = x.sm,
                                 ci = x.ci,
                                 gen = x.gen,
                                 fecha = string.Format("{0:dd/MM/yyyy}", x.fecha)
                             }
                             );

                    int indice;
                    foreach (var _itemProcedimiento in q.Where(f => f.fecha == dateFecha.Value.ToShortDateString()))
                    {
                        indice = dataGridViewProcedimientos.Rows.Add();
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_CIERRE].Value = _itemProcedimiento.ci.id_cierre;
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value = _itemProcedimiento.ci.suministro_id;
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value = _itemProcedimiento.sm.PRO_Procedimiento.procedimiento_id;
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.PROCEDIMIENTO].Value = _itemProcedimiento.sm.PRO_Procedimiento.descripcion;
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_GENERICO].Value = _itemProcedimiento.sm.generico_id;
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.OBS].Value = _itemProcedimiento.gen.observacion;

                        if (_itemProcedimiento.ci.cantidad_aplicaciones > 0)
                        {
                            dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.CHECK].Value = true;
                           // dataGridViewDescartables.Rows.Clear();
                           // TraeDescartables(Convert.ToInt32(dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value));
                        }
                        else
                        {
                            dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.CHECK].Value = false;
                        }

                        if (HorarioSuministroProc(_itemProcedimiento.sm) == "")
                        {
                            dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = null;
                        }
                        else
                        {
                            string _Horario = HorarioSuministroProc(_itemProcedimiento.sm).Substring(0, HorarioSuministroProc(_itemProcedimiento.sm).Length - 1);
                            dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = _Horario;
                        }

                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.DIAS].Value = DiasSuministroProc(_itemProcedimiento.sm);

                        DataGridViewRow row = dataGridViewProcedimientos.Rows[indice];
                        DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Procedimiento.MOTIVO] as DataGridViewComboBoxCell;
                        CargarEstados(comboboxColumnSector);

                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.MOTIVO].Value = _itemProcedimiento.ci.motivo;

                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.APLICACIONES].Value = _itemProcedimiento.ci.cantidad_aplicaciones;
                    }

                    chckCierre.Show();
                }
                else
                {
                    dataGridViewDescartables.Rows.Clear();                   
                    int indice;
                    foreach (var _itemProcedimiento in E.PRO_SuministroDeProcedimiento.Where(m => m.paciente_id == Clases.Paciente.PacienteIngresado && (m.fechaBaja > DateTime.Now || m.fechaBaja == null)))
                    {
                        indice = dataGridViewProcedimientos.Rows.Add();                       
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value = _itemProcedimiento.suministroDeProcedimiento_id;
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value = _itemProcedimiento.procedimiento_id; //ACA LUEGO HACER RELACION CON TABLA MEDICAMENTO
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.PROCEDIMIENTO].Value = _itemProcedimiento.PRO_Procedimiento.descripcion; //ACA LUEGO HACER RELACION CON TABLA MEDICAMENTO       
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_GENERICO].Value = _itemProcedimiento.generico_id; //ACA LUEGO HACER RELACION CON TABLA MEDICAMENTO
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.CHECK].Value = false;
                        dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.OBS].Value = ObservacionProcedimiento(_itemProcedimiento.generico_id == null?0:Convert.ToInt32(_itemProcedimiento.generico_id));

                        if (_itemProcedimiento.tipoProcedimiento_id == 3) //Procedimientos comunes
                        {
                            if (HorarioSuministroProc(_itemProcedimiento) == "")
                            {
                                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = null;
                            }
                            else
                            {
                                string _Horario = HorarioSuministroProc(_itemProcedimiento).Substring(0, HorarioSuministroProc(_itemProcedimiento).Length - 1);
                                dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = _Horario;
                            }

                            dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.DIAS].Value = DiasSuministroProc(_itemProcedimiento);
                        }
                        else if(_itemProcedimiento.tipoProcedimiento_id == 2)//Nutricion
                        {                            
                            dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.HORARIO].Value = "Segun necesidad";
                            dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.DIAS].Value = "Todos los dias";
                            dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value = _itemProcedimiento.posologia_id;
                            dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.OBS].Value = ObservacionNutricion(_itemProcedimiento.posologia_id == null ? 0 : Convert.ToInt32(_itemProcedimiento.posologia_id));
                        }                        

                    }
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObservacionProcedimiento(int _genericoID)
        {
            try
            {
                string obs = E.PRO_Generico.Find(_genericoID).observacion.ToString();
                return obs;
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

        private void TraeDescartables(int _suministroID)
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();

                var existeFecha = (from f in E.FARM_DIARIO
                                   select new
                                   {
                                       cierre = f.id_cierre,
                                       fechaCarga = f.fecha_carga,
                                       paciente = f.paciente_id,
                                       turno = f.Turno,
                                       tipo = f.tipo,
                                       suministro = f.suministro_id

                                   }).ToList().Select(x => new
                                   {
                                       cierre = x.cierre,
                                       fechaCarga = string.Format("{0:dd/MM/yyyy}", x.fechaCarga),
                                       paciente = x.paciente,
                                       turno = x.turno,
                                       tipo = x.tipo,
                                       suministro = x.suministro
                                   });

                if (E.FARM_DIARIO.Count() > 0 && existeFecha.ToList().Where(f => f.fechaCarga == dateFecha.Value.ToShortDateString() && f.paciente == Clases.Paciente.PacienteIngresado && f.turno == cboHorarios.Text && f.tipo == "DES" && f.suministro == _suministroID).Count() > 0)
                {
                    var q = (from ci in E.FARM_DIARIO                             
                             join art in E.ARTICULO on ci.producto_id equals art.art_CodGen
                             where ci.paciente_id == Clases.Paciente.PacienteIngresado && ci.Turno == cboHorarios.Text && ci.tipo == "DES" && ci.suministro_id == _suministroID
                             select new { ci,art, fecha = ci.fecha_carga }).ToList().Select(x => new
                             {                                                                 
                                 ci = x.ci,
                                 art = x.art,
                                 fecha = string.Format("{0:dd/MM/yyyy}", x.fecha)
                             }
                            ).GroupBy(i=>i.ci.id_cierre).Select(grp=>grp.First());
                    int indice;
                    foreach (var _itemDescartable in q.Where(f=>f.fecha == dateFecha.Value.ToShortDateString()))
                    {
                        indice = dataGridViewDescartables.Rows.Add();
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_CIERRE].Value = _itemDescartable.ci.id_cierre;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _itemDescartable.ci.suministro_id;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemDescartable.ci.producto_id;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = _itemDescartable.art.art_DescGen + " "+ _itemDescartable.art.artele_Desc1 + " "+ _itemDescartable.art.artele_Desc2;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = _itemDescartable.ci.cantidad_aplicaciones;
                        //dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = _itemDescartable.tipo_articulo;

                        if(_itemDescartable.ci.cantidad_aplicaciones > 0)
                        {
                            dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CHECK].Value = true;
                        }
                        else
                        {
                            dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CHECK].Value = false;
                        }

                        DataGridViewRow row = dataGridViewDescartables.Rows[indice];
                        DataGridViewComboBoxCell comboboxColumnSector = row.Cells[(int)Col_Descartables.MOTIVO] as DataGridViewComboBoxCell;
                        CargarEstados(comboboxColumnSector);

                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.MOTIVO].Value = _itemDescartable.ci.motivo;

                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.APLICACIONES].Value = _itemDescartable.ci.cantidad_aplicaciones;
                    }                   
                }
                else
                {
                    var q = from asoc in E.PRO_Asociacion_Procedimiento
                            join art in E.ARTICULO on asoc.articulo_id equals art.art_CodGen
                            where asoc.suministro_procedimiento_id == _suministroID
                            select new { asoc, art };

                    int indice;
                    foreach(var _itemDescartable in q)
                    {
                        indice = dataGridViewDescartables.Rows.Add();
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _itemDescartable.asoc.suministro_procedimiento_id;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemDescartable.asoc.articulo_id;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = _itemDescartable.art.art_DescGen + " " + _itemDescartable.art.artele_Desc1 + " "+ _itemDescartable.art.artele_Desc2;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = _itemDescartable.asoc.cantidad;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = _itemDescartable.asoc.tipo_articulo;
                        dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CHECK].Value = true;
                    }
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
            foreach(var _itemNutricion in q)
            {
                if(_itemNutricion.alimento_id != "0")
                {
                    indice = dataGridViewDescartables.Rows.Add();
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value = _suministroID;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value = _itemNutricion.alimento_id;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.DESCARTABLE].Value = TraeDescripcionArticulo(_itemNutricion.alimento_id.ToString());
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CANTIDAD].Value = 1;
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.TIPO].Value = "DES";
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CHECK].Value = true;
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
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CHECK].Value = true;
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
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CHECK].Value = true;
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
                    dataGridViewDescartables.Rows[indice].Cells[(int)Col_Descartables.CHECK].Value = true;
                }
            }
        }

        private string TraeDescripcionArticulo(string _articuloID)
        {
            try
            {
                string articulo = E.ARTICULO.Find(_articuloID).art_DescGen +" "+ E.ARTICULO.Find(_articuloID).artele_Desc1 +" "+ E.ARTICULO.Find(_articuloID).artele_Desc2;
                return articulo;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void guardaCierre() //Guardo un registro completo de lo que se aplico ese dia o lo que no se aplico
        {
            SISTMEDEntities E = new SISTMEDEntities();
            using (var dbContextTransaction= E.Database.BeginTransaction())
                try
                {
                    E.Configuration.ValidateOnSaveEnabled = false;
                    #region GuardaMedicacion
                    for (int i = 0; i < dataGridViewMedicamentos.Rows.Count; i++)
                    {
                        if (dataGridViewMedicamentos.Rows[i].Visible == true)
                        {
                            FARM_DIARIO _itemFarma = new FARM_DIARIO();

                            _itemFarma.suministro_id = Convert.ToInt32(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamento.ID_SUMINISTRO].Value);
                            _itemFarma.fecha_carga = dateFecha.Value;
                            _itemFarma.usuario_carga = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                            _itemFarma.producto_id = dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamento.ID_PROD].Value.ToString();
                            _itemFarma.paciente_id = Clases.Paciente.PacienteIngresado;
                            _itemFarma.Turno = cboHorarios.Text;
                            _itemFarma.tipo = "MED";

                            if (dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamento.CHECK].Value != null && (bool)dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamento.CHECK].Value == true)//Se dio el medicamento a farmacia
                            {                                
                                _itemFarma.cantidad_aplicaciones = dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamento.HORARIO].Value.ToString().Count(a => a == '-') + 1;                               
                            }
                            else //No se dio el medicamento a farmacia
                            {                                    
                                _itemFarma.cantidad_aplicaciones = 0; //No se aplico nada      
                            }

                            if(chckCierre.Checked)
                            {
                                _itemFarma.usuario_cierre = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                                _itemFarma.fecha_cierre = DateTime.Now;
                                _itemFarma.cerrado = true;
                                _itemFarma.motivo = dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamento.MOTIVO].Value == null? 0 : Convert.ToInt32(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamento.MOTIVO].Value);
                            }

                            if (dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamento.ID_CIERRE].Value != null)//Ya existe el registro
                            {
                                _itemFarma.id_cierre = Convert.ToInt32(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamento.ID_CIERRE].Value);
                                E.Entry(_itemFarma).State = System.Data.Entity.EntityState.Modified;
                            }
                            else
                            {
                                E.FARM_DIARIO.Add(_itemFarma);
                            }
                        }

                    }
                    #endregion
                    #region GuardaProcedimientos
                    for (int i = 0; i < dataGridViewProcedimientos.Rows.Count; i++)
                    {
                        if (dataGridViewProcedimientos.Rows[i].Visible == true)
                        {
                            FARM_DIARIO _itemFarmaProc = new FARM_DIARIO();

                            _itemFarmaProc.suministro_id = Convert.ToInt32(dataGridViewProcedimientos.Rows[i].Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value);
                            _itemFarmaProc.fecha_carga = DateTime.Now;
                            _itemFarmaProc.usuario_carga = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                            _itemFarmaProc.producto_id = "";
                            _itemFarmaProc.paciente_id = Clases.Paciente.PacienteIngresado;
                            _itemFarmaProc.Turno = cboHorarios.Text;
                            _itemFarmaProc.tipo = "PRO";

                            if (dataGridViewProcedimientos.Rows[i].Cells[(int)Col_Procedimiento.CHECK].Value != null && (bool)dataGridViewProcedimientos.Rows[i].Cells[(int)Col_Procedimiento.CHECK].Value == true)//Se dio el procedimiento
                            {
                                //Grabo el procedimiento y luego los descartables aplicados                                
                                _itemFarmaProc.cantidad_aplicaciones = 1; //Se aplico el procedimiento sin descartables                                
                            }
                            else //No se dio el procedimiento a farmacia
                            {                               
                                _itemFarmaProc.cantidad_aplicaciones = 0; //No se aplico nada                               
                            }

                            if (dataGridViewProcedimientos.Rows[i].Cells[(int)Col_Procedimiento.ID_CIERRE].Value != null)//Ya existe el registro
                            {
                                _itemFarmaProc.id_cierre = Convert.ToInt32(dataGridViewProcedimientos.Rows[i].Cells[(int)Col_Procedimiento.ID_CIERRE].Value);
                                E.Entry(_itemFarmaProc).State = System.Data.Entity.EntityState.Modified;
                            }
                            else
                            {
                                E.FARM_DIARIO.Add(_itemFarmaProc);
                            }
                        }
                    }
                    #endregion
                    #region GuardaDescartables
                    for (int i = 0; i < dataGridViewDescartables.Rows.Count; i++)
                    {
                        if (dataGridViewDescartables.Rows[i].Visible == true)
                        {
                            FARM_DIARIO _itemFarmaDesc = new FARM_DIARIO();

                            _itemFarmaDesc.suministro_id = Convert.ToInt32(dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.ID_SUMINISTRO].Value);
                            _itemFarmaDesc.fecha_carga = DateTime.Now;
                            _itemFarmaDesc.usuario_carga = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                            _itemFarmaDesc.producto_id = dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.COD_DESCARTABLE].Value.ToString();
                            _itemFarmaDesc.paciente_id = Clases.Paciente.PacienteIngresado;
                            _itemFarmaDesc.Turno = cboHorarios.Text;
                            _itemFarmaDesc.tipo = "DES";

                            if (dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.CHECK].Value != null && (bool)dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.CHECK].Value == true)//Se dio el procedimiento
                            {
                                //Grabo el procedimiento y luego los descartables aplicados                               
                                _itemFarmaDesc.cantidad_aplicaciones = Convert.ToInt32(dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.CANTIDAD].Value);                               
                            }
                            else //No se dio el procedimiento a farmacia
                            {                              
                                _itemFarmaDesc.cantidad_aplicaciones = 0; //No se aplico nada                               
                            }

                            if (dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.ID_CIERRE].Value != null)//Ya existe el registro
                            {
                                _itemFarmaDesc.id_cierre = Convert.ToInt32(dataGridViewDescartables.Rows[i].Cells[(int)Col_Descartables.ID_CIERRE].Value);
                                E.Entry(_itemFarmaDesc).State = System.Data.Entity.EntityState.Modified;
                            }
                            else
                            {
                                E.FARM_DIARIO.Add(_itemFarmaDesc);
                            }
                        }
                    }
                    #endregion

                    E.SaveChanges();
                    dbContextTransaction.Commit();

                    MetroMessageBox.Show(this, "Se guardo correctamente el registro");
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        #endregion

        #region Eventos
        private void Farm_Principal_Load(object sender, EventArgs e)
        {
            try
            {
                spinner.Hide();
                traePacientes(Clases.Usuario.UsuarioLogeado.Id_sede);
              
                if (DateTime.Now.Hour >= 07 && DateTime.Now.Hour <= 14)//Turno Mañana
                {
                    cboHorarios.SelectedIndex = 0;
                }
                if (DateTime.Now.Hour >= 15 && DateTime.Now.Hour <= 22)//Turno Tarde
                {
                    cboHorarios.SelectedIndex = 1;
                }
                if(DateTime.Now.Hour >= 23 || DateTime.Now.Hour <= 06)//Turno Noche
                {
                    cboHorarios.SelectedIndex = 2;
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                spinner.Show();
                dataGridViewDescartables.Rows.Clear();
                Clases.Paciente.PacienteIngresado = Convert.ToInt32(gridPacientes.CurrentRow.Cells[(int)Col_Pacientes.ID].Value);
                TraeMedicacionPorTurno();
                TraeProcedimientosPorTurno();
                //TraeDescartables(-1);

                for (int u = 0; u < dataGridViewMedicamentos.RowCount; u++ )
                {
                    if (dataGridViewMedicamentos.Rows[u].Cells[(int)Col_Medicamento.HORARIO].Value == null || dataGridViewMedicamentos.Rows[u].Cells[(int)Col_Medicamento.DIAS].Value.ToString() == "")
                    {
                        dataGridViewMedicamentos.Rows[u].Visible = false;
                    }
                    else
                    {
                        dataGridViewMedicamentos.Rows[u].Visible = true;
                    }
                }

                for (int u = 0; u < dataGridViewProcedimientos.RowCount; u++)
                {
                    if (dataGridViewProcedimientos.Rows[u].Cells[(int)Col_Procedimiento.HORARIO].Value == null || dataGridViewProcedimientos.Rows[u].Cells[(int)Col_Procedimiento.DIAS].Value.ToString() == "")
                    {
                        dataGridViewProcedimientos.Rows[u].Visible = false;
                    }
                    else
                    {
                        dataGridViewProcedimientos.Rows[u].Visible = true;
                    }
                }

                spinner.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        #endregion

        private void cboHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewDescartables.Rows.Clear();
                TraeMedicacionPorTurno();
                TraeProcedimientosPorTurno();
                for (int u = 0; u < dataGridViewMedicamentos.RowCount; u++)
                {
                    if(dataGridViewMedicamentos.Rows[u].Cells[(int)Col_Medicamento.HORARIO].Value == null || dataGridViewMedicamentos.Rows[u].Cells[(int)Col_Medicamento.DIAS].Value.ToString() == "")
                    {
                        dataGridViewMedicamentos.Rows[u].Visible = false;
                    }
                    else
                    {
                        dataGridViewMedicamentos.Rows[u].Visible = true;
                    }
                }
                for (int u = 0; u < dataGridViewProcedimientos.RowCount; u++)
                {
                    if (dataGridViewProcedimientos.Rows[u].Cells[(int)Col_Procedimiento.HORARIO].Value == null || dataGridViewProcedimientos.Rows[u].Cells[(int)Col_Procedimiento.DIAS].Value.ToString() == "")
                    {
                        dataGridViewProcedimientos.Rows[u].Visible = false;
                    }
                    else
                    {
                        dataGridViewProcedimientos.Rows[u].Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TraeMedicacionPorTurno();
                TraeProcedimientosPorTurno();
                for (int u = 0; u < dataGridViewMedicamentos.RowCount; u++)
                {
                    if (dataGridViewMedicamentos.Rows[u].Cells[(int)Col_Medicamento.HORARIO].Value == null || dataGridViewMedicamentos.Rows[u].Cells[(int)Col_Medicamento.DIAS].Value.ToString() == "")
                    {
                        dataGridViewMedicamentos.Rows[u].Visible = false;
                    }
                    else
                    {
                        dataGridViewMedicamentos.Rows[u].Visible = true;
                    }
                }
                for (int u = 0; u < dataGridViewProcedimientos.RowCount; u++)
                {
                    if (dataGridViewProcedimientos.Rows[u].Cells[(int)Col_Procedimiento.HORARIO].Value == null || dataGridViewProcedimientos.Rows[u].Cells[(int)Col_Procedimiento.DIAS].Value.ToString() == "")
                    {
                        dataGridViewProcedimientos.Rows[u].Visible = false;
                    }
                    else
                    {
                        dataGridViewProcedimientos.Rows[u].Visible = true;
                    }
                }
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
                spinner.Show();

                guardaCierre();

                spinner.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void dataGridViewProcedimientos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
                            if(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_GENERICO].Value != null)
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
                                if(dataGridViewDescartables.Rows[i].Visible == false)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {               
                dataGridViewMedicamentos.Columns[(int)Col_Medicamento.CANT_APLICACIONES].Visible = true;
                dataGridViewMedicamentos.Columns[(int)Col_Medicamento.MOTIVO].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                dataGridViewMedicamentos.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMedicamentos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == (int)Col_Medicamento.CHECK)
                {
                    if (dataGridViewMedicamentos.CurrentRow != null)
                    {                        
                            DataGridViewCheckBoxCell cellSelecion = dataGridViewMedicamentos.CurrentRow.Cells[(int)Col_Medicamento.CHECK] as DataGridViewCheckBoxCell;

                            if (Convert.ToBoolean(cellSelecion.Value))
                            {
                                dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamento.CANT_APLICACIONES].Value = _cantAplicaciones;
                                dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamento.MOTIVO].Value = null;
                            }
                            else
                            {
                                if (cellSelecion.Value != null)
                                {
                                    dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamento.CANT_APLICACIONES].Value = 0;
                                }
                            }                       
                    }                    
                }
                if(e.ColumnIndex == (int)Col_Medicamento.CANT_APLICACIONES)
                {
                   
                    if (dataGridViewMedicamentos.CurrentRow != null)
                    {
                        if (Convert.ToInt32(dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamento.CANT_APLICACIONES].Value) != _cantAplicaciones)//Hubo un cambio entre lo dado y lo aplicado
                        {
                            if(_pvez == false)
                            {
                                dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamento.MOTIVO].ReadOnly = false;
                                if(Convert.ToInt32(dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamento.CANT_APLICACIONES].Value) == 0)
                                {
                                    dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamento.MOTIVO].Value = 1;
                                }
                                else
                                {
                                    dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamento.MOTIVO].Value = 3;
                                }
                                
                            }

                            _pvez = false;
                        }
                        else
                        {
                            dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamento.MOTIVO].ReadOnly = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckCierre_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(chckCierre.Checked)
                {
                    dataGridViewMedicamentos.Columns[(int)Col_Medicamento.CANT_APLICACIONES].Visible = true;
                    dataGridViewMedicamentos.Columns[(int)Col_Medicamento.MOTIVO].Visible = true;

                    dataGridViewProcedimientos.Columns[(int)Col_Procedimiento.APLICACIONES].Visible = true;
                    dataGridViewProcedimientos.Columns[(int)Col_Procedimiento.MOTIVO].Visible = true;

                    dataGridViewDescartables.Columns[(int)Col_Descartables.APLICACIONES].Visible = true;
                    dataGridViewDescartables.Columns[(int)Col_Descartables.MOTIVO].Visible = true;
                }
                else
                {
                    dataGridViewMedicamentos.Columns[(int)Col_Medicamento.CANT_APLICACIONES].Visible = false;
                    dataGridViewMedicamentos.Columns[(int)Col_Medicamento.MOTIVO].Visible = false;

                    dataGridViewProcedimientos.Columns[(int)Col_Procedimiento.APLICACIONES].Visible = false;
                    dataGridViewProcedimientos.Columns[(int)Col_Procedimiento.MOTIVO].Visible = false;

                    dataGridViewDescartables.Columns[(int)Col_Descartables.APLICACIONES].Visible = false;
                    dataGridViewDescartables.Columns[(int)Col_Descartables.MOTIVO].Visible = false;
                }
               
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
                    _Generico.recibirReferenciaFormularioAnterior(this);
                    _Generico.ShowDialog();
                }
                else
                {
                    Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Nutricion _Nutricion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Nutricion();
                    _Nutricion.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_SUMINISTRO].Value);
                    _Nutricion.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value);
                    _Nutricion.Tipo_Procedimiento_Id = 2;
                    _Nutricion.Nutricion_Id = Convert.ToInt32(dataGridViewProcedimientos.CurrentRow.Cells[(int)Col_Procedimiento.ID_PROCEDIMIENTO].Value);
                    _Nutricion.Paciente_Id = Clases.Paciente.PacienteIngresado;                    
                    _Nutricion.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Farm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow fila in gridPacientes.Rows)
                {
                    Console.WriteLine("Contenido de la fila: " + fila.Cells["Paciente"].Value.ToString());
                    if (!fila.Cells["Paciente"].Value.ToString().Contains(metroTextBox1.Text.ToUpper()))
                        fila.Visible = false;
                    else
                    {
                        fila.Visible = true;
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
