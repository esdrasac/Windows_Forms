using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Forms {
    class Eq2grau {
        public double MeuDelta { get; set; }
        public double Raiz1 { get; set; }
        public double Raiz2 { get; set; }
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }


        public void CalcDelta() {
            MeuDelta = Math.Pow(b, 2) - 4 * a * c;
        }

        public void CalcRaizes() {
            Raiz1 = (-b + Math.Sqrt(MeuDelta)) / (2 * a);
            Raiz1 = (-b - Math.Sqrt(MeuDelta)) / (2 * a);
        }

    }
}
