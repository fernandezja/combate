using Xunit;

namespace Combate.App.Tests;

public class CombaeTests
{
    [Fact]
    public void TodosDeberianPoderPreguntarSiEstaVivo()
    {
        var soldado = new Soldado();
        var tanque = new Tanque();
        var buque = new Buque();

        Assert.True(soldado.EstaVivo());
        Assert.True(tanque.EstaVivo());
        Assert.True(buque.EstaVivo());

    }
}
