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
    public partial class frmConsultaArticulo : Form
    {
        private ManejaArticulos AdmA;
        public frmConsultaArticulo(ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.AdmA = AdmA;
            cmbArticulos.SelectedIndex = 0;
        }

        private void frmConsultaArticulo_Load(object sender, EventArgs e)
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

            string strComando = "SELECT Descripcion FROM Articulo ORDER BY Descripcion ASC";

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
                    cmbArticulos.Items.Add(Lector.GetValue(0).ToString());

                Con.Close();
                return;
            }
            Con.Close();
        }

        private void cmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedIndex == 0)
            {
                lblDescripcion.Text = "";
                lblMarca.Text = "";
                lblPrecio.Text = "";
                lblCantidad.Text = "";
            }
            else
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

                string Desc = cmbArticulos.SelectedItem.ToString();

                string strComando = "SELECT Descripcion,Marca,Precio,Cantidad FROM Articulo WHERE Descripcion LIKE'"+Desc+"'";

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
                        lblDescripcion.Text = Lector.GetValue(0).ToString();
                        lblMarca.Text = Lector.GetValue(1).ToString();
                        lblPrecio.Text = Lector.GetValue(2).ToString();
                        lblCantidad.Text = Lector.GetValue(3).ToString();
                    }
                }
                Con.Close();
            }
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
            cmbArticulos.SelectedIndex = 0;
            lblDescripcion.Text = "";
            lblMarca.Text = "";
            lblPrecio.Text = "";
            lblCantidad.Text = "";
        }

    }
}
