﻿using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;

namespace DAOS
{
	public class DaoMiembro
	{

		/// <summary>
		/// Inserta un miembro a la base de datos
		/// </summary>
		/// <param name="objMiembro">El miembro a inserrtar</param>
		/// <returns>Retorna el valor de llave primaria que le pertenece</returns>
		public int INSERT(Miembro objMiembro)
		{
			int done = 0;
			MySqlConnection conn = Connection.Conn();

			try
			{
				String cmdStr = "INSERT INTO miembros(email,nombre,apellido,contrasena)" +
					" VALUES(@email,@nombre,@apellidos,sha2(@contrasena,512))";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@email",objMiembro.Email);
				cmd.Parameters.AddWithValue("@nombre",objMiembro.Nombre);
				cmd.Parameters.AddWithValue("@apellidos",objMiembro.Apellido);
				cmd.Parameters.AddWithValue("@contrasena",objMiembro.Contrasenia);
				cmd.ExecuteNonQuery();

				done = (int)cmd.LastInsertedId;

			}
			catch (MySqlException ex)
			{
				done = 0;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return done;
		}

		/// <summary>
		/// Consulta un miembro para permitir logearse
		/// </summary>
		/// <param name="objMiembro">El miembro a auntentificar</param>
		/// <returns>Un miembro</returns>
		public Miembro SELECT_TO_LOGIN(Miembro objMiembro)
		{

			MySqlConnection conn = Connection.Conn();
			
			try
			{
				String cmdStr = "SELECT nombre,apellido,email,idMiembro FROM miembros " +
					"WHERE email=@email and contrasena=sha2(@contrasena,512);";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@email",objMiembro.Email);
				cmd.Parameters.AddWithValue("@contrasena",objMiembro.Contrasenia);
				objMiembro = null;
				MySqlDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					objMiembro = new Miembro();
					objMiembro.Nombre = dr["nombre"].ToString();
					objMiembro.Apellido = dr["apellido"].ToString();
					objMiembro.Email = dr["email"].ToString();
					objMiembro.IdMiembro = int.Parse(dr["idMiembro"].ToString());
				}

			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				objMiembro=null;

			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
			return objMiembro;
		}

		/// <summary>
		/// Consulta a un miembro por medio de su llave primaria
		/// </summary>
		/// <param name="idMiembro">Llave primaria del miembro</param>
		/// <returns>Un miembro</returns>
		public Miembro SELECT(int idMiembro)
		{

			MySqlConnection conn = Connection.Conn();
			Miembro objMiembro = null;

			try
			{
				String cmdStr = "SELECT * FROM miembros WHERE idMiembro=@id";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@id",idMiembro);
				MySqlDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					objMiembro = new Miembro();
					objMiembro.IdMiembro = int.Parse(dr["idMiembro"].ToString());
					objMiembro.Rol = dr["rol"].ToString();
					objMiembro.Email = dr["email"].ToString();
					objMiembro.Contrasenia = dr["contrasena"].ToString();
					objMiembro.Titulo = dr["titulo"].ToString();
					objMiembro.Nombre = dr["nombre"].ToString();
					objMiembro.Apellido = dr["apellido"].ToString();
					objMiembro.NombreDistintivo = dr["nombreDistintivo"].ToString();
					objMiembro.NombreDeCertificado = dr["nombreDeCertificado"].ToString();
					objMiembro.Sexo = char.Parse(dr["sexo"].ToString());
					objMiembro.TallaDeCamisa = dr["tallaDeCamisa"].ToString();
					objMiembro.FechaDeNacimiento = dr.GetDateTime("fechaDeNacimiento");
					objMiembro.CiudadDeOrigen = dr["ciudadDeOrigen"].ToString();
					objMiembro.EstadoDeOrigen = dr["estadoDeOrigen"].ToString();
					objMiembro.PaisDeOrigen = dr["paisDeOrigen"].ToString();
					objMiembro.PaisDeResidencia = dr["paisDeResidencia"].ToString();
					objMiembro.Ocupacion = dr["ocupacion"].ToString();
					objMiembro.InstitutoEmpleoCompania = dr["institutoEmpleoCompania"].ToString();
					objMiembro.NecesidadesEspeciales = dr["necesidadesEspeciales"].ToString();
					objMiembro.EmailSecundario = dr["emailSecundario"].ToString();
					
				}

			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				objMiembro = null;

			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
			return objMiembro;
		}

		/// <summary>
		/// Actualiza los valores de un miembro en la base de datos
		/// </summary>
		/// <param name="objMiembro">Miewmbro a actualizar</param>
		/// <returns>Booleano</returns>
		public bool UPDATE(Miembro objMiembro)
		{
			bool done = false;
			MySqlConnection conn = Connection.Conn();

			try
			{
				String cmdStr = "UPDATE miembros SET rol = @rol,email = @email" +
					"contrasena = sha2(@contrasena,512), titulo = @titulo," +
					"nombre = @nombre, apellido = @apellido," +
					"nombreDistintivo = @nombreDis, nombreDeCertificado = @nombreCer," +
					"sexo = @sexo, tallaDeCamisa = @talla, fechaDeNacimiento = @fechaNac," +
					"ciudadDeOrigen = @ciudadOr, estadoDeOrigen = @estadoOr," +
					"paisDeOrigen = @paisOr, paisDeResidencia = @paisRe," +
					"ocupacion = @ocupacion, institutoEmpleoCompania = @insEmpComp," +
					"necesidadesEspeciales = @necesidadesEs, emailSecundario = @emailSec" +
					" WHERE (idMiembro = @id)";

				MySqlCommand cmd = new MySqlCommand(cmdStr,conn);

				cmd.Parameters.AddWithValue("@id",objMiembro.IdMiembro);
				cmd.Parameters.AddWithValue("@rol",objMiembro.Rol);
				cmd.Parameters.AddWithValue("@email",objMiembro.Email);
				cmd.Parameters.AddWithValue("@contrasena",objMiembro.Contrasenia);
				cmd.Parameters.AddWithValue("@titulo",objMiembro.Titulo);
				cmd.Parameters.AddWithValue("@nombre",objMiembro.Nombre);
				cmd.Parameters.AddWithValue("@apellido",objMiembro.Apellido);
				cmd.Parameters.AddWithValue("@nombreDis",objMiembro.NombreDistintivo);
				cmd.Parameters.AddWithValue("@nombreCer",objMiembro.NombreDeCertificado);
				cmd.Parameters.AddWithValue("@sexo",objMiembro.Sexo);
				cmd.Parameters.AddWithValue("@talla",objMiembro.TallaDeCamisa);
				cmd.Parameters.AddWithValue("@fechaNac",objMiembro.FechaDeNacimiento);
				cmd.Parameters.AddWithValue("@ciudadOr",objMiembro.CiudadDeOrigen);
				cmd.Parameters.AddWithValue("@estadoOr",objMiembro.EstadoDeOrigen);
				cmd.Parameters.AddWithValue("@paisOr",objMiembro.PaisDeOrigen);
				cmd.Parameters.AddWithValue("@paisRe",objMiembro.PaisDeResidencia);
				cmd.Parameters.AddWithValue("@ocupacion",objMiembro.Ocupacion);
				cmd.Parameters.AddWithValue("@insEmpCom",objMiembro.InstitutoEmpleoCompania);
				cmd.Parameters.AddWithValue("@nesecidadesEs",objMiembro.NecesidadesEspeciales);
				cmd.Parameters.AddWithValue("@emailSec",objMiembro.EmailSecundario);

				cmd.ExecuteNonQuery();

				done = true;
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				done = false;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return done;
		}
	}
}