using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Impresion
{
    public partial class Impresion : MetroForm
    {
        #region Variables
        private int paciente_id;
        public int Paciente_id
        {
            get
            {
                return paciente_id;
            }

            set
            {
                this.paciente_id = value;
            }
        }
        #endregion

        #region Funciones
        public Impresion()
        {
            InitializeComponent();
        }

       
        #endregion

        #region Eventos
        private void Impresion_Load(object sender, EventArgs e)
        {
            chckVertical.Checked = true;
            this.radioEstePac.Select();
            this.radioIM.Select();
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
                if (radioIM.Checked)
                {
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IndicacionesMedicas.rpt";
                    objReport.Load(reportPath);
                    objReport.Refresh();
                    objReport.ReportOptions.EnableSaveDataWithReport = false;
                }
                else if(chckVertical.Checked)
                {
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "HojaEnfermeriaVertical.rpt";
                    objReport.Load(reportPath);
                    objReport.Refresh();
                    objReport.ReportOptions.EnableSaveDataWithReport = false;
                }
                else
                {
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "HojaEnfermeria.rpt";
                    objReport.Load(reportPath);
                    objReport.Refresh();
                    objReport.ReportOptions.EnableSaveDataWithReport = false;
                }


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

                ////2° PARAMETRO
                //ParametroField = new ParameterField();
                //ParametroValue = new ParameterDiscreteValue();
                //ParametroField.Name = "@TODOS";
                //ParametroValue.Value = this.radioTodos.Checked;
                //ParametroField.CurrentValues.Add(ParametroValue);
                //Parametros.Add(ParametroField);

                ////3° PARAMETRO
                //ParametroField = new ParameterField();
                //ParametroValue = new ParameterDiscreteValue();
                //ParametroField.Name = "@SEDE";
                //ParametroValue.Value = Clases.Paciente.PacienteSede;
                //ParametroField.CurrentValues.Add(ParametroValue);
                //Parametros.Add(ParametroField);

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
