
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
    
public partial class PRO_Alimento_Horarios_Administracion
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PRO_Alimento_Horarios_Administracion()
    {

        this.PRO_Alimento_Paciente = new HashSet<PRO_Alimento_Paciente>();

    }


    public int id { get; set; }

    public string descripcion { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PRO_Alimento_Paciente> PRO_Alimento_Paciente { get; set; }

}

}
