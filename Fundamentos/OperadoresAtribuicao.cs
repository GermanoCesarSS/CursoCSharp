using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = 17
            num1 -= 3; //14
            num1 *= 5; //70
            num1 /= 2; //35

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = 2
            b--; // b = 0

            Console.WriteLine($"{a} {b}");

            // Não se preucupe com o código
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome); // c.nome = Maria

        }
    }
}
