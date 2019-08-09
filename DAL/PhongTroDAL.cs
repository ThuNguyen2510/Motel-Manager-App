using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DTO;
namespace QLNT.DAL
{
public  class PhongTroDAL
    {
        QLPT ql { get; set; }
       public PhongTroDAL ()
        {
            this.ql = new QLPT();
        }
        public List<Object> show1()
        {
            var kq = ql.PHONG_TRO.Select(q => new
            {
                q.MaPhong,
               TrangThai= q.TrangThai.Value== 1? "Phòng đã thuê" :"Phòng còn trống",
                q.SoNguoi
            } );
            
            List<Object> k = new List<object>(kq);
            return k;
        }
        public List<Object> show2(string s)
        {
            var kq = ql.CT_KHACH_THUE.Select(p => new
            {
                p.MaPhong,
                p.MaKhach,
                p.KHACH_THUE.TenKhach,
                p.KHACH_THUE.GioiTinh,
                p.KHACH_THUE.NgheNghiep,
                p.NgayVaoPhong
            }).Where(x=> x.MaPhong==s);
            List<Object> k = new List<object>(kq);
            return k;
        }
        public List<Object> PhongCoKhach()
        {
           var kq=ql.PHONG_TRO.Where(q => q.TrangThai == 1).Select(x=> new {
               x.MaPhong,x.SoNguoi,x.ThongTinPhong,
            }).ToList();

            List<Object> k = new List<object>(kq);
            return k;
        }
        public List<string> DSPhongCoNguoi()
        {
            return ql.PHONG_TRO.Where(q => q.TrangThai == 1).Select(x => x.MaPhong).ToList();
        }
        public List<string> PhongChuaCoKhach()
        {
            return ql.PHONG_TRO.Where(q => q.TrangThai == 0).Select(x=> x.MaPhong).ToList();

        }
        public List<Object> cT_KHACH_THUEsCoPhong(string MaPhong)
        {
            var kq = ql.CT_KHACH_THUE.Where(q => q.MaPhong == MaPhong).Select(x => new
            {
                x.MaKhach,
                x.KHACH_THUE.TenKhach,
                x.KHACH_THUE.GioiTinh,
                x.KHACH_THUE.NgheNghiep,
                x.NgayVaoPhong
            });
            List<Object> k = new List<object>(kq);
            return k;

        }
        public List<Object> cT_KHACH_THUEsChuaCoPhong()
        {
            var kq= ql.KHACH_THUE.Where(q => q.TinhTrang == 0).Select(x=> new
            {
                x.MaKhach,
                x.TenKhach,
                x.GioiTinh,
                x.NgheNghiep,
                
            });
            List<Object> k = new List<object>(kq);
            return k;
        }
        public void ThemKhachVaoPhongMoi(CT_KHACH_THUE kt)
        {
           
            ql.CT_KHACH_THUE.Add(kt);
            HOP_DONG hd = new HOP_DONG
            {
                MaPhong = kt.MaPhong,
                NgayLap = kt.NgayVaoPhong
            };
            ql.HOP_DONG.Add(hd);
            PHONG_TRO pt = ql.PHONG_TRO.Where(x => x.MaPhong == kt.MaPhong).SingleOrDefault();
            KHACH_THUE k = ql.KHACH_THUE.Where(x => x.MaKhach == kt.MaKhach).SingleOrDefault();
            k.TinhTrang = 1;// co phong
            pt.TrangThai = 1;// co nguoi thue
            pt.SoNguoi++;
            ql.SaveChanges();
        }
        public void AddKhachGhep(CT_KHACH_THUE ct)
        {
            ql.CT_KHACH_THUE.Add(ct);
            PHONG_TRO pt = ql.PHONG_TRO.Where(x => x.MaPhong == ct.MaPhong).SingleOrDefault();
            pt.SoNguoi++;
            KHACH_THUE k = ql.KHACH_THUE.Where(x => x.MaKhach == ct.MaKhach).SingleOrDefault();
            k.TinhTrang = 1;
            ql.SaveChanges();
        }
    }
}
