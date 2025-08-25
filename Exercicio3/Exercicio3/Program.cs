using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolhe um número aí");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int b = a * i;
                Console.WriteLine(b);
                Thread.Sleep(50);
            }
        }
    }
}