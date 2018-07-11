using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实训
{
    public partial class MainFormUser : Form
    {
        public MainFormUser()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "欢迎" + UserInfo.ID;
        }

        private void 查看记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.MdiParent = this;
            queryForm.WindowState = FormWindowState.Maximized;
            queryForm.Show();
        }

        private void MainFormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 修改密码PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswprdForm pwd = new PasswprdForm();
            pwd.MdiParent = this;
            pwd.WindowState = FormWindowState.Maximized;
            pwd.Show();
        }

        private void 修改个人信息IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
