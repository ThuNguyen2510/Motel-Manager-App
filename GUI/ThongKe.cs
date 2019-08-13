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
            for(int i=0;i<kq.Count;i++)
            {
                if (!x.Contains(kq[i].ToString().Substring(12, 7)))
                    x.Add(kq[i].ToString().Substring(12,7));
                
            }           
           
            table.Columns.Add(new DataColumn("thang", typeof(string)));
           for(int i=0;i<x.Count;i++)
            {
                table.Rows.Add(x[i]);
            }

            dgvThang.DataSource = table;
        }

        private void dgvThang_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object i = dgvThang.SelectedRows[0].Cells[0].Value;
            string tendv = i.ToString().Substring(5, 2);
            int thang = Convert.ToInt32(tendv);
            string ten = i.ToString().Substring(0, 4);
            int nam = Convert.ToInt32(ten);
            txtTienThang.Text = hoaDonBLL.DoanhThuThang(thang, nam).ToString();
            dgvPhong.DataSource = hoaDonBLL.LayHD(thang);
            
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
