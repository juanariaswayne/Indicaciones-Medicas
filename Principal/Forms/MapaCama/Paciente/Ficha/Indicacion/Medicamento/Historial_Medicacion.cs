using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento
{
    public partial class Historial_Medicacion : MetroForm
    {
        #region Variables
        private enum Col_Medicamentos
        {
            SUMINISTRODEMEDICACION_ID = 0,
            MEDICACION_ID,
            FECHA_INICIO,
            MEDICAMENTO,
            HORARIODESUMINISTRO,
            FECHA_HASTA,
            OBSERVACION,
            MEDICO
        }

        private enum Col_Procedimiento
        {
            ID_PROC = 0,
            FECHA_INICIO,
            PROCEDIMIENTO,
            FECHA_BAJA,
            MEDICO
        }
        #endregion

        #region Funciones
        public Historial_Medicacion()
        {
            InitializeComponent();
        }

        private string traeMedicoMedicacion(string _idMedico)
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();
                string _medico = E.TBL_Usuarios.Where(med=>med.IdentificadorUsuario.Trim() == _idMedico).SingleOrDefault().NombreUsuario.ToString();
                return _medico;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Trae_Medicacion_Paciente(int _idPaciente, string _idMedicamento)
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();
                CultureInfo culture = new CultureInfo("en-US");
                this.dataGridViewHisMed.Rows.Clear();
                int indice;
                foreach (var item in E.MED_GET_Suministro_Medicacion_Historico(_idPaciente).ToList().Where(f=>f.fechaInicio >= dateDesde.Value && f.fechaInicio <= dateHasta.Value))
                {

                    indice = dataGridViewHisMed.Rows.Add();
                    dataGridViewHisMed.Rows[indice].Cells[(int)Col_Medicamentos.SUMINISTRODEMEDICACION_ID].Value = item.suministroDeMedicacion_id;
                    dataGridViewHisMed.Rows[indice].Cells[(int)Col_Medicamentos.MEDICACION_ID].Value = item.medicamento_id;
                    dataGridViewHisMed.Rows[indice].Cells[(int)Col_Medicamentos.FECHA_INICIO].Value = item.fechaInicio.Value.ToShortDateString();
                    dataGridViewHisMed.Rows[indice].Cells[(int)Col_Medicamentos.MEDICAMENTO].Value = item.descripcion_medicamento + " " + item.potencia + "" + " ( " + item.dosis + " " + item.presentacion + ")" + " Via " + item.Via;
                    dataGridViewHisMed.Rows[indice].Cells[(int)Col_Medicamentos.FECHA_HASTA].Value = item.fechaBaja == null ? "" : item.fechaBaja.Value.ToShortDateString();

                    dataGridViewHisMed.Rows[indice].Cells[(int)Col_Medicamentos.OBSERVACION].Value = item.motivoBaja;
                    string _medicoMatricula = item.motivoBaja.ToString().Substring(item.motivoBaja.ToString().IndexOf(":") + ":".Length);
                    dataGridViewHisMed.Rows[indice].Cells[(int)Col_Medicamentos.MEDICO].Value = traeMedicoMedicacion(_medicoMatricula.Trim());

                    String _Horario;
                    _Horario = "";
                    if (item.HS_24 == true)
                    {
                        _Horario = "24-" + _Horario;
                    }
                    if (item.HS_23 == true)
                    {
                        _Horario = "23-" + _Horario;
                    }
                    if (item.HS_22 == true)
                    {
                        _Horario = "22-" + _Horario;
                    }
                    if (item.HS_21 == true)
                    {
                        _Horario = "21-" + _Horario;
                    }
                    if (item.HS_20 == true)
                    {
                        _Horario = "20-" + _Horario;
                    }
                    if (item.HS_19 == true)
                    {
                        _Horario = "19-" + _Horario;
                    }
                    if (item.HS_18 == true)
                    {
                        _Horario = "18-" + _Horario;
                    }
                    if (item.HS_17 == true)
                    {
                        _Horario = "17-" + _Horario;
                    }
                    if (item.HS_16 == true)
                    {
                        _Horario = "16-" + _Horario;
                    }
                    if (item.HS_15 == true)
                    {
                        _Horario = "15-" + _Horario;
                    }
                    if (item.HS_14 == true)
                    {
                        _Horario = "14-" + _Horario;
                    }
                    if (item.HS_13 == true)
                    {
                        _Horario = "13-" + _Horario;
                    }
                    if (item.HS_12 == true)
                    {
                        _Horario = "12-" + _Horario;
                    }
                    if (item.HS_11 == true)
                    {
                        _Horario = "11-" + _Horario;
                    }
                    if (item.HS_10 == true)
                    {
                        _Horario = "10-" + _Horario;
                    }
                    if (item.HS_09 == true)
                    {
                        _Horario = "09-" + _Horario;
                    }
                    if (item.HS_08 == true)
                    {
                        _Horario = "08-" + _Horario;
                    }
                    if (item.HS_07 == true)
                    {
                        _Horario = "07-" + _Horario;
                    }
                    if (item.HS_06 == true)
                    {
                        _Horario = "06-" + _Horario;
                    }
                    if (item.HS_05 == true)
                    {
                        _Horario = "05-" + _Horario;
                    }
                    if (item.HS_04 == true)
                    {
                        _Horario = "04-" + _Horario;
                    }
                    if (item.HS_03 == true)
                    {
                        _Horario = "03-" + _Horario;
                    }
                    if (item.HS_02 == true)
                    {
                        _Horario = "02-" + _Horario;
                    }
                    if (item.HS_01 == true)
                    {
                        _Horario = "01-" + _Horario;
                    }

                    if (_Horario == "")
                    {
                        dataGridViewHisMed.Rows[indice].Cells[(int)Col_Medicamentos.HORARIODESUMINISTRO].Value = item.evento;
                    }
                    else
                    {
                        _Horario = _Horario.Substring(0, _Horario.Length - 1);
                        dataGridViewHisMed.Rows[indice].Cells[(int)Col_Medicamentos.HORARIODESUMINISTRO].Value = _Horario;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Trae_Procedimientos()
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();
                dataGridViewProcedimientos.Rows.Clear();
                int indice;
                foreach (var _itemProcedimiento in E.PRO_SuministroDeProcedimiento.Where(p=>p.paciente_id == Clases.Paciente.PacienteIngresado).ToList().Where(f => (f.fechaBaja >= dateDesde.Value && f.fechaBaja <= dateHasta.Value) || f.fechaBaja == null))
                {
                    indice = dataGridViewProcedimientos.Rows.Add();
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.ID_PROC].Value = _itemProcedimiento.procedimiento_id;
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.PROCEDIMIENTO].Value = _itemProcedimiento.PRO_Procedimiento.descripcion + " "+ (_itemProcedimiento.generico_id == null? "": _itemProcedimiento.PRO_Generico.observacion);
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.FECHA_INICIO].Value = _itemProcedimiento.fechaAltaSistema.Value.ToShortDateString();
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.FECHA_BAJA].Value = _itemProcedimiento.fechaBaja == null? "" : _itemProcedimiento.fechaBaja.Value.ToShortDateString();
                    dataGridViewProcedimientos.Rows[indice].Cells[(int)Col_Procedimiento.MEDICO].Value = traeMedico(Convert.ToInt32(_itemProcedimiento.usuario_id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string traeMedico(int _idMedico)
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();
                string _medico = E.TBL_Usuarios.Find(_idMedico).NombreUsuario.ToString();
                return _medico;
            }
            catch (Exception ex)
            {
                return "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos
        private void Historial_Medicacion_Load(object sender, EventArgs e)
        {
            dateDesde.Value = DateTime.Now.AddMonths(-1);
            dateHasta.Value = DateTime.Now;
            Trae_Medicacion_Paciente(Clases.Paciente.PacienteIngresado,"");
            Trae_Procedimientos();
        }
        #endregion

        private void dateDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Trae_Medicacion_Paciente(Clases.Paciente.PacienteIngresado, "");
                Trae_Procedimientos();
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
                Trae_Medicacion_Paciente(Clases.Paciente.PacienteIngresado, "");
                Trae_Procedimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                IFormatProvider culture = new CultureInfo("en-US", true);

                Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IndicacionesMedicasHist.rpt";
                    objReport.Load(reportPath);
                    objReport.Refresh();
                    objReport.ReportOptions.EnableSaveDataWithReport = false;                


                // PARAMETROS DE CONEXION
                TableLogOnInfo logoninfo = new TableLogOnInfo();
                logoninfo.ConnectionInfo.ServerName = ConfigurationManager.AppSettings["Source"];
                logoninfo.ConnectionInfo.DatabaseName = ConfigurationManager.AppSettings["CatalogSISTMED"];
                logoninfo.ConnectionInfo.UserID = ConfigurationManager.AppSettings["User ID"];
                logoninfo.ConnectionInfo.Password = ConfigurationManager.AppSettings["Password"];
                logoninfo.ConnectionInfo.IntegratedSecurity = false;
                Tables tables = objReport.Database.Tables;
                foreach (Table table in tables)
                {
                    table.ApplyLogOnInfo(logoninfo);
                }
                // FIN PARAMETROS DE CONEXION

                ParameterFields Parametros = new ParameterFields();
                ParameterField ParametroField = new ParameterField();
                ParameterDiscreteValue ParametroValue = new ParameterDiscreteValue();
                Parametros.Clear();
                //1er PARAMETRO
                ParametroField.Name = "@PACIENTE_ID";
                ParametroValue.Value = Clases.Paciente.PacienteIngresado;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FechaDesde";
                ParametroValue.Value = dateDesde.Value.ToString("yyyy-MM-dd");
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //3° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FechaHasta";
                ParametroValue.Value = dateHasta.Value.ToString("yyyy-MM-dd");
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                _Reporte.Parameters = Parametros;
                _Reporte.Reporte = objReport;
                _Reporte.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
