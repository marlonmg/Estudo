﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();
            fila.Enqueue("Fulano");
            fila.Enqueue("Ciclano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue("TESTE");
            salada.Enqueue(10);
            salada.Enqueue(false);

            foreach (var itens in salada)
            {
                Console.WriteLine(itens);
            }
        }
    }
}