using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;   //Sử dụng đối tượng MessageBox
using QUANLYBANHANG1.Class;

namespace QUANLYBANHANG1.Class
{
    class SPFunctions
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CE1V8OME;Initial Catalog=ASS2_DB;Integrated Security=True"); //khởi tạo đối tượng

        public static void Disconnect()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }           
        }
        //Phương thức thực thi câu lệnh Select lấy dữ liệu 
        public static DataTable GetDataToDataTable(string sql)
        {
        
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(table);
            return table;
        }

        //Hàm thực hiện câu lệnh SQL
        public static void RunSQL(string sql)        
        {
            con.Open();
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }
        //Hàm kiểm tra khoá trùng
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
    }
}
