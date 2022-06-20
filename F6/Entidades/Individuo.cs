using F6.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F6.Entidades
{
    public class Individuo
    {
        public char[] Genes { get; private set; }

        public Guid Id { get; set; }

        public Individuo()
        {
            this.Genes = new char[44];
            this.Id = Guid.NewGuid();
        }

        public int ConvertXBase10()
        {
            return Convert.ToInt32(new String(this.Genes.Take(new Range(0, 22)).ToArray()), 2);

        }
        public int ConvertYBase10()
        {
            return Convert.ToInt32(new String(this.Genes.Take(new Range(22, 44)).ToArray()), 2);
        }

        public double X()
        {
            return Numeros.Trunca((this.ConvertXBase10() * Constantes.Multiplicador) + Constantes.LimiteInferior);
        }

        public double Y()
        {
            return Numeros.Trunca((this.ConvertYBase10() * Constantes.Multiplicador) + Constantes.LimiteInferior);
        }

        public double Aptidao()
        {
            return Numeros.Trunca(Fitness.Calcule(this));
        }

        public void CriaGenesRandomicos()
        {
            for (int i = 0; i <= 43; i++)
            {
                this.Genes[i] = Constantes.Randomico.RandomZeroOuUm();
            }
        }
    }
}
