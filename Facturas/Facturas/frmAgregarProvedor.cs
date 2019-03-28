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
                if (!ValidaTextbox(txtClave) || !ValidaTextbox(txtNombre) || !ValidaTextbox(txtDomicilio) || !ValidaTextbox(txtRFC))
                {
                    MessageBox.Show("CAMPO VACÍO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                String domicilio, RFC, nombre;
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
                nombre = txtNombre.Text;
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
                domicilio = txtDomicilio.Text;
                RFC = txtRFC.Text;
                proveedores.AgregaProveedor(clave,RFC,nombre,domicilio);
                MessageBox.Show("PROVEEDOR AGREGADO EXITOSAMENTE", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            if (result == DialogResult.No)
                return;
        }
        public bool ValidaTextbox(TextBox textBox)
        {
            if (textBox.Text!="")
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
    }
}
