using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class MetodosEstaticos
    {

        public class CalcEstatica
        {
            // Método de instância
            public int Multiplicar(int a, int b)
            {
                return a * b;
            }

             //Unica copia e compartilhado com as outras estancias
             //Método de Classe ou Método estático!!

            public static int Somar(int a, int b)
            {
                return a + b;
            }
        }

        public static void Executar()
        {
            // Método normal
            CalcEstatica cal = new CalcEstatica();
            var resultado = cal.Multiplicar(2, 2);
            Console.WriteLine($"Resultado: {resultado}");

            // Método Estático
            Console.WriteLine($"Resultado: {CalcEstatica.Somar(2, 2)}");
        }
    }
}
