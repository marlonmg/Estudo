using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {

        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Marlon";
            alunos[2] = "Giovane";
            alunos[3] = "Jackson";
            alunos[4] = "Henrique";
            
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.4, 6.8 };
            foreach(var nota in notas)
            {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine("Média: " + media);

            string nome = "";
            char[] letras = { 'M', 'A', 'R', 'L', 'O', 'N' };
            //foreach (var letra in letras)
            //{
            //    nome = letra.ToString();
            //};

            for (int i = 0; i < letras.Length; i++)
            {
                nome += letras[i];
            }

            Console.WriteLine(nome);

        }
    }
}
