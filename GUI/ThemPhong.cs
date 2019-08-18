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
    public partial class ThemPhong : Form
    {
        PhongTroBLL pt { get; set; }
        public ThemPhong()
        {
            InitializeComponent();
            this.pt = new PhongTroBLL();
        }
        public delegate void THEM();
        public THEM t;

        private void butThem_Click(object sender, EventArgs e)
        {
            try
            {
                GIA_THUE gIA_ = new GIA_THUE
                {
                    SoNguoi = Convert.ToInt32(txtSoNguoi.Text),
                    GiaTien = Convert.ToDecimal(txtGiaTien.Text)

                };

                pt.Addgiaphong(gIA_);
                MessageBox.Show("Thêm Thành Công!", "OK", MessageBoxButtons.OK);
                t();
            }
            catch (Exception r)
            {
                MessageBox.Show("Mời kiểm tra lại thông tin!", "OK", MessageBoxButtons.OK);
            }
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
