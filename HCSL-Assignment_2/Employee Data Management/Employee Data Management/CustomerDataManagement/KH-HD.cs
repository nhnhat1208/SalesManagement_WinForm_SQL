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

namespace Quản_Lý_Khách_Hàng
{
    public partial class Form3 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-CE1V8OME;Initial Catalog=ASS2_DB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select Khach_Hang_MaKH 'Mã Khách Hàng', Khach_Hang_TenKh 'Tên Khách hàng', Khach_Hang_DiaChi 'Địa Chỉ', Hoa_Don_MaHD 'Mã Hóa Đơn', Hoa_Don_NgayDatHang 'Ngày Đặt Hàng', Hoa_Don_NgayXuatDon 'Ngày Xuất Đơn', Hoa_Don_TinhTrangDon 'Tình Trạng' " +
                "from Khach_Hang join Hoa_Don on Khach_Hang_MaKH = Hoa_Don_MaKH ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewHD.DataSource = table;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            dataGridViewHD.Columns["Mã Khách Hàng"].Width = 70;
            dataGridViewHD.Columns["Địa Chỉ"].Width = 230;
            dataGridViewHD.Columns["Mã Hóa Đơn"].Width = 70;
            dataGridViewHD.Columns["Ngày Đặt Hàng"].Width = 90;
            dataGridViewHD.Columns["Ngày Xuất Đơn"].Width = 90;
            dataGridViewHD.Columns["Tình Trạng"].Width = 70;
            dataGridViewHD.Columns["Tên Khách hàng"].Width = 130;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select Khach_Hang_MaKH 'Mã Khách Hàng', Khach_Hang_TenKh 'Tên Khách hàng', Khach_Hang_DiaChi 'Địa Chỉ', Hoa_Don_MaHD 'Mã Hóa Đơn', Hoa_Don_NgayDatHang 'Ngày Đặt Hàng', Hoa_Don_NgayXuatDon 'Ngày Xuất Đơn', Hoa_Don_TinhTrangDon 'Tình Trạng' from Khach_Hang join Hoa_Don on Khach_Hang_MaKH = Hoa_Don_MaKH where Khach_Hang_MaKH like'%"+ textBoxMaKH.Text +"%' and Khach_Hang_TenKH like N'% "+ textBoxTenKH.Text +"%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewHD.DataSource = table;
            dataGridViewHD.Columns["Mã Khách Hàng"].Width = 70;
            dataGridViewHD.Columns["Địa Chỉ"].Width = 230;
            dataGridViewHD.Columns["Mã Hóa Đơn"].Width = 70;
            dataGridViewHD.Columns["Ngày Đặt Hàng"].Width = 90;
            dataGridViewHD.Columns["Ngày Xuất Đơn"].Width = 90;
            dataGridViewHD.Columns["Tình Trạng"].Width = 70;
            dataGridViewHD.Columns["Tên Khách hàng"].Width = 130;

        } 
    }
}
