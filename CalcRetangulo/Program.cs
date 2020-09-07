using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CalcRetangulo;

namespace CalcRetangulo
{

    class Program
    {
        static void Main(string[] args)
        {
            Retangulo A;
            A = new Retangulo();
            Console.WriteLine("Qual a altura do retangulo?");
            A.altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Qual a largura do retangulo?");
            A.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;

            double area = A.Area();
            Console.WriteLine("Area do retangulo: "+ area);

            double perimetro = A.Perimetro();
            Console.WriteLine("Perimetro do retangulo: "+perimetro);

            double diagonal = A.Diagonal();
            Console.WriteLine("Diagonal do retangulo: "+diagonal);
            Console.ReadKey();
        }
    }
}
