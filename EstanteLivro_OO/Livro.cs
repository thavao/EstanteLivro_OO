using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Livro
{
    public string titulo;
    public string autores;
    public DateOnly dataPublicacao;
    public string editora;
    public string edicao;
    public string ISBN;
    public int quantidadePaginas;

    public Livro()
    {

    }
    public void DefinirTitulo(string t)
    {
        this.titulo = t;
    }
    public void DefinirAutores(string a)
    {
        this.autores = a;
    }
    public void DefinirDataPublicacao(DateOnly d)
    {
        this.dataPublicacao = d;
    }
    public void DefinirEditora(string e)
    {
        this.editora = e;
    }
    public void DefinirEdicao(string ed)
    {
        this.edicao = ed;
    }
    public void DefinirISBN(string i)
    {
        this.ISBN = i;
    }
    public void DefinirQtdPaginas(int p)
    {
        this.quantidadePaginas = p;
    }

    public void ImprimirLivro()
    {
        Console.WriteLine("Informações do Livro:");
        Console.WriteLine($"Título: {this.titulo}");
        Console.WriteLine($"Autores: {this.autores}");
        Console.WriteLine($"Data de Publicação: {this.dataPublicacao}");
        Console.WriteLine($"Editora: {this.editora}");
        Console.WriteLine($"Edição: {this.edicao}");
        Console.WriteLine($"ISBN: {this.ISBN}");
        Console.WriteLine($"Quantidade de Páginas: {this.quantidadePaginas}");
    }
}