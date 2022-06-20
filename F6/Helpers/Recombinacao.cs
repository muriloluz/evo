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
        public static List<Individuo> UmPonto(Individuo pai, Individuo mae)
        {
            var filho1 = new Individuo();
            var filho2 = new Individuo();

            var ponto = Constantes.Randomico.ProximoInt(pai.Genes.Length);

            for(int i = 0; i <= ponto; i++)
            {
                filho1.Genes[i] = pai.Genes[i]; 
                filho2.Genes[i] = mae.Genes[i];
            }

            for(int j = pai.Genes.Length - 1; j > ponto; j--)
            {
                filho1.Genes[j] = mae.Genes[j];
                filho2.Genes[j] = pai.Genes[j];
            }

            var retorno = new List<Individuo>();

            retorno.Add(filho1);
            retorno.Add(filho2);

            return retorno;
        }
    }
}
