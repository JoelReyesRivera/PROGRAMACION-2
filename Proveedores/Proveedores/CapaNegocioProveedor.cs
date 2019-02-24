using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class CapaNegocioProveedor
    {
        ManejaProveedores proveedores;

        public CapaNegocioProveedor(ManejaProveedores proveedores)
        {
            this.proveedores = proveedores;
        }

        public void AgregaProveedor()
        {
            int clave;
            String nombre, domicilio, RFC;
            Console.WriteLine("INGRESE LOS DATOS DEL PROVEEDOR");
            Console.WriteLine("CLAVE");
            clave = Leer.Int();
            while (proveedores.ClaveExistente(clave))
            {
                Console.WriteLine("CLAVE EXISTENTE; INGRESE UNA CLAVE UNICA");
                clave = Leer.Int();
            }
            Console.WriteLine("NOMBRE");
            nombre = Leer.String();
            while (proveedores.NombreExistente(nombre))
            {
                Console.WriteLine("NOMBRE EXISTENTE; INGRESE UN NOMBRE UNICO");
                nombre = Leer.String();
             } 
            Console.WriteLine("RFC");
            RFC = Leer.String();
            while (proveedores.RFCExistente(RFC))
            {
                Console.WriteLine("RFC EXISTENTE; INGRESE UN RFC UNICO");
                RFC = Leer.String();
            } 
            Console.WriteLine("DOMICILIO");
            domicilio = Leer.String();
            proveedores.AgregaProveedor(clave,RFC,nombre,domicilio);
            Proveedor proveedor = new Proveedor(RFC, nombre, domicilio);
            Console.WriteLine("PROVEEDOR AGREGADO CORRECTAMENTE\nCLAVE: {0}" +"\n"+ proveedor.ToString(),clave);
        }
        
        public void Imprimir()
        {
            proveedores.Imprimir();
        }

        public void ConsultaProveedor()
        {
            String nombre;
            nombre = Leer.String();
            Proveedor proveedor = proveedores.ObtieneProveedor(nombre);
            if (proveedor==null)
            {
                Console.WriteLine("NOMBRE INEXISTENTE");
                return;
            }
            Console.WriteLine("PROVEEDOR");
            Console.WriteLine(proveedor.ToString());
        }
    }
}
