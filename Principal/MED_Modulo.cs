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
    
    public partial class MED_Modulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MED_Modulo()
        {
            this.MED_ModuloEmpresa = new HashSet<MED_ModuloEmpresa>();
            this.MED_PacienteModulo = new HashSet<MED_PacienteModulo>();
            this.MED_PacienteModuloTesting = new HashSet<MED_PacienteModuloTesting>();
        }
    
        public string modulo_id { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> puntaje { get; set; }
        public Nullable<bool> facturable { get; set; }
        public Nullable<int> puntajeFacturacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MED_ModuloEmpresa> MED_ModuloEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MED_PacienteModulo> MED_PacienteModulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MED_PacienteModuloTesting> MED_PacienteModuloTesting { get; set; }
    }
}