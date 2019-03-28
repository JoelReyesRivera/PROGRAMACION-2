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
            CargarCmd();
        }

        public void CargarCmd()
        {
            Proveedor[] array = proveedores.GetProveedores();
            foreach (var item in array)
            {
                cmbNombre.Items.Add(item.pNombre);
            }
        }
        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nombre= cmbNombre.SelectedItem.ToString();
            Proveedor proveedor = proveedores.RetornaProveedorNom(nombre);
            txtClave.Text = String.Format(""+proveedores.GetClave(nombre));
            txtRFC.Text = proveedor.pRFC;
            txtSueldo.Text = String.Format("" + proveedor.pSaldo);
            txtDomicilio.Text = proveedor.pDomicilio;
        }
    }
}
