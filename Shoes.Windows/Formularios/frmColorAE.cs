using Microsoft.Extensions.Options;
using Shoes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = Shoes.Entidades.Color;

namespace Shoes.Windows.Formularios
{
    public partial class frmColorAE : Form
    {
        private Color? color;
        public frmColorAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (color != null)
            {
                txtColor.Text = color.ColorName;
            }
        }
        public void SetTipo(Color color)
        {
            this.color = color;
        }
        public Color? GetColor()
        {
            return color;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtColor.Text))
            {
                valido = false;
                errorProvider1.SetError(txtColor, "DEBE INGRESAR UN COLOR");
            }
            return valido;
        }

        private void frmColorAE_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (color == null)
                {
                    color = new Color();

                }
                color.ColorName = txtColor.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
