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
    public class ManejaFacturas
    {
        private Dictionary<int, Factura> Facturas;

        public ManejaFacturas()
        {
            Facturas = new Dictionary<int, Factura>();
        }
        public void AgregarFactura(int Clave, int ClaveProv, DateTime Fecha, float Monto)
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

            string strComando = "INSERT INTO Factura(Clave,Provedor,Fecha,Monto)";
            strComando += "VALUES(@Clave,@ClaveProv,@Fecha,@Monto)";

            SqlCommand Insert = new SqlCommand(strComando, Con);

            Insert.Parameters.AddWithValue("@Clave", Clave);
            Insert.Parameters.AddWithValue("@ClaveProv", ClaveProv);
            Insert.Parameters.AddWithValue("@Fecha", Fecha);
            Insert.Parameters.AddWithValue("@Monto", Monto);

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
        }
        public int BuscaFacturaClave(int Clave)
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

            string strComandoC = "SELECT COUNT (Clave) FROM Factura WHERE Clave=" + Clave;

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
                    return Art;
                }
            }
            Con.Close();
            return -1;
        }
        public int BuscaFacturaClaveProv(int ClaveFactura, int ClaveProveedor)
        {
            foreach (KeyValuePair<int, Factura> pair in Facturas)
            {
                if (pair.Key == ClaveFactura && pair.Value.pClaveProv == ClaveProveedor)
                    return pair.Key;
            }
            return -1;
        }
        public KeyValuePair<int, Factura>[] RetornaFacturas()
        {
            KeyValuePair<int, Factura>[] F = new KeyValuePair<int, Factura>[Facturas.Count];
            int c = 0;
            foreach (KeyValuePair<int, Factura> pair in Facturas)
                F[c++] = pair;
            return F;
        }
        public Factura RetornaFactura(int Clave)
        {
            if (Facturas.TryGetValue(Clave, out Factura F))
                return F;
            return null;
        }
        public int BuscaKeyFactura(Factura F)
        {
            foreach (KeyValuePair<int, Factura> pair in Facturas)
            {
                if (pair.Value.Equals(F))
                    return pair.Key;
            }
            return -1;
        }
        public Factura[] RetornaFacturasProv(int ClaveProv)
        {
            Factura[] F = new Factura[Facturas.Count];
            int pos = 0;
            for (int i = 0; i < Facturas.Count; i++)
            {
                KeyValuePair<int, Factura> pair = Facturas.ElementAt(i);
                if (pair.Value.pClaveProv == ClaveProv)
                    F[pos++] = pair.Value;
            }
            return F;
        }
        public int Count()
        {
            int Count = 0;
            string Conexion = Rutinas.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return Count;
            }
            string Query = "select count(*) from Factura";
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return Count;
            }
            if (!Lector.HasRows)
            {
                Conecta.Close();
                return Count;
            }
            while (Lector.Read())
            {
                try
                {
                    Count = Convert.ToInt32(Lector.GetValue(0));
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("ERRORR AL CONVERTIR", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return Count;
                }
            }
            return Count;
        }
    }
}
