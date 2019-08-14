using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DTO;
using QLNT.DAL;
namespace QLNT.BLL
{
    public class HoaDonBLL
    {
        public HoaDonDAL hddal { get; set; }
        public HoaDonBLL()
        {
            this.hddal = new HoaDonDAL();
        }
        public string ThoiGian()
        {
            return hddal.ThoiGian();
        }
        public List<string> PhongChuaLapHD()
        {
            return hddal.PhongChuaLapHD();
        }
        public List<Object> DV()
        {
            return hddal.TenDV();
        }
        public DICH_VU showDV(string tendv)
        {
            return hddal.showDV(tendv);
        }
        public void Them_1DV(CT_DICHVU dv)
        {
            hddal.ThemDV(dv);
        }
        public List<Object> listDv1HD()
        {
            return hddal.CTDV1H();
        }
        public CT_DICHVU cT(string madv)
        {
            return hddal.cT(madv);
        }
        public List<string> Pt()
        {
            return hddal.PhongChuaLapHDpt();
        }

        public List<Object> PhongDaLapHD()
        {
            return hddal.PhongDaLapHD();
        }
        public void ThemHD(HOA_DON hOA)
        {
            hddal.ThemHD(hOA);
        }
        public int DemHD()
        {
            return hddal.dem();
        }
        public List<Object> ChiTietHDPhong(string maphong)
        {
            return hddal.ChiTietHDPhong(maphong);
        }
        public void SuaDV(string madv, int dvsd)
        {
            hddal.SuaDV(madv, dvsd);
        }
        public void XoaDV(string madv)
        {
            hddal.XoaDV(madv);
        }
        public void XoaHD(int mahd, string madv)
        {
            hddal.XoaHD(mahd, madv);
        }
        public List<Object> LayThang()
        {
            return hddal.LayThang();
        }
        public List<Object> LayHD(int thang)
        {
            return hddal.LayHD(thang);
        }
        public List<Object> TienPhong(string maphong)
        {
            return hddal.TienPhong(maphong);
        }
        public List<Object> TienDV(int mahd)
        {
            return hddal.TienDV(mahd);
        }
        public List<Object> DoanhThuThangDV(int mahd)
        {
            return hddal.DoanhThuThangDV(mahd);
        }
        public List<Object> LayMAPHONG(int thang, int nam)
        {
            return hddal.LayMP(thang, nam);
        }
        public object Songuoi(string maphong)
        {
            return hddal.Songuoi(maphong);
        }
       public object DoanhThuThangPhong(int songuoi)
        {
            return hddal.DoanhThuThangPhong(songuoi);
        }
        public List<int> layMAHD(int thang, int nam)
        {
            return hddal.layMAHD(thang, nam);
        }
    }
}
