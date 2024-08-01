using Shoes.Entidades;
using Shoes.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.Windows.Formularios
{
	public partial class frmMostrarShoes : Form
	{
		private List<Shoe>? lista;
		public frmMostrarShoes()
		{
			InitializeComponent();
		}

		public void SetLista(List<Shoe>? shoesLista)
		{
			lista = shoesLista;
		}

		private void MostrarDatosEnLista()
		{
			GridHelper.LimpiarGrilla(dgvDatos);
			foreach (var item in lista)
			{
				var r = GridHelper.ConstruirFila(dgvDatos);
				GridHelper.SetearFila(r, item);
				GridHelper.AgregarFila(r, dgvDatos);
			}
		}
		private void frmMostrarShoes_Load(object sender, EventArgs e)
		{
			if (lista != null)
			{
				MostrarDatosEnLista();
			}
		}

		
	}
}
