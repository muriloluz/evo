using F6.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6.Entidades
{
    public class EstrategiaAG
    {
        public List<Individuo> Pais { get; set; }

        public List<Individuo> Filhos { get; set; }

        public List<Individuo> FilhosParaGrafico { get; set; }

        private int TamanhoOriginal { get; set; }

        public EstrategiaAG(int tamanho)
        {
            this.Pais = new List<Individuo>();
            this.TamanhoOriginal = tamanho;

            for (int i = 0; i < tamanho; i++)
            {
                var ind = new Individuo();
                ind.CriaGenesRandomicos();
                this.Pais.Add(ind);
            }

            this.Filhos = new List<Individuo>();

            this.FilhosParaGrafico = new List<Individuo>();
        }

        public void Iniciar()
        {
            //// Mantendo filhos da geracao anterior para comparacao no grafico
            this.FilhosParaGrafico = this.Filhos.ToList();
            this.Filhos.Clear();

            for (int i = 0; i < this.TamanhoOriginal / 2; i++)
            {
                var pai = this.SelecionaProporcionalAptidao();
                var mae = this.SelecionaProporcionalAptidao();

                while (pai.Id == mae.Id)
                {
                    mae = this.SelecionaProporcionalAptidao();
                }

                /// Crossover
                var filhos = Recombinacao.DoisPontos(pai, mae, Constantes.TaxaRecombinacao);

                /// Mutacao
                foreach (var f in filhos)
                {
                    Mutacao.Muta(f, Constantes.TaxaMutacao);
                }

                this.Filhos.AddRange(filhos);
            }

            this.SelecionaSobreviventesElitismo();
        }

        private void SelecionaSobreviventesElitismo()
        {
            var melhorPai = this.Pais.OrderByDescending(x => x.Aptidao()).Take(1).FirstOrDefault();

            var selecionaFilhoParaMorrer = Constantes.Randomico.ProximoInt(this.TamanhoOriginal);

            this.Filhos.RemoveAt(selecionaFilhoParaMorrer);

            this.Pais = this.Filhos.ToList();

            this.Pais.Add(melhorPai);
        }

        private double SomaTotalAptidaoPais()
        {
            double total = this.Pais.Select(x => x.Aptidao()).Sum();

            return total;
        }

        private Individuo SelecionaProporcionalAptidao()
        {
            var aptidaoTotal = this.SomaTotalAptidaoPais();
            var normalizaAptidao = aptidaoTotal * 100000;
            var randomico = (double)Constantes.Randomico.ProximoInt((int)normalizaAptidao) / 100000.0;
            var selecionadoInicial = 0;
            var aptidaoAcumulada = 0.0;

            for (int i = 0; i < this.TamanhoOriginal; i++)
            {
                aptidaoAcumulada += this.Pais.ElementAt(i).Aptidao();
                if (randomico > aptidaoAcumulada)
                {
                    continue;
                }
                else
                {
                    selecionadoInicial = i;
                    break;
                }
            }

            return this.Pais.ElementAt(selecionadoInicial);
        }
    }
}
