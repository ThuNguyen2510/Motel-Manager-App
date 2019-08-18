using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DTO;
using System.Windows.Forms;
namespace QLNT.DAL
{
 public   class KhachThueDAL
    {
        public QLPT ql { get; set; }
        public KhachThueDAL()
        {
            this.ql = new QLPT();
        }
        public List<Object> show()
        {
            var kq = ql.KHACH_THUE.Select(q => new
            {
                q.MaKhach, q.TenKhach, q.GioiTinh, q.CMND, q.NgheNghiep, q.QueQuan,q.SDT
            });
            List<Object> kt = new List<Object>(kq);
            return kt;
        }
        public KHACH_THUE lay1khach(string ma)
        {
            return ql.KHACH_THUE.Where(q => q.MaKhach == ma).SingleOrDefault();
        }

        public void Update(KHACH_THUE ks,string ma)
        {
            KHACH_THUE kc = this.lay1khach(ma);
            kc.TenKhach = ks.TenKhach;
            kc.GioiTinh = ks.GioiTinh;
            kc.HinhAnh = ks.HinhAnh;
            kc.CMND = ks.CMND;
            kc.SDT = ks.SDT;
            kc.NgheNghiep = ks.NgheNghiep;
            kc.QueQuan = ks.QueQuan;
            ql.SaveChanges();
        }
        public void Add(KHACH_THUE ks)
        {
            try
            {
                ql.KHACH_THUE.Add(ks);
                ks.TinhTrang = 0;
              
                ql.SaveChanges();
                MessageBox.Show("Thêm Khách Thuê Thành Công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mời kiểm tra lại thông tin!");
            }
          
        }
        public void Delete(string s)
        {
            KHACH_THUE k = this.lay1khach(s);
            //USER_KHACHTHUE u = ql.USER_KHACHTHUE.Where(x => x.MaKhach == k.MaKhach).SingleOrDefault();
            CT_KHACH_THUE ct = ql.CT_KHACH_THUE.Where(x => x.MaKhach == k.MaKhach).SingleOrDefault();
            ct.PHONG_TRO.SoNguoi--;            
            ql.KHACH_THUE.Remove(k);
            ql.CT_KHACH_THUE.Remove(ct);
          //  ql.USER_KHACHTHUE.Remove(u);
            ql.SaveChanges();

        }
        public List<Object> Search(int i, string s)
        {
            var kq = ql.KHACH_THUE.Select(q => new
            {
                q.MaKhach,
                q.TenKhach,
                q.GioiTinh,
                q.CMND,
                q.NgheNghiep,
                q.QueQuan,
                q.SDT
            });

            if (i == 0)
            {
                kq = ql.KHACH_THUE.Select(q => new
                {
                    q.MaKhach,
                    q.TenKhach,
                    q.GioiTinh,
                    q.CMND,
                    q.NgheNghiep,
                    q.QueQuan,
                    q.SDT
                }).Where(q => q.TenKhach.Contains(s));


            } else if (i == 1)
            {
                kq = ql.KHACH_THUE.Select(q => new
                {
                    q.MaKhach,
                    q.TenKhach,
                    q.GioiTinh,
                    q.CMND,
                    q.NgheNghiep,
                    q.QueQuan,
                    q.SDT
                }).Where(q => q.MaKhach.Contains(s));
            } else if (i == 2)
            {
                kq = ql.KHACH_THUE.Select(q => new
                {
                    q.MaKhach,
                    q.TenKhach,
                    q.GioiTinh,
                    q.CMND,
                    q.NgheNghiep,
                    q.QueQuan,
                    q.SDT
                }).Where(q => q.GioiTinh == s);
            }
            else if (i == 3)
            {
                
                kq = ql.KHACH_THUE.Select(q => new
                {
                    q.MaKhach,
                    q.TenKhach,
                    q.GioiTinh,
                    q.CMND,
                    q.NgheNghiep,
                    q.QueQuan,
                    q.SDT
                }).Where(q => q.QueQuan.Contains(s));
                
            }

            List<Object> kt = new List<Object>(kq);
            return kt;


        }
       

    }
    
}
