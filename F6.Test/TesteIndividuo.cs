using F6.Entidades;
using F6.Helpers;
using F6.Test.Auxiliar;

namespace F6.Test
{
    public class TesteIndividuo
    {
        [Fact]
        public void VerificaConversaoBase10()
        {
            var individuo = this.ObtemIndividuoExemplo();

            Assert.Equal(165377, individuo.ConvertXBase10());
            Assert.Equal(2270139, individuo.ConvertYBase10());
        }

        [Fact]
        public void TestaValorXY()
        {
            var individuo = this.ObtemIndividuoExemplo();

            Assert.Equal(-92.11420, individuo.X());
            Assert.Equal(8.24868, individuo.Y());
        }

        [Fact]
        public void TestaFitness()
        {
            var individuo = this.ObtemIndividuoExemplo();
            Assert.Equal(0.50507, individuo.Aptidao());
        }

        [Theory]
        [Repeat(1000)]
        public void TestaRandomicidade()
        {
            var indi = new Individuo();
            indi.CriaGenesRandomicos();

            var indi2 = new Individuo();
            indi2.CriaGenesRandomicos();

            Assert.NotEqual(indi.X(), indi2.X());
            Assert.NotEqual(indi.Y(), indi2.Y());
        }

        private Individuo ObtemIndividuoExemplo()
        {
            var individuo = new Individuo();
            individuo.Genes[0] = '0';
            individuo.Genes[1] = '0';
            individuo.Genes[2] = '0';
            individuo.Genes[3] = '0';
            individuo.Genes[4] = '1';
            individuo.Genes[5] = '0';
            individuo.Genes[6] = '1';
            individuo.Genes[7] = '0';
            individuo.Genes[8] = '0';
            individuo.Genes[9] = '0';
            individuo.Genes[10] = '0';
            individuo.Genes[11] = '1';
            individuo.Genes[12] = '1';
            individuo.Genes[13] = '0';
            individuo.Genes[14] = '0';
            individuo.Genes[15] = '0';
            individuo.Genes[16] = '0';
            individuo.Genes[17] = '0';
            individuo.Genes[18] = '0';
            individuo.Genes[19] = '0';
            individuo.Genes[20] = '0';
            individuo.Genes[21] = '1';

            individuo.Genes[22] = '1';
            individuo.Genes[23] = '0';
            individuo.Genes[24] = '0';
            individuo.Genes[25] = '0';
            individuo.Genes[26] = '1';
            individuo.Genes[27] = '0';
            individuo.Genes[28] = '1';
            individuo.Genes[29] = '0';
            individuo.Genes[30] = '1';
            individuo.Genes[31] = '0';
            individuo.Genes[32] = '0';
            individuo.Genes[33] = '0';
            individuo.Genes[34] = '1';
            individuo.Genes[35] = '1';
            individuo.Genes[36] = '1';
            individuo.Genes[37] = '0';
            individuo.Genes[38] = '1';
            individuo.Genes[39] = '1';
            individuo.Genes[40] = '1';
            individuo.Genes[41] = '0';
            individuo.Genes[42] = '1';
            individuo.Genes[43] = '1';

            return individuo;
        }
    }
}