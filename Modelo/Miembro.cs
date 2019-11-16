using System;

namespace Modelo
{
	public class Miembro
	{
		public int IdMiembro { get; set; }
		public String Rol { get; set; }
		public String Email { get; set; }
		public String Contrasenia { get; set; }
		public String Titulo { get; set; }
		public String Nombre { get; set; }
		public String Apellido { get; set; }
		public String NombreDistintivo { get; set; }
		public String NombreDeCertificado { get; set; }
		public char Sexo { get; set; }
		public String TallaDeCamisa { get; set; }
		public DateTime FechaDeNacimiento { get; set; }
		public String CiudadDeOrigen { get; set; }
		public String EstadoDeOrigen { get; set; }
		public String PaisDeOrigen { get; set; }
		public String PaisDeResidencia { get; set; }
		public String Ocupacion { get; set; }
		public String InstitutoEmpleoCompania { get; set; }
		public String NecesidadesEspeciales { get; set; }
		public String EmailSecundario { get; set; }

	}
}
