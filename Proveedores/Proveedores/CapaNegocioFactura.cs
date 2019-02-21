using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class CapaNegocioFactura
    {
        Dictionary<int, Factura> DicFactura;
        List<DetalleFactura> ListDetalleFactura;

        public CapaNegocioFactura(Dictionary<int, Factura> DicFac, List<DetalleFactura> ListDetFact)
        {
            DicFactura = DicFac;
            ListDetalleFactura = ListDetFact;
        }

        public void AgregaFactura()
        {

        }

        public void AgregaDetalleFactura()
        {

        }

        public void ConsultaSaldoProveedor() //NO SE DONDE VA
        {

        }
    }
}
