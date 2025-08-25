using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o primeiro número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i >= b; i--)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
                Thread.Sleep(50);
            }
        }
    }
}