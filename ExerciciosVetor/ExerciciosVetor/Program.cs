using System;

namespace ExerciciosVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int estudantes, quarto;
            string nome, email;
            Inquilino[] vetor = new Inquilino[10];

            estudantes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= estudantes; i++)
            {
                Console.WriteLine("Inquilino #" + i);
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("E-mail: ");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Inquilino { Nome = nome, Email = email, Quarto = quarto };
            }

            Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine($"{vetor[i].Quarto}: {vetor[i].Nome}, {vetor[i].Email}");
                }
            }
        }
    }
}
