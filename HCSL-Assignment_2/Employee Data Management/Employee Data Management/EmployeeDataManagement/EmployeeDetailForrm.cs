using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Data_Management
{
    public partial class EmployeeDetailForm : Form
    {
        EmployeeListForm HomeEmpPage;
        string empId;
        EmployeeDAL emp = new EmployeeDAL();
        public EmployeeDetailForm(EmployeeListForm srcPage, DataGridViewCell data)
        {
            InitializeComponent();
            HomeEmpPage = srcPage;
            empId = (string)data.Value;
        }
        public void DisplayDetail()
        {
            textBox1.Text = empId;
            DataTable dt = new DataTable();
            dt = emp.SearchByOption("by Employee ID", empId);
            textBox2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][2].ToString();
            dateTimePicker1.Value = DateTime.Parse(dt.Rows[0][3].ToString());
            textBox5.Text = dt.Rows[0][4].ToString();
            textBox6.Text = dt.Rows[0][6].ToString();

            dataGridView1.DataSource = emp.getInfoCommunication(empId);
            dataGridView2.DataSource = emp.getWorkHistory(empId);

        }
        private void DetailInfoForrm_Load(object sender, EventArgs e)
        {
            DisplayDetail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeEmpPage.showList();
            HomeEmpPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayDetail();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Fill info: CMND!", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (!CheckData())
                return;
            DialogResult confirmResult = MessageBox.Show("Are you sure to update this item ??", "Confirm Update!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    emp.UpdateBasicInfo(empId, textBox2.Text, textBox3.Text, dateTimePicker1.Value, textBox5.Text, textBox6.Text);

                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            MessageBox.Show("Success Update!");
            DisplayDetail();

        }

        private void EmployeeDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeEmpPage.showList();
            HomeEmpPage.Show();
        }
    }
}
