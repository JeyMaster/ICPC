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
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
            InitializeComponent();
		}

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            new FrmTableroMiembro().ShowDialog();
            

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            new FrmRegistro().ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new FrmTableroAdministrador().ShowDialog();
        }
    }
}
