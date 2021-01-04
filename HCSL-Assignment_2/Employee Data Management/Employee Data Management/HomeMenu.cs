using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quản_Lý_Khách_Hàng;
using QUANLYBANHANG1;

namespace Employee_Data_Management
{
    public partial class HomeMenu : Form
    {
        public HomeMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormQLKH cusHome = new FormQLKH(this);
            this.Hide();
            cusHome.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeListForm empHome = new EmployeeListForm(this);
            this.Hide();
            empHome.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fQLSP productHome = new fQLSP(this);
            this.Hide();
            productHome.Show();
        }
    }
}
