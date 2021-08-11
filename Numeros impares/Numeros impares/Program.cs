using System;
using System.Globalization;

namespace Numeros_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) // x recebeu o valor 8, dividido por 2 que é igual 0
            {
                x = x + 1; // 8 = 8 + 1
            }
            
            Console.WriteLine(x); // Console leu 9 que é o novo valor do X, antes era 8
            Console.WriteLine(x + 2); // Console leu 9 + 2
            Console.WriteLine(x + 4); // Console leu 9 + 4
            Console.WriteLine(x + 6); // Console leu 9 + 6
            Console.WriteLine(x + 8); // Console leu 9 + 8
            Console.WriteLine(x + 10); // Console leu 9 + 10

           
        }

    }
}
