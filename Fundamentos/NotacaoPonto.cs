using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            // Letra MAIÚSCULA
            var saudacao = "ola".ToUpper() // "OLA"
                .Insert(3, " World!") // "OLA world!"
                .Replace("Wordl!", "Mundo!"); // "OLA Mundo!"

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);

        }
    }
}
