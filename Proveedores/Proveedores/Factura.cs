using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class Factura
    {
        private int Clave;
        private int ClaveProv;
        private float Importe;
        private string Dia, Mes, Año;

        public Factura(int Clave,int ClaveProv, float Importe, string Dia, string Mes, string Año)
        {
            this.Clave = Clave;
            this.ClaveProv = ClaveProv;
            this.Importe = Importe;
            this.Dia = Dia;
            this.Mes = Mes;
            this.Año = Año;
        }
        public int pClave
        {
            get
            {
                return Clave;
            }
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
            return String.Format("\nClave: {0}\nClave Proveedor: {1}\nImporte: {2}\nDía: {3}\nMes: {3}\nAño: {4}\n",Clave,ClaveProv,Importe,Dia,Mes,Año);
        }
    }
}
