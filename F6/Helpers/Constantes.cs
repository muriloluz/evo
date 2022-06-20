using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6.Helpers
{
    public static class Constantes
    {
        public static double Multiplicador =  200 / (Math.Pow(2, 22) - 1);

        public static int CasasDecimais = 6;

        public static int LimiteInferior = -100;

        public static double TaxaMutacao = 0.05;

        public static Randomico Randomico = new Randomico();
    }
}
