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
    public partial class frmAgregarPagoProveedor : Form
    {
        ManejaProveedores proveedores;
        public frmAgregarPagoProveedor(ManejaProveedores proveedores)
        {
            InitializeComponent();
            this.proveedores = proveedores;
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿DESEA REALIZAR EL PAGO?", "PAGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                String clave = txtClave.Text, importeTexto = txtImporte.Text;
                int claveProveedor;
                float importe;
                try
                {
                    claveProveedor = int.Parse(clave);
                }
                catch (Exception)
                {
                    MessageBox.Show("CLAVE INVÁLIDA", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!proveedores.ClaveExistente(claveProveedor))
                {
                    MessageBox.Show("LA CLAVE INGRESADA NO LE PERTENECE A NINGUN PROVEEDOR", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    importe = float.Parse(importeTexto);
                }
                catch (Exception)
                {
                    MessageBox.Show("IMPORTE INVALIDO", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Proveedor proveedor = proveedores.RetornaProveedorClave(claveProveedor);
                txtNombre.Text = proveedor.pNombre;
                lblImporteSaldoActual.Text = String.Format("" + proveedor.pSaldo);
                if (proveedor.pSaldo - importe < 0)
                {
                    MessageBox.Show("IMPORTE INVALIDO; EL IMPORTE DEBE SER IGUAL O MENOR QUE $" + proveedor.pSaldo, "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                proveedor.pSaldo = proveedor.pSaldo - importe;
                MessageBox.Show("SALDO NUEVO DE PROVEEDOR $" + clave + ": " + proveedor.pSaldo, "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("PAGO REALIZADO CORRECTAMENTE", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtClave.Text = "";
            txtImporte.Text = "";
            txtNombre.Text = "";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String clave = txtClave.Text, importeTexto = txtImporte.Text;
            int claveProveedor;
            try
            {
                claveProveedor = int.Parse(clave);
            }
            catch (Exception)
            {
                MessageBox.Show("CLAVE INVÁLIDA", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!proveedores.ClaveExistente(claveProveedor))
            {
                MessageBox.Show("LA CLAVE INGRESADA NO LE PERTENECE A NINGUN PROVEEDOR", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Proveedor proveedor = proveedores.RetornaProveedorClave(claveProveedor);
            txtNombre.Text = proveedor.pNombre;
            lblImporteSaldoActual.Text = String.Format("" + proveedor.pSaldo);
        }

        private void txtClave_Validated(object sender, EventArgs e)
        {
            string P = txtClave.Text;
            if (!(ValidaTextoNum(P)))
            {
                errorProviderProveedores.SetError(txtClave, "SOLO DEBE TENER NÚMEROS");
                txtClave.Focus();
            }
            else
                errorProviderProveedores.SetError(txtClave, "");
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorProviderProveedores.SetError(txtClave, "EN ESTE APARTADO SOLO SE ACEPTAN NUMEROS");
                e.Handled = false;
            }
            else
                errorProviderProveedores.SetError(txtClave, "");
        }

        private bool ValidaCadena(string Cadena)
        {
            foreach (char C in Cadena)
            {
                if (!(Char.IsLetter(C)))
                    return false;
            }
            return true;
        }

        private bool ValidaTextoNum(string Cadena)
        {
            foreach (char C in Cadena)
            {
                if (C < '0' || C > '9')
                    return false;
            }
            return true;
        }

        private void txtImporte_Validated(object sender, EventArgs e)
        {
            string P = txtImporte.Text;
            if (!(ValidaTextoNum(P)))
            {
                errorProviderProveedores.SetError(txtImporte, "SOLO DEBE TENER NÚMEROS");
                txtImporte.Focus();
            }
            else
                errorProviderProveedores.SetError(txtImporte, "");
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorProviderProveedores.SetError(txtImporte, "EN ESTE APARTADO SOLO SE ACEPTAN NUMEROS");
                e.Handled = false;
            }
            else
                errorProviderProveedores.SetError(txtImporte, "");
        }
    }
}
