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
    public partial class QuerHeadForm : Form
    {
        public QuerHeadForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Conn.sqlConn.Open();
                string sqlstr = @"select t5.department, count(*) as dff from (
	                                select t4.*,t.name,t.department from(
		                                select * from(
			                                select t1.employee_id,t1.date,DATEDIFF(n,t1.time,t2.time) as diff
		                                from record t1
		                                inner join record t2 
		                                on t1.date = t2.date 
                                        and t1.employee_id=t2.employee_id 
                                        and t1.machine_id=1 
                                        and t2.machine_id=2
		                                and t1.date>=@start
		                                and t1.date<=@end
                                        ) t3 where t3.diff<540
	                                )t4,employee t where t4.employee_id=t.id
                                )t5 group by t5.department";
                SqlCommand cmd = new SqlCommand(sqlstr, Conn.sqlConn);
                cmd.Parameters.Add(new SqlParameter("@start", this.dateTimePicker1.Value.ToShortDateString()));
                cmd.Parameters.Add(new SqlParameter("@end", this.dateTimePicker2.Value.ToShortDateString()));
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 0)
            {
                string objectId = this.dataGridView1["department", e.RowIndex].Value.ToString();
                HeadDetails dh = new HeadDetails(objectId);
                dh.Show();
            }
            
        }

        private void QuerHeadForm_Load(object sender, EventArgs e)
        {

        }
    }
}
