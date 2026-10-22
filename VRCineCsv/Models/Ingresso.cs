namespace VRCineCsv.Models;

public class Ingresso
{
    private int _id;
    private int _tipo;
    private double _preco;
    private int _status;
    private string _codigoQR = string.Empty;
    private DateTime? _dataEmissao;
    private string _necessidadesVR = string.Empty;

    public Ingresso(int id, int tipo, double preco, int status, string codigoQR, DateTime? dataEmissao, string necessidadesVR)
    {
        _id = id;
        _tipo = tipo;
        _preco = preco;
        _status = status;
        _codigoQR = codigoQR;
        _dataEmissao = dataEmissao;
        _necessidadesVR = necessidadesVR;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public int Tipo
    {
        get => _tipo;
        set => _tipo = value;
    }

    public double Preco
    {
        get => _preco;
        set => _preco = value;
    }

    public int Status
    {
        get => _status;
        set => _status = value;
    }

    public string CodigoQR
    {
        get => _codigoQR;
        set => _codigoQR = value;
    }

    public DateTime? DataEmissao
    {
        get => _dataEmissao;
        set => _dataEmissao = value;
    }

    public string NecessidadesVR
    {
        get => _necessidadesVR;
        set => _necessidadesVR = value;
    }
}
