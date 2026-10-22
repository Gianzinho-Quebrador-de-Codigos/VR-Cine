namespace VRCineCsv.Models;

public class Avaliacao
{
    private int _id;
    private int _notaFilme;
    private int _notaConforto;
    private string _comentario = string.Empty;
    private DateTime _dataAvaliacao;

    public Avaliacao(int id, int notaFilme, int notaConforto, string comentario, DateTime dataAvaliacao)
    {
        _id = id;
        _notaFilme = notaFilme;
        _notaConforto = notaConforto;
        _comentario = comentario;
        _dataAvaliacao = dataAvaliacao;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public int NotaFilme
    {
        get => _notaFilme;
        set => _notaFilme = value;
    }

    public int NotaConforto
    {
        get => _notaConforto;
        set => _notaConforto = value;
    }

    public string Comentario
    {
        get => _comentario;
        set => _comentario = value;
    }

    public DateTime DataAvaliacao
    {
        get => _dataAvaliacao;
        set => _dataAvaliacao = value;
    }
}
