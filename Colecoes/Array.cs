using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "A";
            alunos[1] = "B";
            alunos[2] = "C";
            alunos[3] = "D";
            alunos[4] = "E";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }



            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };
            double somatorio = 0;

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);



            char[] letras = { 'A', 'r', 'r', 'a', 'y'};
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
