using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6.Helpers
{
    public static class Numeros
    {
        public static double Trunca(double numero)
        {
            return (Math.Truncate(numero * Math.Pow(10, Constantes.CasasDecimais))) / Math.Pow(10, Constantes.CasasDecimais);
        }

        public static double Arredonda(double numero)
        {
            return Math.Round(numero, Constantes.CasasDecimais);
        }
    }
}
