using SHOPVANGBAC.Domain.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHOPVANGBAC.Areas.Admin.Models
{
    public class ProductPagerViewModel
    {
        public IEnumerable<SANPHAM> Products { get; set; }
        public Pager Pager { get; set; }

    }

}