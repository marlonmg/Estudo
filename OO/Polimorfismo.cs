using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    
    public class Comida
    {
        public double Peso;

        public Comida (double peso)
        {
            Peso = peso;
        }
        public Comida()
        {

        }
    }
        public class Feijao : Comida
        {
            public Feijao(double peso)
        {
            Peso = peso;
        }
        }
        public class Arroz : Comida
        {
            
        }
        public class Carne : Comida
        {
        
        }
        public class Pessoa
        {
            public double Peso = 90;
            public void Comer(Feijao feijao)
            {
                Peso += feijao.Peso;
            
            }
            public void Comer(Arroz arroz)
            {
                Peso += arroz.Peso;
            }

            public void Comer(Carne carne)
            {
                Peso += carne.Peso;
            }                    
        }

    class Polimorfismo
    {
        public static void Executar()
        {
                       
            Feijao ingrediente1 = new Feijao(0.3);
            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.5;
            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 1.0;

            Pessoa pessoa = new Pessoa();
            pessoa.Comer(ingrediente1);
            pessoa.Comer(ingrediente2);
            pessoa.Comer(ingrediente3);

            Console.WriteLine("Pessoa pesa  " + pessoa.Peso);

        }

    }
}
