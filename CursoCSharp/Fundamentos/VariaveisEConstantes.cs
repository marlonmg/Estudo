using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A area é : " + area);

            bool estaChovendo = true;
            if (estaChovendo == false)
            {
                Console.WriteLine("Não está chovendo");
            }

            else
            {
                Console.WriteLine("Esta chovendo");

            }        
            
        }
    }
}
