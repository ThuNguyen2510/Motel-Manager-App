using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.DAL;
using QLNT.BLL;
using QLNT.DTO;
namespace QLNT.GUI
{
    public partial class DangKyThue : Form
    {
         PhongTroBLL ql { get; set; }
         KhachThueBLL kt { get; set; }
        public DangKyThue()
        {
            InitializeComponent();
            this.ql = new PhongTroBLL();
            this.kt = new KhachThueBLL();
        }

        private void DangKyThue_Load(object sender, EventArgs e)
        {
            dgvPhongCoKhach.DataSource = ql.PhongDaCoKhach();           
            dgvKhachChuaCoPhong.DataSource = ql.KhachChuaCoPhong();
            List<string> PhongOGhep = ql.DSPhongCoKhach();
            List<string> PhongMoi =  ql.PhongChuaCoKhach();
            for (int i=0;i<PhongOGhep.Count;i++)
            {
                if (cbbPhongGhep.FindStringExact(PhongOGhep[i]) < 0) cbbPhongGhep.Items.Add(PhongOGhep[i]);
            }
            for(int i=0;i<PhongMoi.Count;i++)
            {
                if (cbbPhongMoi.FindString(PhongMoi[i]) < 0) cbbPhongMoi.Items.Add(PhongMoi[i]);
            }
            rbtGhep.Enabled = false;
            rbtPhongMoi.Enabled = false;
            cbbPhongGhep.Enabled = false;
            cbbPhongMoi.Enabled = false;
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPhongCoKhach_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object i = dgvPhongCoKhach.SelectedRows[0].Cells[0].Value;
            string s = i.ToString();
            dgvKhachDangThue.DataSource = ql.KhachDaCoPhong(s).ToList();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtPhongMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPhongMoi.Checked)
            {
                cbbPhongMoi.Enabled = true;
                cbbPhongGhep.Enabled = false;
            }
        }

        private void rbtGhep_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtGhep.Checked)
            {
                cbbPhongGhep.Enabled = true;
                cbbPhongMoi.Enabled = false;
            }
        }
        int c = 0;
        private void dgvKhachChuaCoPhong_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            c = 1;
            if (c == 1)
            {
                rbtPhongMoi.Enabled = true;
                rbtGhep.Enabled = true;
            }else
            {
                rbtGhep.Enabled = false;
                rbtPhongMoi.Enabled = false;
            }
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm khách thuê này?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    object i = dgvKhachChuaCoPhong.SelectedRows[0].Cells[0].Value;
                    string makhach = i.ToString();
                    KHACH_THUE k = kt.lay1khach(makhach);
                    CT_KHACH_THUE ct = new CT_KHACH_THUE
                    {
                        MaKhach = k.MaKhach,
                        NgayVaoPhong = DateTime.Now,
                    };

                    if (rbtPhongMoi.Checked)
                    {
                        ct.MaPhong = cbbPhongMoi.SelectedItem.ToString();
                        ql.AddKhachPhongMoi(ct);
                        DangKyThue_Load(this, e);
                    }
                    else if (rbtGhep.Checked)
                    {
                        ct.MaPhong = cbbPhongGhep.SelectedItem.ToString();
                        ql.AddKhachGhep(ct);
                        DangKyThue_Load(this, e);
                    }
                    MessageBox.Show("Thêm Khách Thuê Thành Công!");


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mời kiểm tra lại thông tin!");

            }



        }
    }
}
