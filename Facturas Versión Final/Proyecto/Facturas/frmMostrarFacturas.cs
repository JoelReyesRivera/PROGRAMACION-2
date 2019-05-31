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
    public partial class frmMostrarFacturas : Form
    {
        ManejaFacturas mF;
        ManejaProveedores proveedores;

        public frmMostrarFacturas(ManejaFacturas mF, ManejaProveedores proveedores)
        {
            InitializeComponent();
            this.mF = mF;
            this.proveedores = proveedores;
        }

        private void frmMostrarFacturas_Load(object sender, EventArgs e)
        {
            dgvFacturas.Rows.Clear();
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

            string strComando = "select f.clave,p.clave,p.Nombre,f.monto,format(f.fecha,'dd/MM/yyyy') from Factura f inner join Proveedor p on f.provedor=p.Clave";

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
                    dgvFacturas.Rows.Add(Lector.GetValue(0).ToString(), Lector.GetValue(1).ToString(), Lector.GetValue(2).ToString(), Lector.GetValue(3).ToString(), Lector.GetValue(4).ToString());
                }
            }
            Con.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }
    }
}
