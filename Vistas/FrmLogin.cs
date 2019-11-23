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
using System.Text.RegularExpressions;

namespace Vistas
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
            InitializeComponent();
		}
		private Regex automata;
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
			if (Validaciones(Strings.validarCorreo, txtEmail, "Email incorrecto")
				&Validaciones(Strings.alfaNumerico,txtContrasena,"Solo valores alfanumericos"))
			{
				MessageBox.Show("Listo");

			}
            String hi = "hi";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            new FrmRegistro().ShowDialog();
        }

      

		private void txtEmail_KeyUp(object sender, KeyEventArgs e)
		{
			
		}

		private bool Validaciones(String validacion,TextBox txtComponent,String msg)
		{
			bool done = false;
			automata = new Regex(validacion);
			if (!automata.IsMatch(txtComponent.Text))
			{
				errPrvLogin.SetError(txtComponent, msg);
				done = false;
			}
			else
			{
				errPrvLogin.SetError(txtComponent, "");
				done = true;
			}

			return done;
		}
	}
}
