using Microsoft.Extensions.DependencyInjection;
using Shoes.Entidades;
using Shoes.Entidades.Dto;
using Shoes.Servicios.Interface;
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
using Size = Shoes.Entidades.Size;

namespace Shoes.Windows.Formularios
{
	public partial class frmDetalleTalles : Form
	{
		private List<ShoeSize>? shoeSizes;
		private int shoeId;
		private readonly IShoesService servicio;
		public frmDetalleTalles(int shoeId, IShoesService servicio)
		{
			InitializeComponent();
			this.shoeId = shoeId;
			this.servicio = servicio;
		}

		public void SetDatos(List<ShoeSize> shoeSizes)
		{
			this.shoeSizes = shoeSizes;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (shoeSizes != null)
			{
				GridHelper.MostrarDatosEnGrilla(shoeSizes, dgvDatos);
			}
		}
		private void frmDetalleTalles_Load(object sender, EventArgs e)
		{

		}

		private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}


		private void ModificarStock_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				MessageBox.Show("Debe seleccionar un talle para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var r = dgvDatos.SelectedRows[0];
			if (r.Tag is null) return;
			var shoeSize = (ShoeSize)r.Tag;

			frmEditarStock frm = new frmEditarStock(shoeSize.ShoeId, shoeSize.SizeId, servicio);
			frm.ShowDialog();

			GridHelper.MostrarDatosEnGrilla(shoeSizes, dgvDatos);
		}

		private void tsbQuitarStock_Click(object sender, EventArgs e)
		{
		//	if (dgvDatos.SelectedRows.Count == 0)
		//	{
		//		MessageBox.Show("Debe seleccionar un talle para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		//		return;
			}

		//	var r = dgvDatos.SelectedRows[0];
		//	if (r.Tag is null) return;
		//	var shoeSize = (ShoeSize)r.Tag;

		//	frmEditarStock frm = new frmEditarStock(shoeSize.ShoeId, shoeSize.SizeId, servicio);
		//	frm.ShowDialog();

		//	GridHelper.MostrarDatosEnGrilla(shoeSizes, dgvDatos);
		//}

		private void tsbAgregarStock_Click(object sender, EventArgs e)
		{
			//if (dgvDatos.SelectedRows.Count == 0)
			//{
			//	MessageBox.Show("Debe seleccionar un talle para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//	return;
			//}

			//var r = dgvDatos.SelectedRows[0];
			//if (r.Tag is null) return;
			//var shoeSize = (ShoeSize)r.Tag;

			//EditarStock1 frm = new EditarStock1(shoeSize.ShoeId, shoeSize.SizeId, servicio);
			
			//DialogResult dr=frm.ShowDialog();
			//if (dr==DialogResult.OK)
			//{
			//	int stock = frm.GetStock();
			//	servicio.EditarSs(shoeSize.ShoeSizeId, stock);
			//	GridHelper.MostrarDatosEnGrilla(shoeSizes, dgvDatos);
			//	MessageBox.Show("Registro agregado exitosamente");
			//}
				
			
			//else
			//{
			//	MessageBox.Show("Registro duplicado.");
			//}
						
		}
	}
}
