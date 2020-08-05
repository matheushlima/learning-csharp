using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, ultnome;
            int qtquartos, idade;
            double precoproduto, altura;

            string[] linha;

            Console.WriteLine("Entre com seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            qtquartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            precoproduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha): ");
            linha = Console.ReadLine().Split(' ');
            ultnome = linha[0];
            idade = int.Parse(linha[1]);
            altura = double.Parse(linha[2]);
            Console.WriteLine("");
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(qtquartos);
            Console.WriteLine(precoproduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultnome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));


        }
    }
}
