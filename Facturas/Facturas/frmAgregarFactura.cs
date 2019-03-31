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
    public partial class frmAgregarFactura : Form
    {
        ManejaFacturas mF;
        ManejaDetalleFactura mD;
        ManejaProveedores proveedores;
        ManejaArticulos AdmA;

        public frmAgregarFactura(ManejaFacturas mF, ManejaDetalleFactura mD, ManejaProveedores proveedores, ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.mF = mF;
            this.mD = mD;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //HACER EL DETALLE FACTURA
            DialogResult D = MessageBox.Show("¿DESEA AGREGAR LA FACTURA?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                int ClaveFactura, ClaveProveedor; string ClaveF = txtClaveFactura.Text, ClaveP = txtClaveProveedor.Text;

                if (ClaveF.Length == 0)
                {
                    MessageBox.Show("CLAVE DE FACTURA VACÍA", "CAMPO VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidaNumCadena(ClaveF))
                {
                    MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "SÓLO NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    ClaveFactura = int.Parse(txtClaveFactura.Text);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (mF.BuscaFacturaClave(ClaveFactura) != -1)
                {
                    MessageBox.Show("LA FACTURA YA EXISTE", "CLAVE FACTURA DUPLICADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    return;
                }
                try
                {
                    ClaveProveedor = int.Parse(txtClaveProveedor.Text);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("CLAVE DE PROVEEDOR NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (proveedores.getPosClave(ClaveProveedor) == -1)
                {
                    MessageBox.Show("EL PROVEEDOR NO EXISTE", "PROVEEDOR NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int CantArt = lvArticulos.Items.Count;
                if (CantArt == 0)
                {
                    MessageBox.Show("NO SE PUEDE GUARDAR LA FACTURA, NO HAY ARTICULOS SELECCIONADOS", "SIN ARTICULOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime fecha = DateTime.Now;
                mF.AgregarFactura(ClaveFactura, ClaveProveedor, fecha.Day, fecha.Month, fecha.Year);
                Factura F=mF.RetornaFactura(ClaveFactura);
                Proveedor P = proveedores.RetornaProveedorClave(ClaveProveedor);

                //CREA DETALLE FACTURA POR CADA DIFERENTE TIPO DE ARTICULO
                for (int i = 0; i < lvArticulos.Items.Count; i++)
                {
                    int ClaveArt = Convert.ToInt32(lvArticulos.Items[i].Text);
                    int Cant = Convert.ToInt32(lvArticulos.Items[i].SubItems[4].Text);
                    Articulo Art = AdmA.RetornaArticulo(ClaveArt);
                    Art.pCantidad -= Cant;
                    float Precio = Convert.ToSingle(lvArticulos.Items[i].SubItems[3].Text);
                    mD.AgregarDetalle(ClaveFactura, ClaveArt, Cant, Precio);
                }
                float Importe = CalculaImporte();
                F.pImporte += Importe;
                P.pSaldo += Importe;
                MessageBox.Show("FACTURA CREADA CORRECTAMENTE CON SUS " + CantArt + " DETALLES DE FACTURA", "FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void Valida_Factura(object sender, EventArgs e)
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
        private void Valida_claveartAgrega(object sender, EventArgs e)
        {
            string ClaveArticulo = txtClaveArticuloAgregar.Text;
            if (!ValidaNumCadena(ClaveArticulo))
            {
                errorP.SetError(txtClaveArticuloAgregar, "CLAVE DE ARTÍCULO NO VÁLIDA");
                txtClaveArticuloAgregar.Focus();
            }
            else
            {
                errorP.SetError(txtClaveArticuloAgregar, "");
            }
        }

        private void txtClaveArticuloAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(txtClaveArticuloAgregar, "SÓLO SE PERMITEN NÚMEROS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(txtClaveArticuloAgregar, "");
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
            errorP.Clear();
            txtClaveFactura.Text = "";
            txtClaveProveedor.Text = "";
            txtClaveArticuloAgregar.Text = "";
            numUpCantidad.Value = 1;
            lvArticulos.Items.Clear();
            lblImporte.Text = "$0";
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            string ClaveF = txtClaveFactura.Text, ClaveP = txtClaveProveedor.Text;
            if (ClaveF.Length == 0)
            {
                MessageBox.Show("NO PUEDE AGREGAR ARTICULOS SI NO TIENE UNA FACTURA", "SIN FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ClaveP.Length == 0)
            {
                MessageBox.Show("NO PUEDE AGREGAR ARTICULOS SI NO TIENE UNA PROVEEDOR", "SIN PROVEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int CantArt = lvArticulos.Items.Count;
            if (CantArt >= 3)
            {
                MessageBox.Show("NO SE PUEDE AGRGAR MÁS DE 3 TIPOS DIFERENTES DE ARTICULOS", "ARTICULOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ClaveArticulo; string ClaveA = txtClaveArticuloAgregar.Text;

            if (ClaveA.Length == 0)
            {
                MessageBox.Show("CLAVE DEL ARTICULO VACÍA", "CAMPO VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidaNumCadena(ClaveA))
            {
                MessageBox.Show("CLAVE DEL ARTICULO NO VÁLIDA", "SÓLO NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ClaveArticulo = Convert.ToInt32(txtClaveArticuloAgregar.Text);

            }
            catch (Exception Ex)
            {
                MessageBox.Show("CLAVE DEL ARTICULO NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AdmA.BuscaArt(ClaveArticulo) == -1)
            {
                MessageBox.Show("CLAVE DE ARTICULO INEXISTENTE", "ARTICULO INEXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Articulo Art = AdmA.RetornaArticulo(ClaveArticulo);

            int Cant = Convert.ToInt32(numUpCantidad.Value); float PrecioTotal = Cant * Art.pPrecio; 

            for (int i = 0; i < lvArticulos.Items.Count; i++) //BUSCA SI EL ARTICULO YA ESTA AGREGADO EN EL LIST VIEW
            {
                if (lvArticulos.Items[i].Text.Trim() == ClaveA)
                {
                    int rc = Convert.ToInt32(lvArticulos.Items[i].SubItems[4].Text); //CANTIDAD DEL ARTICULO REGISTRADO
                    int SumCant = Art.pCantidad - (rc + Cant);
                    if (SumCant < 0)
                    {
                        MessageBox.Show("LA EXISTENCIA DEL ARTICULO NO ES LA SUFICIENTE PARA LA CANTIDAD INGRESADA", "EXISTENCIA INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int cf = rc + Cant; //CANTIDAD FINAL
                    lvArticulos.Items[i].SubItems[4].Text = cf.ToString();
                    float rp = Convert.ToInt32(lvArticulos.Items[i].SubItems[5].Text); //PRECIO DEL ARTICULO REGISTRADO
                    float pf = PrecioTotal + rp; //PRECIO FINAL
                    lvArticulos.Items[i].SubItems[5].Text = pf.ToString();
                    CalculaImporte();
                    return;
                }
            }
            //SI EL ARTICULO A AGREGAR NO SE ENCUENTRA EN LA LIST VIEW 
            int DifCant = Art.pCantidad - Cant;
            if (DifCant < 0)
            {
                MessageBox.Show("LA EXISTENCIA DEL ARTICULO NO ES LA SUFICIENTE PARA LA CANTIDAD INGRESADA", "EXISTENCIA INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //AGREGA LOS DATOS DEL ARTICULO EN UNA LISTA
            ListViewItem Registro = new ListViewItem(ClaveA);
            Registro.SubItems.Add(Art.pDescripcion);
            Registro.SubItems.Add(Art.pModelo);
            Registro.SubItems.Add(Art.pPrecio.ToString());
            Registro.SubItems.Add(Cant.ToString());
            Registro.SubItems.Add(PrecioTotal.ToString());
            //AGREGA LA LISTA CON TODOS LOS DATOS DEL ARTICULO EN EL LIST VIEW
            lvArticulos.Items.Add(Registro);
            CalculaImporte();
        }

        private float CalculaImporte()
        {
            float Importe = 0;
            for (int i = 0; i < lvArticulos.Items.Count; i++)
            {
                float Cantidad = Convert.ToSingle(lvArticulos.Items[i].SubItems[5].Text);
                Importe += Cantidad;
                lblImporte.Text = "$" + Importe;
            }
            return Importe;
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            if (lvArticulos.SelectedItems.Count == 0)
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUN ARTICULO", "SIN SELECCIONAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult R = MessageBox.Show("¿DESEA ELIMINAR EL ARTICULO SELECCIONADO?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                 for (int i = 0; i < lvArticulos.Items.Count; i++)
                 {
                     if (lvArticulos.SelectedItems.Contains(lvArticulos.Items[i]))
                         lvArticulos.Items[i].Remove();
                 }
                CalculaImporte();
            }
        } 
    }
}
