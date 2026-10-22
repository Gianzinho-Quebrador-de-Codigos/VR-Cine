namespace VRCineCsv.Models;

public class Sessao
{
    private int _id;
    private DateTime _inicio;
    private DateTime _fim;
    private double _precoInteira;
    private double _precoMeia;
    private bool _cancelada;

    public Sessao(int id, DateTime inicio, DateTime fim, double precoInteira, double precoMeia, bool cancelada)
    {
        _id = id;
        _inicio = inicio;
        _fim = fim;
        _precoInteira = precoInteira;
        _precoMeia = precoMeia;
        _cancelada = cancelada;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public DateTime Inicio
    {
        get => _inicio;
        set => _inicio = value;
    }

    public DateTime Fim
    {
        get => _fim;
        set => _fim = value;
    }

    public double PrecoInteira
    {
        get => _precoInteira;
        set => _precoInteira = value;
    }

    public double PrecoMeia
    {
        get => _precoMeia;
        set => _precoMeia = value;
    }

    public bool Cancelada
    {
        get => _cancelada;
        set => _cancelada = value;
    }
}
