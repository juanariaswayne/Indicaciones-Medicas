using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Mail;
using System.Net;
using System.Data.SqlTypes;

namespace Principal.Forms.Parametros.Medicamento
{
    public partial class Medicamento_Solicitado : MetroForm
    {
        #region Variables
        private enum Col_Medicamentos_Solicitados
        {
            PACIENTE = 0,
            PACIENTE_ID,
            MEDICAMENTO_ID,
            MEDICAMENTO,
            BEJERMAN_ID,
            PRESENTACION_ID,
            PRESENTACION,
            UNIDAD_DE_MEDIDA_ID,   
            POTENCIA,
            USUARIO_SOLICITA_ID,
            USUARIO_SOLICITA,
            FECHA_SOLICITA,
            AUT_TODO,
            AUT_SOLO_PAC,
            NO_AUTORIZA,
            PENDIENTE,
            AUT_ID,
            AUTORIZA,
            FECHA_AUTORIZA,
            FECHA_HASTA

        }
        private enum Col_Medicamentos_Solicitados_No_autorizado
        {
            MEDICAMENTO,
            USUARIO_SOLICITA,
            FECHA_SOLICITA
        }

        bool _autorizaTodo = false;
        bool _autorizaPaciente = false;
        bool _noAutoriza = false;
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
                    ctl.Value = Convert.ToDateTime(this.Value);
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

