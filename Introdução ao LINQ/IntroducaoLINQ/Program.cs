using System;
using System.Linq;
using IntroducaoLINQ.Entities;
using System.Collections.Generic;

namespace IntroducaoLINQ
{
    class Program
    {
        static void exibirResultado<T>(string mensangem, IEnumerable<T> lista)
        {
            Console.WriteLine(mensangem);
            foreach (T objeto in lista)
            {
                Console.WriteLine(objeto);
            }
            Console.WriteLine();
        } 
        static void Main(string[] args)
        {
            Categoria c1 = new Categoria() { Id = 1, Nome = "Ferramentas", Tipo = 2 };
            Categoria c2 = new Categoria() { Id = 2, Nome = "Computadores", Tipo = 1 };
            Categoria c3 = new Categoria() { Id = 3, Nome = "Eletronicos", Tipo = 1 };

            List<Produto> listaProdutos = new List<Produto>() {
                new Produto() { Id = 1, Nome = "Computador", Preco = 1100.0, Categoria = c2 },
                new Produto() { Id = 2, Nome = "Microfone", Preco = 600.0, Categoria = c3 },
                new Produto() { Id = 3, Nome = "TV", Preco = 3100.0, Categoria = c3 },
                new Produto() { Id = 4, Nome = "Notebook", Preco = 2000.0, Categoria = c2 },
                new Produto() { Id = 5, Nome = "Som", Preco = 5000.0, Categoria = c3 },
                new Produto() { Id = 6, Nome = "Tablet", Preco = 2200.0, Categoria = c2 },
                new Produto() { Id = 7, Nome = "Câmera", Preco = 4100.0, Categoria = c2 },
                new Produto() { Id = 8, Nome = "Impressora", Preco = 900.0, Categoria = c1 },
                new Produto() { Id = 9, Nome = "MacBook", Preco = 6100.0, Categoria = c1 },
                new Produto() { Id = 10, Nome = "Furadeira", Preco = 1000.0, Categoria = c1 },
                new Produto() { Id = 11, Nome = "Martelo", Preco = 200.0, Categoria = c1 }
               

            };

            // Expressão LINQ - Usei uma lista como uma base de dados
            var r1 = listaProdutos.Where(p => p.Categoria.Tipo == 1 && p.Preco < 900.0);
            exibirResultado("Produtos do Tipo 1 e com Preço menor que R$ 900.0:", r1);

            var r2 = listaProdutos.Where(p => p.Categoria.Nome == "Ferramentas").Select(p => p.Nome);
            exibirResultado("Produtos da Categoria 'FERRAMENTAS' ", r2);

            var r3 = listaProdutos.Where(p => p.Categoria.Tipo == 1).OrderByDescending(p => p.Preco).ThenBy(p => p.Nome);
            exibirResultado("Ordenação Pelo Tipo' ", r3);

        }
    }
}
