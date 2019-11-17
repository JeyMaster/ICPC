using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;

namespace DAOS
{
	public class DaoInstitucion
	{
		public int INSERT(Institucion objInstitucion)
		{
			MySqlConnection conn = Connection.Conn();
			int done = 0;
			try
			{
				String cmdStr = "";
				MySqlCommand cmd = new MySqlCommand(cmdStr,conn);
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				done = 0;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
			return done;
		}

		public void SELECT()
		{
			MySqlConnection conn = Connection.Conn();

			try
			{
				String cmdStr = "";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
		}

		public void SELECT(int idInstitucion)
		{
			MySqlConnection conn = Connection.Conn();

			try
			{
				String cmdStr = "";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
		}

		public void UPDATE(Institucion objInstitucion)
		{
			MySqlConnection conn = Connection.Conn();

			try
			{
				String cmdStr = "";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
		}
	}
}
