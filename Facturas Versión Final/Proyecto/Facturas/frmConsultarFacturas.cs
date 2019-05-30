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
    public partial class frmConsultarFacturas : Form
    {
        public ManejaProveedores proveedores;
        public ManejaArticulos articulos;
        public ManejaDetalleFactura detalles;
        public ManejaFacturas facturas;

        public frmConsultarFacturas(ManejaProveedores proveedores, ManejaArticulos articulos, ManejaDetalleFactura detalles, ManejaFacturas facturas)
        {
            InitializeComponent();
            this.proveedores = proveedores;
            this.articulos = articulos;
            this.detalles = detalles;
            this.facturas = facturas;
            cargarCmbProveedores();
            cmbProveedores.SelectedIndex = -1;
        }


        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedIndex < 0)
                return;
            String textoProveedor = cmbProveedores.SelectedItem.ToString();
            cargarCmbFacturas(proveedores.GetClave(textoProveedor));
            cargarDataGridViewFacturas(proveedores.GetClave(textoProveedor));
            dtgvDetalles.Rows.Clear();
        }

        public void cargarCmbFacturas(int proveedor)
        {
            cmbFacturas.Items.Clear();
            KeyValuePair<int,Factura> [] lista = facturas.RetornaFacturas();
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i].Value.pClaveProv==proveedor)
                {
                    cmbFacturas.Items.Add(lista[i].Key);
                }
            }
            cmbFacturas.SelectedIndex = -1;
        }

        public void cargarDataGridViewFacturas(int proveedor)
        {
            dtgvFacturas.Rows.Clear();
            KeyValuePair<int, Factura>[] lista = facturas.RetornaFacturas();
            Proveedor proveedor1 = proveedores.RetornaProveedorClave(proveedor);
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i].Value.pClaveProv == proveedor)
                {
                    dtgvFacturas.Rows.Add(lista[i].Key,lista[i].Value.pClaveProv, proveedor1.pNombre,lista[i].Value.pImporte, lista[i].Value.pDia+"/"+ lista[i].Value.pMes +"/"+ lista[i].Value.pAño);
                }
            }
        }
        public void cargarCmbProveedores()
        {
            cmbFacturas.Items.Clear();
            Proveedor [] array =proveedores.GetProveedores();
            for (int i = 0; i < array.Length; i++)
            {
                cmbProveedores.Items.Add(array[i].pNombre);
            }
        }

        private void cmbFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFacturas.SelectedIndex < 0)
                return;

            String facturaTexto = cmbFacturas.SelectedItem.ToString();
            int factura;
            try
            {
                factura = int.Parse(facturaTexto);
            }
            catch (Exception)
            {
                MessageBox.Show("FACTURA INVÁLIDA", "FACTURAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cargarDataGridViewDetalles(factura);
        }

        public void cargarDataGridViewDetalles(int factura)
        {
           /* dtgvDetalles.Rows.Clear();
            List<DetalleFactura> lista = detalles.RetornaDetalles();
            Articulo articulo;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].pClaveFact == factura)
                {
                    articulo = articulos.RetornaArticulo(lista[i].pClaveArt);
                    dtgvDetalles.Rows.Add(factura, lista[i].pClaveArt,articulo.pDescripcion,articulo.pMarca, lista[i].pCant,lista[i].pPrecio);
                }
            }
            */
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA SALIR?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
                this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            cmbProveedores.Text = "";
            cmbProveedores.SelectedIndex = -1;
            dtgvFacturas.Rows.Clear();
            cmbFacturas.Text = "";
            cmbFacturas.SelectedIndex = -1;
            dtgvDetalles.Rows.Clear();
            errorP.Clear();

        }

        private void cmbProveedores_Validated(object sender, EventArgs e)
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
                cmbProveedores.SelectedIndex = -1;
                cmbProveedores.Focus();
            }
            else
            {
                errorP.SetError(cmbProveedores, "");
            }
        }

        private void cmbProveedores_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbFacturas_Validated(object sender, EventArgs e)
        {
            bool flag = false;
            string ClaveFactura = cmbFacturas.Text;
            string Elemento = "";
            for (int i = 0; i < cmbFacturas.Items.Count; i++)
            {
                Elemento = cmbFacturas.GetItemText(cmbFacturas.Items[i]);
                if (Elemento.CompareTo(ClaveFactura) == 0)
                {
                    flag = true;
                    cmbFacturas.SelectedIndex = i;
                }
            }
            if (!flag)
            {
                errorP.SetError(cmbFacturas, "FACTURA NO ENCONTRADA");
                cmbFacturas.SelectedIndex = -1;
                cmbFacturas.Focus();
            }
            else
            {
                errorP.SetError(cmbFacturas, "");
            }
        }

        private void cmbFacturas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(cmbFacturas, "SÓLO SE PERMITEN NÚMEROS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(cmbFacturas, "");
            }
        }
    }
}
