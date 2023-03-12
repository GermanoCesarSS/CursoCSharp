using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class CalculadoraCadeia
    {
        // Atributo
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }

    // Executavél
    internal class MetodosComRetorno
    {
        public static void Executar()
        {

            var calComum = new CalculadoraComum();
            var resultado = calComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calComum.Subtrair(2, 7));
            Console.WriteLine(calComum.Multiplicar(2, 4));


            var calCadeia = new CalculadoraCadeia();
            calCadeia.Somar(3).Multiplicar(3).Imprimir()
                     .Limpar().Imprimir();

            resultado = calCadeia.Somar(3).Multiplicar(2)
                                 .Resultado();

            Console.WriteLine(resultado);

        }
    }
}
