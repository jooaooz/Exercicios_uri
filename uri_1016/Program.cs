using System;

namespace uri_1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, tempo;

            tempo = int.Parse(Console.ReadLine());
            distancia = tempo * 2;
            Console.WriteLine(distancia + "minutos");
        }
    }
}
