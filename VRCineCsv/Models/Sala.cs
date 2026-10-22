namespace VRCineCsv.Models;

public class Sala
{
    private int _id;
    private string _nome = string.Empty;
    private bool _ativa;

    public Sala(int id, string nome, bool ativa)
    {
        _id = id;
        _nome = nome;
        _ativa = ativa;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    public bool Ativa
    {
        get => _ativa;
        set => _ativa = value;
    }
}
