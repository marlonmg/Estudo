using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    class Abstract
    {
        public abstract class Celular
        {
            public abstract string Assistente();

            public string Tocar()
            {
                return "Trim....trim......trim......";
            }
        }
        public class Samsung : Celular
        {
            public override string Assistente()
            {
                return "Olá meu nome é Bixby";
            }
        }

        public class Iphone : Celular
        {
            public override string Assistente()
            {
                return "Olá meu nome é Siri";
            }
        }

        public static void Executar()
        {
            var Celulares = new List<Celular>{
            new Iphone(),
            new Samsung()
        };
            foreach(var celular in Celulares)
            {
                Console.WriteLine(celular.Assistente());
                Console.WriteLine(celular.Tocar());
            }
        }
    }
}
