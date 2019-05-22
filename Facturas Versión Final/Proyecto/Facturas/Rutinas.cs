using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Facturas
{
    public class Rutinas
    {
        public static string ConvierteFecha(int Dia, int Mes, int Año)
        {
            string Fecha = Dia + " de " + ConvierteMes(Mes) + " " + Año;

            return Fecha;
        }
        public static string ConvierteMes(int Mes)
        {
            string[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return Meses[Mes - 1];
        }
        public static bool ValidaTexto(string Cadena)
        {
            foreach (char C in Cadena)
            {
                if (!(Char.IsLetter(C)))
                    return false;
            }
            return true;
        }
        public static bool ValidaTextoNum(string Cadena)
        {
            foreach (char C in Cadena)
            {
                if (C < '0' || C > '9')
                    return false;
            }
            return true;
        }
        public static string CadenaSinEspacios(string Cadena)
        {
            string str = Cadena.Replace(" ", "");
            return str;
        }
        public static bool IsEmpty(string Cadena)
        {
            if (string.IsNullOrWhiteSpace(Cadena) || string.IsNullOrEmpty(Cadena))
                return true;

            return false;
        }
        public static bool validadDecimal(String Numero)
        {
            Regex regex = new Regex(@"^\d+\.+([0-9]{1,2})$");
            Match match = regex.Match(Numero);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
    }
}
