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
        private ManejaFacturas mF;
        private ManejaDetalleFactura mD;

        public frmMenuPrincipal()
        {
            InitializeComponent();
            AdmA = new ManejaArticulos();
            proveedores = new ManejaProveedores();
            mF = new ManejaFacturas();
            mD = new ManejaDetalleFactura();
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            /*frmMenuInventario Inventario = new frmMenuInventario(AdmA);
            Inventario.ShowDialog();*/
        }

        private void btnMenuProvedor_Click(object sender, EventArgs e)
        {
            /*frmMenuProvedor Proveedor = new frmMenuProvedor(proveedores);
            Proveedor.ShowDialog();*/
        }

        private void btnMenuFactura_Click(object sender, EventArgs e)
        {
           /* frmMenuFacturaDetalle FacturaDetalle = new frmMenuFacturaDetalle(mF,mD,proveedores,AdmA);
            FacturaDetalle.ShowDialog();*/
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void consultaIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmConsultaArticulo ConsultaArt = new frmConsultaArticulo(AdmA);
            ConsultaArt.ShowDialog();
        }

        private void agregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregaArticulo frmAgregaArt = new frmAgregaArticulo(AdmA);
            frmAgregaArt.ShowDialog();
        }

        private void consultarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaArticulos VerArt = new frmConsultaArticulos(AdmA);
            VerArt.ShowDialog();
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificaExistenciaArticulo Modifica = new frmModificaExistenciaArticulo(AdmA);
            Modifica.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proveedores.Count() == 0)
            {
                MessageBox.Show("NO HAY PROVEEDORES REGISTRADOS", "SIN PROVEEDORES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAgregarFactura AgregaFactura = new frmAgregarFactura(mF, mD, proveedores, AdmA);
            AgregaFactura.ShowDialog();
        }

        private void consultarPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mF.pCount == 0)
            {
                MessageBox.Show("NO HAY FACTURAS REGISTRADAS", "SIN FACTURAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmConsultarFacturas ConsultaFacturas = new frmConsultarFacturas(proveedores, AdmA, mD, mF);
            ConsultaFacturas.ShowDialog();
        }

        private void consultarIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mF.pCount == 0)
            {
                MessageBox.Show("NO HAY FACTURAS REGISTRADAS", "SIN FACTURAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmBuscarFactura BuscarFactura = new frmBuscarFactura(mF, mD, proveedores, AdmA);
            BuscarFactura.ShowDialog();
        }

        private void consultarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mF.pCount == 0)
            {
                MessageBox.Show("NO HAY FACTURAS REGISTRADAS", "SIN FACTURAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmMostrarFacturas MostrarFacturas = new frmMostrarFacturas(mF, proveedores);
            MostrarFacturas.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*if (mF.pCount == 0)
            {
                MessageBox.Show("NO HAY FACTURAS REGISTRADAS", "SIN FACTURAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */
            if (proveedores.Count() == 0)
            {
                MessageBox.Show("NO HAY PROVEEDORES REGISTRADOS", "SIN PROVEEDORES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAgregarDetalle AgregaDetalle = new frmAgregarDetalle(mD, mF, proveedores, AdmA);
            AgregaDetalle.ShowDialog();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mD.pCount == 0)
            {
                MessageBox.Show("NO HAY DETALLES REGISTRADOS", "SIN DETALLES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmBuscarDetalle BuscarDetalle = new frmBuscarDetalle(mD, mF, proveedores, AdmA);
            BuscarDetalle.ShowDialog();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mD.pCount == 0)
            {
                MessageBox.Show("NO HAY DETALLES REGISTRADOS", "SIN DETALLES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmMostrarDetalles MostrarDetalles = new frmMostrarDetalles(mD, mF, proveedores, AdmA);
            MostrarDetalles.ShowDialog();
        }

        private void agregaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgregarProvedor AgregaProveedor = new frmAgregarProvedor(proveedores);
            AgregaProveedor.ShowDialog();
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (proveedores.Count() == 0)
            {
                MessageBox.Show("NO HAY PROVEEDORES REGISTRADOS", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmConsultaProvedor ConsultaProveedor = new frmConsultaProvedor(proveedores);
            ConsultaProveedor.ShowDialog();
        }

        private void todosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (proveedores.Count() == 0)
            {
                MessageBox.Show("NO HAY PROVEEDORES REGISTRADOS", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmConsultaProveedores ConsultaProveedores = new frmConsultaProveedores(proveedores);
            ConsultaProveedores.ShowDialog();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proveedores.Count() == 0)
            {
                MessageBox.Show("NO HAY PROVEEDORES REGISTRADOS", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAgregarPagoProveedor pagoProveedores = new frmAgregarPagoProveedor(proveedores);
            pagoProveedores.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA TERMINAR LA APLICACIÓN?","CONFIRMAR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (D== DialogResult.Yes)
                Application.Exit();
        }

        private void abOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformacion Inf = new frmInformacion();
            Inf.ShowDialog();
        }
    }
}
