using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesArrayList
    {
        public static void Executar() {
            var arraylist = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            arraylist.Add(3.14);

            foreach (object item in arraylist) {
                Console.WriteLine($"{item} => {item.GetType()}");
            }

        }
    }
}
