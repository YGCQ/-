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
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.sqlConn.Open();
                string sqlstr = "select serial,date, time, machine_id from [dbo].[record] where date between @date1 and @date2 and employee_id = @id";
                SqlCommand cmd = new SqlCommand(sqlstr, Conn.sqlConn);
                string str1 = this.dateTimePicker1.Value.Year.ToString() + "-" + this.dateTimePicker1.Value.Month.ToString() + "-" + this.dateTimePicker1.Value.Day.ToString();
                string str2 = this.dateTimePicker2.Value.Year.ToString() + "-" + this.dateTimePicker2.Value.Month.ToString() + "-" + this.dateTimePicker2.Value.Day.ToString();
                cmd.Parameters.Add(new SqlParameter("@date1", str1));
                cmd.Parameters.Add(new SqlParameter("@date2", str2));
                cmd.Parameters.Add(new SqlParameter("@id", UserInfo.ID));
                // 将该查询过程绑定到DataAdapter
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;

                // 将DataSet和DataAdapter绑定
                DataSet ds = new DataSet();
                // 自定义一个表(MyGoods)来标识数据库的GOODS表
                adp.Fill(ds, "record1");

                // 指定DataGridView的数据源为DataSet的MyGoods表
                this.dataGridView1.DataSource = ds.Tables["record1"];
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

        private void QueryForm_Load(object sender, EventArgs e)
        {
            this.splitContainer1.IsSplitterFixed = false;
            this.splitContainer1.FixedPanel = FixedPanel.Panel1;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
