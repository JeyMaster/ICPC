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

		private int index;

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

		private void btnEditar_Click(object sender, EventArgs e)
		{
			Modelo.Region objRegion = new Modelo.Region();

			objRegion.Nombre = dgvRegiones[1,index].Value.ToString();
			objRegion.IdRegion = (int) dgvRegiones[0, index].Value;

			new FrmAgregarEditarRegiones(objRegion).ShowDialog();
		}

		private void dgvRegiones_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			index = dgvRegiones.CurrentRow.Index;
		}
	}
}
