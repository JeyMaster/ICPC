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
    public partial class FrmAdminInstituciones : Form
    {
        public FrmAdminInstituciones()
        {
            InitializeComponent();
        }
        DaoInstitucion objDaoInstitucion = new DaoInstitucion();
        private void FrmAdminInstituciones_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
        public void CargarTabla()
        {
            List<Institucion> ltsConcursos = objDaoInstitucion.SELECT();
            dgvInstituciones.DataSource = ltsConcursos;
        }
        String rowclicked;
        String idInstitucionXfila;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FrmAgregarEditarInstituciones().ShowDialog();
            CargarTabla();
        }
    

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Institucion InstitucionAEditar = objDaoInstitucion. SELECT(Int32.Parse(idInstitucionXfila));
            new FrmAgregarEditarInstituciones(InstitucionAEditar).ShowDialog();
            CargarTabla();
        }

        private void dgvInstituciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowclicked = dgvInstituciones.CurrentCell.RowIndex.ToString();
            idInstitucionXfila = dgvInstituciones.Rows[Int32.Parse(rowclicked)].Cells[0].Value.ToString();
        }
    }
}
