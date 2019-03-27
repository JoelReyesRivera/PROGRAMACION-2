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
    public partial class frmMenuDetalles : Form
    {
        public frmMenuDetalles()
        {
            InitializeComponent();
        }

        private void frmMenuDetalles_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarDetalle AgregaDetalle = new frmAgregarDetalle();
            AgregaDetalle.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmMostrarDetalles MostrarDetalles = new frmMostrarDetalles();
            MostrarDetalles.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarDetalle BuscarDetalle = new frmBuscarDetalle();
            BuscarDetalle.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
