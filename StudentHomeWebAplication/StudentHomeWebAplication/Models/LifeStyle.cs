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
    
    public partial class LifeStyle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LifeStyle()
        {
            this.Student = new HashSet<Student>();
        }
    
        public int IdCleanliness { get; set; }
        public long IdLifeStyle { get; set; }
        public long IdGetUp { get; set; }
        public long IdGotoBed { get; set; }
    
        public virtual Cleanliness Cleanliness { get; set; }
        public virtual GetUp GetUp { get; set; }
        public virtual GoToBed GoToBed { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Student { get; set; }
    }
}