using F6.Entidades;
using F6.Helpers;
using F6.Test.Auxiliar;

namespace F6.Test
{
    public class TesteFitness
    {
        [Fact]
        public void VerificaCasoOtimo()
        {
            var retorno = Fitness.Calcule(0, 0);

            Assert.Equal(1, retorno); 
        }

        [Fact]
        public void VerificaCasoFixo()
        {
            var retorno = Fitness.Calcule(-92.11420, 8.24868);

            Assert.Equal(0.50507, retorno);
        }
    }
}