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
    public partial class WorkType_Management : Form
    {
        public WorkType_Management()
        {
            InitializeComponent();
            this.ShowWorkType();
        }
        public void ShowWorkType()
        {
            string ShowStr = "select * from work_type";
            DatabaseControl dc = new DatabaseControl();
            DataTable d1 = new DataTable();
            d1 = dc.ExecuteQuery(ShowStr);
            if (d1 != null && d1.Rows.Count > 0)
            {
                dataGridView1.DataSource = d1;   //将查询结果放入到dataGridView；
            }
        }

        private void AddWorkType_Click(object sender, EventArgs e)
        {
            AddWorkType addWorkType = new AddWorkType();
            addWorkType.Show();
        }

        private void DeleteWorkType_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            string strWorkTypeName = dataGridView1.Rows[a].Cells[0].Value.ToString();
            string AlertMessage = "确定要删除" + strWorkTypeName + "的工种吗？";
            if (MessageBox.Show(AlertMessage, "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                //确定删除
                string sqlStr = "DELETE FROM work_type where  w_name ='" + strWorkTypeName+"'";
                DatabaseControl databaseControl = new DatabaseControl();
                int d2 = databaseControl.ExecuteUpdate(sqlStr);//执行后会有返回值，是int类型，如果执行失败会返回0；
                if (d2 != 0)
                {
                    MessageBox.Show("删除成功！", "添加结果",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除失败！此工种不存在！", "添加结果",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.ShowWorkType();
        }
    }
}
