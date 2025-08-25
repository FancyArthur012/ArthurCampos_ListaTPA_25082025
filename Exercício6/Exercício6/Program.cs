using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int grade = 0;
            int totalGrades = 0;

            while (counter < 11)
            {
                Console.WriteLine($"Qual o valor da {counter}° nota?");
                grade = int.Parse(Console.ReadLine());
                if (grade > 0 || grade < 10)
                {
                    totalGrades = totalGrades + grade;
                    counter++;
                }

                else
                    Console.WriteLine("Valor inválido, tente novamente");
            }
            double avg = totalGrades / 10;
            Console.WriteLine($"A média das notas é igual a: {avg}");
        }
    }
}