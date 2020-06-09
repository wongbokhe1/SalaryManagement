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
    public partial class Employee_Management : Form
    {
        public Employee_Management()
        {
            InitializeComponent();
            this.ShowEmployee();
        }

        public void ShowEmployee()
        {
            string ShowStr = "select * from member";
            DatabaseControl dc = new DatabaseControl();
            DataTable d1 = new DataTable();
            d1 = dc.ExecuteQuery(ShowStr);
            if (d1 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d1;   //将查询结果放入到dataGridView；
            }
        }
    
        private void Add_Employee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.ShowEmployee();
        }

        private void Delete_Employee_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            string strID = dataGridView1.Rows[a].Cells[0].Value.ToString();
            string AlertMessage = "确定要删除id为" +strID +"的员工吗？";
            if (MessageBox.Show(AlertMessage, "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                //确定删除
                string sqlStr = "DELETE FROM member where  id =" + strID ;
                DatabaseControl databaseControl = new DatabaseControl();
                int d2 = databaseControl.ExecuteUpdate(sqlStr);//执行后会有返回值，是int类型，如果执行失败会返回0；
                if (d2 != 0)
                {
                    MessageBox.Show("删除成功！", "添加结果",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除失败！此工号不存在！", "添加结果",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
