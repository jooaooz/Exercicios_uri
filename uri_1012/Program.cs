using System;
using System.Globalization;

namespace uri_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;



            double tringulo = (A * C) / 2;
            double circulo = pi * (C * C);
            double trapezio = ((A + B) * C) / 2;
            double quadrado = B * B;
            double retangulo = A * B;



            Console.WriteLine("TRIANGULO: " + tringulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
