using System;
using System.Collections.Generic;
using System.Text;
using static CursoCSharp.Colecoes.ColecoesList;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
             public static void Executar(){

            var Livro = new Produto("Game of Thrones", 49.9);
            var carrinho = new HashSet<Produto>();
            carrinho.Add(Livro);

            var Combo = new HashSet<Produto>() {
                new Produto("Camisa",10),
                new Produto("Ultima temporada DVD",100),
                new Produto("Poster",9.9)
            };

            carrinho.UnionWith(Combo);
            Console.WriteLine(carrinho.Count);
     //       carrinho.RemoveAt(2);

            foreach(var item in carrinho)
            {
            //    Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome},{item.Preco}");
            }
        }        
    }
}
