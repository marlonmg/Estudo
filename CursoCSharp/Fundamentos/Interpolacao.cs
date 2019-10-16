using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "DELL";
            double preco = 5800.00;

            Console.WriteLine(nome + ' ' + marca + ' ' + preco);
            Console.WriteLine("{0} {1} {2}", nome, marca, preco);
            Console.WriteLine($" {marca} ");
        }
    }
}
