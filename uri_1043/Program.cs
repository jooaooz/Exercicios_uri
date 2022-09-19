using System;

namespace uri_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');



            int numOne = int.Parse(numeros[0]);
            int numTwo = int.Parse(numeros[1]);
            int numThree = int.Parse(numeros[2]);



            int menor = 0;
            int maior = 0;
            int medio = 0;



            if (numOne < numTwo && numOne < numThree && numTwo < numThree)
            {
                menor = numOne;
                medio = numTwo;
                maior = numThree;
            }
            else if (numOne < numTwo && numOne < numThree && numTwo > numThree)
            {
                menor = numOne;
                medio = numTwo;
                maior = numThree;
            }
            else if (numOne > numTwo && numOne < numThree && numTwo < numThree)
            {
                menor = numTwo;
                medio = numOne;
                maior = numThree;
            }
            else if (numOne > numTwo && numOne > numThree && numTwo < numThree)
            {
                menor = numTwo;
                medio = numOne;
                maior = numThree;
            }
            else if (numOne > numTwo && numOne > numThree && numTwo > numThree)
            {
                menor = numTwo;
                medio = numOne;
                maior = numThree;
            }
            else
            {
                menor = numThree;
                medio = numOne;
                maior = numTwo;
            }
            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(maior);
            Console.WriteLine("");
            Console.WriteLine(numOne);
            Console.WriteLine(numTwo);
            Console.WriteLine(numThree);

        }
    }
}
