namespace VRCineCsv.Models;

public class Usuario
{
    private int _id;
    private string _nome = string.Empty;
    private string _email = string.Empty;
    private string _senhaHash = string.Empty;
    private int _perfil;

    public Usuario(int id, string nome, string email, string senhaHash, int perfil)
    {
        _id = id;
        _nome = nome;
        _email = email;
        _senhaHash = senhaHash;
        _perfil = perfil;
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

    public string Email
    {
        get => _email;
        set => _email = value;
    }

    public string SenhaHash
    {
        get => _senhaHash;
        set => _senhaHash = value;
    }

    public int Perfil
    {
        get => _perfil;
        set => _perfil = value;
    }
}
