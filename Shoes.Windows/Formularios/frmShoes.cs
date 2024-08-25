using Microsoft.Extensions.DependencyInjection;
using Shoes.Entidades;
using Shoes.Entidades.Dto;
using Shoes.Entidades.Enums;
using Shoes.Servicios.Interface;
using Shoes.Windows.Helpers;
using Color = Shoes.Entidades.Color;
using Size = Shoes.Entidades.Size;

namespace Shoes.Windows.Formularios
{
	public partial class frmShoes : Form
	{
		private readonly IServiceProvider serviceProvider;
		private readonly IShoesService servicio;
		private List<ShoeListDto> lista;
		Orden orden;

		private Brand brandFiltro;
		private Color colorFiltro;
		private Genre genreFiltro;
		private Sport sportFiltro;

		private bool FilterOn = false;

		private int pageCount;
		private int pageSize = 14;
		private int pageNum = 0;
		private int recordCount;

		public frmShoes(IShoesService _servicio, IServiceProvider _serviceProvider)
		{
			InitializeComponent();
			servicio = _servicio;
			serviceProvider = _serviceProvider;
		}

		private void frmShoes_Load(object sender, EventArgs e)
		{

			CombosHelper.CargarComboBrands(serviceProvider, ref tscMarca);
			CombosHelper.CargarComboColors(serviceProvider, ref tscColor);
			CombosHelper.CargarComboGenre(serviceProvider, ref tscGenero);
			CombosHelper.CargarComboSports(serviceProvider, ref tscDeporte);
			RecargarGrilla();
		}

		private void RecargarGrilla()
		{
			try
			{
				recordCount = servicio.GetCantidad();
				pageCount = FormHelper.CalcularPagina(recordCount, pageSize);
				txtCantidadRegistros.Text = pageCount.ToString();
				CombosHelper.CargarComboPagina(pageCount, ref cboPaginas);
				lista = servicio.GetListaPaginadaOrdenadaFiltrada(pageNum, pageSize);
				MostrarDatosEnGrilla();
			}
			catch (Exception)
			{
				throw;
			}

		}

		private void MostrarDatosEnGrilla()
		{
			GridHelper.LimpiarGrilla(dgvDatos);
			if (lista is not null)
			{
				foreach (var item in lista)
				{
					DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetearFila(r, item);
					GridHelper.AgregarFila(r, dgvDatos);
				}

			}
		}

		private void tsbTalles_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			var r = dgvDatos.SelectedRows[0];
			if (r.Tag is null) return;
			var shoesDto = (ShoeListDto)r.Tag;
			var shoeId = shoesDto.ShoeId;
			List<ShoeSize>? shoeSizes = servicio.GetListaShoesSizes(shoeId);

			//List<Size>? sizess = servicio.GetSizePorShoes(shoesDto.ShoeId);
			//List<SizeDetailDto>? sizes = servicio.GetSizeDetalle(shoesDto.ShoeId);

