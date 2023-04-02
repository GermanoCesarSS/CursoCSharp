using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Nullables
    {
        static int num3;

        public static void Executar() {

            Nullable<int> num1 = null;
            int? num2 = null;

            if(num1.HasValue) {
                Console.WriteLine($"Valor de num: {num1}");
            }
            else {
                Console.WriteLine("A variavel não possui valor");
            }


            int valor = num2 ?? 1000;
            Console.WriteLine(valor);


            bool? bolleana = null;
            bool rs = bolleana.GetValueOrDefault();
            Console.WriteLine(rs);

            try {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            }catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }




        }
    }
}
