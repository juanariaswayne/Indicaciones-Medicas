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
    
    public partial class PRO_Asociacion_Procedimiento_Proc
    {
        public int id { get; set; }
        public int procedimiento_id { get; set; }
        public int procedimiento_id2 { get; set; }
        public Nullable<int> suministro_procedimiento_id { get; set; }
    
        public virtual PRO_Procedimiento PRO_Procedimiento { get; set; }
        public virtual PRO_Procedimiento PRO_Procedimiento1 { get; set; }
        public virtual PRO_SuministroDeProcedimiento PRO_SuministroDeProcedimiento { get; set; }
    }
}
