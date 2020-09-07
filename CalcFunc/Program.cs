using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CalcFunc;

namespace CalcFunc
{

    }
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario novo;
            novo = new Funcionario();
            Console.WriteLine("Qual o nome do funcionario?");
            novo.name = Console.ReadLine();
            Console.WriteLine("Qual o salario bruto do funcionario?");
            novo.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Qual o imposto sobre este funcionario?");
            novo.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double full = novo.SalarioLiquido();
            Console.WriteLine("Funcionario: "+novo.name+", Salario: R$"+full);
          
            Console.WriteLine("Qual porcentagem este funcionario ganhara de aumento?");
            double porcentagem = novo.AumentoSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            full += porcentagem;

            Console.WriteLine("Funcionario: " + novo.name + ", Salario: R$" + full);
            Console.ReadKey();

        }
    }

