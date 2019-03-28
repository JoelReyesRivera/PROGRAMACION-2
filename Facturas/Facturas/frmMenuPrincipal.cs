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
        public ManejaArticulos AdmA;
        public ManejaProveedores proveedores;

        public frmMenuPrincipal()
        {
            InitializeComponent();
            AdmA = new ManejaArticulos();
            proveedores = new ManejaProveedores();
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            frmMenuInventario Inventario = new frmMenuInventario(AdmA);
            Inventario.ShowDialog();
        }

        private void btnMenuProvedor_Click(object sender, EventArgs e)
        {
            frmMenuProvedor Proveedor = new frmMenuProvedor(proveedores);
            Proveedor.ShowDialog();
        }

        private void btnMenuFactura_Click(object sender, EventArgs e)
        {
            frmMenuFacturaDetalle FacturaDetalle = new frmMenuFacturaDetalle();
            FacturaDetalle.ShowDialog();
        }
    }
}
