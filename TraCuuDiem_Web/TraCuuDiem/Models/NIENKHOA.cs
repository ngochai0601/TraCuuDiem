//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TraCuuDiem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NIENKHOA
    {
        public NIENKHOA()
        {
            this.HOCKies = new HashSet<HOCKY>();
            this.SINHVIENs = new HashSet<SINHVIEN>();
        }
    
        public int MANIENKHOA { get; set; }
        public Nullable<int> NAMBATDAU { get; set; }
        public Nullable<int> NAMKETTHUC { get; set; }
    
        public virtual ICollection<HOCKY> HOCKies { get; set; }
        public virtual ICollection<SINHVIEN> SINHVIENs { get; set; }
    }
}
