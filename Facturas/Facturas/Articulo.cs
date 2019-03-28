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
        private string Descripcion, Modelo;
        private float Precio;

        public Articulo(int Clave, string Descripcion, string Modelo, float Precio, int Cantidad)
        {
            this.Clave = Clave+1;
            this.Descripcion = Descripcion;
            this.Modelo = Modelo;
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
        public int pCantidad
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
        public override string ToString()
        {
            return string.Format("\nClAVE: {0}\nDESCRIPCION: {1}\nMODELO :{2}\nPRECIO: {3} \nCANTIDAD EN EXISTENCIA: {4}", Clave, Descripcion, Modelo, Precio,Cantidad);
        }
    }
}
