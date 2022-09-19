using System;
using System.Globalization;

namespace uri_1010
{
    class Program
    {
        static void Main(string[] args)
        {
         string prod1 = Console.ReadLine();
         string[] vetorprod1 = prod1.Split(" ");
         string prod2 = Console.ReadLine();
         string[] vetorprod2 = prod2.Split(" ");

         int numeropecal1 = int.Parse(vetorprod1[1]);
         float valorpeca1 = float.Parse(vetorprod1[2], CultureInfo.InvariantCulture);

         int numeropeca2 = int.Parse(vetorprod2[1]);
         float valorpeca2 = float.Parse(vetorprod2[2], CultureInfo.InvariantCulture);

            float total = (valorpeca1 * numeropecal1) + (valorpeca2 * numeropeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}
