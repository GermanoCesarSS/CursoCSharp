using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
       public static void Executar()
        {

            CultureInfo Culture = new CultureInfo("en-US");

            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final é {totalComDesconto.ToString("F2", Culture)}");

            // IMC

            var peso = 91.2;
            var altura = 1.82;
            var imc = peso / Math.Pow(altura, 2.0);
            Console.WriteLine($"IMC é {imc.ToString("F", Culture)}");

            // Número Par/Impar
            var par = 24;
            var impar = 55;
            Console.WriteLine($"{par} / 2 tem resto {par % 2}");
            Console.WriteLine($"{impar} / 2 tem resto {impar % 2}");
        }
    }
}
