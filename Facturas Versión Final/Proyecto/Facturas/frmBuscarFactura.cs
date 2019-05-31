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
    public partial class frmBuscarFactura : Form
    {
        ManejaFacturas mF;
        ManejaDetalleFactura mD;
        ManejaProveedores proveedores;
        ManejaArticulos AdmA;

        public frmBuscarFactura(ManejaFacturas mF, ManejaDetalleFactura mD, ManejaProveedores proveedores,ManejaArticulos AdmA)
        {
            InitializeComponent();
            cmbClaveFactura.SelectedIndex = -1;
            this.mF = mF;
            this.mD = mD;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void frmBuscarFactura_Load(object sender, EventArgs e)
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
        
        private void lblNumDetalles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int ClaveFactura = Convert.ToInt32(cmbClaveFactura.SelectedItem);
            frmVistaBuscaFactura VistaDetalles = new frmVistaBuscaFactura(mD,AdmA,ClaveFactura);
            VistaDetalles.ShowDialog();
        }
        private void Limpiar()
        {
            cmbClaveFactura.Text = "";
            cmbClaveFactura.SelectedIndex = -1;
            txtClaveProveedor.Text = "";
            txtProveedor.Text = "";
            txtFecha.Text = "";
            txtCantDetalles.Text = "";
            lblNumDetalles.Text = "";
            txtImporte.Text = "";
            lblFact.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void lblNumDetalles_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }

        private void cmbClaveFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClaveFactura.SelectedIndex < 0)
                return;
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

            string strComando = "select p.clave,p.Nombre,f.monto,format(f.fecha,'dd/MM/yyyy') from Factura f inner join Proveedor p on f.provedor=p.Clave where f.clave =" + claveFactura;

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
                    txtClaveProveedor.Text = Lector.GetValue(0).ToString();
                    txtProveedor.Text = Lector.GetValue(1).ToString();
                    txtImporte.Text = Lector.GetValue(2).ToString();
                    txtFecha.Text = Lector.GetValue(3).ToString();
                }
            }
            Con.Close();
            int factura = int.Parse(claveFactura);
            txtCantDetalles.Text = String.Format(""+mD.DetallesPorFactura(factura));
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
                cmbClaveFactura.SelectedIndex = -1;
                cmbClaveFactura.Focus();
                Limpiar();
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
    }
}
