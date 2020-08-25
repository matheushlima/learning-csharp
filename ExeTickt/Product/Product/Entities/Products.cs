using System.Globalization;

namespace Product.Entities
{
    class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products()
        {

        }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}