using System;
using System.Globalization;

namespace ListaExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Exercicio01
            Console.WriteLine("Digite um número inteiro: ");

            int x = int.Parse(Console.ReadLine());

            if( x < 0)
            {
                Console.WriteLine("Negativo");
            } else if ( x > 0)
            {
                Console.WriteLine("Não Negativo");
            }
            else { Console.WriteLine("Não Negativo"); } */

            //------------------------------------------------------------//

            /*//Execicio02
            Console.WriteLine("Digite um número inteiro: ");

            int x = int.Parse(Console.ReadLine());

            if ( x % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else { Console.WriteLine("IMPAR"); }*/

            //------------------------------------------------------------//

            /*//Exercicio03
            Console.WriteLine("Digite dois numeros na mesma linha: \nEX:(1 2)\n");

            string[] num = Console.ReadLine().Split(" ");

            int x1, x2, result = 0;

            x1 = int.Parse(num[0]);

            x2 = int.Parse(num[1]);

            if(x1 > x2)
            {
                if (x1 % x2 == 0)
                {
                    Console.WriteLine("Multiplos");
                }
                else { Console.WriteLine("Não são multiplos"); }
            } 
                else if(x1 < x2)
                {
                    if (x2 % x1 == 0)
                    {
                        Console.WriteLine("Multiplos");
                    }
                    else { Console.WriteLine("Não são multiplos"); } 
                }*/


            //------------------------------------------------------------//

            /* //Exercicio04
            string[] hora;

            int horaini, horafin, duracao;

            Console.WriteLine("Digite a hora inicial e final na mesma linha \n");
            hora = Console.ReadLine().Split(' ');

            horaini = int.Parse(hora[0]);
            horafin = int.Parse(hora[1]);

            if (horaini < horafin)
            {
                duracao = horafin - horaini;
            } 
            else {
                duracao = 24 - horaini + horafin;
            }

            Console.WriteLine($"O jogo durou {duracao} hora(s)"); */


            //------------------------------------------------------------//

            //Exercico05

            /*string[] linha;
            int cod, qtd;
            double pagar = 0;

            Console.WriteLine("Digite o codigo do produto e qauntidade: ");

            linha = Console.ReadLine().Split(' ');

            cod = int.Parse(linha[0]);
            qtd = int.Parse(linha[1]);

            if (cod == 1) {
                pagar = qtd * 4.00;
            } else if (cod == 2) {
                pagar = qtd * 4.50;
            } else if (cod == 3) {
                pagar = qtd * 5.00;
            } else if (cod == 4) {
                pagar = qtd * 2.00;
            } else if (cod == 5) {
                pagar = qtd * 1.50;
            }
            else { Console.WriteLine("Código invalido"); }

            Console.WriteLine("Total: R$" + pagar.ToString("F2", CultureInfo.InvariantCulture));*/


            //------------------------------------------------------------//


            /*//Exercicio06
            Console.WriteLine("Entre com um número: \n");

            double num = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (num <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (num > 25.00 && num <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (num > 50.00 && num <= 70.00)
            {
                Console.WriteLine("Intervalo (50,75)");
            }
            else if (num > 75.00 && num <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else { Console.WriteLine("Fora de intervalo"); } */


            //------------------------------------------------------------//


            //Exercicio07

            /*string[] ponto;

            double x, y;

            Console.WriteLine("Digite as coordenadas: \n");

            ponto = Console.ReadLine().Split(' ');

            x = double.Parse(ponto[0], CultureInfo.InvariantCulture);

            y = double.Parse(ponto[1], CultureInfo.InvariantCulture);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else { Console.WriteLine("Origem"); } */


            //------------------------------------------------------------//

            //Exercicio 8

            Console.WriteLine("Digite seu salario: \n");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(salario >= 0.00 && salario <= 2000.00) {
                Console.WriteLine("Isento");
            } else if (salario <= 3000.00) {
                double juros = (1000.00 * 8) / 100;
                Console.WriteLine($"R$ {juros.ToString("F2", CultureInfo.InvariantCulture)}");
            } else if (salario <= 4000.00) {
                double juros = (1000.00 * 8) / 100;
                juros = juros + (((salario - 3000.00) * 18) / 100);
                Console.WriteLine($"R$ {juros.ToString("F2", CultureInfo.InvariantCulture)}");
            } else {
                double juros = (1000.00 * 8) / 100;
                juros = juros + (1500.00 * 18) / 100;
                juros = juros + (((salario - 4500.00) * 28) / 100);
                Console.WriteLine($"R$ {juros.ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}
