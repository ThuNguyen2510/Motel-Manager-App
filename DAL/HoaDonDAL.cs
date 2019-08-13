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
        public List<string> PhongChuaLapHD()
        {
            string t = DateTime.Now.ToString("yyyy/MM");
            DateTime dateTime = Convert.ToDateTime(t);
            List<string> w=ql.PHONG_TRO.Where(x => x.TrangThai==1).Select(x=> x.MaPhong).ToList();// cac phong co nguoi thue
            List<string> r = ql.HOA_DON.Where(x =>x.NgayLap.Value.Month ==dateTime.Month&& x.NgayLap.Value.Year==dateTime.Year ).Select(x => x.MaPhong).ToList();// phong da co hoa don
            List<string> differenceQuery = w.Except(r).ToList();       //phong chua co hoa don    
            return differenceQuery;
        }

        public List<string> PhongChuaLapHDpt()
        {
            
            List<string> r = ql.PHONG_TRO.Where(d=>d.TrangThai==1).Select(x => x.MaPhong).ToList();

            return r;
        }

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
        int ma;
        public void ThemDV(CT_DICHVU dv)
        {

            var ma = ql.HOA_DON.OrderByDescending(x => x.MaHoaDon).Take(1).Select(p => p.MaHoaDon).SingleOrDefault();
            Object s = ma;
            int mahd = (int)s;
            dv.MaHoaDon = mahd + 1 ;
            ma = (int)s + 1;
            ql.CT_DICHVU.Add(dv);
            ////    ct = dv;
            ql.SaveChanges();
        }
        public void SuaDV(string madv,int dvsd)
        {
            var ud = ql.HOA_DON.OrderByDescending(x => x.MaHoaDon).Take(1).Select(p => p.MaHoaDon).SingleOrDefault();
            Object s = ud;
            int mahd = (int)s + 1;
            CT_DICHVU sua = ql.CT_DICHVU.Where(x => x.MaHoaDon ==mahd  && x.MaDichVu == madv).SingleOrDefault();
            sua.DonViSuDung = dvsd;
            ql.SaveChanges();

            
        }
        public List<Object> CTDV1H()
        {
            var ud = ql.HOA_DON.OrderByDescending(x => x.MaHoaDon).Take(1).Select(p => p.MaHoaDon).SingleOrDefault();
            Object s = ud;
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
        public CT_DICHVU cT(string madv)
        {
            var ud = ql.HOA_DON.OrderByDescending(x => x.MaHoaDon).Take(1).Select(p => p.MaHoaDon).SingleOrDefault();
            Object s = ud;
            int mahd = (int)s + 1;
            return ql.CT_DICHVU.Where(x => x.MaHoaDon == mahd && x.MaDichVu == madv).SingleOrDefault();
            

        }
        public List<Object> PhongDaLapHD()
        {
            string t = DateTime.Now.ToString("yyyy/MM");
            DateTime dateTime = Convert.ToDateTime(t);
            var kq = ql.HOA_DON.Where(x => x.NgayLap.Value.Month == dateTime.Month && x.NgayLap.Value.Year == dateTime.Year).Select(x => new { x.MaPhong }).ToList();// phong da co hoa don
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
        public List<Object> ChiTietHDPhong(string maphong)
        {
            string t = DateTime.Now.ToString("yyyy/MM");
            DateTime dateTime = Convert.ToDateTime(t);
            HOA_DON hOA = ql.HOA_DON.Where(x => x.MaPhong == maphong && x.NgayLap.Value.Month == dateTime.Month && x.NgayLap.Value.Year == dateTime.Year).SingleOrDefault();
            var kq = ql.CT_DICHVU.Where(x => x.MaHoaDon == hOA.MaHoaDon).Select(x => new
            {
                x.MaHoaDon,
                x.HOA_DON.MaPhong,
                NgayLap= x.HOA_DON.NgayLap.Value.Day+"/"+x.HOA_DON.NgayLap.Value.Month+"/"+ x.HOA_DON.NgayLap.Value.Year,
                x.MaDichVu,
                TongTien=x.DonViSuDung*x.DICH_VU.GiaDichVu,
            }).ToList();
            List<Object> k = new List<object>(kq);
            return k;
        }
        public void XoaDV(string madv)
        {
            var ud = ql.HOA_DON.OrderByDescending(x => x.MaHoaDon).Take(1).Select(p => p.MaHoaDon).SingleOrDefault();
            Object s = ud;
            int mahd = (int)s + 1;
            CT_DICHVU v= ql.CT_DICHVU.Where(x => x.MaHoaDon == mahd && x.MaDichVu == madv).SingleOrDefault();
            ql.CT_DICHVU.Remove(v);
            ql.SaveChanges();
        }
        public void XoaHD(int mahd,string madv)
        {
            CT_DICHVU v = ql.CT_DICHVU.Where(x => x.MaHoaDon == mahd && x.MaDichVu == madv).SingleOrDefault();
            ql.CT_DICHVU.Remove(v);
            ql.SaveChanges();
        }
    }
}
