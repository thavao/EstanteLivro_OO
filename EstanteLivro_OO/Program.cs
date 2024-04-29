int tamanhoEstante, opcao;


Livro CriarLivro()
{
    Livro novoLivro = new Livro();

    Console.Write("Digite o nome do livro: ");
    novoLivro.DefinirTitulo(Console.ReadLine());

    Console.Write("Digite o autor do livro: ");
    novoLivro.DefinirAutores(Console.ReadLine());

    Console.Write("Digite a data de publicação do livro: ");
    novoLivro.DefinirDataPublicacao(DateOnly.Parse(Console.ReadLine()));

    Console.Write("Digite a editora do livro: ");
    novoLivro.DefinirEditora(Console.ReadLine());

    Console.Write("Digite a edição do livro: ");
    novoLivro.DefinirEdicao(Console.ReadLine());

    Console.Write("Digite o ISBN do livro: ");
    novoLivro.DefinirISBN(Console.ReadLine());

    Console.Write("Digite a quantidae de páginas do livro: ");
    novoLivro.DefinirQtdPaginas(int.Parse(Console.ReadLine()));


    return novoLivro;
}

Livro[] InserirLivrosNaEstante(Livro[] es)
{
    for (int i = 0; i < tamanhoEstante; i++)
    {
        Console.WriteLine();
        Console.WriteLine($"Cadastre o {i + 1}º livro");
        es[i] = CriarLivro();
        Console.WriteLine();
    }
    return es;
}

void ImprimirEstante(Livro[] es)
{
    Console.WriteLine();
    Console.WriteLine("----Livros na estante----");
    for (int i = 0; i < tamanhoEstante; i++)
    {
        Console.WriteLine("---------------------------------");
        es[i].ImprimirLivro();
    }
}
void ImprimirLivroEspecifico(Livro[] es, int indice)
{
    es[indice].ImprimirLivro();
}



Console.Write("Defina o tamanho da estante: ");
tamanhoEstante = int.Parse(Console.ReadLine());

Livro[] estante = new Livro[tamanhoEstante];


do
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Inserir livros na estante");
    Console.WriteLine("2 - Ver livros da estante");
    Console.WriteLine("3 - Ver 1 livro da estante");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            estante = InserirLivrosNaEstante(estante);
            break;
        case 2:
            ImprimirEstante(estante);
            break;
        case 3:
            Console.WriteLine("Digite a posição do livro na estante");
            ImprimirLivroEspecifico(estante, int.Parse(Console.ReadLine()) + 1);
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }
    Console.WriteLine("Pressione Enter para continuar...");
    Console.ReadLine();
} while (true);