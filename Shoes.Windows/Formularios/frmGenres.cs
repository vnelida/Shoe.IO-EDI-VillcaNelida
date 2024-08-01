using Shoes.Entidades;
using Shoes.Entidades.Enums;
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

namespace Shoes.Windows.Formularios
{
	public partial class frmGenres : Form
	{
		private readonly IGenresService servicio;
		private List<Genre>? lista;
		private List<Shoe> listaShoes;
		private Orden orden;
		private int pageCount;
		private int pageSize = 13;
		private int page = 1;
		private int recordCount;
		public frmGenres(IGenresService _servicio)
		{
			InitializeComponent();
			servicio = _servicio;
		}

		private void panelNavegacion_Paint(object sender, PaintEventArgs e)
		{

		}


		private void frmGenres_Load(object sender, EventArgs e)
		{
			recordCount = servicio.GetCantidad();
			pageCount = FormHelper.CalcularPagina(recordCount, pageSize);
			txtCantidadRegistros.Text = pageCount.ToString();
			CombosHelper.CargarComboPagina(pageCount, ref cboPaginas);
			lista = servicio.GetListaPaginada(page, pageSize);
			RecargarGrilla();
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
				foreach (var item in lista)
				{
					DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
					GridHelper.SetearFila(r, item);
					GridHelper.AgregarFila(r, dgvDatos);
				}

			}
		}

		private void tsbBorrar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			var r = dgvDatos.SelectedRows[0];
			if (r.Tag is not null)
			{
				Genre genre = (Genre)r.Tag;
				DialogResult dr = MessageBox.Show($"¿Desea borrar el registro ''{genre.GnereName}''?", "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dr == DialogResult.No)
				{
					return;
				}
				try
				{


					if (!servicio.EstaRelacionado(genre))
					{
						servicio.Borrar(genre);

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
			Genre? genre = (Genre)r.Tag;
			frmGenreAE frm = new frmGenreAE() { Text = "Editar genero" };
			frm.SetTipo(genre);
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel)
			{
				return;
			}
			try
			{
				genre = frm.GetTipo();

				if (!servicio.Existe(genre))
				{
					servicio.Guardar(genre);

					GridHelper.SetearFila(r, genre);
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

		private void tsbNuevo_Click(object sender, EventArgs e)
		{
			frmGenreAE frm = new frmGenreAE() { Text = "Nuevo genero" };
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel)
			{
				return;
			}

			Genre genre = frm.GetTipo();

			if (!servicio.Existe(genre))
			{
				servicio.Guardar(genre);
				var r = GridHelper.ConstruirFila(dgvDatos);
				GridHelper.SetearFila(r, genre);
				GridHelper.AgregarFila(r, dgvDatos);
				MessageBox.Show("Registro agregado exitosamente");
			}
			else
			{
				MessageBox.Show("Registro duplicado.");
			}
		}

		private void tsbCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}


		private void MostrarOrdenado(Orden orden)
		{
			lista = servicio.GetListaOrdenada(orden);
			MostrarDatosEnGrilla();
		}


		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			page++;
			if (page > pageCount) { page = pageCount; }
			cboPaginas.SelectedIndex = page - 1;
			lista = servicio.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}

		private void btnAnterior_Click(object sender, EventArgs e)
		{
			page--;
			if (page == 0) { page = 1; }
			cboPaginas.SelectedIndex = page - 1;
			lista = servicio.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}

		private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
		{
			page = int.Parse(cboPaginas.Text);
			lista = servicio.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}

		private void cboPaginas_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			page = int.Parse(cboPaginas.Text);
			lista = servicio.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void panelToolBar_Paint(object sender, PaintEventArgs e)
		{

		}

		private void tsbActualizar_Click(object sender, EventArgs e)
		{
			RecargarGrilla();
		}

		private void aZToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			orden = Orden.AZ;
			MostrarOrdenado(orden);
		}

		private void zAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			orden = Orden.ZA;
			MostrarOrdenado(orden);

		}

		private void tsbConsulta_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			var r = dgvDatos.SelectedRows[0];
			Genre genre = (Genre)r.Tag;
			var genreEnDB = servicio.GetGenrePorId(genre.GenreId);
			listaShoes = servicio.GetShoes(genreEnDB);

			frmMostrarShoes frm = new frmMostrarShoes() { Text = $"{genre.GnereName}" };
			frm.SetLista(listaShoes);
			frm.ShowDialog(this);
		}

		private void btnUltimo_Click_1(object sender, EventArgs e)
		{
			page = pageCount;
			cboPaginas.SelectedIndex = page - 1;
			lista = servicio.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}

		private void btnPrimero_Click_1(object sender, EventArgs e)
		{
			page = 1;
			cboPaginas.SelectedIndex = page - 1;
			lista = servicio.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}
	}
}
