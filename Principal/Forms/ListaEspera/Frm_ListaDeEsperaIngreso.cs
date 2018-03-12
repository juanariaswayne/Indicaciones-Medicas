using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
namespace Principal.Forms.ListaEspera
{
    public partial class Frm_ListaDeEsperaIngreso : MetroForm
    {
        #region Variables
        enum Col_ListaEspera
        {
            COL_ESPERA_ID = 0,
            COL_PUNTAJE,
            COL_FINGRESO,
            COL_APELLIDO,
            COL_NOMBRE,
            COL_OBRASOCIAL,
            COL_EDAD,
            COL_GENERO,
            COL_FECHANAC,
            COL_TIPODOC,
            COL_NRODOC,
            COL_DIAGNOSTICO_ID,
            COL_OBRASOCIAL_ID,
            COL_NROAFIALIDO,
            COL_USUARIO_ID,
            COL_FECHAMODIF,
            COL_DERIVA,
            COL_OBS,
             COL_ESREINGRESO,
            COL_RECOMENDADO,
            COL_QUIEN_RECOMIENDA,
            COL_SEDE_SUGERIDA,
            COL_CAMA_DADA,
            COL_CAMA_CONFIRMADA,
            COL_FECHACONFIRMACION_CAMA

        } 
        enum Col_Modulos
        {
            COL_SELECCION=0,
            COL_CODIGO,
            COL_DESCRIPCION


        }
        enum Col_Factores
        {
            COL_SELECCION=0,
            COL_ID, 
            COL_DESCRIPCION

        }

        enum Col_Cultivos
        {
            ID = 0,
            ESPERA_ID,
            CULTIVO,
            FECHA,
            FECHAVTO

        }
        int _listaEsperaUpdate = 0;
        

        SISTMEDEntities _Mod = new SISTMEDEntities();
        SISTMEDEntities _Stored = new SISTMEDEntities();

        List<TraeListaEspera_Result> _listaEspera = new List<TraeListaEspera_Result>();
        #endregion

        #region Calendar
        public class CalendarColumn : DataGridViewColumn
        {
            public CalendarColumn()
                : base(new CalendarCell())
            {
            }

            public override DataGridViewCell CellTemplate
            {
                get
                {
                    return base.CellTemplate;
                }
                set
                {
                    // Ensure that the cell used for the template is a CalendarCell.
                    if (value != null &&
                        !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                    {
                        throw new InvalidCastException("Must be a CalendarCell");
                    }
                    base.CellTemplate = value;
                }
            }
        }

        public class CalendarCell : DataGridViewTextBoxCell
        {

            public CalendarCell()
                : base()
            {
                // Use the short date format.
                this.Style.Format = "d";
            }

            public override void InitializeEditingControl(int rowIndex, object
                initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                // Set the value of the editing control to the current cell value.
                base.InitializeEditingControl(rowIndex, initialFormattedValue,
                    dataGridViewCellStyle);
                CalendarEditingControl ctl =
                    DataGridView.EditingControl as CalendarEditingControl;
                // Use the default row value when Value property is null.
                if (this.Value == null)
                {
                    ctl.Value = (DateTime)this.DefaultNewRowValue;
                }
                else
                {
                    ctl.Value = (DateTime)this.Value;
                }
            }

            public override Type EditType
            {
                get
                {
                    // Return the type of the editing control that CalendarCell uses.
                    return typeof(CalendarEditingControl);
                }
            }

            public override Type ValueType
            {
                get
                {
                    // Return the type of the value that CalendarCell contains.

                    return typeof(DateTime);
                }
            }

            public override object DefaultNewRowValue
            {
                get
                {
                    // Use the current date and time as the default value.
                    return DateTime.Now;
                }
            }
        }

        class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
        {
            DataGridView dataGridView;
            private bool valueChanged = false;
            int rowIndex;

            public CalendarEditingControl()
            {
                this.Format = DateTimePickerFormat.Short;
            }

            // Implements the IDataGridViewEditingControl.EditingControlFormattedValue 
            // property.
            public object EditingControlFormattedValue
            {
                get
                {
                    return this.Value.ToShortDateString();
                }
                set
                {
                    if (value is String)
                    {
                        try
                        {
                            // This will throw an exception of the string is 
                            // null, empty, or not in the format of a date.
                            this.Value = DateTime.Parse((String)value);
                        }
                        catch
                        {
                            // In the case of an exception, just use the 
                            // default value so we're not left with a null
                            // value.
                            this.Value = DateTime.Now;
                            this.Show();
                        }
                    }
                }
            }

            // Implements the 
            // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
            public object GetEditingControlFormattedValue(
                DataGridViewDataErrorContexts context)
            {
                return EditingControlFormattedValue;
            }

            // Implements the 
            // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
            public void ApplyCellStyleToEditingControl(
                DataGridViewCellStyle dataGridViewCellStyle)
            {
                this.Font = dataGridViewCellStyle.Font;
                this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
                this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;

            }

            // Implements the IDataGridViewEditingControl.EditingControlRowIndex 
            // property.
            public int EditingControlRowIndex
            {
                get
                {
                    return rowIndex;
                }
                set
                {
                    rowIndex = value;
                }
            }

            // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey 
            // method.
            public bool EditingControlWantsInputKey(
                Keys key, bool dataGridViewWantsInputKey)
            {
                // Let the DateTimePicker handle the keys listed.
                switch (key & Keys.KeyCode)
                {
                    case Keys.Left:
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Right:
                    case Keys.Home:
                    case Keys.End:
                    case Keys.PageDown:
                    case Keys.PageUp:
                        return true;
                    default:
                        return !dataGridViewWantsInputKey;
                }
            }

            // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit 
            // method.
            public void PrepareEditingControlForEdit(bool selectAll)
            {
                // No preparation needs to be done.
            }