			if (shoeSizes is null || shoeSizes.Count == 0)
			{
				MessageBox.Show("El articulo seleccionado no tiene talles disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			frmDetalleTalles frm = new frmDetalleTalles(shoesDto.ShoeId, servicio) { Text = $"Talles del articulo {shoesDto.Model}" };
			frm.SetDatos(shoeSizes);
			frm.ShowDialog(this);

		}
		private void tsbNuevo_Click(object sender, EventArgs e)
		{
			frmShoesAE frm = new frmShoesAE(serviceProvider);
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel) { return; }
			try
			{
				(Shoe? shoe, List<Entidades.Size>? sizes) s = frm.GetShoesSizes();
				if (s.shoe is null) return;
				if (!servicio.Existe(s.shoe))
				{
					servicio.Guardar(s.shoe, s.sizes);
					ActualizarDespuesDeAgregar(s.shoe);
					MessageBox.Show("Registro agregado.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

				}
				else
				{
					MessageBox.Show("Registro existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void ActualizarDespuesDeAgregar(Shoe shoeAgreago)
		{

			int paginaActual = pageNum;
			lista = servicio.GetListaPaginadaOrdenadaFiltrada(paginaActual, pageSize);
			MostrarDatosEnGrilla();
			bool shoeAgregadoEnPaginaActual = lista
				.Any(s => s.ShoeId == shoeAgreago.ShoeId);

			if (!shoeAgregadoEnPaginaActual)
			{
				pageNum = pageCount - 1;
				cboPaginas.SelectedIndex = pageNum;
				lista = servicio
					.GetListaPaginadaOrdenadaFiltrada(pageNum, pageSize, orden,
					brandFiltro, colorFiltro, genreFiltro, sportFiltro);
				MostrarDatosEnGrilla();
			}

		}

		private void tsbEditar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0) { return; }
			var r = dgvDatos.SelectedRows[0];
			if (r.Tag is null) return;

			ShoeListDto shoeListDto = (ShoeListDto)r.Tag;
			Shoe? shoe = servicio.GetShoePorId(shoeListDto.ShoeId);
			if (shoe == null) return;

			List<Size>? sizes = servicio.GetSizePorShoes(shoe.ShoeId);
			(Shoe? shoe, List<Size>? sizes) s = (shoe, sizes);


			frmShoesAE frm = new frmShoesAE(serviceProvider) { Text = "Editar" };
			frm.SetShoeSize(s);
			DialogResult dr = frm.ShowDialog(this);
			try
			{
				s = frm.GetShoesSizes();
				if (s.shoe is null) return;
				if (!servicio.Existe(s.shoe))
				{
					servicio.Guardar(s.shoe, s.sizes);
					ActualizarDespuesDeAgregar(shoe);

				}
				else
				{
					MessageBox.Show("Registro existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void tsbBorrar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0) { return; }

			var r = dgvDatos.SelectedRows[0];
			ShoeListDto shoeListDto = (ShoeListDto)r.Tag;
			var shoe = servicio.GetShoePorId(shoeListDto.ShoeId);
			DialogResult dr = MessageBox.Show($"¿Desea dar de baja el registro {shoe.Model}?", "Confirmar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.No)
			{
				return;
			}
			try
			{
				servicio.Borrar(shoe);

				GridHelper.QuitarFila(r, dgvDatos);
				MessageBox.Show("Registro borrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tsbCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			pageNum++;
			if (pageNum > pageCount - 1) { pageNum = pageCount - 1; }
			cboPaginas.SelectedIndex = pageNum;
			ActualizarListaPaginada();
		}

		private void ActualizarListaPaginada()
		{
			lista = servicio.GetListaPaginadaOrdenadaFiltrada(pageNum, pageSize, orden, brandFiltro, colorFiltro, genreFiltro, sportFiltro);
			MostrarDatosEnGrilla();
		}

		private void tsbFiltrar_Click(object sender, EventArgs e)
		{

		}

		private void btnAnterior_Click(object sender, EventArgs e)
		{
			pageNum--;
			if (pageNum < 0) { pageNum = 0; }
			cboPaginas.SelectedIndex = pageNum;
			ActualizarListaPaginada();
		}

		private void btnUltimo_Click(object sender, EventArgs e)
		{
			pageNum = pageCount - 1;
			cboPaginas.SelectedIndex = pageNum;
			ActualizarListaPaginada();
		}

		private void btnPrimero_Click(object sender, EventArgs e)
		{
			pageNum = 0;
			cboPaginas.SelectedIndex = pageNum;
			ActualizarListaPaginada();
		}

		private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
		{
			pageNum = cboPaginas.SelectedIndex;
			ActualizarListaPaginada();
		}

		private void aZToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MostrarOrdenado(Orden.AZ);
		}

		private void zAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MostrarOrdenado(Orden.ZA);
		}

		private void menorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MostrarOrdenado(Orden.MenorPrecio);
		}

		private void mayorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MostrarOrdenado(Orden.MayorPrecio);
		}

		private void MostrarOrdenado(Orden orden)
		{
			lista = servicio.GetListaPaginadaOrdenadaFiltrada(pageNum, pageSize, orden);
			MostrarDatosEnGrilla();
		}

		private void tscMarca_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!FilterOn)
			{
				if (tscMarca.SelectedIndex > 0)
				{
					FilterOn = true;
					var _servicio = serviceProvider.GetService<IBrandsService>();
					brandFiltro = _servicio.GetBrandPorNombre(tscMarca.Text);

					recordCount = servicio.GetCantidad(p => p.Brand == brandFiltro);

					pageCount = FormHelper.CalcularPagina(recordCount, pageSize);

					txtCantidadRegistros.Text = pageCount.ToString();
					CombosHelper.CargarComboPagina(pageCount, ref cboPaginas);

					lista = servicio.GetListaPaginadaOrdenadaFiltrada(pageNum, pageSize, orden, brandFiltro, colorFiltro, genreFiltro, sportFiltro);
					MostrarDatosEnGrilla();
					tsbFiltrar.Enabled = false;
				}
				else
				{
					brandFiltro = null;
				}

			}

			else
			{
				MessageBox.Show("Presione 'Actualizar' para volver a elegir un filtro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void tscColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!FilterOn)
			{
				if (tscColor.SelectedIndex > 0)
				{
					FilterOn = true;
					var _servicio = serviceProvider.GetService<IColorsService>();
					colorFiltro = _servicio?.GetColorPorNombre(tscColor.Text);

					recordCount = servicio.GetCantidad(p => p.ColorN == colorFiltro);

					pageCount = FormHelper.CalcularPagina(recordCount, pageSize);

					txtCantidadRegistros.Text = pageCount.ToString();
					CombosHelper.CargarComboPagina(pageCount, ref cboPaginas);

					lista = servicio.GetListaPaginadaOrdenadaFiltrada(pageNum, pageSize, orden, brandFiltro, colorFiltro, genreFiltro, sportFiltro);
					MostrarDatosEnGrilla();
					tsbFiltrar.Enabled = false;
				}
				else
				{
					colorFiltro = null;
				}

			}

			else
			{
				MessageBox.Show("Presione 'Actualizar' para volver a elegir un filtro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void tscGenero_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!FilterOn)
			{
				if (tscGenero.SelectedIndex > 0)
				{
					FilterOn = true;
					var _servicio = serviceProvider.GetService<IGenresService>();
					genreFiltro = _servicio?.GetGenrePorNombre(tscGenero.Text);

					recordCount = servicio.GetCantidad(p => p.Genre == genreFiltro);

					pageCount = FormHelper.CalcularPagina(recordCount, pageSize);

					txtCantidadRegistros.Text = pageCount.ToString();
					CombosHelper.CargarComboPagina(pageCount, ref cboPaginas);

					lista = servicio.GetListaPaginadaOrdenadaFiltrada(pageNum, pageSize, orden, brandFiltro, colorFiltro, genreFiltro, sportFiltro);
					MostrarDatosEnGrilla();
					tsbFiltrar.Enabled = false;
				}
				else
				{
					genreFiltro = null;
				}

			}

			else
			{
				MessageBox.Show("Presione 'Actualizar' para volver a elegir un filtro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void tscDeporte_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!FilterOn)
			{
				if (tscDeporte.SelectedIndex > 0)
				{
					FilterOn = true;
					var _servicio = serviceProvider.GetService<ISportsService>();
					sportFiltro = _servicio?.GetSportPorNombre(tscDeporte.Text);

					recordCount = servicio.GetCantidad(p => p.Sport == sportFiltro);

					pageCount = FormHelper.CalcularPagina(recordCount, pageSize);

					txtCantidadRegistros.Text = pageCount.ToString();
					CombosHelper.CargarComboPagina(pageCount, ref cboPaginas);

					lista = servicio.GetListaPaginadaOrdenadaFiltrada(pageNum, pageSize, orden, brandFiltro, colorFiltro, genreFiltro, sportFiltro);
					MostrarDatosEnGrilla();
					tsbFiltrar.Enabled = false;
				}
				else
				{
					brandFiltro = null;
				}

			}

			else
			{
				MessageBox.Show("Presione 'Actualizar' para volver a elegir un filtro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void tsbActualizar_Click(object sender, EventArgs e)
		{
			FilterOn = false;
			tsbFiltrar.Enabled = true;
			brandFiltro = null;
			colorFiltro = null;
			genreFiltro = null;
			sportFiltro = null;
			RecargarGrilla();
		}

		

		private void tsbNuevoTalle_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			var r = dgvDatos.SelectedRows[0];
			if (r.Tag is null) return;
			var shoesDto = (ShoeListDto)r.Tag;

			Shoe? shoe = servicio.GetShoePorId(shoesDto.ShoeId);
			if (shoe is null) return;

			frmAgregarTalle frm = new frmAgregarTalle(serviceProvider) { Text = "Asignar talles" };
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel) { return; }
			try
			{
				Size? size = frm.GetSize();
				int stock=frm.GetStock();
				if (size is null) { return; }
				if (!servicio.ExisteRelacion(shoe, size))
				{
					servicio.AsignarSizeAShoe(shoe, size);
					servicio.AgregarStock(shoe.ShoeId, size.SizeId, stock); // Agrega la cantidad de stock especificada

					if (shoesDto is not null)
					{
						shoesDto.CantidadDeTalles++;
						GridHelper.SetearFila(r, shoesDto);
					}
					MessageBox.Show("Talle agregado al articulo correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				else
				{
					var respuesta = MessageBox.Show("El talle ya se encuentra asignado al articulo seleccionado. \n ", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
					//if (respuesta == DialogResult.No) { return; }
					//else
					//{
					//	var unidades = frm.GetStock();
					//	servicio.AgregarStock(shoe.ShoeId, size.SizeId, unidades);
					//	MessageBox.Show("Stock actualizado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
					//}
										
				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

	}
}
