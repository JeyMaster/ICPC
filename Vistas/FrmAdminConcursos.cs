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
    public partial class FrmAdminConcursos : Form
    {
        public FrmAdminConcursos()
        {
            InitializeComponent();
        }
        DaoConcurso objDaoConcuro = new DaoConcurso();
        private void FrmAdminConcursos_Load(object sender, EventArgs e)
        {
           
            List<Concurso> ltsConcursos = objDaoConcuro.SELECT_ALL();
            dgvConcursos.DataSource = ltsConcursos;



        }
        String rowclicked;
        String idConcursoXfila;
        private void dgvConcursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             rowclicked=dgvConcursos.CurrentCell.RowIndex.ToString();
            idConcursoXfila= dgvConcursos.Rows[Int32.Parse(rowclicked)].Cells[0].Value.ToString();
            MessageBox.Show(idConcursoXfila);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Concurso concursoAEditar = objDaoConcuro.SELECT(Int32.Parse(idConcursoXfila));
            new FrmAgregarEditarConcursos(concursoAEditar).ShowDialog();
        }
    }
}
