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
    public partial class frmMenuProvedor : Form
    {
        ManejaProveedores proveedores;
        public frmMenuProvedor(ManejaProveedores proveedores)
        {
            InitializeComponent();
            this.proveedores = proveedores;
        }

        private void btnAgregarProvedor_Click(object sender, EventArgs e)
        {
            frmAgregarProvedor AgregaProveedor = new frmAgregarProvedor(proveedores);
            AgregaProveedor.ShowDialog();
        }

        private void btnConsultarProvedor_Click(object sender, EventArgs e)
        {
            if (proveedores.pCount==0)
            {
                MessageBox.Show("NO HAY PROVEEDORES REGISTRADOS", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmConsultaProvedor ConsultaProveedor = new frmConsultaProvedor(proveedores);
            ConsultaProveedor.ShowDialog();
        }

        private void btnVerProvedores_Click(object sender, EventArgs e)
        {
            if (proveedores.pCount == 0)
            {
                MessageBox.Show("NO HAY PROVEEDORES REGISTRADOS", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmConsultaProveedores ConsultaProveedores = new frmConsultaProveedores(proveedores);
            ConsultaProveedores.ShowDialog();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
