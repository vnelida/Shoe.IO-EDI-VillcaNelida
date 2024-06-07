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

namespace Shoes.Windows.Formularios
{
    public partial class frmGenreAE : Form
    {
        private Genre? genre;
        public frmGenreAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (genre != null)
            {
                txtGenre.Text = genre.GnereName;
            }
        }

        internal Genre? GetTipo()
        {
            return genre;
        }

        internal void SetTipo(Genre genre)
        {
            this.genre = genre;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (genre == null)
                {
                    genre = new Genre();

                }
                genre.GnereName = txtGenre.Text;

                DialogResult = DialogResult.OK;
            
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtGenre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtGenre, "DEBE INGRESAR UN GENERO");
            }
            return valido;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
