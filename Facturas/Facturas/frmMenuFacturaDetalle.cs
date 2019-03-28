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
        private ManejaFacturas mF;
        private ManejaDetalleFactura mD;
        private ManejaProveedores proveedores;
        private ManejaArticulos AdmA;

        public frmMenuFacturaDetalle(ManejaFacturas mF, ManejaDetalleFactura mD,ManejaProveedores proveedores,ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.mF = mF;
            this.mD = mD;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmMenuFacturas Facturas = new frmMenuFacturas(mF, mD, proveedores, AdmA);
            Facturas.ShowDialog();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            frmMenuDetalles Detalles = new frmMenuDetalles(mD, mF, proveedores, AdmA);
            Detalles.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenuFacturaDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
