using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            int counter = 0;

            while (counter < 15)
            { 
                Console.WriteLine("Escolhe um número: ");
                int n = int.Parse(Console.ReadLine());
                if (n > f)
                    f = n;

                counter++;
            }

            Console.WriteLine($"O maior número foi: {f}");
        }
    }
}