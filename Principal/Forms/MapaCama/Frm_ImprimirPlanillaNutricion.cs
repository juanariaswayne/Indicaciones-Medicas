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

namespace Principal.Forms.MapaCama
{
    public partial class Frm_ImprimirPlanillaNutricion : MetroForm
    {
        public Frm_ImprimirPlanillaNutricion()
        {
            InitializeComponent();

            cmboxDocumento.Items.Add("Hoja de camarera");
            cmboxDocumento.Items.Add("Hoja de cocina");
            cmboxTipoDocumento.Items.Add("Todos los pisos");
            cmboxTipoDocumento.Items.Add("Un piso específico");

            cmboxTipoDocumento.Enabled = false;
            cmboxPiso.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void cmboxDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboxTipoDocumento.Enabled = true;
        }

        private void cmboxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmboxTipoDocumento.SelectedItem.ToString() == "Un piso específico")
            {
                cmboxPiso.Enabled = true;
                int id_sede = Clases.Paciente.PacienteSede;
                SISTMEDEntities E = new SISTMEDEntities();
                var pisos = from h in E.Habitaciones
                            join p in E.Piso on h.piso_id equals p.piso_id
                            where h.sede_id == id_sede
                            select p.descripcion;

                foreach(var piso in pisos)
                {
                    if(!cmboxPiso.Items.Contains(piso))
                        cmboxPiso.Items.Add(piso);
                }
            }
            else
            {
                cmboxPiso.Enabled = false;
                btnImprimir.Enabled = true;
            }
        }

        private void cmboxPiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnImprimir.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Obtengo los datos seleccionados
            int sede = Clases.Paciente.PacienteSede;
            string documento = cmboxDocumento.SelectedItem.ToString();
            string datosAIncluir = cmboxTipoDocumento.SelectedItem.ToString();
            int piso;

            if(datosAIncluir.Equals("Un piso específico"))
            {
                SISTMEDEntities E = new SISTMEDEntities();
                string piso_texto = cmboxPiso.SelectedItem.ToString();
                piso = (from p in E.Piso where p.descripcion == piso_texto select p.piso_id).Single();
            }
            else
            {
                piso = -1;
            }

            // Configuro los datos del Crystal Reports
            try
            {
                Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                if(documento.Equals("Hoja de camarera"))
                {
                    String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "HojaDeCamarera.rpt";
                    objReport.Load(reportPath);
                    objReport.Refresh();
                    objReport.ReportOptions.EnableSaveDataWithReport = false;
                }
                else
                {
                    if(documento.Equals("Hoja de cocina"))
                    {
                        String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "HojaDeCocina.rpt";
                        objReport.Load(reportPath);
                        objReport.Refresh();
                        objReport.ReportOptions.EnableSaveDataWithReport = false;
                    }
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

                ////1° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@sede";
                ParametroValue.Value = sede;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                if (piso != -1)
                {
                    ////2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@piso";
                    ParametroValue.Value = piso;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);
                }
                else
                {
                    ////2° PARAMETRO
                    ParametroField = new ParameterField();
                    ParametroValue = new ParameterDiscreteValue();
                    ParametroField.Name = "@piso";
                    ParametroValue.Value = null;
                    ParametroField.CurrentValues.Add(ParametroValue);
                    Parametros.Add(ParametroField);
                }

                _Reporte.Parameters = Parametros;
                _Reporte.Reporte = objReport;
                _Reporte.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error55", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
