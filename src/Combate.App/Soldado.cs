namespace Combate.App;

public class Soldado
{
    public string Nombre { get; set; }

    public int Disparar(Soldado soldado)
    {
        return 1;
    }

    public int RecibirDisparo()
    {
        return 1;
    }

    public bool EstaVivo()
    {
        return false;
    }
}
