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

        public DetalleFactura(int ClaveFact, int ClaveArt, int Cant, float precio)
        {
            this.ClaveFact = ClaveFact;
            this.ClaveArt = ClaveArt;
            this.Cant = Cant;
            this.Precio = precio;
        }
        public int pClaveFact
        {
            get
            {
                return pClaveFact;
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
    }
}
