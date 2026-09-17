
using Xunit;

namespace Combate.App.Tests
{
    
    public class SoldadoTest
    {
        [Fact]
        public void UnSoldadoDebeDisparar() {

            var soldado1 = new Soldado();
            var resultado = soldado1.Disparar();

            Assert.Equal(expected: 1, actual: resultado);
        }

        [Fact]
        public void UnSoldadoDebeRecibirDisparo()
        {

            var soldado1 = new Soldado();
            var resultado = soldado1.RecibirDisparo();

            Assert.Equal(expected: 1, actual: resultado);
        }


    }
}
