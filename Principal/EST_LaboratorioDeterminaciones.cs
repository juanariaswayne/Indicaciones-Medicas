
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
    
public partial class EST_LaboratorioDeterminaciones
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public EST_LaboratorioDeterminaciones()
    {

        this.EST_LaboratorioItems = new HashSet<EST_LaboratorioItems>();

    }


    public int estudio_id { get; set; }

    public string descEstudio { get; set; }

    public Nullable<int> tipoEstudio_id { get; set; }

    public Nullable<bool> inHabilitado { get; set; }



    public virtual EST_LaboratorioTipoEstudio EST_LaboratorioTipoEstudio { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<EST_LaboratorioItems> EST_LaboratorioItems { get; set; }

}

}
