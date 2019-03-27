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
    public partial class frmMenuFacturas : Form
    {
        public frmMenuFacturas()
        {
            InitializeComponent();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuFacturas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarFactura AgregaFactura = new frmAgregarFactura();
            AgregaFactura.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarFacturas ConsultaFacturas = new frmConsultarFacturas();
            ConsultaFacturas.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmMostrarFacturas MostrarFacturas = new frmMostrarFacturas();
            MostrarFacturas.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarFactura BuscarFactura = new frmBuscarFactura();
            BuscarFactura.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
