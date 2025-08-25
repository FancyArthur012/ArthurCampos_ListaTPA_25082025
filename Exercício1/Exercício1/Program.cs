using System;

namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 11; i < 251; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(5);
            }
        }
    }
}
