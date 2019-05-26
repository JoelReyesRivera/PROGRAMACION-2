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
    public partial class frmConsultaArticulos : Form
    {
        private ManejaArticulos AdmA;

        public frmConsultaArticulos(ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.AdmA = AdmA;
        }

        private void frmConsultaArticulos_Load(object sender, EventArgs e)
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

            string strComando = "SELECT Clave,Descripcion,Marca,Precio,Cantidad FROM Articulo ORDER BY Clave";

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
                    this.dgwArticulos.Rows.Add(Lector.GetValue(0).ToString(), Lector.GetValue(1).ToString(), Lector.GetValue(2).ToString(), Lector.GetValue(3).ToString(), Lector.GetValue(4).ToString());
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
