using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG1.Class;
using System.Data.SqlClient;
using Employee_Data_Management;

namespace QUANLYBANHANG1
{
    public partial class SP_HD : Form
    {
        DataTable tblSP;
        public SP_HD()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            // datagridview1.selectitem[0]
            string sql;
            sql = "select San_Pham_MaSP ,San_Pham_TenSP,San_Pham_HangSX ,HoaDon_SanPham_BangGia_MaHD, HoaDon_SanPham_BangGia_Gia_Ban,HoaDon_SanPham_BangGia_SoLuong from San_Pham left outer join HDon_SanPham_BangGia on San_Pham_MaSP = HoaDon_SanPham_BangGia_MaSP ";
            tblSP = SPFunctions.GetDataToDataTable(sql); //Đọc dữ liệu từ bảng
            dgvHD_SP.DataSource = tblSP; //Nguồn dữ liệu            
            dgvHD_SP.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvHD_SP.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvHD_SP.Columns[2].HeaderText = "Hãng Sản Xuất";
            dgvHD_SP.Columns[3].HeaderText = "Màu Hóa Đơn";
            dgvHD_SP.Columns[4].HeaderText = "Giá Bán";
            dgvHD_SP.Columns[5].HeaderText = "Số Lượng";
            dgvHD_SP.Columns[0].Width = 50;
            dgvHD_SP.Columns[1].Width = 100;
            dgvHD_SP.Columns[2].Width = 100;
            dgvHD_SP.Columns[3].Width = 100;
            dgvHD_SP.Columns[4].Width = 100;
            dgvHD_SP.Columns[5].Width = 50;
            dgvHD_SP.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvHD_SP.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        SqlConnection con;
        private void SP_HD_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            string conString = @"Data Source=LAPTOP-CE1V8OME;Initial Catalog=ASS2_DB;Integrated Security=True";
            con = new SqlConnection(conString);
            con.Open();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fQLSP Return = new fQLSP(new HomeMenu());
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
            dgvHD_SP.DataSource = Showdata("Select San_Pham_MaSP ,San_Pham_TenSP,San_Pham_HangSX ,HoaDon_SanPham_BangGia_MaHD, HoaDon_SanPham_BangGia_Gia_Ban,HoaDon_SanPham_BangGia_SoLuong from San_Pham left outer join HDon_SanPham_BangGia on San_Pham_MaSP = HoaDon_SanPham_BangGia_MaSP where San_Pham_TenSP like N'%" + txtTenSP.Text.Trim() + "%' ");
        }      
        private void txtTenSP_TextChanged_1(object sender, EventArgs e)
        {
            dgvHD_SP.DataSource = Showdata("Select San_Pham_MaSP ,San_Pham_TenSP,San_Pham_HangSX ,HoaDon_SanPham_BangGia_MaHD, HoaDon_SanPham_BangGia_Gia_Ban,HoaDon_SanPham_BangGia_SoLuong from San_Pham left outer join HDon_SanPham_BangGia on San_Pham_MaSP = HoaDon_SanPham_BangGia_MaSP where San_Pham_TenSP like N'%" + txtTenSP.Text.Trim() + "%' ");
        }
    }
}
