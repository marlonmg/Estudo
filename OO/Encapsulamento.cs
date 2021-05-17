using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO
{
    class Encapsulamento
    {
        public class Conhecido{

            public void MeusAcessos()
            {
                SubCelebridade sub = new SubCelebridade();

                Console.WriteLine("Conhecido........");
                Console.WriteLine(sub.InfoPublica);
             //   Console.WriteLine(sub.CorDoOlho);
             //   Console.WriteLine(sub.NumeroCelular);
             //   Console.WriteLine(sub.JeitoDeFalar);
             //   Console.WriteLine(sub.SegredoDeFamilia);
             //   Console.WriteLine(sub.UsaMuitoPhotoshop);
            }

        }
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();
            new FilhoReconhecido().MeusAcessos();
            new FilhoNãoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new Conhecido().MeusAcessos();
        }
    }

}
