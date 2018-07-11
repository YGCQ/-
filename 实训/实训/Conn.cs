using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实训
{
    class Conn
    {

        static string connStr = ConfigurationManager.ConnectionStrings["Attendance"].ConnectionString;
       public  static SqlConnection sqlConn = new SqlConnection(connStr);
      
    }
}
