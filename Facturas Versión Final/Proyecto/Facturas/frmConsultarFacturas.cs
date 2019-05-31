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
            cmbFacturas.Items.Clear();
            dtgvDetalles.Rows.Clear();
            dtgvFacturas.Rows.Clear();
            cmbFacturas.Text = "";
            cargarDataGridViewFacturas();
            cargarCmbFacturas();
        }

        public void cargarCmbFacturas()
        {
            cmbFacturas.Items.Clear();
            string nombre = cmbProveedores.SelectedItem.ToString();
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

            string strComando = "SELECT F.CLAVE FROM FACTURA  F INNER JOIN Proveedor P ON P.Clave=f.provedor where P.Nombre='"+nombre+"'";

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
                    cmbFacturas.Items.Add(Lector.GetValue(0).ToString());
                Con.Close();
                return;
            }
            cmbFacturas.SelectedIndex = -1;
        }

        public void cargarDataGridViewFacturas()
        {
            dtgvFacturas.Rows.Clear();
            string nombre = cmbProveedores.SelectedItem.ToString();
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

            string strComando = "select f.clave,p.clave,p.Nombre,f.monto,format(f.fecha,'dd/MM/yyyy') from Factura f inner join Proveedor p on f.provedor=p.Clave where p.Nombre ='" + nombre + "'";

            Lector = UsoBD.Consulta(strComando, Con);

            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return;
            }
            int clave = 0;
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    clave = int.Parse(Lector.GetValue(1).ToString());
                    dtgvFacturas.Rows.Add(Lector.GetValue(0).ToString(), Lector.GetValue(1).ToString(), Lector.GetValue(2).ToString(), Lector.GetValue(3).ToString(), Lector.GetValue(4).ToString());
                }
            }
            Con.Close();
        }
        public void cargarCmbProveedores()
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

            string strComando = "SELECT nombre FROM proveedor ORDER BY nombre ASC";

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
                    cmbProveedores.Items.Add(Lector.GetValue(0).ToString());
                Con.Close();
                return;
            }
            cmbProveedores.SelectedIndex = -1;
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
            cargarDataGridViewDetalles();
        }

        public void cargarDataGridViewDetalles()
        {
            dtgvDetalles.Rows.Clear();
            string factura = cmbFacturas.SelectedItem.ToString();
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

            string strComando = "select d.Factura,d.Articulo,a.descripcion,a.marca,d.Cantidad,d.Precio,(d.Cantidad*d.Precio)  from DetalleFactura d inner join Articulo a on a.clave = d.Articulo where d.Factura = " + factura;

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
                    dtgvDetalles.Rows.Add(Lector.GetValue(0).ToString(), Lector.GetValue(1).ToString(), Lector.GetValue(2).ToString(), Lector.GetValue(3).ToString(), Lector.GetValue(4).ToString(), Lector.GetValue(5).ToString(), Lector.GetValue(6).ToString());
                }
            }
            Con.Close();
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
