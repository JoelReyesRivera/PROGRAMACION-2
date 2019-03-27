using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    class DetalleFactura
    {
        private int ClaveFact, ClaveArt;
        private int Cant;
        private float Precio;

        public DetalleFactura(int ClaveFact, int ClaveArt, int Cant, float Precio)
        {
            this.ClaveFact = ClaveFact;
            this.ClaveArt = ClaveArt;
            this.Cant = Cant;
            this.Precio = Precio;
        }
        public int pClaveFact
        {
            get
            {
                return ClaveFact;
            }
        }
        public int pClaveArt
        {
            get
            {
                return ClaveArt;
            }
        }
        public int pCant
        {
            get
            {
                return Cant;
            }
        }
        public float pPrecio
        {
            get
            {
                return Precio;
            }
            set
            {
                Precio = value;
            }
        }
        public override string ToString()
        {
            return string.Format("\nCLAVE FACTURA: {0}\nCLAVE ARTICULO: {1}\nCANTIDAD: {2}\nPRECIO UNITARIO: {3}\n",ClaveFact,ClaveArt,Cant,Precio);
        }
    }
}
