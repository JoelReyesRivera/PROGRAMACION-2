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
    public partial class frmModificaExistenciaArticulo : Form
    {
        private ManejaArticulos AdmA;
        List<Articulo> Art;

        public frmModificaExistenciaArticulo(ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.AdmA = AdmA;
            cmbArticulos.SelectedIndex = 0;
            //Art = AdmA.ObtenArt();
        }

        private void frmModificaExistenciaArticulo_Load(object sender, EventArgs e)
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
            }
            Con.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA GUARDAR LOS CAMBIOS?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.No)
                return;

            if(cmbArticulos.SelectedIndex == -1)
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUN ARTICULO", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Articulo = Convert.ToString(cmbArticulos.SelectedItem); int Cant = Convert.ToInt32(nudCantidad.Value);
            if (Cant < 1)
            {
                MessageBox.Show("LA CANTIDAD NO PUEDE SER MENOR A 1", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
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

            string strComando = "UPDATE Articulo SET Cantidad=Cantidad+@Cant WHERE Descripcion LIKE'"+Articulo+"'";

            SqlCommand Update= new SqlCommand(strComando, Con);

            Update.Parameters.AddWithValue("@Cant", Cant);

            try
            {
                Update.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Con.Close();
                return ;
            }
            Con.Close();
            
            MessageBox.Show("MODIFICACION EXITOSA", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA SALIR?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
                this.Close();
        }

        private void Limpiar()
        {
            cmbArticulos.SelectedIndex =0;
            nudCantidad.Value = 1;
            txtStock.Text = "";
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            int Cant = Convert.ToInt32(nudCantidad.Value);

            if (Cant == 0)
                Error.SetError(nudCantidad, "NUMERO FUERA DEL RANGO PERMITIDO");
            else
                Error.SetError(nudCantidad, "");
        }

        private void cmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedIndex == 0)
                return;

            string strConexion = Rutinas.GetConnectionString();
            string Desc = Convert.ToString(cmbArticulos.SelectedItem);

            SqlConnection Con = UsoBD.ConectaBD(strConexion);
            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT Cantidad FROM Articulo  WHERE Descripcion LIKE'"+Desc+"'";

            Lector = UsoBD.Consulta(strComandoC, Con);

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
                    txtStock.Text = Lector.GetValue(0).ToString();
                }
            }
            Con.Close();
        }
    }
}
