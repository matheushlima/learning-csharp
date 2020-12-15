using System;
using System.Linq;
using AvgOrder.Entities;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace AvgOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] field = sr.ReadLine().Split(',');
                    string name = field[0];
                    double price = double.Parse(field[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.00).Average();

            Console.WriteLine("Average: " + avg);

            var nameDesc = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach(string name in nameDesc)
            {
                Console.WriteLine(name);
            }
        }
    }
}
