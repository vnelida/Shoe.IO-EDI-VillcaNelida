using Shoes.Entidades;
using Shoes.Entidades.Dto;
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
using Size = Shoes.Entidades.Size;

namespace Shoes.Windows.Formularios
{
	public partial class frmDetalleTalles : Form
	{
		private List<Size>? sizes;
		private List<SizeDetailDto>? sizesDto;
		public frmDetalleTalles()
		{
			InitializeComponent();
		}

		public void SetDatos(List<SizeDetailDto> sizes)
		{
			sizesDto = sizes;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (sizesDto != null)
			{
				GridHelper.MostrarDatosEnGrilla(sizesDto, dgvDatos);
			}
		}
		private void frmDetalleTalles_Load(object sender, EventArgs e)
		{

		}
	}
}
