
namespace Principal.Clases
{
    class Usuario
    {
        public class UsuarioLogeado
        {
            private static string _usuario = string.Empty ;

            private static int _IdUsuario = 0;
            private static int _id_sector;
            public static string usuario_Logeado
            {
             get {return _usuario;}
             set {_usuario = value;}
            }
            public static int id_usuario_Logeado
            {
                get { return _IdUsuario; }
                set { _IdUsuario = value; }
            }
            public static int Id_Sector
            {
                get { return _id_sector; }
                set { _id_sector = value; }
            }
             
        }
        public class EmpresaLogeada
        {
            private static string _empresaIngresada = string.Empty;
            public static string EmpresaIngresada
            {
                get { return _empresaIngresada; }
                set { _empresaIngresada = value; }

            }
        }
       
    }
}

