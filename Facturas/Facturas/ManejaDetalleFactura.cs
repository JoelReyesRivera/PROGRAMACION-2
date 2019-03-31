using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class ManejaDetalleFactura
    {
        private List<DetalleFactura> DetalleFactura;

        public ManejaDetalleFactura()
        {
            DetalleFactura = new List<DetalleFactura>();
        }

        public void AgregarDetalle(int ClaveFact, int ClaveArt, int Cant, float Precio)
        {
            DetalleFactura.Add(new DetalleFactura(ClaveFact,ClaveArt,Cant,Precio));
        }
        public string ImprimeDetallesClave(int ClaveFactura)
        {
            string msj = "";
            for (int i = 0; i < DetalleFactura.Count; i++)
            {
                if (DetalleFactura[i].pClaveFact == ClaveFactura)
                    msj += DetalleFactura[i].ToString();
            }
            if (msj.Length == 0)
                return "NO HAY DETALLES PARA ESTA FACTURA";
            return msj;
        }
        public string ImprimeDetalleClaveArticulo(int ClaveArticulo)
        {
            for (int i = 0; i < DetalleFactura.Count; i++)
            {
                if (DetalleFactura[i].pClaveArt==ClaveArticulo)
                    return DetalleFactura[i].ToString();
            }
            return "NO HAY DETALLE PARA ESTE ARTICULO";
        }
        public string ImprimeDetalleFactura(int ClaveFactura, ManejaArticulos mA)
        {
            string msj = "";
            for (int i = 0; i < DetalleFactura.Count; i++)
            {
                if (DetalleFactura[i].pClaveFact == ClaveFactura)
                    msj += mA.ImprimeArticuloFactura(DetalleFactura[i].pClaveArt);
            }
            return msj;
        }
        public string ImprimeTodo()
        {
            string Cadena = "";
            for (int i = 0; i < DetalleFactura.Count; i++)
                Cadena += DetalleFactura[i].ToString();

            if (Cadena.Length == 0)
                return "NO HAY NINGUN DETALLE REGISTRADO";

            return Cadena;
        }
        public int DetallesPorFactura(int ClaveFactura)
        {
            int NumeroDetalles=0;
            for (int i = 0; i < DetalleFactura.Count; i++)
            {
                if (DetalleFactura[i].pClaveFact == ClaveFactura)
                    NumeroDetalles++;
            }
            return NumeroDetalles;
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
        public int DetalleRepetido(int ClaveFactura,int ClaveArt)
        {
            for (int i = 0; i < DetalleFactura.Count; i++)
            {
                if (DetalleFactura[i].pClaveArt == ClaveArt && DetalleFactura[i].pClaveFact==ClaveFactura)
                    return i;
            }
            return -1;
        }
        public int pCount
        {
            get
            {
                return DetalleFactura.Count;
            }
        }
    }
}
