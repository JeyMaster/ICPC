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
    public partial class FrmAdminRegiones : Form
    {
        DaoRegion objDaoRegiones = new DaoRegion();
        public FrmAdminRegiones()
        {
            InitializeComponent();
			cargarTabla();

        }

		private void cargarTabla()
		{
			List<Modelo.Region> ltsregiones = new DaoRegion().SELECT();

			dgvRegiones.DataSource = null;
			dgvRegiones.DataSource = ltsregiones;
		}
        private void btnAgregar_Click(object sender, EventArgs e)
        {

			new FrmAgregarEditarRegiones(null).ShowDialog();
			cargarTabla();
        }
    }
}
