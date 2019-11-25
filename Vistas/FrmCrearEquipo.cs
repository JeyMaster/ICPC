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
    public partial class FrmCrearEquipo : Form
    {
        public FrmCrearEquipo()
        {
            InitializeComponent();
        }

		private List<Modelo.Region> ltsRegiones;
		private List<Sede> ltsSedes;
		private List<Concurso> ltsConcursos;

		private void FrmCrearEquipo_Load(object sender, EventArgs e)
		{
			cargarRegiones();
			cargarInstituciones();
		}

		private void cargarInstituciones()
		{
			List<Institucion> ltsInstituciones = new DaoInstitucion().SELECT();

			foreach (Institucion institucion in ltsInstituciones)
			{
				cbInstituciones.Items.Add(institucion);
			}
		}

		private void cargarRegiones()
		{
			ltsRegiones = new DaoRegion().SELECT();

			foreach (Modelo.Region region in ltsRegiones)
			{
				cbRegiones.Items.Add(region);
			}
		}

		private void cbSedes_SelectedIndexChanged(object sender, EventArgs e)
		{
			Sede objSede = (Sede)cbSedes.SelectedItem;
			ltsConcursos = new DaoConcurso().SELECT_FOR_SEDE(objSede.IdSede);
			cbConcursos.Items.Clear();

			if (ltsConcursos!=null)
			{
				foreach (Concurso concurso in ltsConcursos)
				{
					cbConcursos.Items.Add(concurso);
				}

			}
			
		}

		private void cbRegiones_SelectedIndexChanged(object sender, EventArgs e)
		{

			Modelo.Region objRegion = (Modelo.Region)cbRegiones.SelectedItem;
			ltsSedes = new DaoSede().SELECT_FOR_REGION(objRegion.IdRegion);
			cbSedes.Items.Clear();
			cbConcursos.Items.Clear();
			if (ltsSedes != null)
			{
				foreach (Sede sede in ltsSedes)
				{
					cbSedes.Items.Add(sede);
				}
			}
		}
	}
}
