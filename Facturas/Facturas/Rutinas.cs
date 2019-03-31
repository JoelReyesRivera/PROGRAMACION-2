using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
