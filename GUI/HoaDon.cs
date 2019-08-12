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
            List<string> pclhd = hdbll.PhongChuaLapHD(thang1);//hoadon
            List<string> pclhd2 = hdbll.Pt();
            List<string> differenceQuery = pclhd2.Except(pclhd).ToList();

            for (int i = 0; i < differenceQuery.Count; i++)
            {
                if (cbbPhongChuaTaoHD.FindStringExact(differenceQuery[i]) < 0) cbbPhongChuaTaoHD.Items.Add(differenceQuery[i]);
            }
           

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
                hdbll.Them_1DV(cT_DICHVU);
                cbbPhongChuaTaoHD_SelectedIndexChanged(this, e);
                dgvDV.DataSource = hdbll.listDv1HD();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mời Kiểm Tra Lại!")
            }



        }

        private void cbbPhongChuaTaoHD_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvDV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object i = dgvDV.SelectedRows[0].Cells[5].Value;
            string madv = i.ToString();
            CT_DICHVU dv = hdbll.cT(cbbPhongChuaTaoHD.SelectedItem.ToString(),madv);
            txtTenDV.Text = dv.DICH_VU.DichVu;
            int gia = Convert.ToInt32(dv.DICH_VU.GiaDichVu);
            txtDongia.Text = gia + "";
            txtMaDV.Text = dv.MaDichVu;
            lbDonVi.Text = dv.DICH_VU.QuyCach;
            txtSoluong.Text = dv.DonViSuDung.ToString();
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
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kiểm tra lại!");
            }
            
        }

        private void dgvPhongDaLapHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPhongDaLapHD.DataSource = hdbll.PhongDaLapHD(thang1).ToList();
        }
    }
}
