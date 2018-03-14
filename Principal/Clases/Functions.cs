using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.IO;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
namespace Clases
{
	public class Functions
	{


        public enum DATE_FORMAT
        {
            DDMMYYYY = 0,
            YYYYMMDD = 1

        }

        public static int SelectItemByValue(ComboBox cbo, string value)
        {
            for (int i = 0; i < cbo.Items.Count; i++)
            {
                var prop = cbo.Items[i].GetType().GetProperty(cbo.ValueMember);
                if (prop != null && prop.GetValue(cbo.Items[i], null).ToString() == value)
                {
                    return i;
                }
            }

            return 0;
        }


        #region SendMail
        /// <summary>
        /// Envia email
        /// </summary>
        /// <param name="SERVER">Dirección o IP del servidor de correo</param>
        /// <param name="PORT">Puerto de SMTP</param>
        /// <param name="TO">Direccion del destinatario del correo</param>
        /// <param name="FROM">Direccion del remitente</param>
        /// <param name="SUBJECT">Tema o encabezado de correo</param>
        /// <param name="BODY">Mensaje</param>       
        /// <returns></returns>
        public static bool SendMail(string SERVER, int PORT, string TO, string FROM, string SUBJECT, string BODY)
        {            
            try
            {                                
                MailMessage Message = new MailMessage(FROM, TO);
                SmtpClient Client = new SmtpClient(SERVER, PORT);

                Message.SubjectEncoding = System.Text.Encoding.Default;
                Message.Subject = SUBJECT;
                Message.BodyEncoding = System.Text.Encoding.Default;
                Message.Body = BODY;
                
                try
                {
                    Client.Send(Message);
                }
                catch (System.Exception ehttp)
                {
                    throw ehttp;                    
                }                
            }
            catch (System.Exception ex)
            {
                throw ex;                
            }
            return true;
        }


