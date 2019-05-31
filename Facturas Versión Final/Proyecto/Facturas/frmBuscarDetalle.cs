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
    public partial class frmBuscarDetalle : Form
    {
        ManejaFacturas mF;
        ManejaDetalleFactura mD;
        ManejaProveedores proveedores;
        ManejaArticulos AdmA;

        public frmBuscarDetalle(ManejaDetalleFactura mD,ManejaFacturas mF, ManejaProveedores proveedores, ManejaArticulos AdmA)
        {
            InitializeComponent();
            cmbClaveFactura.SelectedIndex = -1;
            this.mD = mD;
            this.mF = mF;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void cmbClaveFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            dvgBuscaDetalles.Rows.Clear();
            string claveFactura = cmbClaveFactura.SelectedItem.ToString();
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

            string strComando = "select a.clave,a.descripcion,d.Precio,d.Cantidad,(d.Precio*d.Cantidad),f.monto from DetalleFactura d inner join Articulo a on d.Articulo=a.clave inner join Factura f on f.clave = d.Factura where d.Factura = " + claveFactura;

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
                    dvgBuscaDetalles.Rows.Add(Lector.GetValue(0).ToString(), Lector.GetValue(1).ToString(), Lector.GetValue(2).ToString(), Lector.GetValue(3).ToString(), Lector.GetValue(4).ToString());
                    lblImporteTexto.Text = "Importe total para la factura: $"+Lector.GetValue(5).ToString();
                }
            }
            Con.Close();
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
                dvgBuscaDetalles.Rows.Clear();
                lblImporte.Text = "";
                cmbClaveFactura.SelectedIndex = -1;
                cmbClaveFactura.Focus();
            }
            else
            {
                errorP.SetError(cmbClaveFactura, "");
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
        private void frmBuscarDetalle_Load(object sender, EventArgs e)
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
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            cmbClaveFactura.Text = "";
            cmbClaveFactura.SelectedIndex = -1;
            dvgBuscaDetalles.Rows.Clear();
            lblImporte.Text = "";
            errorP.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }

    }
}
