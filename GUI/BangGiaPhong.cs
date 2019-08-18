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
        public void show()
        {
            dataGridView1.DataSource = ptbll.listGiaThueP();
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object u = dataGridView1.SelectedRows[0].Cells[0].Value;
            int sn = Convert.ToInt32(u.ToString());
            GIA_THUE gIA_ = ptbll.gIA_THUE(sn);
            txtSoNguoi.Text = gIA_.SoNguoi.ToString();
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            txtGiaTien.Text = string.Format("{0:N}",gIA_.GiaTien);           
            butSua.Enabled = true;
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            ThemPhong themPhong = new ThemPhong();
            themPhong.t = new ThemPhong.THEM(show);
            themPhong.Show();
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            object u = dataGridView1.SelectedRows[0].Cells[0].Value;
            int sn = Convert.ToInt32(u.ToString());
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa phòng này?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GIA_THUE gIA_ = new GIA_THUE
                    {
                        SoNguoi = Convert.ToInt32(txtSoNguoi.Text),
                        GiaTien = Convert.ToDecimal(txtGiaTien.Text)
                    };
                    ptbll.SuaPhong(gIA_);
                    MessageBox.Show("Sửa thành công!","OK",MessageBoxButtons.OK);
                }
            }
            catch(Exception es)
                {
                MessageBox.Show("Mời kiểm tra lại thông tin!", "OK", MessageBoxButtons.OK);

            }

        }
    }
}
