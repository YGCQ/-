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

namespace 实训
{
    public partial class Registered : Form
    {
        public Registered()
        {
            InitializeComponent();
        }

        private void Registered_Load(object sender, EventArgs e)
        {
            try
            {
                 Conn.sqlConn.Open();
            string sqlstr = "select MAX(id+1) as id from employee";
            SqlCommand cmd = new SqlCommand(sqlstr, Conn.sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                lab1.Text = dr[0].ToString();
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
                textBox3.SelectAll();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.sqlConn.Open();
                string sqlstr = "insert into [dbo].[employee] ([id], [name],[password], [gender], [department], [role]) VALUES (@id,@name，@password,@dender,@department,@role) ";
                SqlCommand cmd = new SqlCommand(sqlstr, Conn.sqlConn);
                cmd.Parameters.Add(new SqlParameter("@id",lab1.Text ));
                cmd.Parameters.Add(new SqlParameter("@name",textBox2.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@password", textBox3.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@gender", comboBox1.SelectedText));
                cmd.Parameters.Add(new SqlParameter("@department", comboBox2.SelectedText));
                cmd.Parameters.Add(new SqlParameter("@role", comboBox3.SelectedText));

                int res = cmd.ExecuteNonQuery();

                if (res != 0)
                {
                    MessageBox.Show("注册成功");
                }
                else
                {
                    MessageBox.Show("注册失败");
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

        private void button2_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Close();
        }
    }
}
