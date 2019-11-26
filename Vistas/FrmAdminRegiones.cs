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

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Modelo.Region nreg = new Modelo.Region();
            nreg.Nombre = "Europa";
            int res = objDaoRegiones.INSERT(nreg);
            if (res == 1)
            { MessageBox.Show("datos insertados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
