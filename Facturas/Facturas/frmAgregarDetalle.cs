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
                string ClaveF=txtClaveFactura.Text, ClaveP=txtClaveProveedor.Text, ClaveA=txtClaveArticulo.Text;
                int ClaveFactura, ClaveProveedor, ClaveArticulo;

                if (ClaveF.Length == 0)
                {
                    MessageBox.Show("CLAVE DE FACTURA VACÍA", "CAMPO VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidaNumCadena(ClaveF))
                {
                    MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "SÓLO NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveFactura.ForeColor = Color.Red;
                    return;
                }
                try
                {
                    ClaveFactura = int.Parse(ClaveF);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveFactura.ForeColor = Color.Red;
                    return;
                }

                if (ClaveP.Length == 0)
                {
                    MessageBox.Show("CLAVE DE PROVEEDOR VACÍA", "CAMPO VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidaNumCadena(ClaveP))
                {
                    MessageBox.Show("CLAVE DE PROVEEDOR NO VÁLIDA", "SÓLO NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveProveedor.ForeColor = Color.Red;
                    return;
                }
                try
                {
                    ClaveProveedor = int.Parse(ClaveP);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("CLAVE DE PROVEEDOR NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveProveedor.ForeColor = Color.Red;
                    return;
                }
                if (proveedores.getPosClave(ClaveProveedor) == -1)
                {
                    MessageBox.Show("EL PROVEEDOR NO EXISTE", "PROVEEDOR NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveProveedor.ForeColor = Color.Red;
                    return;
                }
                txtClaveProveedor.ForeColor = Color.Green;
                if (mF.BuscaFacturaClaveProv(ClaveFactura, ClaveProveedor) == -1)
                {
                    MessageBox.Show("EL PROVEEDOR NO CUENTA CON LA FACTURA PROPORCIONADA", "NO SE ENCONTRÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveFactura.ForeColor = Color.Red;
                    return;
                }
                txtClaveFactura.ForeColor = Color.Green;
                if (mD.DetallesPorFactura(ClaveFactura) >= 3)
                {
                    MessageBox.Show("CAPTURA MÁXIMA DE ARTÍCULOS SUPERADA PARA ESTA FACTURA", "DETALLES MÁXIMOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (AdmA.pCount - mD.DetallesPorFactura(ClaveFactura) == 0)
                {
                    MessageBox.Show("NO SE PUEDEN CAPTURAR MAS ARTICULOS A ESTA FACTURA, AGREGUE MAS ARTICULOS AL CATALAGO", "SIN ARTÍCULOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveArticulo.ForeColor = Color.Red;
                    return;
                }
                if (ClaveA.Length == 0)
                {
                    MessageBox.Show("CLAVE DE ARTÍCULO VACÍA", "CAMPO VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidaNumCadena(ClaveA))
                {
                    MessageBox.Show("CLAVE DE ARTÍCULO NO VÁLIDA", "SÓLO NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveArticulo.ForeColor = Color.Red;
                    return;
                }
                try
                {
                    ClaveArticulo = int.Parse(ClaveA);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("CLAVE DE ARTÍCULO NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveArticulo.ForeColor = Color.Red;
                    return;
                }

                if (AdmA.BuscaArt(ClaveArticulo) == -1)
                {
                    MessageBox.Show("ARTÍCULO NO ENCONTRADO", "ARTÍCULO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveArticulo.ForeColor = Color.Red;
                    return;
                }
                if (mD.DetalleRepetido(ClaveFactura, ClaveArticulo) != -1)
                {
                    MessageBox.Show("ARTÍCULO YA CAPTUDARO PARA ESTA FACTURA", "ARTICULO REPETIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveArticulo.ForeColor = Color.Red;
                    return;
                }
                txtClaveArticulo.ForeColor = Color.Green;
                if (numUpCantidad.Value == 0)
                {
                    MessageBox.Show("CANTIDAD NO VÁLIDA", "CANTIDAD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int CantArt = (int)numUpCantidad.Value;
                Articulo A = AdmA.RetornaArticulo(ClaveArticulo);
                Factura F = mF.RetornaFactura(ClaveFactura);
                Proveedor P = proveedores.RetornaProveedorClave(ClaveProveedor);
                if (A.pCantidad - CantArt < 0)
                {
                    MessageBox.Show("EXISTENCIA NO SUFICIENTE PARA DICHA CANTIDAD", "SIN EXISTENCIA SUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                float Precio, TotalImp = 0;
                Precio = A.pPrecio;
                TotalImp = Precio * CantArt;
                mD.AgregarDetalle(ClaveFactura, ClaveArticulo, CantArt, Precio);
                F.pImporte += TotalImp;
                P.pSaldo += TotalImp;
                A.pCantidad -= CantArt;
                MessageBox.Show("\n----------DATDOS DEL DETALLE----------"+"\nCLAVE ARTÍCULO: "+A.pClave+ "\nDESCRIPCIÓN: "+A.pDescripcion+"\nCANTIDAD: "+CantArt+ "\nPRECIO UNITARIO: "+A.pPrecio+
                "\nEXISTENCIA RESTANTE: " + A.pCantidad+ "\nIMPORTE DE LA FACTURA: "+TotalImp+ "\nSALDO DEL PROVEEDOR: "+P.pSaldo, "DETALLE AGREGADO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void Valida_proveedor(object sender, EventArgs e)
        {
            string Proveedor = txtClaveProveedor.Text;
            if (!ValidaNumCadena(Proveedor))
            {
                errorP.SetError(txtClaveProveedor, "CLAVE DE PROVEEDOR NO VÁLIDA");
                txtClaveProveedor.Focus();
            }
            else
            {
                errorP.SetError(txtClaveProveedor, "");
            }
        }

        private void txtClaveProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(txtClaveProveedor, "SÓLO SE PERMITEN NÚMEROS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(txtClaveProveedor, "");
            }
        }

        private void Valida_factura(object sender, EventArgs e)
        {
            string ClaveFactura = txtClaveFactura.Text;
            if (!ValidaNumCadena(ClaveFactura))
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
                errorP.SetError(txtClaveFactura, "SÓLO SE PERMITEN NÚMEROS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(txtClaveFactura, "");
            }
        }

        private void Valida_articulo(object sender, EventArgs e)
        {
            string ClaveArticulo = txtClaveArticulo.Text;
            if (!ValidaNumCadena(ClaveArticulo))
            {
                errorP.SetError(txtClaveArticulo, "CLAVE DE ARTÍCULO NO VÁLIDA");
                txtClaveArticulo.Focus();
            }
            else
            {
                errorP.SetError(txtClaveArticulo, "");
            }
        }

        private void txtClaveArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(txtClaveArticulo, "SÓLO SE PERMITEN NÚMEROS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(txtClaveArticulo, "");
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
            txtClaveProveedor.Text = "";
            txtClaveFactura.Text = "";
            txtClaveArticulo.Text = "";
            numUpCantidad.Value = 0;
            txtClaveFactura.ForeColor = Color.Black;
            txtClaveProveedor.ForeColor = Color.Black;
            txtClaveArticulo.ForeColor = Color.Black;
        }

        private void brnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?","CERRAR VENTANA",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }
    }
}
