﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class CapaNegocioProveedor
    {
        Dictionary<int, Proveedor> DicProvedor;

        public CapaNegocioProveedor(Dictionary <int, Proveedor> DicProv)
        {
            DicProvedor = DicProv;
        }

        public void AgregaProveedor()
        {

        }
    }
}
