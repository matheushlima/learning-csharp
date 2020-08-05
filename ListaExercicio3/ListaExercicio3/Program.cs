using System;

namespace ListaExercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Exercicio 1

            Console.WriteLine("Digite uma senha: ");
            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha Invalida\n");
                Console.WriteLine("Digite novamente: ");
                int senhanova = int.Parse(Console.ReadLine());
                senha = senhanova;
            }

            Console.WriteLine("Acesso Permitido"); */


            /*//Exercicio 02

            Console.WriteLine("Digite as cordenadas: ");
            string[] xy = Console.ReadLine().Split(' ');
            int x = int.Parse(xy[0]);
            int y = int.Parse(xy[1]);

            while (x != 0 && y != 0)
            {
                string resultado = quadrante(x, y);
                Console.WriteLine(resultado);

                Console.WriteLine("\nDigite outras cordenadas: ");
                string[] xy2 = Console.ReadLine().Split(' ');
                int x2 = int.Parse(xy2[0]);
                int y2 = int.Parse(xy2[1]);
                x = x2;
                y = y2;

            }

            Console.WriteLine("");

            static string quadrante(int x1, int y1)
            {
                string resultado;
                if (x1 > 0 && y1 > 0)
                {
                    resultado = "primeiro";
                }
                else if (x1 > 0 && y1 < 0)
                {
                    resultado = "quarto";
                }
                else if (x1 < 0 && y1 > 0)
                {
                    resultado = "segundo";
                }
                else { resultado = "terceiro"; }

                return resultado;
            }*/



            //Exercicio03

            Console.WriteLine("Digite seu combustivel preferido: ");
            int num = int.Parse(Console.ReadLine());
            int gasolina = 0, alcool = 0, diesel = 0;

            while(num != 4)
            {
                if(num == 1)
                {
                    alcool += 1;
                } else if(num == 2)
                {
                    gasolina += 1;
                } else if(num == 3)
                {
                    diesel += 1;
                }

                Console.WriteLine("Digite seu combustivel preferido: ");
                int num2 = int.Parse(Console.ReadLine());
                num = num2;
            }

            Console.WriteLine($"MUITO OBRIGADO\nAlcool: {alcool}\nGasoline: {gasolina}\nDiesel: {diesel}\n");
        }
    }
}
