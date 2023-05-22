//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intranet.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clasa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clasa()
        {
            this.Dirigintes = new HashSet<Diriginte>();
            this.Students = new HashSet<Student>();
        }
    
        public int ClasaID { get; set; }
        public string Nume { get; set; }
        public Nullable<int> SpecializareID { get; set; }
        public Nullable<int> DiriginteID { get; set; }
    
        public virtual Specializare Specializare { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diriginte> Dirigintes { get; set; }
        public virtual Diriginte Diriginte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
