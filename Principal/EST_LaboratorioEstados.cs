
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
    
public partial class EST_LaboratorioEstados
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public EST_LaboratorioEstados()
    {

        this.EST_LaboratorioCab = new HashSet<EST_LaboratorioCab>();

    }


    public int estado_id { get; set; }

    public string descripcionEstado { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<EST_LaboratorioCab> EST_LaboratorioCab { get; set; }

}

}
