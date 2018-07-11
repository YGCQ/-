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
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
        }

        private void 统计部门考勤DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuerHeadForm qu = new QuerHeadForm();
            qu.MdiParent = this;
            qu.WindowState = FormWindowState.Maximized;
            qu.Show();

        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void MainFormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 注销LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login lo = new login();
            lo.Show();
            this.Hide();
        }

        private void 注册新用户RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registered reg = new Registered();
            reg.MdiParent = this;
            reg.WindowState = FormWindowState.Maximized;
            reg.Show();
        }

        private void 修改密码pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminPWD pwd = new adminPWD();
            pwd.MdiParent = this;
            pwd.WindowState = FormWindowState.Maximized;
            pwd.Show();
        }

        private void 查询职员考勤EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegiCheck regiCheck = new RegiCheck();
            regiCheck.MdiParent = this;
            regiCheck.WindowState = FormWindowState.Maximized;
            regiCheck.Show();
        }
    }
}
