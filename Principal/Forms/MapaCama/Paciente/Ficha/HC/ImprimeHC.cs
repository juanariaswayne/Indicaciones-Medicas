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

namespace Principal.Forms.MapaCama.Paciente.Ficha.HC
{
    public partial class ImprimeHC : MetroForm
    {
        public ImprimeHC()
        {
            InitializeComponent();
        }

        private void ImprimeProrrogas()
        {
            try
            {
                Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "Prorrogas.rpt";
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
                ParametroField.Name = "@Tipo";
                if (this.radioProrrogas.Checked)
                {
                    ParametroValue.Value = "PR";
                }
                if (this.radioResumen.Checked)
                {
                    ParametroValue.Value = "RE";
                }

                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //3° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FechaDesde";
                ParametroValue.Value = this.datefechaDesde.Value;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //4° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FechaHasta";
                ParametroValue.Value = this.datefechaHasta.Value;
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

        private void ImprimeEpicrisis()
        {
            try
            {
                Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "Epicrisis.rpt";
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


                _Reporte.Parameters = Parametros;
                _Reporte.Reporte = objReport;
                _Reporte.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ImprimeHC_Load(object sender, EventArgs e)
        {
            this.radioProrrogas.Checked = true;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.radioProrrogas.Checked)
                {
                    ImprimeProrrogas();
                }
                if (this.radioEpicrisis.Checked)
                {
                    ImprimeEpicrisis();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
