using System;
using System.Globalization;

namespace ExerFix03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notas = aluno.SomaNotas();
            Console.WriteLine("Nota Final = "+notas.ToString("F2",CultureInfo.InvariantCulture));
            string resultado = aluno.Resultado();
            Console.WriteLine(resultado);
        }
    }
}
