using System;
using System.Threading.Channels;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            

            while (running)
            { 
                int c = 0;
                int s = 0;
                int h = 0;
                int overtime = 0;

                Console.WriteLine("Quantas horas você trabalha por semana?");
                h = int.Parse(Console.ReadLine());

                Console.WriteLine("E qual o seu código?");
                c = int.Parse(Console.ReadLine());

                if (h > 50)
                {
                    overtime = h - 50;
                    h = 50;
                }

                s = h * 10 + overtime * 20 * 4;

                Console.Write($"O usuário de código {c} trabalha por {h} horas por semana, ");
                if (overtime > 0)
                    Console.Write($"e {overtime} dessas horas são horas extras, valendo R$20,00 cada, enquanto as normais valem R$10,00, ");

                else
                    Console.Write("valendo R$10,00 cada, ");

                Console.WriteLine($"totalizando R${s},00 por mês.");

                Console.WriteLine("Quer encerrar o programa?");
                string close = Console.ReadLine();

                if (close == "S")
                    running = false;
            }

        }
    }
}