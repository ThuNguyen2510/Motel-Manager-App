using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DAL;
using QLNT.DTO;
namespace QLNT.BLL
{
 public  class PhongTroBLL
    {
        PhongTroDAL ptdal { get; set; }
       public PhongTroBLL()
        {
            this.ptdal = new PhongTroDAL();
        }
        public List<Object> show1()
        {
            return ptdal.show1();
        }
        public List<Object> show2(string s)
        {
            return ptdal.show2(s);
        }
        public List<Object> KhachChuaCoPhong()
        {
            return ptdal.cT_KHACH_THUEsChuaCoPhong();
        }
        public List<Object> KhachDaCoPhong(string maphong)
        {
            return ptdal.cT_KHACH_THUEsCoPhong(maphong);
        }
        public List<Object> PhongDaCoKhach()
        {
            return ptdal.PhongCoKhach();
        }
        public List<string> PhongChuaCoKhach()
        {
            return ptdal.PhongChuaCoKhach();
        }
        public List<string> DSPhongCoKhach()
        {
            return ptdal.DSPhongCoNguoi();
        }
        public void AddKhachPhongMoi(CT_KHACH_THUE kt)
        {
            ptdal.ThemKhachVaoPhongMoi(kt);
        }
        public void AddKhachGhep(CT_KHACH_THUE ct)
        {
            ptdal.AddKhachGhep(ct);
        }
     }
}
