using System;

namespace FormulaBaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0, b = -3.0, c = -4.0;

            //Math.Pow = Calcula o numero elevado a potencia
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            //Math.Sqrt = calcula a raiz
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine("X1:" + x1);
            Console.WriteLine("X2:" + x2);
        }
    }
}