            // Implements the IDataGridViewEditingControl
            // .RepositionEditingControlOnValueChange property.
            public bool RepositionEditingControlOnValueChange
            {
                get
                {
                    return false;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingControlDataGridView property.
            public DataGridView EditingControlDataGridView
            {
                get
                {
                    return dataGridView;
                }
                set
                {
                    dataGridView = value;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingControlValueChanged property.
            public bool EditingControlValueChanged
            {
                get
                {
                    return valueChanged;
                }
                set
                {
                    valueChanged = value;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingPanelCursor property.
            public Cursor EditingPanelCursor
            {
                get
                {
                    return base.Cursor;
                }
            }

            protected override void OnValueChanged(EventArgs eventargs)
            {
                // Notify the DataGridView that the contents of the cell
                // have changed.
                valueChanged = true;
                this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
                base.OnValueChanged(eventargs);
            }
        }

        #endregion

        #region Funciones

        public Frm_ListaDeEsperaIngreso()
        {
            InitializeComponent();
        }
   

        private void TraeListaEspera(bool conScoring, bool soloOrdena)
        {
            try
            {
                try
                {
                    

                    if (soloOrdena) //SOLO ORDENO LA LISTA EXISTENTE, NO EJECUTO DE NUEVO EL STORED
                    {
                        if (conScoring)
                        {
                            _listaEspera = _listaEspera.OrderByDescending(p => p.Puntaje).ToList();
                        }
                        else
                        {
                            _listaEspera = _listaEspera.OrderBy(p => p.espera_id).ToList();
                        }

                    }
                    else //EJECUTO EL STORED
                    {
                        _listaEspera = (from L in _Stored.TraeListaEspera()
                                        select L).ToList();

                        if (conScoring)
                        {
                            _listaEspera = _listaEspera.OrderByDescending(p => p.Puntaje).ToList();
                        }
                        else
                        {
                            _listaEspera = _listaEspera.OrderBy(p => p.espera_id).ToList();
                        }
                    }
                        dataGridViewListaEspera.Rows.Clear();
                        int indice = 0;
                    foreach (var item in _listaEspera)
                    {
                        indice = dataGridViewListaEspera.Rows.Add();

                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_ESPERA_ID].Value = item.espera_id; // LISTAESPERA_ID
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_PUNTAJE].Value = (item.Puntaje == 999999999) ? "Recomendado" : item.Puntaje.ToString(); // PUNTAJE
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_NOMBRE].Value = item.nombre; //NOMBRE
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_APELLIDO].Value = item.apellido; //APELLIDO
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_FINGRESO].Value = item.fechaIngreso; //FECHA INGRESO
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_OBRASOCIAL].Value = item.ObraSocial; //APELLIDO
                                                                                                                                 //DATOS PARA UNA POSBLE ACTUAIZACION DE LA LISTA DE ESPERA
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_EDAD].Value = item.edad; //EDAD
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_GENERO].Value = item.genero; //GENERO
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_FECHANAC].Value = item.fechaNacimiento; //FECHA NAC
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_TIPODOC].Value = item.tipoDocumento_id; //TIPO DOC
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_NRODOC].Value = item.numeroDocumento; //NRO DOC
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_DIAGNOSTICO_ID].Value = item.diagnostico_id; //DIAGNOSTICO_ID
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_OBRASOCIAL_ID].Value = item.obraSocial_id; //OBRASOCIAL_ID
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_NROAFIALIDO].Value = item.nroAfiliado; //NRO AFILIADO
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_USUARIO_ID].Value = item.usuario_id; //USUARIO
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_FECHAMODIF].Value = item.fechaModificacion; //FECHA MODIF
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_DERIVA].Value = item.deriva; //DERIVA
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_OBS].Value = item.obs; //OBS
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_ESREINGRESO].Value = item.esReingreso; //ES REINGRESO
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_RECOMENDADO].Value = item.vieneRecomendado; //ES RECOMENDADO
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_QUIEN_RECOMIENDA].Value = item.QuienRecomienda; //QUIEN RECOMIENDA
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_SEDE_SUGERIDA].Value = item.sedeSugerida; //SEDE SUGERIDA
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_CAMA_DADA].Value = item.camaDada; //CAMA DADA
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_CAMA_CONFIRMADA].Value = item.confirmaCama; // CONFIRMA CAMA
                        dataGridViewListaEspera.Rows[indice].Cells[(int)Col_ListaEspera.COL_FECHACONFIRMACION_CAMA].Value = item.fechaConfirmacionCama; // FECHA CONFIRAMCION CAMA
                       
                        //PRIMERO VEO SI TIENE CAMA DADA
                        if (Convert.ToBoolean(item.camaDada))
                        {
                            //TIENE LA CAMA DADA...LO PINTO DE OTRO COLOR
                            dataGridViewListaEspera.Rows[indice].DefaultCellStyle.BackColor = Color.MistyRose;

                        }
                        // EN EL SIGUIENTE ORDEN, VEO SI TIENE CAMA CONFIRMADA
                        if (Convert.ToBoolean(item.confirmaCama))
                        {
                            //TIENE LA CAMA CONFIRMADA...LO PINTO DE OTRO COLOR
                            dataGridViewListaEspera.Rows[indice].DefaultCellStyle.BackColor = Color.PaleGreen;

                        }

                        indice++;

                        }
                    

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void TraeTipoDoc()
        {
            try
            {
                var _listObj = (from Tipos in _Mod.TipoDocumento
                                orderby Tipos.descripcion
                                select Tipos).ToList();

                TipoDocumento _itemSeleccion = new TipoDocumento();

                //Limpia el combo
                ComboBoxTipoDoc.SuspendLayout();
                ComboBoxTipoDoc.DataSource = null;
                ComboBoxTipoDoc.Items.Clear();

                // Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione un Tipo>";
                _itemSeleccion.tipoDocumento_id = 0;
                _listObj.Insert(0, _itemSeleccion);

                //Carga el combo
                ComboBoxTipoDoc.DisplayMember = "Descripcion";
                ComboBoxTipoDoc.ValueMember = "tipoDocumento_id";
                ComboBoxTipoDoc.DataSource = _listObj.ToArray();
                ComboBoxTipoDoc.SelectedIndex = 0;

                ComboBoxTipoDoc.ResumeLayout();

            }

            catch (Exception ex)
            {


            }
        }

        private void TraerModulos()
        {
            try
            {
                var _list = (from M in _Mod.MED_Modulo

                             select new
                             {
                                 M.modulo_id,
                                 M.Descripcion

                             });
                dataGridViewModulo.Rows.Clear();
                int indice = 0;
                foreach (var item in _list)
                {
                    indice = dataGridViewModulo.Rows.Add();
                    dataGridViewModulo.Rows[indice].Cells[(int)Col_Modulos.COL_CODIGO].Value = item.modulo_id; //CODIGO
                    dataGridViewModulo.Rows[indice].Cells[(int)Col_Modulos.COL_DESCRIPCION].Value = item.Descripcion; //DESCRIPCION
                               
                    indice++;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TraeObraSocial()
        {
            try
            {
                var _listObj = (from Tipos in _Stored.TraeObrasSociales()
                                orderby Tipos.cli_RazSoc
                                select Tipos).ToList();

                TraeObrasSociales_Result _itemSeleccion = new TraeObrasSociales_Result();

                //Limpia el combo
                ComboBoxOSocial.SuspendLayout();
                ComboBoxOSocial.DataSource = null;
                ComboBoxOSocial.Items.Clear();

                // Carga el item de Seleccion
                _itemSeleccion.cli_RazSoc = "<Seleccione una Obra Social>";
                _itemSeleccion.cli_Cod = "0";
                _listObj.Insert(0, _itemSeleccion);

                //Carga el combo
                ComboBoxOSocial.DisplayMember = "cli_RazSoc";
                ComboBoxOSocial.ValueMember = "cli_Cod";
                ComboBoxOSocial.DataSource = _listObj.ToArray();
                ComboBoxOSocial.SelectedIndex = 0;

                ComboBoxOSocial.ResumeLayout();

            }

            catch (Exception ex)
            {


            }

        }

        private void TraeDiagnostico()
        {
            try
            {
                var _listObj = (from Tipos in _Mod.MED_Diagnosticos
                                orderby Tipos.Diagnostico
                                select Tipos).ToList();

                MED_Diagnosticos _itemSeleccion = new MED_Diagnosticos();

                //Limpia el combo
                ComboBoxDiagnostico.SuspendLayout();
                ComboBoxDiagnostico.DataSource = null;
                ComboBoxDiagnostico.Items.Clear();

                // Carga el item de Seleccion
                _itemSeleccion.Diagnostico = "<Seleccione una Diagnóstico>";
                _itemSeleccion.diagnostico_id = 0;
                _listObj.Insert(0, _itemSeleccion);

                //Carga el combo
                ComboBoxDiagnostico.DisplayMember = "Diagnostico";
                ComboBoxDiagnostico.ValueMember = "diagnostico_id";
                ComboBoxDiagnostico.DataSource = _listObj.ToArray();
                ComboBoxDiagnostico.SelectedIndex = 0;

                ComboBoxDiagnostico.ResumeLayout();

            }

            catch (Exception ex)
            {


            }

        }

        private void TraerDerivaciones()
        {
            try
            {
                var _listObj = (from Deriva in _Mod.MED_Derivacion
                                orderby Deriva.Descripcion
                                select Deriva).ToList();

                MED_Derivacion _itemSeleccion = new MED_Derivacion();

                //Limpia el combo
                comboBoxDeriva.SuspendLayout();
                comboBoxDeriva.DataSource = null;
                comboBoxDeriva.Items.Clear();

                // Carga el item de Seleccion
                _itemSeleccion.Descripcion = "<Seleccione una Derivación>";
                _itemSeleccion.DerivaId = 0;
                _listObj.Insert(0, _itemSeleccion);

                //Carga el combo
                comboBoxDeriva.DisplayMember = "Descripcion";
                comboBoxDeriva.ValueMember = "DerivaId";
                comboBoxDeriva.DataSource = _listObj.ToArray();
                comboBoxDeriva.SelectedIndex = 0;

                comboBoxDeriva.ResumeLayout();

            }

            catch (Exception ex)
            {


            }

        }

        private bool ValidaIngreso()
        {
            try
            {
                //NOMBRE
                if (TextBoxNombre.Text == string.Empty)
                {
                    errorProvider1.SetError(TextBoxNombre, "Debe ingresar un Nombre");
                    return false;                      
                }
                else
                {
                    errorProvider1.SetError(TextBoxNombre, "");
                }

                //APELLIDO
                if (TextBoxApellido.Text == string.Empty)
                {
                    errorProvider1.SetError(TextBoxApellido, "Debe ingresar un Apellido");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(TextBoxApellido, "");
                }
                //OBRA SOCIAL
                if (ComboBoxOSocial.SelectedIndex == 0)
                {
                    errorProvider1.SetError(ComboBoxOSocial, "Debe seleccionar una Obra Social");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(ComboBoxOSocial, "");
                }
                //TIPO DOCUMENTO
                //if (ComboBoxTipoDoc.SelectedIndex == 0)
                //{
                //    errorProvider1.SetError(ComboBoxTipoDoc, "Debe seleccionar un Tipo de documento");
                //    return false;
                //}
                //else
                //{
                //    errorProvider1.SetError(ComboBoxTipoDoc, "");
                //}
                //NRO DOCUMENTO
                //if (TextBoxNroDoc.Text == string.Empty)
                //{
                //    errorProvider1.SetError(TextBoxNroDoc, "Debe ingresar un Nro. de Documento");
                //    return false;
                //}
                //else
                //{
                //    errorProvider1.SetError(TextBoxNroDoc, "");
                //}

                //NRO AFILIADO
                //if (TextBoxNroAfiliado.Text == string.Empty)
                //{
                //    errorProvider1.SetError(TextBoxNroAfiliado, "Debe ingresar un Nro. de Afiliado");
                //    return false;
                //}
                //else
                //{
                //    errorProvider1.SetError(TextBoxNroAfiliado, "");
                //}
                //DIAGNOSTICO
                if (ComboBoxDiagnostico.SelectedIndex == 0)
                {
                    errorProvider1.SetError(ComboBoxDiagnostico, "Debe seleccionar un Diagnóstico");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(ComboBoxDiagnostico, "");
                }
                if (CheckBoxRecomendado.Checked)
                {
                    if (TextBoxQuienRecomienda.Text == string.Empty)
                    {
                        errorProvider1.SetError(TextBoxQuienRecomienda, "Debe ingresar quien recomienda");
                        return false;
                    }
                    else
                    {
                        errorProvider1.SetError(TextBoxQuienRecomienda, "");
                    }
                }

              
                //DERIVA
                if (comboBoxDeriva.SelectedIndex == 0)
                {
                    errorProvider1.SetError(comboBoxDeriva, "Debe seleccionar una Derivación");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(comboBoxDeriva, "");
                }

                if (dataGridViewCultivos.Rows.Count - 1 == 0)
                {
                    errorProvider1.SetError(dataGridViewCultivos, "Debe seleccionar un Cultivo");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(dataGridViewCultivos, "");

                }
                    return true;
            }

            catch(Exception ex)
            {
                return false;
               
            }

        }

        private void NuevoIngreso()
        {
            try
            {
                TextBoxNombre.Text = string.Empty; //NOMBRE
                TextBoxApellido.Text = string.Empty; // APELLIDO
                ComboBoxTipoDoc.SelectedIndex = 0; //TIPO DOCUMENTO
                TextBoxNroDoc.Text = string.Empty; //NRO DOCUMENTO
                TextBoxEdad.Text = string.Empty; // EDAD
                ComboBoxOSocial.SelectedIndex = 0; // OBRA SOCIAL
                TextBoxNroAfiliado.Text = string.Empty; //NRO. AFILIADO
                RadioButtonMasculino.Checked = true; // MASCULINO
                dateTimeFechaNac.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //FECHA NACIMIENTO
              
                CheckBoxReingreso.Checked = false; // ES REINGRESO
                ComboBoxDiagnostico.SelectedIndex = 0; //DIAGNOSTICO
                comboBoxDeriva.SelectedIndex = 0; // DERIVA
                TextBoxObs.Text = string.Empty; // OBS
                CheckBoxRecomendado.Checked = false; //VIENE RECOMENDADO
                TextBoxQuienRecomienda.Text = string.Empty;
                TextBoxQuienRecomienda.Visible = false;
                CheckBoxCamaDada.Checked = false;
              
                comboBoxSede.SelectedIndex = 0;
                _listaEsperaUpdate = 0; //VARIABLE QUE ME INDICA SI ESTOY MODIFICANDO O CREANDO UN NUEVO INGRESO
                dateTimeFechaIngreso.Value = DateTime.Now;
                //DESTILDO TODOS LOS MODULOS
                for (int i = 0; i < dataGridViewModulo.Rows.Count; i++)
                {
                    dataGridViewModulo.Rows[i].Cells[(int)Col_Modulos.COL_SELECCION].Value = false;

                }
                //DESTILDO TODOS LOS FACTORES
                for (int i = 0; i < dataGridViewOtroFactor.Rows.Count; i++)
                {
                    dataGridViewOtroFactor.Rows[i].Cells[(int)Col_Modulos.COL_SELECCION].Value = false;

                }

                dataGridViewCultivos.Rows.Clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TraerOtrosFactores()
        {
            try
            {
                var _list = (from M in _Mod.MED_OtraPonderacionPuntaje

                             select new
                             {
                                 M.Id,
                                 M.Descripcion

                             });
                dataGridViewOtroFactor.Rows.Clear();
                int indice = 0;
                foreach (var item in _list)
                {
                    indice = dataGridViewOtroFactor.Rows.Add();
                    dataGridViewOtroFactor.Rows[indice].Cells[(int)Col_Factores.COL_ID].Value = item.Id; //CODIGO
                    dataGridViewOtroFactor.Rows[indice].Cells[(int)Col_Factores.COL_DESCRIPCION].Value = item.Descripcion; //DESCRIPCION

                    indice++;

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EgresoListaEspera(Object sender, EventArgs e)
        {
            //codigo para mostrar formulario
            Frm_EgresoListaEspera _frmEgrego = new Frm_EgresoListaEspera();
            if (_listaEsperaUpdate > 0)
            {
                _frmEgrego.ListaEsperaId = _listaEsperaUpdate;
                _frmEgrego.Text = TextBoxApellido.Text + " " + TextBoxNombre.Text;
                _frmEgrego.ShowDialog();

                NuevoIngreso();
                if (radioButtonSinScoring.Checked)
                {
                    TraeListaEspera(false, false);
                }
                else
                {
                    TraeListaEspera(true, false);

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Paciente de la lista de espera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ConfirmarCama(Object sender, EventArgs e)
        {
            //codigo para mostrar formulario
            Frm_ConfirmaCama _frmEgrego = new Frm_ConfirmaCama();
            if (_listaEsperaUpdate > 0)
            {
                _frmEgrego.ListaEsperaId = _listaEsperaUpdate;
                _frmEgrego.Text = TextBoxApellido.Text + " " + TextBoxNombre.Text;
                _frmEgrego.ShowDialog();

                NuevoIngreso();
                if (radioButtonSinScoring.Checked)
                {
                    TraeListaEspera(false, false);
                }
                else
                {
                    TraeListaEspera(true, false);

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Paciente de la lista de espera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CargarSedes()
        {
            try
            {

                var _listObj = (from sede in _Mod.Sedes orderby sede.descripcion select sede).ToList();

                Sedes _itemSeleccion = new Sedes();

                //Limpia el combo
                this.comboBoxSede.SuspendLayout();
                this.comboBoxSede.DataSource = null;
                this.comboBoxSede.Items.Clear();
                //Carga el item de Seleccion
                _itemSeleccion.descripcion = "<Seleccione una Sede>";
                _itemSeleccion.sede_id = 0;
                _listObj.Insert(0, _itemSeleccion);
                //Carga el combo
                this.comboBoxSede.DisplayMember = "descripcion";
                this.comboBoxSede.ValueMember = "sede_id";
                this.comboBoxSede.DataSource = _listObj;
                this.comboBoxSede.ResumeLayout();

                comboBoxSede.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculaVto(int fila)
        {
            try
            {
                DateTime _fecha = Convert.ToDateTime(dataGridViewCultivos.Rows[fila].Cells[(int)Col_Cultivos.FECHA].Value);

                dataGridViewCultivos.Rows[fila].Cells[(int)Col_Cultivos.FECHAVTO].Value = _fecha.AddDays(15);
            }


            catch (Exception ex)
            {


            }


        }

        private void AdjuntarArchivo(string _espera_id)
        {
            try
            {

                // Specify a name for your top-level folder.
                string folderName = @"\\192.168.2.50\Indicaciones Medicas\AdjuntosListaEspera"; //RUTA DEL SERVIDOR DONDE ESTARA EL REPOSITORIO DE ADJUNTOS

                string pathString = System.IO.Path.Combine(folderName, _espera_id.ToString()); //CREO LA CARPETA DE NOMBRE IGUAL AL DE LA ESPERA_ID

                if (!System.IO.Directory.Exists(pathString))
                {
                    System.IO.Directory.CreateDirectory(pathString); // COMO NO EXISTE, CREO LA CARPETA
                }

                openFileDialog1.Filter = "All files (*.*)|*.*";

                this.openFileDialog1.Multiselect = true; //PERMITE SELECCIONAR VARIOS ARCHIVOS EN SIMULTENEO

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Length > 0)
                {
                    //RECORRO LOS ARCHIVOS SELECCIONADOS
                    foreach (String file in openFileDialog1.FileNames)
                    {
                        string destino = Path.Combine(pathString, Path.GetFileName(file));
                        File.Copy(openFileDialog1.FileName, destino, false);
                    }

                    MessageBox.Show("Archivo guardado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch(Exception ex)

            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        #endregion


        #region Eventos

        private void Frm_ListaDeEsperaIngreso_Load(object sender, EventArgs e)
        {
            try
            {
                TraeTipoDoc();
                TraerModulos();
                TraeObraSocial();
                TraeDiagnostico();
                TextBoxNombre.Focus();
                if (radioButtonSinScoring.Checked)
                {
                    TraeListaEspera(false,false);
                }
                else
                {
                    TraeListaEspera(true,false);
                }
                TraerOtrosFactores();

                CargarSedes();
                TraerDerivaciones();

                dateTimeFechaIngreso.Value = DateTime.Now;

                //calendar
                CalendarColumn col = new CalendarColumn();

                this.dataGridViewCultivos.Columns.Add(col);
                this.dataGridViewCultivos.Columns[(int)Col_Cultivos.FECHA].HeaderText = "Fecha";
                this.dataGridViewCultivos.Columns[(int)Col_Cultivos.FECHA].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridViewCultivos.Columns[(int)Col_Cultivos.FECHA].Width = 90;
                col = new CalendarColumn();
                this.dataGridViewCultivos.Columns.Add(col);
                this.dataGridViewCultivos.Columns[(int)Col_Cultivos.FECHAVTO].HeaderText = "Fecha Vto.";
                this.dataGridViewCultivos.Columns[(int)Col_Cultivos.FECHAVTO].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridViewCultivos.Columns[(int)Col_Cultivos.FECHAVTO].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //calendar

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TextBoxApellido.Focus();
        }

        private void TextBoxApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ComboBoxTipoDoc.Focus();
        }

        private void dataGridViewModulo_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewModulo.IsCurrentCellDirty)
                dataGridViewModulo.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewListaEspera_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewListaEspera.IsCurrentCellDirty)
                dataGridViewListaEspera.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidaIngreso())
                {
                    MED_ListaEspera _lista = new MED_ListaEspera();
                    Clases.IndicacionesBLL.ListaEspera _saveObj = new Clases.IndicacionesBLL.ListaEspera();
                    List<MED_ListaEsperaModulo> _listModulos = new List<MED_ListaEsperaModulo>();
                    MED_ListaEsperaModulo _itemM;
                    bool selecciono = false;

                    _lista.nombre = TextBoxNombre.Text.ToString().Trim(); //NOMBRE
                    _lista.apellido = TextBoxApellido.Text.ToString().Trim(); // APELLIDO
                    _lista.tipoDocumento_id = (ComboBoxTipoDoc.SelectedIndex > 0) ? Convert.ToInt32(ComboBoxTipoDoc.SelectedValue) : 0; //TIPO DOCUMENTO
                    _lista.numeroDocumento = (TextBoxNroDoc.Text != string.Empty) ? Convert.ToInt32(TextBoxNroDoc.Text) : 0; //NRO. DOCUMENTO
                    _lista.edad = (TextBoxEdad.Text != string.Empty) ? Convert.ToInt16 (TextBoxEdad.Text) : Convert.ToInt16(0); //EDAD
                    _lista.obraSocial_id =  ComboBoxOSocial.SelectedValue.ToString(); //OBRA SOCIAL
                    _lista.nroAfiliado = TextBoxNroAfiliado.Text; // NRO. AFILIADO
                    _lista.genero = (RadioButtonMasculino.Checked) ? "M" : "F"; // GENERO
                    _lista.fechaNacimiento = Convert.ToDateTime(dateTimeFechaNac.Value); // FECHA NACIMIENTO
                    
                    _lista.esReingreso = (CheckBoxReingreso.Checked) ? true : false; // ES REINGRESO
                    _lista.diagnostico_id = Convert.ToInt32(ComboBoxDiagnostico.SelectedValue); //DIAGNOSTICO
                    
                    //if (_listaEsperaUpdate == 0) //SI ES UN NUEVO INGRESO ENVÍO LA FECHA. DE LO CONTRARIO SI ES UNA MODIFICACION NO CAMBIO ESTA FECHA
                    //{
                    _lista.fechaIngreso = Convert.ToDateTime(dateTimeFechaIngreso.Value); //Convert.ToDateTime(DateTime.Now); // FECHA INGRESO CON HORAS
                    //}
                    _lista.fechaModificacion = Convert.ToDateTime(DateTime.Now); // FECHA MODIFICACION CON  HORAS
                    
                    _lista.deriva = Convert.ToInt32(comboBoxDeriva.SelectedValue); // DERIVA
                    _lista.obs = TextBoxObs.Text.ToString().Trim(); // OBS
                    _lista.vieneRecomendado = (CheckBoxRecomendado.Checked) ? true : false; //VIENE RECOMENDADO
                    _lista.QuienRecomienda = TextBoxQuienRecomienda.Text; //QUIEN RECOMIENDA
                    _lista.sedeSugerida = (comboBoxSede.SelectedIndex > 0) ? Convert.ToInt32(comboBoxSede.SelectedValue):0; //SEDE SIGERIDA
                    _lista.camaDada = (CheckBoxCamaDada.Checked) ? true : false; //CAMA DADA
                    _lista.usuario_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado;
                    

                    //RECUPERO LOS MODULOS SELECCIONADOS
                     for(int i=0; i< dataGridViewModulo.Rows.Count;i++)
                    {
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewModulo.Rows[i].Cells[(int)Col_Modulos.COL_SELECCION] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            _itemM = new MED_ListaEsperaModulo();
                            _itemM.modulo_id = dataGridViewModulo.Rows[i].Cells[(int)Col_Modulos.COL_CODIGO].Value.ToString();

                            _listModulos.Add(_itemM);
                            selecciono = true;
                        }

                    }
                    //FIN MODULOS

                    //VERIFICO SI SELECCIONO ALGUN FACTOR DE PUINTAJE ADICIONAL

                    MED_PuntajeAdicionalListaEspera _itemFactor;
                    List<MED_PuntajeAdicionalListaEspera> _listFactor = new List<MED_PuntajeAdicionalListaEspera>();
                    for (int i = 0; i < dataGridViewOtroFactor.Rows.Count; i++)
                    {
                        DataGridViewCheckBoxCell cellSelecion = dataGridViewOtroFactor.Rows[i].Cells[(int)Col_Factores.COL_SELECCION] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(cellSelecion.Value))
                        {
                            _itemFactor = new MED_PuntajeAdicionalListaEspera();
                            _itemFactor.IdFactor = Convert.ToInt32(dataGridViewOtroFactor.Rows[i].Cells[(int)Col_Factores.COL_ID].Value);

                            _listFactor.Add(_itemFactor);
                            
                        }

                    }

                    // FIN OTROS FACTORES DE PONDERACION

                    //RECORRO LOS CULTIVOS INGRESADOS
                    MED_CultivosListaEspera _cultivos;
                    List<MED_CultivosListaEspera> _listCultivos = new List<MED_CultivosListaEspera>();

                   
                        for (int i = 0; i < dataGridViewCultivos.Rows.Count - 1; i++)
                        {
                            _cultivos = new MED_CultivosListaEspera();
                            _cultivos.Cultivo = dataGridViewCultivos.Rows[i].Cells[(int)Col_Cultivos.CULTIVO].Value.ToString();
                            _cultivos.Fecha = Convert.ToDateTime(dataGridViewCultivos.Rows[i].Cells[(int)Col_Cultivos.FECHA].Value);
                            _cultivos.FechaVto = Convert.ToDateTime(dataGridViewCultivos.Rows[i].Cells[(int)Col_Cultivos.FECHAVTO].Value);
                            _listCultivos.Add(_cultivos);
                        }
                   

                    // FIN CULTIVOS

                        if (!selecciono)
                    {
                        MessageBox.Show("Debe seleccionar al menos un Módulo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (_listaEsperaUpdate == 0)
                    {
                        _lista.confirmaCama = false; //CONFIRMA CAMA VA EN CERO, CUANDO SE CREA UN NUEVO OBJETO DE LISTA DE ESPERA

                        if (_saveObj.ListaNew(_lista, _listModulos, _listFactor, _listCultivos))
                        {
                            if (radioButtonSinScoring.Checked)
                            {
                                TraeListaEspera(false,false);
                            }
                            else
                            {
                                TraeListaEspera(true,false);

                            }
                            NuevoIngreso();
                            MessageBox.Show("Los datos fueron ingresados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                       else
                        {
                            MessageBox.Show("Error al crear la lista de espera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        _lista.espera_id = _listaEsperaUpdate;
                        //_lista.fechaIngreso = Convert.ToDateTime(dataGridViewListaEspera.Rows[dataGridViewListaEspera.CurrentRow.Index].Cells[(int)Col_ListaEspera.COL_FINGRESO].Value);
                        if (_saveObj.ListaUpdate(_lista, _listModulos, _listFactor, _listCultivos))
                        {
                            if (radioButtonSinScoring.Checked)
                            {
                                TraeListaEspera(false,false);
                            }
                            else
                            {
                                TraeListaEspera(true,false);

                            }
                            NuevoIngreso();
                            MessageBox.Show("Lista actualizada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la lista Nro: " + _listaEsperaUpdate, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTileNuevoIngreso_Click(object sender, EventArgs e)
        {
            NuevoIngreso();
        }

        private void ComboBoxTipoDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TextBoxNroDoc.Focus();
        }

        private void TextBoxNroDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TextBoxEdad.Focus();
        }

        private void TextBoxEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ComboBoxOSocial.Focus();
        }

        private void ComboBoxOSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TextBoxNroAfiliado.Focus();
        }

        private void dataGridViewListaEspera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    NuevoIngreso();

                    _listaEsperaUpdate = Convert.ToInt32(dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_ESPERA_ID].Value);// LISTAESPERA_ID
                    TextBoxNombre.Text = dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_NOMBRE].Value.ToString();  //NOMBRE
                    TextBoxApellido.Text = dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_APELLIDO].Value.ToString(); //APELLIDO
                    //DATOS PARA UNA POSBLE ACTUAIZACION DE LA LISTA DE ESPERA
                    TextBoxEdad.Text = dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_EDAD].Value.ToString(); //EDAD
                    if (dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_GENERO].Value.ToString() == "M")
                    {
                        RadioButtonMasculino.Checked = true;
                    }
                    else
                    {
                        metroRadioButtonFemenino.Checked = true;
                    }
                    dateTimeFechaNac.Value = Convert.ToDateTime(dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_FECHANAC].Value); //FECHA NAC
                    ComboBoxTipoDoc.SelectedValue = dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_TIPODOC].Value; //TIPO DOC
                    TextBoxNroDoc.Text = dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_NRODOC].Value.ToString(); //NRO DOC
                    ComboBoxDiagnostico.SelectedValue = dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_DIAGNOSTICO_ID].Value; //DIAGNOSTICO_ID
                    ComboBoxOSocial.SelectedValue = dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_OBRASOCIAL_ID].Value; //OBRASOCIAL_ID
                    TextBoxNroAfiliado.Text = dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_NROAFIALIDO].Value.ToString(); //NRO AFILIADO
                    // dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_USUARIO_ID].Value = item.usuario_id; //USUARIO
                    //dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_FECHAMODIF].Value = item.fechaModificacion; //FECHA MODIF
                    comboBoxDeriva.SelectedValue = dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_DERIVA].Value;   //DERIVA
                    TextBoxObs.Text = dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_OBS].Value.ToString(); //OBS
                    CheckBoxReingreso.Checked = (Convert.ToBoolean(dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_ESREINGRESO].Value)) ? true : false; //ES REINGRESO
                    CheckBoxRecomendado.Checked = (Convert.ToBoolean(dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_RECOMENDADO].Value)) ? true : false; //ES RECOMENDADO
                    if (CheckBoxRecomendado.Checked)
                    {
                        TextBoxQuienRecomienda.Visible = true;
                        TextBoxQuienRecomienda.Text = dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_QUIEN_RECOMIENDA].Value.ToString();
                    }
                                      
                    CheckBoxCamaDada.Checked = (Convert.ToBoolean(dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_CAMA_DADA].Value)) ? true : false; //CAMA DADA
                    comboBoxSede.SelectedValue = dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_SEDE_SUGERIDA].Value; // SEDE SUGERIDA
                    dateTimeFechaIngreso.Value = Convert.ToDateTime(dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_FINGRESO].Value); // SEDE SUGERIDA

                    if ( Convert.ToBoolean(dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_CAMA_CONFIRMADA].Value) )
                    {
                        labelCamaConfirmada.Visible = true;
                        labelCamaConfirmada.Text = "TIENE CAMA CONFIRMADA - Fecha: " + dataGridViewListaEspera.Rows[e.RowIndex].Cells[(int)Col_ListaEspera.COL_FECHACONFIRMACION_CAMA].Value;
                    }
                    else
                    {
                        labelCamaConfirmada.Visible = false;
                    }

                    //TRAIGO EL DETALLE DE LOS MODULOS
                    SISTMEDEntities _ModM = new SISTMEDEntities();
                    _ModM.Configuration.ProxyCreationEnabled = false;

                    var _modulos = (from P in _ModM.MED_ListaEsperaModulo where P.espera_id == _listaEsperaUpdate select P).ToList();
                    string _itemMod = string.Empty;

                    foreach (var item in _modulos)
                    {

                        for (int i = 0; i < dataGridViewModulo.Rows.Count; i++)
                        {
                            //VOY BUSCANDO LOS MODULOS SELECCIONADOS
                            _itemMod = dataGridViewModulo.Rows[i].Cells[(int)Col_Modulos.COL_CODIGO].Value.ToString();
                            if (item.modulo_id == _itemMod)
                            {
                                dataGridViewModulo.Rows[i].Cells[(int)Col_Modulos.COL_SELECCION].Value = true;
                            }

                        }

                    }

                    //FIN DETALLE MODULOS

                    //TRAIGO LOS HISOPADOS CARGADOS
                    SISTMEDEntities _ModMH = new SISTMEDEntities();
                    _ModMH.Configuration.ProxyCreationEnabled = false;
                    var _hisopados = (from P in _ModMH.MED_CultivosListaEspera where P.espera_id == _listaEsperaUpdate select P).ToList();
                    dataGridViewCultivos.Rows.Clear();
                    Int32 indice;
                   foreach (var item in _hisopados)
                   {
                        //VOY INGRESANDO LOS HISPODADOS
                        indice = dataGridViewCultivos.Rows.Add();
                        dataGridViewCultivos.Rows[indice].Cells[(int)Col_Cultivos.ID].Value = item.Id;
                        dataGridViewCultivos.Rows[indice].Cells[(int)Col_Cultivos.ESPERA_ID].Value = item.espera_id;
                        dataGridViewCultivos.Rows[indice].Cells[(int)Col_Cultivos.CULTIVO].Value = item.Cultivo;
                        dataGridViewCultivos.Rows[indice].Cells[(int)Col_Cultivos.FECHA].Value = item.Fecha;
                        dataGridViewCultivos.Rows[indice].Cells[(int)Col_Cultivos.FECHAVTO].Value = item.FechaVto;
                    }

                    // FIN HISOPADOS

                    //TRAIGO EL DETALLE DE FACTORES SELECCIONADOS
                    SISTMEDEntities _ModMF = new SISTMEDEntities();
                    var _Factores = (from P in _ModMF.MED_PuntajeAdicionalListaEspera where P.espera_id == _listaEsperaUpdate select P).ToList();
                    int _itemFact = 0;

                    foreach (var item in _Factores)
                    {

                        for (int i = 0; i < dataGridViewOtroFactor.Rows.Count; i++)
                        {
                            //VOY BUSCANDO FACTORES SELECCIONADOS
                            _itemFact = Convert.ToInt32(dataGridViewOtroFactor.Rows[i].Cells[(int)Col_Factores.COL_ID].Value);
                            if (item.IdFactor == _itemFact)
                            {
                                dataGridViewOtroFactor.Rows[i].Cells[(int)Col_Factores.COL_SELECCION].Value = true;
                            }

                        }

                    }
                    //FIN OTROS FACTORES
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CheckBoxRecomendado_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxRecomendado.Checked)
            {
                TextBoxQuienRecomienda.Visible = true;
            }
            else
            {
                TextBoxQuienRecomienda.Text = string.Empty;
                TextBoxQuienRecomienda.Visible = false;
            }
  
        }

        private void dataGridViewOtroFactor_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewListaEspera.IsCurrentCellDirty)
                dataGridViewListaEspera.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        
        private void dataGridViewListaEspera_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //ESTO PARA ASEGURAR QUE ESTOY SELECCIONADO UNA CELDA DEL GRID
                DataGridView.HitTestInfo Hitest = dataGridViewListaEspera.HitTest(e.X, e.Y);
                if (Hitest.Type == DataGridViewHitTestType.Cell)
                {
                    if (Hitest.RowIndex >= 0)
                    {
                        dataGridViewListaEspera.CurrentCell = dataGridViewListaEspera.Rows[Hitest.RowIndex].Cells[Hitest.ColumnIndex];
                        dataGridViewListaEspera.Rows[Hitest.RowIndex].Selected = true;

                        ContextMenuStrip m = new ContextMenuStrip();
                        if (Convert.ToBoolean(dataGridViewListaEspera.Rows[dataGridViewListaEspera.CurrentCell.RowIndex].Cells[(int)Col_ListaEspera.COL_CAMA_CONFIRMADA].Value))
                        {
                            //SI YA TIENE UNA CAMAA CONFIRMADA, SOLO MUESTRO DAR DE BAJA
                            m.Items.Add("Confirmar Ingreso Paciene o Baja", null, EgresoListaEspera);
                        }
                        else
                        {
                            m.Items.Add("Confirmar Ingreso Paciene o Baja", null, EgresoListaEspera);
                            m.Items.Add("Confirmar Cama", null, ConfirmarCama);
                        }
                       
                       
                        m.Show(dataGridViewListaEspera, new Point(e.X, e.Y));
                    }
                }


            }
        }

        private void LinkdiagnosticoNuevo_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Forms.MapaCama.Paciente.Nuevo_Diagnostico N = new Forms.MapaCama.Paciente.Nuevo_Diagnostico();
            //    N.Opener = this;
            //    N.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        
        private void radioButtonSinScoring_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSinScoring.Checked)
            {
                TraeListaEspera(false,true);
            }
            else
            {
                TraeListaEspera(true,true);

            }
        }

        private void radioButtonConScoring_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSinScoring.Checked)
            {
                TraeListaEspera(false,true);
            }
            else
            {
                TraeListaEspera(true,true);

            }
        }

        private void dataGridViewCultivos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewCultivos.IsCurrentCellDirty)
                dataGridViewCultivos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewCultivos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Convert.ToInt32(Col_Cultivos.FECHA))
            {
                CalculaVto(e.RowIndex);
            }
        }

        private void dataGridViewCultivos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void metroTileAdjuanta_Click(object sender, EventArgs e)
        {
            if (_listaEsperaUpdate > 0)
            {
                AdjuntarArchivo(_listaEsperaUpdate.ToString());
            }
            else
            {
                MessageBox.Show("Antes de Adjuntar los archivos, primero debe ingresarlo a la lista de Espera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTileVerAdjuntos_Click(object sender, EventArgs e)
        {
            if (_listaEsperaUpdate > 0)
            {
                Frm_Adjuntos _adjuntos = new Frm_Adjuntos();
                string pathString = System.IO.Path.Combine(@"\\192.168.2.50\\Indicaciones Medicas\\AdjuntosListaEspera\\", _listaEsperaUpdate.ToString()); //ENVIO EL DIRECTORIO PARA LLEER LOS ARCHIVOS CARGADOS
               
                if (Directory.Exists(pathString))
                {
                    _adjuntos.Directorio = pathString;
                    _adjuntos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Este paciente no tiene archivos adjuntos asociados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Antes de Adjuntar los archivos, primero debe ingresarlo a la lista de Espera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        private void TextBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SOLO INGRESO MAYUSCULAS
            if (e.KeyChar.ToString() == e.KeyChar.ToString().ToUpper())
                return;

            e.Handled = true;
            SendKeys.Send(e.KeyChar.ToString().ToUpper());
        }

        private void TextBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SOLO INGRESO MAYUSCULAS
            if (e.KeyChar.ToString() == e.KeyChar.ToString().ToUpper())
                return;

            e.Handled = true;
            SendKeys.Send(e.KeyChar.ToString().ToUpper());
        }

        private void TextBoxQuienRecomienda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SOLO INGRESO MAYUSCULAS
            if (e.KeyChar.ToString() == e.KeyChar.ToString().ToUpper())
                return;

            e.Handled = true;
            SendKeys.Send(e.KeyChar.ToString().ToUpper());
        }
    }
}
