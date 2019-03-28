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
    public partial class frmAgregarDetalle : Form
    {
        ManejaFacturas mF;
        ManejaDetalleFactura mD;
        ManejaProveedores proveedores;
        ManejaArticulos AdmA;

        public frmAgregarDetalle(ManejaDetalleFactura mD, ManejaFacturas mF, ManejaProveedores proveedores, ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.mD = mD;
            this.mF = mF;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void frmAgregarDetalle_Load(object sender, EventArgs e)
        {

        }

        private void Valida_proveedor(object sender, EventArgs e)
        {
            string Proveedor = txtClaveProveedor.Text;
            if (!ValidaNumCadena(Proveedor))
            {
                errorP.SetError(txtClaveProveedor, "Clave de proveedor no válida");
                txtClaveProveedor.Focus();
            }
            else
            {
                errorP.SetError(txtClaveProveedor, "");
            }
        }

        private void txtClaveProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(txtClaveProveedor, "Sólo se permiten números");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(txtClaveProveedor, "");
            }
        }

        private void Valida_factura(object sender, EventArgs e)
        {
            string ClaveFactura = txtClaveFactura.Text;
            if (!ValidaNumCadena(ClaveFactura))
            {
                errorP.SetError(txtClaveFactura, "Clave de factura no válida");
                txtClaveFactura.Focus();
            }
            else
            {
                errorP.SetError(txtClaveFactura, "");
            }
        }

        private void txtClaveFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(txtClaveFactura, "Sólo se permiten números");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(txtClaveFactura, "");
            }
        }

        private void Valida_articulo(object sender, EventArgs e)
        {
            string ClaveArticulo = txtClaveArticulo.Text;
            if (!ValidaNumCadena(ClaveArticulo))
            {
                errorP.SetError(txtClaveArticulo, "Clave de artículo no válida");
                txtClaveArticulo.Focus();
            }
            else
            {
                errorP.SetError(txtClaveArticulo, "");
            }
        }

        private void txtClaveArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(txtClaveArticulo, "Sólo se permiten números");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(txtClaveArticulo, "");
            }
        }

        private void numUpCantidad_Validated(object sender, EventArgs e)
        {
            if (numUpCantidad.Value <= 0)
            {
                errorP.SetError(numUpCantidad, "DEBE SELECCIONAR AL MENOS 1 ARTICULO");
                numUpCantidad.Focus();
            }
            else
            {
                errorP.SetError(numUpCantidad, "");
            }
        }
        private bool ValidaNumCadena(string Cadena)
        {
            foreach (char c in Cadena)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        private bool ValidaTxtCadena(string Cadena)
        {
            foreach (char c in Cadena)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }
}
