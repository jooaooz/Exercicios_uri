using System;
using System.Globalization;

namespace uri_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            double c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            if (a < b + c && a > Math.Abs(b - c))
            { 
                double perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                double area = (a + b) / 2.0 * c;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
