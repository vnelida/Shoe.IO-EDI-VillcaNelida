using Shoes.Entidades;
using Shoes.Servicios.Interface;
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
	public partial class frmEditarStock : Form
	{
		private readonly IShoesService servicio;
		private int shoeId;
		private int sizeId;
		private int currentStock;
		public frmEditarStock(int shoeId, int sizeId, IShoesService servicio)
		{
			InitializeComponent();
			this.shoeId = shoeId;
			this.sizeId = sizeId;
			this.servicio = servicio;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			var shoeSize = servicio.GetShoeSize(shoeId, sizeId);
			if (shoeSize != null)
			{
				stockUpDown.Value = shoeSize.QuantityInStock; 
			}

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			int cantidad = (int)stockUpDown.Value;

			var shoeSize = servicio.GetShoeSize(shoeId, sizeId);

			if (shoeSize != null)
			{
				shoeSize.QuantityInStock = cantidad;

				servicio.EditarSs(shoeSize.ShoeSizeId, shoeSize.QuantityInStock);

				MessageBox.Show("Stock actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

				DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("No se encontró el registro de talla para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	

		private void frmEditarStock_Load(object sender, EventArgs e)
		{
		}

		
	}
}
