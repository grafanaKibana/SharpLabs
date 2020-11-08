﻿using System;


namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            try
            {
                Console.Write("Введите стартовое значение для суммы ряда: ");
                input = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }

            int start = input * input;
            int finish = input * start;
            double result = 0;

            if (0 <= start || start <= finish)
            {
                for (int k = start; k < finish; k++)
                {
                    result += (Math.Pow(-1, k) * Math.Pow(k, 2) - 1) / (Math.Pow(k, 2) + 3);
                }
                Console.WriteLine($"Результат исчесления суммы ряда с стартовым числом {start} = {result}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wrong input");
                Console.ReadKey();
            }
        }
    }
}