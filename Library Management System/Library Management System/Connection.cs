using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public static class Connection
    {
        public static SqlConnection con;
        public static SqlConnection GetCon()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=NOMIR-PC\SQLEXPRESS;Initial Catalog=DBMS_Project;Integrated Security=True";
            con.Open();
            return con;
        }

    }
}
