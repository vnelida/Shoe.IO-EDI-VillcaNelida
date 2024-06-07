using Microsoft.Extensions.DependencyInjection;
using Shoes.Servicios.Interface;
using Shoes.Windows.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.Windows
{
    public partial class frmInicio : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public frmInicio(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            frmColors frm = new frmColors(_serviceProvider.GetService<IColorsService>());
            frm.ShowDialog();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            frmBrands frm = new frmBrands(_serviceProvider.GetService<IBrandsService>());
            frm.ShowDialog();
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            frmGenres frm = new frmGenres(_serviceProvider.GetService<IGenresService>());
            frm.ShowDialog();
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            frmSports frm = new frmSports(_serviceProvider.GetService<ISportsService>());
            frm.ShowDialog();

        }

        private void btnShoes_Click(object sender, EventArgs e)
        {
            frmShoes frm = new frmShoes(_serviceProvider.GetService<IShoesService>(), _serviceProvider);
            frm.ShowDialog();
        }
    }
}
