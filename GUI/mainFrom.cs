using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNT.BLL;
using QLNT.DAL;
using QLNT.GUI;
namespace QLNT
{
    public partial class Form1 : Form
    {
        NguoiDungBLL ngdung { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.ngdung = new NguoiDungBLL();

        }
        int isadmin = 0;
     
        public void PQ(int a)
        {
            isadmin = a;
            if (isadmin == 1)
            {
                this.thongkeToolStripMenuItem.Enabled = true;
                this.khachthueToolStripMenuItem.Enabled = true;
                this.thongtinToolStripMenuItem.Enabled = true;
                this.phongtroToolStripMenuItem.Enabled = true;
                this.bangiaToolStripMenuItem.Enabled = true;
                this.hoadonToolStripMenuItem.Enabled = true;
                this.dangnhapToolStripMenuItem.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.thongkeToolStripMenuItem.Enabled = false;
            this.khachthueToolStripMenuItem.Enabled = false;
            this.thongtinToolStripMenuItem.Enabled = false;
            this.phongtroToolStripMenuItem.Enabled = false;
            this.bangiaToolStripMenuItem.Enabled = false;
            this.hoadonToolStripMenuItem.Enabled = false;
        }

 

        private void dangnhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            dn.s = new DangNhap.OK(PQ);
        }



        private void khachthueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachThue kt = new KhachThue();
            kt.Show();
        }

        private void bangiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void giáPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangGiaPhong bg = new BangGiaPhong();
            bg.Show();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin thongTin = new ThongTin();
            thongTin.Show();
        }

        private void đăngKýThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKyThue dangKyThue = new DangKyThue();
            dangKyThue.Show();
        }
    }
}
