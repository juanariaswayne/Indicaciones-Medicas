
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
    
public partial class MED_SuministroDeMedicacion
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public MED_SuministroDeMedicacion()
    {

        this.MED_Historial_SuministroDeMedicacion = new HashSet<MED_Historial_SuministroDeMedicacion>();

    }


    public int suministroDeMedicacion_id { get; set; }

    public Nullable<int> paciente_id { get; set; }

    public string medicamento_id { get; set; }

    public Nullable<System.DateTime> fechaInicio { get; set; }

    public Nullable<decimal> dosis { get; set; }

    public Nullable<int> presentacion_id { get; set; }

    public Nullable<decimal> unidadDeMedida_id { get; set; }

    public string potencia { get; set; }

    public Nullable<int> via_id { get; set; }

    public Nullable<bool> viaTieneOtro { get; set; }

    public string viaOtro { get; set; }

    public Nullable<int> diluyente_id { get; set; }

    public Nullable<decimal> ml { get; set; }

    public Nullable<int> durante_id { get; set; }

    public Nullable<int> periodo_id { get; set; }

    public Nullable<bool> lapsoDeTiempo { get; set; }

    public Nullable<System.DateTime> lapsoDeTiempoHasta { get; set; }

    public Nullable<int> horarioDeSuministro_id { get; set; }

    public string horarioEvento { get; set; }

    public string evento { get; set; }

    public string horarioOtro { get; set; }

    public string observacion { get; set; }

    public Nullable<int> usuario_id { get; set; }

    public Nullable<System.DateTime> fechaAltaSistema { get; set; }

    public Nullable<System.DateTime> fechaModificacion { get; set; }

    public Nullable<System.DateTime> fechaBaja { get; set; }

    public string motivoBaja { get; set; }

    public Nullable<bool> HS_08 { get; set; }

    public Nullable<bool> HS_09 { get; set; }

    public Nullable<bool> HS_10 { get; set; }

    public Nullable<bool> HS_11 { get; set; }

    public Nullable<bool> HS_12 { get; set; }

    public Nullable<bool> HS_13 { get; set; }

    public Nullable<bool> HS_14 { get; set; }

    public Nullable<bool> HS_15 { get; set; }

    public Nullable<bool> HS_16 { get; set; }

    public Nullable<bool> HS_17 { get; set; }

    public Nullable<bool> HS_18 { get; set; }

    public Nullable<bool> HS_19 { get; set; }

    public Nullable<bool> HS_20 { get; set; }

    public Nullable<bool> HS_21 { get; set; }

    public Nullable<bool> HS_22 { get; set; }

    public Nullable<bool> HS_23 { get; set; }

    public Nullable<bool> HS_24 { get; set; }

    public Nullable<bool> HS_01 { get; set; }

    public Nullable<bool> HS_02 { get; set; }

    public Nullable<bool> HS_03 { get; set; }

    public Nullable<bool> HS_04 { get; set; }

    public Nullable<bool> HS_05 { get; set; }

    public Nullable<bool> HS_06 { get; set; }

    public Nullable<bool> HS_07 { get; set; }

    public Nullable<bool> HS_SH { get; set; }

    public Nullable<bool> L { get; set; }

    public Nullable<bool> M { get; set; }

    public Nullable<bool> X { get; set; }

    public Nullable<bool> J { get; set; }

    public Nullable<bool> V { get; set; }

    public Nullable<bool> S { get; set; }

    public Nullable<bool> D { get; set; }

    public Nullable<int> viaBomba { get; set; }

    public Nullable<bool> SN { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MED_Historial_SuministroDeMedicacion> MED_Historial_SuministroDeMedicacion { get; set; }

    public virtual MED_Diluyente MED_Diluyente { get; set; }

    public virtual MED_Via MED_Via { get; set; }

    public virtual MEDICAMENTO MEDICAMENTO { get; set; }

}

}
