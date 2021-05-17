using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ReadOnly
    {
        public class Cliente
        {
            public string Nome;
            readonly DateTime Nascimento;

            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }

            public string GetDataDeNascimento()
            {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }
        }
        public static void Executar()
        {
            var cliente = new Cliente("Marlon", new DateTime(1985,8,17));
            Console.WriteLine(cliente.GetDataDeNascimento());


        }
    }
}
