using F6.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6.Entidades
{
    public class Populacao
    {
        public List<Individuo> Individuos { get; set; }

        private int TamanhoOriginal { get; set; }

        public Populacao(int tamanho)
        {
            this.Individuos = new List<Individuo>();
            this.TamanhoOriginal = tamanho;

            for (int i = 0; i < tamanho; i++)
            {
                var ind = new Individuo();
                ind.CriaGenesRandomicos();
                this.Individuos.Add(ind);
            }
        }

        /// <summary>
        /// Usado na técnico da computação evolucionária.
        /// </summary>
        private void ClonaMutaPopulacao()
        {
            for (int p = 0; p < this.TamanhoOriginal; p++)
            {
                var pai = this.Individuos.ElementAt(p);

                var filho = new Individuo();

                for (int i = 0; i < pai.Genes.Length; i++)
                {
                    filho.Genes[i] = pai.Genes[i];
                }

                Mutacao.Muta(filho, Constantes.TaxaMutacao);

                this.Individuos.Add(filho);
            }
        }

        /// <summary>
        /// Corte elitista baseado na ordenação da fitness.
        /// </summary>
        private void CortaPopulacao()
        {
            /// evita ordenacao por aptidao
            var listaGuidRemocao = this.Individuos.OrderByDescending(x => x.Aptidao()).Take(this.TamanhoOriginal).Select(x=>x.Id).ToList();
            
            this.Individuos.RemoveAll(x => !listaGuidRemocao.Contains(x.Id));
        }

        private double SomaTotalAptidao()
        {
            double total = this.Individuos.Select(x => x.Aptidao()).Sum();

            return total;
        }

        private Individuo SelecionaProporcionalAptidao()
        {
            var aptidaoTotal = this.SomaTotalAptidao();
            var normalizaAptidao = aptidaoTotal * 100000;
            var randomico = (double) Constantes.Randomico.ProximoInt((int)normalizaAptidao) / 100000.0;
            var selecionadoInicial = 0;
            var aptidaoAcumulada = 0.0;

            for(int i=0; i < this.TamanhoOriginal; i++)
            {
                aptidaoAcumulada += this.Individuos.ElementAt(i).Aptidao();
                if(randomico > aptidaoAcumulada)
                {
                    continue;
                }
                else
                {
                    selecionadoInicial = i;
                    break;
                }
            }

            return this.Individuos.ElementAt(selecionadoInicial);
        }

        public void EstrategiaPE()
        {
            this.ClonaMutaPopulacao();
            this.CortaPopulacao();
        }

        public void EstrategiaGA1()
        {
            var pai = this.SelecionaProporcionalAptidao();
            var mae = this.SelecionaProporcionalAptidao();

            /// Crossover
            var filhos = Recombinacao.UmPonto(pai, mae);

            /// Mutacao
            foreach (var f in filhos)
            {
                Mutacao.Muta(f, Constantes.TaxaMutacao);
            }

            this.Individuos.AddRange(filhos);

            this.CortaPopulacao();
        }

        public void EstrategiaGA2()
        {
            var pai = this.SelecionaProporcionalAptidao();
            var mae = this.SelecionaProporcionalAptidao();

            while(pai.Id == mae.Id)
            {
                mae = this.SelecionaProporcionalAptidao();
            }

            /// Crossover
            var filhos = Recombinacao.DoisPontos(pai, mae);

            /// Mutacao
            foreach (var f in filhos)
            {
                Mutacao.Muta(f, Constantes.TaxaMutacao);
            }

            this.Individuos.AddRange(filhos);

            this.CortaPopulacao();
        }
    }
}
