using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace F6.Helpers
{
    public class Randomico
    {
        private Random random;

        public Randomico()
        {
            random = new Random();
        }

        public char RandomZeroOuUm()
        {
            var rand = ProximoInt(2);

            ///return rand >= 0.5 ? '1' : '0';
            ///
            if(rand == 0)
            {
                return '0';
            }
            else
            {
                return '1';
            }
        }

        public int ProximoInt(int limiteNaoInclusivo)
        {
            return RandomNumberGenerator.GetInt32(limiteNaoInclusivo);
            ////return this.random.NextDouble();
        }
    }
}
