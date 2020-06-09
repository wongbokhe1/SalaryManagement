namespace SalaryManagementSystem
{
    partial class Employee_Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Employee = new System.Windows.Forms.Button();
            this.Delete_Employee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(333, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 0;
            // 
            // Add_Employee
            // 
            this.Add_Employee.Location = new System.Drawing.Point(24, 22);
            this.Add_Employee.Name = "Add_Employee";
            this.Add_Employee.Size = new System.Drawing.Size(122, 38);
            this.Add_Employee.TabIndex = 1;
            this.Add_Employee.Text = "添加员工";
            this.Add_Employee.UseVisualStyleBackColor = true;
            this.Add_Employee.Click += new System.EventHandler(this.Add_Employee_Click);
            // 
            // Delete_Employee
            // 
            this.Delete_Employee.Location = new System.Drawing.Point(175, 22);
            this.Delete_Employee.Name = "Delete_Employee";
            this.Delete_Employee.Size = new System.Drawing.Size(122, 38);
            this.Delete_Employee.TabIndex = 1;
            this.Delete_Employee.Text = "删除员工";
            this.Delete_Employee.UseVisualStyleBackColor = true;
            this.Delete_Employee.Click += new System.EventHandler(this.Delete_Employee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(776, 372);
            this.dataGridView1.TabIndex = 2;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(356, 25);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(62, 32);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Employee_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete_Employee);
            this.Controls.Add(this.Add_Employee);
            this.Controls.Add(this.label1);
            this.Name = "Employee_Management";
            this.Text = "员工管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Employee;
        private System.Windows.Forms.Button Delete_Employee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh;
    }
}