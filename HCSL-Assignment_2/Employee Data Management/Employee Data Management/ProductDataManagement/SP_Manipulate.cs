using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG1.Class;
using Employee_Data_Management;

namespace QUANLYBANHANG1
{

    public partial class SP_Manipulate : Form
    {
        DataTable tblSP;
        public SP_Manipulate()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void InsertForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            string conString = @"Data Source=LAPTOP-CE1V8OME;Initial Catalog=ASS2_DB;Integrated Security=True";
            con = new SqlConnection(conString);
            con.Open(); 
        }
        private void LoadDataGridView()
        {
            // datagridview1.selectitem[0]
            string sql;
            sql = "SELECT San_Pham_MaSP, San_Pham_TenSP, San_Pham_HangSX, San_Pham_MauSac, San_Pham_ChatLieu,San_Pham_MaLoai FROM San_Pham";
            tblSP = SPFunctions.GetDataToDataTable(sql); //Đọc dữ liệu từ bảng
            dgv1SanPham.DataSource = tblSP; //Nguồn dữ liệu            
            dgv1SanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgv1SanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgv1SanPham.Columns[2].HeaderText = "Hãng Sản Xuất";
            dgv1SanPham.Columns[3].HeaderText = "Màu Sắc";
            dgv1SanPham.Columns[4].HeaderText = "Chất Liệu";
            dgv1SanPham.Columns[5].HeaderText = "Mã Loại";
            dgv1SanPham.Columns[0].Width = 50;
            dgv1SanPham.Columns[1].Width = 100;
            dgv1SanPham.Columns[2].Width = 100;
            dgv1SanPham.Columns[3].Width = 100;
            dgv1SanPham.Columns[4].Width = 100;
            dgv1SanPham.Columns[5].Width = 50;
            dgv1SanPham.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgv1SanPham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void dgv1SanPham_Click(object sender, EventArgs e)
        {
            if (btnInsert.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
                return;
            }
            if (tblSP.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaSP.Text = dgv1SanPham.CurrentRow.Cells["San_Pham_MaSP"].Value.ToString();
            txtTenSP.Text = dgv1SanPham.CurrentRow.Cells["San_Pham_TenSP"].Value.ToString();
            txtHangSX.Text = dgv1SanPham.CurrentRow.Cells["San_Pham_HangSX"].Value.ToString();
            txtMauSac.Text = dgv1SanPham.CurrentRow.Cells["San_Pham_MauSac"].Value.ToString();
            txtChatLieu.Text = dgv1SanPham.CurrentRow.Cells["San_Pham_ChatLieu"].Value.ToString();
            txtMaLoai.Text = dgv1SanPham.CurrentRow.Cells["San_Pham_MaLoai"].Value.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSkip.Enabled = true;
        }
        private void ResetValue()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtHangSX.Text = "";
            txtMauSac.Text = "";
            txtChatLieu.Text = "";
            txtMaLoai.Text = "";
        }        
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fQLSP Return = new fQLSP(new HomeMenu());
            Return.Show();        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql; //Lưu câu lệnh sql
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSP.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE San_Pham SET San_Pham_TenSP=N'" +
                txtTenSP.Text.ToString() + "',San_Pham_HangSX=N'" + txtHangSX.Text.ToString() + "',San_Pham_MauSac=N'" + txtMauSac.Text.ToString() 
                + "',San_Pham_ChatLieu=N'" + txtChatLieu.Text.ToString() + "',San_Pham_MaLoai=N'" + txtMaLoai.Text.ToString() + "' WHERE San_Pham_MaSP=N'" + txtMaSP.Text + "'";
            Class.SPFunctions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnSkip.Enabled = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSP.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE San_Pham WHERE San_Pham_MaSP=N'" + txtMaSP.Text + "'";
                Class.SPFunctions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSkip.Enabled = true;
            btnSave.Enabled = true;
            btnInsert.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaSP.Enabled = true; //cho phép nhập mới
            txtMaSP.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaSP.Text.Trim().Length == 0) //Nếu chưa nhập mã sản phẩm
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0) //Nếu chưa nhập tên sản phẩm
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return;
            }
            if (txtHangSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHangSX.Focus();
                return;
            }
            if (txtMauSac.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập màu sắc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMauSac.Focus();
                return;
            }
            if (txtChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHangSX.Focus();
                return;
            }
            sql = "Select San_Pham_MaSP From San_Pham where San_Pham_MaSP=N'" + txtMaSP.Text.Trim() + "'";
            if (Class.SPFunctions.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }

            sql = "INSERT INTO San_Pham VALUES(N'" +
                txtMaSP.Text + "',N'" + txtTenSP.Text + "',N'" + txtHangSX.Text + "',N'" + txtMauSac.Text + "',N'" + txtChatLieu.Text + "',N'" + txtMaLoai.Text + "')";
            Class.SPFunctions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnDelete.Enabled = true;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;
            btnReturn.Enabled = true;
            txtMaSP.Enabled = false;
        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnSkip.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnReturn.Enabled = true;
            txtMaSP.Enabled = false;
        }
    }
}