        /// <summary>
        /// Envia email
        /// </summary>
        /// <param name="SERVER">Dirección o IP del servidor de correo</param>
        /// <param name="PORT">Puerto de SMTP</param>
        /// <param name="TO">Direccion del destinatario del correo</param>
        /// <param name="FROM">Direccion del remitente</param>
        /// <param name="SUBJECT">Tema o encabezado de correo</param>
        /// <param name="BODY">Mensaje</param>       
        /// <returns></returns>
        public static bool SendMail(string SERVER, int PORT, string TO, string FROM, string SUBJECT, string BODY, string SENDER_PASSWORD)
        {
            try
            {
                MailMessage Message = new MailMessage(FROM, TO);
                SmtpClient Client = new SmtpClient(SERVER, PORT);
                NetworkCredential oCredential = new NetworkCredential(FROM,SENDER_PASSWORD);

                Client.Credentials = oCredential;

                Message.SubjectEncoding = System.Text.Encoding.Default;
                Message.Subject = SUBJECT;
                Message.BodyEncoding = System.Text.Encoding.Default;
                Message.Body = BODY;

                try
                {
                    Client.Send(Message);
                }
                catch (System.Exception ehttp)
                {
                    throw ehttp;
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return true;
        }


        /// <summary>
        /// Sobrecarga de envio de correo
        /// </summary>
        /// <param name="SERVER"></param>
        /// <param name="PORT"></param>
        /// <param name="TO"></param>
        /// <param name="FROM"></param>
        /// <param name="SUBJECT"></param>
        /// <param name="BODY"></param>
        /// <param name="ATTACH_FILENAME"></param>
        /// <returns></returns>
        public static bool SendMail(string SERVER, int PORT, string TO, string FROM, string SUBJECT, string BODY, ArrayList ATTACH_FILENAME)
        {           
            int i;

            try
            {

                MailMessage Message = new MailMessage(FROM, TO);
                SmtpClient Client = new SmtpClient(SERVER, PORT);
                //Client.Credentials = (System.Net.ICredentialsByHost)(System.Net.CredentialCache.DefaultCredentials);
                Attachment attach = null;

                Message.SubjectEncoding = System.Text.Encoding.Default;
                Message.Subject = SUBJECT;
                Message.BodyEncoding = System.Text.Encoding.Default;
                Message.Body = BODY;

                for (i = 0; i < ATTACH_FILENAME.Count; i++)
                {
                    attach = new Attachment(ATTACH_FILENAME[i].ToString());
                    Message.Attachments.Add(attach);
                }
                try
                {
                    Client.Send(Message);
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
                
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return true;

        }

        #endregion



        //*************************** TEXT FILE MANAGER *************************** //
        #region IO Text function
        /// <summary>
        /// Escribe en un archivo de texto, lo borra si existe
        /// </summary>
        /// <param name="PathFileName">Nombre de archivo, incluye el path</param>
        /// <param name="Data">Datos a escribir</param>
        /// <returns>Verdadero si pudo escribir, falso caso contrario</returns>
        public static bool TextFileWrite(string PathFileName, string Data)
        {
            try
            {
                
                if (File.Exists(PathFileName))                    
                    File.Delete(PathFileName);

                StreamWriter sr = File.CreateText(PathFileName);

                sr.WriteLine(Data);
                sr.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lee los datos de un archivo plano.
        /// </summary>
        /// <param name="PathFileName">Nombre de archivo, incluye el path</param>
        /// <returns>Texto Leido</returns>
        public static string TextFileReader(string PathFileName)
        {
            string data = string.Empty;

            if (!File.Exists(PathFileName))
            {
                return "";
            }
            StreamReader sr = new StreamReader(PathFileName,Encoding.Default);
            
            data = sr.ReadToEnd();
            sr.Close();
            return data;
        }
        /// <summary>
        /// Modifica un archivo de texto
        /// </summary>
        /// <param name="PathFileName">Nombre de archivo, incluye el path</param>
        /// <param name="Data"></param>
        /// <returns>Verdadero si pudo modificar, falso caso contrario</returns>
        public static bool TextFileAppend(string PathFileName, string Data)
        {
            StreamWriter sr;
            if (!File.Exists(PathFileName))
                sr = File.CreateText(PathFileName);
            else
                sr = File.AppendText(PathFileName);

            sr.WriteLine(Data);
            sr.Close();
            return true;
        }
        /// <summary>
        /// mueve un archivo de lugar
        /// </summary>
        /// <param name="PathFileName"></param>
        /// <param name="NewPathFileName"></param>
        public static bool FileRename(string PathFileName, string NewPathFileName)
        {
            bool ret = true;
            try
            {
                if (File.Exists(PathFileName))
                {
                    if(File.Exists(NewPathFileName))
                        File.Delete(NewPathFileName);
                    File.Move(PathFileName, NewPathFileName);
                    if (File.Exists(PathFileName))
                        File.Delete(PathFileName);
                }
            }
            catch (System.Exception)
            {
                ret = false;
            }
            return (ret);
        }

        /// <summary>
        /// Crea una carpeta en disco
        /// </summary>
        /// <param name="PathDir"></param>
        /// <returns></returns>
        public static bool CreateDirectory(string PathDir)
        {
            try
            {
                if (PathDir == string.Empty)
                    return false;
                if (Directory.Exists(PathDir))
                    return true;
                // Trata de crear el directorio
                DirectoryInfo di = Directory.CreateDirectory(PathDir);
                // Para borrarlo hay que hacer
                // di.Delete();				
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally { }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static string[] GetFileNames(string path, string filter)
        {
            string[] files = Directory.GetFiles(path, filter);
            for (int i = 0; i < files.Length; i++)
                files[i] = Path.GetFileName(files[i]);
            return files;
        }
        #endregion

        //*************************** TEXT FILE MANAGER *************************** //


        #region Numeric

        // Verifica si la cadena es numerica
        public static bool IsNumericRegEX(string Value)
        {
            //return System.Text.RegularExpressions.Regex.IsMatch(Value,"^[-0-9]*.[.0-9].[0-9]*$");
            return System.Text.RegularExpressions.Regex.IsMatch(Value, @"(^[-+]?\d+(,?\d*)*\.?\d*([Ee][-+]\d*)?$)|(^[-+]?\d?(,?\d*)*\.\d+([Ee][-+]\d*)?$)");
        }
        // Verifica si la cadena es digital
        public static bool IsDigits(string Value)
        {
            int i;
            bool Ret = true;
            if (Value == "") { Ret = false; }
            for (i = 0; i < Value.Length; i++)
                if (!Char.IsDigit(Value[i])) { Ret = false; }

            return Ret;

        }

        // Convierte un string a un valor Entero
        public static int ConvToInt32(string Value)
        {
            Value = Value.Trim();
            if (IsNumericRegEX(Value))
                return Convert.ToInt32(Value);
            else
                return 0;
        }
        // Convierte un string a un valor Entero Largo
        public static long ConvToInt64(string Value)
        {
            Value = Value.Trim();
            if (IsNumericRegEX(Value))
                return Convert.ToInt64(Value);
            else
                return 0;
        }
        // Convierte un string a un valor Doble decimal
        public static double ConvToDouble(string Value)
        {
            Value = Value.Trim();
            if (IsNumericRegEX(Value))
                return Convert.ToDouble(Value);
            else
                return 0;
        }
        // Convierte un string a un valor decimal
        public static decimal ConvToDecimal(string Value)
        {
            Value = Value.Trim();
            if (IsNumericRegEX(Value))
                return Convert.ToDecimal(Value);
            else
                return 0;
        }

        public static float ConvToFloat(string Value)
        {
            Value = Value.Trim();
            if (IsNumericRegEX(Value))
                return float.Parse(Value);
            else
                return 0;
        }
        //*************************** DATE MANAGER *************************** //
        public static string ConvertDateFormat(string DateValue, bool withTime)
        {
            System.DateTime sDate = new System.DateTime();
            string DateRet;
            if (DateValue == string.Empty)
                DateValue = "01/01/2000";
            
            sDate = DateTime.Parse(DateValue);

            if (withTime)
                DateRet = sDate.Year.ToString() + "-" + sDate.Month.ToString() + "-" + sDate.Day.ToString() + " " + sDate.Hour.ToString() + ":" + sDate.Minute.ToString() + ":" + sDate.Second.ToString();
            else
                DateRet = sDate.Year.ToString() + "-" + sDate.Month.ToString() + "-" + sDate.Day.ToString();

            return DateRet;
        }
        public static string ConvertDateFormat(string DateValue, DATE_FORMAT Format)
        {
            System.DateTime sDate = new System.DateTime();
            string DateRet;
            if (DateValue == string.Empty)
                DateValue = "01/01/2000";

            sDate = DateTime.Parse(DateValue);
            switch (Format)
            {
                case DATE_FORMAT.DDMMYYYY:
                    DateRet = sDate.Day.ToString() + "/" + sDate.Month.ToString() + "/" + sDate.Year.ToString();
                    break;
                case DATE_FORMAT.YYYYMMDD:
                    DateRet = sDate.Year.ToString() + "-" + sDate.Month.ToString() + "-" + sDate.Day.ToString();
                    break;
                default:
                    DateRet = sDate.Year.ToString() + "-" + sDate.Month.ToString() + "-" + sDate.Day.ToString();
                    break;
            }

            return DateRet;
        }
        public static string ConvertDateFormat(string DateValue)
        {
            System.DateTime sDate = new System.DateTime();
            string DateRet;
            if (DateValue == string.Empty)
                DateValue = "01/01/1900";

            sDate = DateTime.Parse(DateValue);
            
            DateRet = sDate.Year.ToString() + "-" + sDate.Month + "-" + sDate.Day + " " + sDate.Hour + ":" + sDate.Minute + ":" + sDate.Second;
            return DateRet;
        }
        public static string ConvertDecimalFormat(string Value)
        {
            int index = -1;
            // Reemplaza todos los puntos por comas
            Value = Value.Replace(".", ",").ToString();

            if (Value == String.Empty) { return Value; }
            // Reemplaza por (0,)  si comienza con (,)			
            if (Value.Substring(0, 1).ToString() == ",") { Value = "0" + Value; }
            // Toma la primera ocurrencia de la coma
            // Y reemplaza el resto de las comas por nada
            index = Value.IndexOf(",");
            if (index >= 0)                
                Value = Value.Substring(0, index).ToString() + "," + Value.Substring(index).Replace(",", "").ToString();
            return Value;

        }
        public static string ConvertDateFormatScreen(string DateValue)
        {
            System.DateTime sDate = new System.DateTime();
            string DateRet;
            if (DateValue == string.Empty)
                DateValue = "01/01/1900";

            sDate = DateTime.Parse(DateValue);
            DateRet = sDate.Day.ToString().PadLeft(2, '0') + "/" + sDate.Month.ToString().PadLeft(2, '0') + "/" + sDate.Year.ToString();
            return DateRet;
        }
        public static string ConvertCanonicFormatSQL(string DateValue, bool withTime)
        {
            System.DateTime sDate = new System.DateTime();
            string DateRet;
            if (DateValue == string.Empty)
                DateValue = "01/01/2000";

            sDate = DateTime.Parse(DateValue);
            if (withTime)
                DateRet = sDate.Year.ToString() + "-" + sDate.Month.ToString() + "-" + sDate.Day.ToString() + " " + sDate.Hour.ToString() + ":" + sDate.Minute.ToString() + ":" + sDate.Second.ToString();
            else
                DateRet = sDate.Year.ToString() + "-" + sDate.Month.ToString() + "-" + sDate.Day.ToString();

            return DateRet;
        }
        /// <summary>
        /// Verifica si una expresion es numerica o no
        /// </summary>
        /// <param name="Expression"></param>
        /// <returns></returns>
        public static bool IsNumeric(object Expression)
        {
            bool isNum;
            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        
        #endregion

        //*************************** CONTROLS ************************************ //

        #region Miselaneous
        
        

        public static bool ValidEmail(string validatingstring)
        {
            //bool ret = false;
            //ret=Regex.Match(validatingstring, @"^[a-zA-Z][a-zA-Z0-9_-]+@[a-zA-Z]+[.]{1}[a-zA-Z]+$").Success;
            //return (ret);
            if (validatingstring == null || validatingstring.Length == 0)
            {
                //throw new ArgumentNullException("validatingstring");
                return false;
            }

            //const string expression = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            //                          @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            //                          @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return Regex.IsMatch(validatingstring, @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|[a-zA-Z]{2})$", RegexOptions.IgnorePatternWhitespace);

            //Regex regex = new Regex(expression);
            //return regex.IsMatch(validatingstring);

                
        }

        #endregion
        
        #region Date
            // Verifica si la cadena es una fecha
            public static bool IsDate(string Value)
            {
                string Patron1 = "(((0[1-9]|[12][0-9]|3[01])([/]|[-])?(0[13578]|10|12)([/]|[-])?(’’d{4}))" +
                                "|(([0][1-9]|[12][0-9]|30)([/]|[-])?(0[469]|11)([/]|[-])?(’’d{4}))" +
                                "|((0[1-9]|1[0-9]|2[0-8])([/]|[-])?(02)([/]|[-])?(’’d{4}))" +
                                "|((29)([/]|[-])?(02)([/]|[-])?((20)[02468][048]))" +
                                "|((29)([/]|[-])?(02)([/]|[-])?((20)[13579][26])))";

                string Patron = "^("+Patron1+")$";

                Regex ExpresionRegular = new Regex(Patron);

                return ExpresionRegular.IsMatch(Value);
                
                //return System.Text.RegularExpressions.Regex.IsMatch(Value, "^(0?[1-9]|1[0-9]|2|2[0-9]|3[0-1])/(0?[1-9]|1[0-2])/(d{2}|d{4})$");

            }
        #endregion


    }
}
