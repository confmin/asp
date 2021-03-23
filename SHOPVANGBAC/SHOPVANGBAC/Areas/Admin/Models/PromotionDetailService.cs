using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SHOPVANGBAC.Domain.DataContext;

namespace SHOPVANGBAC.Areas.Admin.Models
{
    public class PromotionDetailService
    {
        SHOPVANGBACEntities db;

        public PromotionDetailService()
        {
            db = new SHOPVANGBACEntities();
        }
        public IEnumerable<CHITIETKM> getAllPromotionDetail()
        {           
            return db.CHITIETKMs;
        }

        public IEnumerable<SANPHAM> getAllProduct()
        {
            return db.SANPHAMs;
        }

        public IEnumerable<KHUYENMAI> getALLPromotion()
        {
            return db.KHUYENMAIs;
        }

        public CHITIETKM getOnePromotionDetail(string makm, int masp)
        {         
            return db.CHITIETKMs.Find(makm, masp);          
        }

        public bool addPromotionDetail(CHITIETKM ctkm)
        {
            try
            {
                db.CHITIETKMs.Add(ctkm);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool updatePromotionDetail(CHITIETKM ctkm)
        {
            try
            {
                var result = db.CHITIETKMs.Find(ctkm.MAKM, ctkm.MASP);
                if (result != null)
                {                   
                    result.PHANTRAMKM = ctkm.PHANTRAMKM;
                    db.SaveChanges();
                    return true;
                    
                }             
                return false;                     
               
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deletePromotionDetail(string makm, int masp)
        {
            try
            {
                db.CHITIETKMs.Remove(db.CHITIETKMs.Find(makm, masp));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }


    }
}