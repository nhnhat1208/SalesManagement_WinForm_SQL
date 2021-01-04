using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data_Management
{

    public class EmployeeDAL
    {
        SqlDataAdapter adpt;
        SqlCommand cmd;
        private readonly SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CE1V8OME;Initial Catalog=ASS2_DB;Integrated Security=True");
        static StringBuilder sb = new StringBuilder("");
        static void conn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            sb = new StringBuilder("");
            sb.AppendLine(e.Message);
        }
        public DataTable GetAllEmployee()
        {
            adpt = new SqlDataAdapter("SELECT * FROM Nhan_Vien", con);
            con.Open();

            DataTable dt = new DataTable();
            _ = adpt.Fill(dataTable: dt);

            for (int i = 0; i < dt.Columns.Count; i++)
                dt.Columns[i].ColumnName = dt.Columns[i].ColumnName.Remove(0, 10);
       
            con.Close();
            return dt;
        }

        public DataTable SearchByOption(string optionStr, string valueStr)
        {
            String searchCmd = "SELECT * FROM Nhan_Vien";

            // Add option to SELECT
            if (optionStr == "by Name")
            {
                searchCmd += " WHERE Nhan_Vien_HoTen = \'";
            }
            else if (optionStr == "by Employee ID")
            {
                searchCmd += " WHERE Nhan_Vien_MaNV = \'";
            }
            else if (optionStr == "by CMND ID")
            {
                searchCmd += " WHERE Nhan_Vien_CMND = \'";
            }
            // Check error control flow when user empty textbox or listbox
            else
            {
                throw new Exception("Please select the settings option to search");
            }
            if (valueStr == "")
            {
                throw new Exception("Please select the settings option to search");
            }
            // Use SQL Command String to SEARCH  in Database
            searchCmd += valueStr + '\'';
            con.Open();
            adpt = new SqlDataAdapter(searchCmd, con);
            DataTable dt = new DataTable();
            _ = adpt.Fill(dataTable: dt);

            for(int i = 0; i< dt.Columns.Count; i++)
                dt.Columns[i].ColumnName = dt.Columns[i].ColumnName.Remove(0, 10);
            
            con.Close();
            return dt;
        }
        public DataTable getInfoCommunication(string IdEmp)
        {
            DataTable dtAll = new DataTable();

            adpt = new SqlDataAdapter("SELECT NhanVien_SDT_SDT FROM NV_SDT WHERE NhanVien_SDT_MaNV = \'" + IdEmp + '\'', con);
            con.Open();
            DataTable dtnumber = new DataTable();
            _ = adpt.Fill(dataTable: dtnumber);
            con.Close();

            adpt = new SqlDataAdapter("SELECT NhanVien_Email_email FROM NVIEN_Email WHERE NhanVien_Email_MaNV = \'" + IdEmp + '\'', con);
            con.Open();
            DataTable dtemail = new DataTable();
            _ = adpt.Fill(dataTable: dtemail);
            con.Close();

            dtAll = dtnumber.Copy();
            dtAll.Columns[0].ColumnName = "SDT";
            dtAll.Columns.Add("Email");
            int i = 0;

            foreach (DataRow row in dtemail.Rows)
            {
                while(dtAll.Rows.Count < dtemail.Rows.Count)
                    dtAll.Rows.Add();
                dtAll.Rows[i++][1] = row[0];
            }

            return dtAll;
        }
        public DataTable getWorkHistory(string IdEmp)
        {
            adpt = new SqlDataAdapter("SELECT NhanVien_ChiNhanh_MaCN, NhanVien_ChiNhanh_ThoiGianBDLam, NhanVien_ChiNhanh_ConLamHayKo" +
                " FROM NV_ChiNhanh WHERE NhanVien_ChiNhanh_MaNV = \'" + IdEmp + '\'', con);
            con.Open();
            DataTable dt = new DataTable();
            _ = adpt.Fill(dataTable: dt);

            for (int i = 0; i < dt.Columns.Count; i++)
                dt.Columns[i].ColumnName = dt.Columns[i].ColumnName.Remove(0, 18);

            con.Close();
            return dt;
        }

        public void InsertEmployee(string id, string CMND, string Name, DateTime BirthDate, string address, string AccountNumber)
        {
            string sql = "INSERT INTO Nhan_Vien(Nhan_Vien_MaNV, Nhan_Vien_CMND, Nhan_Vien_HoTen, " +
                "Nhan_Vien_NgaySinh, Nhan_Vien_DiaChi, Nhan_Vien_SoTK) " +
                "VALUES(@id, @cmnd, @name, @birthdate, @address, @accountNumber)";
          
            cmd = new SqlCommand(sql, con);
            con.Open();
            sb = new StringBuilder("");
            con.InfoMessage += conn_InfoMessage;
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            cmd.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = CMND;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.Add("@birthdate", SqlDbType.DateTime).Value = BirthDate;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@accountNumber", SqlDbType.Int).Value = Int32.Parse(AccountNumber);
            cmd.ExecuteNonQuery();

            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                con.Close();
                throw new Exception(sb.ToString());
            }

            con.Close();
          
        }

        public void UpdateBasicInfo(string id, string CMND, string Name, DateTime BirthDate, string address, string AccountNumber)
        {
            
            string sql = "UPDATE Nhan_Vien SET Nhan_Vien_CMND = @cmnd, Nhan_Vien_HoTen = @name, Nhan_Vien_NgaySinh = @birthdate," +
                "Nhan_Vien_DiaChi = @address, Nhan_Vien_SoTK = @accountNumber WHERE Nhan_Vien_MaNV = @id";

            cmd = new SqlCommand(sql, con);
            con.Open();
            sb = new StringBuilder("");
            con.InfoMessage += conn_InfoMessage;
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            cmd.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = CMND;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.Add("@birthdate", SqlDbType.DateTime).Value = BirthDate;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@accountNumber", SqlDbType.Int).Value = Int32.Parse(AccountNumber);
            cmd.ExecuteNonQuery();

            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                con.Close();
                throw new Exception(sb.ToString());
            }

            con.Close();

        }

        public void DeleteEmployee(string id)
        {
            string sql = "DELETE Nhan_Vien WHERE Nhan_Vien_MaNV = @id";
          
            cmd = new SqlCommand(sql, con);
            con.Open();
            sb = new StringBuilder("");
            con.InfoMessage += conn_InfoMessage;
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            cmd.ExecuteNonQuery();

            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                con.Close();
                throw new Exception(sb.ToString());
            }

            con.Close();
        }
    }


}
