using System;

namespace ExerFix02
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            porcentagem = (Salario * porcentagem) / 100;
            Salario += porcentagem;
        }
    }
}
