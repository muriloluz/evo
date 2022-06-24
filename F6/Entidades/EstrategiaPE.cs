using F6.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6.Entidades
{
    public class EstrategiaPE
    {
        public List<Individuo> Individuos { get; set; }

        private int TamanhoOriginal { get; set; }

        public EstrategiaPE(int tamanho)
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

        public void Iniciar()
        {
            this.ClonaMutaPopulacao();
            this.CortaPopulacao();
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
            this.Individuos = this.Individuos.OrderByDescending(x => x.Aptidao()).Take(this.TamanhoOriginal).ToList();
        }

        public List<DataSourceIndividuo> ObtemDataSourcePopulacao()
        {
            var retorno = new List<DataSourceIndividuo>();

            this.Individuos.ForEach(p => retorno.Add(p.ConvertDatSource()));

            return retorno;
        }
    }
}
