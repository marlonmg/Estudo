using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Bom comportamento? /N");
            entrada = Console.ReadLine();

            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9 && bomComportamento)
            {
                Console.WriteLine("Passou com louvor");
            }

        }
    }
}
 