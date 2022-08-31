using System;
using System.Globalization;

namespace uri_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double peso1 = 2;
            double peso2 = 3;
            double peso3 = 5;
            double media = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
