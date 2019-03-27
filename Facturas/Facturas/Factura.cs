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
        private string Dia, Mes, Año;

        public Factura(int ClaveProv, string Dia, string Mes, string Año)
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
        public string pDia
        {
            get
            {
                return Dia;
            }
        }
        public string pMes
        {
            get
            {
                return Mes;
            }
        }
        public string pAño
        {
            get
            {
                return Año;
            }
        }
        public override string ToString()
        {
            return String.Format("\nCLAVE PROVEEDOR: {0}\nIMPORTE: {1}\nDIA: {2}\nMES: {3}\nAÑO: {4}\n",ClaveProv,Importe,Dia,Mes,Año);
        }
    }
}
