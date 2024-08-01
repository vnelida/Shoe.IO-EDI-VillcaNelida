using Shoes.Windows.Helpers;
using Size = Shoes.Entidades.Size;

namespace Shoes.Windows.Formularios
{
	public partial class frmAgregarTalle : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private Size? sizeSelect;
		public frmAgregarTalle(IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CombosHelper.CargarComboSizes(_serviceProvider, ref cboTalles);
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (ValidarDatos())
			{
				DialogResult = DialogResult.OK;
			}
		}

		private bool ValidarDatos()
		{
			bool valido = true;
			errorProvider1.Clear();

			if (cboTalles.SelectedIndex > 100)
			{
				valido = false;
				errorProvider1.SetError(cboTalles, "Debe seleccionar un talle.");

			}

			return valido;
		}

		private void frmAgregarTalle_Load(object sender, EventArgs e)
		{

		}

		private void cboTalles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboTalles.SelectedItem is not null)
			{
				sizeSelect = cboTalles.SelectedIndex > 0 ?
			(Entidades.Size)cboTalles.SelectedItem : null;

			}
		}

		internal Size? GetSize()
		{
			return sizeSelect;
		}
	}
}
