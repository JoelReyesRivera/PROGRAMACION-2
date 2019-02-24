using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class ManejaProveedores
    {
        public Dictionary<int, Proveedor> proveedores;

        public ManejaProveedores()
        {
            proveedores = new Dictionary<int, Proveedor>();
        }

        public void AgregaProveedor(int Clave, String RFC, String nombre, String domicilio)
        {
            proveedores.Add(Clave,new Proveedor (RFC,nombre,domicilio));
        }

        public int BuscarPosNombre(String nombre)
        {
            for (int i = 0; i < proveedores.Count; i++)
            {
                if (proveedores[i].pNombre.Equals(nombre))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool RFCExistente(String RFC)
        {
            for (int i = 0; i < proveedores.Count; i++)
            {
                if (proveedores[i].pRFC.Equals(RFC))
                {
                    return true ;
                }
            }
            return false;
        }
        public bool NombreExistente(String nombre)
        {
            for (int i = 0; i < proveedores.Count; i++)
            {
                if (proveedores[i].pNombre.Equals(nombre))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ClaveExistente(int clave)
        {
            return proveedores.ContainsKey(clave);
        }

        public void Imprimir()
        {
            for (int i = 0; i < proveedores.Count; i++)
            {
                Console.WriteLine(proveedores[i].ToString());
            }
        }

        public Proveedor ObtieneProveedorNombre(String Nombre)
        {
            for (int i = 0; i < proveedores.Count; i++)
            {
                if (proveedores[i].pNombre.Equals(Nombre))
                {
                    return proveedores[i];
                }
            }
            return null;
        }

        public int getPosClave(int clave)
        {
            int count=0;
            foreach (KeyValuePair<int, Proveedor> pair in proveedores)
            {
                if (pair.Key==clave)
                {
                    return count;
                }
                count++;
            }
            return -1;
        }

        public Proveedor ObtieneProveedorClave(int clave)
        {
            Proveedor proveedor=null;
            if (proveedores.TryGetValue(clave, out proveedor))
            {
                return proveedor;
            }
            return proveedor;
        }
    }
}
