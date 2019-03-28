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
    public partial class frmAgregarFactura : Form
    {
        public frmAgregarFactura()
        {
            InitializeComponent();
        }

        private void Valida_Factura(object sender, EventArgs e)
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
        private void Valida_claveart(object sender, EventArgs e)
        {
            string ClaveArticulo = txtClaveArticuloEliminar.Text;
            if (!ValidaNumCadena(ClaveArticulo))
            {
                errorP.SetError(txtClaveArticuloEliminar, "Clave de artículo no válida");
                txtClaveArticuloEliminar.Focus();
            }
            else
            {
                errorP.SetError(txtClaveArticuloEliminar, "");
            }
        }

        private void txtClaveArticuloEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(txtClaveArticuloEliminar, "Sólo se permiten números");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(txtClaveArticuloEliminar, "");
            }
        }
        private void Valida_claveartAgrega(object sender, EventArgs e)
        {
            string ClaveArticulo = txtClaveArticuloAgregar.Text;
            if (!ValidaNumCadena(ClaveArticulo))
            {
                errorP.SetError(txtClaveArticuloAgregar, "Clave de artículo no válida");
                txtClaveArticuloAgregar.Focus();
            }
            else
            {
                errorP.SetError(txtClaveArticuloAgregar, "");
            }
        }

        private void txtClaveArticuloAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(txtClaveArticuloAgregar, "Sólo se permiten números");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(txtClaveArticuloAgregar, "");
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
                errorP.SetError(numUpCantidad,"");
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

        private void frmAgregarFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
