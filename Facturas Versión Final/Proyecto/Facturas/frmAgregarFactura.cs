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
            cmbArticulo.SelectedIndex = -1;
            cmbProveedores.SelectedIndex = -1;
            this.mF = mF;
            this.mD = mD;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA AGREGAR LA FACTURA?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                string ClaveF = Convert.ToString(txtClaveFactura.Text); string Proveedor = Convert.ToString(cmbProveedores.SelectedItem);
                string ClaveA= Convert.ToString(cmbArticulo.SelectedItem);
                int ClaveFactura; int ClaveProveedor;

                if (ClaveF.Length == 0)
                {
                    MessageBox.Show("CLAVE DE FACTURA VACÍA", "CAMPO VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Rutinas.ValidaTextoNum(ClaveF))
                {
                    MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "SÓLO NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    ClaveFactura = int.Parse(ClaveF);

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
                ClaveProveedor = proveedores.BuscarPosNombre(Proveedor);
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
            txtClaveFactura.Text = "";
            cmbProveedores.Text = "";
            cmbProveedores.SelectedIndex = -1;
            txtClave.Text = "";
            cmbArticulo.Text = "";
            cmbArticulo.SelectedIndex = -1;
            txtClave.Text = "";
            txtClaveArt.Text = "";
            txtPrecio.Text = "";
            txtExistencia.Text = "";
            numUpCantidad.Value = 1;
            lvArticulos.Items.Clear();
            lblImporte.Text = "$0";
            errorP.Clear();

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            string ClaveF = Convert.ToString(txtClaveFactura), ClaveP = Convert.ToString(cmbProveedores.SelectedItem); string Articulo = Convert.ToString(cmbArticulo.SelectedItem);
            int ClaveArticulo;
            if (ClaveF.Length == 0)
            {
                MessageBox.Show("NO PUEDE AGREGAR ARTICULOS SI NO TIENE UNA FACTURA", "SIN FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbProveedores.SelectedIndex == -1)
            {
                MessageBox.Show("PROVEEDOR NO ENCONTRADO","PROVEEDOR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (cmbArticulo.SelectedIndex == -1)
            {
                MessageBox.Show("ARTÍCULO NO ENCONTRADO","ARTÍCULO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int CantArt = lvArticulos.Items.Count;
            if (CantArt >= 3)
            {
                MessageBox.Show("NO SE PUEDE AGRGAR MÁS DE 3 TIPOS DIFERENTES DE ARTICULOS", "ARTICULOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClaveArticulo = AdmA.BuscaClaveArt(Articulo); ;
            Articulo Art = AdmA.RetornaArticulo(ClaveArticulo);

            int Cant = Convert.ToInt32(numUpCantidad.Value); float PrecioTotal = Cant * Art.pPrecio; 

            for (int i = 0; i < lvArticulos.Items.Count; i++) //BUSCA SI EL ARTICULO YA ESTA AGREGADO EN EL LIST VIEW
            {
                if (lvArticulos.Items[i].Text.Trim() == ClaveArticulo.ToString())
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
                    float rp;
                    try
                    {
                        rp = Convert.ToInt32(lvArticulos.Items[i].SubItems[5].Text); //PRECIO DEL ARTICULO REGISTRADO
                    }
                    catch (Exception)
                    {
                        return;
                    }
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
            ListViewItem Registro = new ListViewItem(ClaveArticulo.ToString());
            Registro.SubItems.Add(Art.pDescripcion);
            Registro.SubItems.Add(Art.pMarca);
            Registro.SubItems.Add(Art.pPrecio.ToString());
            Registro.SubItems.Add(Cant.ToString());
            Registro.SubItems.Add(PrecioTotal.ToString());
            //AGREGA LA LISTA CON TODOS LOS DATOS DEL ARTICULO EN EL LIST VIEW
            lvArticulos.Items.Add(Registro);
            CalculaImporte();
        }

        private float CalculaImporte()
        {
            int Count = lvArticulos.Items.Count;  float Importe = 0;
            if (Count==0)
            {
                lblImporte.Text = "$0";
            }
            else
            {
                for (int i = 0; i < Count; i++)
                {
                    float Cantidad = Convert.ToSingle(lvArticulos.Items[i].SubItems[5].Text);
                    Importe += Cantidad;
                    lblImporte.Text = "$" + Importe;
                }
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }

        private void frmAgregarFactura_Load(object sender, EventArgs e)
        {
            Proveedor[] P = proveedores.GetProveedores();
            for (int i = 0; i < P.Length; i++)
                cmbProveedores.Items.Add(P[i].pNombre);

            List<Articulo> Articulos = AdmA.ObtenArt();
            for (int i = 0; i < Articulos.Count; i++)
                cmbArticulo.Items.Add(Articulos.ElementAt(i).pDescripcion);

        }
        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedIndex < 0)
                return;
            string Proveedor = Convert.ToString(cmbProveedores.SelectedItem);
            int ClaveProv = proveedores.BuscarPosNombre(Proveedor);
            KeyValuePair<int, Proveedor> P = proveedores.RetornaProveedor(ClaveProv);
            txtClave.Text = P.Key + "";
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
                txtClave.Text = "";
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

        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulo.SelectedIndex < 0)
                return;
            string Articulo = Convert.ToString(cmbArticulo.SelectedItem);
            int ClaveArticulo = AdmA.BuscaClaveArt(Articulo);
            Articulo A = AdmA.RetornaArticulo(ClaveArticulo);
            txtClaveArt.Text = A.pClave + "";
            txtExistencia.Text = A.pCantidad + "";
            txtPrecio.Text = A.pPrecio + "";
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

        private void txtClaveFactura_Validated(object sender, EventArgs e)
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
                errorP.SetError(txtClaveFactura, "SÓLO SE PERMITEN NÚMEROS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(txtClaveFactura, "");
            }
        }
    }
}
