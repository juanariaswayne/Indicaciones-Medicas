
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
    
public partial class MED_Via
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public MED_Via()
    {

        this.MED_Historial_SuministroDeMedicacion = new HashSet<MED_Historial_SuministroDeMedicacion>();

        this.MED_Medicamento_Via = new HashSet<MED_Medicamento_Via>();

        this.MED_SuministroDeMedicacion = new HashSet<MED_SuministroDeMedicacion>();

    }


    public int via_id { get; set; }

    public string descripcion { get; set; }

    public Nullable<bool> inactivo { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MED_Historial_SuministroDeMedicacion> MED_Historial_SuministroDeMedicacion { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MED_Medicamento_Via> MED_Medicamento_Via { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MED_SuministroDeMedicacion> MED_SuministroDeMedicacion { get; set; }

}

}
