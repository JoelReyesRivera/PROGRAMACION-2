using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class Program
    {
        //Capas
        CapaNegocioArticulo capaArticulo;
        CapaNegocioFactura capaFactura;
        CapaNegocioProveedor capaProveedor;

        //Manejadoras
        ManejaArticulo articulos;
        ManejaFacturas facturas;
        ManejaDetalleFactura detalles;
        ManejaProveedores proveedores;

        public Program()
        {
            articulos = new ManejaArticulo();
            capaArticulo = new CapaNegocioArticulo(articulos);
            proveedores = new ManejaProveedores();
            capaProveedor = new CapaNegocioProveedor(proveedores);
            facturas = new ManejaFacturas();
            detalles = new ManejaDetalleFactura();
            capaFactura = new CapaNegocioFactura(facturas, detalles, proveedores, articulos);
            MenuPrincipal();
        }

        public void MenuPrincipal()
        {
            int opcion;
            do
            {
                Console.WriteLine("---------- MENU PRINCIPAL ---------- ");
                Console.WriteLine("1.- MENU ARTICULO\n2.- MENU PROVEEDOR\n3.- MENU FACTURA\n4.- MENU DETALLE FACTURA\n0.- SALIR");
                opcion = Leer.Int();
                switch (opcion)
                {
                    case 1:
                        MenuArticulos();
                        break;
                    case 2:
                        MenuProveedores();
                        break;
                    case 3:
                        MenuFacturas();
                        break;
                    case 4:
                        MenuDetalles();
                        break;
                    default:
                        Console.WriteLine("ELIJA UNA DE LAS OPCIONES");
                        break;
                }
            } while (opcion != 0);
        }

        public void MenuArticulos()
        {
            int opcion;
            do
            {
                Console.WriteLine("---------- MENU ARTICULOS ---------- ");
                Console.WriteLine("1.- AGREGAR ARTICULO\n2.- CONSULTAR ARTICULO\n3.- IMPRIMIR ARTICULOS\n0.- SALIR");
                opcion = Leer.Int();
                switch (opcion)
                {
                    case 1:
                        capaArticulo.AgregaArticulo();
                        break;
                    case 2:
                        capaArticulo.ConsultaArticulo();
                        break;
                    case 3:
                        capaArticulo.ImprimeArticulos();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("ELIJA UNA DE LAS OPCIONES");
                        break;
                }
            } while (opcion!=0);
        }

        public void MenuProveedores()
        {
            int opcion;
            do
            {
                Console.WriteLine("---------- MENU PROVEEDOR ---------- ");
                Console.WriteLine("1.- AGREGAR PROVEEDOR\n2.- CONSULTAR PROVEEDOR\n3.- IMPRIMIR PROVEEDORES\n0.- SALIR");
                opcion = Leer.Int();
                switch (opcion)
                {
                    case 1:
                        capaProveedor.AgregaProveedor();
                        break;
                    case 2:
                        capaProveedor.ConsultaProveedor();
                        break;
                    case 3:
                        capaProveedor.Imprimir();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("ELIJA UNA DE LAS OPCIONES");
                        break;
                }
            } while (opcion != 0);
        }

        public void MenuFacturas()
        {
            int opcion;
            do
            {
                Console.WriteLine("---------- MENU FACTURA ---------- ");
                Console.WriteLine("1.- AGREGAR FACTURA\n2.- CONSULTAR FACTURA\n3.- IMPRIMIR FACTURAS\n0.- SALIR");
                opcion = Leer.Int();
                switch (opcion)
                {
                    case 1:
                        capaFactura.AgregaFactura();
                        break;
                    case 2:
                        capaFactura.ConsultaFacturas();
                        break;
                    case 3:
                        capaFactura.ImprimirFacturas();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("ELIJA UNA DE LAS OPCIONES");
                        break;
                }
            } while (opcion != 0);
        }

        public void MenuDetalles()
        {

        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
