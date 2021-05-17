using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesList
    {
        public class Produto
        {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar(){

            var Livro = new Produto("Game of Thrones", 49.9);
            var carrinho = new List<Produto>();
            carrinho.Add(Livro);

            var Combo = new List<Produto>() {
                new Produto("Camisa",10),
                new Produto("Ultima temporada DVD",100),
                new Produto("Poster",9.9)
            };

            carrinho.AddRange(Combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(2);

            foreach(var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome},{item.Preco}");
            }
        }        
    }
}
