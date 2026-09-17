using Xunit;

namespace Combate.App.Tests;

public class TanqueTest
{
    [Fact]
    public void UnTanqueQuedaSinVidaEnDosDisparos()
    {
        var soldado = new Soldado();
        var tanque = new Tanque();

        Assert.True(tanque.EstaVivo());

        soldado.Disparar(tanque);

        Assert.True(tanque.EstaVivo());

        soldado.Disparar(tanque);

        Assert.False(tanque.EstaVivo());
    }
}
