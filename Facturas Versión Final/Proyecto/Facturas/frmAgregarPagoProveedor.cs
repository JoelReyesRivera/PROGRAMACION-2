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
using System.Configuration;

namespace Facturas
{
    public partial class frmAgregarPagoProveedor : Form
    {
        ManejaProveedores proveedores;
        public frmAgregarPagoProveedor(ManejaProveedores proveedores)
        {
            InitializeComponent();
            this.proveedores = proveedores;
            cmbProveedores.SelectedIndex = -1;
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            string Conexion = Rutinas.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }
            DialogResult result = MessageBox.Show("¿DESEA REALIZAR EL PAGO?", "PAGO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string Proveedor = Convert.ToString(cmbProveedores.SelectedItem);
                string importeTexto = txtImporte.Text;
                float importe,saldo=0;
                int claveProveedor;
                DateTime Fecha = DateTime.Now;

                if (cmbProveedores.SelectedIndex == -1)
                {
                    MessageBox.Show("PROVEEDOR NO ENCONTRADO","PROVEEDOR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Limpiar();
                    return;
                }
                try
                {
                    importe = float.Parse(importeTexto);
                }
                catch (Exception)
                {
                    MessageBox.Show("IMPORTE INVALIDO", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (importe < 1)
                {
                    MessageBox.Show("IMPORTE INVALIDO", "PAGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                claveProveedor = proveedores.GetClave(Proveedor);
                string Query = "select Saldo from Proveedor where Clave = " + claveProveedor;
                SqlDataReader Lector = null;
                Lector = UsoBD.Consulta(Query, Conecta);
                if (Lector == null)
                {
                    MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                    foreach (SqlError Error in UsoBD.ESalida.Errors)
                        MessageBox.Show(Error.Message);
                    Conecta.Close();
                    return;
                }
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        try
                        {
                            saldo = float.Parse(Lector.GetValue(0).ToString());
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show("ERROR DE FORMATO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                Conecta.Close();
                if ((saldo - importe) < 0)
                {
                    MessageBox.Show("EL IMPORTE A PAGAR DEBE SER IGUAL O MENOR QUE EL SALDO ACTUAL","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

                string strComando = "INSERT INTO PagoProveedor(Proveedor,Fecha,Importe)";
                strComando += "VALUES(@ClaveProv,@Fecha,@Monto)";

                SqlCommand Insert = new SqlCommand(strComando, Con);

                Insert.Parameters.AddWithValue("@ClaveProv", claveProveedor);
                Insert.Parameters.AddWithValue("@Fecha", Fecha);
                Insert.Parameters.AddWithValue("@Monto", importe);

                try
                {
                    Insert.ExecuteNonQuery();
                }
                catch (SqlException Ex)
                {
                    foreach (SqlError item in Ex.Errors)
                        MessageBox.Show(item.Message);

                    Con.Close();
                    return;
                }
                Con.Close();
                MessageBox.Show("PAGO REALIZADO CORRECTAMENTE","PAGO REALIZADO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            cmbProveedores.Text = "";
            cmbProveedores.SelectedIndex = -1;
            txtClave.Text = "";
            txtImporte.Text = "";
            txtImporteActual.Text = "";
            errorP.Clear();
            errorProviderProveedores.Clear();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }
        private void txtClave_Validated(object sender, EventArgs e)
        {
            string P = txtClave.Text;
            if (!(Rutinas.ValidaTextoNum(P)))
            {
                errorProviderProveedores.SetError(txtClave, "SOLO DEBE TENER NÚMEROS");
                txtClave.Focus();
            }
            else
                errorProviderProveedores.SetError(txtClave, "");
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorProviderProveedores.SetError(txtClave, "EN ESTE APARTADO SOLO SE ACEPTAN NUMEROS");
                e.Handled = false;
            }
            else
                errorProviderProveedores.SetError(txtClave, "");
        }


        private void txtImporte_Validated(object sender, EventArgs e)
        {
            string P = txtImporte.Text;
            if (!(Rutinas.validadDecimal(P)))
            {
                errorProviderProveedores.SetError(txtImporte, "SOLO DEBE TENER NÚMEROS,  FORMATO (0.00)");
                txtImporte.Focus();
            }
            else
                errorProviderProveedores.SetError(txtImporte, "");
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(".") || e.KeyChar == 46)
            {
                return;
            }
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorProviderProveedores.SetError(txtImporte, "EN ESTE APARTADO SOLO SE ACEPTAN NUMEROS, FORMATO (0.00)");
                e.Handled = false;
            }
            else
                errorProviderProveedores.SetError(txtImporte, "");
        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedIndex < 0)
                return;
            string Conexion = Rutinas.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }
            string Nom = cmbProveedores.SelectedItem.ToString();
            string Query = "select Clave,Saldo from Proveedor where Nombre = " + "'" + Nom + "'";
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    string Clave = Lector.GetValue(0).ToString();
                    string Saldo = Lector.GetValue(1).ToString();

                    txtClave.Text = Clave;
                    txtImporteActual.Text = Saldo;
                }
            }
            Conecta.Close();
        }

        private void frmAgregarPagoProveedor_Load(object sender, EventArgs e)
        {
            string Conexion = Rutinas.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }

            string Query = "select Nombre from Proveedor";
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }
            if (Lector.HasRows)
            {
                cmbProveedores.Items.Clear();
                while (Lector.Read())
                    cmbProveedores.Items.Add(Lector.GetValue(0).ToString());
            }
            Conecta.Close();
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

        private void grpProveedor_Enter(object sender, EventArgs e)
        {

        }
    }
}
