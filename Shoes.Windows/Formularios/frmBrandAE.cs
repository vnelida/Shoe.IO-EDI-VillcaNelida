using Microsoft.Extensions.Options;
using Shoes.Entidades;
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
	public partial class frmBrandAE : Form
	{
		private Brand? brand;
		public frmBrandAE()
		{
			InitializeComponent();
		}

		public void SetTipo(Brand brand)
		{
			this.brand = brand;
		}
		public Brand GetTipo()
		{
			return brand;
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (brand != null)
			{
				txtBrand.Text = brand.BrandName;
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (ValidarDatos())
			{
				if (brand == null)
				{
					brand = new Brand();
				}
				brand.BrandName = txtBrand.Text;
				DialogResult = DialogResult.OK;
			}
		}

		private bool ValidarDatos()
		{
			bool valido = true;
			errorProvider1.Clear();
			if (string.IsNullOrEmpty(txtBrand.Text))
			{
				valido = false;
				errorProvider1.SetError(txtBrand, "Ingrese un registro valido");
			}
			return valido;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmBrandAE_Load(object sender, EventArgs e)
		{

		}
	}
}
