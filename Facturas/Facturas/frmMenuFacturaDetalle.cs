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
    public partial class frmMenuFacturaDetalle : Form
    {
        public frmMenuFacturaDetalle()
        {
            InitializeComponent();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmMenuFacturas Facturas = new frmMenuFacturas();
            Facturas.ShowDialog();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            frmMenuDetalles Detalles = new frmMenuDetalles();
            Detalles.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
