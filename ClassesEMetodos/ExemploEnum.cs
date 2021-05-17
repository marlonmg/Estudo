using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ExemploEnum
    {
        public enum Genero { Acao, Aventura, Terrror, Animacao, Comedia};

        public class Filme
        {
            public string Titulo;
            public Genero GeneroDoFilme;
        }
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filme = new Filme();
            filme.Titulo = "Animal";
            filme.GeneroDoFilme = Genero.Comedia;
            Console.WriteLine("{0} é {1}", filme.Titulo,filme.GeneroDoFilme);
        }
    }
}
