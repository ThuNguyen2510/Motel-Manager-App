using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DAL;
using QLNT.DTO;
namespace QLNT.BLL
{
 public   class NguoiDungBLL
    {
        NguoiDungDAL user { get; set; }
        public NguoiDungBLL()
        {
            this.user = new NguoiDungDAL();
        }
        public List<USER_KHACHTHUE> DangNhap()
        {
            return user.User();
        }
       public USER_KHACHTHUE Admin()
        {
            return user.admin();
        }
       
    }
}
