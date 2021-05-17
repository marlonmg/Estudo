using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlteraRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlteraOut(out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }

        public static void Executar()
        {
            int a = 3;
            AlteraRef(ref a);
            Console.WriteLine(a);

            
            AlteraOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");
            
        }
    }
}
