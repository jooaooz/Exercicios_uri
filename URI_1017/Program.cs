using System;
using System.Globalization;

namespace URI_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int autonomia = 12;
            float horaspercoridas, velocidademedia, gastocombustivel;

            horaspercoridas = float.Parse(Console.ReadLine());
            velocidademedia = float.Parse(Console.ReadLine());

            gastocombustivel = (velocidademedia / autonomia) *horaspercoridas;

            Console.WriteLine(gastocombustivel.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
