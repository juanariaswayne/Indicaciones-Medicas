using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Principal.Clases
{
    public class Paciente
    {
       
            private static int _pacienteID = 0;
            public static int PacienteIngresado
            {
                get { return _pacienteID; }
                set { _pacienteID = value; }

            }

        private static string _pacienteNombre = "";
        public static string PacienteNombre
        {
            get { return _pacienteNombre; }
            set { _pacienteNombre = value; }

        }

        private static int _pacienteSede = 0;
        public static int PacienteSede
        {
            get { return _pacienteSede; }
            set { _pacienteSede = value; }

        }

        private static int _pacientePiso = 0;
        public static int PacientePiso
        {
            get { return _pacientePiso; }
            set { _pacientePiso = value; }

        }

        private static bool _pacientePediatrico = false;
        public static bool PacientePediatrico
        {
            get { return _pacientePediatrico; }
            set { _pacientePediatrico = value; }
        }


    }

    public class PHP
    {
        private static int _frasco = 0;
        public static int Frasco
        {
            get { return _frasco; }
            set { _frasco = value; }
        }
    }
   
}
