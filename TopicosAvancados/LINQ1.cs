using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{

    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    internal class LINQ1
    {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Gabriel", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Gabriel", Idade = 19, Nota = 8.0},
            };

            Console.WriteLine("== Aprovados =================");
            var aprovados = alunos.Where(a => a.Nota >= 7.0).
                                    OrderBy(a => a.Nome);

            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Chamada ===========================");
            var chamada = alunos.OrderBy(a => a.Nome).
                                    Select(a => a.Nome);

            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Aprovados (por Idade)====================");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;
            foreach (var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }

        }
    }
}
