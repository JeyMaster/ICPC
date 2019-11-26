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
    public partial class FrmAgregarEditarInstituciones : Form
    {

        public FrmAgregarEditarInstituciones()
        {
            InitializeComponent();
            editar = false;
            btnGuardarCambios.Text = "Agregar";
        }

        public FrmAgregarEditarInstituciones(Institucion InstitucionParaEditar)
        {
            InitializeComponent();
            editar = true;
            institucionAEditar = InstitucionParaEditar;
        }

        bool editar;
        Institucion institucionAEditar=new Institucion();
        Institucion InstitucionAAgregar = new Institucion();
        DaoInstitucion objDaoInstitucion = new DaoInstitucion();
        private void FrmAgregarEditarInstituciones_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                this.Text = "Editar";
                txtIdInstitucion.Text = institucionAEditar.IdInstitucion.ToString();
                txtIdRegion.Text = institucionAEditar.IdRegion.ToString();
                txtNombreCompleto.Text =institucionAEditar.NombreCompleto;
                txtNombreCorto.Text = institucionAEditar.NombreCorto;
                txtPaginaWeb.Text = institucionAEditar.PaginaWeb;
                txtGradoOfrecido.Text = institucionAEditar.GradoOfrecido;
                txtCompañiaCalle.Text= institucionAEditar.CompaniaCalle;
                txtState.Text = institucionAEditar.State;
                txtCiudad.Text = institucionAEditar.Ciudad;
                txtCodigoPostal.Text = institucionAEditar.CodigoPostal;
                txtLineaDeCalle2.Text = institucionAEditar.LineaDeCalle_2;
                txtLineaDeCalle3.Text = institucionAEditar.LineaDeCalle_3;
                txtEstado.Text = institucionAEditar.Estado;

                txtIdInstitucion.Enabled = false;
                
            }
            else
            {
                this.Text = "Agregar";
                txtIdInstitucion.Visible = false;
                label1.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void txtGuardarCambios_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                institucionAEditar.IdRegion = Int32.Parse(txtIdRegion.Text);
                institucionAEditar.NombreCompleto = txtNombreCompleto.Text;
                institucionAEditar.NombreCorto = txtNombreCorto.Text;
                institucionAEditar.PaginaWeb = txtPaginaWeb.Text;
                institucionAEditar.GradoOfrecido = txtGradoOfrecido.Text;
                institucionAEditar.CompaniaCalle = txtCompañiaCalle.Text;
                institucionAEditar.State = txtState.Text;
                institucionAEditar.Ciudad = txtCiudad.Text;
                institucionAEditar.CodigoPostal = txtCodigoPostal.Text;
                institucionAEditar.LineaDeCalle_2 = txtLineaDeCalle2.Text;
                institucionAEditar.LineaDeCalle_3 = txtLineaDeCalle3.Text;
                institucionAEditar.Estado = txtEstado.Text;

                bool res = objDaoInstitucion.UPDATE(institucionAEditar);
                if (res)
                {
                    MessageBox.Show("Institucion Actualizada Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Al Actualizar La Institucion", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                InstitucionAAgregar.IdRegion = Int32.Parse( txtIdRegion.Text);
                InstitucionAAgregar.NombreCompleto = txtNombreCompleto.Text;
                InstitucionAAgregar.NombreCorto = txtNombreCorto.Text;
                InstitucionAAgregar.PaginaWeb = txtPaginaWeb.Text;
                InstitucionAAgregar.GradoOfrecido = txtGradoOfrecido.Text;
                InstitucionAAgregar.CompaniaCalle = txtCompañiaCalle.Text;
                InstitucionAAgregar.State = txtState.Text;
                InstitucionAAgregar.Ciudad = txtCiudad.Text;
                InstitucionAAgregar.CodigoPostal = txtCodigoPostal.Text;
                InstitucionAAgregar.LineaDeCalle_2 = txtLineaDeCalle2.Text;
                InstitucionAAgregar.LineaDeCalle_3 = txtLineaDeCalle3.Text;
                InstitucionAAgregar.Estado = txtEstado.Text;

                int res = objDaoInstitucion.INSERT(InstitucionAAgregar);
                if (res != 0)
                {
                    MessageBox.Show("Institucion Agregada Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Al Agregar La Institucion ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
