using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturas
{
    public partial class frmMenuInventario : Form
    {
        public frmMenuInventario()
        {
            InitializeComponent();
        }

        private void btnAgregaArticulo_Click(object sender, EventArgs e)
        {
            frmAgregaArticulo AgregaArt = new frmAgregaArticulo();
            AgregaArt.ShowDialog();
        }

        private void lblConsultarArticulo_Click(object sender, EventArgs e)
        {
            frmConsultaArticulo ConsultaArt = new frmConsultaArticulo();
            ConsultaArt.ShowDialog();
        }

        private void btnVerArticulos_Click(object sender, EventArgs e)
        {
            frmConsultaArticulos VerArt = new frmConsultaArticulos();
            VerArt.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }
    }
}
