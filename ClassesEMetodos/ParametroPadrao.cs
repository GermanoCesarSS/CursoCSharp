using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
  
    internal class ParametroPadrao
    {

        
        //public static int Somar(int a = 1, int b = 1) {

        //    return a + b;
        //}


        public static void Executar()
        {
        double calcularMedia(double nota1, double nota2, double nota3, out String conc)
        {
            double media = (nota1 + nota2 + nota3) / 3;
            conc = media >= 7 ? "aprovado" : "reprovado";
            return media;
        }
       
            String conceito;
            double mediaDoAluno = calcularMedia(1.6, 9.4, 5.0, out conceito);
            Console.WriteLine("A media é " + mediaDoAluno + " e o aluno está " + conceito);

            //    Console.WriteLine(Somar(10, 23));
            //    Console.WriteLine(Somar(50));
            //    Console.WriteLine(Somar());
            //    Console.WriteLine(Somar(b: 7));
        }
    }
}
