using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            var marca = "Dell";
            double preco = 5_800.00;

            Console.WriteLine("O " + nome + " da marca "
                + marca + " custa " + preco + ".");
            Console.WriteLine("O {0} da marca {1} custa {2}.",
                nome, marca, preco);
            Console.WriteLine($"A marca {marca} é legal!");
            Console.WriteLine($" 1 + 1 = {1 + 1} A marca {marca} é legal!");
        }
    }
}
