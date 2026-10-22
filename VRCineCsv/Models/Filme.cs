namespace VRCineCsv.Models;

public class Filme
{
    private int _id;
    private string _titulo = string.Empty;
    private string _sinopse = string.Empty;
    private int _duracaoMinutos;

    public Filme(int id, string titulo, string sinopse, int duracaoMinutos)
    {
        _id = id;
        _titulo = titulo;
        _sinopse = sinopse;
        _duracaoMinutos = duracaoMinutos;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Titulo
    {
        get => _titulo;
        set => _titulo = value;
    }

    public string Sinopse
    {
        get => _sinopse;
        set => _sinopse = value;
    }

    public int DuracaoMinutos
    {
        get => _duracaoMinutos;
        set => _duracaoMinutos = value;
    }
}
