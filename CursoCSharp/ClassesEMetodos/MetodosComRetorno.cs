using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    class CalculadoraComun
    {
        public int Somar(int a, int b)
        { 
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Dividir(int a, int b)
        {
            return a / b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

    }


    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }        
        
        public CalculadoraCadeia Dividir(int a)
        {
            memoria /= 2;
            return this;
        }
 

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var CalculadoraComun = new CalculadoraComun();

            Console.WriteLine(CalculadoraComun.Somar(1, 4));
            Console.WriteLine(CalculadoraComun.Dividir(10, 2));
            Console.WriteLine(CalculadoraComun.Multiplicar(2, 5));

            var calculadoraCadeia = new CalculadoraCadeia();

            calculadoraCadeia.Somar(20).Multiplicar(10).Dividir(2).Imprimir();
        }
        
    }    
}
