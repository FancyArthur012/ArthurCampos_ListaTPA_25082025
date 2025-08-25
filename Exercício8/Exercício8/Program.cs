using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um número: ");

            int n = int.Parse(Console.ReadLine());

            int total = 1;
            for (int e = 1; e <= n; e++)
            {
                total *= e;
            }

            Console.WriteLine($"{n}! é igual a: {total}");
        }
    }
}