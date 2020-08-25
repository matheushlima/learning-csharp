using Product.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> lista = new List<Products>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, use or imported (c/u/i): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(type == 'i')
                {
                    Console.Write("Custom free: ");
                    double cfree = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ImportedProduct(name, price, cfree));
                } else if(type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    lista.Add(new UsedProduct(name, price, date));
                } else { lista.Add(new Products(name, price)); }
            }

            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS");
            foreach(Products prod in lista)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
