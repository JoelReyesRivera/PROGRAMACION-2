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
            proveedores.AgregaProveedor(clave, RFC.ToUpper(), nombre.ToUpper(), domicilio.ToUpper());
            Console.WriteLine("PROVEEDOR AGREGADO CORRECTAMENTE\n{0}",proveedores.RetornaProveedorClave(clave).ToString());
        }

        public void Imprimir()
        {
            proveedores.Imprimir();
        }
        public void ConsultaSaldo()
        {
            Console.WriteLine("\n***CONSULTANDO SALDO POR NOMBRE DE PROV***");
            Console.WriteLine("PROPORCIONE EL NOMBRE DEL PROVEEDOR: ");
            string Nombre = Leer.String();
            while (!proveedores.NombreExistente(Nombre))
            {
                Console.WriteLine("NO SE ENCUENTRA EL PROVEEDOR, ESCRIBA OTRO NOMBRE");
                Nombre = Console.ReadLine();
            }
            Console.WriteLine(proveedores.ConsultaSaldos(Nombre.ToUpper()));
        }

        public void ConsultaProveedor()
        {
            String nombre;
            nombre = Leer.String();
            Proveedor proveedor = proveedores.RetornaProveedorNom(nombre);
            if (proveedor == null)
            {
                Console.WriteLine("NOMBRE INEXISTENTE");
                return;
            }
            Console.WriteLine("PROVEEDOR");
            Console.WriteLine(proveedor.ToString());
        }
    }
}
