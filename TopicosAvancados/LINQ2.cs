using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    internal class LINQ2
    {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Gabriel", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Gabriel", Idade = 19, Nota = 8.0},
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(
                          aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null) {
                Console.WriteLine("Aluno Inexistente");
            }

            var gabriel = alunos.First(aluno => aluno.Nome.Equals("Gabriel"));
            Console.WriteLine(gabriel.Nota);

            var sicrano = alunos.FirstOrDefault(
                aluno => aluno.Nota.Equals("Sicrano"));
            if (sicrano == null) {
                Console.WriteLine("Aluno Inexistente!");
            }

            var outroGabriel = alunos.LastOrDefault(
                                aluno => aluno.Nome.Equals("Gabriel"));
            Console.WriteLine(outroGabriel.Nota);

            var exemploSkip = alunos.Skip(1).Take(2);
            foreach (var aluno in exemploSkip) {
                Console.WriteLine(aluno.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(
                aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaDaTurma = alunos.Where(aluno => aluno.Nota >= 7).
                                        Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);



        }
    }
}
