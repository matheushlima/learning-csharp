using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerListas
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            List <Funcionario> listafunc = new List<Funcionario>();

            Console.WriteLine("Entre com o número de funcionarios: ");
            int func = int.Parse(Console.ReadLine());

            for(int i = 0; i <= func; i++)
            {
                Console.WriteLine("\nFuncionario #" + i);
                Console.Write("Digite o ID: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listafunc.Add(new Funcionario { Id = id, Nome = nome, Salario = salario });
            }

            Console.Write("\nDigitir o ID do funcionario que recebera aumento: ");
            id = int.Parse(Console.ReadLine());

            Funcionario aumento = listafunc.Find(x => x.Id == id);
            if(aumento != null)
            {
                Console.Write("Digite a porcentagem de aumento do salario: ");
                double porc = double.Parse(Console.ReadLine());

                aumento.AumentoSalario(porc);
            }
            else { Console.WriteLine("Funcionario não existe!"); }


            Console.WriteLine("\nLista de Funcionarios:");
            foreach(Funcionario obj in listafunc)
            {
                Console.WriteLine(obj.Id + ", " + obj.Nome + ", " + obj.Salario.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
