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
    public partial class frmConsultaProvedor : Form
    {
        ManejaProveedores proveedores;
        public frmConsultaProvedor(ManejaProveedores proveedores)
        {
            InitializeComponent();
            this.proveedores = proveedores;
            cmbProveedores.SelectedIndex = -1;
        }
        private void frmConsultaProvedor_Load(object sender, EventArgs e)
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
            MessageBox.Show("CONECTADO A LA BASE DE DATOS");
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
        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
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
            string Query = "select Clave,RFC,Domicilio,Saldo from Proveedor where Nombre = " + "'" + Nom + "'";
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
                    string RFC = Lector.GetValue(1).ToString();
                    string Domicilio = Lector.GetValue(2).ToString();
                    string Saldo = Lector.GetValue(3).ToString();

                    txtClave.Text = Clave;
                    txtRFC.Text = RFC;
                    txtDomicilio.Text = Domicilio;
                    txtSueldo.Text =Saldo;
                }
            }
            Conecta.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA SALIR?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
                this.Close();
        }

        private void cmbNombre_Validated(object sender, EventArgs e)
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
                txtDomicilio.Text = "";
                txtRFC.Text = "";
                txtSueldo.Text = "";
                cmbProveedores.SelectedIndex = -1;
                cmbProveedores.Focus();
            }
            else
            {
                errorP.SetError(cmbProveedores, "");
            }
        }

        private void cmbNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            cmbProveedores.Text = "";
            cmbProveedores.SelectedIndex = -1;
            txtClave.Text = "";
            txtDomicilio.Text = "";
            txtRFC.Text = "";
            txtSueldo.Text = "";
            errorP.Clear();
        }
    }
}
