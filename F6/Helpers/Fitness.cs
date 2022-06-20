using F6.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6.Helpers
{
    public static class Fitness
    {
        public static double Calcule(Individuo individuo)
        {
            var x = individuo.X();
            var y = individuo.Y();

            return Calcule(x, y);
        }

        public static double Calcule(double x, double y)
        {
            var parteInterna = Math.Pow(x, 2) + Math.Pow(y, 2);
            var raizParteInterna = Math.Sqrt(parteInterna);

            var parteSuperior = (Math.Pow(Math.Sin(raizParteInterna), 2)) - 0.5;

            var parteInferior = Math.Pow((1.0 + 0.001 * parteInterna), 2);

            var resultado = 0.5 - (parteSuperior / parteInferior);

            return resultado;
        }
    }
}
