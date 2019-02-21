using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class ManejaFacturas
    {
        private Dictionary<int, Factura> facturas;

        public ManejaFacturas()
        {
            facturas = new Dictionary<int, Factura>();
        }
    }
}
