using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DAL;
using QLNT.DTO;
namespace QLNT.BLL
{
 public   class DichVuBLL
    {
        DichVuDAL dich { get; set; }
        public DichVuBLL()
        {
            this.dich = new DichVuDAL();
        }
        public List<string> listMaloaidv()
        {
            return dich.MaLoaiDV();
        }
        public List<Object> ListDV()
        {
            return dich.ListDV();
        }
        public DICH_VU dichvu1(string madv)
        {
            return dich.show1dv(madv);
        }
        public void AddDV(DICH_VU a)
        {
            dich.AddDV(a);
        }
        public void SuaDV(DICH_VU a)
        {
            dich.SuaDV(a);
        }
    }

}
