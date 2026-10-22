namespace VRCineCsv.Models;

public class Assento
{
    private int _id;
    private string _codigo = string.Empty;
    private bool _ativo;

    public Assento(int id, string codigo, bool ativo)
    {
        _id = id;
        _codigo = codigo;
        _ativo = ativo;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Codigo
    {
        get => _codigo;
        set => _codigo = value;
    }

    public bool Ativo
    {
        get => _ativo;
        set => _ativo = value;
    }
}
