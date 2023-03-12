using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;

        // Valor imutavel
        readonly DateTime Nascimento;
        

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(2023, 01, 08);
        }

        public string GetDataDeNascimento()
        {
            return String.Format($"{Nascimento.Day:D2}/{Nascimento.Month:D2}/{Nascimento.Year}");
        }
    }

    internal class Readonly
    {
        public static void Executar()
        {

            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

            
        }
    }
}
