
using Xunit;

namespace Combate.App.Tests
{
    
    public class SoldadoTest
    {
        [Fact]
        public void UnSoldadoDebeDisparar() {

            var soldado1 = new Soldado();
            var resultado = soldado1.Disparar(soldado1);

            Assert.Equal(expected: 1, actual: resultado);
        }

        [Fact]
        public void UnSoldadoDebeRecibirDisparo()
        {

            var soldado1 = new Soldado();
            var resultado = soldado1.RecibirDisparo();

            Assert.Equal(expected: 1, actual: resultado);
        }


        [Fact]
        public void UnSoldadoMuereEnUnDisparo()
        {

            var soldado1 = new Soldado();
            var soldado2 = new Soldado();


            soldado1.Disparar(soldado2);

            var resultado = soldado2.EstaVivo();

            Assert.Equal(expected: false, actual: resultado);
        }



         [Fact]
        public void UnSoldadoConEscudoMuereDeDosDisparos()
        {

            var soldado1 = new Soldado();
            var soldado2 = new Soldado();
            var escudo1 = new Escudo50();

            soldado2.SetEscudo(escudo1);

            Assert.True(soldado2.EstaVivo());

            soldado1.Disparar(soldado2);

            Assert.True(soldado2.EstaVivo());

            
            soldado1.Disparar(soldado2);

            
            Assert.False(soldado2.EstaVivo());

        }


    }
}
