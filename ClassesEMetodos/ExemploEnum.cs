using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    // Enum
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia}

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    // Executavél
    internal class ExemploEnum
    {
        public static void Executar()
        {

            // Conversão
            int id = (int)Genero.Animacao;
            Console.WriteLine(id); // id = 3

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknardo 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine($"{filmeParaFamilia.Titulo} é {filmeParaFamilia.GeneroDoFilme}");
        }
    }
}
