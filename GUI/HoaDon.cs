using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.BLL;
using QLNT.DTO;
namespace QLNT.GUI
{
    public partial class HoaDon : Form
    {
        public HoaDonBLL hdbll { get; set; }
        int thang1;
        public HoaDon()
        {
            InitializeComponent();
            this.hdbll = new HoaDonBLL();
            string s = hdbll.ThoiGian();
            DateTime dt = Convert.ToDateTime(s);
            thang1= Convert.ToInt32(dt.Month.ToString()) + 1;
            thang.Text = thang1.ToString() + "/" + dt.Year.ToString();
            dgvTenDV.DataSource = hdbll.DV();
            butSua.Enabled = false;
            butThem.Enabled = false;
            butXoaDV.Enabled = false;
            butLapHD.Enabled = false;
            butXoaHD.Enabled = false;


        }
                private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            txtMaDV.Enabled = false;
            txtTenDV.Enabled = false;
            txtDongia.Enabled = false;
            List<string> pclhd = hdbll.PhongChuaLapHD();
            for (int i = 0; i < pclhd.Count; i++)
            {
                if (cbbPhongChuaTaoHD.FindStringExact(pclhd[i]) < 0) cbbPhongChuaTaoHD.Items.Add(pclhd[i]);
            }
            dgvPhongDaLapHD.DataSource = hdbll.PhongDaLapHD();

        }

        private void dgvTenDV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object i = dgvTenDV.SelectedRows[0].Cells[0].Value;
            string tendv = i.ToString();
            DICH_VU dv = hdbll.showDV(tendv);
            txtTenDV.Text = dv.DichVu;
            txtMaDV.Text = dv.MaDichVu;
            txtDongia.Text = Convert.ToInt32(dv.GiaDichVu) + "";
            lbDonVi.Text = dv.QuyCach;
            butThem.Enabled = true;
           

        }

        private void butThem_Click(object sender, EventArgs e)
        {
            try
            {
                CT_DICHVU cT_DICHVU = new CT_DICHVU
                {
                    MaDichVu = txtMaDV.Text,
                    DonViSuDung = Convert.ToInt16(txtSoluong.Text)
                };

                string maphong = cbbPhongChuaTaoHD.SelectedItem.ToString();
                if (txtSoluong.Text == "")
                    MessageBox.Show("Mời nhập số lượng!");
                else
                {
                    hdbll.Them_1DV(cT_DICHVU);
                    cbbPhongChuaTaoHD_SelectedIndexChanged(this, e);
                    dgvDV.DataSource = hdbll.listDv1HD();
                    cbbPhongChuaTaoHD.Enabled = false;
                    butLapHD.Enabled = true;
                    butThem.Enabled = false;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mời Kiểm Tra Lại!");
            }



        }

        private void cbbPhongChuaTaoHD_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvDV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object i = dgvDV.SelectedRows[0].Cells[5].Value;
            string madv = i.ToString();
            CT_DICHVU dv = hdbll.cT(madv);
            txtTenDV.Text = dv.DICH_VU.DichVu;
            int gia = Convert.ToInt32(dv.DICH_VU.GiaDichVu);
            txtDongia.Text = gia + "";
            txtMaDV.Text = dv.MaDichVu;
            lbDonVi.Text = dv.DICH_VU.QuyCach;
            txtSoluong.Text = dv.DonViSuDung.ToString();
            butSua.Enabled = true;
            butXoaDV.Enabled = true;
            butThem.Enabled = false;
        }

        private void butLapHD_Click(object sender, EventArgs e)
        {
            try
            {
                HOA_DON hd = new HOA_DON
                {
                    MaHoaDon = hdbll.DemHD() + 1,
                    MaPhong = cbbPhongChuaTaoHD.SelectedItem.ToString(),
                    NgayLap = DateTime.Now,
                };
                hdbll.ThemHD(hd);
                dgvDV.DataSource = null;
                HoaDon_Load(this, e);
                cbbPhongChuaTaoHD.Items.Remove(hd.MaPhong);
                cbbPhongChuaTaoHD.Enabled = true;
                butSua.Enabled = false;
                butThem.Enabled = false;
                butXoaDV.Enabled = false;
                butLapHD.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra lại!");
            }
            
        }

        private void dgvPhongDaLapHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPhongDaLapHD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object i = dgvPhongDaLapHD.SelectedRows[0].Cells[0].Value;
            string maphong = i.ToString();
            dgvHD.DataSource = hdbll.ChiTietHDPhong(maphong);
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            try
            {
                object i = dgvDV.SelectedRows[0].Cells[5].Value;
                string madv = i.ToString();

                int dv = Convert.ToInt32(txtSoluong.Text);
                if(txtSoluong.Text=="")
                {
                    MessageBox.Show("Mời nhập số lượng!");
                }else
                {

                    hdbll.SuaDV(madv, dv);
                    dgvDV.DataSource = hdbll.listDv1HD();
                    butThem.Enabled = false;
                }

            }
            catch (Exception p)
            {
                MessageBox.Show("Mời kiểm tra lại!");
            }
           
        }

        private void dgvHD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            butXoaHD.Enabled = true;
        }
        public List<string> TimXoa()
        {
            List<string> msp = new List<string>();
            foreach (DataGridViewRow i in dgvDV.SelectedRows)
            {
                msp.Add(i.Cells[5].Value.ToString());
            }
            return msp;
        }
            private void butXoaDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa Dich vu đã chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    for (int i = 0; i < TimXoa().Count; i++)
                    {
                        hdbll.XoaDV(TimXoa()[i]);
                      
                    }
                    MessageBox.Show("Xóa thành công!", "OK", MessageBoxButtons.OK);
                    dgvDV.DataSource = hdbll.listDv1HD();
                    butThem.Enabled = false;
                }
            }
            catch (Exception p)
            {
                MessageBox.Show("Mời kiểm tra lại!");
            }
        }
        public List<string> TimXoa2()
        {
            //MaDV
            List<string> msp = new List<string>();
            foreach (DataGridViewRow i in dgvHD.SelectedRows)
            {
                msp.Add(i.Cells[3].Value.ToString());
            }
            return msp;
        }
        private void butXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa Dich vu đã chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    object k = dgvHD.SelectedRows[0].Cells[0].Value;
                    int mahd = Convert.ToInt32(k);
                    object f = dgvPhongDaLapHD.SelectedRows[0].Cells[0].Value;
                    string maphong = f.ToString();
                    for (int i = 0; i < TimXoa2().Count; i++)
                    {
                        hdbll.XoaHD(mahd,TimXoa2()[i]);

                    }
                    MessageBox.Show("Xóa thành công!", "OK", MessageBoxButtons.OK);
                    dgvHD.DataSource = hdbll.ChiTietHDPhong(maphong);
                    butXoaHD.Enabled= false;
                }
            }
            catch (Exception p)
            {
                MessageBox.Show("Mời kiểm tra lại!");
            }
        }
    }
}
