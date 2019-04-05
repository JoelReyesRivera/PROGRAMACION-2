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
            this.mF = mF;
            this.mD = mD;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void frmBuscarFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ClaveFact = txtClaveFactura.Text;
            int ClaveFactura;

            if (ClaveFact.Length == 0)
            {
                MessageBox.Show("CLAVE DE FACTURA VACÍA", "CAMPO NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Rutinas.ValidaTextoNum(ClaveFact))
            {
                MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "SÓLO NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClaveFactura.ForeColor = Color.Red;
                return;
            }
            try
            {
                ClaveFactura = int.Parse(ClaveFact);
            }catch(Exception Ex)
            {
                MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClaveFactura.ForeColor = Color.Red;
                return;
            }
            if (mF.BuscaFacturaClave(ClaveFactura) == -1)
            {
                MessageBox.Show("LA FACTURA NO EXISTE", "FACTURA NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClaveFactura.ForeColor = Color.Red;
                return;
            }
            txtClaveFactura.ForeColor = Color.Green;
            Factura F = mF.RetornaFactura(ClaveFactura);
            Proveedor P = proveedores.RetornaProveedorClave(F.pClaveProv);
            int NumDetalles = mD.DetallesPorFactura(ClaveFactura);
            txtClaveProveedor.Text = F.pClaveProv+"";
            txtProveedor.Text = P.pNombre;
            txtImporte.Text = F.pImporte+"";
            txtFecha.Text = Rutinas.ConvierteFecha(F.pDia, F.pMes, F.pAño);
            lblNumDetalles.Text = NumDetalles + "";
            
                

        }
        private void lblNumDetalles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ClaveFactura = int.Parse(txtClaveFactura.Text);
            frmVistaBuscaFactura VistaDetalles = new frmVistaBuscaFactura(mD,AdmA,ClaveFactura);
            VistaDetalles.ShowDialog();
        }
        private void Limpiar()
        {
            txtClaveProveedor.Text = "";
            txtClaveFactura.Text = "";
            txtFecha.Text = "";
            txtProveedor.Text = "";
            txtImporte.Text = "";
            lblNumDetalles.Text = "";
            txtClaveFactura.ForeColor = Color.Black;
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

        private void Valida_factura(object sender, EventArgs e)
        {
            string ClaveFactura = txtClaveFactura.Text;
            if (!Rutinas.ValidaTextoNum(ClaveFactura))
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
                errorP.SetError(txtClaveFactura, "CLAVE DE FACTURA NO VÁLIDA");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(txtClaveFactura, "");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }
    }
}
