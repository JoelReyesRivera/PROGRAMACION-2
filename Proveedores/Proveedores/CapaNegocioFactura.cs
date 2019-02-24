using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.WriteLine("***AGREGANDO FACTURA***");
            Console.WriteLine("PROPORCIONE EL NÚMERO DE LA FACTURA: ");
            int ClaveFact = Leer.Int();
            while(!ValidaValor(ClaveFact) || mF.BuscaFactura(ClaveFact) ==-1)
            {
                Console.WriteLine("NÚMERO DE FACTURA NO ACEPTADO, PROPORCIONE OTRO");
                ClaveFact = Leer.Int();
            }
            Console.WriteLine("PROPORCIONE EL NÚMERO DEL PROVEEDOR: ");
            int ClaveProv = Leer.Int();
            if (!ValidaValor(ClaveProv) ||mP.BuscarPosClave(ClaveFact) ==-1)//HACER MÉTODO QUE BUSQUE LA CLAVE EN EL DICCIONARIO
            {
                Console.WriteLine("NÚMERO DE PROVEEDOR NO ACEPTADO, PROPORCIONE OTRO");
                return;
            }
            Console.WriteLine("PROPORCIONE EL IMPORTE");//<---- SE PIDE IMPORTE
            float Importe = Leer.Float();
            while (!ValidaValor(Importe))
            {
                Console.WriteLine("PROPORCIONE UN IMPORTE VÁLIDO");
                Importe = Leer.Int();
            }
            Console.WriteLine("PRPOPORCIONE LA FECHA DE LA FACTURA EN FORMATO dd/mm/yyyy");
            string Fecha = Leer.String();
            Fecha = Fecha.Trim();
            DateTime dt;
            while (!DateTime.TryParseExact(Fecha, "dd/MM/yyyy", null, DateTimeStyles.None, out dt) && !ValidaAño(Fecha.Substring(6, 4)))
            {
                Console.WriteLine("LA FECHA NO ES VÁLIDA, PROPORCIONE OTRA");
                Fecha = Leer.String();
            }

            mF.AgregarFactura(ClaveFact, ClaveProv, Importe, Fecha.Substring(0, 2), Fecha.Substring(3, 2), Fecha.Substring(6, 4));
            Console.WriteLine(mF.ImprimeIndividual(ClaveFact));
            CapturaArticulos(ClaveFact, ClaveProv);
        }
        public void CapturaArticulos(int ClaveFactura,int ClaveProv)
        {
            Console.WriteLine("***AGREGANDO ARTÍCULOS A LA FACTURA***");
            int TotalArt, CantArt;
            float Imp = 0, TotalImp = 0;
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
                Console.WriteLine("INTRODUZCA LA CANTIDAD DE DICHO ARTÍCULO");
                CantArt = Leer.Int();
                while (!ValidaValor(CantArt) || CantArt>3)
                {
                    Console.WriteLine("CANTIDAD NO ACEPTADA, PROPORCIONE OTRA CANTIDAD");
                    CantArt = Leer.Int();
                }
                TotalArt -= CantArt;
                Imp = CantArt * mA.RetornaArticulo(ClaveArt).pPrecio;//<-----SE GENERA OTRO IMPORTE¿?
                TotalImp += Imp;
                mD.AgregarDetalle(ClaveFactura, ClaveArt, CantArt, Imp);
            }
            mP.ObtieneProveedor(ClaveProv).pSaldo += TotalImp;//HACER MÉTODO QUE RETORNE UN PROVEEDOR POR MEDIO DE LA CLAVE
            //ACTUALIZAR IMPORTE A LA FACTURA¿?

        }
        public bool ValidaAño(string Año)
        {
            int A = int.Parse(Año);
            if (A > 2019)
                return false;
            return true;
        }
        public bool ValidaValor(float Valor)
        {
            if (Valor <= 0)
                return false;
            return true;
        }
    }
}
