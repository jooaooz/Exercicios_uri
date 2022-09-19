using System;
using System.Globalization;

namespace URI_1008
{
    class Program
    {
        static void Main(string[] args)
        {

            int funcionarios = Convert.ToInt32(Console.ReadLine());
            int horas = Convert.ToInt32(Console.ReadLine());
            double valorhoras = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);



            double salario = (valorhoras * horas);



            Console.WriteLine($"NUMBER = {funcionarios}\nSALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");



            Console.ReadKey();


        }
    }
}
