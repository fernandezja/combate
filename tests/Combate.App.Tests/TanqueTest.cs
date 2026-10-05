using Xunit;

namespace Combate.App.Tests;

public class TanqueTest
{
    [Fact]
    public void UnTanqueQuedaSinVidaEnDosDisparos()
    {
        var tanque = new Soldado();
        var tanque = new Tanque();

        Assert.True(tanque.EstaVivo());

        soldado.Disparar(tanque);

        Assert.True(tanque.EstaVivo());

        soldado.Disparar(tanque);

        Assert.False(tanque.EstaVivo());
    }


    public void UnTanqueConEscudoMuereDeCuatroDisparos()
        {

            var soldado1 = new Soldado();
            var tanque2 = new Tanque();
            var escudo1 = new Escudo50();

            tanque2.SetEscudo(escudo1);

            Assert.True(tanque2.EstaVivo());

            soldado1.Disparar(tanque2);
            soldado1.Disparar(tanque2);
            soldado1.Disparar(tanque2);
            soldado1.Disparar(tanque2);

            
            Assert.False(tanque2.EstaVivo());

        }
}
