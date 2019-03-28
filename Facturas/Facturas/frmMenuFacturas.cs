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
        private ManejaArticulos AdmA;
        private ManejaProveedores proveedores;
        private ManejaFacturas mF;
        private ManejaDetalleFactura mD;

        public frmMenuFacturas(ManejaFacturas mF, ManejaDetalleFactura mD, ManejaProveedores proveedores,ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.mF = mF;
            this.mD = mD;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
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
            if (mF.pCount == 0)
            {
                MessageBox.Show("NO HAY FACTURAS REGISTRADAS","SIN FACTURAS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            frmConsultarFacturas ConsultaFacturas = new frmConsultarFacturas();
            ConsultaFacturas.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (mF.pCount == 0)
            {
                MessageBox.Show("NO HAY FACTURAS REGISTRADAS", "SIN FACTURAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmMostrarFacturas MostrarFacturas = new frmMostrarFacturas();
            MostrarFacturas.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mF.pCount == 0)
            {
                MessageBox.Show("NO HAY FACTURAS REGISTRADAS", "SIN FACTURAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmBuscarFactura BuscarFactura = new frmBuscarFactura();
            BuscarFactura.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
