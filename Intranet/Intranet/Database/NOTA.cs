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
    
    public partial class NOTA
    {
        public int NOTAID { get; set; }
        public Nullable<int> Semestru { get; set; }
        public Nullable<int> Elev { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<int> Grad { get; set; }
        public int Materia { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Materie Materie { get; set; }
    }
}
