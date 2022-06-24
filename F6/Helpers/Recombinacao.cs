using F6.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6.Helpers
{
    public static class Recombinacao
    {
        public static List<Individuo> UmPonto(Individuo pai, Individuo mae, int taxaRecombinacao)
        {
            var random = Constantes.Randomico.ProximoInt(101);

            Individuo filho1;
            Individuo filho2;

            if (random <= taxaRecombinacao)
            {
                filho1 = new Individuo();
                filho2 = new Individuo();

                var ponto = Constantes.Randomico.ProximoInt(pai.Genes.Length);

                for (int i = 0; i <= ponto; i++)
                {
                    filho1.Genes[i] = pai.Genes[i];

                    filho2.Genes[i] = mae.Genes[i];
                }

                for (int j = ponto + 1; j < pai.Genes.Length; j++)
                {
                    filho1.Genes[j] = mae.Genes[j];

                    filho2.Genes[j] = pai.Genes[j];
                }
            }
            else
            {
                filho1 = Clona(pai);
                filho2 = Clona(mae);
            }

            var retorno = new List<Individuo>();

            retorno.Add(filho1);
            retorno.Add(filho2);

            return retorno;
        }

        public static List<Individuo> DoisPontos(Individuo pai, Individuo mae, int taxaRecombinacao)
        {
            var random = Constantes.Randomico.ProximoInt(101);

            Individuo filho1;
            Individuo filho2;


            if (random <= taxaRecombinacao /*&& HammingDistance(pai,mae) >= 8*/) 
            {
                var pontoUm = Constantes.Randomico.ProximoInt(pai.Genes.Length);
                var pontoDois = Constantes.Randomico.ProximoInt(pai.Genes.Length);

                var pontoMenor = (pontoUm < pontoDois) ? pontoUm : pontoDois;
                var pontoMaior = (pontoUm >= pontoDois) ? pontoUm : pontoDois;

                filho1 = new Individuo();
                filho2 = new Individuo();

                for (int i = 0; i <= pontoMenor; i++)
                {
                    filho1.Genes[i] = pai.Genes[i];
                    filho2.Genes[i] = mae.Genes[i];
                }

                for (int j = pontoMenor + 1; j <= pontoMaior; j++)
                {
                    filho1.Genes[j] = mae.Genes[j];
                    filho2.Genes[j] = pai.Genes[j];
                }

                for (int w = pontoMaior + 1; w < pai.Genes.Length; w++)
                {
                    filho1.Genes[w] = pai.Genes[w];
                    filho2.Genes[w] = mae.Genes[w];
                }
            }
            else
            {
                filho1 = Clona(pai);
                filho2 = Clona(mae);
            }

            var retorno = new List<Individuo>();

            retorno.Add(filho1);
            retorno.Add(filho2);

            return retorno;
        }

        private static Individuo Clona(Individuo pai)
        {
            var filho = new Individuo();

            for (int i = 0; i < pai.Genes.Length; i++)
            {
                filho.Genes[i] = pai.Genes[i];
            }

            return filho;
        }

        private static int HammingDistance(Individuo pai, Individuo mae)
        {
            var distancia = 0;

            for(int i = 0; i < pai.Genes.Length; i++)
            {
                if(pai.Genes[i] != mae.Genes[i])
                {
                    distancia++;
                }
            }

            return distancia;
        }
    }
}
