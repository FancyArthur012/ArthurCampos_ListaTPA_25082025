using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int positive = 0;
            int negative = 0;
            int even = 0;
            int uneven = 0;
            int counter = 1;

            while (running)
            {
                Console.WriteLine("Escolha um número inteiro: ");
                int n = int.Parse(Console.ReadLine());

                if (n > 0)
                    positive++;

                else
                    negative++;

                if (n % 2 == 0)
                    even++;

                else
                    uneven++;

                if (counter % 5 == 0)
                {
                    Console.WriteLine("Continuar? (S/N)");
                    string end = Console.ReadLine();

                    if (end == "N")
                        running = false;

                    else 
                        running = true;
                }

                counter++;
            }

            Console.WriteLine($"Durante o programa, o usuário escolheu {positive} números positivos, {negative} números negativos, {even} números pares e {uneven} números ímpares.");
        }
    }
}