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
    public partial class frmAgregarDetalle : Form
    {
        ManejaFacturas mF;
        ManejaDetalleFactura mD;
        ManejaProveedores proveedores;
        ManejaArticulos AdmA;

        public frmAgregarDetalle(ManejaDetalleFactura mD, ManejaFacturas mF, ManejaProveedores proveedores, ManejaArticulos AdmA)
        {
            InitializeComponent();
            cmbClaveFactura.SelectedIndex = -1;
            cmbArticulo.SelectedIndex = -1;
            this.mD = mD;
            this.mF = mF;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA AGREGAR EL DETALLE?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                string ClaveF = Convert.ToString(cmbClaveFactura.SelectedItem); string Articulo=Convert.ToString(cmbArticulo.SelectedItem);
                int ClaveFactura, ClaveArticulo;

                if (cmbClaveFactura.SelectedIndex == -1)
                {
                    MessageBox.Show("FACTURA NO VÁLIDA", "FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                    return;
                }
                try
                {
                    ClaveFactura = int.Parse(ClaveF);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                    return;
                }
                if (mD.DetallesPorFactura(ClaveFactura) >= 3)
                {
                    MessageBox.Show("CAPTURA MÁXIMA DE ARTÍCULOS SUPERADA PARA ESTA FACTURA", "DETALLES MÁXIMOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (AdmA.CantidadArticulos() - mD.DetallesPorFactura(ClaveFactura) == 0)
                {
                    MessageBox.Show("NO SE PUEDEN CAPTURAR MAS ARTICULOS A ESTA FACTURA, AGREGUE MAS ARTICULOS AL CATALAGO", "SIN ARTÍCULOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbArticulo.SelectedIndex == -1)
                {
                    MessageBox.Show("ARTÍCULO NO VÁLIDO", "ARTÍCULO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ClaveArticulo = AdmA.BuscaClaveArt(Articulo);
                if (mD.DetalleRepetido(ClaveFactura, ClaveArticulo))
                {
                    MessageBox.Show("ARTÍCULO YA CAPTUDARO PARA ESTA FACTURA", "ARTICULO REPETIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (numUpCantidad.Value == 0)
                {
                    MessageBox.Show("CANTIDAD NO VÁLIDA", "CANTIDAD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int CantArt = (int)numUpCantidad.Value;
                int clave = AdmA.BuscaClaveArt(Articulo);
                Limpiar();
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
        private void cmbArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(cmbArticulo, "SÓLO SE PERMITEN LETRAS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(cmbArticulo, "");
            }
        }

        private void numUpCantidad_Validated(object sender, EventArgs e)
        {
            if (numUpCantidad.Value <= 0)
            {
                errorP.SetError(numUpCantidad, "DEBE SELECCIONAR AL MENOS 1 ARTICULO");
                numUpCantidad.Focus();
            }
            else
            {
                errorP.SetError(numUpCantidad, "");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            cmbClaveFactura.SelectedIndex = -1;
            cmbArticulo.SelectedIndex = -1;
            cmbClaveFactura.Text = "";
            cmbArticulo.Text = "";
            txtClaveProveedor.Text = "";
            txtProveedor.Text = "";
            txtImporte.Text = "";
            txtCantDetalles.Text = "";
            lblNumDetalles.Text = "";
            txtFecha.Text = "";
            numUpCantidad.Value = 0;
            txtClaveArt.Text ="";
            txtExistencia.Text ="";
            txtPrecio.Text = "";
        }

        private void brnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?","CERRAR VENTANA",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }

        private void frmAgregarDetalle_Load(object sender, EventArgs e)
        {
            KeyValuePair<int, Factura>[] Facturas = mF.RetornaFacturas();
            for (int i = 0; i < Facturas.Length; i++)
                cmbClaveFactura.Items.Add(Facturas[i].Key);

            List<Articulo> Articulos = AdmA.ObtenArt();
            for (int i = 0; i < Articulos.Count; i++)
                cmbArticulo.Items.Add(Articulos.ElementAt(i).pDescripcion);
        }

        private void cmbClaveFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClaveFactura.SelectedIndex <0)
                return;
            int ClaveFactura = Convert.ToInt32(cmbClaveFactura.SelectedItem);
            Factura F = mF.RetornaFactura(ClaveFactura);
            Proveedor P = proveedores.RetornaProveedorClave(F.pClaveProv);
            int NumDetalles = mD.DetallesPorFactura(ClaveFactura);
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
                Limpiar();
                cmbClaveFactura.SelectedIndex = -1;
                cmbClaveFactura.Focus();
            }
            else
            {
                errorP.SetError(cmbClaveFactura, "");
            }
        }

        private void cmbArticulo_Validated(object sender, EventArgs e)
        {
            bool flag = false;
            string Articulo = cmbArticulo.Text;
            string Elemento = "";
            for (int i = 0; i < cmbArticulo.Items.Count; i++)
            {
                Elemento = cmbArticulo.GetItemText(cmbArticulo.Items[i]);
                if (Elemento.CompareTo(Articulo) == 0)
                {
                    flag = true;
                    cmbArticulo.SelectedIndex = i;
                }
            }
            if (!flag)
            {
                errorP.SetError(cmbArticulo, "ARTÍCULO NO ENCONTRADO");
                txtClaveArt.Text = "";
                txtExistencia.Text = "";
                txtPrecio.Text = "";
                cmbArticulo.SelectedIndex = -1;
                cmbArticulo.Focus();
            }
            else
            {
                errorP.SetError(cmbArticulo, "");
            }
        }
        private void lblNumDetalles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ClaveFactura = Convert.ToInt32(cmbClaveFactura.SelectedItem);
            frmVistaBuscaFactura VistaDetalles = new frmVistaBuscaFactura(mD, AdmA, ClaveFactura);
            VistaDetalles.ShowDialog();
        }

        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulo.SelectedIndex < 0)
                return;
            string Articulo = Convert.ToString(cmbArticulo.SelectedItem);
            int ClaveArticulo = AdmA.BuscaClaveArt(Articulo);
            Articulo A = AdmA.RetornaArticulo(ClaveArticulo);
            txtClaveArt.Text = A.pClave+"";
            txtExistencia.Text = A.pCantidad+"";
            txtPrecio.Text = A.pPrecio+"";
        }
    }
}
