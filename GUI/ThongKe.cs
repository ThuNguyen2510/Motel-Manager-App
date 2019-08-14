using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.BLL;
using QLNT.DTO;
namespace QLNT.GUI
{
    public partial class ThongKe : Form
    {
        HoaDonBLL hoaDonBLL { get; set; }
        public ThongKe()
        {
            InitializeComponent();
            this.hoaDonBLL = new HoaDonBLL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LayThang();
        }
        DataTable table = new DataTable("T");
   
        public void LayThang()
        {
            List<Object> kq = hoaDonBLL.LayThang();
            List<string> x = new List<string>();
            for (int i = 0; i < kq.Count; i++)
            {
                if (!x.Contains(kq[i].ToString().Substring(12, 7)))
                    x.Add(kq[i].ToString().Substring(12, 7));

            }
            table.Columns.Add(new DataColumn("thang", typeof(string)));
            for (int i = 0; i < x.Count; i++)
            {
                table.Rows.Add(x[i]);
                
            }
            dgvThang.DataSource = table;
            List<int> thang = new List<int>();
            List<int> nam = new List<int>();
            for(int i=0;i<x.Count;i++)
            {
                nam.Add(Convert.ToInt32(x[i].Substring(0, 4)));
                thang.Add(Convert.ToInt32(x[i].Substring(5, 2)));
            }
            float tong = 0;
            for(int i=0;i<thang.Count;i++)
            {
                tong += DoanhThuThang(thang[i], nam[i]);
            }
            txtTongDT.Text = tong + "";

        }

        private void dgvThang_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object i = dgvThang.SelectedRows[0].Cells[0].Value;
            string tendv = i.ToString().Substring(5, 2);
            int thang = Convert.ToInt32(tendv);
            string ten = i.ToString().Substring(0, 4);
            int nam = Convert.ToInt32(ten);
            dgvPhong.DataSource = hoaDonBLL.LayHD(thang);
            txtTienThang.Text = DoanhThuThang(thang, nam)+ "";
        }
        public float DoanhThuThang(int thang,int nam)
        {
            List<string> MapHong = new List<string>();
            for (int h = 0; h < hoaDonBLL.LayMAPHONG(thang, nam).Count; h++)
            {
                string k = hoaDonBLL.LayMAPHONG(thang, nam)[h].ToString().Substring(12, 4);
                MapHong.Add(k);
            }

            List<int> x = hoaDonBLL.layMAHD(thang, nam);
            List<Object> tiendv = new List<object>();
            for (int p = 0; p < x.Count; p++)
            {
                for (int u = 0; u < hoaDonBLL.DoanhThuThangDV(x[p]).Count; u++)
                    if (!tiendv.Contains(hoaDonBLL.DoanhThuThangDV(x[p])[u]))
                    {
                        tiendv.Add(hoaDonBLL.DoanhThuThangDV(x[p])[u]);
                    }
            }
            float tong1 = 0;
            for (int p = 0; p < tiendv.Count; p++)
            {
                int end = tiendv[p].ToString().Length - 11 - 5;
                string t = tiendv[p].ToString().Substring(9, end);
                tong1 += float.Parse(t);
            }
            float tong2 = 0;

            List<int> sn = new List<int>();// so nguoi
            for (int l = 0; l < MapHong.Count; l++)
            {
                object r = hoaDonBLL.Songuoi(MapHong[l]);
                int s = Convert.ToInt32(r.ToString().Substring(12, 1));
                sn.Add(s);
            }
            List<Object> tienphong = new List<object>();
            for (int u = 0; u < sn.Count; u++)
            {

                if (!tienphong.Contains(hoaDonBLL.DoanhThuThangPhong(sn[u])))
                {
                    tienphong.Add(hoaDonBLL.DoanhThuThangPhong(sn[u]));
                }
            }
            for (int u = 0; u < tienphong.Count; u++)
            {
                int end = tienphong[u].ToString().Length - 19;
                string t = tienphong[u].ToString().Substring(12, end);
                tong2 += float.Parse(t);
            }
            return  tong1 + tong2;
           


        }
        private void dgvPhong_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object i = dgvPhong.SelectedRows[0].Cells[2].Value;
            string maphong = i.ToString();
            dgvTienPhong.DataSource = hoaDonBLL.TienPhong(maphong);
            object j = dgvPhong.SelectedRows[0].Cells[0].Value;
            int mahd = Convert.ToInt32(j);
            dgvTienDV.DataSource = hoaDonBLL.TienDV(mahd);
            lbPhong.Text = maphong;
            float tien = 0;// tien 1phong
            int sc = dgvTienDV.Rows.Count;           
            for (int o = 0; o < sc ; o++)
                tien += float.Parse(dgvTienDV.Rows[o].Cells[2].Value.ToString());
            tien +=float.Parse(dgvTienPhong.Rows[0].Cells[1].Value.ToString());
            txtTienPhong.Text = tien + "";
        }
       
        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
