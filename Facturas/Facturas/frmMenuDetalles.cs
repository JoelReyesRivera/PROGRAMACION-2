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
    public partial class frmMenuDetalles : Form
    {
        private ManejaDetalleFactura mD;
        private ManejaFacturas mF;
        private ManejaProveedores proveedores;
        private ManejaArticulos AdmA;

        public frmMenuDetalles(ManejaDetalleFactura mD,ManejaFacturas mF,ManejaProveedores proveedores, ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.mD = mD;
            this.mF = mF;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void frmMenuDetalles_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (mF.pCount == 0)
            {
                MessageBox.Show("NO HAY FACTURAS REGISTRADAS", "SIN FACTURAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (proveedores.pCount == 0)
            {
                MessageBox.Show("NO HAY PROVEEDORES REGISTRADOS","SIN PROVEEDORES",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (AdmA.pCount == 0)
            {
                MessageBox.Show("NO HAY ARTÍCULOS REGISTRADOS","SIN ARTICULOS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            frmAgregarDetalle AgregaDetalle = new frmAgregarDetalle(mD, mF, proveedores, AdmA);
            AgregaDetalle.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (mD.pCount == 0)
            {
                MessageBox.Show("NO HAY DETALLES REGISTRADOS","SIN DETALLES",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            frmMostrarDetalles MostrarDetalles = new frmMostrarDetalles(mD,mF,proveedores,AdmA);
            MostrarDetalles.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mD.pCount == 0)
            {
                MessageBox.Show("NO HAY DETALLES REGISTRADOS", "SIN DETALLES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmBuscarDetalle BuscarDetalle = new frmBuscarDetalle(mD, mF, proveedores, AdmA);
            BuscarDetalle.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA REGRESAR A LA PANTALLA ANTERIOR?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }
    }
}
