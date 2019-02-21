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
        private float Cant;

        public DetalleFactura(int ClaveFact, int ClaveArt, float Cant)
        {
            this.ClaveFact = ClaveFact;
            this.ClaveArt = ClaveArt;
            this.Cant = Cant;
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
        public float pCant
        {
            get
            {
                return Cant;
            }
        }
    }
}
