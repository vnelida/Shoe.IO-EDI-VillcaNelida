using Shoes.Entidades;
using Shoes.Entidades.Enums;
using Shoes.Servicios.Interface;
using Shoes.Windows.Helpers;

namespace Shoes.Windows.Formularios
{
	public partial class frmBrands : Form
	{
		private readonly IBrandsService service;
		private List<Brand> lista;
		private List<Shoe> listaShoes;
		private Orden orden;
		private int pageCount;
		private int pageSize = 13;
		private int page = 1;
		private int recordCount;
		public frmBrands(IBrandsService _service)
		{
			InitializeComponent();
			service = _service;
		}

		private void frmBrands_Load(object sender, EventArgs e)
		{
			recordCount = service.GetCantidad();
			pageCount = FormHelper.CalcularPagina(recordCount, pageSize);
			txtCantidadRegistros.Text = pageCount.ToString();
			CombosHelper.CargarComboPagina(pageCount, ref cboPaginas);
			lista = service.GetListaPaginada(page, pageSize);

			RecargarGrilla();
		}
		private void MostrarOrdenado(Orden orden)
		{
			lista = service.GetListaOrdenada(orden);
			MostrarDatosEnGrilla();
		}
		private void RecargarGrilla()
		{
			MostrarDatosEnGrilla();
		}

		private void MostrarDatosEnGrilla()
		{
			GridHelper.LimpiarGrilla(dgvDatos);
			if (lista is not null)
			{
				foreach (var brand in lista)
				{
					DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetearFila(r, brand);
					GridHelper.AgregarFila(r, dgvDatos);
				}

			}
		}


		

		private void panelNavegacion_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			page++;
			if (page > pageCount) { page = pageCount; }
			cboPaginas.SelectedIndex = page - 1;
			lista = service.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}

		private void btnAnterior_Click(object sender, EventArgs e)
		{
			page--;
			if (page == 0) { page = 1; }
			cboPaginas.SelectedIndex = page - 1;
			lista = service.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}

		private void btnUltimo_Click(object sender, EventArgs e)
		{
			page = pageCount;
			cboPaginas.SelectedIndex = page - 1;
			lista = service.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}

		private void btnPrimero_Click(object sender, EventArgs e)
		{
			page = 1;
			cboPaginas.SelectedIndex = page - 1;
			lista = service.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}

		private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
		{
			page = int.Parse(cboPaginas.Text);
			lista = service.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}


		private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void tsbCerrar_Click_1(object sender, EventArgs e)
		{
			Close();
		}

		private void tsbConsulta_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			var r = dgvDatos.SelectedRows[0];
			Brand brand = (Brand)r.Tag;
			var brandEnDB = service.GetBrandPorId(brand.BrandId);
			listaShoes = service.GetShoes(brandEnDB);

			frmMostrarShoes frm = new frmMostrarShoes() { Text=$"{brand.BrandName}" };
			frm.SetLista(listaShoes);
			frm.ShowDialog(this);
		}

		private void tsbNuevo_Click_1(object sender, EventArgs e)
		{
			frmBrandAE frm = new frmBrandAE() { Text = "Nueva marca" };
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel)
			{
				return;
			}

			Brand brand = frm.GetTipo();

			if (!service.Existe(brand))
			{
				service.Guardar(brand);
				var r = GridHelper.ConstruirFila(dgvDatos);
				GridHelper.SetearFila(r, brand);
				GridHelper.AgregarFila(r, dgvDatos);
				MessageBox.Show("Registro agregado exitosamente");
			}
			else
			{
				MessageBox.Show("Registro duplicado.");
			}
		}

		private void tsbBorrar_Click_1(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			var r = dgvDatos.SelectedRows[0];
			if (r.Tag is not null)
			{
				Brand brand = (Brand)r.Tag;
				DialogResult dr = MessageBox.Show($"¿Desea borrar el registro ''{brand.BrandName}''?", "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dr == DialogResult.No)
				{
					return;
				}
				try
				{


					if (!service.EstaRelacionado(brand))
					{
						service.Borrar(brand);

						GridHelper.QuitarFila(r, dgvDatos);
						MessageBox.Show("Registro borrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Registro relacionado. Baja denegada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}

			}
		}

		private void tsbEditar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			var r = dgvDatos.SelectedRows[0];
			if (r.Tag == null) { return; }
			Brand? brand = (Brand)r.Tag;
			frmBrandAE frm = new frmBrandAE() { Text = "Editar marca" };
			frm.SetTipo(brand);
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel)
			{
				return;
			}
			try
			{
				brand = frm.GetTipo();

				if (!service.Existe(brand))
				{
					service.Guardar(brand);

					GridHelper.SetearFila(r, brand);
					MessageBox.Show("Registro editado exitosamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Registro duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void tsbActualizar_Click_1(object sender, EventArgs e)
		{
			RecargarGrilla();
		}

		private void aZToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			orden = Orden.AZ;
			MostrarOrdenado(orden);
		}

		private void zAToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			orden = Orden.ZA;
			MostrarOrdenado(orden);
		}
	}
}
