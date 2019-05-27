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
    public partial class frmConsultaProveedores : Form
    {
        ManejaProveedores proveedores;
        public frmConsultaProveedores(ManejaProveedores proveedores)
        {
            InitializeComponent();
            this.proveedores = proveedores;
        }

        private void frmConsultaProveedores_Load(object sender, EventArgs e)
        {
            dtgvProveedores.Rows.Clear();
            string Conexion = Rutinas.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("ERROR CONECTANDO CON LA BASE DE DATOS");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }
            string Query = "select Clave,Nombre,RFC,Domicilio,Saldo from Proveedor";
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR REALIZANDO CONSULTA");
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
                    string Nombre = Lector.GetValue(1).ToString();
                    string RFC = Lector.GetValue(2).ToString();
                    string Domicilio = Lector.GetValue(3).ToString();
                    string Saldo = Lector.GetValue(4).ToString();

                    dtgvProveedores.Rows.Add(Clave, Nombre, RFC, Domicilio, Saldo);
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

    }
}
