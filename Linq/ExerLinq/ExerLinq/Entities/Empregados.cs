namespace ExerLinq.Entities
{
    class Empregados
    {
        public Empregados(string name, string email, double salario)
        {
            Name = name;
            Email = email;
            Salario = salario;
        }

        public string Name{ get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }
    }
}
