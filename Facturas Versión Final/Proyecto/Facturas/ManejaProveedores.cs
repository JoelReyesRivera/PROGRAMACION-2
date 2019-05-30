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
    public class ManejaProveedores
    {
        private Dictionary<int, Proveedor> proveedores;

        public ManejaProveedores()
        {
            proveedores = new Dictionary<int, Proveedor>();
        }

        public void AgregaProveedor(int Clave, String RFC, String nombre, String domicilio)
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
            string Query = "insert into Proveedor(Clave,Nombre,RFC,Domicilio,Saldo)";
            Query += " values(@Clave,@Nombre,@RFC,@Domicilio,@Saldo)";
            SqlCommand cmd = new SqlCommand(Query, Conecta);
            cmd.Parameters.AddWithValue("@Clave", Clave);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@RFC", RFC);
            cmd.Parameters.AddWithValue("@Domicilio", domicilio);
            cmd.Parameters.AddWithValue("@Saldo", 0);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                foreach (SqlError item in Ex.Errors)
                    MessageBox.Show(item.Message);
                Conecta.Close();
                return;
            }
            Conecta.Close();
        }
        public int BuscarPosNombre(String nombre)
        {
            int P = -1;
            string Conexion = Rutinas.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return P;
            }
            string Query = "select Clave from Proveedor where Nombre= " + "'" + nombre + "'";
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return P;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    try
                    {
                        P = int.Parse(Lector.GetValue(0).ToString());
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("ERRORR CONVIRTIENDO LA CLAVE", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return P;
                    }
                }

            }
            return P;
        }
        public bool RFCExistente(String RFC)
        {
            string Conexion = Rutinas.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return true;
            }
            string Query = "select RFC from Proveedor where RFC= " + "'" + RFC + "'";
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return true;
            }
            if (Lector.HasRows)
                return true;

            return false;
        }
        public bool NombreExistente(String nombre)
        {
            string Conexion = Rutinas.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return true;
            }
            string Query = "select Nombre from Proveedor where Nombre= " + "'" + nombre + "'";
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return true;
            }
            if (Lector.HasRows)
                return true;

            return false;
        }

        public bool ClaveExistente(int clave)
        {
            string Conexion = Rutinas.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return true;
            }
            string Query = "select Clave from Proveedor where Clave= " + clave;
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return true;
            }
            if (Lector.HasRows)
                return true;

            return false;
        }

        public int GetClave(String nombre)
        {
            int Clave = -1;
            string Conexion = Rutinas.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return Clave;
            }
            string Query = "select Clave from Proveedor where Nombre= " + "'" + nombre + "'";
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return Clave;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    try
                    {
                        Clave = int.Parse(Lector.GetValue(0).ToString());
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("ERRORR CONVIRTIENDO LA CLAVE", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return Clave;
                    }
                }
            }
            return Clave;
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
            string Query = "select count(*) from Proveedor";
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
        public string getNombreProveedor(int clave)
        {
            string Conexion = Rutinas.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return null;
            }
            string Query = "select nombre from Proveedor where clave = " + clave;
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return null;
            }
            if (!Lector.HasRows)
            {
                Conecta.Close();
                return null;
            }
            while (Lector.Read())
            {
                return Lector.GetValue(0).ToString();
            }
            return null;
        }
        public Proveedor RetornaProveedorNom(string Nombre)//N
        {
            foreach (KeyValuePair<int, Proveedor> pair in proveedores)
            {
                if (pair.Value.pNombre.CompareTo(Nombre) == 0)
                    return pair.Value;
            }
            return null;
        }
        public int getPosClave(int clave)//N
        {
            foreach (KeyValuePair<int, Proveedor> pair in proveedores)
            {
                if (pair.Key == clave)
                    return pair.Key;
            }
            return -1;
        }
        public Proveedor RetornaProveedorClave(int clave)//N
        {
            if (proveedores.TryGetValue(clave, out Proveedor P))
                return P;
            return null;
        }
        public KeyValuePair<int, Proveedor> RetornaProveedor(int Clave)//N
        {
            KeyValuePair<int, Proveedor> P = new KeyValuePair<int, Proveedor>();
            foreach (KeyValuePair<int, Proveedor> pair in proveedores)
            {
                if (pair.Key == Clave)
                {
                    P = pair;
                    break;
                }
            }
            return P;
        }
        public KeyValuePair<int, Proveedor>[] RetornaProveedores()//N
        {
            KeyValuePair<int, Proveedor>[] P = new KeyValuePair<int, Proveedor>[proveedores.Count];
            int c = 0;
            foreach (KeyValuePair<int, Proveedor> pair in proveedores)
                P[c++] = pair;
            return P;
        }
        public Proveedor[] GetProveedores()//N
        {
            Proveedor[] array = new Proveedor[proveedores.Count];
            int i = 0;
            foreach (var item in proveedores)
            {
                array[i] = item.Value;
                i++;
            }
            return array;
        }
        public int[] GetClaves()//N
        {
            int[] array = new int[proveedores.Count];
            int i = 0;
            foreach (var item in proveedores)
            {
                array[i] = item.Key;
                i++;
            }
            return array;
        }
    }
}