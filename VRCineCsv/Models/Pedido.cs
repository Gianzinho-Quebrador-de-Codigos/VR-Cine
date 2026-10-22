namespace VRCineCsv.Models;

public class Pedido
{
    private int _id;
    private DateTime _dataCriacao;
    private int _status;
    private double _valorDesconto;
    private double _valorTotal;

    public Pedido(int id, DateTime dataCriacao, int status, double valorDesconto, double valorTotal)
    {
        _id = id;
        _dataCriacao = dataCriacao;
        _status = status;
        _valorDesconto = valorDesconto;
        _valorTotal = valorTotal;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public DateTime DataCriacao
    {
        get => _dataCriacao;
        set => _dataCriacao = value;
    }

    public int Status
    {
        get => _status;
        set => _status = value;
    }

    public double ValorDesconto
    {
        get => _valorDesconto;
        set => _valorDesconto = value;
    }

    public double ValorTotal
    {
        get => _valorTotal;
        set => _valorTotal = value;
    }
}
