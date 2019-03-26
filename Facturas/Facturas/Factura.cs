using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas

{
    class Factura
    {
        private int ClaveProv;
        private float Importe;
        private int Dia, Mes, Año;

        public Factura(int ClaveProv, int Dia, int Mes, int Año)
        {
            this.ClaveProv = ClaveProv;
            this.Dia = Dia;
            this.Mes = Mes;
            this.Año = Año;
            Importe = 0;
        }
        public int pClaveProv
        {
            get
            {
                return ClaveProv;
            }
        }
        public float pImporte
        {
            get
            {
                return Importe;
            }
            set
            {
                Importe = value;
            }
        }
        public int pDia
        {
            get
            {
                return Dia;
            }
        }
        public int pMes
        {
            get
            {
                return Mes;
            }
        }
        public int pAño
        {
            get
            {
                return Año;
            }
        }
        public override string ToString()
        {
            return String.Format("\nClave Proveedor: {0}\nImporte: {1}\nDía: {2}\nMes: {3}\nAño: {4}\n", ClaveProv, Importe, Dia, Mes, Año);
        }
    }
}
