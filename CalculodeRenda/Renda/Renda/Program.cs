using Renda.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Renda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ic = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ic == 'i' || ic == 'I')
                {
                    Console.Write("Health expenditure: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PessoaFisica(name, income, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numfun = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(name, income, numfun));
                }
            }

            Console.WriteLine("");

            Console.WriteLine("TAXES PAID: ");

            double totalImposto = 0.0;
            foreach(Pessoa pessoa in list)
            {
                Console.WriteLine($"{pessoa.Nome}: $ {pessoa.Imposto().ToString("F2", CultureInfo.InvariantCulture)}");

                totalImposto += pessoa.Imposto();
            }

            Console.WriteLine("\nTOTAL TAXES: $" + totalImposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
