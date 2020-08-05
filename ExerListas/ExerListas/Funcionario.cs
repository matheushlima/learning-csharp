using System;

namespace ExerListas
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public void AumentoSalario(double Porcentagem)
        {
            double porc;
            porc = Salario * Porcentagem / 100;

            Salario += porc;
        }
    }
}
