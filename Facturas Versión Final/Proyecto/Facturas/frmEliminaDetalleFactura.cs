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
    public partial class frmEliminaDetalleFactura : Form
    {
        public frmEliminaDetalleFactura()
        {
            InitializeComponent();
        }

        private void frmEliminaDetalleFactura_Load(object sender, EventArgs e)
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
                     cmbFactura.Items.Add(Lector.GetValue(0).ToString());
                Con.Close();
                return;
            }
        }

        private void cmbFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDetalleFactura.Items.Clear();

            if (cmbFactura.SelectedIndex < 0)
                return;

            string strConexion = Rutinas.GetConnectionString();
            SqlConnection Con = UsoBD.ConectaBD(strConexion);
            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Con.Close();
                return;
            }

            string Fact = cmbFactura.SelectedItem.ToString();
            string Query = "SELECT P.Nombre,P.Clave FROM Factura F INNER JOIN Proveedor P ON F.Provedor=P.Clave WHERE F.Clave="+Fact;
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Con);

            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Con.Close();
                return;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    string Nombre = Lector.GetValue(0).ToString();
                    string Clave = Lector.GetValue(1).ToString();
                    txtProveedor.Text = Nombre;
                    txtClaveP.Text = Clave;
                }
            }
            Con.Close();

            string CA="", Art="", Cant="", Pre="";
            string Conexion = Rutinas.GetConnectionString();

            SqlConnection Con2 = UsoBD.ConectaBD(Conexion);
            if (Con2 == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            SqlDataReader Lector2 = null;

            string strComando = "SELECT A.Clave,A.Descripcion,DF.Cantidad,DF.Precio FROM DetalleFactura DF ";
                   strComando += "INNER JOIN Articulo A ON DF.Articulo = A.Clave WHERE DF.Factura = "+Fact+"ORDER BY DF.Factura";

            Lector2 = UsoBD.Consulta(strComando, Con2);

            if (Lector2 == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con2.Close();
                return;
            }
            if (Lector2.HasRows)
            {
                while (Lector2.Read())
                {
                    CA = Lector2.GetValue(0).ToString();
                    Art = Lector2.GetValue(1).ToString();
                    Cant = Lector2.GetValue(2).ToString();
                    Pre= Lector2.GetValue(3).ToString();

                    ListViewItem Registro = new ListViewItem(Fact);
                    Registro.SubItems.Add(CA);
                    Registro.SubItems.Add(Art);
                    Registro.SubItems.Add(Cant);
                    Registro.SubItems.Add(Pre);

                    lvDetalleFactura.Items.Add(Registro);

                }
            }
            Con2.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            cmbFactura.SelectedIndex = -1;
            txtProveedor.Text = "";
            txtClaveP.Text = "";
            lvDetalleFactura.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvDetalleFactura.SelectedItems.Count == 0)
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUN DETALLE DE FACTURA", "SIN SELECCIONAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult R = MessageBox.Show("¿DESEA ELIMINAR EL DETALLE SELECCIONADO?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                string Fac,Art,Cant,Pre;
                for (int i = 0; i < lvDetalleFactura.Items.Count; i++)
                {
                    if (lvDetalleFactura.SelectedItems.Contains(lvDetalleFactura.Items[i]))
                    {
                        Fac=lvDetalleFactura.Items[i].SubItems[0].Text;
                        Art =lvDetalleFactura.Items[i].SubItems[1].Text;
                        Cant =lvDetalleFactura.Items[i].SubItems[3].Text;
                        Pre =lvDetalleFactura.Items[i].SubItems[4].Text;

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

                        string strComandoC = "EXEC EliminaDetalleFactura "+Fac+","+Art+","+Cant+","+Pre;

                        Lector = UsoBD.Consulta(strComandoC, Con);
                        if (Lector == null)
                        {
                            MessageBox.Show("ERROR AL HACER LA CONSULTA");
                            foreach (SqlError E in UsoBD.ESalida.Errors)
                                MessageBox.Show(E.Message);

                            Con.Close();
                            return;
                        }
                        Con.Close();
                        lvDetalleFactura.Items[i].Remove();
                        MessageBox.Show("LA ELIMINACION DEL DETALLE DE FACTURA SE HA REALIZADO CORRECTAMENTE", "ELIMINACION REALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }    
                }
            }
        }
    }
}
