using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AgregaArt(string Desc, string Modelo, float Precio, int Cant)
        {
            Array[Count] = new Articulo(Count,Desc, Modelo, Precio, Cant);
            Count++;
        }

        public int BuscaArt(int Clave)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Array[i].pClave == Clave)
                    return i;
            }
            return -1;
        }
        public bool BuscaRep(string Desc, string Modelo)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Array[i].pDescripcion.Equals(Desc) && (Array[i].pModelo.Equals(Modelo)))
                    return true;
            }
            return false;
        }
        public bool BuscaDesc(string Desc)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Array[i].pDescripcion.Equals(Desc))
                    return true;
            }
            return false;
        }
        public string ImprimeArticuloFactura(int ClaveArticulo)
        {
            string msj = "";
            for (int i = 0; i < Count; i++)
            {
                if (Array[i].pClave == ClaveArticulo)
                    msj += Array[i].ToString();
            }
            return msj;
        }
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
        public string ImprimeCatalogoArticulo()
        {
            string Cadena = " ";

            for (int i = 0; i < Count; i++)
                Cadena += Array[i].ToString();

            return Cadena;
        }
        public int pCount
        {
            get
            { return Count; }
        }
    }
}
