using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net
{
    class SQLHelper
    {
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter paramerter in parameters)
                    {
                        cmd.Parameters.Add(paramerter);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter paramerter in parameters)
                    {
                        cmd.Parameters.Add(paramerter);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        // SqlDataReader是连接相关的，相当于数据库的游标，智能读取当前游标指向的行，并非返回结果。
        // 当连接关闭的时候，ExecuteReader就不能读取了。优点是，对程序占用内存几乎没影响。
        // 因此，以下代码是错误的：应该使用DataSet
        
        /*public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] parameters)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    foreach (SqlParameter paramerter in parameters)
                    {
                        cmd.Parameters.Add(paramerter);
                    }
                    return cmd.ExecuteReader();
                }
            }
        }*/


    }
}
