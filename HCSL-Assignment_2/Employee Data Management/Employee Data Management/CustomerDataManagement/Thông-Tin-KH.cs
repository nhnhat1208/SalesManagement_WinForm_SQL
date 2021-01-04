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
    public partial class Form2 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-CE1V8OME;Initial Catalog=ASS2_DB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select Khach_Hang_MaKH 'Mã Khách Hàng', Khach_Hang_TenKh 'Tên Khách hàng', Khach_Hang_DiaChi 'Địa Chỉ' " +
                "from Khach_Hang ";
            adapter.SelectCommand= command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewTT.DataSource = table;


        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            dataGridViewTT.Columns["Mã Khách Hàng"].Width = 110;
            dataGridViewTT.Columns["Tên Khách hàng"].Width = 120;
            dataGridViewTT.Columns["Địa Chỉ"].Width = 250;

        }

        private void dataGridViewTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.ReadOnly = true;
            int numrow;
            numrow = e.RowIndex;
            textBox1.Text = dataGridViewTT.Rows[numrow].Cells[0].Value.ToString();
            textBox3.Text = dataGridViewTT.Rows[numrow].Cells[1].Value.ToString();
            textBox2.Text = dataGridViewTT.Rows[numrow].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Khach_Hang values('"+ textBox1.Text +"', N'"+ textBox3.Text +"', N'"+  textBox2.Text +"') ";
            command.ExecuteNonQuery();
            loaddata();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " delete from Khach_Hang where Khach_Hang_MaKH = '"+ textBox1.Text +"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Khach_Hang set Khach_Hang_TenKH= N'"+ textBox3.Text +"', Khach_Hang_DiaChi= N'"+ textBox2.Text +"' where Khach_Hang_MaKH = '"+ textBox1.Text +"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select Khach_Hang_MaKH 'Mã Khách Hàng', Khach_Hang_TenKH 'Tên Khách hàng', Khach_Hang_DiaChi 'Địa Chỉ' from Khach_Hang Where Khach_Hang_MaKH  like'%" + textBox1.Text + "%' and Khach_Hang_TenKH like N'%" + textBox3.Text + "%' and Khach_Hang_DiaChi like N'%" + textBox2.Text + "%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewTT.DataSource = table;
            dataGridViewTT.Columns["Mã Khách Hàng"].Width = 110;
            dataGridViewTT.Columns["Tên Khách hàng"].Width = 120;
            dataGridViewTT.Columns["Địa Chỉ"].Width = 250;
        } 

    }
}
