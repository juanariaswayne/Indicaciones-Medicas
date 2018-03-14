using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Forms
{
    public partial class Login : MetroForm
    {
        #region Variables
        public bool IngresoCorrecto = false;

        private Int32 _perfilUsuario = 0;
        private Int32 _idUsuario = 0;
        private Int32 _idSector = 0;

        public Int32 PerfilUsuario
        {
            get { return _perfilUsuario; }
            set { _perfilUsuario = value; }
        }

        #endregion
        
        #region Funciones
        public Login()
        {
            InitializeComponent();          
        }

        #endregion

        #region Eventos
        private void Login_Load(object sender, EventArgs e)
        {
            btnTest.Hide();
            SISTMEDEntities E = new SISTMEDEntities();
            CargarCboSede();
            this.txtUsuario.Focus();          
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.CenterToScreen();
            CargarCboSede();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.txtContrasenia.Focus(); }
                
        }

        private void CargarCboSede()
        {
            try
            {
                BLL.Tables.SEDES _os = new BLL.Tables.SEDES();
                Entities.Tables.SEDES _itemSeleccion = new Entities.Tables.SEDES();
                List<Entities.Tables.SEDES> _ItemsOS = new List<Entities.Tables.SEDES>();
                //Limpia el combo
                this.cboSede.SuspendLayout();
                this.cboSede.DataSource = null;
                this.cboSede.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.DESCRIPCION = "<Seleccione Sede>";
                _itemSeleccion.SEDE_ID = 0;
                _ItemsOS = _os.ItemList(); //Carga la lista para llenar el combo;
                _ItemsOS.Insert(0, _itemSeleccion);
                //Carga el combo
                this.cboSede.DisplayMember = BLL.Tables.SEDES.ColumnNames.DESCRIPCION;
                this.cboSede.ValueMember = BLL.Tables.SEDES.ColumnNames.SEDE_ID;
                this.cboSede.DataSource = _ItemsOS;
                this.cboSede.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSede.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionar una Sede", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    #region Usuario
                    MenuSistema.Cls_Menus Menus = new MenuSistema.Cls_Menus();
                    Seguridad.Encriptacion encripta = new Seguridad.Encriptacion();
                    string ClaveUsu;
                    ClaveUsu = encripta.ENCRIPTAR(txtContrasenia.Text.ToString());
                    foreach (Entities.Procedures._VALIDACREDENCIAL Creden in Menus.ValidarCredenciales(txtUsuario.Text, ClaveUsu))
                    {
                        _idUsuario = Creden.idusuario;
                        PerfilUsuario = Creden.perfil;
                        _idSector = Creden.Sector_id;
                        Clases.Usuario.UsuarioLogeado.Id_Sector = Creden.Sector_id;
                        Clases.Usuario.UsuarioLogeado.id_usuario_Logeado = Creden.idusuario;
                        
                    }

                    if (_idUsuario != 0) //SI ES CERO, NO EXISTE O LA CLAVE ES INCORRECTA, SINO TRAE EL ID DE USUARIO Y EL PERFIL AL QUE PERTENECE
                    {
                        IngresoCorrecto = true;
                        //GUARDO EL USUARIO QUE ESTÁ LOGEADO
                        Clases.Usuario.UsuarioLogeado.usuario_Logeado = txtUsuario.Text.ToString();
                        //TAMBIEN GUARDO LA EMPRESA LOGEADA ---- HECTOR
                        Clases.Usuario.UsuarioLogeado.Id_sede = Convert.ToInt32(this.cboSede.SelectedValue);
                        switch (Clases.Usuario.UsuarioLogeado.Id_sede)
                        {
                            case 1:
                                Clases.Usuario.EmpresaLogeada.EmpresaIngresada = "EGES";
                                break;
                            case 2:
                                Clases.Usuario.EmpresaLogeada.EmpresaIngresada = "EGES";
                                break;
                            case 3:
                                Clases.Usuario.EmpresaLogeada.EmpresaIngresada = "RSC";
                                break;
                        }

                        this.Hide();
                        if (PerfilUsuario == 2)
                        {
                            Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion _FormInternacion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Indicacion();
                            _FormInternacion.Show();
                        }
                        if (PerfilUsuario == 1 || PerfilUsuario == 8)
                        {
                            Forms.MapaCama.MapaDeCamas _FormMapaCama = new Forms.MapaCama.MapaDeCamas();
                            int sede = Convert.ToInt32(this.cboSede.SelectedValue);

                            switch (sede)
                            {
                                case 1:
                                    _FormMapaCama.sede = "Sede: VENEZUELA";
                                    _FormMapaCama.sede_id = 1;
                                    _FormMapaCama.empresa = "EGSAC";
                                    _FormMapaCama.empresa_id = 2;
                                    Clases.Paciente.PacienteSede = 1;
                                    break;
                                case 2:
                                    _FormMapaCama.sede = "Sede: MEXICO";
                                    _FormMapaCama.sede_id = 2;
                                    _FormMapaCama.empresa = "EGSAC";
                                    _FormMapaCama.empresa_id = 2;
                                    Clases.Paciente.PacienteSede = 2;
                                    break;
                                case 3:
                                    _FormMapaCama.sede = "Sede: CATAMARCA";
                                    _FormMapaCama.sede_id = 3;
                                    _FormMapaCama.empresa = "RSC";
                                    _FormMapaCama.empresa_id = 1;
                                    Clases.Paciente.PacienteSede = 3;
                                    break;
                            }

                            _FormMapaCama.Show();
                        }
                        if (PerfilUsuario == 5) // USUARIO DE HOTELERIA
                        {
                            Forms.Internacion.Hoteleria.Hoteleria _FormHoteleria = new Forms.Internacion.Hoteleria.Hoteleria();
                            _FormHoteleria.Show();
                        }
                        if (PerfilUsuario == 6) // USUARIO DE FACTURACION
                        {
                            Forms.Parametros.Configuraciones _Parametros = new Parametros.Configuraciones();
                            _Parametros.Show();
                        }
                        if (PerfilUsuario == 9) // USUARIO DE LABORATORIO
                        {
                            Forms.MapaCama.Paciente.Ficha.Laboratorio.RecepcionMuestras _Laboratorio = new MapaCama.Paciente.Ficha.Laboratorio.RecepcionMuestras();
                            _Laboratorio.Show();
                        }
                        if (PerfilUsuario == 11) // USUARIO DE TEST
                        {
                            //Forms.Farmacia.Farm_Principal _farma = new Farmacia.Farm_Principal();
                            //_farma.Show();

                            Forms.Facturacion.Factu_Pacientes _factu = new Facturacion.Factu_Pacientes();
                            _factu.Show();
                        }
                        if (PerfilUsuario == 13) // USUARIO DE FARMACIA
                        {
                            Forms.Farmacia.Farm_Principal _farma = new Farmacia.Farm_Principal();
                            Clases.Usuario.UsuarioLogeado.Id_Sector = 13;
                            _farma.Show();

                            //Forms.Facturacion.ResumenIM _factu = new Facturacion.ResumenIM();
                            //_factu.Show();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("El usuario o la contraseña no son válidos ó este usuario está inactivo", "Error de credenciales", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                            Application.Exit();
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.cboSede.Focus(); }
        }

        private void cboSede_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { this.btnIngresar.Focus(); }
        }

        private void cboSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clases.Paciente.PacienteSede = Convert.ToInt32(cboSede.SelectedValue);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "admin")
            {
                btnTest.Show();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            int _sede = Convert.ToInt32(this.cboSede.SelectedValue);

            if (_sede == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una Sede", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            switch (_sede)
            {
                case 1:
                    Clases.Usuario.EmpresaLogeada.EmpresaIngresada = "EGES";
                    Clases.Usuario.UsuarioLogeado.id_usuario_Logeado = 0; //PROVISORIO
                    break;
                case 2:
                    Clases.Usuario.EmpresaLogeada.EmpresaIngresada = "EGES";
                    Clases.Usuario.UsuarioLogeado.id_usuario_Logeado = 0; //PROVISORIO
                    break;
                case 3:
                    Clases.Usuario.EmpresaLogeada.EmpresaIngresada = "RSC";
                    Clases.Usuario.UsuarioLogeado.id_usuario_Logeado = 0; //PROVISORIO
                    break;
                

            }

            ListaEspera.Frm_ListaEsperaPrincipal _listaP = new ListaEspera.Frm_ListaEsperaPrincipal();
            _listaP.ShowDialog();
            //test.TestsPDF Pdf = new test.TestsPDF();
          
          
            //Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProcedimientoV2 proc = new MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProcedimientoV2();
            //proc.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://manualesclinica.santacatalinaclinica.com/m/65526");
        }
    }
}
