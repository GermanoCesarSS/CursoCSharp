using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    // Classe sem poder herdar
    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_407;
        }
    }

    //class SouFilho : SemFilho { }

    class Avo {
        public virtual bool HorarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public sealed override bool HorarNomeFamilia() {
            return true;
        }
    }

    class FilhoRebelde : Pai {
        //public override bool HonrarNomeFamilia() {
        //    return false;
        //}
    } 

    internal class Sealed {
        static public void Executar() {

            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HorarNomeFamilia());


        }
    }
}
