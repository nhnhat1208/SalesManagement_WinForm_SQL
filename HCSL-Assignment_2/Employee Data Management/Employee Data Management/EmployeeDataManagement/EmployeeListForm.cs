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
using Employee_Data_Management;

namespace Employee_Data_Management
{
    public partial class EmployeeListForm : Form
    {
        readonly EmployeeDAL emp = new EmployeeDAL();
        readonly HomeMenu homeMenu = new HomeMenu();
        public EmployeeListForm(HomeMenu src)
        {
            InitializeComponent();
            homeMenu = src;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = emp.SearchByOption(comboBox1.Text, textBox1.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void showList()
        {
            dataGridView1.DataSource = emp.GetAllEmployee();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            showList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            InsertEmployeeForm inForm = new InsertEmployeeForm(this);
            inForm.Show();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Hide();
            EmployeeDetailForm inForm = new EmployeeDetailForm(this, dataGridView1.SelectedRows[0].Cells[0]);
            inForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select ROW data you want delete and click button Delete");
                return;
            }
            
            DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Update!!", MessageBoxButtons.YesNo);
         
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    emp.DeleteEmployee(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());                   
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                return;
            }
            MessageBox.Show("Success");
            showList();
        }

        private void EmployeeListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            homeMenu.Show();
        }
    }
}
