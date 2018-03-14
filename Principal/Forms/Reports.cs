using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Principal
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            
        }
        private void Reports_Load(object sender, EventArgs e)
        {

            this.ReportViewer.RefreshReport();
            
        }

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ReportViewer = null;
        }

        object mReporte;
        ParameterFields paramFields;
        public object Reporte
        {
            get { return mReporte; }
            set
            {
                mReporte = value;
                this.ReportViewer.ReportSource = null;
                this.ReportViewer.ReportSource = mReporte;

            }
        }
        public ParameterFields Parameters
        {
            get { return paramFields; }

            set
            {
                paramFields = value;
                this.ReportViewer.ParameterFieldInfo = null;
                this.ReportViewer.ParameterFieldInfo = paramFields;
            }


        }

    }
}
