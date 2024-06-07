using Microsoft.Extensions.DependencyInjection;
using Shoes.Entidades;
using Shoes.Servicios.Interface;
using Color = Shoes.Entidades.Color;

namespace Shoes.Windows.Helpers
{
	public static class CombosHelper
	{
		public static void CargarComboSports(IServiceProvider serviceProvider, ref ToolStripComboBox cbo)
		{
			var servicio = serviceProvider.GetService<ISportsService>();

			var lista = servicio?.GetLista();
			var defaultSport = new Sport
			{
				SportName = "Seleccione"
			};



			cbo.Items.Clear();
			lista?.Insert(0, defaultSport);
			if (lista is not null)
			{
				foreach (Sport sport in lista)
				{
					cbo.Items.Add(sport.SportName);
				}

			}
			if (lista?.Count > 0)
			{
				cbo.SelectedIndex = 0;
			}
		}
		public static void CargarComboGenre(IServiceProvider serviceProvider, ref ToolStripComboBox cbo)
		{
			var servicio = serviceProvider.GetService<IGenresService>();

			var lista = servicio?.GetLista();
			var defaultGenre = new Genre
			{
				GnereName = "Seleccione"
			};



			cbo.Items.Clear();
			lista?.Insert(0, defaultGenre);
			if (lista is not null)
			{
				foreach (Genre genre in lista)
				{
					cbo.Items.Add(genre.GnereName);
				}

			}
			if (lista?.Count > 0)
			{
				cbo.SelectedIndex = 0;
			}
		}
		public static void CargarComboBrands(IServiceProvider serviceProvider, ref ToolStripComboBox cbo)
		{
			var servicio = serviceProvider.GetService<IBrandsService>();

			var lista = servicio?.GetLista();
			var defaultBrand = new Brand
			{
				BrandName = "Seleccione"
			};



			cbo.Items.Clear();
			lista?.Insert(0, defaultBrand);
			if (lista is not null)
			{
				foreach (Brand brand in lista)
				{
					cbo.Items.Add(brand.BrandName);
				}

			}
			if (lista?.Count > 0)
			{
				cbo.SelectedIndex = 0;
			}
		}

		public static void CargarComboPagina(int pageCount, ref ComboBox cbo)
		{
			cbo.Items.Clear();
			for (int page = 1; page <= pageCount; page++)
			{
				cbo.Items.Add(page.ToString());
			}
			cbo.SelectedIndex = 0;
		}

		public static void CargarComboColors(IServiceProvider serviceProvider, ref ComboBox cbo)
		{
			var servicio = serviceProvider.GetService<IColorsService>();

			var lista = servicio.GetLista();
			var defaultColor = new Color
			{
				ColorName = "Seleccione"
			};
			lista.Insert(0, defaultColor);
			cbo.DataSource = lista;
			cbo.DisplayMember = "ColorName";
			cbo.ValueMember = "ColorId";
			cbo.SelectedIndex = 0;
		}

		public static void CargarComboBrands(IServiceProvider serviceProvider, ref ComboBox cbo)
		{
			var servicio = serviceProvider.GetService<IBrandsService>();

			var lista = servicio.GetLista();
			var defaultBrand = new Brand
			{
				BrandName = "Seleccione"
			};
			lista.Insert(0, defaultBrand);
			cbo.DataSource = lista;
			cbo.DisplayMember = "BrandName";
			cbo.ValueMember = "BrandId";
			cbo.SelectedIndex = 0;
		}

		public static void CargarComboSport(IServiceProvider serviceProvider, ref ComboBox cbo)
		{
			var servicio = serviceProvider.GetService<ISportsService>();

			var lista = servicio.GetLista();
			var defaultSport = new Sport
			{
				SportName = "Seleccione"
			};
			lista.Insert(0, defaultSport);
			cbo.DataSource = lista;
			cbo.DisplayMember = "SportName";
			cbo.ValueMember = "Sportid";
			cbo.SelectedIndex = 0;
		}
		public static void CargarComboGenre(IServiceProvider serviceProvider, ref ComboBox cbo)
		{
			var servicio = serviceProvider.GetService<IGenresService>();

			var lista = servicio.GetLista();
			var defaultGenre = new Genre
			{
				GnereName = "Seleccione"
			};
			lista.Insert(0, defaultGenre);
			cbo.DataSource = lista;
			cbo.DisplayMember = "GnereName";
			cbo.ValueMember = "GenreId";
			cbo.SelectedIndex = 0;
		}

		public static void CargarComboColors(IServiceProvider serviceProvider, ref ToolStripComboBox cbo)
		{
			var servicio = serviceProvider.GetService<IColorsService>();

			var lista = servicio.GetLista();
			var defaultColor = new Color
			{
				ColorName = "Seleccione"
			};


			cbo.Items.Clear();
			lista.Insert(0, defaultColor);
			foreach (Color color in lista)
			{
				cbo.Items.Add(color.ColorName);
			}

			if (lista.Count > 0)
			{
				cbo.SelectedIndex = 0;
			}
		}

	}
}