        #region Inicio
        public Medicamento_Solicitado()
        {
            InitializeComponent();
        }
        private void Medicamento_Solicitado_Load(object sender, EventArgs e)
        {
            Trae_Medicamento_Solicitado_Sin_Autorizar();
            //calendar
            CalendarColumn col = new CalendarColumn();

            this.dataGridViewMedicamentos.Columns.Add(col);
            this.dataGridViewMedicamentos.Columns[(int)Col_Medicamentos_Solicitados.FECHA_HASTA].HeaderText = "Autorizar Hasta";
            this.dataGridViewMedicamentos.Columns[(int)Col_Medicamentos_Solicitados.FECHA_HASTA].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        #endregion

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Graba_Autorizazion();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dataGridViewMedicamentos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewMedicamentos.IsCurrentCellDirty)
                dataGridViewMedicamentos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dataGridViewMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == (int)Col_Medicamentos_Solicitados.AUT_TODO)
                {
                    DataGridViewCheckBoxCell _autTodo = dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamentos_Solicitados.AUT_TODO] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(_autTodo.Value))
                    {
                        _autorizaTodo = true;
                        _noAutoriza = false;
                        _autorizaPaciente = false;

                        dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamentos_Solicitados.AUT_SOLO_PAC].Value = false;
                        dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamentos_Solicitados.NO_AUTORIZA].Value = false;
                        dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamentos_Solicitados.AUT_TODO].Value = true;
                    }
                }

                if (e.ColumnIndex == (int)Col_Medicamentos_Solicitados.AUT_SOLO_PAC)
                {
                    DataGridViewCheckBoxCell _autTodo = dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamentos_Solicitados.AUT_SOLO_PAC] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(_autTodo.Value))
                    {
                        _autorizaTodo = false;
                        _noAutoriza = false;
                        _autorizaPaciente = true;

                        dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamentos_Solicitados.AUT_TODO].Value = false;
                        dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamentos_Solicitados.NO_AUTORIZA].Value = false;
                        dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamentos_Solicitados.AUT_SOLO_PAC].Value = true;
                    }
                }

                if (e.ColumnIndex == (int)Col_Medicamentos_Solicitados.NO_AUTORIZA)
                {
                    DataGridViewCheckBoxCell _autTodo = dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamentos_Solicitados.NO_AUTORIZA] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(_autTodo.Value))
                    {
                        _autorizaTodo = false;
                        _noAutoriza = true;
                        _autorizaPaciente = false;

                        dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamentos_Solicitados.AUT_SOLO_PAC].Value = false;
                        dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamentos_Solicitados.AUT_TODO].Value = false;
                        dataGridViewMedicamentos.Rows[e.RowIndex].Cells[(int)Col_Medicamentos_Solicitados.NO_AUTORIZA].Value = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region Metodos
        private void Trae_Medicamento_Solicitado_Sin_Autorizar()
        {
            try
            {
                CultureInfo culture = new CultureInfo("en-US");
                SISTMEDEntities E = new SISTMEDEntities();
                
                this.dataGridViewMedicamentos.Rows.Clear();
                int indice;
                foreach (var item in E.MED_Solicita_Medicamento_Nuevo.Where(med=>med.pendiente == true && med.autoriza == false))
                {
                    indice = dataGridViewMedicamentos.Rows.Add();                  
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.MEDICAMENTO_ID].Value = item.medicamento_id;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.MEDICAMENTO].Value = item.medicamento;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.BEJERMAN_ID].Value = item.bejerman_id;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.PRESENTACION_ID].Value = item.presentacion_id;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.PRESENTACION].Value = item.MED_Presentacion.descripcion;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.UNIDAD_DE_MEDIDA_ID].Value = item.unidadDeMedida_id;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.POTENCIA].Value = item.Potencia;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.USUARIO_SOLICITA_ID].Value = item.usuarioSolicita_id;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.USUARIO_SOLICITA].Value = item.TBL_Usuarios.NombreUsuario;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.FECHA_SOLICITA].Value = item.fechaSolicita;          
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.NO_AUTORIZA].Value = item.autoriza;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.PENDIENTE].Value = item.pendiente;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.AUT_ID].Value = item.usuarioAutoriza_id;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.AUTORIZA].Value = item.TBL_Usuarios.NombreUsuario;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.FECHA_AUTORIZA].Value = item.fechaAutoriza;
                    dataGridViewMedicamentos.Rows[indice].Cells[(int)Col_Medicamentos_Solicitados.PACIENTE].Value = item.paciente_id == null? "" : item.Pacientes.nombre + " " + item.Pacientes.apellido;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Trae_Medicamento_Solicitado_No_Autorizado(bool autoriza, bool pendiente)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Graba_Autorizazion()
        {
            try
            {
                    SISTMEDEntities E = new SISTMEDEntities();
                    E.Configuration.ValidateOnSaveEnabled = false;
                    E.Configuration.ProxyCreationEnabled = false;

                    for (int i = 0; i < this.dataGridViewMedicamentos.Rows.Count; i++)
                    {
                        bool _todo = Convert.ToBoolean(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos_Solicitados.AUT_TODO].Value);
                        bool _paciente = Convert.ToBoolean(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos_Solicitados.AUT_SOLO_PAC].Value);
                        bool _noAut = Convert.ToBoolean(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos_Solicitados.NO_AUTORIZA].Value);
                        bool _autoriza = false;                    
                        DateTime _fechaHasta = SqlDateTime.MinValue.Value;
                        if (_todo || _paciente || _noAut) //Verifico que haya seleccionado algo
                        {
                            if(_todo || _paciente)
                            {
                                _autoriza = true; 
                                if(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos_Solicitados.FECHA_HASTA].Value != null)
                                {
                                   _fechaHasta = Convert.ToDateTime(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos_Solicitados.FECHA_HASTA].Value);
                                }                                                              
                            }
                            
                            MED_Solicita_Medicamento_Nuevo _item = new MED_Solicita_Medicamento_Nuevo
                            {
                                medicamento_id = Convert.ToInt32(dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos_Solicitados.MEDICAMENTO_ID].Value),
                                medicamento = dataGridViewMedicamentos.Rows[i].Cells[(int)Col_Medicamentos_Solicitados.MEDICAMENTO].Value.ToString(),
                                autoriza = _autoriza,
                                pendiente = false,
                                fechaDesde = DateTime.Now,
                                fechaHasta = _fechaHasta,
                                fechaAutoriza = DateTime.Now,
                                usuarioAutoriza_id = Clases.Usuario.UsuarioLogeado.id_usuario_Logeado,
                                bejermanAlta = _todo //Si autoriza solo a un Paciente esto esta false O si No Autoriza
                            };

                            E.MED_Solicita_Medicamento_Nuevo.Attach(_item);
                            E.Entry(_item).Property(s => s.medicamento).IsModified = true;
                            E.Entry(_item).Property(s => s.autoriza).IsModified = true;
                            E.Entry(_item).Property(s => s.pendiente).IsModified = true;
                            E.Entry(_item).Property(s => s.paciente_id).IsModified = true;
                            E.Entry(_item).Property(s => s.fechaDesde).IsModified = true;
                            E.Entry(_item).Property(s => s.fechaHasta).IsModified = true;
                            E.Entry(_item).Property(s => s.fechaAutoriza).IsModified = true;
                            E.Entry(_item).Property(s => s.usuarioAutoriza_id).IsModified = true;
                            E.Entry(_item).Property(s => s.bejermanAlta).IsModified = true;
                            
                        }
                    }

                    E.SaveChanges();

                Trae_Medicamento_Solicitado_Sin_Autorizar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Envia_Mail()
        {
            MessageBox.Show("Aguarde unos segundos...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress("sistemas@csantacatalina.com.ar"));
            email.To.Add(new MailAddress("lucas.caruso@csantacatalina.com.ar"));
            email.From = new MailAddress("sistemas@csantacatalina.com.ar");
            email.Subject = "Pedido de autorización de medicamento";
            email.Body = "Se solicita la autorización de agregar un nuevo medicamento";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            //email.Attachments.Add(new Attachment(SPath));

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("sistemas@csantacatalina.com.ar", "Omega.2017");

            string output = null;
            //this.progressBar1.Value = 80;
            try
            {
                smtp.Send(email);
                //this.progressBar1.Value = 90;
                email.Dispose();
                output = "Corre electrónico fue enviado satisfactoriamente.";
            }
            catch (Exception ex)
            {
                //output = "Error enviando correo electrónico: " + ex.Message;
            }

            Console.WriteLine(output);
        }
        #endregion

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Graba_Autorizazion();
        }
    }
}
