namespace VRCineCsv.Models;

public class Cupom
{
    private int _id;
    private string _codigo = string.Empty;
    private double _percentualDesconto;
    private DateTime _validade;
    private bool _ativo;

    public Cupom(int id, string codigo, double percentualDesconto, DateTime validade, bool ativo)
    {
        _id = id;
        _codigo = codigo;
        _percentualDesconto = percentualDesconto;
        _validade = validade;
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

    public double PercentualDesconto
    {
        get => _percentualDesconto;
        set => _percentualDesconto = value;
    }

    public DateTime Validade
    {
        get => _validade;
        set => _validade = value;
    }

    public bool Ativo
    {
        get => _ativo;
        set => _ativo = value;
    }
}
