using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.GUI;
using QLNT.BLL;
using QLNT.DTO;
using QLNT.DAL;
namespace QLNT.GUI
{
    public partial class DangNhap : Form
    {
        NguoiDungBLL ngdung { get; set; }
        
        public DangNhap()
        {
            InitializeComponent();
            this.ngdung = new NguoiDungBLL();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
        public delegate void OK(int a);
        public OK s;
        private void butOK_Click(object sender, EventArgs e)
        {
            USER_KHACHTHUE list = ngdung.Admin();
            
           
                if (list.Username.Equals(usernametxt.Text) == true && list.Pwd.Equals(passwordtxt.Text) == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");                   
                    s(1);           
                    this.Close();
                 
             }
            else
            {
                MessageBox.Show("Mời kiểm tra lại!");
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
