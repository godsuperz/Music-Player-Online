using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// DBHelper 的摘要说明
/// </summary>
public class DBHelper
{
    SqlConnection conn = null; // 连接对象
    string connString = ConfigurationManager.AppSettings["MusicConnectionString"];// 连接字符串

    public SqlConnection GetConnection()
    {
        conn = new SqlConnection(connString);
        return conn;
    }

}