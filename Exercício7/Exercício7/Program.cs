using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1;  i < 101; i++)
            {
                if (i % 10 == 0)
                    Console.Write("MÚLTIPLO DE 10: ");
                Console.WriteLine(i);

                Thread.Sleep(50);
            }
        }
    }
}