//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentHomeWebAplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            this.Landlord = new HashSet<Landlord>();
            this.Landlord1 = new HashSet<Landlord>();
        }
    
        public Nullable<long> IdDepartment { get; set; }
        public Nullable<long> IdRoom { get; set; }
        public Nullable<long> IdHouse { get; set; }
        public long IdProperty { get; set; }
        public long IdPriority { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual House House { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Landlord> Landlord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Landlord> Landlord1 { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Priority Priority1 { get; set; }
        public virtual Room Room { get; set; }
        public virtual Room Room1 { get; set; }
    }
}
