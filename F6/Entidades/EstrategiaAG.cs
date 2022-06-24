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
            //// Mantendo filhos da geracao anterior para comparacao no grafico, é limpada pelo gráfico e não afeta o algoritmo.
            this.FilhosParaGrafico = this.Filhos.ToList();
            this.Filhos.Clear();

            for (int i = 0; i < this.TamanhoOriginal / 2; i++)
            {
                //var listaPais = this.SelecionaIndividuoMaiorFitness(2);
                //var pai = listaPais.ElementAt(0);
                //var mae = listaPais.ElementAt(1);

                var pai = this.SelecionaProporcionalAptidao();
                var mae = this.SelecionaProporcionalAptidao();

                //var pai = this.SelecionaProporcionalRank();
                //var mae = this.SelecionaProporcionalRank();


                /// TODO: Considerar não repetir individuos

                /// Crossover
                var filhos = Recombinacao.DoisPontos(pai, mae, Constantes.TaxaRecombinacao);

                /// Mutacao
                foreach (var f in filhos)
                {
                    Mutacao.Muta(f, Constantes.TaxaMutacao);
                }

                this.Filhos.AddRange(filhos);
            }

            this.SelecionaSobreviventesElitismo(Constantes.SobreviventesElitismo);
        }

        public List<DataSourceIndividuo> ObtemDataSourcePais()
        {
            var retorno = new List<DataSourceIndividuo>();

            this.Pais.ForEach(p => retorno.Add(p.ConvertDatSource()));

            return retorno;
        }

        private void SelecionaSobreviventesElitismo()
        {
            var melhorPai = this.Pais.OrderByDescending(x => x.Aptidao()).Take(1).FirstOrDefault();

            var selecionaFilhoParaMorrer = Constantes.Randomico.ProximoInt(this.TamanhoOriginal);

            this.Filhos.RemoveAt(selecionaFilhoParaMorrer);

            this.Pais = this.Filhos.ToList();

            this.Pais.Add(melhorPai);
        }

        private void SelecionaSobreviventesElitismo(int n)
        {
            var listaMelhoresPais = this.Pais.OrderByDescending(x => x.Aptidao()).Take(n).ToList();

            var listaFilhosCandidatos = new List<int>();

            while(listaFilhosCandidatos.Count < n)
            {
                var candidato = Constantes.Randomico.ProximoInt(this.TamanhoOriginal);

                if (listaFilhosCandidatos.Contains(candidato))
                {
                    continue;
                }
                else
                {
                    listaFilhosCandidatos.Add(candidato);
                }
            }

            foreach(var indice in listaFilhosCandidatos.OrderByDescending(x=>x))
            {
                this.Filhos.RemoveAt(indice);
            }

            this.Pais = this.Filhos.ToList();
            this.Pais.AddRange(listaMelhoresPais);
        }

        private void SelecionaSobriventesTodosFilhos()
        {
            this.Pais = this.Filhos.ToList();
        }

        private double SomaTotalAptidaoPais()
        {
            double total = this.Pais.Select(x => x.Aptidao()).Sum();

            return total;
        }

        private Individuo SelecionaProporcionalAptidao()
        {
            var aptidaoTotal = this.SomaTotalAptidaoPais();

            var normalizaAptidao = aptidaoTotal * Math.Pow(10, Constantes.CasasDecimais - 1);

            var randomico = (double) Constantes.Randomico.ProximoInt((int)normalizaAptidao) / (double)Math.Pow(10, Constantes.CasasDecimais - 1);
            var selecionadoInicial = 0;
            var aptidaoAcumulada = 0.0;

            for (int i = 0; i < this.TamanhoOriginal; i++)
            {
                aptidaoAcumulada += this.Pais.ElementAt(i).Aptidao();
                if (aptidaoAcumulada < randomico )
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

        private Individuo SelecionaProporcionalRank()
        {
            Dictionary<int, Individuo> rank = new Dictionary<int, Individuo>();
            var listaOrdenadaCrescente = this.Pais.OrderBy(x => x.Aptidao()).ToList();
            Individuo selecionado = null;

            for (int i = 0; i < this.TamanhoOriginal; i++)
            {   
                rank.Add(i + 1, listaOrdenadaCrescente.ElementAt(i));                 
            }

            var somaRank = rank.Select(x => x.Key).Sum();

            var randomico = Constantes.Randomico.ProximoInt(somaRank + 1);

            var selecionadoInicial = 0;
            var rankAcumulado = 0;
            var rankAtual = 0;

            for (int i = 0; i < rank.Keys.Count; i++)
            {
                rankAtual = rank.Keys.ElementAt(i);
                 rankAcumulado += rankAtual;

                if (rankAcumulado < randomico)
                {
                    continue;
                }
                else
                {
                    selecionado = rank[rankAtual] ;
                    break;
                }
            }

            return selecionado;
        }

        private List<Individuo> SelecionaIndividuoMaiorFitness(int quantidade)
        {
            return this.Pais.OrderByDescending(x => x.Aptidao()).Take(quantidade).ToList();
        }
    }
}
