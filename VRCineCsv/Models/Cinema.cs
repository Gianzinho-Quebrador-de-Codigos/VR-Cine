namespace VRCineCsv.Models;

public class Cinema
{
    private int _id;
    private string _nome = string.Empty;
    private string _endereco = string.Empty;

    public Cinema(int id, string nome, string endereco)
    {
        _id = id;
        _nome = nome;
        _endereco = endereco;
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

    public string Endereco
    {
        get => _endereco;
        set => _endereco = value;
    }
}
