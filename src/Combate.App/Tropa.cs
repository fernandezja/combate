namespace Combate.App;

public abstract class Tropa
{
    protected int _vida;

    protected Tropa(int vidaInicial)
    {
        _vida = vidaInicial;
    }

    public int Disparar(Tropa tropa)
    {
        return tropa.RecibirDisparo();
    }

    public int RecibirDisparo()
    {
        _vida--;
        return 1;
    }

    public bool EstaVivo()
    {
        return _vida > 0;
    }
}
