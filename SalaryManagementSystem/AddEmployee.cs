using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagementSystem
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EmployeeId = textBox1.Text;
            string EmployeeName = textBox2.Text;
            string EmployeeSex = textBox3.Text;
            string EmployeeWorkType = textBox4.Text;
            string EmployeeAge = textBox5.Text;
            string sqlStr = "INSERT INTO member " +
                "VALUES(" + EmployeeId + ", '" + EmployeeWorkType + "', " + EmployeeAge + ", '" + EmployeeSex + "', '" + EmployeeName + "')";
            DatabaseControl databaseControl = new DatabaseControl();
            int d2 = databaseControl.ExecuteUpdate(sqlStr);//执行后会有返回值，是int类型，如果执行失败会返回0；
            if (d2 != 0)
            {
                MessageBox.Show("添加成功！", "添加结果",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("添加失败！此工号已存在！", "添加结果",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
