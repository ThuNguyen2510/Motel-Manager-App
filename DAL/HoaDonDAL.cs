using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DTO;
using System.Windows.Forms;
namespace QLNT.DAL
{
 public   class HoaDonDAL
    {
      public  QLPT ql { get; set; }
        public HoaDonDAL()
        {
            this.ql = new QLPT();
        }

        public string ThoiGian()
        {
            string tg = ql.HOA_DON.Max(x => x.NgayLap).ToString();
            return tg;
        }
        public List<string> PhongChuaLapHD(int k)
        {
            
            List<string> r = ql.HOA_DON.Select(x => x.MaPhong).ToList();            
            return r;
        }

        public List<string> PhongChuaLapHDpt()
        {
            
            List<string> r = ql.PHONG_TRO.Where(d=>d.TrangThai==1).Select(x => x.MaPhong).ToList();

            return r;
        }
        //public List<Object> PhongDaLapHD()
        //{
        //    //return;
        //}
        public List<Object> TenDV()
        {
            var kq= ql.DICH_VU.Select(x => new { x.DichVu }).ToList();
            List<Object> k = new List<object>(kq);
            return k;
        }
        public DICH_VU showDV(string tendv)
        {
            return ql.DICH_VU.Where(x =>x.DichVu == tendv).SingleOrDefault();
        }
        //CT_DICHVU ct;
        //int ma;
        public void ThemDV(CT_DICHVU dv)
        {

            var ma = ql.HOA_DON.OrderByDescending(x => x.MaHoaDon).Take(1).Select(p => p.MaHoaDon).SingleOrDefault();
            Object s = ma;
            int mahd = (int)s;
            dv.MaHoaDon = mahd + 1 ;
           // ma = (int)s + 1;
            ql.CT_DICHVU.Add(dv);
            ////    ct = dv;
            ql.SaveChanges();
        }
        public List<Object> CTDV1H()
        {
            var ma = ql.HOA_DON.OrderByDescending(x => x.MaHoaDon).Take(1).Select(p => p.MaHoaDon).SingleOrDefault();
            Object s = ma;
            int mahd = (int)s+1;
            var dv = ql.CT_DICHVU.Where(x => x.MaHoaDon == mahd).Select(e => new
            {

                DichVu = e.DICH_VU.DichVu,
                SoLuong = e.DonViSuDung,
                e.DICH_VU.QuyCach,
                e.DICH_VU.GiaDichVu,
                TongTien = e.DICH_VU.GiaDichVu * e.DonViSuDung,
                e.MaDichVu
            }).ToList();
            List<Object> k = new List<object>(dv);
            return k;

        } 
        public CT_DICHVU cT(string maphong,string madv)
        {
           
            return ql.CT_DICHVU.Where(x => x.MaHoaDon == ma && x.MaDichVu == madv).SingleOrDefault();
            

        }
        public List<Object> PhongDaLapHD(int m)
        {
            var kq = ql.HOA_DON.Select(
                s => s.MaPhong
            );
            List<Object> r = new List<Object>(kq);
            return r;
        }
        public int dem()
        {
            return ql.HOA_DON.Count();
        }

        public void ThemHD(HOA_DON hOA)
        {
            ql.HOA_DON.Add(hOA);
            ql.SaveChanges();
        }
    }
}
