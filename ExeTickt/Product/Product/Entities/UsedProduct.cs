using System;
using System.Globalization;

namespace Product.Entities
{
    class UsedProduct : Products
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            ManufactureDate = date;
        }

        public override string PriceTag()
        {
            return Name + "(used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture Date: " + ManufactureDate.ToString("dd/MM/yyyy") +")" ;
        }
    }
}
