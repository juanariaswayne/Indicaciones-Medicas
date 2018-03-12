using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.Entity;
using MetroFramework;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento
{
    public partial class Nutricion : MetroForm
    {
        #region Variables
        public delegate void Indicacion();
        public event Indicacion ActualizarIndicacion;
        public IActuIndicaciones Opener { get; set; }
        private int suministro_procedimiento_id;
        public int Suministro_Procedimiento_Id
        {
            get
            {
                return suministro_procedimiento_id;
            }
            set
            {
                this.suministro_procedimiento_id = value;
            }
        }
        private int procedimiento_id;
        public int Procedimiento_Id
        {
            get
            {
                return procedimiento_id;
            }
            set
            {
                this.procedimiento_id = value;
            }
        }
        private int paciente_id;
        public int Paciente_Id
        {
            get
            {
                return paciente_id;
            }
            set
            {
                this.paciente_id = value;
            }
        }
        private int tipo_procedimiento_id;
        public int Tipo_Procedimiento_Id
        {
            get
            {
                return tipo_procedimiento_id;
            }
            set
            {
                this.tipo_procedimiento_id = value;
            }
        }
        private int nutricion_id;
        public int Nutricion_Id
        {
            get
            {
                return nutricion_id;
            }
            set
            {
                this.nutricion_id = value;
            }
        }
        #endregion

        #region Inicio
        // LOAD
        private void Nutricion_Load(object sender, EventArgs e)
        {
            try
            {
                if (suministro_procedimiento_id != 0)
                {
                    Get_Posologia(nutricion_id);
                    btnGuardar.Enabled = false;
                    btnSalir.Enabled = false;
                    btnModificar.Enabled = true;
                    btnSalir.Enabled = true;
                    this.chckProcedimientos.Checked = true;                
                }
                else
                {
                    btnModificar.Enabled = false;
                    this.groupSuspender.Enabled = false;
                    // Carga Combos
                    CargarCboAlimento(cboAlimento1);
                    CargarCboAlimento(cboAlimento2);
                    CargarCboAlimento(cboAlimento3);
                    CargarCboAlimento(cboAlimento4);
                    cboAlimento1.SelectedValue = "0";
                    cboAlimento2.SelectedValue = "0";
                    cboAlimento3.SelectedValue = "0";
                    cboAlimento4.SelectedValue = "0";
                    this.chckProcedimientos.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Nutricion()
        {
            InitializeComponent(); 
        }
        // VALIDACIONES
        private void txtVelocidadEnteral_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtGavageCantMl_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtVelocidadParenteral_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Eventos       
        // BOTONES
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // COMBOS
        //--------------------------------------------------------------------------------------------------------------------- COMBOS
        private void CargarCboAlimento(ComboBox _Combo)
        {
            try
            {
                SISTMEDEntities E = new SISTMEDEntities();

                TRAEENTERALES_Result Ent = new TRAEENTERALES_Result();
                Ent.art_DescGen = "Sin alimento enteral";
                Ent.art_CodGen = "0";

                var _lista = E.TRAEENTERALES().ToList();
                _lista.Add(Ent);
                _lista = _lista.OrderBy(s => s.art_DescGen).ToList();

                //Carga el combo
                _Combo.DataSource = _lista;
                _Combo.DisplayMember = "art_DescGen";
                _Combo.ValueMember = "art_Codgen";
                _Combo.ResumeLayout();                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        #endregion

        #region Metodos
        public void Limpiar()
        {
            try
            {
                this.txtObservacion.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        public void Graba_Historial_Suministro_Procedimiento_Nutricion()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                   SISTMEDEntities E = new SISTMEDEntities();

                    // Tabla PRO_SuministroDeProcedimiento
                    PRO_Historial_SuministroDeProcedimiento _itemSuministro = new PRO_Historial_SuministroDeProcedimiento();

                        foreach (var item in E.ObtieneUltimoId("PRO_Posologia")) // Nombre de la tabla en la que buscara
                        {
                            if (item.Value == 1)
                            { _itemSuministro.posologia_id = Convert.ToInt32(item.Value); }
                            else
                            { _itemSuministro.posologia_id = Convert.ToInt32(item.Value + 1); }

                        }
                        _itemSuministro.paciente_id = paciente_id;
                        _itemSuministro.procedimiento_id = procedimiento_id;
                        _itemSuministro.tipoProcedimiento_id = tipo_procedimiento_id;
                        _itemSuministro.fechaAltaSistema = System.DateTime.Now;
                        _itemSuministro.usuario_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;

                        E.Entry(_itemSuministro).State = System.Data.Entity.EntityState.Added;
                    // Tabla PRO_Posologia
                    PRO_Historial_Posologia _itemPosologia = new PRO_Historial_Posologia();

                        _itemPosologia.paciente_id = paciente_id;
                        _itemPosologia.procedimiento_id = procedimiento_id;
                        // ORAL
                        _itemPosologia.PlanOral = cboPlanOral.Text;
                        if (this.chckCortado.Checked) { _itemPosologia.Cortado = true; } else { _itemPosologia.Cortado = false; }
                        if (this.chckLiquidoAligerado.Checked) { _itemPosologia.LiquidosAligerados = true; } else { _itemPosologia.LiquidosAligerados = false; }
                        if (this.chckLiquidoEspeso.Checked) { _itemPosologia.LiquidosEspesos = true; } else { _itemPosologia.LiquidosEspesos = false; }
                        if (this.chckLiquidoFino.Checked) { _itemPosologia.LiquidosFinos = true; } else { _itemPosologia.LiquidosFinos = false; }
                        if (this.chckPicado.Checked) { _itemPosologia.Picado = true; } else { _itemPosologia.Picado = false; }
                        if (this.chckSupControl.Checked) { _itemPosologia.SupControl = true; } else { _itemPosologia.SupControl = false; }
                        if (this.ckchAsistencia.Checked) { _itemPosologia.Asistencia = true; } else { _itemPosologia.Asistencia = false; }
                        if (this.ckchSinLiquidos.Checked) { _itemPosologia.SinLiquidos = true; } else { _itemPosologia.SinLiquidos = false; }
                        if (this.chckHiposodico.Checked) { _itemPosologia.hiposodica = true; } else { _itemPosologia.hiposodica = false; }
                        if (this.chckDBT.Checked) { _itemPosologia.dbt = true; } else { _itemPosologia.dbt = false; }

                        // ENTERAL
                        _itemPosologia.alimento_id = this.cboAlimento1.SelectedValue.ToString();
                        _itemPosologia.alimentoVelocidad = txtVelocidad1.Text == "" ? 0 : Convert.ToInt32(this.txtVelocidad1.Text.ToString());
                        _itemPosologia.horario_alimento = this.txtHorario1.Text;

                        _itemPosologia.alimento_id2 = this.cboAlimento2.SelectedValue.ToString();
                        _itemPosologia.alimentoVelocidad2 = txtVelocidad2.Text == "" ? 0 : Convert.ToInt32(this.txtVelocidad2.Text.ToString());
                        _itemPosologia.horario_alimento2 = this.txtHorario2.Text;

                        _itemPosologia.alimento_id3 = this.cboAlimento3.SelectedValue.ToString();
                        _itemPosologia.alimento_velocidad3 = txtVelocidad3.Text == "" ? 0 : Convert.ToInt32(this.txtVelocidad3.Text.ToString());
                        _itemPosologia.horario_alimento3 = this.txtHorario3.Text;

                        _itemPosologia.alimento_id4 = this.cboAlimento4.SelectedValue.ToString();
                        _itemPosologia.alimentoVelocidad4 = txtVelocidad4.Text == "" ? 0 : Convert.ToInt32(this.txtVelocidad4.Text.ToString());
                        _itemPosologia.horario_alimento4 = this.txtHorario4.Text;


                        _itemPosologia.observacion = this.txtObservacion.Text;
                        _itemPosologia.usuario_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                        _itemPosologia.fechaAltaSistema = System.DateTime.Now;
                        _itemPosologia.fechaModificacion = System.DateTime.Now;

                        E.Entry(_itemPosologia).State = System.Data.Entity.EntityState.Added;

                        E.SaveChanges();

                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AlreadyExists()
        {
            SISTMEDEntities A = new SISTMEDEntities();
            if (A.PRO_Posologia.Find(nutricion_id) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool AlreadyExistsSuministro()
        {
            SISTMEDEntities A = new SISTMEDEntities();
            if (A.PRO_SuministroDeProcedimiento.Find(suministro_procedimiento_id) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Modifica_Suministro_Procedimiento_Nutricion()
        {
            try
            {
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    SISTMEDEntities E = new SISTMEDEntities();
                    // Tabla PRO_SuministroDeProcedimiento
                    PRO_SuministroDeProcedimiento _itemSuministro = new PRO_SuministroDeProcedimiento();

                    foreach (var item in E.ObtieneUltimoId("PRO_Posologia")) // Nombre de la tabla en la que buscara
                    {
                        if(suministro_procedimiento_id == 0)
                        {
                            if (item.Value == 1)
                            { _itemSuministro.posologia_id = Convert.ToInt32(item.Value); }
                            else
                            { _itemSuministro.posologia_id = Convert.ToInt32(item.Value + 1); }
                        }
                        else
                        {
                            _itemSuministro.posologia_id = nutricion_id;
                        }                        

                    }
                    _itemSuministro.paciente_id = paciente_id;
                    _itemSuministro.procedimiento_id = procedimiento_id;
                    _itemSuministro.tipoProcedimiento_id = tipo_procedimiento_id;
                    _itemSuministro.fechaAltaSistema = System.DateTime.Now;
                    _itemSuministro.usuario_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemSuministro.suministroDeProcedimiento_id = suministro_procedimiento_id;

                    E.Entry(_itemSuministro).State = (AlreadyExistsSuministro() ? EntityState.Modified : EntityState.Added);
                    // Tabla PRO_Posologia
                    PRO_Posologia _itemPosologia = new PRO_Posologia();

                    _itemPosologia.paciente_id = paciente_id;
                    _itemPosologia.procedimiento_id = procedimiento_id;
                    _itemPosologia.posologia_id = nutricion_id;
                    // ORAL
                    _itemPosologia.PlanOral = cboPlanOral.Text;
                    if (this.chckCortado.Checked) { _itemPosologia.Cortado = true; } else { _itemPosologia.Cortado = false; }
                    if (this.chckLiquidoAligerado.Checked) { _itemPosologia.LiquidosAligerados = true; } else { _itemPosologia.LiquidosAligerados = false; }
                    if (this.chckLiquidoEspeso.Checked) { _itemPosologia.LiquidosEspesos = true; } else { _itemPosologia.LiquidosEspesos = false; }
                    if (this.chckLiquidoFino.Checked) { _itemPosologia.LiquidosFinos = true; } else { _itemPosologia.LiquidosFinos = false; }
                    if (this.chckPicado.Checked) { _itemPosologia.Picado = true; } else { _itemPosologia.Picado = false; }
                    if (this.chckSupControl.Checked) { _itemPosologia.SupControl = true; } else { _itemPosologia.SupControl = false; }
                    if (this.ckchAsistencia.Checked) { _itemPosologia.Asistencia = true; } else { _itemPosologia.Asistencia = false; }
                    if (this.ckchSinLiquidos.Checked) { _itemPosologia.SinLiquidos = true; } else { _itemPosologia.SinLiquidos = false; }
                    if (this.chckHiposodico.Checked) { _itemPosologia.hiposodica = true; } else { _itemPosologia.hiposodica = false; }
                    if (this.chckDBT.Checked) { _itemPosologia.dbt = true; } else { _itemPosologia.dbt = false; }
                    if (this.chckACO.Checked) { _itemPosologia.ACO = true; } else { _itemPosologia.ACO = false; }
                    if (this.chckIRA.Checked) { _itemPosologia.IRA = true; } else { _itemPosologia.IRA = false; }
                    if (this.chckICR.Checked) { _itemPosologia.IRC = true; } else { _itemPosologia.IRC = false; }
                    if (this.chckSorbete.Checked) { _itemPosologia.Sorbete = true; } else { _itemPosologia.Sorbete = false; }
                    if (this.chckCeliaco.Checked) { _itemPosologia.Celiaco = true; } else { _itemPosologia.Celiaco = false; }
                    if (this.chckHepatoProtector.Checked) { _itemPosologia.HepatoProtector = true; } else { _itemPosologia.HepatoProtector = false; }
                    if (this.chckHipercalorica.Checked) { _itemPosologia.Hipercalorico = true; } else { _itemPosologia.Hipercalorico = false; }
                    if (this.chckHipocalorica.Checked) { _itemPosologia.Hipocalorico = true; } else { _itemPosologia.Hipocalorico = false; }


                    // ENTERAL
                    _itemPosologia.alimento_id = this.cboAlimento1.SelectedValue.ToString();
                    _itemPosologia.alimentoVelocidad = txtVelocidad1.Text == "" ? 0 : Convert.ToInt32(this.txtVelocidad1.Text.ToString());
                    _itemPosologia.horario_alimento = this.txtHorario1.Text;
                    _itemPosologia.VolT1 = this.txtVolTot1.Text;
                    _itemPosologia.Goteo1 = radioGoteo1.Checked;
                    _itemPosologia.Paralelo1 = radioParalelo1.Checked;

                    _itemPosologia.alimento_id2 = this.cboAlimento2.SelectedValue.ToString();
                    _itemPosologia.alimentoVelocidad2 = txtVelocidad2.Text == "" ? 0 : Convert.ToInt32(this.txtVelocidad2.Text.ToString());
                    _itemPosologia.horario_alimento2 = this.txtHorario2.Text;
                    _itemPosologia.VolT2 = this.txtVolTot2.Text;
                    _itemPosologia.Goteo2 = radioGoteo2.Checked;
                    _itemPosologia.Paralelo2 = radioParalelo2.Checked;

                    _itemPosologia.alimento_id3 = this.cboAlimento3.SelectedValue.ToString();
                    _itemPosologia.alimento_velocidad3 = txtVelocidad3.Text == "" ? 0 : Convert.ToInt32(this.txtVelocidad3.Text.ToString());
                    _itemPosologia.horario_alimento3 = this.txtHorario3.Text;
                    _itemPosologia.VolT3 = this.txtVolTot3.Text;
                    _itemPosologia.Goteo3 = radioGoteo3.Checked;
                    _itemPosologia.Paralelo3 = radioParalelo3.Checked;

                    _itemPosologia.alimento_id4 = this.cboAlimento4.SelectedValue.ToString();
                    _itemPosologia.alimentoVelocidad4 = txtVelocidad4.Text == "" ? 0 : Convert.ToInt32(this.txtVelocidad4.Text.ToString());
                    _itemPosologia.horario_alimento4 = this.txtHorario4.Text;
                    _itemPosologia.VolT4 = this.txtVolTot4.Text;
                    _itemPosologia.Goteo4 = radioGoteo4.Checked;
                    _itemPosologia.Paralelo4 = radioParalelo4.Checked;

                    _itemPosologia.SNG = radioSNG.Checked;
                    _itemPosologia.Gastro = radioGastro.Checked;
                    _itemPosologia.Yeyunostomia = radioYeyu.Checked;
                    _itemPosologia.Oral = radioOral.Checked;

                    _itemPosologia.observacion = this.txtObservacion.Text;
                    _itemPosologia.usuario_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    _itemPosologia.fechaAltaSistema = System.DateTime.Now;
                    _itemPosologia.fechaModificacion = System.DateTime.Now;

                    _itemPosologia.ml_frasco1 = txtMlFrasco1.Text == ""? 0 : Convert.ToInt32(txtMlFrasco1.Text);
                    _itemPosologia.ml_frasco2 = txtMlFrasco2.Text == "" ? 0 : Convert.ToInt32(txtMlFrasco2.Text);
                    _itemPosologia.ml_frasco3 = txtMlFrasco3.Text == "" ? 0 : Convert.ToInt32(txtMlFrasco3.Text);
                    _itemPosologia.ml_frasco4 = txtMlFrasco4.Text == "" ? 0 : Convert.ToInt32(txtMlFrasco4.Text);


                    if (txtSuspenderMotivo.Text != string.Empty)
                    {
                        _itemPosologia.fechaBaja = DateTime.Now;
                        _itemPosologia.motivoBaja = txtSuspenderMotivo.Text;
                        _itemSuministro.fechaBaja = DateTime.Now;
                        _itemSuministro.motivoBaja = txtSuspenderMotivo.Text;
                    }

                    E.Entry(_itemPosologia).State = (AlreadyExists() ? EntityState.Modified : EntityState.Added);

                    E.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        // Recupera Posologia
        private void Get_Posologia(int nutricion_id)
        {
            // Carga Combos
            CargarCboAlimento(cboAlimento1);
            CargarCboAlimento(cboAlimento2);
            CargarCboAlimento(cboAlimento3);
            CargarCboAlimento(cboAlimento4);

            try
            {
                CultureInfo culture = new CultureInfo("en-US");

                SISTMEDEntities E = new SISTMEDEntities();

               
                foreach (var item in E.PRO_Posologia.Where(n=>n.posologia_id == nutricion_id))
                {
                    this.cboPlanOral.Text = item.PlanOral.ToString();
                    this.chckCortado.Checked = item.Cortado.Value;
                    this.chckLiquidoAligerado.Checked = item.LiquidosAligerados.Value;
                    this.chckLiquidoEspeso.Checked = item.LiquidosEspesos.Value;
                    this.chckLiquidoFino.Checked = item.LiquidosFinos.Value;
                    this.chckPicado.Checked = item.Picado.Value;
                    this.chckSupControl.Checked = item.SupControl.Value;
                    this.ckchAsistencia.Checked = item.Asistencia.Value;
                    this.ckchSinLiquidos.Checked = item.SinLiquidos.Value;
                    this.chckHiposodico.Checked = item.hiposodica.Value;
                    this.chckDBT.Checked = item.dbt.Value;
                    this.chckACO.Checked = item.ACO.Value;
                    this.chckICR.Checked = item.IRC.Value;
                    this.chckIRA.Checked = item.IRA.Value;
                    this.chckSorbete.Checked = item.Sorbete.Value;
                    this.chckCeliaco.Checked = item.Celiaco.Value;
                    this.chckHipercalorica.Checked = item.Hipercalorico.Value;
                    this.chckHipocalorica.Checked = item.Hipocalorico.Value;
                    this.chckHepatoProtector.Checked = item.HepatoProtector.Value;
                    // ENTERAL
                    this.cboAlimento1.SelectedValue = item.alimento_id;
                    this.txtVelocidad1.Text = item.alimentoVelocidad.ToString();
                    this.txtHorario1.Text = item.horario_alimento;
                    this.txtVolTot1.Text = item.VolT1.ToString();
                    this.radioGoteo1.Checked = item.Goteo1.Value;
                    this.radioParalelo1.Checked = item.Paralelo1.Value;

                    this.cboAlimento2.SelectedValue = item.alimento_id2;
                    this.txtVelocidad2.Text = item.alimentoVelocidad2.ToString();
                    this.txtHorario2.Text = item.horario_alimento2;
                    this.txtVolTot2.Text = item.VolT2.ToString();
                    this.radioGoteo2.Checked = item.Goteo2.Value;
                    this.radioParalelo2.Checked = item.Paralelo2.Value;

                    this.cboAlimento3.SelectedValue = item.alimento_id3;
                    this.txtVelocidad3.Text = item.alimento_velocidad3.ToString();
                    this.txtHorario3.Text = item.horario_alimento3;
                    this.txtVolTot3.Text = item.VolT3.ToString();
                    this.radioGoteo3.Checked = item.Goteo3.Value;
                    this.radioParalelo3.Checked = item.Paralelo3.Value;

                    this.cboAlimento4.SelectedValue =item.alimento_id4;
                    this.txtVelocidad4.Text = item.alimentoVelocidad4.ToString();
                    this.txtHorario4.Text = item.horario_alimento4;
                    this.txtVolTot4.Text = item.VolT4.ToString();
                    this.radioGoteo4.Checked = item.Goteo4.Value;
                    this.radioParalelo4.Checked = item.Paralelo4.Value;

                    this.radioSNG.Checked = item.SNG.Value;
                    this.radioGastro.Checked = item.Gastro.Value;
                    this.radioYeyu.Checked = item.Yeyunostomia.Value;
                    this.radioOral.Checked = item.Oral.Value;

                    this.txtObservacion.Text = item.observacion;
                    
                    txtMlFrasco1.Text = item.ml_frasco1.ToString();
                    txtMlFrasco2.Text = item.ml_frasco2.ToString();
                    txtMlFrasco3.Text = item.ml_frasco3.ToString();
                    txtMlFrasco4.Text = item.ml_frasco4.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                {
                    if (this.txtSuspenderMotivo.Text != String.Empty)
                    {
                        #region Suspender
                        DialogResult dialogResult = MessageBox.Show("Seguro que desea supender este procedimiento?", "Procedimiento - Nutrición", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {
                                Graba_Historial_Suministro_Procedimiento_Nutricion();
                                Modifica_Suministro_Procedimiento_Nutricion();
                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ActualizarIndicacion();
                                this.Close();
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                this.Close();
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        #region Modifica
                        DialogResult dialogResult = MessageBox.Show("Desea modificar el procedimiento?", "Procedimiento - Nutrición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        {
                            if (dialogResult == DialogResult.Yes)
                            {

                                Graba_Historial_Suministro_Procedimiento_Nutricion();
                                Modifica_Suministro_Procedimiento_Nutricion();
                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ActualizarIndicacion();
                                this.Close();

                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                //do something else
                            }
                        }
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DialogResult dialogResult = MessageBox.Show("Desea guardar el procedimiento?", "Procedimiento - Nutrición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            SISTMEDEntities E = new SISTMEDEntities();

                            var q = from N in E.PRO_SuministroDeProcedimiento where N.paciente_id == paciente_id && N.tipoProcedimiento_id == 2 && N.fechaBaja == null select N;

                            if (q.ToList().Count() > 0)
                            {
                                MessageBox.Show("Ya existe una nutricion para este paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                Modifica_Suministro_Procedimiento_Nutricion();
                                Graba_Historial_Suministro_Procedimiento_Nutricion();
                                MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Opener.IActualiza();
                                this.Close();
                            }

                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chckSuspender_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(chckSuspender.Checked)
                {
                    txtSuspenderMotivo.Text = "Baja";
                }
                else
                {
                    txtSuspenderMotivo.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboAlimento1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cboAlimento1.Text != "AGUA PARA ENTERAL")
                {
                    radioGoteo1.Checked = false;
                    radioParalelo1.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboAlimento2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboAlimento2.Text != "AGUA PARA ENTERAL")
                {
                    radioGoteo2.Checked = false;
                    radioParalelo2.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboAlimento3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboAlimento3.Text != "AGUA PARA ENTERAL")
                {
                    radioGoteo3.Checked = false;
                    radioParalelo3.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboAlimento4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboAlimento4.Text != "AGUA PARA ENTERAL")
                {
                    radioGoteo4.Checked = false;
                    radioParalelo4.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                {
                    DialogResult dialogResult = MessageBox.Show("Desea guardar el procedimiento?", "Procedimiento - Nutrición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (radioGastro.Checked == false && radioSNG.Checked == false && radioYeyu.Checked == false && radioOral.Checked == false)
                            {
                                MessageBox.Show("Debe seleccionar un tipo de nutricion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                SISTMEDEntities E = new SISTMEDEntities();

                                var q = from N in E.PRO_SuministroDeProcedimiento where N.paciente_id == paciente_id && N.tipoProcedimiento_id == 2 && N.fechaBaja == null select N;

                                if (q.ToList().Count() > 0)
                                {
                                    MessageBox.Show("Ya existe una nutricion para este paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    Modifica_Suministro_Procedimiento_Nutricion();
                                    Graba_Historial_Suministro_Procedimiento_Nutricion();
                                    MessageBox.Show("La Operación se realizó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Opener.IActualiza();
                                    this.Close();
                                }
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
