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
    public partial class HeadDetails : Form
    {
        private string goodsId = null;
        
        public HeadDetails(string id)
        {
            this.goodsId = id;
            InitializeComponent();
        }

        private void HeadDetails_Load(object sender, EventArgs e)
        {
            try
            {
                Conn.sqlConn.Open();
                string sqlstr = @"select t4.department, t4.name, t3.date, t3.time,t3.tim,t3.diff  from (
		                            select t1.employee_id, t1.date,t1.time,t2.time as tim,datediff(n,t1.time,t2.time) as diff 
		                            from record t1
		                            inner join record t2 
		                            on t1.date = t2.date 
                                    and t1.employee_id=t2.employee_id 
                                    and t1.machine_id=1 
                                    and t2.machine_id=2

                                    ) t3, employee t4 
                                    where t3.employee_id = t4.id and t3.diff<540 and t4.department=@department";
                SqlCommand cmd = new SqlCommand(sqlstr, Conn.sqlConn);
                cmd.Parameters.Add(new SqlParameter("@department", goodsId));
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

        }
    }
}
