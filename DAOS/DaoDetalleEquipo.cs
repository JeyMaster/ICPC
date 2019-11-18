using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;

namespace DAOS
{
	class DaoDetalleEquipo
	{
		public int INSERT(DetalleEquipo objDetalleEquipo)
		{
			MySqlConnection conn = Connection.Conn();
			int done = 0;
			try
			{
				String cmdStr = "INSERT INTO DETALLE_EQUIPO VALUES(@idEquipo,@idMiembro,@rol)";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@idMiembrro", objDetalleEquipo.IdMimbro);
				cmd.Parameters.AddWithValue("@idEquipo", objDetalleEquipo.IdEquipo);
				cmd.Parameters.AddWithValue("@rol", objDetalleEquipo.Rol);

				cmd.ExecuteNonQuery();

				done = (int)cmd.LastInsertedId;

			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				done = 0;
			}

			return done;
		}
	}
}
