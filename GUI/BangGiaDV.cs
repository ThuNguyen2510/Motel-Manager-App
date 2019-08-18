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
    public partial class BangGiaDV : Form
    {
        DichVuBLL dv { get; set; }
        public BangGiaDV()
        {
            InitializeComponent();
            this.dv = new DichVuBLL();
            butSua.Enabled = false;
        }


        private void butThem_Click(object sender, EventArgs e)
        {
            ThemDV them = new ThemDV();
            them.ThemK = new ThemDV.Them(show);
            them.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            butSua.Enabled = true;
            object madv = dataGridView1.SelectedRows[0].Cells[0].Value;
            string m = madv.ToString();
            DICH_VU dICH_ = dv.dichvu1(m);
            txtMaDV.Text = dICH_.MaDichVu;
            txtTenDV.Text = dICH_.DichVu;
            txtDonGia.Text = string.Format("{0:N}", dICH_.GiaDichVu);
            txtDonViTinh.Text = dICH_.QuyCach;
            comboBox1.SelectedIndex = comboBox1.FindStringExact(dICH_.MaLoaiDichVu);
        }
       public void show()
        {
            dataGridView1.DataSource = dv.ListDV();
        }
        private void BangGiaDV_Load(object sender, EventArgs e)
        {
            List<string> maloaidv = dv.listMaloaidv();
            for(int i=0;i<maloaidv.Count;i++)
            {
                if (comboBox1.FindStringExact(maloaidv[i]) < 0) comboBox1.Items.Add(maloaidv[i]);
            }
            dataGridView1.DataSource = dv.ListDV();
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            object madv = dataGridView1.SelectedRows[0].Cells[0].Value;
            string m = madv.ToString();
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa dịch vụ này?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DICH_VU dICH_ = new DICH_VU
                    {
                        MaDichVu = m,
                        DichVu = txtTenDV.Text,
                        GiaDichVu = Convert.ToDecimal(txtDonGia.Text),
                        QuyCach = txtDonViTinh.Text,
                        MaLoaiDichVu = comboBox1.SelectedItem.ToString(),
                    };
                    dv.SuaDV(dICH_);
                    show();
                    MessageBox.Show("Sửa thành công!", "OK", MessageBoxButtons.OK);
                }
                }catch(Exception p)
            {
                MessageBox.Show("Mời kiểm tra lại thông tin!","OK",MessageBoxButtons.OK);
            }
          
        }
    }
}
