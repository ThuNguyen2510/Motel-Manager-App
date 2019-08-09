using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.BLL;
using QLNT.DAL;
using QLNT.DTO;
namespace QLNT.GUI
{
    public partial class KhachThue : Form
    {
        public KhachThueBLL kt { get; set; }
        public KhachThue()
        {
            InitializeComponent();
            this.kt = new KhachThueBLL();
        }
        
        private void KhachThue_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = kt.show();
        }

        private void dgvKH_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object i = dgvKH.SelectedRows[0].Cells[0].Value;
            string s = i.ToString();
            KHACH_THUE khach = kt.lay1khach(s);
            txtMaKH.Text = khach.MaKhach;
            txtTenKhach.Text = khach.TenKhach;
            txtNghe.Text = khach.QueQuan;
            txtCMND.Text = khach.CMND;
            txtQue.Text = khach.QueQuan;
            txtSDT.Text = khach.SDT;
            if(khach.GioiTinh=="Nữ")
            {
                radioButtonNu.Checked = true;
            }
            else
            {
                radioButtonNam.Checked = true;
            }
            byte[] MyData = new byte[50];
            MyData = khach.HinhAnh;

            if (MyData.Length > 50)
            {
                MemoryStream stream = new MemoryStream(MyData);
                pictureBox1.Image = new Bitmap(stream);
            }
            path1.Text = "label13";

        }
        private byte[] convertimagetobyte()
        {
            FileStream fs = new FileStream(path1.Text, FileMode.Open, FileAccess.Read);
            byte[] img = new byte[fs.Length];
            fs.Read(img, 0, (int)(fs.Length));
            return img;

        }
        private void butUpHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Choose Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*gif";
            op.FilterIndex = 1;
            op.RestoreDirectory = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = op.FileName;
                path1.Text = op.FileName;
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có chắc muốn sửa khách thuê này?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
                object i = dgvKH.SelectedRows[0].Cells[0].Value;
                string s = i.ToString();
                KHACH_THUE kc = kt.lay1khach(s);
                string fm = "Nữ";
                byte[] img = new byte[50];
                if (radioButtonNam.Checked)
                {
                    fm = "Nam";
                }
                if (path1.Text == "label13")
                {
                    img = kc.HinhAnh;
                }
                else
                {
                    img = convertimagetobyte();
                }

                KHACH_THUE ks = new KHACH_THUE
                {
                    MaKhach = s,
                    TenKhach = txtTenKhach.Text,
                    CMND = txtCMND.Text,
                    QueQuan = txtQue.Text,
                    SDT = txtSDT.Text,
                    NgheNghiep = txtNghe.Text,
                    HinhAnh = img,
                    GioiTinh = fm,
                };
                kt.Update(ks, s);
                MessageBox.Show("Sửa Thành Công!","OK", MessageBoxButtons.OK);
                dgvKH.DataSource = kt.show();
                path1.Text = "label13";
           // }
        }
        private bool checkempty(string x)
        {
            return x.Equals("");
        }
        private void butThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thêm khách thuê này?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                    string gt = "Nam";
                    if (radioButtonNu.Checked) gt = "Nữ";
                    byte[] img = new byte[50];
                    if (path1.Text != "label13")
                        img = convertimagetobyte();
                    KHACH_THUE k = new KHACH_THUE
                    {
                        MaKhach = txtMaKH.Text,
                        TenKhach = txtTenKhach.Text,
                        CMND = txtCMND.Text,
                        QueQuan = txtQue.Text,
                        NgheNghiep = txtNghe.Text,
                        GioiTinh = gt,
                        SDT = txtSDT.Text,
                        HinhAnh = img
                    };
                    if (checkempty(txtMaKH.Text) == true || checkempty(txtTenKhach.Text) == true)
                    {
                        MessageBox.Show("Mời kiểm tra lại thông tin","OK",MessageBoxButtons.OK);
                    }
                    else
                    {
                        kt.Add(k);
                        dgvKH.DataSource = kt.show();
                    }

               
            }

        }
        public List<string> TimXoa()
        {
            List<string> msp = new List<string>();
            foreach (DataGridViewRow i in dgvKH.SelectedRows)
            {
                msp.Add(i.Cells[0].Value.ToString());
            }
            return msp;

        }
        private void butXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa Khách thuê đã chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //try
                //{
                    for (int i = 0; i < TimXoa().Count; i++)
                    {
                        kt.Delete(this.TimXoa()[i]);
                    }
                    MessageBox.Show("Xóa thành công!","OK",MessageBoxButtons.OK);
                    dgvKH.DataSource = kt.show();
               // }
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Thất bại, kiểm tra lại!","OK",MessageBoxButtons.OK);
                //}
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            dgvKH.DataSource = kt.Search(cbbSearch.SelectedIndex,txtSearch.Text);
        }

        private void cbbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            butSearch.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
