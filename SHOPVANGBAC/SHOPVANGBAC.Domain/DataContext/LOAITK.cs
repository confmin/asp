//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SHOPVANGBAC.Domain.DataContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOAITK
    {
        public LOAITK()
        {
            this.TAIKHOANs = new HashSet<TAIKHOAN>();
        }
    
        public string MALOAITK { get; set; }
        public string TENLOAITK { get; set; }
    
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
    }
}
