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
    
    public partial class TAIKHOAN
    {
        public TAIKHOAN()
        {
            this.KHACHHANGs = new HashSet<KHACHHANG>();
        }
    
        public int MATK { get; set; }
        public string TENDN { get; set; }
        public string MATKHAU { get; set; }
        public Nullable<System.DateTime> NGAYDANGKY { get; set; }
        public Nullable<bool> TRANGTHAI { get; set; }
        public string MALOAITK { get; set; }
    
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }
        public virtual LOAITK LOAITK { get; set; }
    }
}
