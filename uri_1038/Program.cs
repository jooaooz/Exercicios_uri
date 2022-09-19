using System;
using System.Globalization;

namespace uri_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            string item = vet[0];
            int quantidade = int.Parse(vet[1]);

            if (item == "1")
            {
                Console.WriteLine("total: R$ " + (quantidade + 4.00).ToString
                    ("F2", CultureInfo.InvariantCulture));
            }
            else (item == "2")
            {
                Console.WriteLine("total: R$ " + (quantidade + 4.00).ToString
                    ("F2", CultureInfo.InvariantCulture));
            }

            else (item == "3")
            {
                Console.WriteLine("total: R$ " + (quantidade + 4.50).ToString
                    ("F2", CultureInfo.InvariantCulture));

            }

            else (item == "4")
            {
                Console.WriteLine("total: R$ " + (quantidade + 5.00).ToString
                    ("F2", CultureInfo.InvariantCulture));

            }
             else (item == "5")
        }
    }
}
