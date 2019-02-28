using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class ManejaArticulo
    {
        private Articulo[] articulos;
        private int Cont;

        public ManejaArticulo()
        {
            articulos = new Articulo[50];
            Cont = 0;
        }

        public void AgregaArt(string Desc, string Marca, float Precio)
        {
            articulos[Cont] = new Articulo(GeneraClave(), Desc, Marca, Precio);
        }

        private int GeneraClave()
        {
            return Cont += 1;
        }

        public int BuscaArt(int Clave)
        {
            int Pos = -1;
            for (int i = 0; i < Cont; i++)
            {
                if (articulos[i].pClave == Clave)
                {
                    Pos = i;
                    break;
                }
            }
            return Pos;
        }
        public bool BuscaRep(string Desc, string Marca)
        {
            bool Band = false;
            for (int i = 0; i < Cont; i++)
            {
                if (articulos[i].pDescripcion.Equals(Desc) && (articulos[i].pMarca.Equals(Marca)))
                {
                    Band = true;
                    break;
                }
            }
            return Band;
        }
        public string ImprimeArticuloFactura(int ClaveArticulo)
        {
            string msj = "";
            for (int i = 0; i < Cont; i++)
            {
                if (articulos[i].pClave == ClaveArticulo)
                    msj += articulos[i].ToString();
            }
            return msj;
        }
        public Articulo RetornaArticulo(int Clave)//RETORNA POR CLAVE
        {
            for (int i = 0; i < Cont; i++)
            {
                if (articulos[i].pClave == Clave)
                    return articulos[i];
            }
            return null;
        }
        public int pCount
        {
            get
            {
                return Cont;
            }
        }

        public string ImprimeCatalogoArticulo()
        {
            string Cadena =" ";

            for (int i = 0; i < pCount; i++)
                Cadena+=articulos[i].ToString();
    
            return Cadena;
        }
    }
}
