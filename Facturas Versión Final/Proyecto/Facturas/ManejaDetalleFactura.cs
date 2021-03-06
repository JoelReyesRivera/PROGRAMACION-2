﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBD;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Facturas
{
    public class ManejaDetalleFactura
    {
        private List<DetalleFactura> DetalleFactura;

        public ManejaDetalleFactura()
        {
            DetalleFactura = new List<DetalleFactura>();
        }

        public bool AgregarDetalle(int ClaveFact, int ClaveArt, int Cant)
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

            string strComandoC = "exec InsertarDetalleFactura " + ClaveFact + "," + ClaveArt + "," + Cant;

            Lector = UsoBD.Consulta(strComandoC, Con);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return false;
            }
            Con.Close();
            return false;
        }
        public int DetallesPorFactura(int ClaveFactura)
        {
            string strConexion = Rutinas.GetConnectionString();
            int Cantidad = 0;
            SqlConnection Con = UsoBD.ConectaBD(strConexion);
            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return Cantidad;
            }
            SqlDataReader Lector = null;

            string strComandoC = "SELECT COUNT (Factura) FROM DetalleFactura WHERE Factura=" + ClaveFactura;

            Lector = UsoBD.Consulta(strComandoC, Con);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return Cantidad;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Cantidad = Convert.ToInt32(Lector.GetValue(0).ToString());
                }
            }
            Con.Close();
            return Cantidad;
        }
        public DetalleFactura[] RetornaDetallesFactura(int ClaveFactura)
        {
            DetalleFactura[] D = new DetalleFactura[DetalleFactura.Count];
            int pos = 0;
            for (int i = 0; i < DetalleFactura.Count; i++)
            {
                if (DetalleFactura[i].pClaveFact == ClaveFactura)
                    D[pos++] = DetalleFactura[i];
            }
            return D;
        }
        public List<DetalleFactura> RetornaDetalles()
        {
            List<DetalleFactura> D = new List<DetalleFactura>();
            for (int i = 0; i < DetalleFactura.Count; i++)
                D.Add(DetalleFactura.ElementAt(i));
            return D;
        }
        public bool DetalleRepetido(int ClaveFactura, int ClaveArt)
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

            string strComandoC = "select * from DetalleFactura where Factura = " + ClaveFactura + "and Articulo = " + ClaveArt;

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
                return true;
            }
            Con.Close();
            return false;
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
            string Query = "select count(*) from DetalleFactura";
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
