using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class ExemploLambda {
        public static void Executar() {

            //Action algoNoConsole = () => {
            //    Console.WriteLine("Lambda com CSharp!");
            //};
            Action<string> algoNoConsole = (a) => {
                Console.WriteLine("Lambda com CSharp!" + a);
            };
            algoNoConsole("! ! ! !");


            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogarDado());


            //Func<int, string> conversorHex = (numero) => {
            //    return numero.ToString("X")
            //    };
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format($"{dia:D2}/{mes:D2}/{ano:D4}");
            Console.WriteLine(formatarData(26, 3, 2023));
        }
    }
}
