using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());
            for(int i = 1; i <= a; i++)
            {
                int alunos = int.Parse(Console.ReadLine());
                set.Add(alunos);
            }

            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 1; i <= b; i++)
            {
                int alunos = int.Parse(Console.ReadLine());
                set.Add(alunos);
            }

            Console.Write("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());
            for (int i = 1; i <= c; i++)
            {
                int alunos = int.Parse(Console.ReadLine());
                set.Add(alunos);
            }

            Console.WriteLine("\nTotal Students: " + set.Count);
        }
    }
}
