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

namespace Principal.Forms.Facturacion
{
    public partial class Factu_selectorPaciente : MetroForm
    {
        public Factu_selectorPaciente()
        {
            InitializeComponent();
        }

        private void Factu_selectorPaciente_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Clases.Paciente.PacienteNombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMedicacion_Click(object sender, EventArgs e)
        {
            try
            {
                Facturacion.Factu_Medicamentos _med = new Facturacion.Factu_Medicamentos();
                _med.Show();
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
                Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";
               
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "IndicacionesMedicas.rpt";
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

        private void btnProcedimientos_Click(object sender, EventArgs e)
        {
            try
            {
                Facturacion.Factu_Procedimientos _proc = new Factu_Procedimientos();
                _proc.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInternacion_Click(object sender, EventArgs e)
        {
            try
            {
                Factu_internacion datosinternacion = new Factu_internacion();
                datosinternacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
