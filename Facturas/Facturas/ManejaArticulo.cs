using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    //ArticuloFactura
    //Modifica Articulo
    //Todos los articulos

    class ManejaArticulo
    {
        private Articulo[] Array;
        private int Cont;

        public ManejaArticulo()
        {
            Array = new Articulo[50];
            Cont = 0;
        }

        public void AgregaArticulo(string Desc, string Marca, float Precio, int Cantidad)
        {
            Array[Cont] = new Articulo( Desc, Marca, Precio,Cantidad);
        }

        public int BuscaArticulo(string Desc)
        {
            for (int i = 0; i < Cont; i++)
            {
<<<<<<< HEAD
                if (Array[i].pDescripcion.CompareTo(Desc)==0)
=======
                if (Array[i].pDescripcion=Desc)
>>>>>>> master
                    return i;
            }
            return -1;
        }
        public bool BuscaRepetido(string Desc, string Modelo)
        {
            for (int i = 0; i < Cont; i++)
            {
                if (Array[i].pDescripcion == (Desc) && (Array[i].pModelo == (Modelo)))
                    return true;
            }
            return false;
        }
        public bool BuscaDescripcion(string Desc)
        {
            for (int i = 0; i < Cont; i++)
            {
                if (Array[i].pDescripcion == (Desc))
                    return true;
            }
            return false;
        }
        public Articulo RetornaArticulo(string Desc)
        {
            for (int i = 0; i < Cont; i++)
            {
<<<<<<< HEAD
                if (Array[i].pDescripcion.CompareTo(Desc)==0)
                    return Array[i];
=======
                if (Array[i].pDescripcion == (Desc))
                    return articulos[i];
>>>>>>> master
            }
            return null;
        }
        public int size
        {
            get{ return Cont; }
        }
    }
}
