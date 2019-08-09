using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DTO;
namespace QLNT.DAL
{
public  class NguoiDungDAL
    {
        public QLPT ql { get; set; }
        public NguoiDungDAL()
        {
            this.ql = new QLPT();
        }

        public List<USER_KHACHTHUE> User()
        {
            List<USER_KHACHTHUE> kq = ql.USER_KHACHTHUE.ToList();
            return kq;
            
            
        }
        public USER_KHACHTHUE admin()
        {
            return ql.USER_KHACHTHUE.Where(q => q.IsAdmin == 1).SingleOrDefault();
        }
    }
}
