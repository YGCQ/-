namespace 实训
{
    partial class HeadDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.签到时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.签出时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工作时长 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.部门,
            this.职员,
            this.日期,
            this.签到时间,
            this.签出时间,
            this.工作时长});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 部门
            // 
            this.部门.DataPropertyName = "department";
            this.部门.HeaderText = "部门";
            this.部门.Name = "部门";
            // 
            // 职员
            // 
            this.职员.DataPropertyName = "name";
            this.职员.HeaderText = "职员";
            this.职员.Name = "职员";
            // 
            // 日期
            // 
            this.日期.DataPropertyName = "date";
            this.日期.HeaderText = "日期";
            this.日期.Name = "日期";
            // 
            // 签到时间
            // 
            this.签到时间.DataPropertyName = "time";
            this.签到时间.HeaderText = "签到时间";
            this.签到时间.Name = "签到时间";
            // 
            // 签出时间
            // 
            this.签出时间.DataPropertyName = "tim";
            this.签出时间.HeaderText = "签出时间";
            this.签出时间.Name = "签出时间";
            // 
            // 工作时长
            // 
            this.工作时长.DataPropertyName = "diff";
            this.工作时长.HeaderText = "工作时长";
            this.工作时长.Name = "工作时长";
            // 
            // HeadDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HeadDetails";
            this.Text = "HeadDetails";
            this.Load += new System.EventHandler(this.HeadDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职员;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 签到时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 签出时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工作时长;
    }
}