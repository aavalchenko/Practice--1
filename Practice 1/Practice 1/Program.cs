using System;
using System.Collections.Generic;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество стопок: ");
            int count = int.Parse(Console.ReadLine());
            List<double> coins = new List<double>(count);
            Console.WriteLine("Введите количество монет в каждой стопке:\n");

            for (int i = 0; i < count; i++)
                coins.Add(int.Parse(Console.ReadLine()));

            Console.Write("\nВведите сколько стопок может взять первый игрок в начале игры: ");
            int firstStep = int.Parse(Console.ReadLine());

            Console.WriteLine(GetAnswer(count, firstStep, coins));
            Console.ReadKey();
        }

        static double GetAnswer(int count, int firstStep, List<double> coins)
        {
            double answer = 0;
            List<double> answers = new List<double>();
            double[] mas = new double[1];

            for (int step = 0; step <= count; step++)
            {
                for (int j = firstStep; j > -1; j--)
                {
                    for (int i = 0; i < count; i += j)
                    {

                    }
                }
            }

            return answer;
        }
    }
}
