using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Data_Management;

namespace Quản_Lý_Khách_Hàng
{
    public partial class FormQLKH : Form
    {
        HomeMenu homeMenu = new HomeMenu();
        public FormQLKH(HomeMenu src)
        {
            InitializeComponent();
            homeMenu = src;
        }

       private void tsHoaDon_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.MdiParent = this;
            frm.Name = "Form3";
            frm.Show();
        }

       private void tsThongTin_Click(object sender, EventArgs e)
       {
           Form2 frm = new Form2();
           frm.MdiParent = this;
           frm.Name = "Form2";
           frm.Show();
       }

        private void FormQLKH_Load(object sender, EventArgs e)
        {

        }

        private void FormQLKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            homeMenu.Show();
        }
    }
}
