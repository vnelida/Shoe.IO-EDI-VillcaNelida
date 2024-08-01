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
using Size = Shoes.Entidades.Size;

namespace Shoes.Windows.Formularios
{
	public partial class frmSizeAE : Form
	{
		private Size? size;

		public frmSizeAE()
		{
			InitializeComponent();
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (size != null)
			{
				txtSize.Text = size.SizeNumber.ToString();
			}
		}

		public Size? GetTipo()
		{
			return size;
		}

		public void SetTipo(Size size)
		{
			this.size = size;
		}

		private bool ValidarDatos()
		{
			bool valido = true;
			errorProvider1.Clear();
			if (string.IsNullOrEmpty(txtSize.Text))
			{
				valido = false;
				errorProvider1.SetError(txtSize, "DEBE INGRESAR UN TALLE VALIDO");
			}
			if (!decimal.TryParse(txtSize.Text, out decimal sizeNumber))
			{
				errorProvider1.SetError(txtSize, "DEBE INGRESAR UN TALLE VALIDO");
				valido = false;
			}
			return valido;
		}


		private void frmSizeAE_Load(object sender, EventArgs e)
		{

		}

		private void btnOk_Click_1(object sender, EventArgs e)
		{
			if (ValidarDatos())
			{
				if (size == null)
				{
					size = new Size();

				}
				size.SizeNumber = decimal.Parse( txtSize.Text);

				DialogResult = DialogResult.OK;

			}
		}

		private void btnCancel_Click_1(object sender, EventArgs e)
		{
			Close();
		}
	}
}
