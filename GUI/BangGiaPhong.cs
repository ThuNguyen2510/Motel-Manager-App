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
    public partial class BangGiaPhong : Form
    {
        PhongTroBLL ptbll { get; set; }
        public BangGiaPhong()
        {
            InitializeComponent();
            ptbll = new PhongTroBLL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BangGiaPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ptbll.listGiaThueP();
           
            butSua.Enabled = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object u = dataGridView1.SelectedRows[0].Cells[0].Value;
            int sn = Convert.ToInt32(u.ToString());
            GIA_THUE gIA_ = ptbll.gIA_THUE(sn);
            txtSoNguoi.Text = gIA_.SoNguoi.ToString();
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            txtGiaTien.Text = string.Format(info,"{0:N}",gIA_.GiaTien);           
            butSua.Enabled = true;
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            try
            {
                GIA_THUE gIA_ = new GIA_THUE
                {
                    SoNguoi = Convert.ToInt32(txtSoNguoi.Text),
                     GiaTien = Convert.ToDecimal(txtGiaTien.Text)
                   
            };
                
                ptbll.Addgiaphong(gIA_);
                MessageBox.Show("Thêm Thành Công!");
                BangGiaPhong_Load(this, e);
        }
            catch (Exception r)
            {
                MessageBox.Show("Mời kiểm tra lại thông tin!");
            }
}

        private void butSua_Click(object sender, EventArgs e)
        {
            object u = dataGridView1.SelectedRows[0].Cells[0].Value;
            int sn = Convert.ToInt32(u.ToString());
            try
            {

                GIA_THUE gIA_ = new GIA_THUE
                {
                    SoNguoi = Convert.ToInt32(txtSoNguoi.Text),
                    GiaTien = Convert.ToDecimal(txtGiaTien.Text)
                };
                ptbll.SuaPhong(gIA_);
                MessageBox.Show("Sửa thành công!");
            }
            catch(Exception es)
                {
                MessageBox.Show("Mời kiểm tra lại thông tin!");

            }

        }
    }
}
