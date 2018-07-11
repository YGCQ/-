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
    public partial class RegiCheck : Form
    {
        public RegiCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                Conn.sqlConn.Open();
                string sqlstr = null;
               if (Regex.IsMatch(textBox1.Text.Trim(), "^\\d+$"))
                {
                     sqlstr = @"select t3.employee_id, t4.department, t4.name, t3.date, t3.time,t3.tim,t3.diff  from (
                                    select t1.employee_id, t1.date,t1.time,t2.time as tim,datediff(n, t1.time, t2.time) as diff
                                    from record t1
                                    inner
                                    join record t2
                              on t1.date = t2.date
                              and t1.employee_id = t2.employee_id
                                    and t1.machine_id = 1
                                    and t2.machine_id = 2
                                    and t1.date>=@start
		                            and t1.date<=@end
                                    ) t3, employee t4
                                    where t3.employee_id = t4.id
                                    and t3.employee_id=@id";
                }
                else if (Regex.IsMatch(textBox1.Text.Trim(), "^[\u4E00-\u9FA5]{0,}$"))
                {
                     sqlstr = @"select t3.employee_id, t4.department, t4.name, t3.date, t3.time,t3.tim,t3.diff  from (
                                    select t1.employee_id, t1.date,t1.time,t2.time as tim,datediff(n, t1.time, t2.time) as diff
                                    from record t1
                                    inner
                                    join record t2
                              on t1.date = t2.date
                              and t1.employee_id = t2.employee_id
                                    and t1.machine_id = 1
                                    and t2.machine_id = 2
                                    and t1.date>=@start
		                            and t1.date<=@end
                                    ) t3, employee t4
                                    where t3.employee_id = t4.id
                                    and t4.name=@id";
                }
                SqlCommand cmd = new SqlCommand(sqlstr, Conn.sqlConn);
                cmd.Parameters.Add(new SqlParameter("@start", this.dateTimePicker3.Value.ToShortDateString()));
                cmd.Parameters.Add(new SqlParameter("@end", this.dateTimePicker2.Value.ToShortDateString()));
                cmd.Parameters.Add(new SqlParameter("@id", textBox1.Text.Trim()));
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

        private void RegiCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
