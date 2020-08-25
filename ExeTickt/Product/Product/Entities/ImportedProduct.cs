using System.Globalization;

namespace Product.Entities
{
    class ImportedProduct : Products
    {
        public double CustomsFree { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFree) : base(name, price)
        {
            CustomsFree = customsFree;
        }

        public double TotalPrice()
        {
            return Price + CustomsFree;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + "(Customs Free: $ " + CustomsFree.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        
    }
}
