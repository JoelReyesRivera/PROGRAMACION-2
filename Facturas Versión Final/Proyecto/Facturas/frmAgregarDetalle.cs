using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBD;

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
                mD.AgregarDetalle(ClaveFactura,clave,CantArt);
                MessageBox.Show("DETALLE AGREGADO CORRECTAMENTE", "DETALLE FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void cargarCmbFacturas()
        {
            string strConexion = Rutinas.GetConnectionString();
            SqlConnection Con = UsoBD.ConectaBD(strConexion);

            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }

            SqlDataReader Lector = null;

            string strComando = "SELECT CLAVE FROM FACTURA ORDER BY CLAVE ASC";

            Lector = UsoBD.Consulta(strComando, Con);

            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                    cmbClaveFactura.Items.Add(Lector.GetValue(0).ToString());
                Con.Close();
                return;
            }
        }
        public void cargarCmbArticulos()
        {
            string strConexion = Rutinas.GetConnectionString();
            SqlConnection Con = UsoBD.ConectaBD(strConexion);

            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }

            string strComando = "SELECT Descripcion FROM ARTICULO ORDER BY Descripcion ASC";

            SqlDataReader Lector2 = UsoBD.Consulta(strComando, Con);

            if (Lector2 == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return;
            }
            if (Lector2.HasRows)
            {
                while (Lector2.Read())
                    cmbArticulo.Items.Add(Lector2.GetValue(0).ToString());
                Con.Close();
                return;
            }
            Con.Close();
        }
        private void frmAgregarDetalle_Load(object sender, EventArgs e)
        {
            cargarCmbArticulos();
            cargarCmbFacturas();
        }

        private void cmbClaveFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClaveFactura.SelectedIndex <0)
                return;
            string clave = cmbClaveFactura.SelectedItem.ToString();
            int claveFactura;
            try
            {
                claveFactura = int.Parse(clave);
            }
            catch (Exception)
            {
                return;
            }
            string strConexion = Rutinas.GetConnectionString();
            SqlConnection Con = UsoBD.ConectaBD(strConexion);

            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }

            SqlDataReader Lector = null;

            string strComando = "SELECT clave,Provedor,format(Fecha	,'dd/MM/yyyy'),monto FROM FACTURA where clave = " + clave;

            Lector = UsoBD.Consulta(strComando, Con);

            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return;
            }
            if (Lector.HasRows)
            {
                int proveedor=0, factura = 0;
                while (Lector.Read())
                {
                    try
                    {
                        proveedor = int.Parse(Lector.GetValue(1).ToString());
                        factura = int.Parse(Lector.GetValue(0).ToString());
                    }
                    catch (Exception)
                    {
                        
                    }
                    txtClaveProveedor.Text = String.Format(" " + proveedor);
                    txtImporte.Text = Lector.GetValue(3).ToString();
                    txtProveedor.Text = proveedores.getNombreProveedor(proveedor);
                    txtFecha.Text = Lector.GetValue(2).ToString();
                    txtCantDetalles.Text = String.Format(" " + mD.DetallesPorFactura(factura));
                    Con.Close();
                    return;
                }
            }

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
            int ClaveFactura;
            try
            {
                ClaveFactura= Convert.ToInt32(cmbClaveFactura.SelectedItem);
            }
            catch (Exception)
            {
                return;
            }
            frmVistaBuscaFactura VistaDetalles = new frmVistaBuscaFactura(mD, AdmA, ClaveFactura);
            VistaDetalles.ShowDialog();
        }

        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulo.SelectedIndex < 0)
                return;
            string descripcion = cmbArticulo.SelectedItem.ToString();

            string strConexion = Rutinas.GetConnectionString();
            SqlConnection Con = UsoBD.ConectaBD(strConexion);

            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }

            SqlDataReader Lector = null;

            string strComando = "SELECT * from articulo where descripcion = '" + descripcion+ "'";

            Lector = UsoBD.Consulta(strComando, Con);

            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    txtClaveArt.Text = Lector.GetValue(0).ToString();
                    txtPrecio.Text = Lector.GetValue(3).ToString();
                    txtExistencia.Text = Lector.GetValue(4).ToString();
                    Con.Close();
                    return;
                }
            }
            Con.Close();
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (cmbClaveFactura.SelectedIndex<0)
            {
                MessageBox.Show("FACTURA NO SELECCIONADA", "DETALLES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ClaveFactura= Convert.ToInt32(cmbClaveFactura.SelectedItem);
            frmVistaBuscaFactura VistaDetalles = new frmVistaBuscaFactura(mD, AdmA, ClaveFactura);
            VistaDetalles.ShowDialog();
        }
    }
}
