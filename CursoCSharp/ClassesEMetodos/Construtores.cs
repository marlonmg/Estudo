﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;
       public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() { }
    }
           
    class Construtores
    {
        //Construtor padrão
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Modelo = "325i";
            carro1.Fabricante = "BMW";
            carro1.Ano = 2018;
            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");


            var carro2 = new Carro("KA","FORD",2019);
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");
        }
    }
}
