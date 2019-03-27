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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            frmMenuInventario Inventario = new frmMenuInventario();
            Inventario.ShowDialog();
        }

        private void btnMenuProvedor_Click(object sender, EventArgs e)
        {
            frmMenuProvedor Proveedor = new frmMenuProvedor();
            Proveedor.ShowDialog();
        }

        private void btnMenuFactura_Click(object sender, EventArgs e)
        {
            frmMenuFacturaDetalle FacturaDetalle = new frmMenuFacturaDetalle();
            FacturaDetalle.ShowDialog();
        }
    }
}
