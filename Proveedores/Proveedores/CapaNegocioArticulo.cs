using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class CapaNegocioArticulo
    {
        ManejaArticulo ManejadoraArticulo;

        public CapaNegocioArticulo(ManejaArticulo ManejArt)
        {
            ManejadoraArticulo = ManejArt;
        }

        public void AgregaArticulo()
        {
            string Desc, Marca;
            float Precio;

            Console.Write("INGRESE LA DESCRIPCION DEL ARTICULO: ");
            Desc = Leer.String();
            Console.Write("INGRESE EL MODELO DEL ARTICULO: ");
            Marca = Leer.String();
          
            if (ManejadoraArticulo.BuscaRep(Desc.ToUpper(), Marca.ToUpper()))
                Console.WriteLine("EL ARTICULO INGRESADO ANTERIROMENTE YA ESTA REGISTRADO");
            else
            {
                Console.Write("INGRESA EL PRECIO DEL ARTIULO: ");
                Precio = Leer.Float();
                if(ManejadoraArticulo.AgregaArt(Desc.ToUpper(), Marca.ToUpper(), Precio))
                    Console.WriteLine(" EL ARTICULO FUE AGREGADO CON EXITO ");
                else
                    Console.WriteLine(" EL ARTICULO NO SE PUDO AGREGAR ");
                
            }
        }
    }
}
