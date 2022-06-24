using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6.Entidades
{
    public class DataSourceExecucoes
    {
        public DataSourceExecucoes(int sequencia, Individuo melhorIndividuo)
        {
            this.Id = sequencia;
            this.Aptidao = melhorIndividuo.Aptidao();
            this.X = melhorIndividuo.X();
            this.Y = melhorIndividuo.Y();
        }

        public int Id { get; set; }

        public double Aptidao { get; set; }

        public double X { get; set; }

        public double Y { get; set; }
    }
}
