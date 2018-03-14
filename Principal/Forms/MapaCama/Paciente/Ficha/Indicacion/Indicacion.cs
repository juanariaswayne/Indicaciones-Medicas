using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Forms.MapaCama.Paciente.Ficha.Indicacion
{
    public interface IActuIndicaciones
    {
        void IActualiza();
    }

    public partial class Indicacion : MetroForm, IActuIndicaciones
    {       

        #region Variables

        int _idPaciente;
        string medicamento_id;
        int procedimiento_id;
        int suministro_medicacion_id;

        public int IdPaciente
        {
            get
            {
                return _idPaciente;
            }

            set
            {
                this._idPaciente = value;
            }
        }

        private enum Col_Pacientes
        {
            PACIENTE_ID = 0,
            HABITACION,
            PACIENTE
        }
        private enum Col_Medicamentos
        {
            SUMINISTRODEMEDICACION_ID = 0,
            PACIENTE_ID,
            MEDICACION_ID,
            FECHA_INICIO,
            MEDICAMENTO,            
            HORARIODESUMINISTRO,
            FECHA_HASTA,
            OBSERVACION,
            MEDICO
        }
        private enum Col_Procedimientos
        {
            SUMINISTRO_PROCEDIMIENTO_ID = 0,
            PROCEDIMIENTO_ID,
            PROCEDIMIENTO,
            TIPO_PROCEDIMIENTO_ID,
            TIPO_PROCEDIMIENTO,
            ENFERMERIA_ID,
            POSOLOGIA_ID,
            GENERICO_ID,
            COLOCACIONVIAPERIFERICA_ID,
            CUIDADOORAL_ID,
            CUIDADOPOSTURAL_ID,
            PROTECCIONFISICA_ID,
            PHP_ID
        }

        #endregion
       
        #region Eventos
        //--------------------------------------------------------------------------------------------------------------------- LOAD
        public Indicacion()
        {
            InitializeComponent();
        }

        private void Indicacion_Load(object sender, EventArgs e)
        {
            try
            {
                if(Clases.Usuario.UsuarioLogeado.Id_Sector == 4 || Clases.Usuario.UsuarioLogeado.Id_Sector == 3 || Clases.Usuario.UsuarioLogeado.Id_Sector == 1002 || Clases.Usuario.UsuarioLogeado.Id_Sector == 6)
                {
                    this.btnMedicacion.Enabled = false;
                    if(Clases.Usuario.UsuarioLogeado.Id_Sector != 6)
                    { this.btnProcedimiento.Enabled = false; } 
                }
                IdPaciente = Clases.Paciente.PacienteIngresado;
                Trae_Medicacion_Paciente(IdPaciente, medicamento_id);
                Trae_Procedimientos_Paciente(IdPaciente, procedimiento_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //--------------------------------------------------------------------------------------------------------------------- MEDICAMENTOS

        private void dataGridViewMedicacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Clases.Usuario.UsuarioLogeado.Id_Sector == 1 || Clases.Usuario.UsuarioLogeado.Id_Sector == 8)
            {
                Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.Medicacion _SuministroDeMedicacion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.Medicacion();
                _SuministroDeMedicacion.Paciente_Id = IdPaciente;
                _SuministroDeMedicacion.Medicamento_Id = Convert.ToString(dataGridViewMedicacion.CurrentRow.Cells[(int)Col_Medicamentos.MEDICACION_ID].Value);
                _SuministroDeMedicacion.Suministro_Medicacion_Id = Convert.ToInt32(dataGridViewMedicacion.CurrentRow.Cells[(int)Col_Medicamentos.SUMINISTRODEMEDICACION_ID].Value);
                _SuministroDeMedicacion.Opener = this;
                _SuministroDeMedicacion.ShowDialog();
            }
        }

        private void dataGridViewMedicamento_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewProcedimiento.IsCurrentCellDirty)
                dataGridViewProcedimiento.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        //--------------------------------------------------------------------------------------------------------------------- PROCEDIMIENTOS
        private void dataGridViewProcedimiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (Clases.Usuario.UsuarioLogeado.Id_Sector == 1 || Clases.Usuario.UsuarioLogeado.Id_Sector == 8 || Clases.Usuario.UsuarioLogeado.Id_Sector == 1002 || Clases.Usuario.UsuarioLogeado.Id_Sector == 6)
            {
                this.Cursor = Cursors.WaitCursor;
                int tipo = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.TIPO_PROCEDIMIENTO_ID].Value);
                switch (tipo)
                {
                    case 1:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Enfermeria _Enfermeria = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Enfermeria();
                        _Enfermeria.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.SUMINISTRO_PROCEDIMIENTO_ID].Value);
                        _Enfermeria.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.PROCEDIMIENTO_ID].Value);
                        _Enfermeria.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.TIPO_PROCEDIMIENTO_ID].Value);
                        _Enfermeria.Enfermeria_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.ENFERMERIA_ID].Value);
                        _Enfermeria.Paciente_Id = IdPaciente;
                        _Enfermeria.ActualizarIndicacion += new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Enfermeria.Indicacion(ActualizarIndicacion);
                        _Enfermeria.ShowDialog();
                        break;

                    case 2:
                       
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Nutricion _Nutricion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Nutricion();
                        _Nutricion.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.SUMINISTRO_PROCEDIMIENTO_ID].Value);
                        _Nutricion.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.PROCEDIMIENTO_ID].Value);
                        _Nutricion.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.TIPO_PROCEDIMIENTO_ID].Value);
                        _Nutricion.Nutricion_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.POSOLOGIA_ID].Value);
                        _Nutricion.Paciente_Id = IdPaciente;
                        _Nutricion.ActualizarIndicacion += new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.Nutricion.Indicacion(ActualizarIndicacion);
                        _Nutricion.ShowDialog();
                        
                        break;

                    case 3:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProcedimientoV2 _Generico = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProcedimientoV2();
                        _Generico.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.SUMINISTRO_PROCEDIMIENTO_ID].Value);
                        _Generico.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.PROCEDIMIENTO_ID].Value);
                        _Generico.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.TIPO_PROCEDIMIENTO_ID].Value);
                        _Generico.Generico_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.GENERICO_ID].Value);
                        _Generico.Paciente_Id = IdPaciente;
                        _Generico.ActualizarIndicacion += new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProcedimientoV2.Indicacion(ActualizarIndicacion);
                        _Generico.ShowDialog();
                        break;

                    case 4:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ColocacionViaPeriferica _ColocacionViaPeriferica = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ColocacionViaPeriferica();
                        _ColocacionViaPeriferica.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.SUMINISTRO_PROCEDIMIENTO_ID].Value);
                        _ColocacionViaPeriferica.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.PROCEDIMIENTO_ID].Value);
                        _ColocacionViaPeriferica.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.TIPO_PROCEDIMIENTO_ID].Value);
                        _ColocacionViaPeriferica.ColocacionViaPeriferica_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.COLOCACIONVIAPERIFERICA_ID].Value);
                        _ColocacionViaPeriferica.Paciente_Id = IdPaciente;
                        _ColocacionViaPeriferica.ActualizarIndicacion += new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ColocacionViaPeriferica.Indicacion(ActualizarIndicacion);
                        _ColocacionViaPeriferica.ShowDialog();
                        break;

                    case 5:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.CuidadoOral _CuidadoOral = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.CuidadoOral();
                        _CuidadoOral.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.SUMINISTRO_PROCEDIMIENTO_ID].Value);
                        _CuidadoOral.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.PROCEDIMIENTO_ID].Value);
                        _CuidadoOral.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.TIPO_PROCEDIMIENTO_ID].Value);
                        _CuidadoOral.CuidadoOral_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.CUIDADOORAL_ID].Value);
                        _CuidadoOral.Paciente_Id = IdPaciente;
                        _CuidadoOral.ActualizarIndicacion += new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.CuidadoOral.Indicacion(ActualizarIndicacion);
                        _CuidadoOral.ShowDialog();
                        break;

                    case 6:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.CuidadoPostural _CuidadoPostural = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.CuidadoPostural();
                        _CuidadoPostural.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.SUMINISTRO_PROCEDIMIENTO_ID].Value);
                        _CuidadoPostural.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.PROCEDIMIENTO_ID].Value);
                        _CuidadoPostural.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.TIPO_PROCEDIMIENTO_ID].Value);
                        _CuidadoPostural.CuidadoPostural_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.CUIDADOPOSTURAL_ID].Value);
                        _CuidadoPostural.Paciente_Id = IdPaciente;
                        _CuidadoPostural.ActualizarIndicacion += new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.CuidadoPostural.Indicacion(ActualizarIndicacion);
                        _CuidadoPostural.ShowDialog();
                        break;

                    case 7:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProteccionFisica _ProteccionFisica = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProteccionFisica();
                        _ProteccionFisica.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.SUMINISTRO_PROCEDIMIENTO_ID].Value);
                        _ProteccionFisica.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.PROCEDIMIENTO_ID].Value);
                        _ProteccionFisica.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.TIPO_PROCEDIMIENTO_ID].Value);
                        _ProteccionFisica.ProteccionFisica_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.PROTECCIONFISICA_ID].Value);
                        _ProteccionFisica.Paciente_Id = IdPaciente;
                        _ProteccionFisica.ActualizarIndicacion += new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.ProteccionFisica.Indicacion(ActualizarIndicacion);
                        _ProteccionFisica.ShowDialog();
                        break;

                    case 8:
                        Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.PHPV2 _Php = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.PHPV2();
                        _Php.Suministro_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.SUMINISTRO_PROCEDIMIENTO_ID].Value);
                        _Php.Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.PROCEDIMIENTO_ID].Value);
                        _Php.Tipo_Procedimiento_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.TIPO_PROCEDIMIENTO_ID].Value);
                        //_Php.Php_Id = Convert.ToInt32(dataGridViewProcedimiento.CurrentRow.Cells[(int)Col_Procedimientos.PHP_ID].Value);
                        _Php.Paciente_Id = IdPaciente;
                        _Php.ActualizarIndicacion += new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.PHPV2.Indicacion(ActualizarIndicacion);
                        _Php.ShowDialog();
                        break;
                }
                this.Cursor = Cursors.Arrow;
               
            }
        }

        private void dataGridViewProcedimiento_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewProcedimiento.IsCurrentCellDirty)
                dataGridViewProcedimiento.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        //--------------------------------------------------------------------------------------------------------------------- BOTONES
       
        private void btnMedicacion_Click(object sender, EventArgs e)
        {
            Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.SeleccionarMedicamento _SeleccionarMedicacion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.SeleccionarMedicamento();
            _SeleccionarMedicacion.IdPaciente = IdPaciente;
            _SeleccionarMedicacion.Indicacion = this; // Le paso a la variable publica mi instancia, para que el formulario Medicacion sepa donde actualizar          
            _SeleccionarMedicacion.ShowDialog();            
        }
      
        private void btnImprimir_Click(object sender, EventArgs e)
        {
          
        }
        
        #endregion

        #region Metodos
        //--------------------------------------------------------------------------------------------------------------------- MEDICAMENTOS
        private void Trae_Medicacion_Paciente(int _idPaciente, string _idMedicamento)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.MED_GET_SUMINISTRO_MEDICACION _obtieneIndicaciones = new BLL.Procedures.MED_GET_SUMINISTRO_MEDICACION();
                this.dataGridViewMedicacion.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.MED_GET_SUMINISTRO_MEDICACION item in _obtieneIndicaciones.ItemList(suministro_medicacion_id, _idPaciente, medicamento_id, "PAC"))
                {
                    indice = dataGridViewMedicacion.Rows.Add();
                    dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.SUMINISTRODEMEDICACION_ID].Value = item.suministrodemedicacion_id;
                    dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.PACIENTE_ID].Value = item.paciente_id;
                    dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.MEDICACION_ID].Value = item.medicamento_id;
                    dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.FECHA_INICIO].Value = item.fechainicio;
                    dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.MEDICAMENTO].Value = item.droga + " " + item.potencia + "  - " + " ( " + item.dosis + "  " + item.unimed + " )";
                    if (item.lapsodetiempohasta.ToShortDateString().ToString() != DateTime.MinValue.ToShortDateString() && Convert.ToDateTime (item.lapsodetiempohasta.ToShortDateString()) < Convert.ToDateTime (DateTime.Now.ToShortDateString()))
                    {
                        dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.FECHA_HASTA].Value = (item.lapsodetiempohasta.ToShortDateString().ToString() == DateTime.MinValue.ToShortDateString()) ? string.Empty : item.lapsodetiempohasta.ToShortDateString();
                        dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.FECHA_HASTA].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.FECHA_HASTA].Value = (item.lapsodetiempohasta.ToShortDateString().ToString() == DateTime.MinValue.ToShortDateString()) ? string.Empty : item.lapsodetiempohasta.ToShortDateString();
                    }
                    dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.OBSERVACION].Value = item.observacion.ToUpper();

                    String _Horario;
                    _Horario = "";
                    if (item.hs_24 == true)
                    {
                        _Horario = "24-" + _Horario;
                    }
                    if (item.hs_23 == true)
                    {
                        _Horario = "23-" + _Horario;
                    }
                    if (item.hs_22 == true)
                    {
                        _Horario = "22-" + _Horario;
                    }
                    if (item.hs_21 == true)
                    {
                        _Horario = "21-" + _Horario;
                    }
                    if (item.hs_20 == true)
                    {
                        _Horario = "20-" + _Horario;
                    }
                    if (item.hs_19 == true)
                    {
                        _Horario = "19-" + _Horario;
                    }
                    if (item.hs_18 == true)
                    {
                        _Horario = "18-" + _Horario;
                    }
                    if (item.hs_17 == true)
                    {
                        _Horario = "17-" + _Horario;
                    }
                    if (item.hs_16 == true)
                    {
                        _Horario = "16-" + _Horario;
                    }
                    if (item.hs_15 == true)
                    {
                        _Horario = "15-" + _Horario;
                    }
                    if (item.hs_14 == true)
                    {
                        _Horario = "14-" + _Horario;
                    }
                    if (item.hs_13 == true)
                    {
                        _Horario = "13-" + _Horario;
                    }
                    if (item.hs_12 == true)
                    {
                        _Horario = "12-" + _Horario;
                    }
                    if (item.hs_11 == true)
                    {
                        _Horario = "11-" + _Horario;
                    }
                    if (item.hs_10 == true)
                    {
                        _Horario = "10-" + _Horario;
                    }
                    if (item.hs_09 == true)
                    {
                        _Horario = "09-" + _Horario;
                    }
                    if (item.hs_08 == true)
                    {
                        _Horario = "08-" + _Horario;
                    }
                    if (item.hs_07 == true)
                    {
                        _Horario = "07-" + _Horario;
                    }
                    if (item.hs_06 == true)
                    {
                        _Horario = "06-" + _Horario;
                    }
                    if (item.hs_05 == true)
                    {
                        _Horario = "05-" + _Horario;
                    }
                    if (item.hs_04 == true)
                    {
                        _Horario = "04-" + _Horario;
                    }
                    if (item.hs_03 == true)
                    {
                        _Horario = "03-" + _Horario;
                    }
                    if (item.hs_02 == true)
                    {
                        _Horario = "02-" + _Horario;
                    }
                    if (item.hs_01 == true)
                    {
                        _Horario = "01-" + _Horario;
                    }
                    if(item.hs_sh == true) //Otro horario
                    {
                        _Horario = "Otro";
                    }

                    
                    if (_Horario == "")
                    {
                        dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.HORARIODESUMINISTRO].Value = item.evento.ToUpper() + " // " + item.via; 
                    }
                    else
                    {
                        if (_Horario == "Otro")
                        {
                            dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.HORARIODESUMINISTRO].Value = item.horariootro.ToUpper() +" // " + item.via;
                        }
                        else
                        {
                            _Horario = _Horario.Substring(0, _Horario.Length - 1);
                            if (item.viatieneotro == true)
                            {
                                dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.HORARIODESUMINISTRO].Value = _Horario + " // " + item.viaotro.ToUpper();
                            }
                            else
                            {
                                dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.HORARIODESUMINISTRO].Value = _Horario + " // " + item.via;
                            }
                        }
                    }

                    dataGridViewMedicacion.Rows[indice].Cells[(int)Col_Medicamentos.MEDICO].Value = item.nombreusuario;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------------------------------------------------------------------------------------- PROCEDIMIENTOS
        private void Trae_Procedimientos_Paciente(int _idPaciente, int procedimiento_id)
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                BLL.Procedures.PRO_GET_PROCEDIMIENTO_PACIENTE _detalle = new BLL.Procedures.PRO_GET_PROCEDIMIENTO_PACIENTE();
                this.dataGridViewProcedimiento.Rows.Clear();
                int indice;
                foreach (Entities.Procedures.PRO_GET_PROCEDIMIENTO_PACIENTE item in _detalle.ItemList(_idPaciente))
                {
                    indice = dataGridViewProcedimiento.Rows.Add();
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.SUMINISTRO_PROCEDIMIENTO_ID].Value = item.suministrodeprocedimiento_id;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.PROCEDIMIENTO_ID].Value = item.procedimiento_id;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.PROCEDIMIENTO].Value = item.procedimiento;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.TIPO_PROCEDIMIENTO_ID].Value = item.tipoprocedimiento_id;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.TIPO_PROCEDIMIENTO].Value = item.tipoprocedimiento;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.ENFERMERIA_ID].Value = item.enfermeria_id;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.POSOLOGIA_ID].Value = item.posologia_id;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.GENERICO_ID].Value = item.generico_id;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.COLOCACIONVIAPERIFERICA_ID].Value = item.colocacionviaperiferica_id;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.CUIDADOORAL_ID].Value = item.cuidadooral_id;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.CUIDADOPOSTURAL_ID].Value = item.cuidadopostural_id;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.PROTECCIONFISICA_ID].Value = item.proteccionfisica_id;
                    dataGridViewProcedimiento.Rows[indice].Cells[(int)Col_Procedimientos.PHP_ID].Value = item.php_id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargaIndicaciones()
        {
            try
            {
                IdPaciente = Clases.Paciente.PacienteIngresado;
                Trae_Medicacion_Paciente(IdPaciente, medicamento_id);
                Trae_Procedimientos_Paciente(IdPaciente, procedimiento_id);
                tabIndicacion.SelectedTab = tabIndicacion.TabPages[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ActualizarIndicacion()
        {
            Trae_Medicacion_Paciente(_idPaciente, medicamento_id);
            Trae_Procedimientos_Paciente(_idPaciente, procedimiento_id);
        }
        public void IActualiza()
        {
           
            Trae_Medicacion_Paciente(Clases.Paciente.PacienteIngresado, "");
            Trae_Procedimientos_Paciente(Clases.Paciente.PacienteIngresado, 1);
        }
        #endregion

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.Historial_Medicacion _HisMed = new Ficha.Indicacion.Medicamento.Historial_Medicacion();
            _HisMed.ShowDialog();
            Cursor = Cursors.Arrow;
        }

        private void btnMedicacion_Click_1(object sender, EventArgs e)
        {
            Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.SeleccionarMedicamento _SeleccionarMedicacion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Medicamento.SeleccionarMedicamento();
            _SeleccionarMedicacion.IdPaciente = IdPaciente;
            _SeleccionarMedicacion.Indicacion = this; // Le paso a la variable publica mi instancia, para que el formulario Medicacion sepa donde actualizar          
            _SeleccionarMedicacion.ShowDialog();
        }

        private void btnProcedimiento_Click_1(object sender, EventArgs e)
        {
            Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.SeleccionarProcedimiento _SeleccionarProcedimiento = new Forms.MapaCama.Paciente.Ficha.Indicacion.Procedimiento.SeleccionarProcedimiento();
            _SeleccionarProcedimiento.Paciente_Id = IdPaciente;
            _SeleccionarProcedimiento.Indicacion = this; // Le paso a la variable publica mi instancia, para que el formulario Procedimiento sepa donde actualizar          
            _SeleccionarProcedimiento.ShowDialog();
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            Forms.MapaCama.Paciente.Ficha.Indicacion.Impresion.Impresion _Impresion = new Forms.MapaCama.Paciente.Ficha.Indicacion.Impresion.Impresion();
            _Impresion.Paciente_id = IdPaciente;
            _Impresion.ShowDialog();
        }
    }
}
