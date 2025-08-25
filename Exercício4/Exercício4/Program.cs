using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolhe um número");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolhe outro número");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
                
                Thread.Sleep(50);
            }
        }
    }
}