using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotaAluno
{
    public class Aluno
    {
        public string name;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double final()
        {
            double calc = Nota1 + Nota2 + Nota3;
            return calc;
        }
        public double reprovado()
        {
            double calc = Nota1 + Nota2 + Nota3;
            calc -= 60;
            return calc;
        }
    }
}
