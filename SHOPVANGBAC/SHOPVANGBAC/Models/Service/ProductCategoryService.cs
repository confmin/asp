using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SHOPVANGBAC.Domain.DataContext;
using SHOPVANGBAC.Models.ViewModel;

namespace SHOPVANGBAC.Models.Service
{
    public class ProductCategoryService
    {
        /// <summary>

        /// </summary>
        /// <param name="category"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static IEnumerable<SANPHAM> LoadProductCategory(string category, ref int totalRecord, int pageIndex = 1, int pageSize = 8)
        {
            IEnumerable<SANPHAM> ListProductCategory = null;
            SHOPVANGBACEntities db = new SHOPVANGBACEntities();
            if (category =="tat-ca")
            {
                totalRecord = (from sp in db.SANPHAMs
                               orderby sp.MASP descending
                               select sp).Count();
                try
                {
                    ListProductCategory = (from sp in db.SANPHAMs
                                           orderby sp.MASP descending
                                           select sp).Skip((pageIndex - 1) * pageSize).Take(pageSize);
                }
                catch (Exception e)
                {

                }
            }
            if (category =="bac")
            {
                totalRecord = (from sp in db.SANPHAMs
                               where sp.MALOAISP == "LP00001"
                               orderby sp.MASP descending
                               select sp).Count();
                try
                {
                    ListProductCategory = (from sp in db.SANPHAMs
                                           where sp.MALOAISP == "LP00001"
                                           orderby sp.MASP descending
                                           select sp).Skip((pageIndex - 1) * pageSize).Take(pageSize);
                }
                catch (Exception e)
                {

                }
            }
            if (category =="vang")
            {
                totalRecord = (from sp in db.SANPHAMs
                               where sp.MALOAISP == "LP00002"
                               orderby sp.MASP descending
                               select sp).Count();
                try
                {
                    ListProductCategory = (from sp in db.SANPHAMs
                                           where sp.MALOAISP == "LP00002"
                                           orderby sp.MASP descending
                                           select sp).Skip((pageIndex - 1) * pageSize).Take(pageSize);
                }
                catch (Exception e)
                {

                }
            }
            return ListProductCategory;
        }

        /// <summary>
        /// Service load tất cả sản phẩm
        /// </summary>
        /// <returns></returns>
        public static List<ProductViewModel> LoadProductAll()
        {
            SHOPVANGBACEntities db = new SHOPVANGBACEntities();
            List<ProductViewModel> result = new List<ProductViewModel>();
            IEnumerable<SANPHAM> LoadProductAll = new List<SANPHAM>();
            LoadProductAll = (from sp in db.SANPHAMs
                              orderby sp.MASP descending
                              select sp);
            // Lấy promotion của sản phẩm
            foreach (SANPHAM sp in LoadProductAll)
            {
                int Promotion = PromotionService.GetPromotion(sp.MASP);
                ProductViewModel productViewModel = new ProductViewModel { Product = sp, Promotion = Promotion };
                result.Add(productViewModel);
            }
            return result;
        }
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public static List<ProductViewModel> LoadProductBac()
        {
            SHOPVANGBACEntities db = new SHOPVANGBACEntities();
            List<ProductViewModel> result = new List<ProductViewModel>();
            IEnumerable<SANPHAM> LoadProductBac = new List<SANPHAM>();

            LoadProductBac = (from sp in db.SANPHAMs
                              where sp.MALOAISP == "LP00001"
                              orderby sp.MASP descending
                              select sp);

            // Lấy promotion của sản phẩm
            foreach (SANPHAM sp in LoadProductBac)
            {
                int Promotion = PromotionService.GetPromotion(sp.MASP);
                ProductViewModel productViewModel = new ProductViewModel { Product = sp, Promotion = Promotion };
                result.Add(productViewModel);
            }
            return result;
        }
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public static List<ProductViewModel> LoadProductVang()
        {
            SHOPVANGBACEntities db = new SHOPVANGBACEntities();
            List<ProductViewModel> result = new List<ProductViewModel>();
            IEnumerable<SANPHAM> LoadProductVang = new List<SANPHAM>();

            LoadProductVang = (from sp in db.SANPHAMs
                              where sp.MALOAISP == "LP00002"
                              orderby sp.MASP descending
                              select sp);

            // Lấy promotion của sản phẩm
            foreach (SANPHAM sp in LoadProductVang)
            {
                int Promotion = PromotionService.GetPromotion(sp.MASP);
                ProductViewModel productViewModel = new ProductViewModel { Product = sp, Promotion = Promotion };
                result.Add(productViewModel);
            }
            return result;
        }   
    }
}