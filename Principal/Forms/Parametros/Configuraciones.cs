using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.Parametros
{
    public partial class Configuraciones : MetroForm
    {
        #region Inicio
        public Configuraciones()
        {
            InitializeComponent();
        }
        private void Configuraciones_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region evento
        #region Procedimiento
        private void btnProcedim_Click(object sender, EventArgs e)
        {
            Forms.Parametros.Procedimiento.EditProcedimientos _Proc = new Forms.Parametros.Procedimiento.EditProcedimientos();
            _Proc.ShowDialog();
        }
        private void btnDesc_Click(object sender, EventArgs e)
        {
            Forms.Parametros.Procedimiento.ProcedimientoDescartable _Desc = new Forms.Parametros.Procedimiento.ProcedimientoDescartable();
            _Desc.ShowDialog();
        }
        private void btnAutorizaProcedimiento_Click(object sender, EventArgs e)
        {
            //Forms.Parametros.Procedimiento.Procedimiento_Solicitado _ProcedimientoSolicitado = new Forms.Parametros.Procedimiento.Procedimiento_Solicitado();
            //_ProcedimientoSolicitado.ShowDialog();
        }
        private void btnSolicitaProcedimiento_Click(object sender, EventArgs e)
        {
            Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Solicitar_Procedimientos_Nuevo _Solicita_Procedimiento_Nuevo = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Solicitar_Procedimientos_Nuevo();
            _Solicita_Procedimiento_Nuevo.ShowDialog();
        }
        #endregion

        #region Medicamento
        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            Forms.Parametros.Medicamento.MedicamentoVia _MedicamentoVia = new Forms.Parametros.Medicamento.MedicamentoVia();
            _MedicamentoVia.ShowDialog();
        }
        private void btnVías_Click(object sender, EventArgs e)
        {
            Forms.Parametros.Medicamento.Edita_Via _EditaVia = new Forms.Parametros.Medicamento.Edita_Via();
            _EditaVia.ShowDialog();
        }
        private void btnAutorizaMedicamento_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Forms.Parametros.Medicamento.Medicamento_Solicitado _MedicamentoSolicitado = new Forms.Parametros.Medicamento.Medicamento_Solicitado();
            _MedicamentoSolicitado.ShowDialog();
            Cursor = Cursors.Arrow;
        }
        private void btnSolicitaMedicamento_Click(object sender, EventArgs e)
        {
            Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.Solicitar_Medicamentos_Nuevo _Solicita_Medicacion_Nuevo = new Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.Solicitar_Medicamentos_Nuevo();
            _Solicita_Medicacion_Nuevo.ShowDialog();
        }
        #endregion
        private void Configuraciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
        }
        #endregion

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Forms.Medicamento.Medicamento _Medicamento = new Forms.Medicamento.Medicamento();
            _Medicamento.ShowDialog();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            NuevoUsuario N = new NuevoUsuario();
            N.ShowDialog();
            Cursor = Cursors.Arrow;
        }
    }
}
