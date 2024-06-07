using Microsoft.Extensions.DependencyInjection;
using Shoes.Entidades;
using Shoes.Servicios.Interface;
using Shoes.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = Shoes.Entidades.Color;

namespace Shoes.Windows.Formularios
{
	public partial class frmShoesAE : Form
	{
		private IServiceProvider serviceProvider;

		private Shoe? shoe;
		private Brand? brand;
		private Genre? genre;
		private Sport? sport;
		private Color? color;
		public frmShoesAE(IServiceProvider _serviceProvider)
		{
			InitializeComponent();
			serviceProvider = _serviceProvider;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CombosHelper.CargarComboBrands(serviceProvider, ref cboBrands);
			CombosHelper.CargarComboColors(serviceProvider, ref cboColors);
			CombosHelper.CargarComboGenre(serviceProvider, ref cboGenres);
			CombosHelper.CargarComboSport(serviceProvider, ref cboSports);
			if (shoe != null)
			{
				txtModel.Text = shoe.Model;
				txtDescripcion.Text = shoe.Description;
				txtPrecio.Text = shoe.Price.ToString();
				cboSports.SelectedValue = shoe.SportId;
				cboGenres.SelectedValue = shoe.GenreId;
				cboColors.SelectedValue = shoe.ColorId;
				cboBrands.SelectedValue = shoe.BrandId;

				sport = shoe.Sport;
				color = shoe.ColorN;
				genre = shoe.Genre;
				brand = shoe.Brand;
			}
		}
		public Shoe GetTipo()
		{
			return shoe;
		}
		public void SetTipo(Shoe? shoe)
		{
			this.shoe = shoe;
		}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmShoesAe_Load(object sender, EventArgs e)
		{

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (ValidarDatos())
			{
				if (shoe == null)
				{
					shoe = new Shoe();
				}
				shoe.Model = txtModel.Text;
				shoe.Description = txtDescripcion.Text;
				shoe.Sport = sport;
				shoe.Genre = genre;
				shoe.ColorN = color;
				shoe.Brand = brand;
				shoe.Price = decimal.Parse(txtPrecio.Text);
				shoe.SportId = sport.SportiD;
				shoe.GenreId = genre.GenreId;
				shoe.ColorId = color.ColorId;
				shoe.BrandId = brand.BrandId;

				DialogResult = DialogResult.OK;
			}
		}

		private bool ValidarDatos()
		{
			bool valido = true;
			errorProvider1.Clear();


			if (string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrWhiteSpace(txtModel.Text))
			{
				valido = false;
				errorProvider1.SetError(txtModel, "El modelo es requerido.");
			}

			if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
			{
				valido = false;
				errorProvider1.SetError(txtDescripcion, "La descripcion es requerido.");
			}

			if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || (precio <= 0))
			{
				valido = false;
				errorProvider1.SetError(txtPrecio, "Ingrese un precio valido.");

			}

			if (cboBrands.SelectedIndex == 0 && brand == null)
			{
				valido = false;
				errorProvider1.SetError(cboBrands, "Debe seleccionar una marca.");

			}

			if (cboColors.SelectedIndex == 0 && color == null)
			{
				valido = false;
				errorProvider1.SetError(cboColors, "Debe seleccionar un color.");

			}

			if (cboGenres.SelectedIndex == 0 && color == null)
			{
				valido = false;
				errorProvider1.SetError(cboGenres, "Debe seleccionar un genero.");

			}

			if (cboSports.SelectedIndex == 0 && color == null)
			{
				valido = false;
				errorProvider1.SetError(cboSports, "Debe seleccionar un deporte.");

			}
			return valido;
		}

		private void cboBrands_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboBrands.SelectedIndex > 0)
			{
				brand = (Brand)cboBrands.SelectedItem;
			}
			else
			{
				brand = null;
			}
		}

		private void cboColors_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboColors.SelectedIndex > 0)
			{
				color = (Color)cboColors.SelectedItem;
			}
			else
			{
				color = null;
			}
		}

		private void cboSports_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboSports.SelectedIndex > 0)
			{
				sport = (Sport)cboSports.SelectedItem;
			}
			else
			{
				sport = null;
			}
		}

		private void cboGenres_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboGenres.SelectedIndex > 0)
			{
				genre = (Genre)cboGenres.SelectedItem;
			}
			else
			{
				genre = null;
			}
		}

		private void btnNuevoBrand_Click(object sender, EventArgs e)
		{
			frmBrandAE frm = new frmBrandAE();
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel) { return; }
			else
			{
				var service = serviceProvider.GetService<IBrandsService>();
				brand = frm.GetTipo();
				if (service.Existe(brand))
				{
					MessageBox.Show("La marca ingresada ya existe.");
					return;

				}

				cboBrands.Enabled = false;
				lblMarca.Visible = true;
				lblMarca.Text = brand.BrandName;

			}


		}

		private void btnNuevoGenero_Click(object sender, EventArgs e)
		{
			frmGenreAE frm = new frmGenreAE();
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel) { return; }
			else
			{
				var service = serviceProvider.GetService<IGenresService>();
				genre = frm.GetTipo();
				if (service.Existe(genre))
				{
					MessageBox.Show("El genero ingresado ya existe.");
					return;

				}

				cboGenres.Enabled = false;
				lblGenero.Visible = true;
				lblGenero.Text = genre.GnereName;

			}
		}

		private void btnNuevoColor_Click(object sender, EventArgs e)
		{
			frmColorAE frm = new frmColorAE();
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel) { return; }
			else
			{
				var service = serviceProvider.GetService<IColorsService>();
				color = frm.GetColor();
				if (service.Existe(color))
				{
					MessageBox.Show("El color ingresado ya existe");
					return;

				}

				cboColors.Enabled = false;
				lblColor.Visible = true;
				lblColor.Text = color.ColorName;

			}
		}

		private void btnNuevoDeporte_Click(object sender, EventArgs e)
		{
			frmSportsAE frm = new frmSportsAE();
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel) { return; }
			else
			{
				var service = serviceProvider.GetService<ISportsService>();
				sport = frm.GetSport();
				if (service.Existe(sport))
				{
					MessageBox.Show("El deporte ingresada ya existe");
					return;

				}

				cboSports.Enabled = false;
				lblDeporte.Visible = true;
				lblDeporte.Text = sport.SportName;

			}
		}
	}
}
