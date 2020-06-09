namespace SalaryManagementSystem
{
    partial class WorkType_Management
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
            this.AddWorkType = new System.Windows.Forms.Button();
            this.DeleteWorkType = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(328, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 1;
            // 
            // AddWorkType
            // 
            this.AddWorkType.Location = new System.Drawing.Point(27, 22);
            this.AddWorkType.Name = "AddWorkType";
            this.AddWorkType.Size = new System.Drawing.Size(142, 36);
            this.AddWorkType.TabIndex = 2;
            this.AddWorkType.Text = "添加工种";
            this.AddWorkType.UseVisualStyleBackColor = true;
            this.AddWorkType.Click += new System.EventHandler(this.AddWorkType_Click);
            // 
            // DeleteWorkType
            // 
            this.DeleteWorkType.Location = new System.Drawing.Point(186, 22);
            this.DeleteWorkType.Name = "DeleteWorkType";
            this.DeleteWorkType.Size = new System.Drawing.Size(142, 36);
            this.DeleteWorkType.TabIndex = 2;
            this.DeleteWorkType.Text = "删除工种";
            this.DeleteWorkType.UseVisualStyleBackColor = true;
            this.DeleteWorkType.Click += new System.EventHandler(this.DeleteWorkType_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(789, 381);
            this.dataGridView1.TabIndex = 3;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(350, 22);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(142, 36);
            this.refresh.TabIndex = 2;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // WorkType_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.DeleteWorkType);
            this.Controls.Add(this.AddWorkType);
            this.Controls.Add(this.label1);
            this.Name = "WorkType_Management";
            this.Text = "工种管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddWorkType;
        private System.Windows.Forms.Button DeleteWorkType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh;
    }
}