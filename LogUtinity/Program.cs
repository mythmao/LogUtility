using Common;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogUtinity
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ConnStr = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
            LogHelper loghelper = new LogHelper(true);
            loghelper.WriteLog("Hello,World!");
            #region MySqlTest
            //using (MySqlConnection conn = new MySqlConnection(ConnStr))
            //{
            //    conn.Open();
            //    string sql = "INSERT INTO Log (Date,Thread,Level,Logger,Message,Exception) VALUES (@log_date, @thread, @log_level, @logger, @message, @exception)";
            //    MySqlCommand cmd = conn.CreateCommand();
            //    cmd.CommandText = sql;
            //    {
            //        MySqlParameter para = new MySqlParameter("log_date", MySqlDbType.DateTime);
            //        para.Value = DateTime.Now;
            //        cmd.Parameters.Add(para);
            //    }
            //    {
            //        MySqlParameter para = new MySqlParameter("thread", MySqlDbType.String);
            //        para.Value = "test";
            //        cmd.Parameters.Add(para);
            //    }
            //    {
            //        MySqlParameter para = new MySqlParameter("log_level", MySqlDbType.String);
            //        para.Value = "info";
            //        cmd.Parameters.Add(para);
            //    }
            //    {
            //        MySqlParameter para = new MySqlParameter("logger", MySqlDbType.String);
            //        para.Value = "test";
            //        cmd.Parameters.Add(para);
            //    }
            //    {
            //        MySqlParameter para = new MySqlParameter("message", MySqlDbType.String);
            //        para.Value = "test";
            //        cmd.Parameters.Add(para);
            //    }
            //    {
            //        MySqlParameter para = new MySqlParameter("exception", MySqlDbType.String);
            //        para.Value = "";
            //        cmd.Parameters.Add(para);
            //    }
            //    int count = cmd.ExecuteNonQuery();
            //    Console.WriteLine(count);
            //    //object obj = cmd.ExecuteScalar();
            //    //Console.WriteLine(Convert.ToInt32(obj));
            //} 
            #endregion
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
