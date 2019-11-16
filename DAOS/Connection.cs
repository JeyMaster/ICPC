using System;
using MySql.Data.MySqlClient;

namespace DAOS
{
	public class Connection
	{
		public static MySqlConnection Conn()
		{
			MySqlConnection conn;

			try
			{
				String connString = "server=127.0.0.1;uid=root;pwd=root;database=RegICPC";
				conn = new MySqlConnection(connString);
				conn.Open();
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				conn = null;
			}

			return conn;
		}
	}
}
