using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DAL;
using QLNT.DTO;
namespace QLNT.BLL
{
    public class KhachThueBLL
    {
        public KhachThueDAL kt {get;set;}
        public KhachThueBLL()
        {
            this.kt = new KhachThueDAL();
        }
        public List<Object> show()
        {
            return kt.show();
        }
        public KHACH_THUE lay1khach(string k)
        {
            return kt.lay1khach(k);
        }
        public void Update(KHACH_THUE ks,string ma)
        {
            kt.Update(ks,ma);
        }
        public void Add(KHACH_THUE k)
        {
            kt.Add(k);
        }
        public void Delete(string s)
        {
            kt.Delete(s);
        }
        public List<Object> Search(int i,string s)
        {
           return kt.Search(i,s);
        }

    }
}
