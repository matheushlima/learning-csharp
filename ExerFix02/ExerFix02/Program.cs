using System;
using System.Globalization;

namespace ExerFix02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Sálario Bruto: ");
            func.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double saliq = func.SalarioLiquido();

            Console.WriteLine($"\nFuncionario: {func.Nome}, $ {saliq}");

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            func.AumentarSalario(porc);
            saliq = func.SalarioLiquido();
            Console.WriteLine($"\nDados Atualizados: {func.Nome}, $ {saliq.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
