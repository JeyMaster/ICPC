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
    public partial class FrmAgregarEditarSedes : Form
    {
        

        public FrmAgregarEditarSedes()
        {
            InitializeComponent();
            editar = false;
            btnGuardarCambios.Text = "Agregar";

        }

        public FrmAgregarEditarSedes(Sede sedeParaEditar)
        {
            InitializeComponent();
            editar = true;
            sedeAEditar = sedeParaEditar;
        }
        bool editar;
        Sede sedeAEditar;
        Sede sedeAAgregar = new Sede();
        DaoSede objDaoSede = new DaoSede();

        private void FrmAgregarEditarSedes_Load(object sender, EventArgs e)
        {

            if (editar)
            {
                this.Text = "Editar";
                txtIdSede.Text = sedeAEditar.IdSede.ToString();
                txtIdRegion.Text = sedeAEditar.IdRegion.ToString();
                txtNombre.Text = sedeAEditar.Nombre;
                
                txtIdSede.Enabled = false;
                txtIdRegion.Enabled = false;
            }
            else
            {
                this.Text = "Agregar";
                txtIdSede.Visible = false;
                lblIdSede.Visible = false;
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                 sedeAEditar.Nombre = txtNombre.Text;

                bool res = objDaoSede.UPDATE(sedeAEditar);
                if (res)
                {
                    MessageBox.Show("Sede Actualizada Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Al Actualizar La Sede", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
               
                sedeAAgregar.IdRegion = Int32.Parse(txtIdRegion.Text);
                sedeAAgregar.Nombre = txtNombre.Text;
                

                int res = objDaoSede.INSERT(sedeAAgregar);
                if (res != 0)
                {
                    MessageBox.Show("Sede Agregada Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Al Agregar La Sede ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
