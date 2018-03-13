using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.ListaEspera
{
    public partial class Frm_ListaEsperaPrincipal : Form
    {
        public Frm_ListaEsperaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTileNuevoIngreso_Click(object sender, EventArgs e)
        {
            ListaEspera.Frm_ListaDeEsperaIngreso Pdf = new ListaEspera.Frm_ListaDeEsperaIngreso();
            Pdf.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ListaEspera.Frm_ModuloEmpresa Pdf2 = new ListaEspera.Frm_ModuloEmpresa();
            Pdf2.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ListaEspera.Frm_OtroFactorPonderacion pdf3 = new ListaEspera.Frm_OtroFactorPonderacion();
            pdf3.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ListaEspera.Frm_CostoModulo Pdf4 = new ListaEspera.Frm_CostoModulo();
            Pdf4.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            ListaEspera.Frm_MotivoEgreso Pdf5 = new ListaEspera.Frm_MotivoEgreso();
            Pdf5.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            ListaEspera.Frm_VisorListaEspera Pdf6 = new ListaEspera.Frm_VisorListaEspera();
            Pdf6.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            ListaEspera.Frm_Derivacion pdf7 = new ListaEspera.Frm_Derivacion();
            pdf7.Show();

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            ListaEspera.Frm_SectoresMails pdf8 = new Frm_SectoresMails();
            pdf8.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            ListaEspera.Frm_Mails pdf9 = new Frm_Mails();
            pdf9.Show();
        }
    }
}
