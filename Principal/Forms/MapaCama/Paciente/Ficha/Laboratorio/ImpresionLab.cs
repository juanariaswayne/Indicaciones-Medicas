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

namespace Principal.Forms.MapaCama.Paciente.Ficha.Laboratorio
{
    public partial class ImpresionLab : MetroForm
    {
        #region Variables
        #endregion

        #region Funciones
        public ImpresionLab()
        {
            InitializeComponent();
        }

        private void CargarCboEstados()
        {
            try
            {
                BLL.Tables.EST_LABORATORIOESTADOS _os = new BLL.Tables.EST_LABORATORIOESTADOS();
                Entities.Tables.EST_LABORATORIOESTADOS _itemSeleccion = new Entities.Tables.EST_LABORATORIOESTADOS();
                List<Entities.Tables.EST_LABORATORIOESTADOS> _ItemsOS = new List<Entities.Tables.EST_LABORATORIOESTADOS>();
                //Limpia el combo
                this.cboEstado.SuspendLayout();
                this.cboEstado.DataSource = null;
                this.cboEstado.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCIONESTADO = "<Seleccione>";
                _itemSeleccion.ESTADO_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboEstado.DisplayMember = BLL.Tables.EST_LABORATORIOESTADOS.ColumnNames.DESCRIPCIONESTADO;
                this.cboEstado.ValueMember = BLL.Tables.EST_LABORATORIOESTADOS.ColumnNames.ESTADO_ID;
                this.cboEstado.DataSource = _ItemsOS;
                this.cboEstado.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimePedidosSec()
        {
            try
            {
                Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "PedidoLab.rpt";
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
                ParametroField.Name = "@INF";
                if (radioTodos.Checked)
                {
                    ParametroValue.Value = "TOD";
                }
                if (radioTipo.Checked)
                {
                    ParametroValue.Value = "TIP";
                }
                if (radioSector.Checked)
                {
                    ParametroValue.Value = "SEC";
                }
                if (radioEstado.Checked)
                {
                    ParametroValue.Value = "EST";
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FECHA_DESDE";
                ParametroValue.Value = this.dateDesde.Value;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //3° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FECHA_HASTA";
                ParametroValue.Value = this.dateHasta.Value;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //4° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@SECTOR";
                if (cboSector.SelectedIndex == 0)
                {
                    ParametroValue.Value = "GEN";
                }
                if (cboSector.SelectedIndex == 1)
                {
                    ParametroValue.Value = "MIC";
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);
                
                //5° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@TIPO";
                ParametroValue.Value = this.cboTipo.SelectedIndex + 1;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //6° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@ESTADO";
                ParametroValue.Value = this.cboEstado.SelectedValue;
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

        private void ImprimeAyuna()
        {
            try
            {
                Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "PedidoLabAyuna.rpt";
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
                ParametroField.Name = "@INF";               
                ParametroValue.Value = "AYU";               
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FECHA_DESDE";
                ParametroValue.Value = this.dateDesde.Value;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //3° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FECHA_HASTA";
                ParametroValue.Value = this.dateHasta.Value;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //4° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@SECTOR";
                if (cboSector.SelectedIndex == 0)
                {
                    ParametroValue.Value = "GEN";
                }
                if (cboSector.SelectedIndex == 1)
                {
                    ParametroValue.Value = "MIC";
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //5° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@TIPO";
                ParametroValue.Value = this.cboTipo.SelectedIndex + 1;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //6° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@ESTADO";
                ParametroValue.Value = this.cboEstado.SelectedValue;
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

        private void ImprimePedidosPac()
        {
            try
            {
                Reports _Reporte = new Reports();
                ReportDocument objReport = new ReportDocument();

                //String reportPath = Application.StartupPath + @"\Reporting\" + "IngresoCompras_Sintetico.rpt";

                String reportPath = ConfigurationManager.AppSettings["Reports"] + "\\Reporting\\" + "PedidoLabOrdPac.rpt";
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
                ParametroField.Name = "@INF";
                if (radioTodos.Checked)
                {
                    ParametroValue.Value = "TOD";
                }
                if (radioTipo.Checked)
                {
                    ParametroValue.Value = "TIP";
                }
                if (radioSector.Checked)
                {
                    ParametroValue.Value = "SEC";
                }
                if (radioEstado.Checked)
                {
                    ParametroValue.Value = "EST";
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //2° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FECHA_DESDE";
                ParametroValue.Value = this.dateDesde.Value;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //3° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@FECHA_HASTA";
                ParametroValue.Value = this.dateHasta.Value;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //4° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@SECTOR";
                if (cboSector.SelectedIndex == 0)
                {
                    ParametroValue.Value = "GEN";
                }
                if (cboSector.SelectedIndex == 1)
                {
                    ParametroValue.Value = "MIC";
                }
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //5° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@TIPO";
                ParametroValue.Value = this.cboTipo.SelectedIndex + 1;
                ParametroField.CurrentValues.Add(ParametroValue);
                Parametros.Add(ParametroField);

                //6° PARAMETRO
                ParametroField = new ParameterField();
                ParametroValue = new ParameterDiscreteValue();
                ParametroField.Name = "@ESTADO";
                ParametroValue.Value = this.cboEstado.SelectedValue;
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
        #endregion

        #region Eventos
        private void ImpresionLab_Load(object sender, EventArgs e)
        {
            CargarCboEstados();
            radioTodos.Checked = true;
        }
        private void btnImprimir_MouseEnter(object sender, EventArgs e)
        {
            this.btnImprimir.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            this.btnImprimir.Style = MetroFramework.MetroColorStyle.Blue;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (radioAyuna.Checked)
            {
                ImprimeAyuna();
            }
            else
            {
                if (radioSolicitud.Checked)
                {
                    ImprimePedidosSec();
                }
                if (radioPaciente.Checked)
                {
                    ImprimePedidosPac();
                }

            }
            
        }


        #endregion

        private void radioSector_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioSector.Checked)
            {
                cboSector.Enabled = true;
                cboEstado.Enabled = false;
                cboTipo.Enabled = false;
            }
            else
            {
                cboSector.Enabled = false;
                cboEstado.Enabled = true;
                cboTipo.Enabled = true;
            }
        }

        private void radioTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioTipo.Checked)
            {
                cboTipo.Enabled = true;
                cboEstado.Enabled = false;
                cboSector.Enabled = false;
            }
            else
            {
                cboTipo.Enabled = false;
                cboEstado.Enabled = true;
                cboSector.Enabled = true;
            }
        }

        private void radioEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioEstado.Checked)
            {
                cboEstado.Enabled = true;
                cboSector.Enabled = false;
                cboTipo.Enabled = false;
            }
            else
            {
                cboEstado.Enabled = false;
                cboSector.Enabled = true;
                cboTipo.Enabled = true;
            }
        }

        private void radioTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioTodos.Checked)
            {
                cboEstado.Enabled = false;
                cboSector.Enabled = false;
                cboTipo.Enabled = false;
            }
            else
            {
                cboEstado.Enabled = false;
                cboSector.Enabled = false;
                cboTipo.Enabled = false;
            }

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
