using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace ListaExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Exercicio01
            int a, b, soma;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("Soma = " + soma); */

            //----------------------------------------------------------//

            //Exercico02
            double raio, area;
            double pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));


            //----------------------------------------------------------//

            /*//Exercicio03
            int a, b, c, d, dif;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            dif = (a * b) - (c * d);

            Console.WriteLine(dif); */

            //----------------------------------------------------------//

            /*//Exercicio04
            int numfunc, hrtrab;
            double valorhr, salario;

            numfunc = int.Parse(Console.ReadLine());
            hrtrab = int.Parse(Console.ReadLine());
            valorhr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = hrtrab * valorhr;

            Console.WriteLine("NUMBER = " + numfunc);
            Console.WriteLine("SALARY = U$ "+ salario.ToString("F2", CultureInfo.InvariantCulture)); */

            //----------------------------------------------------------//

            /*//Exercico05
            string[] peca1;
            string[] peca2;

            int codpeca1, codpeca2, numpec1, numpec2;
            double valorpeca1, valorpeca2, total;

            peca1 = Console.ReadLine().Split(' ');
            peca2 = Console.ReadLine().Split(' ');

            codpeca1 = int.Parse(peca1[0]);
            numpec1 = int.Parse(peca1[1]);
            valorpeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            codpeca2 = int.Parse(peca2[0]);
            numpec2 = int.Parse(peca2[1]);
            valorpeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            total = (numpec1 * valorpeca1) + (numpec2 * valorpeca2);

            Console.WriteLine("Valor a pagar: R$ " + total.ToString("F2",CultureInfo.InvariantCulture)); */

            //----------------------------------------------------------//

            /*//Exercicio06
            float a, b, c, areat, areac, areatra, areaq, arear;
            float pi = 3.14159f;

            string[] linha;
            
            linha = Console.ReadLine().Split(' ');

            a = float.Parse(linha[0], CultureInfo.InvariantCulture);
            b = float.Parse(linha[1], CultureInfo.InvariantCulture);
            c = float.Parse(linha[2], CultureInfo.InvariantCulture);

            areat = (a * c) / 2;
            areac = (float)(pi * Math.Pow(c, 2));
            areatra = ((a + b) / 2) * c;
            areaq = b * b;
            arear = (a * b);

            Console.WriteLine("TRIANGULO: "+ areat.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areac.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: "+ areatra.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: "+ areaq.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: "+ arear.ToString("F3",CultureInfo.InvariantCulture));*/
        }
    }
}
 