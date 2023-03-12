using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }

        // Atribuição
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() { }
    }

    internal class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3
            };

            // Desconto só pode ser alterado assim
            Produto.Desconto = 0.5;


            Console.WriteLine($"O produto {produto1.Nome} tem seu preço com desconto: {produto1.CalcularDesconto()}");
            Console.WriteLine($"Preço com desconto: {produto2.CalcularDesconto()}");

        }
    }
}
