using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class Articulo
    {
        private int Clave, Cantidad;
        private string Descripcion, Marca;
        private float Precio;

        public Articulo(int Clave, string Descripcion, string Marca, float Precio, int Cantidad)
        {
            this.Clave = Clave+1;
            this.Descripcion = Descripcion;
            this.Marca = Marca;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
        }

        public int pClave
        {
            get { return Clave; }
        }
        public string pDescripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        public string pMarca
        {
            get { return Marca; }
            set { Marca = value; }
        }
        public float pPrecio
        {
            get { return Precio; }
            set { Precio = value; }
        }
        public int pCantidad
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
    }
}
