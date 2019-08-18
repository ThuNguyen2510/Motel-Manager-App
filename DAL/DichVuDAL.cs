using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.DTO;

namespace QLNT.DAL
{
    public class DichVuDAL
    {
        QLPT ql { get; set; }
        public DichVuDAL(){
            this.ql = new QLPT();
            }
        public List<string> MaLoaiDV()
        {
            return ql.LOAI_DICH_VU.Select(x => x.MaLoaiDichVu).ToList();
        }
        public List<Object> ListDV()
        {
            var k = ql.DICH_VU.Select(x => new
            {
                x.MaDichVu,
                x.DichVu,
                x.GiaDichVu,
                x.QuyCach,
                x.MaLoaiDichVu,

            });
            List<Object> kq = new List<object>(k);
            return kq;
        }
        public DICH_VU show1dv(string madv)
        {
            return ql.DICH_VU.Where(x => x.MaDichVu == madv).SingleOrDefault();
        }
        public void AddDV(DICH_VU dICH_)
        {
           
            string madv = ql.DICH_VU.Where(x => x.MaDichVu == dICH_.MaDichVu).Select(e => e.MaDichVu).SingleOrDefault();
                if (madv!=dICH_.MaDichVu)
            {
                ql.DICH_VU.Add(dICH_);
                ql.SaveChanges();
            }           
          else
                MessageBox.Show("Mời kiểm tra lại thông tin MADV", "OK", MessageBoxButtons.OK);
            
           
        }
        public void SuaDV(DICH_VU dICH_)
        {
            DICH_VU iCH_VU = ql.DICH_VU.Where(x => x.MaDichVu == dICH_.MaDichVu).SingleOrDefault();
            iCH_VU.GiaDichVu = dICH_.GiaDichVu;
            iCH_VU.QuyCach = dICH_.QuyCach;
            iCH_VU.DichVu = dICH_.DichVu;
            iCH_VU.MaLoaiDichVu = dICH_.MaLoaiDichVu;
            ql.SaveChanges();
        }
    }
}
