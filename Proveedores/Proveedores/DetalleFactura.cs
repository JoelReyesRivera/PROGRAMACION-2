using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
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
            return string.Format("\nClave Factura: {0}\nClave Artículo: {1}\nCantidad: {2}\nPrecio unitario: {3}\n",ClaveFact,ClaveArt,Cant,Precio);
        }
    }
}
