using VRCineCsv.Models;

string pasta = Path.Combine(AppContext.BaseDirectory, "Dados");
Directory.CreateDirectory(pasta);
string filmes = Path.Combine(pasta, "filmes.csv");
string cinemas = Path.Combine(pasta, "cinemas.csv");

if (!File.Exists(filmes))
    File.WriteAllText(filmes, "Id;Titulo;Sinopse;DuracaoMinutos\n");

if (!File.Exists(cinemas))
    File.WriteAllText(cinemas, "Id;Nome;Endereco\n");

Console.WriteLine("VR CINE");

while (true)
{
    Console.WriteLine("\n1 - Cadastrar filme\n2 - Listar filmes\n3 - Cadastrar cinema\n4 - Listar cinemas\n0 - Sair");
    Console.Write("Opção: ");
    string? opcao = Console.ReadLine();
    if (opcao == "0" || opcao == null) break;

    switch (opcao)
    {
        case "1":
            Console.Write("Título: ");
            string titulo = Console.ReadLine()!;
            Console.Write("Sinopse: ");
            string sinopse = Console.ReadLine()!;
            Console.Write("Duração em minutos: ");
            int duracao = int.Parse(Console.ReadLine()!);

            int idFilme = File.ReadAllLines(filmes).Length;
            Filme filme = new Filme(idFilme, titulo, sinopse, duracao);
            File.AppendAllText(filmes, $"{filme.Id};{filme.Titulo};{filme.Sinopse};{filme.DuracaoMinutos}\n");
            Console.WriteLine("Filme salvo!");
            break;

        case "2":
            foreach (string linha in File.ReadAllLines(filmes))
                Console.WriteLine(linha);
            break;

        case "3":
            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine()!;

            int idCinema = File.ReadAllLines(cinemas).Length;
            Cinema cinema = new Cinema(idCinema, nome, endereco);
            File.AppendAllText(cinemas, $"{cinema.Id};{cinema.Nome};{cinema.Endereco}\n");
            Console.WriteLine("Cinema salvo!");
            break;

        case "4":
            foreach (string linha in File.ReadAllLines(cinemas))
                Console.WriteLine(linha);
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
