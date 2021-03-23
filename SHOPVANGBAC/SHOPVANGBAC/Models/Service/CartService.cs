using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SHOPVANGBAC.Domain.DataContext;

namespace SHOPVANGBAC.Models.Service
{
    public class CartService
    {
        public static bool CheckNumberProduct(int id,int soluong)
        {
            SHOPVANGBACEntities db = new SHOPVANGBACEntities();
            SANPHAM sp = db.SANPHAMs.Where(s => s.MASP == id).SingleOrDefault();
            return sp.SOLUONG >= soluong;
        }
    }
}