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
    
    public partial class Specializare
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specializare()
        {
            this.Clasas = new HashSet<Clasa>();
            this.MateriiSpecializaris = new HashSet<MateriiSpecializari>();
        }
    
        public int SpecializareID { get; set; }
        public string NumeSpecializare { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clasa> Clasas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MateriiSpecializari> MateriiSpecializaris { get; set; }
    }
}