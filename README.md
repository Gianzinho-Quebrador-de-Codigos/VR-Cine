# VR Cine — cadastro iniciante

Abra VRCineCsv.sln no Visual Studio e execute VRCineCsv com Ctrl+F5.

O menu permite cadastrar e listar filmes e cinemas. Program.cs usa Console.ReadLine para receber dados, construtores de Filme e Cinema para criar objetos, File.AppendAllText para gravar e File.ReadAllLines para listar.

As 12 classes continuam em Models, com campos privados, propriedades públicas e construtores. Razor Pages permanece disponível, sem uso.

Os arquivos filmes.csv e cinemas.csv ficam na pasta Dados junto ao executável e permanecem após reiniciar. Cada linha é um cadastro e os campos são separados por ponto e vírgula. Nesta versão introdutória, informe textos sem ponto e vírgula ou aspas e duração como um número inteiro positivo. Não há validação de campos nem tratamento de exceções. O ID usa a quantidade de linhas do arquivo; não exclua registros manualmente e execute uma instância por vez.
