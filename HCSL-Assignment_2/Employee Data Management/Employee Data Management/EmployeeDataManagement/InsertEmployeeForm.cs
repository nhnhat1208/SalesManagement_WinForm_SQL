using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Data_Management
{
    public partial class InsertEmployeeForm : Form
    {
        EmployeeListForm HomeEmpPage;
        EmployeeDAL emp = new EmployeeDAL();
        public InsertEmployeeForm(EmployeeListForm srcPage)
        {
            InitializeComponent();
            HomeEmpPage = srcPage;
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Fill info: Mã NV!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Fill info: CMND!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Fill info: Họ và Tên!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Fill info: Địa chỉ!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox5.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Fill info: Số TK!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox6.Focus();
                return false;
            }
            if (!Int32.TryParse(textBox6.Text, out _))
            {
                MessageBox.Show("Please input number: Số TK!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox6.Clear();
                textBox6.Focus();
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;
            try
            {
                emp.InsertEmployee(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, textBox5.Text, textBox6.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            MessageBox.Show("Success");
            this.Close();
            HomeEmpPage.showList();
            HomeEmpPage.Show();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {

        }

        private void InsertEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeEmpPage.showList();
            HomeEmpPage.Show();
        }
    }
}
