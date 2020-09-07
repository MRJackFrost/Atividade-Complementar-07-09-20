using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NotaAluno
{

    class Program
    {

        static void Main(string[] args)
        {
            Aluno aluno;
            aluno = new Aluno();
            Console.WriteLine("Qual o nome do aluno?");
            aluno.name = Console.ReadLine();


            Console.WriteLine("Qual a primeira nota?");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (aluno.Nota1 > 30) {
                Console.WriteLine("Nota invalida, insira novamente");
                aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


            Console.WriteLine("Qual a segunda nota?");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (aluno.Nota2 > 35)
            {
                Console.WriteLine("Nota invalida, insira novamente");
                aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


            Console.WriteLine("Qual a terceira nota?");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (aluno.Nota3 > 35)
            {
                Console.WriteLine("Nota invalida, insira novamente");
                aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double final = aluno.final();
            if (final >= 60)
            {
                Console.WriteLine(aluno.name+" foi aprovado, nota: " + final);
            }
            else {
                double faltou = aluno.reprovado();
                Console.WriteLine(aluno.name+" foi reprovado, nota: "+final+" faltou: "+faltou+" pontos");
            }
            Console.ReadKey();
        }
    }
}
