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
        ManejaFacturas mF;
        ManejaDetalleFactura mD;
        ManejaProveedores proveedores;
        ManejaArticulos AdmA;

        public frmAgregarFactura(ManejaFacturas mF, ManejaDetalleFactura mD, ManejaProveedores proveedores, ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.mF = mF;
            this.mD = mD;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA AGREGAR LA FACTURA?","CONFIRMAR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                int ClaveFactura;
                int ClaveProveedor;
                if (txtClaveFactura.Text.Length == 0)
                {
                    MessageBox.Show("CLAVE DE FACTURA VACÍA","CAMPO VACÍO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (!ValidaNumCadena(txtClaveFactura.Text))
                {
                    MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA","SÓLO NÚMEROS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    ClaveFactura = int.Parse(txtClaveFactura.Text);

                }catch (Exception Ex)
                {
                    MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (mF.BuscaFacturaClave(ClaveFactura) != -1)
                {
                    MessageBox.Show("LA FACTURA YA EXISTE", "CLAVE FACTURA DUPLICADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtClaveProveedor.Text.Length == 0)
                {
                    MessageBox.Show("CLAVE DE PROVEEDOR VACÍA","CAMPO VACÍO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (!ValidaNumCadena(txtClaveProveedor.Text))
                {
                    MessageBox.Show("CLAVE DE PROVEEDOR NO VÁLIDA", "SÓLO NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    ClaveProveedor = int.Parse(txtClaveProveedor.Text);

                }catch (Exception Ex)
                {
                    MessageBox.Show("CLAVE DE PROVEEDOR NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (proveedores.getPosClave(ClaveProveedor) == -1)
                {
                    MessageBox.Show("EL PROVEEDOR NO EXISTE", "PROVEEDOR NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime fecha = DateTime.Now;
                mF.AgregarFactura(ClaveFactura, ClaveProveedor, fecha.Day, fecha.Month, fecha.Year);
                MessageBox.Show("FACTURA CREADA CORRECTAMENTE","FACTURA",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Valida_Factura(object sender, EventArgs e)
        {
            string ClaveFactura = txtClaveFactura.Text;
            if (!ValidaNumCadena(ClaveFactura))
            {
                errorP.SetError(txtClaveFactura, "CLAVE DE FACTURA NO VÁLIDA");
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
                errorP.SetError(txtClaveFactura, "SÓLO SE PERMITEN NÚMEROS");
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
                errorP.SetError(txtClaveProveedor, "CLAVE DE PROVEEDOR NO VÁLIDA");
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
                errorP.SetError(txtClaveProveedor, "SÓLO SE PERMITEN NÚMEROS");
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
                errorP.SetError(txtClaveArticuloEliminar, "CLAVE DE ARTÍCULO NO VÁLIDA");
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
                errorP.SetError(txtClaveArticuloEliminar, "SÓLO SE PERMITEN NÚMEROS");
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
                errorP.SetError(txtClaveArticuloAgregar, "CLAVE DE ARTÍCULO NO VÁLIDA");
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
                errorP.SetError(txtClaveArticuloAgregar, "SÓLO SE PERMITEN NÚMEROS");
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
