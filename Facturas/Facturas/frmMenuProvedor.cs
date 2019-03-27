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
        public frmMenuProvedor()
        {
            InitializeComponent();
        }

        private void btnAgregarProvedor_Click(object sender, EventArgs e)
        {
            frmAgregarProvedor AgregaProveedor = new frmAgregarProvedor();
            AgregaProveedor.ShowDialog();
        }

        private void btnConsultarProvedor_Click(object sender, EventArgs e)
        {
            frmConsultaProvedor ConsultaProveedor = new frmConsultaProvedor();
            ConsultaProveedor.ShowDialog();
        }

        private void btnVerProvedores_Click(object sender, EventArgs e)
        {
            frmConsultaProveedores ConsultaProveedores = new frmConsultaProveedores();
            ConsultaProveedores.ShowDialog();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
