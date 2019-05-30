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
    public partial class frmVistaBuscaFactura : Form
    {
        private ManejaDetalleFactura mD;
        private ManejaArticulos AdmA;
        int ClaveFactura;

        public frmVistaBuscaFactura(ManejaDetalleFactura mD,ManejaArticulos AdmA,int ClaveFactura)
        {
            InitializeComponent();
            this.mD = mD;
            this.AdmA = AdmA;
            this.ClaveFactura = ClaveFactura;
        }

        private void frmVistaBuscaFactura_Load(object sender, EventArgs e)
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

            string strComando = "select a.Clave,a.Descripcion,d.Precio,d.Cantidad from DetalleFactura d inner join Articulo a on a.Clave=d.Articulo where d.Factura= " + ClaveFactura;

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
                    dvgDetalles.Rows.Add(Lector.GetValue(0).ToString(), Lector.GetValue(1).ToString(), Lector.GetValue(2).ToString(), Lector.GetValue(3).ToString());
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
    }
}
