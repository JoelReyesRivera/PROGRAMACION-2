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
        private List<DetalleFactura> DetalleFactura;

        public ManejaFacturas()
        {
            facturas = new Dictionary<int, Factura>();
            DetalleFactura = new List<DetalleFactura>();
        }
    }
}
