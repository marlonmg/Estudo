using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Struct
    {
       public struct Sponto{
           public int x;
            public int y;
            }
      public class Cponto
        {
            public int x;
            public int y;
        }

        public static void Executar()
        {
            Sponto sponto = new Sponto { x = 1, y = 1 };
            Sponto copiaSponto = sponto;
            copiaSponto.x = 2;         //Atribuição por valor!!

            Console.WriteLine("{0}", sponto.x);
            Console.WriteLine("{0}", copiaSponto.x);

            Cponto cponto = new Cponto { x = 2, y = 5 };
            Cponto copiaCponto = cponto;
            copiaCponto.y = 10;    //Atribuição por referencia!!

            Console.WriteLine("{0}",cponto.y);
            Console.WriteLine("{0}",copiaCponto.y);



        }
    }
}
