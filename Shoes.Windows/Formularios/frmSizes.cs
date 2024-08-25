using Shoes.Entidades;
using Shoes.Entidades.Enums;
using Shoes.Servicios.Interface;
using Shoes.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Size = Shoes.Entidades.Size;

namespace Shoes.Windows.Formularios
{
	public partial class frmSizes : Form
	{
		private readonly ISizeService service;
		private List<Size> lista;
		private List<Shoe> listaShoes;

		private Orden orden;
		private int pageCount;
		private int pageSize = 13;
		private int page = 0;
		private int recordCount;
		public frmSizes(ISizeService _service)
		{
			InitializeComponent();
			service = _service;
		}

		private void frmSizes_Load(object sender, EventArgs e)
		{
			RecargarGrilla();
		}

		private void RecargarGrilla()
		{
			recordCount = service.GetCantidad();
			pageCount = FormHelper.CalcularPagina(recordCount, pageSize);
			txtCantidadRegistros.Text = pageCount.ToString();
			CombosHelper.CargarComboPagina(pageCount, ref cboPaginas);
			lista = service.GetListaPaginada(page, pageSize);
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

		private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
		{
			page = int.Parse(cboPaginas.Text);
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

		private void btnUltimo_Click(object sender, EventArgs e)
		{
			page = pageCount;
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

		private void btnSiguiente_Click(object sender, EventArgs e)
		{

			page++;
			if (page > pageCount) { page = pageCount; }
			cboPaginas.SelectedIndex = page - 1;
			lista = service.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}

		private void tsbCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void tsbNuevo_Click(object sender, EventArgs e)
		{
			frmSizeAE frm = new frmSizeAE() { Text = "Nuevo talle" };
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel)
			{
				return;
			}

			Size size = frm.GetTipo();

			if (!service.Existe(size))
			{
				service.Guardar(size);
				var r = GridHelper.ConstruirFila(dgvDatos);
				GridHelper.SetearFila(r, size);
				GridHelper.AgregarFila(r, dgvDatos);
				MessageBox.Show("Registro agregado exitosamente");
			}
			else
			{
				MessageBox.Show("Registro duplicado.");
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
			Size? size = (Size)r.Tag;
			frmSizeAE frm = new frmSizeAE() { Text = "Editar talle" };
			frm.SetTipo(size);
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel)
			{
				return;
			}
			try
			{
				size = frm.GetTipo();

				if (!service.Existe(size))
				{
					service.Guardar(size);

					GridHelper.SetearFila(r, size);
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

		private void tsbBorrar_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			var r = dgvDatos.SelectedRows[0];
			if (r.Tag is not null)
			{
				Size size = (Size)r.Tag;
				DialogResult dr = MessageBox.Show($"¿Desea borrar el registro ''{size.SizeNumber}''?", "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dr == DialogResult.No)
				{
					return;
				}
				try
				{


					if (!service.EstaRelacionado(size))
					{
						service.Borrar(size);

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

		private void tsbConsulta_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			var r = dgvDatos.SelectedRows[0];
			Size size = (Size)r.Tag;
			var sizeEnDB = service.GetSizePorId(size.SizeId);
			listaShoes = service.GetShoes(sizeEnDB);

			frmMostrarShoes frm = new frmMostrarShoes() { Text = $"Talle {size.SizeNumber}" };
			frm.SetLista(listaShoes);
			frm.ShowDialog(this);
		}
	}
}
