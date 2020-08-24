using System;
using System.Collections.Generic;
using System.Text;
using Pedido.Entities.Enums;

namespace Pedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens = new List<OrderItem>();
        public Client Client;

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void Additem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void Removeitem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;
            foreach(OrderItem item in Itens)
            {
                total += item.Subtotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("ORDER SUMMARY");
            text.Append("Order moment: ");
            text.AppendLine(Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            text.Append("Order Status: ");
            text.AppendLine(Status.ToString());
            text.AppendLine("Client: " + Client);
            text.AppendLine("Order itens: ");
            foreach (OrderItem item in Itens)
            {
                text.AppendLine(item.Products.Name + ", $" + item.Price + ", Quantity: " + item.Quantity + ", Subtotal: " + item.Subtotal());
            }
            text.AppendLine("Total Price: $" + Total());

            return text.ToString();
        }
    }
}
