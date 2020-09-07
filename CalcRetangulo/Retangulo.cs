using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcRetangulo
{
    public class Retangulo
    {
        public double largura;
        public double altura;

        public double Area()
        {
            double calc = largura * altura;
            return calc;
        }
        public double Perimetro()
        {
            double calc = (2 * largura) + (2 * altura);
            return calc;
        }
        public double Diagonal()
        {
            double calc = (largura * largura) + (altura * altura);
            calc = Math.Sqrt(calc);
            return calc;
        }
    }
}
