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
using QLNT.DAL;
using QLNT.DTO;
namespace QLNT.GUI
{
    public partial class ThongTin : Form
    {
        PhongTroBLL pt { get; set; }
        
        public ThongTin()
        {
            InitializeComponent();
            this.pt = new PhongTroBLL();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongTin_Load(object sender, EventArgs e)
        {

            dgv1.DataSource = pt.show1();
            
            
            
        }

        private void dgv1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            object i = dgv1.SelectedRows[0].Cells[0].Value;
            string s = i.ToString();
            dgv2.DataSource = pt.show2(s);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
