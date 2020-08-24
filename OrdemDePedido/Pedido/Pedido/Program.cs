using System;
using System.Globalization;
using Pedido.Entities;
using Pedido.Entities.Enums;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client
            Console.WriteLine("Enter client data:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth Data: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            //Order
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many itens to this order? ");
            int numorder = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, status, client);

            //Item
            for(int i = 1; i <= numorder; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nameprodu = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(nameprodu, price);

                Console.Write("Quantity: ");
                int qtdproduct = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(qtdproduct, price, product);

                order.Additem(orderItem);
            }

            Console.WriteLine(order);


        }
    }
}
