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
            this.mD = mD;
            this.mF = mF;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dvgBuscaDetalles.Rows.Clear();
            lblImporte.Text = "";
            string ClaveFact = txtClaveFactura.Text;
            int ClaveFactura;

            if (ClaveFact.Length == 0)
            {
                MessageBox.Show("CLAVE DE FACTURA VACÍA", "CAMPO NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidaNumCadena(ClaveFact))
            {
                MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "SÓLO NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ClaveFactura = int.Parse(ClaveFact);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mF.BuscaFacturaClave(ClaveFactura) == -1)
            {
                MessageBox.Show("LA FACTURA NO EXISTE", "FACTURA NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DetalleFactura[] D = mD.RetornaDetallesFactura(ClaveFactura);
            Articulo A;
            float ImporteDetalle = 0,ImporteTotal=0;
            for (int i = 0; i < D.Length; i++)
            {
                if (D[i] != null)
                {
                    A = AdmA.RetornaArticulo(D[i].pClaveArt);
                    ImporteDetalle = D[i].pCant * A.pPrecio;
                    ImporteTotal += ImporteDetalle;
                    dvgBuscaDetalles.Rows.Add(D[i].pClaveArt,A.pDescripcion,D[i].pPrecio,D[i].pCant,ImporteDetalle);
                }
            }
            lblImporte.Text = ImporteDetalle + "";
        }
        private void frmBuscarDetalle_Load(object sender, EventArgs e)
        {

        }

        private void Valida_factura(object sender, EventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtClaveFactura.Text = "";
            lblImporte.Text = "";
            dvgBuscaDetalles.Rows.Clear();
        }
    }
}
