using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                if (pessoa == "Marlon")

                    Console.WriteLine("Olá {0}", pessoa);
                else
                {
                    Console.WriteLine("Não recepcionar");
                }
            }
        }

        public static void Executar() {

            Recepcionar("Marlon", "Silvana", "Arlete", "Julia", "Claudia");

        }        
    }
}
