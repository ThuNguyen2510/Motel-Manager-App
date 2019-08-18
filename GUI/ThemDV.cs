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
    public partial class ThemDV : Form
    {
        DichVuBLL dv { get; set; }
        public delegate void Them();
        public Them ThemK;
        public ThemDV()
        {
            InitializeComponent();
            this.dv = new DichVuBLL();
        }
            private void ThemDV_Load(object sender, EventArgs e)
          {
            List<string> maloaidv = dv.listMaloaidv();
            for (int i = 0; i < maloaidv.Count; i++)
            {
                if (comboBox1.FindStringExact(maloaidv[i]) < 0) comboBox1.Items.Add(maloaidv[i]);
            }
           }

        private void butThem_Click(object sender, EventArgs e)
        {
            Themdv();
            ThemK();
            
        }
        public void Themdv()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm dịch vụ này?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DICH_VU dICH = new DICH_VU
                    {
                        MaDichVu = txtMaDV.Text,
                        DichVu = txtTenDV.Text,
                        GiaDichVu = Convert.ToDecimal(txtDonGia.Text),
                        QuyCach = txtDonViTinh.Text,
                        MaLoaiDichVu = comboBox1.SelectedItem.ToString()
                    };
                    dv.AddDV(dICH);
                    MessageBox.Show("Thêm Khách Thuê Thành Công!");
                }
            }
            catch(Exception w)
            {
                MessageBox.Show("Mời kiểm tra lại thông tin","OK",MessageBoxButtons.OK);
            }
          
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
