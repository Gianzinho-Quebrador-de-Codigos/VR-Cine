namespace VRCineCsv.Models;

public class ProdutoAlimenticio
{
    private int _id;
    private string _nome = string.Empty;
    private string _descricao = string.Empty;
    private double _preco;
    private bool _disponivel;

    public ProdutoAlimenticio( int id, string nome, string descricao, double preco, bool disponivel)
    {
        _id = id;
        _nome = nome;
        _descricao = descricao;
        _preco = preco;
        _disponivel = disponivel;
    }

}