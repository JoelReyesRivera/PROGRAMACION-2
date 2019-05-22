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
    public partial class frmBuscarFactura : Form
    {
        ManejaFacturas mF;
        ManejaDetalleFactura mD;
        ManejaProveedores proveedores;
        ManejaArticulos AdmA;

        public frmBuscarFactura(ManejaFacturas mF, ManejaDetalleFactura mD, ManejaProveedores proveedores,ManejaArticulos AdmA)
        {
            InitializeComponent();
            cmbClaveFactura.SelectedIndex = -1;
            this.mF = mF;
            this.mD = mD;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void frmBuscarFactura_Load(object sender, EventArgs e)
        {
            KeyValuePair<int, Factura>[] Facturas = mF.RetornaFacturas();
            for (int i = 0; i < Facturas.Length; i++)
                cmbClaveFactura.Items.Add(Facturas[i].Key);
        }
        
        private void lblNumDetalles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ClaveFactura = Convert.ToInt32(cmbClaveFactura.SelectedItem);
            frmVistaBuscaFactura VistaDetalles = new frmVistaBuscaFactura(mD,AdmA,ClaveFactura);
            VistaDetalles.ShowDialog();
        }
        private void Limpiar()
        {
            cmbClaveFactura.Text = "";
            cmbClaveFactura.SelectedIndex = -1;
            txtClaveProveedor.Text = "";
            txtProveedor.Text = "";
            txtFecha.Text = "";
            txtCantDetalles.Text = "";
            lblNumDetalles.Text = "";
            txtImporte.Text = "";
            lblFact.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void lblNumDetalles_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }

        private void cmbClaveFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClaveFactura.SelectedIndex < 0)
                return;
            int ClaveFactura = Convert.ToInt32(cmbClaveFactura.SelectedItem);
            Factura F = mF.RetornaFactura(ClaveFactura);
            Proveedor P = proveedores.RetornaProveedorClave(F.pClaveProv);
            int NumDetalles = mD.DetallesPorFactura(ClaveFactura);
            lblFact.Text = ClaveFactura+"";
            txtClaveProveedor.Text = F.pClaveProv + "";
            txtProveedor.Text = P.pNombre;
            txtImporte.Text = F.pImporte + "";
            txtFecha.Text = Rutinas.ConvierteFecha(F.pDia, F.pMes, F.pAño);
            lblNumDetalles.Text = NumDetalles + "";
        }

        private void cmbClaveFactura_Validated(object sender, EventArgs e)
        {
            bool flag = false;
            string ClaveFactura = cmbClaveFactura.Text;
            string Elemento = "";
            for (int i = 0; i < cmbClaveFactura.Items.Count; i++)
            {
                Elemento = cmbClaveFactura.GetItemText(cmbClaveFactura.Items[i]);
                if (Elemento.CompareTo(ClaveFactura) == 0)
                {
                    flag = true;
                    cmbClaveFactura.SelectedIndex = i;
                }
            }
            if (!flag)
            {
                errorP.SetError(cmbClaveFactura, "FACTURA NO ENCONTRADA");
                cmbClaveFactura.SelectedIndex = -1;
                cmbClaveFactura.Focus();
                Limpiar();
            }
            else
            {
                errorP.SetError(cmbClaveFactura, "");
            }
        }

        private void cmbClaveFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(cmbClaveFactura, "SÓLO SE PERMITEN NÚMEROS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(cmbClaveFactura, "");
            }
        }
    }
}
