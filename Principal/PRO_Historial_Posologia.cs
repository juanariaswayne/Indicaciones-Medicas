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
    
    public partial class PRO_Historial_Posologia
    {
        public int posologia_id { get; set; }
        public Nullable<int> paciente_id { get; set; }
        public Nullable<int> procedimiento_id { get; set; }
        public string PlanOral { get; set; }
        public Nullable<bool> hiposodica { get; set; }
        public Nullable<bool> SinLiquidos { get; set; }
        public Nullable<bool> LiquidosFinos { get; set; }
        public Nullable<bool> LiquidosEspesos { get; set; }
        public Nullable<bool> LiquidosAligerados { get; set; }
        public Nullable<bool> SupControl { get; set; }
        public Nullable<bool> Asistencia { get; set; }
        public Nullable<bool> Picado { get; set; }
        public Nullable<bool> Cortado { get; set; }
        public Nullable<bool> hipograsa { get; set; }
        public string alimento_id { get; set; }
        public Nullable<int> alimentoVelocidad { get; set; }
        public Nullable<int> gavageIntervalo_id { get; set; }
        public Nullable<int> gavageCantidad { get; set; }
        public Nullable<int> preparado_id { get; set; }
        public Nullable<int> preparadoVelocidad { get; set; }
        public Nullable<System.DateTime> ayunoFecha { get; set; }
        public Nullable<System.DateTime> ayunoHora { get; set; }
        public Nullable<System.DateTime> liquidoFecha { get; set; }
        public Nullable<System.DateTime> liquidoHora { get; set; }
        public string observacion { get; set; }
        public Nullable<int> usuario_id { get; set; }
        public Nullable<System.DateTime> fechaAltaSistema { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public string motivoBaja { get; set; }
        public string horario_alimento { get; set; }
        public string alimento_id2 { get; set; }
        public Nullable<int> alimentoVelocidad2 { get; set; }
        public string horario_alimento2 { get; set; }
        public string alimento_id3 { get; set; }
        public Nullable<int> alimento_velocidad3 { get; set; }
        public string horario_alimento3 { get; set; }
        public string alimento_id4 { get; set; }
        public Nullable<int> alimentoVelocidad4 { get; set; }
        public string horario_alimento4 { get; set; }
        public Nullable<bool> dbt { get; set; }
    }
}