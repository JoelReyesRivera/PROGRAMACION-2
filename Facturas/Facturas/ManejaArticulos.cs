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

        public void AgregaArt(string Desc, string Marca, float Precio, int Cant)
        {
            Array[Count] = new Articulo(Count,Desc, Marca, Precio, Cant);
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
        public bool BuscaRep(string Desc, string Marca)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Array[i].pDescripcion.Equals(Desc) && (Array[i].pMarca.Equals(Marca)))
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
