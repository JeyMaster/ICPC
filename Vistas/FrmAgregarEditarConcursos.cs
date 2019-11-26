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
    public partial class FrmAgregarEditarConcursos : Form
    {
        public FrmAgregarEditarConcursos(Modelo.Concurso concursoParaEditar)
        {
            InitializeComponent();
            editar = true;
            ConcuroAEditar = concursoParaEditar;
            
        }
        public FrmAgregarEditarConcursos()
        {
            InitializeComponent();
            editar = false;
            btnGuardarCambios.Text = "Agregar";
            
        }
        bool editar;
        Concurso ConcuroAEditar;
        Concurso ConcuroAAgregar=new Concurso();
        DaoConcurso objDaoConcurso=new DaoConcurso();


        private void FrmAgregarEditarConcursos_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                this.Text = "Editar";
                txtIdConcurso.Text = ConcuroAEditar.IdConcurso.ToString();
                txtIdSede.Text = ConcuroAEditar.IdSede.ToString();
                txtTitulo.Text = ConcuroAEditar.Titulo;
                txtNombre.Text = ConcuroAEditar.Nombre;
                txtEmail.Text = ConcuroAEditar.Email;
                txtLocacion.Text = ConcuroAEditar.Locacion;
                txtInfoFacturacion.Text = ConcuroAEditar.InfoFacturacion;
                txtIdConcurso.Enabled = false;
                txtIdSede.Enabled = false;
            }
            else {
                this.Text = "Agregar";
                txtIdConcurso.Visible = false;
                label1.Visible = false;
            }
            

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                ConcuroAEditar.Titulo = txtTitulo.Text;
                ConcuroAEditar.Nombre = txtNombre.Text;
                ConcuroAEditar.Email = txtEmail.Text;
                ConcuroAEditar.Locacion = txtLocacion.Text;
                ConcuroAEditar.InfoFacturacion = txtInfoFacturacion.Text;

                bool res = objDaoConcurso.UPDATE(ConcuroAEditar);
                if (res)
                {
                    MessageBox.Show("Concurso Actualizado Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Al Actualizar El Concurso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                //ConcuroAEditar.IdConcurso = Int32.Parse(txtIdConcurso.Text);
                ConcuroAAgregar.IdSede = Int32.Parse(txtIdSede.Text);
                ConcuroAAgregar.Titulo = txtTitulo.Text;
                ConcuroAAgregar.Nombre = txtNombre.Text;
                ConcuroAAgregar.Email = txtEmail.Text;
                ConcuroAAgregar.Locacion = txtLocacion.Text;
                ConcuroAAgregar.InfoFacturacion = txtInfoFacturacion.Text;

                int res = objDaoConcurso.INSERT(ConcuroAAgregar);
                if (res!=0)
                {
                    MessageBox.Show("Concurso Agregado Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Al Agregar El Concurso ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
