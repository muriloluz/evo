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

        public static int CasasDecimais = 5;

        public static int LimiteInferior = -100;

        public static int TaxaMutacao = 5;

        public static int TaxaRecombinacao = 65;

        public static Randomico Randomico = new Randomico();

        public static int SobreviventesElitismo = 4;

        public static int ParticipantesTorneio = 2;
    }
}
