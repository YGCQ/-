using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实训
{
    public partial class PasswprdForm : Form
    {
        public PasswprdForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PasswprdForm_Load(object sender, EventArgs e)
        {
            la_Id.Text = UserInfo.ID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_pwd.Text.Trim() == txt_newpwd.Text.Trim())
                {
                    Conn.sqlConn.Open();
                    string sqlstr = "UPDATE [dbo].[employee] SET password = @pwd WHERE id =@id ";
                    SqlCommand cmd = new SqlCommand(sqlstr, Conn.sqlConn);
                    cmd.Parameters.Add(new SqlParameter("@id", UserInfo.ID));
                    cmd.Parameters.Add(new SqlParameter("@pwd", this.txt_pwd.Text.Trim()));
                    int i = cmd.ExecuteNonQuery();
                    if (i >= 0)
                    {
                        MessageBox.Show("修改成功");
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
                else
                {
                    txt_newpwd.SelectAll();
                    toolTip1.SetToolTip(txt_newpwd, "输入的两次密码不一致");
                    toolTip1.Show("输入的两次密码不一致", txt_newpwd);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("访问数据库错误：" + exp.Message);
            }
            finally
            {
                Conn.sqlConn.Close();
            }
        }

        private void txt_pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txt_newpwd_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                if (txt_pwd.Text.Trim() == txt_newpwd.Text.Trim())
                {

                    button1_Click(sender, e);
                    
                }
                else
                {
                    txt_newpwd.SelectAll();
                    toolTip1.SetToolTip(txt_newpwd,"输入的两次密码不一致");
                    toolTip1.Show("输入的两次密码不一致", txt_newpwd);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_pwd_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_pwd_Leave(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(txt_pwd.Text.Trim(), "^[0-9a-zA-Z_]{1,}$"))
            {
                txt_pwd.Focus();
                txt_pwd.SelectAll();
                label4.Text = "密码包含非法字符";
            }
            else if(txt_pwd.Text.Length<=5)
            {
                txt_pwd.Focus();
                txt_pwd.SelectAll();
                label4.Text = "输入的长度小于6个字符";
                
            }
            else
            {
                label4.Text = "";
            }
        }

        private void txt_newpwd_Leave(object sender, EventArgs e)
        {
            if (txt_pwd.Text.Trim() != txt_newpwd.Text.Trim())
            {
                txt_newpwd.SelectAll();
                toolTip1.SetToolTip(txt_newpwd, "输入的两次密码不一致");
                toolTip1.Show("输入的两次密码不一致", txt_newpwd);
            }
        }
    }
}
