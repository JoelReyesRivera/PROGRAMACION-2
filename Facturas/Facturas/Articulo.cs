using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    class Articulo
    {
        private int Clave, Cantidad, Count;
        private string Descripcion, Modelo;
        private float Precio;

        public Articulo(string Descripcion, string Modelo, float Precio, int Cantidad)
        {
            Count++;
            Clave = Count;
            this.Descripcion = Descripcion;
            this.Modelo = Modelo;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
        }

        public int pClave
        {
            get { return Clave; }
        }
        public string pNombre
        {
            get { return pNombre; }
            set { pNombre = value; }
        }
        public string pDescripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        public string pModelo
        {
            get { return Modelo; }
            set { Modelo = value; }
        }
        public float pPrecio
        {
            get { return Precio; }
            set { Precio = value; }
        }
    }
}

