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
    
    public partial class PRO_SuministroDeProcedimiento_Historico
    {
        public int suministroDeProcedimiento_id { get; set; }
        public Nullable<int> paciente_id { get; set; }
        public Nullable<int> procedimiento_id { get; set; }
        public Nullable<int> tipoProcedimiento_id { get; set; }
        public Nullable<int> usuario_id { get; set; }
        public Nullable<System.DateTime> fechaAltaSistema { get; set; }
        public Nullable<System.DateTime> fechaModificiacion { get; set; }
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
        public Nullable<bool> h01 { get; set; }
        public Nullable<bool> h02 { get; set; }
        public Nullable<bool> h03 { get; set; }
        public Nullable<bool> h04 { get; set; }
        public Nullable<bool> h05 { get; set; }
        public Nullable<bool> h06 { get; set; }
        public Nullable<bool> h07 { get; set; }
        public Nullable<bool> h08 { get; set; }
        public Nullable<bool> h09 { get; set; }
        public Nullable<bool> h10 { get; set; }
        public Nullable<bool> h11 { get; set; }
        public Nullable<bool> h12 { get; set; }
        public Nullable<bool> h13 { get; set; }
        public Nullable<bool> h14 { get; set; }
        public Nullable<bool> h15 { get; set; }
        public Nullable<bool> h16 { get; set; }
        public Nullable<bool> h17 { get; set; }
        public Nullable<bool> h18 { get; set; }
        public Nullable<bool> h19 { get; set; }
        public Nullable<bool> h20 { get; set; }
        public Nullable<bool> h21 { get; set; }
        public Nullable<bool> h22 { get; set; }
        public Nullable<bool> h23 { get; set; }
        public Nullable<bool> h00 { get; set; }
        public Nullable<bool> Lunes { get; set; }
        public Nullable<bool> Martes { get; set; }
        public Nullable<bool> Miercoles { get; set; }
        public Nullable<bool> Jueves { get; set; }
        public Nullable<bool> Viernes { get; set; }
        public Nullable<bool> Sabado { get; set; }
        public Nullable<bool> Domingo { get; set; }
        public Nullable<bool> SegunNecesidad { get; set; }
        public Nullable<bool> UnicaVez { get; set; }
        public Nullable<int> suministro_original { get; set; }
        public Nullable<bool> impFactu { get; set; }
    
        public virtual PRO_Generico PRO_Generico { get; set; }
        public virtual PRO_PHPV2 PRO_PHPV2 { get; set; }
        public virtual PRO_Procedimiento PRO_Procedimiento { get; set; }
        public virtual PRO_SuministroDeProcedimiento PRO_SuministroDeProcedimiento { get; set; }
    }
}
