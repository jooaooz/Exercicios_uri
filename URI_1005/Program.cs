using System;
using System.Globalization;
namespace URI_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double peso1 = 3.5;
            double peso2 = 7.5;
            double media = ((nota1  * peso1) + (nota2 * peso2)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5" ,CultureInfo.InvariantCulture));
        }
    }
}
