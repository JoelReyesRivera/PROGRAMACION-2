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
    public partial class frmBuscarDetalle : Form
    {
        ManejaFacturas mF;
        ManejaDetalleFactura mD;
        ManejaProveedores proveedores;
        ManejaArticulos AdmA;

        public frmBuscarDetalle(ManejaDetalleFactura mD,ManejaFacturas mF, ManejaProveedores proveedores, ManejaArticulos AdmA)
        {
            InitializeComponent();
            cmbClaveFactura.SelectedIndex = -1;
            this.mD = mD;
            this.mF = mF;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void cmbClaveFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClaveFactura.SelectedIndex < 0)
                return;
            dvgBuscaDetalles.Rows.Clear();
            int ClaveFactura = Convert.ToInt32(cmbClaveFactura.SelectedItem);
            DetalleFactura[] D = mD.RetornaDetallesFactura(ClaveFactura);
            Articulo A;
            float ImporteDetalle = 0, ImporteTotal = 0;
            for (int i = 0; i < D.Length; i++)
            {
                if (D[i] != null)
                {
                    A = AdmA.RetornaArticulo(D[i].pClaveArt);
                    ImporteDetalle = D[i].pCant * A.pPrecio;
                    ImporteTotal += ImporteDetalle;
                    dvgBuscaDetalles.Rows.Add(D[i].pClaveArt, A.pDescripcion, D[i].pPrecio, D[i].pCant, ImporteDetalle);
                }
            }
            lblImporte.Text = ImporteTotal + "";
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
                dvgBuscaDetalles.Rows.Clear();
                lblImporte.Text = "";
                cmbClaveFactura.SelectedIndex = -1;
                cmbClaveFactura.Focus();
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
        private void frmBuscarDetalle_Load(object sender, EventArgs e)
        {
            KeyValuePair<int, Factura>[] Facturas = mF.RetornaFacturas();
            for (int i = 0; i < Facturas.Length; i++)
                cmbClaveFactura.Items.Add(Facturas[i].Key);

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            cmbClaveFactura.Text = "";
            cmbClaveFactura.SelectedIndex = -1;
            dvgBuscaDetalles.Rows.Clear();
            lblImporte.Text = "";
            errorP.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }

    }
}
