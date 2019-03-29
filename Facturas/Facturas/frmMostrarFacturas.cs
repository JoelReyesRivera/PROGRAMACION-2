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
    public partial class frmMostrarFacturas : Form
    {
        ManejaFacturas mF;
        ManejaProveedores proveedores;

        public frmMostrarFacturas(ManejaFacturas mF, ManejaProveedores proveedores)
        {
            InitializeComponent();
            this.mF = mF;
            this.proveedores = proveedores;
        }

        private void frmMostrarFacturas_Load(object sender, EventArgs e)
        {

        }
    }
}
