using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.236;
            string nome = "Maria";

            /*
            Console.Write("Ola Mundo");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            //F4 = núemro de casas decimais -- Culture = apresntar numero com ponto
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            */

            //Placeholters
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concatenação
            Console.WriteLine(nome + " tem " +idade+ " anos e tem saldo igual a " +saldo.ToString("F4")+ " reais ");
        }
    }
}
