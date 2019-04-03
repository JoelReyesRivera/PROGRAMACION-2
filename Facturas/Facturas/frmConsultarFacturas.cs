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
        }


        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            String textoProveedor = cmbProveedores.SelectedItem.ToString();
            cargarCmbFacturas(proveedores.GetClave(textoProveedor));
            cargarDataGridViewFacturas(proveedores.GetClave(textoProveedor));
            dtgvDetalles.Rows.Clear();
        }

        public void cargarCmbFacturas(int proveedor)
        {
            cmbFacturas.Items.Clear();
            cmbFacturas.Items.Add("-FACTURAS-");
            KeyValuePair<int,Factura> [] lista = facturas.RetornaFacturas();
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i].Value.pClaveProv==proveedor)
                {
                    cmbFacturas.Items.Add(lista[i].Key);
                }
            }
            cmbFacturas.SelectedIndex = 0;
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
            cmbProveedores.Items.Add("-PROVEEDORES-");
            cmbProveedores.SelectedIndex = 0;
            Proveedor [] array =proveedores.GetProveedores();
            for (int i = 0; i < array.Length; i++)
            {
                cmbProveedores.Items.Add(array[i].pNombre);
            }
        }

        private void cmbFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFacturas.SelectedIndex!=0)
            {
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
        }

        public void cargarDataGridViewDetalles(int factura)
        {
            dtgvDetalles.Rows.Clear();
            List<DetalleFactura> lista = detalles.RetornaDetalles();
            Articulo articulo;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].pClaveFact == factura)
                {
                    articulo = articulos.RetornaArticulo(lista[i].pClaveArt);
                    dtgvDetalles.Rows.Add(factura, lista[i].pClaveArt,articulo.pDescripcion,articulo.pModelo,lista[i].pCant,lista[i].pPrecio);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA SALIR?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
                this.Close();
        }
    }
}
