using Company.Entities;
using System;
using System.Collections.Generic;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employess: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> lista = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                string yn = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("value per hour: ");
                double value = double.Parse(Console.ReadLine());
                if (yn == "y" || yn == "Y")
                {
                    
                    Console.Write("Additional charge: ");
                    double charge = double.Parse(Console.ReadLine());

                    OutSourceEmployee outSourceEmployee = new OutSourceEmployee(name, hours, value, charge);
                    lista.Add(outSourceEmployee);

                }

                else if (yn == "N" || yn == "n")
                {
                    Employee employee = new Employee(name, hours, value);
                    lista.Add(employee);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee emp in lista)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment()}");
            }
        }
    }
}
