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
        CapaNegocioArticulo cArt;
        CapaNegocioFactura cFact;
        CapaNegocioProveedor cProv;

        //Manejadoras
        ManejaArticulo mA;
        ManejaFacturas mF;
        ManejaDetalleFactura mD;
        ManejaProveedores mP;

        public Program()
        {
            mA = new ManejaArticulo();
            cArt = new CapaNegocioArticulo(mA);
            mP = new ManejaProveedores();
            cProv = new CapaNegocioProveedor(mP);
            mF = new ManejaFacturas();
            mD = new ManejaDetalleFactura();
            cFact = new CapaNegocioFactura(mF,mD,mP,mA);
            Menu();
        }

        public void Menu()
        {

        } 

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
