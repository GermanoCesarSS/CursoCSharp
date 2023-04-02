using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CursoCSharp.Api
{

    public static class ExtensaoString
    {
        public static String ParseHome(this string path) {
            string home = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            return path.Replace("~", home);
        }
    }

    internal class PrimeiroArquivo
    {
        public static void Executar() {
            // Caminhos // Path
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)){
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo.");
                }
            }

            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adcionar");
                sw.WriteLine("mais texto.");
            }

        }
    }
}
