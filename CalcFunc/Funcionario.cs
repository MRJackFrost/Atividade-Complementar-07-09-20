using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcFunc
{
    public class Funcionario
    {
        public string name;
        public double salarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            double calc = salarioBruto - imposto;
            return calc;
        }
        public double AumentoSalario(double percent)
        {
            double calc = (salarioBruto * percent) / 100;
            return calc;
        }
    }
}
