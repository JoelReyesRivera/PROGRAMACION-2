using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class ManejaFacturas
    {
        private Dictionary<int, Factura> Facturas;

        public ManejaFacturas()
        {
            Facturas = new Dictionary<int, Factura>();
        }
        public void AgregarFactura(int Clave, int ClaveProv, string Dia, string Mes, string Año)
        {
            Facturas.Add(Clave, new Factura(ClaveProv, Dia, Mes, Año));
        }
        public int BuscaFacturaClave(int Clave)
        {
            foreach (KeyValuePair<int, Factura> pair in Facturas)
            {
                if (pair.Key == Clave)
                    return pair.Key;
            }
            return -1;
        }
        public int BuscaFacturaClaveProv(int ClaveFactura,int ClaveProveedor)
        {
            foreach (KeyValuePair<int, Factura> pair in Facturas)
            {
                if (pair.Key == ClaveFactura && pair.Value.pClaveProv==ClaveProveedor)
                    return pair.Key;
            }
            return -1;
        }
        public Factura RetornaFactura(int Clave)
        {
            if (Facturas.TryGetValue(Clave, out Factura F))
                return F;
            return null;
        }
        public String ImprimeFacturaClaveProv(int Proveedor, ManejaDetalleFactura mD, ManejaArticulo mA)
        {
            string msj="";
            foreach(KeyValuePair<int, Factura> pair in Facturas)
            {
                if (pair.Value.pClaveProv == Proveedor)
                {
                    msj += pair.Value.ToString();
                    msj += mD.ImprimeDetalleFactura(pair.Key,mA);
                }
            }
            return msj;
        }
        public string ImprimeIndividual(int Clave)
        {
            return RetornaFactura(Clave).ToString();
        }
        public string ImprimeTodo()
        {
            string msj="";
            foreach(KeyValuePair<int, Factura> pair in Facturas)
            {
                msj += pair.Value.ToString();
            }
            return msj;
        }
        public string ConvierteMes(string Mes)
        {
            int M = int.Parse(Mes);
            string[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return Meses[M-1];
        }
        public bool ValidaNula(string Fecha)
        {
            int A = int.Parse(Fecha.Substring(0, 2));
            int M = int.Parse(Fecha.Substring(3, 2));
            int Y = int.Parse(Fecha.Substring(6, 4));
            if (A <= 0)
                return false;
            if (M <= 0)
                return false;
            if (Y > 2019 || Y <= 0)
                return false;
            return true;
        }
        public int pCount
        {
            get
            {
                return Facturas.Count;
            }
        }
    }
}
