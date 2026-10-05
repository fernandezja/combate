namespace Combate.App;

public abstract class Tropa
{
    protected int _vida;
    protected Escudo50 _escudo;

      public void SetEscudo(Escudo50 value  )
    {


        _escudo = value;

        _escudo.SetPortado(this);
    }

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
