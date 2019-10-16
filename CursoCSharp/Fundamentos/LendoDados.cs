using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.Write("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual seu salario?");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome},{idade},{salario}" );
        }
    }
}
