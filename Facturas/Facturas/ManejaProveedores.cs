using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class ManejaProveedores
    {
        private Dictionary<int, Proveedor> proveedores;

        public ManejaProveedores()
        {
            proveedores = new Dictionary<int, Proveedor>();
        }

        public void AgregaProveedor(int Clave, String RFC, String nombre, String domicilio)
        {
            proveedores.Add(Clave, new Proveedor(RFC, nombre, domicilio));
        }

        public int BuscarPosNombre(String nombre)
        {
            foreach (KeyValuePair<int, Proveedor> pair in proveedores)
            {
                if (pair.Value.pNombre.CompareTo(nombre) == 0)
                    return pair.Key;
            }
            return -1;
        }
        public bool RFCExistente(String RFC)
        {
            foreach (KeyValuePair<int, Proveedor> pair in proveedores)
            {
                if (pair.Value.pRFC.CompareTo(RFC) == 0)
                    return true;
            }
            return false;
        }
        public bool NombreExistente(String nombre)
        {
            foreach (KeyValuePair<int, Proveedor> pair in proveedores)
            {
                if (pair.Value.pNombre.CompareTo(nombre) == 0)
                    return true;
            }
            return false;
        }

        public bool ClaveExistente(int clave)
        {
            return proveedores.ContainsKey(clave);
        }

        public String Imprimir()
        {
            String salida = "\nPROVEEDORES\n";
            foreach (KeyValuePair<int, Proveedor> pair in proveedores)
            {
                salida += String.Format("CLAVE : {0}{1}", pair.Key, pair.Value.ToString());
                salida += "\n---------------------------\n";
            }
            return salida;
        }
        public Proveedor RetornaProveedorNom(string Nombre)
        {
            foreach (KeyValuePair<int, Proveedor> pair in proveedores)
            {
                if (pair.Value.pNombre.CompareTo(Nombre) == 0)
                    return pair.Value;
            }
            return null;
        }
        public int getPosClave(int clave)
        {
            foreach (KeyValuePair<int, Proveedor> pair in proveedores)
            {
                if (pair.Key == clave)
                    return pair.Key;
            }
            return -1;
        }
        public Proveedor RetornaProveedorClave(int clave)
        {
            if (proveedores.TryGetValue(clave, out Proveedor P))
                return P;
            return null;
        }
        public string ConsultaSaldos(string Nombre)
        {
            int Proveedor = -1;
            float Saldo = 0;
            string msj = "";
            foreach (KeyValuePair<int, Proveedor> pair in proveedores)
            {
                if (pair.Value.pNombre.CompareTo(Nombre) == 0)
                {
                    Proveedor = pair.Key;
                    Saldo = pair.Value.pSaldo;
                    break;
                }
            }
            if (Proveedor == -1)
                return "NO SE ENCONTRÓ DICHO PROVEEDOR EN EL SISTEMA";

            return msj + "\nPROVEEDOR: " + Nombre + "\nCLAVE: " + Proveedor + "\nSALDO: $" + Saldo;
        }
        public int GetClave(String nombre)
        {
            foreach (var item in proveedores)
            {
                if (item.Value.pNombre.Equals(nombre))
                {
                    return item.Key;
                }
            }
            return -1;
        }
        public int pCount
        {
            get
            {
                return proveedores.Count;
            }
        }

        public Proveedor[] GetProveedores()
        {
            Proveedor[] array = new Proveedor[proveedores.Count];
            int i = 0;
            foreach (var item in proveedores)
            {
                array[i] = item.Value;
                i++;
            }
            return array;
        }
        public int[] GetClaves()
        {
            int[] array = new int[proveedores.Count];
            int i = 0;
            foreach (var item in proveedores)
            {
                array[i] = item.Key;
                i++;
            }
            return array;
        }
    }
}
