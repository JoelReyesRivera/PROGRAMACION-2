using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Proveedores
{
    class CapaNegocioFactura
    {
        ManejaFacturas mF;
        ManejaDetalleFactura mD;
        ManejaProveedores mP;
        ManejaArticulo mA;

        public CapaNegocioFactura(ManejaFacturas mF, ManejaDetalleFactura mD, ManejaProveedores mP, ManejaArticulo mA)
        {
            this.mF = mF;
            this.mD = mD;
            this.mP = mP;
            this.mA = mA;
        }

        public void AgregaFactura()
        {
            Console.WriteLine("\n***AGREGANDO FACTURA***");
            Console.WriteLine("PROPORCIONE EL NÚMERO DE LA FACTURA: ");
            int ClaveFact = Leer.Int();
            while(mF.BuscaFacturaClave(ClaveFact) !=-1 || !ValidaValor(ClaveFact))
            {
                Console.WriteLine("NÚMERO DE FACTURA NO ACEPTADO, PROPORCIONE OTRO");
                ClaveFact = Leer.Int();
            }
            Console.WriteLine("PROPORCIONE EL NÚMERO DEL PROVEEDOR: ");
            int ClaveProv = Leer.Int();
            while (mP.getPosClave(ClaveProv) ==-1 || !ValidaValor(ClaveProv))
            {
                Console.WriteLine("NÚMERO DE PROVEEDOR NO ACEPTADO, PROPORCIONE OTRO");
                ClaveProv = Leer.Int();
            }
            Console.WriteLine("PROVEEDOR SELECCIONADO: {0}\n",mP.RetornaProveedorClave(ClaveProv).ToString());
            Console.WriteLine("PRPOPORCIONE LA FECHA DE LA FACTURA EN FORMATO dd/mm/yyyy");
            string Fecha = Leer.String();
            Fecha = Fecha.Trim();
            DateTime dt;
            while (!DateTime.TryParseExact(Fecha, "dd/MM/yyyy", null, DateTimeStyles.None, out dt) && !mF.ValidaNula(Fecha))
            {
                Console.WriteLine("LA FECHA NO ES VÁLIDA, PROPORCIONE OTRA");
                Fecha = Leer.String();
            }

            mF.AgregarFactura(ClaveFact, ClaveProv, Fecha.Substring(0, 2), mF.ConvierteMes(Fecha.Substring(3,2)), Fecha.Substring(6, 4));
            Console.WriteLine("Factura creada: {0}\n",mF.ImprimeIndividual(ClaveFact));
            CapturaArticulos(ClaveFact, ClaveProv);
        }
        public void CapturaArticulos(int ClaveFactura,int ClaveProv)
        {
            Console.WriteLine("***AGREGANDO ARTÍCULOS A LA FACTURA***");
            int CantArt;
            float TotalArt,Precio, TotalImp = 0;
            Console.Write("¿CUÁNTOS ARTÍCULOS DESEA AGREGAR EN TOTAL?: ");
            TotalArt = Leer.Int();
            while (TotalArt<1 || TotalArt > 3)
            {
                Console.WriteLine("NO SE PUEDEN CAPTURAR MÁS DE 3 ARTÍCULOS EN TOTAL NI MENOS DE 1");
                Console.WriteLine("PROPORCIONE LA CANTIDAD DE ARTÍCULOS A CAPTURAR: ");
                TotalArt = Leer.Int();
            }
            while (TotalArt != 0)
            {
                Console.WriteLine("PROPORCIONE LA CLAVE DEL ARTÍCULO");
                int ClaveArt = Leer.Int();
                while (mA.BuscaArt(ClaveArt)==-1)
                {
                    Console.WriteLine("EL ARTÍCULO NO EXISTE, PROPORCIONE OTRA CLAVE");
                    ClaveArt = Leer.Int();
                }
                Console.WriteLine("ARTICULO SELECCIONADO: {0}\n", mA.RetornaArticulo(ClaveArt).ToString());
                Console.WriteLine("INTRODUZCA LA CANTIDAD DE DICHO ARTÍCULO");
                CantArt = Leer.Int();
                while (!ValidaValor(CantArt) || CantArt>3 || TotalArt-CantArt<0)
                {
                    Console.WriteLine("CANTIDAD NO ACEPTADA, PROPORCIONE OTRA CANTIDAD");
                    CantArt = Leer.Int();
                }
                TotalArt -= CantArt;
                Precio = mA.RetornaArticulo(ClaveArt).pPrecio;
                TotalImp += Precio*CantArt;
                mD.AgregarDetalle(ClaveFactura, ClaveArt,CantArt, Precio);
            }
            Console.WriteLine("\n***MOSTRANDO DETALLES AGREGADOS***\n{0}", mD.ImprimePorClave(ClaveFactura));
            Factura F = mF.RetornaFactura(ClaveFactura);
            F.pImporte = TotalImp;
            Proveedor P = mP.RetornaProveedorClave(ClaveProv);
            P.pSaldo += TotalImp;
            Console.WriteLine("Importe para la factura {0}",F.pImporte);
            Console.WriteLine("Saldo del proveedor: {0}",P.pSaldo);
        }
        public void ConsultaFacturas()
        {
            Console.WriteLine("\n***MOSTRANDO FACTURAS POR PROVEEDOR***");
            Console.WriteLine("PROPORCIONE EL NOMBRE DEL PROVEEDOR: ");
            string Nombre = Console.ReadLine();
            int Proveedor;
            Proveedor = mP.BuscarPosNombre(Nombre.ToUpper());
            Console.WriteLine(mF.ImprimeFacturaClaveProv(Proveedor,mD,mA));
        }
        public void ImprimirFacturas()
        {
            Console.WriteLine(mF.ImprimeTodo());
        }
        public bool ValidaValor(float Valor)
        {
            if (Valor <= 0)
                return false;
            return true;
        }
    }
}
