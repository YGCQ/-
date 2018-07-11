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
using System.Configuration;

namespace 实训
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
               Conn.sqlConn.Open();
                 
              //  SqlCommand cmd = new SqlCommand(string.Format("select * from EMPLOYEE where ID={0} and PASSWORD={1}",textBox1.Text.Trim(),textBox2.Text.Trim()), sqlConn);
                 string str="select * from EMPLOYEE where ID=@id and PASSWORD=@pwd";
                 SqlCommand cmd = new SqlCommand(str, Conn.sqlConn);
                 cmd.Parameters.Add(new SqlParameter("@id", this.textBox1.Text.Trim()));
                 cmd.Parameters.Add(new SqlParameter("@pwd", this.textBox2.Text.Trim()));

                 SqlDataReader dr = cmd.ExecuteReader();
                 if (dr.HasRows)
                 {
                     dr.Read();
                     UserInfo.ID = int.Parse(dr["id"].ToString());
                     UserInfo.Name = dr["name"].ToString();
                     UserInfo.Password = dr["password"].ToString();
                     UserInfo.role = dr["role"].ToString();
                     //  UserInfo.userPhone = dr["PHONE"].ToString();

                     MessageBox.Show(UserInfo.role + "登录成功");

                     if (UserInfo.role == "职员")
                     {
                        MainFormUser formUser = new MainFormUser();
                         formUser.Show();
                        this.Hide();

                    }

                     if (UserInfo.role == "管理员")
                     {
                         //显示库管员主界面
                          MainFormAdmin formAdmin = new MainFormAdmin();
                          formAdmin.Show();

                         // 隐藏登录界面
                         this.Hide();
                     }
                 }
                 else
                 {
                     MessageBox.Show("用户或密码错误");
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
                textBox2.SelectAll();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                button1_Click(sender,e);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registered reg = new Registered();
            this.Hide();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
