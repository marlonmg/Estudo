using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Som { get; set; }

        public Animal(string nome, string som)
        {
            Nome = nome;
            Som = som;
        }
    }
    public class Cachorro : Animal
    {
        public double Altura { get; set; }
        public Cachorro(string nome, string som) : base(nome,som)
        {

        }
        public Cachorro(string nome, string som, double altura) : this(nome,som)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return Nome + Altura;
        }
    }

    public class Gato : Animal
    {
        public string Pelo { get; set; }
        public Gato(string nome, string som) : base(nome, som)
        {
        }
        public Gato(string nome, string som, string pelo) : this(nome, som)
        {
            Pelo = pelo;
        }
        public override string ToString()
        {
            return $" Gato {Nome} faz {Som}";
        }
    }
    class ConstrutorThis
    {
        public static void Executar()
        {
            Cachorro lupi = new Cachorro("Lupi  ", "Late", 0.50);
            Cachorro max = new Cachorro("Max","late");

            Console.WriteLine(lupi);
            Console.WriteLine(max);

            Animal gato = new Gato("Noninha", "mia");
            Gato gato2 = new Gato("negao", "mia", "Preto");
            Console.WriteLine(gato);
            Console.WriteLine(gato2);
        }
    }
}
