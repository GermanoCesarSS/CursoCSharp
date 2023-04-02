using System;
using System.IO;
namespace CursoCSharp.Api
{
    internal class Diretorios
    {
        public static void Executar() {
            var novoDir = @"~/pastaCSharp".ParseHome();
            var novoDestino = @"~/pastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();


            if(Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true);
            }

            if(Directory.Exists(novoDestino)) {
                Directory.Delete(novoDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("== Pastas =============");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n== arquivos =======================");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n== Raiz ===========================");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDestino);

        }
    }
}
