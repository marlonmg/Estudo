using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    class Heranca
    {
        public class Carro
        {
            protected readonly int VelocidadeMaxima;
            int VelocidadeAtual;

            public Carro()
            {

            }
            public Carro(int velocidadeMaxima)
            {
                VelocidadeMaxima = velocidadeMaxima;
            }

            protected int AlterarVelocidade(int delta)
            {
                int novaVelocidade = VelocidadeAtual + delta;

                if(VelocidadeAtual < 0)
                {
                    VelocidadeAtual = 0;
                } else if(novaVelocidade > VelocidadeMaxima)
                {
                    VelocidadeAtual = VelocidadeMaxima;
                }
                else
                {
                    VelocidadeAtual = novaVelocidade;
                }
                return VelocidadeAtual;
            }
            
            public virtual int Acelerar()
            {
                return AlterarVelocidade(5);
            }
            public int Freiar()
            {
                return AlterarVelocidade(-5);
            }
        }

        public class Uno : Carro
        {
            public Uno() : base(200)
            {

            }
        }
        public class Ferrari : Carro
        {
            public Ferrari() : base(350)
            {

            }
            public override int Acelerar()
            {
                return AlterarVelocidade(15);
            }

            //Oculta o método da classe pai
            public new int Freiar()
            {
                return AlterarVelocidade(-15);
            }
        }
        public static void Executar()
        {
            Console.WriteLine("Uno.....");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Freiar());
            Console.WriteLine(carro1.Freiar());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Freiar());
            Console.WriteLine(carro2.Freiar());

        }
    }
}
