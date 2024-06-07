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
    public partial class frmSportsAE : Form
    {
        private Sport? sport;
        public frmSportsAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (sport != null)
            {
                txtSport.Text = sport.SportName;
            }
        }
        public Sport? GetSport()
        {
            return sport;
        }

        public void SetTipo(Sport sport)
        {
            this.sport = sport;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (sport==null)
                {
                    sport = new Sport();
                }
                sport.SportName = txtSport.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtSport.Text ))
            {
                valido = false;
                errorProvider1.SetError(txtSport, "Ingrese un deporte valido");
            }
            return valido;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
