using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAOS;
using Modelo;

namespace Vistas
{
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();
			Sede sede = new Sede();
			sede.Nombre = "ITSUR BAJIO";
			sede.IdRegion = 1;
			sede.IdSede = 1;
			new DaoSede().UPDATE(sede) ;
		}
	}
}
