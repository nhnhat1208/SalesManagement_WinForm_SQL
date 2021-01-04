using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUANLYBANHANG1.Class;
using Employee_Data_Management;

namespace QUANLYBANHANG1
{
    public partial class fQLSP : Form
    {
        DataTable tblSP;
        HomeMenu homeMenu = new HomeMenu();
        public fQLSP(HomeMenu src)
        {
            InitializeComponent();
            homeMenu = src;
        }
        SqlConnection con;
        private void fQLSP_Load(object sender, EventArgs e)
        {
            cbxChoice.Text = "Mã Sản Phẩm";
            LoadDataGridView();
            string conString = @"Data Source=LAPTOP-CE1V8OME;Initial Catalog=ASS2_DB;Integrated Security=True";
            con = new SqlConnection(conString);
            con.Open();

        }
     
        public void LoadDataGridView()
        {
            // datagridview1.selectitem[0]
            string sql;
            sql = "SELECT San_Pham_MaSP, San_Pham_TenSP, San_Pham_HangSX, San_Pham_MauSac, San_Pham_ChatLieu,San_Pham_MaLoai FROM San_Pham";
            tblSP = SPFunctions.GetDataToDataTable(sql); //Đọc dữ liệu từ bảng
            dgvSanPham.DataSource = tblSP; //Nguồn dữ liệu            
            dgvSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns[2].HeaderText = "Hãng Sản Xuất";
            dgvSanPham.Columns[3].HeaderText = "Màu Sắc";
            dgvSanPham.Columns[4].HeaderText ="Chất Liệu";
            dgvSanPham.Columns[5].HeaderText = "Mã Loại";
            dgvSanPham.Columns[0].Width = 50;
            dgvSanPham.Columns[1].Width = 100;
            dgvSanPham.Columns[2].Width = 100;
            dgvSanPham.Columns[3].Width = 100;
            dgvSanPham.Columns[4].Width = 100;
            dgvSanPham.Columns[5].Width = 50;
            dgvSanPham.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvSanPham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }


        private void btnManipulate_Click(object sender, EventArgs e)
        {
            this.Hide();
            SP_Manipulate Return = new SP_Manipulate (); 
            Return.Show();            
        }
        public DataTable Showdata(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxChoice.Text == "Mã Sản Phẩm")
            {
                dgvSanPham.DataSource = Showdata("Select* FROM San_Pham where San_Pham_MaSP like'%" + txtKeyWord.Text.Trim() + "%' ");
            }
            if (cbxChoice.Text == "Tên Sản Phẩm")
            {
                dgvSanPham.DataSource = Showdata("Select* FROM San_Pham where San_Pham_TenSP like N'%" + txtKeyWord.Text.Trim() + "%' ");
            }
        }
        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            if (cbxChoice.Text == "Mã Sản Phẩm")
            {
                dgvSanPham.DataSource = Showdata("Select* FROM San_Pham where San_Pham_MaSP like'%" + txtKeyWord.Text.Trim() + "%' ");
            }
            if (cbxChoice.Text == "Tên Sản Phẩm")
            {
                dgvSanPham.DataSource = Showdata("Select* FROM San_Pham where San_Pham_TenSP like N'%" + txtKeyWord.Text.Trim() + "%' ");
            }
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            LoadDataGridView();            
        }

        private void btnSalesStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            SP_HD Return = new SP_HD();
            Return.Show();
        }

        private void fQLSP_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            homeMenu.Show();
        }
    }
}
