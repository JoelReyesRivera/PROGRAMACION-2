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
        public void AgregarFactura(int Clave, int ClaveProv, float Importe, string Dia, string Mes, string Año)
        {
            Facturas.Add(Clave, new Factura(Clave, ClaveProv, Importe, Dia, Mes, Año));
        }
        public int BuscaFactura(int Clave)
        {
            for (int i = 0; i < Facturas.Count; i++)
            {
                if (Facturas[i].pClave == Clave)
                    return i;
            }
            return -1;
        }
        public Factura RetornaFactura(int Clave)
        {
            for (int i = 0; i < Facturas.Count; i++)
            {
                if (Facturas[i].pClave == Clave)
                    return Facturas[i];
            }
            return null;
        }
        public string ImprimeIndividual(int Clave)
        {
            return RetornaFactura(Clave).ToString();
        }
        public string ImprimeTodo()
        {
            string msj="";
            for(int i = 0; i < Facturas.Count; i++)
                msj += Facturas[i].ToString();
            return msj;
        }
    }
}
