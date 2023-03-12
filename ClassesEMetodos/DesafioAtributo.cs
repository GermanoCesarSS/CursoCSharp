using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            // Acessar variavél 'a' dentro do método Executar!
            var desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}
