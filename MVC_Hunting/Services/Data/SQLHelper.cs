using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MVC_Hunting.Services.Data
{
    public class SQLHelper
    {
        static String StrConnection = String.Empty;

        public static String ConnectionString()
        {
            StrConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MVCHunting;Persist Security Info=True;User ID=sa;Password=pass1234";

            return StrConnection;
        }
        public static SqlCommand CreateCommand(string sql, CommandType type, List<SqlParameter> param)
        {
            ConnectionString();
            SqlConnection con = new SqlConnection(StrConnection);
            //con.ConnectionString = strConnection;
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = type;
            cmd.Connection = con;
            if (param.Count > 0)
            {
                foreach (SqlParameter p in param)
                {
                    if (p != null)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
            }

            return cmd;
        }
        public static SqlCommand CreateCommand(string sql, CommandType type)
        {
            ConnectionString();
            SqlConnection con = new SqlConnection(StrConnection);
            //con.ConnectionString = "";

            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = type;
            cmd.CommandText = sql;
            cmd.Connection = con;
            return cmd;
        }
        public static SqlDataReader ExcequteReader(String sqlQuerry, CommandType commandType)
        {
            SqlDataReader dataReader;
            SqlCommand cmd = new SqlCommand();
            cmd = CreateCommand(sqlQuerry, commandType);
            cmd.Connection.Open();
            dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dataReader;
        }
        public static void ExecuteNonQuery(string sql, CommandType type)
        {

            SqlCommand cmd = new SqlCommand();
            cmd = CreateCommand(sql, type);
            cmd.CommandType = type;
            cmd.CommandText = sql;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}