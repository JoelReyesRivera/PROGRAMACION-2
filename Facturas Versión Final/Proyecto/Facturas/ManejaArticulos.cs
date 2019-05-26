using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBD;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Facturas
{
    public class ManejaArticulos
    {
        private Articulo[] Array;
        private int Count;

        public ManejaArticulos()
        {
            Array = new Articulo[50];
            Count = 0;
        }

        public bool AgregaArt(string Desc, string Marca, float Precio, int Cant)
        {
            string strConexion = Rutinas.GetConnectionString();

            SqlConnection Con = UsoBD.ConectaBD(strConexion);

            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return false;
            }

            string strComando = "INSERT INTO Articulo(Descripcion,Marca,Precio,Cantidad)";
            strComando += " VALUES(@Descripcion, @Marca, @Precio, @Cantidad)";

            SqlCommand Insert = new SqlCommand(strComando, Con);

            Insert.Parameters.AddWithValue("@Descripcion", Desc.Trim());
            Insert.Parameters.AddWithValue("@Marca", Marca.Trim());
            Insert.Parameters.AddWithValue("@Precio", Precio);
            Insert.Parameters.AddWithValue("@Cantidad", Cant);

            try
            {
                Insert.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);

                Con.Close();
                return false;
            }
            Con.Close();
            return true;
        }

        public int BuscaArt(int Clave)
        {
            string strConexion = Rutinas.GetConnectionString();

            SqlConnection Con = UsoBD.ConectaBD(strConexion);
            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return -1;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT COUNT (Clave) FROM Articulo WHERE Clave=" + Clave;

            Lector = UsoBD.Consulta(strComandoC, Con);

            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return -1;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    int Art = Convert.ToInt32(Lector.GetValue(0).ToString());
                    if (Art >= 0)
                    {
                        Con.Close();
                        return Art;
                    }
                }
            }
            Con.Close();
            return -1;
        }

        public int BuscaClaveArt(string Desc)
        {
            string strConexion = Rutinas.GetConnectionString();

            SqlConnection Con = UsoBD.ConectaBD(strConexion);
            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return -1;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT Clave FROM Articulo WHERE Descripcion LIKE'" +Desc+"'";

            Lector = UsoBD.Consulta(strComandoC, Con);

            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return -1;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    int Clave = Convert.ToInt32(Lector.GetValue(0).ToString());
                    Con.Close();
                    return Clave;
                }
            }
            Con.Close();
            return -1;
        }
        public bool BuscaRep(string Desc, string Marca)
        {
            string strConexion = Rutinas.GetConnectionString();

            SqlConnection Con = UsoBD.ConectaBD(strConexion);
            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return false;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT COUNT(Clave) FROM Articulo WHERE Descripcion LIKE'"+Desc+"' AND Marca LIKE'"+Marca+"'";

            Lector = UsoBD.Consulta(strComandoC, Con);

            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return false;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    if (Convert.ToInt32(Lector.GetValue(0).ToString()) > 0)
                    {
                        Con.Close();
                        return true;
                    }
                }
            }
            Con.Close();
            return false;
        }
        /*public bool BuscaDesc(string Desc)
        {
            string strConexion = Rutinas.GetConnectionString();

            SqlConnection Con = UsoBD.ConectaBD(strConexion);
            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return false;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT COUNT(Clave) FROM Articulo WHERE Descripcion LIKE'"+ Desc +"'";

            Lector = UsoBD.Consulta(strComandoC, Con);

            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return false;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    if (Convert.ToInt32(Lector.GetValue(0).ToString()) > 0)
                    {
                        Con.Close();
                        return true;
                    }
                }
            }
            Con.Close();
            return false;
        }*/
        public Articulo RetornaArticulo(int Clave)//RETORNA POR CLAVE
         {
             for (int i = 0; i < Count; i++)
             {
                 if (Array[i].pClave == Clave)
                     return Array[i];
             }
             return null;
         }
         public List<Articulo> ObtenArt()
         {
             List<Articulo> Lista = new List<Articulo>();
             for (int i = 0; i < Count; i++)
                 Lista.Add(Array[i]);

             return Lista;
         }

         public int pCount
         {
             get
             { return Count; }
         }
    }
}
