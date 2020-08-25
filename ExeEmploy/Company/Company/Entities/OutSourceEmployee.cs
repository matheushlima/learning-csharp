namespace Company.Entities
{
    class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourceEmployee()
        {

        }

        public OutSourceEmployee(string name, int hours, double valuePerHour, double addcharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = addcharge;
        }

        public override double Payment()
        {
            base.Payment();
            return base.Payment() + (AdditionalCharge + (AdditionalCharge*10/100));
        }
    }
}
