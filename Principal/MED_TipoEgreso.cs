
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
    
public partial class MED_TipoEgreso
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public MED_TipoEgreso()
    {

        this.MotivoEgreso = new HashSet<MotivoEgreso>();

    }


    public int tipo_id { get; set; }

    public string Descripcion { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MotivoEgreso> MotivoEgreso { get; set; }

}

}
