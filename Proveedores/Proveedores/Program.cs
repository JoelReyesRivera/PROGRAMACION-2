using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class Program
    {
        ManejaArticulo ManejaArt;
        ManejaFacturas ManejaFact;
        ManejaProveedores ManejaProv;

        CapaNegocioArticulo CapaNegocioArt;
        CapaNegocioFactura CapaNegocioFact;
        CapaNegocioProveedor CapaNegocioProv;

        public Program()
        {
            ManejaArt = new ManejaArticulo();
            ManejaFact = new ManejaFacturas();
            ManejaProv = new ManejaProveedores();

            CapaNegocioArt = new CapaNegocioArticulo(ManejaArt);
            CapaNegocioFact = new CapaNegocioFactura(ManejaFact);
            CapaNegocioProv = new CapaNegocioProveedor(ManejaProv);
            Menu();
        }
        static void Main(string[] args)
        {
            new Program();
        }
        public void Menu()
        {

        }
    }
}
