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
    
    public partial class BACDAOTAO
    {
        public BACDAOTAO()
        {
            this.SINHVIENs = new HashSet<SINHVIEN>();
        }
    
        public string MABACDAOTAO { get; set; }
        public string TENBACDAOTAO { get; set; }
    
        public virtual ICollection<SINHVIEN> SINHVIENs { get; set; }
    }
}
