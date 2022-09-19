using System;
using System.Globalization;

namespace uri_1009
{
    class Program
    {
        static void Main(string[] args)
        {
         string nome = Console.ReadLine();
         double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         double total = (vendas * 0.15) + salario;
         Console.WriteLine("TOTAL = R$ " + total.ToString("F2" , CultureInfo.InvariantCulture));

        }
    }
}
