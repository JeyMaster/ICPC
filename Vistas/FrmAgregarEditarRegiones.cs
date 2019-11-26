using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using DAOS;

namespace Vistas
{
    public partial class FrmAgregarEditarRegiones : Form
    {
        public FrmAgregarEditarRegiones(Modelo.Region region)
        {
            InitializeComponent();
			this.region = region;
        }

		private Modelo.Region region;

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (region==null)
			{
				Modelo.Region reg = new Modelo.Region();
				reg.Nombre = txtNombre.Text;
				new DaoRegion().INSERT(reg);
				this.Close();
			}
		}
	}
}
