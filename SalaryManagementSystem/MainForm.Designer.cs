namespace SalaryManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Employee_Management = new System.Windows.Forms.Button();
            this.Subsidy_Management = new System.Windows.Forms.Button();
            this.Work_Type_Management = new System.Windows.Forms.Button();
            this.Salary_Statistics = new System.Windows.Forms.Button();
            this.Attendance_Management = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(338, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "工资管理系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Employee_Management
            // 
            this.Employee_Management.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Employee_Management.Location = new System.Drawing.Point(358, 82);
            this.Employee_Management.Name = "Employee_Management";
            this.Employee_Management.Size = new System.Drawing.Size(162, 56);
            this.Employee_Management.TabIndex = 1;
            this.Employee_Management.Text = "员工管理";
            this.Employee_Management.UseVisualStyleBackColor = true;
            this.Employee_Management.Click += new System.EventHandler(this.Employee_Management_Click);
            // 
            // Subsidy_Management
            // 
            this.Subsidy_Management.Location = new System.Drawing.Point(358, 308);
            this.Subsidy_Management.Name = "Subsidy_Management";
            this.Subsidy_Management.Size = new System.Drawing.Size(162, 60);
            this.Subsidy_Management.TabIndex = 1;
            this.Subsidy_Management.Text = "津贴管理";
            this.Subsidy_Management.UseVisualStyleBackColor = true;
            this.Subsidy_Management.Click += new System.EventHandler(this.Subsidy_Management_Click);
            // 
            // Work_Type_Management
            // 
            this.Work_Type_Management.Location = new System.Drawing.Point(358, 374);
            this.Work_Type_Management.Name = "Work_Type_Management";
            this.Work_Type_Management.Size = new System.Drawing.Size(162, 64);
            this.Work_Type_Management.TabIndex = 1;
            this.Work_Type_Management.Text = "工种管理";
            this.Work_Type_Management.UseVisualStyleBackColor = true;
            this.Work_Type_Management.Click += new System.EventHandler(this.Work_Type_Management_Click);
            // 
            // Salary_Statistics
            // 
            this.Salary_Statistics.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Salary_Statistics.Location = new System.Drawing.Point(358, 157);
            this.Salary_Statistics.Name = "Salary_Statistics";
            this.Salary_Statistics.Size = new System.Drawing.Size(162, 62);
            this.Salary_Statistics.TabIndex = 1;
            this.Salary_Statistics.Text = "工资统计";
            this.Salary_Statistics.UseVisualStyleBackColor = true;
            this.Salary_Statistics.Click += new System.EventHandler(this.Salary_Statistics_Click);
            // 
            // Attendance_Management
            // 
            this.Attendance_Management.Location = new System.Drawing.Point(359, 236);
            this.Attendance_Management.Name = "Attendance_Management";
            this.Attendance_Management.Size = new System.Drawing.Size(160, 61);
            this.Attendance_Management.TabIndex = 2;
            this.Attendance_Management.Text = "考勤管理";
            this.Attendance_Management.UseVisualStyleBackColor = true;
            this.Attendance_Management.Click += new System.EventHandler(this.Attendance_Management_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.Attendance_Management);
            this.Controls.Add(this.Work_Type_Management);
            this.Controls.Add(this.Subsidy_Management);
            this.Controls.Add(this.Salary_Statistics);
            this.Controls.Add(this.Employee_Management);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MainForm";
            this.Text = "工资管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Employee_Management;
        private System.Windows.Forms.Button Subsidy_Management;
        private System.Windows.Forms.Button Work_Type_Management;
        private System.Windows.Forms.Button Salary_Statistics;
        private System.Windows.Forms.Button Attendance_Management;
    }
}

