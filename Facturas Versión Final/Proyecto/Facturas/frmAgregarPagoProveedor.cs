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
            cmbProveedores.SelectedIndex = -1;
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿DESEA REALIZAR EL PAGO?", "PAGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string Proveedor = Convert.ToString(cmbProveedores.SelectedItem);
                string importeTexto = txtImporte.Text;
                float importe;
                int claveProveedor;

                if (cmbProveedores.SelectedIndex == -1)
                {
                    MessageBox.Show("PROVEEDOR NO ENCONTRADO","PROVEEDOR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Limpiar();
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
                if (importe < 1)
                {
                    MessageBox.Show("IMPORTE INVALIDO", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                claveProveedor = proveedores.GetClave(Proveedor);
                Proveedor proveedor = proveedores.RetornaProveedorClave(claveProveedor);
                if (proveedor.pSaldo - importe < 0)
                {
                    MessageBox.Show("IMPORTE INVALIDO; EL IMPORTE DEBE SER IGUAL O MENOR QUE $" + proveedor.pSaldo, "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                proveedor.pSaldo = proveedor.pSaldo - importe;
                MessageBox.Show("SALDO NUEVO DE PROVEEDOR " + proveedor.pNombre + ": $" + proveedor.pSaldo, "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("PAGO REALIZADO CORRECTAMENTE", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            cmbProveedores.Text = "";
            cmbProveedores.SelectedIndex = -1;
            txtClave.Text = "";
            txtImporte.Text = "";
            txtImporteActual.Text = "";
            errorP.Clear();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }
        private void txtClave_Validated(object sender, EventArgs e)
        {
            string P = txtClave.Text;
            if (!(Rutinas.ValidaTextoNum(P)))
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


        private void txtImporte_Validated(object sender, EventArgs e)
        {
            string P = txtImporte.Text;
            if (!(Rutinas.validadDecimal(P)))
            {
                errorProviderProveedores.SetError(txtImporte, "SOLO DEBE TENER NÚMEROS,  FORMATO (0.00)");
                txtImporte.Focus();
            }
            else
                errorProviderProveedores.SetError(txtImporte, "");
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(".") || e.KeyChar == 46)
            {
                return;
            }
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorProviderProveedores.SetError(txtImporte, "EN ESTE APARTADO SOLO SE ACEPTAN NUMEROS, FORMATO (0.00)");
                e.Handled = false;
            }
            else
                errorProviderProveedores.SetError(txtImporte, "");
        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedIndex < 0)
                return;
            string Proveedor = Convert.ToString(cmbProveedores.SelectedItem);
            int ClaveProv = proveedores.BuscarPosNombre(Proveedor);
            KeyValuePair<int, Proveedor> P = proveedores.RetornaProveedor(ClaveProv);
            txtClave.Text = P.Key+"";
            txtImporteActual.Text = P.Value.pSaldo + "";
        }

        private void frmAgregarPagoProveedor_Load(object sender, EventArgs e)
        {
            Proveedor[] P = proveedores.GetProveedores();
            for (int i = 0; i < P.Length; i++)
                cmbProveedores.Items.Add(P[i].pNombre);
        }

        private void cmbProveedores_Validated(object sender, EventArgs e)
        {
            bool flag = false;
            string Proveedor = cmbProveedores.Text;
            string Elemento = "";
            for (int i = 0; i < cmbProveedores.Items.Count; i++)
            {
                Elemento = cmbProveedores.GetItemText(cmbProveedores.Items[i]);
                if (Elemento.CompareTo(Proveedor) == 0)
                {
                    flag = true;
                    cmbProveedores.SelectedIndex = i;
                }
            }
            if (!flag)
            {
                errorP.SetError(cmbProveedores, "PROVEEDOR NO ENCONTRADO");
                cmbProveedores.SelectedIndex = -1;
                cmbProveedores.Focus();
            }
            else
            {
                errorP.SetError(cmbProveedores, "");
            }
        }

        private void cmbProveedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(cmbProveedores, "SÓLO SE PERMITEN LETRAS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(cmbProveedores, "");
            }
        }
    }
}
