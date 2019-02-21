using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class Articulo
    {
        private int Clave;
        private string Descripcion, Marca;
        private float Precio;

        public Articulo(int Clave, string Descripcion,string Marca, float Precio)
        {
            this.Clave = Clave;
            this.Descripcion = Descripcion;
            this.Marca = Marca;
            this.Precio = Precio;
        }
        public int pClave
        {
            get
            {
                return Clave;
            }
        }
        public string pNombre
        {
            get
            {
                return pNombre;
            }
            set
            {
                pNombre = value;
            }
        }
        public string pDescripcion
        {
            get
            {
                return Descripcion;
            }
            set
            {
                Descripcion = value;
            }
        }
        public string pMarca
        {
            get
            {
                return Marca;
            }
            set
            {
                Marca = value;
            }
        }
        public float pPrecio
        {
            get
            {
                return Precio;
            }
            set
            {
                Precio = value;
            }
        }
    }
}
