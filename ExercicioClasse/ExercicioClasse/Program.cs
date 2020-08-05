using System;
using System.Globalization;

namespace ExercicioClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01

            /*Class1 nome1 = new Class1();
            Class1 idade1 = new Class1();
            Class1 nome2 = new Class1();
            Class1 idade2 = new Class1();
            string velha;

           
            Console.WriteLine("Digite seu nome e sua idade: ");
            nome1.nome = Console.ReadLine();
            idade1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite seu nome e sua idade:");
            nome2.nome = Console.ReadLine();
            idade2.idade = int.Parse(Console.ReadLine());

            if(idade1.idade < idade2.idade)
            {
                velha = nome2.nome;
            } else { velha = nome1.nome; }

            Console.WriteLine($"\n\nDados da primeira pessoa: \nNome: {nome1.nome}\nIdade: {idade1.idade}");
            Console.WriteLine($"Dados da segunda pessoa: \nNome: {nome2.nome}\nIdade: {idade2.idade}");
            Console.WriteLine("Pessoa mais velha: " + velha); */


            //Exercicio02

            Funcionario nome1 = new Funcionario();
            Funcionario salario1 = new Funcionario();
            Funcionario nome2 = new Funcionario();
            Funcionario salario2 = new Funcionario();
            double media;

            Console.WriteLine("Digite seu nome e seu salrio: ");
            nome1.nome = Console.ReadLine();
            salario1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("\nDigite seu nome e seu salrio: ");
            nome2.nome = Console.ReadLine();
            salario2.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = (salario1.salario + salario2.salario) / 2;

            Console.WriteLine($"\n\nDados do primeiro funcionario: \nNome: {nome1.nome}\nSalario: {salario1.salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Dados do segundo funcionario: \nNome: {nome2.nome}\nSalario: {salario2.salario.ToString("F2", CultureInfo.InvariantCulture)}\nSalário Médio: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
