using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SHOPVANGBAC.Domain.DataContext;

namespace SHOPVANGBAC.Models.ViewModel
{
    public class HomePageViewModel
    {
        public IEnumerable<SANPHAM> ProductsSelling { get; set; }
        public IEnumerable<ProductViewModel> NewProducts { get; set; }
    }
}