using Contratos.Entities;
using Contratos.Entities.Enums;
using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Contratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string namedepart = Console.ReadLine();
            Console.WriteLine("Enter Worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior / Mid_level / Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(namedepart);
            Worker worker = new Worker(name, salary, level, department);

            Console.Write("how many contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Data (DD/M/YYYY)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(date, value, hours);
                worker.AddContract(hourContract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY)");
            string income = Console.ReadLine();
            double totalincome = worker.Income(int.Parse(income.Substring(0, 1)), int.Parse(income.Substring(3)));
            

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(worker);
            Console.WriteLine($"Income for {income}: " + totalincome);
        }
    }
}
