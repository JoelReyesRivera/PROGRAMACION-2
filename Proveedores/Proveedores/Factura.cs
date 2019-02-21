using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class Factura
    {
        private int ClaveProv;
        private float Importe;
        private int Dia, Mes, Año;

        public Factura(int ClaveProv, float Importe, int Dia, int Mes, int Año)
        {
            this.ClaveProv = ClaveProv;
            this.Importe = Importe;
            this.Dia = Dia;
            this.Mes = Mes;
            this.Año = Año;
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
    }
}
