using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia

            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * Math.Pow(raio, 2.0);
            Console.WriteLine("Área é: " + area.ToString("F2", CultureInfo.InvariantCulture));

            // Tipos inteiros

            bool EstaChovendo = true;
            Console.WriteLine("Está chovendo " + EstaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte SaldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + SaldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int MenorValorInt = int.MinValue;
            Console.WriteLine("Menor int: " + MenorValorInt);

            uint PopulacaoBrasileira = 207_600_000;
            Console.WriteLine("Populacao Brasileira " + PopulacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial" + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preco do Computador " + precoComputador.ToString(CultureInfo.InvariantCulture));

            double valorDeMerdado = 1_000_000_000_000.00;
            Console.WriteLine("Valor Apple "  + valorDeMerdado);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as estrelas " + distanciaEntreEstrelas);

            char letra = 'B';
            Console.WriteLine("Depois do A vêm o " + letra);

            string texto = "OIiiiiiiiiii";
            Console.WriteLine(texto);

        }
    }
}
