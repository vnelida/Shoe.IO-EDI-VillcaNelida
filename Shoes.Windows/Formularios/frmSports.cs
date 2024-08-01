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
	public partial class frmSports : Form
	{
		private readonly ISportsService servicio;
		private List<Sport> lista;
		private List<Shoe> listaShoes;
		private Orden orden;
		private int pageCount;
		private int pageSize = 13;
		private int page = 1;
		private int recordCount;

		public frmSports(ISportsService _servicio)
		{
			InitializeComponent();
			servicio = _servicio;
		}

		private void frmSports_Load(object sender, EventArgs e)
		{
			RecargarGrilla();
		}
		private void RecargarGrilla()
		{
			recordCount = servicio.GetCantidad();
			pageCount = FormHelper.CalcularPagina(recordCount, pageSize);
			txtCantidadRegistros.Text = pageCount.ToString();
			CombosHelper.CargarComboPagina(pageCount, ref cboPaginas);
			lista = servicio.GetListaPaginada(page, pageSize);
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
				Sport sport = (Sport)r.Tag;
				DialogResult dr = MessageBox.Show($"¿Desea borrar el registro ''{sport.SportName}''?", "Confirmar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
				if (dr == DialogResult.No)
				{
					return;
				}
				try
				{


					if (!servicio.EstaRelacionado(sport))
					{
						servicio.Borrar(sport);

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

		private void tsbNuevo_Click(object sender, EventArgs e)
		{
			frmSportsAE frm = new frmSportsAE() { Text = "Nuevo deporte" };
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel)
			{
				return;
			}

			Sport sport = frm.GetSport();

			if (!servicio.Existe(sport))
			{
				servicio.Guardar(sport);
				var r = GridHelper.ConstruirFila(dgvDatos);
				GridHelper.SetearFila(r, sport);
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
			Sport? sport = (Sport)r.Tag;
			frmSportsAE frm = new frmSportsAE() { Text = "Editar deporte" };
			frm.SetTipo(sport);
			DialogResult dr = frm.ShowDialog(this);
			if (dr == DialogResult.Cancel)
			{
				return;
			}
			try
			{
				sport = frm.GetSport();

				if (!servicio.Existe(sport))
				{
					servicio.Guardar(sport);

					GridHelper.SetearFila(r, sport);
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

		private void tsbCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void MostrarOrdenado(Orden orden)
		{
			lista = servicio.GetListaOrdenada(orden);
			MostrarDatosEnGrilla();
		}

		private void tsbOrden_Click(object sender, EventArgs e)
		{

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

		private void btnSiguiente_Click_1(object sender, EventArgs e)
		{
			page++;
			if (page > pageCount) { page = pageCount; }
			cboPaginas.SelectedIndex = page - 1;
			lista = servicio.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}

		private void btnAnterior_Click_1(object sender, EventArgs e)
		{
			page--;
			if (page == 0) { page = 1; }
			cboPaginas.SelectedIndex = page - 1;
			lista = servicio.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();

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

		private void cboPaginas_SelectedIndexChanged_2(object sender, EventArgs e)
		{
			page = int.Parse(cboPaginas.Text);
			lista = servicio.GetListaPaginada(page, pageSize);
			MostrarDatosEnGrilla();
		}

		private void tsbActualizar_Click(object sender, EventArgs e)
		{
			RecargarGrilla();
		}

		private void tsbConsulta_Click(object sender, EventArgs e)
		{
			if (dgvDatos.SelectedRows.Count == 0)
			{
				return;
			}
			var r = dgvDatos.SelectedRows[0];
			Sport sport = (Sport)r.Tag;
			var sportInDB = servicio.GetSportPorId(sport.SportiD);
			listaShoes = servicio.GetShoes(sportInDB);

			frmMostrarShoes frm = new frmMostrarShoes() { Text = $"{sport.SportName}" };
			frm.SetLista(listaShoes);
			frm.ShowDialog(this);
		}
	}
}
