﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class Proveedor
    {
        private string RFC, Nombre, Domicilio;
        private float Saldo;
            
        public Proveedor(string RFC,string Nombre,string Domicilio)
        {
            //LA CLAVE SE ASIGNA EN EL DICCIONARIO
            this.RFC = RFC;
            this.Nombre = Nombre;
            this.Domicilio = Domicilio;
            Saldo = 0;
        }
        public string pRFC
        {
            get
            {
                return RFC;
            }
        }
        public string pNombre
        {
            get
            {
                return Nombre;
            }
        }
        public string pDomicilio
        {
            get
            {
                return Domicilio;
            }
        }
        public float pSaldo
        {
            get
            {
                return Saldo;
            }
            set
            {
                value = Saldo;
            }
        }
        public String ToString()
        {
            return "\nRFC :" + RFC + "\nNOMBRE: " + Nombre + "\nDOMICILIO: " + Domicilio + "\nSALDO: " + Saldo;
        }
    }
}
