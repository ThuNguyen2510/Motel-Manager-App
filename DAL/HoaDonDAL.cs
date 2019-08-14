using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DTO;
using System.Windows.Forms;
using System.Globalization;

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
                x.MaDichVu,x.DICH_VU.DichVu,x.DICH_VU.GiaDichVu,x.DonViSuDung,
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
        public List<Object> LayThang()
        {
            var dateTimes = ql.HOA_DON.Select(x =>new { x.NgayLap }).ToList();
            List<Object> list = new List<object>(dateTimes);        
            return list;            
        }
        public List<Object> LayHD(int thang)
        {
            var kq = ql.HOA_DON.Where(x => x.NgayLap.Value.Month == thang).Select(
                e => new
                {
                    e.MaHoaDon,
                    NgayLap = e.NgayLap.Value.Day+"/"+ e.NgayLap.Value.Month + "/"+ e.NgayLap.Value.Year,
                    e.MaPhong
                }).ToList();
            List<Object> list = new List<object>(kq);
            return list;
        }
        public List<Object> TienPhong(string maphong)
        {
            PHONG_TRO phong = ql.PHONG_TRO.Where(x => x.MaPhong == maphong).SingleOrDefault();
            var kq = ql.GIA_THUE.Where(e => e.SoNguoi == phong.SoNguoi).Select(q=> new
            {
                phong.MaPhong,GiaTien=q.GiaTien
            }).ToList();
            List<Object> f = new List<object>(kq);
            return f;
        }
        public List<Object> TienDV(int mahd)
        {
            var kq = ql.CT_DICHVU.Where(x => x.MaHoaDon == mahd).Select(q => new
            {
                q.MaDichVu,
                q.DICH_VU.DichVu,
                Tien = q.DonViSuDung * q.DICH_VU.GiaDichVu
            }).ToList();
            List<Object> e = new List<object>(kq);
            return e;
        }
        public List<int> layMAHD(int thang,int nam)
        {
            List<int> hOA_ = ql.HOA_DON.Where(x => x.NgayLap.Value.Month == thang && x.NgayLap.Value.Year == nam).Select(e => e.MaHoaDon).ToList();
           
            return hOA_;
        }
        public List<Object> DoanhThuThangDV(int mahoadon)
        {

            var tien1p = ql.CT_DICHVU.Where(q => q.MaHoaDon == mahoadon).Select(x => new
            {
                Tien = x.DonViSuDung * x.DICH_VU.GiaDichVu
            }
            ).ToList();
            List<Object> tiendv = new List<object>(tien1p);
            return tiendv;

        }
        public List<Object> LayMP(int thang, int nam)
        { 
            var kq= ql.HOA_DON.Where(x => x.NgayLap.Value.Month == thang && x.NgayLap.Value.Year == nam).Select(x =>new { x.MaPhong }).ToList();// maphong
            List<Object> h = new List<object>(kq);
            return h;
        }
        public object Songuoi(string maphong)
        {
         
            var a = ql.PHONG_TRO.Where(x => x.MaPhong == maphong).Select(q => new { q.SoNguoi }).SingleOrDefault();
            return a;
        }
        public object DoanhThuThangPhong(int songuoi)
        {
            var tienphong1 = ql.GIA_THUE.Where(x => x.SoNguoi ==songuoi).Select(z =>new { z.GiaTien }).SingleOrDefault();
            return tienphong1;
        }

    }
}
