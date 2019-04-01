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
    public partial class frmAgregarProvedor : Form
    {
        ManejaProveedores proveedores;

        public frmAgregarProvedor(ManejaProveedores proveedores)
        {
            InitializeComponent();
            this.proveedores = proveedores;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿DESEA GUARDAR?", "GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                String domicilio, RFC, nombre, claveTexto;
                domicilio = txtDomicilio.Text;
                RFC = txtRFC.Text;
                nombre = txtNombre.Text;
                claveTexto = txtClave.Text;
                if (!ValidaTexto(claveTexto) || !ValidaTexto(nombre) || !ValidaTexto(domicilio) || !ValidaTexto(RFC))
                {
                    MessageBox.Show("CAMPO VACÍO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int clave=0;
                try
                {
                    clave = int.Parse(txtClave.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("CLAVE INVÁLIDA", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (proveedores.ClaveExistente(clave))
                {
                    MessageBox.Show("CLAVE YA EXISTENTE", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (proveedores.NombreExistente(nombre))
                {
                    MessageBox.Show("NOMBRE YA EXISTENTE", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                proveedores.AgregaProveedor(clave,RFC,nombre,domicilio);
                MessageBox.Show("PROVEEDOR AGREGADO EXITOSAMENTE", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            if (result == DialogResult.No)
                return;
        }
        public bool ValidaTexto( String texto)
        {
            if (texto != "")
            {
                return true;
            }
            return false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txtClave.Text = "";
            txtDomicilio.Text = "";
            txtNombre.Text = "";
            txtRFC.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿DESEA SALIR?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            if (result == DialogResult.No)
                return;
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorProviderProveedores.SetError(txtNombre, "EN ESTE APARADO SOLO SE ACEPTAN LETRAS");
                e.Handled = false;
            }
            else
                errorProviderProveedores.SetError(txtNombre, "");
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            string M = txtNombre.Text;
            if (!ValidaCadena(M))
            {
                errorProviderProveedores.SetError(txtNombre, "NOMBRE ESCRITO EN FORMA INCORRECTA");
                txtNombre.Focus();
            }
            else
                errorProviderProveedores.SetError(txtNombre, "");
        }
    }

}
