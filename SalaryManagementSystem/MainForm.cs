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

namespace SalaryManagementSystem
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Salary_Statistics_Click(object sender, EventArgs e)
        {
            Salary_Statistics ss = new Salary_Statistics();
            ss.Show();
        }

        private void Employee_Management_Click(object sender, EventArgs e)
        {
            Employee_Management em = new Employee_Management();

            em.Show();
        }

        private void Subsidy_Management_Click(object sender, EventArgs e)
        {
            Subsidy_Management sm = new Subsidy_Management();
            sm.Show();
        }

        private void Work_Type_Management_Click(object sender, EventArgs e)
        {
            WorkType_Management wm = new WorkType_Management();
            wm.Show();
        }

        private void Attendance_Management_Click(object sender, EventArgs e)
        {
            AttendanceManagement am = new AttendanceManagement();
            am.Show();
        }
    }
}
