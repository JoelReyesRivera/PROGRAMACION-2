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
    public partial class frmConsultaProvedor : Form
    {
        ManejaProveedores proveedores;
        public frmConsultaProvedor(ManejaProveedores proveedores)
        {
            InitializeComponent();
            this.proveedores = proveedores;
            cmbProveedores.SelectedIndex = -1;
            CargarCmd();
        }

        public void CargarCmd()
        {
            Proveedor[] array = proveedores.GetProveedores();
            foreach (var item in array)
            {
                cmbProveedores.Items.Add(item.pNombre);
            }
        }
        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedIndex < 0)
                return;
            String nombre= cmbProveedores.SelectedItem.ToString();
            Proveedor proveedor = proveedores.RetornaProveedorNom(nombre);
            txtClave.Text = String.Format(""+proveedores.GetClave(nombre));
            txtRFC.Text = proveedor.pRFC;
            txtSueldo.Text = String.Format("" + proveedor.pSaldo);
            txtDomicilio.Text = proveedor.pDomicilio;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA SALIR?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
                this.Close();
        }

        private void cmbNombre_Validated(object sender, EventArgs e)
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
                txtClave.Text = "";
                txtDomicilio.Text = "";
                txtRFC.Text = "";
                txtSueldo.Text = "";
                cmbProveedores.SelectedIndex = -1;
                cmbProveedores.Focus();
            }
            else
            {
                errorP.SetError(cmbProveedores, "");
            }
        }

        private void cmbNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            cmbProveedores.Text = "";
            cmbProveedores.SelectedIndex = -1;
            txtClave.Text = "";
            txtDomicilio.Text = "";
            txtRFC.Text = "";
            txtSueldo.Text = "";
            errorP.Clear();
        }
    }
}
