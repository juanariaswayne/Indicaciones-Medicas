using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Laboratorio
{    
    public partial class NuevoPedidoLab : MetroForm
    {
        #region Variables
        #endregion

        #region Funciones
        public NuevoPedidoLab()
        {
            InitializeComponent();
        }        

        private void GuardaPedido(int _Estudio)
        {
            try
            {
                BLL.Tables.EST_LABORATORIOCAB _cabLab = new BLL.Tables.EST_LABORATORIOCAB();
                Entities.Tables.EST_LABORATORIOCAB _itemCab = new Entities.Tables.EST_LABORATORIOCAB();

                BLL.Tables.EST_LABORATORIOITEMS _itemLab = new BLL.Tables.EST_LABORATORIOITEMS();
                List<Entities.Tables.EST_LABORATORIOITEMS> _itemLabItems = new List<Entities.Tables.EST_LABORATORIOITEMS>();
                //Entities.Tables.EST_LABORATORIOITEMS _itemItems = new Entities.Tables.EST_LABORATORIOITEMS();

                _itemCab.FECHASOLICITUD = DateTime.Now;
                _itemCab.ESTADO_ID = 1;                
                if (chckUrgente.Checked)
                { _itemCab.TIPO = 2; }
                else { _itemCab.TIPO = 1; }
                _itemCab.PACIENTE_ID = Clases.Paciente.PacienteIngresado;
                _itemCab.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;

                int _NroItem;
                _NroItem = 1;
                Entities.Tables.EST_LABORATORIOITEMS _itemItems = new Entities.Tables.EST_LABORATORIOITEMS();
                _itemItems.ESTUDIO_ID = _Estudio;
                _itemItems.NROITEM = _NroItem;                
                _itemLabItems.Add(_itemItems); // Cargo la lista


                _cabLab.GrabaLaboratorio(_itemLabItems, _itemCab);//Graba lista de Items y cabecera
                MetroMessageBox.Show(this,"Se realizo correctamente el pedido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos
        private void NuevoPedidoLab_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnAnalisisSangre_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.MapaCama.Paciente.Ficha.Laboratorio.PedidoLab _PedidoLab = new PedidoLab();
                _PedidoLab.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Estilos
        private void btnAnalisisSangre_MouseEnter(object sender, EventArgs e)
        {
            btnAnalisisSangre.Style = MetroFramework.MetroColorStyle.Orange;
        }

        private void btnAnalisisSangre_MouseLeave(object sender, EventArgs e)
        {
            btnAnalisisSangre.Style = MetroFramework.MetroColorStyle.Red;
        }

        private void btnHemocultivo_MouseEnter(object sender, EventArgs e)
        {
            btnHemocultivo.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void btnHemocultivo_MouseLeave(object sender, EventArgs e)
        {
            btnHemocultivo.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void btnUrocultivo_MouseEnter(object sender, EventArgs e)
        {
            btnUrocultivo.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void btnUrocultivo_MouseLeave(object sender, EventArgs e)
        {
            btnUrocultivo.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void btnHisNasal_MouseEnter(object sender, EventArgs e)
        {
            btnHisNasal.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void btnHisNasal_MouseLeave(object sender, EventArgs e)
        {
            btnHisNasal.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void btnHisRectal_MouseEnter(object sender, EventArgs e)
        {
            btnHisRectal.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void btnHisRectal_MouseLeave(object sender, EventArgs e)
        {
            btnHisRectal.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void btnCdePtaCateter_MouseEnter(object sender, EventArgs e)
        {
            btnCdePtaCateter.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void btnCdePtaCateter_MouseLeave(object sender, EventArgs e)
        {
            btnCdePtaCateter.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void btnCdeAspTraqueal_MouseEnter(object sender, EventArgs e)
        {
            btnCdeAspTraqueal.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void btnCdeAspTraqueal_MouseLeave(object sender, EventArgs e)
        {
            btnCdeAspTraqueal.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void btnCoprocultivo_MouseEnter(object sender, EventArgs e)
        {
            btnCoprocultivo.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void btnCoprocultivo_MouseLeave(object sender, EventArgs e)
        {
            btnCoprocultivo.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void btnExdeLCR_MouseEnter(object sender, EventArgs e)
        {
            btnExdeLCR.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void btnExdeLCR_MouseLeave(object sender, EventArgs e)
        {
            btnExdeLCR.Style = MetroFramework.MetroColorStyle.Lime;
        }
        #endregion

        private void btnHemocultivo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Esta seguro que quiere pedir un Hemocultivo para el paciente "+ Clases.Paciente.PacienteNombre+" ?", "Pedido de Microbiologia", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dialogResult == DialogResult.Yes)
                {
                    GuardaPedido(36); //Hardcodeo el 36 que es el ID del estudio Hemocultivo
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUrocultivo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Esta seguro que quiere pedir un Urocultivo para el paciente " + Clases.Paciente.PacienteNombre + " ?", "Pedido de Microbiologia", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dialogResult == DialogResult.Yes)
                {
                    GuardaPedido(37); //Hardcodeo el 37 que es el ID del estudio Urocultivo
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHisNasal_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Esta seguro que quiere pedir un Hisopado Nasal para el paciente " + Clases.Paciente.PacienteNombre + " ?", "Pedido de Microbiologia", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dialogResult == DialogResult.Yes)
                {
                    GuardaPedido(40); //Hardcodeo el 40 que es el ID del estudio His Nasal
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHisRectal_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Esta seguro que quiere pedir un Hisopado Rectal para el paciente " + Clases.Paciente.PacienteNombre + " ?", "Pedido de Microbiologia", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dialogResult == DialogResult.Yes)
                {
                    GuardaPedido(41); //Hardcodeo el 41 que es el ID del estudio His Rectal
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCdePtaCateter_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Esta seguro que quiere pedir un C. de Pta Cateter para el paciente " + Clases.Paciente.PacienteNombre + " ?", "Pedido de Microbiologia", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dialogResult == DialogResult.Yes)
                {
                    GuardaPedido(39); //Hardcodeo el 39 que es el ID del estudio C. de pta Cateter
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCdeAspTraqueal_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Esta seguro que quiere pedir un Aspirado Traqueal para el paciente " + Clases.Paciente.PacienteNombre + " ?", "Pedido de Microbiologia", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dialogResult == DialogResult.Yes)
                {
                    GuardaPedido(38); //Hardcodeo el 38 que es el ID del estudio c de asp Traqueal
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCoprocultivo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Esta seguro que quiere pedir un Coprocultivo para el paciente " + Clases.Paciente.PacienteNombre + " ?", "Pedido de Microbiologia", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dialogResult == DialogResult.Yes)
                {
                    GuardaPedido(42); //Hardcodeo el 42 que es el ID del estudio Coprocultivo
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExdeLCR_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Esta seguro que quiere pedir un Ex. de LCR para el paciente " + Clases.Paciente.PacienteNombre + " ?", "Pedido de Microbiologia", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dialogResult == DialogResult.Yes)
                {
                    GuardaPedido(43); //Hardcodeo el 43 que es el ID del estudio Ex de LCR
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
