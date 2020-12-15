using System;
using System.Globalization;
using System.Collections.Generic;
using ExerLinq.Entities;
using System.IO;
using System.Linq;

namespace ExerLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;

            Console.Write("Local do arquivo: ");
            string path = Console.ReadLine();

            Console.Write("Salrio: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Empregados> list = new List<Empregados>();

            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream){
                    string[] linha = sr.ReadLine().Split(',');
                    string nome = linha[0];
                    string email = linha[1];
                    double salario = double.Parse(linha[2], CultureInfo.InvariantCulture);

                    list.Add(new Empregados(nome, email, salario));
                }
            }

            var emailSalario = list.Where(e => e.Salario > salarioBase).OrderBy(e => e.Email).Select(e => e.Email);
            Console.WriteLine("Email of people whose salary is more than 2000.00: ");
            foreach (string email in emailSalario)
            {
                Console.WriteLine(email);
            }

            var nomeSalario = list.Where(e => e.Name.StartsWith("M")).Select(e => e.Salario);
            foreach (double sal in nomeSalario)
            {
                sum += sal;
            }
            Console.Write("\nSum of salary of people whose namee starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
