using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictonary
    {

        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Home-Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004" + filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("Gladiador"));
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
        }
    }
}
