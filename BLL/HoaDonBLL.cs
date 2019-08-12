using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DTO;
using QLNT.DAL;
namespace QLNT.BLL
{
 public  class HoaDonBLL
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
        public List<string> PhongChuaLapHD(int t)
        {
            return hddal.PhongChuaLapHD(t);
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
        public CT_DICHVU cT(string maphong,string madv)
        {
            return hddal.cT(maphong,madv);
        }
        public List<string> Pt()
        {
            return hddal.PhongChuaLapHDpt();
        }

        public List<Object> PhongDaLapHD(int m)
        {
            return hddal.PhongDaLapHD(m);
        }
        public void ThemHD(HOA_DON hOA)
        {
            hddal.ThemHD(hOA);
        }
        public int DemHD()
        {
            return hddal.dem();
        }

    }
}
