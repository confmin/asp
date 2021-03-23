using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SHOPVANGBAC.Domain.DataContext;
using SHOPVANGBAC.Models.ViewModel;

namespace SHOPVANGBAC.Models.Service
{
    public class DetailPageService
    {
        public static SANPHAM LoadDetailProduct(int Id)
        {
            SANPHAM res = null;
            SHOPVANGBACEntities db = new SHOPVANGBACEntities();
            res = db.SANPHAMs.Find(Id);
            return res;
        }
        public static IEnumerable<SANPHAM> LoadListProductRelative(int Id)
        {
            SANPHAM product = LoadDetailProduct(Id);
            if (product == null)
            {
                List<SANPHAM> lstListNewProduct = new List<SANPHAM>();
                foreach (ProductViewModel sp in ProductService.GetListNewProducts().Take(3))
                {
                    lstListNewProduct.Add(sp.Product);
                }
                return lstListNewProduct;
            }
            // nếu ID là có
            IEnumerable<SANPHAM> res = null;
            SHOPVANGBACEntities db = new SHOPVANGBACEntities();
            res = (from sp in db.SANPHAMs
                   where sp.MATH == product.MATH
                   select sp);
            if (res != null && res.ToList().Count < 3)
            {
                // lấy những sản phẩm cùng thương hiệu 
                int amount = res.ToList().Count;
                List<SANPHAM> lsp = new List<SANPHAM>();
                foreach (var item in res)
                {
                    lsp.Add(item);
                }
                // lấy những sản phẩm mới
               // IEnumerable<SANPHAM> NewProducts = ;
                foreach (var item in ProductService.GetListNewProducts().Take(3 - amount))
                {
                    lsp.Add(item.Product);
                }
                return lsp;
            }
            return res;
        }
        public static string GetTag(int Id)
        {
            string res = "";
            SHOPVANGBACEntities db = new SHOPVANGBACEntities();
            // lấy ra mã thương hiệu
            int trademark = db.SANPHAMs.Find(Id).MATH.Value;
            // lấy ra tên thương hiệu
            res = db.THUONGHIEUx.Find(trademark).TENTH;
            return res;
        }
    }
}