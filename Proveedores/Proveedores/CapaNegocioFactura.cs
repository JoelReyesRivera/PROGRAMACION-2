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
            if (mP.pCount == 0)
            {
                Console.WriteLine("NO ES POSIBLE AGREGAR FACTURAS YA QUE NO HAY PROVEEDORES REGISTRADOS");
                return;
            }
            if (mA.pCount == 0)
            {
                Console.WriteLine("NO ES POSIBLE AGREGAR FACTURAS YA QUE NO HAY ARTICULOS REGISTRADOS");
                return;
            }
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
            DateTime fecha = DateTime.Now;
            mF.AgregarFactura(ClaveFact, ClaveProv, fecha.Day, fecha.Month, fecha.Year);
            Console.WriteLine("Factura creada: {0}\n",mF.ImprimeIndividual(ClaveFact));
            CapturaArticulos(ClaveFact, ClaveProv);
        }
        private void CapturaArticulos(int ClaveFactura,int ClaveProv)
        {
            if (mD.DetallesPorFactura(ClaveFactura) >= 3)
            {
                Console.WriteLine("NO SE PUEDEN AGREGAR MAS DETALLES DE FACTURA PARA LA FACTURA INGRESADA");
                return;
            }

            int CantArt, opcion;
            float Precio, TotalImp = 0;
            do
            {
                Console.WriteLine("\t AGREGRA ARTICULO\n1.- SI\n2.- NO");
                opcion = Leer.Int();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("PROPORCIONE LA CLAVE DEL ARTÍCULO");
                        int ClaveArt = Leer.Int();
                        while (mA.BuscaArt(ClaveArt) == -1)
                        {
                            Console.WriteLine("EL ARTÍCULO NO EXISTE, PROPORCIONE OTRA CLAVE");
                            ClaveArt = Leer.Int();
                        }
                        if (mA.pCount - mD.DetallesPorFactura(ClaveFactura) == 0)
                        {
                            Console.WriteLine("NO SE PUEDEN CAPTURAR MAS ARTICULOS A ESTA FACTURA, AGREGUE MAS ARTICULOS AL CATALAGO");
                            return;
                        }
                        while (!(mD.DetalleRepetido(ClaveFactura, ClaveArt) == -1))
                        {
                            Console.WriteLine("NO ES POSIBLE AGRERAR ESTE ARTICULO, YA ESTA REGISTRADO PARA ESTA FACTURA");
                            ClaveArt = Leer.Int();
                        }
                        Console.WriteLine("ARTICULO SELECCIONADO: {0}\n", mA.RetornaArticulo(ClaveArt).ToString());
                        Console.WriteLine("INTRODUZCA LA CANTIDAD DE DICHO ARTÍCULO");
                        CantArt = Leer.Int();
                        while (!ValidaValor(CantArt))
                        {
                            Console.WriteLine("CANTIDAD NO ACEPTADA, PROPORCIONE OTRA CANTIDAD");
                            CantArt = Leer.Int();
                        }
                        Precio = mA.RetornaArticulo(ClaveArt).pPrecio;
                        TotalImp = Precio * CantArt;
                        mD.AgregarDetalle(ClaveFactura, ClaveArt, CantArt, Precio);
                        Console.WriteLine("\n***MOSTRANDO DETALLES AGREGADOS***\n{0}", mD.ImprimeDetallesClave(ClaveFactura));
                        Factura F = mF.RetornaFactura(ClaveFactura);
                        F.pImporte += TotalImp;
                        Proveedor P = mP.RetornaProveedorClave(ClaveProv);
                        P.pSaldo += TotalImp;
                        Console.WriteLine("Importe para la factura {0}", F.pImporte);
                        Console.WriteLine("Saldo del proveedor: $ {0}", P.pSaldo);
                        break;
                    case 2:
                        break;
                }
            } while (opcion != 2);
        }
        public void CapturaArticulos()
        {
            if (mF.pCount == 0)
            {
                Console.WriteLine("NO HAY FACTURAS REGISTRADAS");
                return;
            }
            if (mP.pCount == 0)
            {
                Console.WriteLine("NO HAY PROVEEDORES REGISTRADOS");
                return;
            }
            if (mA.pCount == 0)
            {
                Console.WriteLine("NO HAY ARTICULOS REGISTRADOS");
                return;
            }
            Console.WriteLine("\n***CAPTURANDO ARTICULOS A UNA FACTURA***");
            int ClaveProveedor, ClaveFactura;
            Console.WriteLine("PROPORCIONE EL NUMERO DEL PROVEEDOR: ");
            ClaveProveedor = Leer.Int();
            while (mP.getPosClave(ClaveProveedor) == -1)
            {
                Console.WriteLine("PROVEEDOR NO ENCONTRADO, PROPORCIONE OTRO");
                ClaveProveedor = Leer.Int();
            }
            Console.WriteLine("PROPORCIONE EL NUMERO DE LA FACTURA: ");
            ClaveFactura = Leer.Int();
            while (mF.BuscaFacturaClaveProv(ClaveFactura,ClaveProveedor) == -1)
            {
                Console.WriteLine("EL PROVEEDOR NO CUENTA CON LA FACTURA PROPORCIONADA, INGRESE OTRA");
                ClaveFactura = Leer.Int();
            }
            if (mD.DetallesPorFactura(ClaveFactura) >= 3)
            {
                Console.WriteLine("CAPTURAS MAXIMAS SUPERADAS PARA ESTA FACTURA");
                return;
            }
            if (mA.pCount - mD.DetallesPorFactura(ClaveFactura) ==0 )
            {
                Console.WriteLine("NO SE PUEDEN CAPTURAR MAS ARTICULOS A ESTA FACTURA, AGREGUE MAS ARTICULOS AL CATALAGO");
                return;
            }
            Factura F = mF.RetornaFactura(ClaveFactura);
            Proveedor P = mP.RetornaProveedorClave(ClaveProveedor);
            int CantArt,ClaveArt;
            float Precio, TotalImp = 0;
            Console.WriteLine("PROPORCIONE LA CLAVE DEL ARTÍCULO");
            ClaveArt = Leer.Int();
            while (mA.BuscaArt(ClaveArt) == -1)
            {
                Console.WriteLine("EL ARTÍCULO NO EXISTE, PROPORCIONE OTRA CLAVE");
                ClaveArt = Leer.Int();
            }
            while (mD.DetalleRepetido(ClaveFactura,ClaveArt)!=-1)
            {
                Console.WriteLine("EL ARTICULO YA ESTA CAPTURADO PARA ESA FACTURA");
                Console.WriteLine("PROPORCIONE OTRO ARTICULO: ");
                ClaveArt = Leer.Int();
            }
            Console.WriteLine("ARTICULO SELECCIONADO: {0}\n", mA.RetornaArticulo(ClaveArt).ToString());
            Console.WriteLine("INTRODUZCA LA CANTIDAD DE DICHO ARTÍCULO");
            CantArt = Leer.Int();
            while (!ValidaValor(CantArt))
            {
                Console.WriteLine("CANTIDAD NO VALIDA, PROPORCIONE OTRA CANTIDAD");
                CantArt = Leer.Int();
            }
            Precio = mA.RetornaArticulo(ClaveArt).pPrecio;
            TotalImp = Precio * CantArt;
            mD.AgregarDetalle(ClaveFactura, ClaveArt, CantArt, Precio);
            Console.WriteLine("\n***MOSTRANDO DETALLE AGREGADO***\n{0}", mD.ImprimeDetalleClaveArticulo(ClaveArt));
            F.pImporte += TotalImp;
            P.pSaldo += TotalImp;
            Console.WriteLine("Importe para la factura {0}", F.pImporte);
            Console.WriteLine("Saldo del proveedor: {0}", P.pSaldo);

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
        public void ImprimirDetalleFacturas()
        {
            Console.WriteLine(mD.ImprimeTodo());
        }
        public bool ValidaValor(float Valor)
        {
            if (Valor <= 0)
                return false;
            return true;
        }
    }
}
