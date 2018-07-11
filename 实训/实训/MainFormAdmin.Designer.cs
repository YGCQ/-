namespace 实训
{
    partial class MainFormAdmin
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.修改密码pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册新用户RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询职员考勤EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计部门考勤DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 20);
            this.toolStripStatusLabel1.Text = "欢迎";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码pToolStripMenuItem,
            this.注册新用户RToolStripMenuItem,
            this.查询职员考勤EToolStripMenuItem,
            this.统计部门考勤DToolStripMenuItem,
            this.注销LToolStripMenuItem,
            this.退出EToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 修改密码pToolStripMenuItem
            // 
            this.修改密码pToolStripMenuItem.Name = "修改密码pToolStripMenuItem";
            this.修改密码pToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.修改密码pToolStripMenuItem.Text = "修改密码&p";
            this.修改密码pToolStripMenuItem.Click += new System.EventHandler(this.修改密码pToolStripMenuItem_Click);
            // 
            // 注册新用户RToolStripMenuItem
            // 
            this.注册新用户RToolStripMenuItem.Name = "注册新用户RToolStripMenuItem";
            this.注册新用户RToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.注册新用户RToolStripMenuItem.Text = "注册新用户&R";
            this.注册新用户RToolStripMenuItem.Click += new System.EventHandler(this.注册新用户RToolStripMenuItem_Click);
            // 
            // 查询职员考勤EToolStripMenuItem
            // 
            this.查询职员考勤EToolStripMenuItem.Name = "查询职员考勤EToolStripMenuItem";
            this.查询职员考勤EToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.查询职员考勤EToolStripMenuItem.Text = "查询职员考勤&E";
            this.查询职员考勤EToolStripMenuItem.Click += new System.EventHandler(this.查询职员考勤EToolStripMenuItem_Click);
            // 
            // 统计部门考勤DToolStripMenuItem
            // 
            this.统计部门考勤DToolStripMenuItem.Name = "统计部门考勤DToolStripMenuItem";
            this.统计部门考勤DToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.统计部门考勤DToolStripMenuItem.Text = "统计部门考勤&D";
            this.统计部门考勤DToolStripMenuItem.Click += new System.EventHandler(this.统计部门考勤DToolStripMenuItem_Click);
            // 
            // 注销LToolStripMenuItem
            // 
            this.注销LToolStripMenuItem.Name = "注销LToolStripMenuItem";
            this.注销LToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.注销LToolStripMenuItem.Text = "注销&L";
            this.注销LToolStripMenuItem.Click += new System.EventHandler(this.注销LToolStripMenuItem_Click);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.退出EToolStripMenuItem.Text = "退出 &E";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFormAdmin";
            this.Text = "管理员界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.MainFormAdmin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改密码pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册新用户RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询职员考勤EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计部门考勤DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
    }
}