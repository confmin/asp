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
    
    public partial class KHACHHANG
    {
        public KHACHHANG()
        {
            this.DONHANGs = new HashSet<DONHANG>();
        }
    
        public int MAKH { get; set; }
        public Nullable<int> MATK { get; set; }
        public string TENKH { get; set; }
        public string EMAIL { get; set; }
        public string SDT { get; set; }
        public string GIOITINH { get; set; }
        public string DIACHI { get; set; }
    
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
