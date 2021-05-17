using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ValorVsReferencia
    {
        public class Dependente
        {
            public string Nome;
            public int Idade;
        }
        
        public static void Executar()
        {
            Dependente dep = new Dependente();
            dep.Nome = "Marlon";
            dep.Idade = 34;

            Dependente CopiaDep = dep;
            CopiaDep.Idade = 50;
            CopiaDep.Nome = "Peterson";

            Console.WriteLine($"{dep.Nome}{dep.Idade}");
            Console.WriteLine($"{CopiaDep.Nome}{CopiaDep.Idade}");



        }
    }
}
