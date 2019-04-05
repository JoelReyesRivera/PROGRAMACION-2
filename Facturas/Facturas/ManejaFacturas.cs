using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class ManejaFacturas
    {
        private Dictionary<int, Factura> Facturas;

        public ManejaFacturas()
        {
            Facturas = new Dictionary<int, Factura>();
        }
        public void AgregarFactura(int Clave, int ClaveProv, int Dia, int Mes, int Año)
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
        public KeyValuePair<int,Factura>[] RetornaFacturas()
        {
            KeyValuePair<int, Factura>[] F = new KeyValuePair<int, Factura>[Facturas.Count];
            int c = 0;
            foreach(KeyValuePair<int,Factura> pair in Facturas)
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
            foreach(KeyValuePair<int,Factura> pair in Facturas)
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
        public int pCount
        {
            get
            {
                return Facturas.Count;
            }
        }
    }
}
