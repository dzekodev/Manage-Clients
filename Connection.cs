using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Tp_9
{
    public class Connection
    {
        public static string cs = ConfigurationManager.ConnectionStrings["Tp_8_CS"].ConnectionString;
        public static SqlConnection cn = new SqlConnection(cs);
        public static SqlCommand cmd = cn.CreateCommand();
        public static SqlDataReader dr;
    }
}