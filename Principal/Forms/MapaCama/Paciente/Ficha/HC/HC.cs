using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Principal.Forms.MapaCama.Paciente.Ficha.HC
{
    public partial class HC : MetroForm
    {
        #region Variables
        public delegate void DatosHC();
        public event DatosHC Datos;

        private String guarda;
        private int hisC;        
        private bool _ModificaUltimoDia;

        public string Guarda
        {
            get
            {
                return guarda;
            }

            set
            {
                this.guarda = value;
            }
        }

        public int HisC
        {
            get
            {
                return hisC;
            }

            set
            {
                this.hisC = value;
            }
        }

    
        #endregion
        #region Funciones
        public HC()
        {
            InitializeComponent();
        }

        private void TraeDetalleUltimaProrroga(int _HC)
        {
            try
            {
                BLL.Procedures.PRORROGAULTIMODETALLE _obtieneIndicaciones = new BLL.Procedures.PRORROGAULTIMODETALLE();

                foreach (Entities.Procedures.PRORROGAULTIMODETALLE item in _obtieneIndicaciones.ItemList(_HC))
                {
                    //this.txtEstado.Text = item.estadoalingreso;
                    this.txtHC.Text = item.antecedentes;

                    if (item.fechaprorroga.ToShortDateString() == DateTime.Now.ToShortDateString())
                    {
                        _ModificaUltimoDia = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TraeDetalleProrroga(int _HC)
        {
            try
            {
                BLL.Procedures.PRORROGADETALLE _obtieneIndicaciones = new BLL.Procedures.PRORROGADETALLE();

                foreach (Entities.Procedures.PRORROGADETALLE item in _obtieneIndicaciones.ItemList(_HC))
                {
                    this.txtHC.Text = item.antecedentes;
                    //this.txtEstado.Text = item.estadoalingreso;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardaHC()
        {
            BLL.Tables.PRORROGAS _HC = new BLL.Tables.PRORROGAS();
            Entities.Tables.PRORROGAS _item = new Entities.Tables.PRORROGAS();

            _item.PRORROGA_ID = hisC;
            _item.USUARIO_ID = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
            _item.PACIENTE_ID = Clases.Paciente.PacienteIngresado;
            _item.FECHAPRORROGA = DateTime.Now;
            _item.ANTECEDENTES = txtHC.Text;
            //_item.ESTADOALINGRESO = txtEstado.Text;
            _item.ESTADOPRORROGA = true;           

            if (_ModificaUltimoDia)
            {
                DialogResult dialogResult = MessageBox.Show("Desea crear una nueva? presione SI // Desea actualizar la actual? presione NO", "Ya hay una HC creada para el dia de hoy!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    _HC.AddItem(_item);
                    MessageBox.Show("Se agrego correctamente una HC nueva", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Datos();
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                   
                    _HC.UpdateItem(_item);
                    MessageBox.Show("Se actualizo correctamente la HC", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Datos();
                    this.Close();
                }
            }
            else
            {
                _HC.AddItem(_item);
                MessageBox.Show("Se agrego correctamente una HC nueva", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Datos();
                this.Close();
            }


        }
        #endregion

        #region Eventos
        private void NuevaProrroga_Load(object sender, EventArgs e)
        {
            if (guarda == "SI")
            {
                TraeDetalleUltimaProrroga(hisC);
                //this.txtEstado.ReadOnly = false;
                //this.txtEstado.ReadOnly = false;
                this.txtHC.ReadOnly = false;
                this.buttonGuardar.Visible = true;
            }
            else
            {
                TraeDetalleProrroga(hisC);
                //this.txtEstado.ReadOnly = true;
                this.txtHC.ReadOnly = true;
                this.buttonGuardar.Visible = false;
                this.Text = "Detalle Historia Clinica";
            }
        }
        #endregion

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            GuardaHC();
        }
    }
}
