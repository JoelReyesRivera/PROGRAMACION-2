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
            if (!ValidaNumCadena(ClaveFact))
            {
                MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "SÓLO NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ClaveFactura = int.Parse(ClaveFact);
            }catch(Exception Ex)
            {
                MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mF.BuscaFacturaClave(ClaveFactura) == -1)
            {
                MessageBox.Show("LA FACTURA NO EXISTE", "FACTURA NO ENCONTRADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            DetalleFactura[] D = mD.RetornaDetallesFactura(ClaveFactura);
            Articulo A;
            string Detalles = "--------- DETALLES DE LA FACTURA ----------\n";
            for (int i = 0; i < D.Length; i++)
            {
                if (D[i] != null)
                {
                    A = AdmA.RetornaArticulo(D[i].pClaveArt);
                    Detalles += "\n***DETALLE " + (i + 1) + "\nClAVE ARTÍCULO: " + D[i].pClaveArt + "\nDESCRIPCIÓN: " + A.pDescripcion + "\nPRECIO UNITARIO: " + A.pPrecio + "\nCANTIDAD: " + D[i].pCant + "\n";
                }
            }
            MessageBox.Show(Detalles, "DETALLES DE LA FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void Limpiar()
        {
            txtClaveProveedor.Text = "";
            txtClaveFactura.Text = "";
            txtFecha.Text = "";
            txtProveedor.Text = "";
            txtImporte.Text = "";
            lblNumDetalles.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void lblNumDetalles_Click(object sender, EventArgs e)
        {

        }
    }
}
