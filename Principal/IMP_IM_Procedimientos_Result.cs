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
    
    public partial class IMP_IM_Procedimientos_Result
    {
        public int suministroDeProcedimiento_id { get; set; }
        public Nullable<int> paciente_id { get; set; }
        public Nullable<int> procedimiento_id { get; set; }
        public string Procedimiento { get; set; }
        public Nullable<int> tipoProcedimiento_id { get; set; }
        public Nullable<int> usuario_id { get; set; }
        public Nullable<System.DateTime> fechaAltaSistema { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public string motivoBaja { get; set; }
        public Nullable<int> enfermeria_id { get; set; }
        public Nullable<int> posologia_id { get; set; }
        public Nullable<int> generico_id { get; set; }
        public Nullable<int> colocacionViaPeriferica_id { get; set; }
        public Nullable<int> cuidadoOral_id { get; set; }
        public Nullable<int> cuidadoPostural_id { get; set; }
        public Nullable<int> php_id { get; set; }
        public Nullable<int> proteccionFisica_id { get; set; }
        public string art_Descgen { get; set; }
        public string observacion { get; set; }
    }
}