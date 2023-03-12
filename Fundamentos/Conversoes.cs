using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTrunca = (int)nota;
            Console.WriteLine($"Nota truncada: {notaTrunca}");

            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado: {idadeString}");

            Console.WriteLine("Digite um número:");
            //string palavra = Console.ReadLine();
           // int numero;
            int.TryParse(Console.ReadLine(), out int numero);
            Console.WriteLine($"Resultado: {numero}");
        }
    }
}
