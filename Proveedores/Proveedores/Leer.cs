using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class Leer
    {
        public static int Int()
        {
            int value;
            do
            {
                try
                {
                    value = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("INGRESE UN NUMERO ENTERO");
                    value = int.MinValue;
                }
            } while (value == int.MinValue);
            return value;
        }

        public static float Float()
        {
            float value;
            do
            {
                try
                {
                    value = float.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("INGRESE UN NUMERO DECIMAL");
                    value = float.MinValue;
                }
            } while (value == float.MinValue);
            return value;
        }

        public static String String()
        {
            String value;
            value = Console.ReadLine();
            if (string.IsNullOrEmpty(value.Trim()))
            {
                do
                {
                    Console.WriteLine("INGRESE UN TEXTO");
                    value = Console.ReadLine();
                } while (string.IsNullOrEmpty(value.Trim()));
            }
            return value.ToUpper();
        }
    }
}
