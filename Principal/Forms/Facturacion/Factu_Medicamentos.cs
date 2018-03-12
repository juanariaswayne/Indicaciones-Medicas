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

namespace Principal.Forms.Facturacion
{
    public partial class Factu_Medicamentos : MetroForm
    {
        SISTMEDEntities E = new SISTMEDEntities();
        private enum Col_Medicamento
        {
            ID = 0,
            INICIO,
            ID_SUMINISTRO,
            MEDICAMENTO_ID,
            MEDICAMENTO,
            DOSIS,
            VIA,
            DILUYENTE,
            ML,            
            HORARIO,
            DIAS,
            OBS,
            FIN,
            MED,
            IMP
        }

        public Factu_Medicamentos()
        {
            InitializeComponent();
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
                if (_itemMedicamento.HS_23 == true)
                {
                    _Horario = "23-" + _Horario;
                }
                if (_itemMedicamento.HS_22 == true)
                {
                    _Horario = "22-" + _Horario;
                }
                if (_itemMedicamento.HS_21 == true)
                {
                    _Horario = "21-" + _Horario;
                }
                if (_itemMedicamento.HS_20 == true)
                {
                    _Horario = "20-" + _Horario;
                }
                if (_itemMedicamento.HS_19 == true)
                {
                    _Horario = "19-" + _Horario;
                }
                if (_itemMedicamento.HS_18 == true)
                {
                    _Horario = "18-" + _Horario;
                }
                if (_itemMedicamento.HS_17 == true)
                {
                    _Horario = "17-" + _Horario;
                }
                if (_itemMedicamento.HS_16 == true)
                {
                    _Horario = "16-" + _Horario;
                }
                if (_itemMedicamento.HS_15 == true)
                {
                    _Horario = "15-" + _Horario;
                }
                if (_itemMedicamento.HS_14 == true)
                {
                    _Horario = "14-" + _Horario;
                }
                if (_itemMedicamento.HS_13 == true)
                {
                    _Horario = "13-" + _Horario;
                }
                if (_itemMedicamento.HS_12 == true)
                {
                    _Horario = "12-" + _Horario;
                }
                if (_itemMedicamento.HS_11 == true)
                {
                    _Horario = "11-" + _Horario;
                }
                if (_itemMedicamento.HS_10 == true)
                {
                    _Horario = "10-" + _Horario;
                }
                if (_itemMedicamento.HS_09 == true)
                {
                    _Horario = "09-" + _Horario;
                }
                if (_itemMedicamento.HS_08 == true)
                {
                    _Horario = "08-" + _Horario;
                }
                if (_itemMedicamento.HS_07 == true)
                {
                    _Horario = "07-" + _Horario;
                }
                if (_itemMedicamento.HS_06 == true)
                {
                    _Horario = "06-" + _Horario;
                }
                if (_itemMedicamento.HS_05 == true)
                {
                    _Horario = "05-" + _Horario;
                }
                if (_itemMedicamento.HS_04 == true)
                {
                    _Horario = "04-" + _Horario;
                }
                if (_itemMedicamento.HS_03 == true)
                {
                    _Horario = "03-" + _Horario;
                }
                if (_itemMedicamento.HS_02 == true)
                {
                    _Horario = "02-" + _Horario;
                }
                if (_itemMedicamento.HS_01 == true)
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

                if (_itemMedicamento.L == true)
                {
                    _Dias = "Lunes" + _Dias;
                }
                if (_itemMedicamento.M == true)
                {
                    _Dias = "Martes" + _Dias;
                }
                if (_itemMedicamento.X == true)
                {
                    _Dias = "Miercoles" + _Dias;
                }
                if (_itemMedicamento.J == true)
                {
                    _Dias = "Jueves" + _Dias;
                }
                if (_itemMedicamento.V == true)
                {
                    _Dias = "Viernes" + _Dias;
                }
                if (_itemMedicamento.S == true)
                {
                    _Dias = "Sabado" + _Dias;
                }
                if (_itemMedicamento.D == true)
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

        private void traeIndicacionMedicamentos(int _paciente)
        {
            try
            {

                dataGridViewMedicamentos.Rows.Clear();
                int indice;
                foreach (var item in E.MED_Historial_SuministroDeMedicacion.Where(p => p.paciente_id == _paciente && (p.fechaBaja >= dateDesde.Value && p.fechaBaja <= dateHasta.Value || p.fechaBaja == null)).OrderBy(med => med.MEDICAMENTO.descripcion_medicamento))
                {
                    indice = dataGridViewMedicamentos.Rows.Add();
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.ID].Value = item.suministroDeMedicacion_id;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.INICIO].Value = item.fechaAltaSistema.Value.ToString();
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.ID_SUMINISTRO].Value = item.suministro_original;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.MEDICAMENTO_ID].Value = item.medicamento_id;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.MEDICAMENTO].Value = item.MEDICAMENTO.descripcion_medicamento + " " + item.MEDICAMENTO.presentacion + " " + item.MEDICAMENTO.potencia;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.VIA].Value = item.viaTieneOtro == false? item.MED_Via.descripcion : item.viaOtro;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.DILUYENTE].Value = item.diluyente_id == 0 ? "" : item.MED_Diluyente.descripcion;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.ML].Value = item.ml;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.DOSIS].Value = item.dosis;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.HORARIO].Value = HorarioSuministro(item);
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.DIAS].Value = DiasSuministro(item);
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.OBS].Value = item.observacion;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.FIN].Value = item.fechaBaja == null ? item.lapsoDeTiempoHasta == null? "" : item.lapsoDeTiempoHasta.ToString() : item.fechaBaja.Value.ToString();
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.MED].Value = traeMedico(Convert.ToInt32(item.usuario_id));
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamento.IMP].Value = item.imprimeFactu == null? true: item.imprimeFactu.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Factu_Medicamentos_Load(object sender, EventArgs e)
        {
            try
            {
                dateDesde.Value = Convert.ToDateTime("01/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());
                dateHasta.Value = dateDesde.Value.AddMonths(1).AddDays(-1);
                this.Text = "Medicacion de: " + Clases.Paciente.PacienteNombre;                
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    IFormatProvider culture = new CultureInfo("en-US", true);

                    Reports _Reporte = new Reports();
                    ReportDocument objReport = new ReportDocument();

                    //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";

                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IndicacionesMedicamentosFact.rpt";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == (int)Col_Medicamento.IMP)
                {
                    dataGridViewMedicamentos.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
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

                if (e.ColumnIndex == (int)Col_Medicamento.IMP)
                {
                    DataGridViewCheckBoxCell cellSelecion = dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamento.IMP] as DataGridViewCheckBoxCell;

                    SISTMEDEntities E = new SISTMEDEntities();
                    E.Configuration.ValidateOnSaveEnabled = false;

                    int _suministroID = Convert.ToInt32(dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamento.ID].Value);

                    MED_Historial_SuministroDeMedicacion _hist = new MED_Historial_SuministroDeMedicacion { suministroDeMedicacion_id = _suministroID, imprimeFactu = Convert.ToBoolean(cellSelecion.Value) };
                    E.MED_Historial_SuministroDeMedicacion.Attach(_hist);
                    E.Entry(_hist).Property(f => f.imprimeFactu).IsModified = true;
                    E.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
