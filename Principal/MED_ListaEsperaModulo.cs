//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Principal
{
    using System;
    using System.Collections.Generic;
    
    public partial class MED_ListaEsperaModulo
    {
        public int espera_id { get; set; }
        public string modulo_id { get; set; }
    
        public virtual MED_ListaEspera MED_ListaEspera { get; set; }
    }
}
