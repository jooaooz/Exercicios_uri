using System;
using System.Globalization;

namespace uri_1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            string[] numeros = Console.ReadLine().Split(' ');

            x = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            y = double.Parse(numeros[1], CultureInfo.InvariantCulture);

            if ( x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo y");
            }
            else if  (y == 0.0)
            {
                Console.WriteLine("Eixo x");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");

            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");

            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");

            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
