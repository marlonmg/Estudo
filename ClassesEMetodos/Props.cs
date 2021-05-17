using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        //Propriedade autoimplementada
        public double Preco { get; set; }

        //Somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //Lambda
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
           
        }
    }
    class Props
    {
        public static void Executar() {

            var op1 = new CarroOpcional("Ar condicionado", 4000.9);
            Console.WriteLine("Preço com desconto: " + op1.PrecoComDesconto + "  Preço normal: " + op1.Preco);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 3000;

            Console.WriteLine(op2.Nome + "" + op2.PrecoComDesconto);           
            

        }
    }
}
