using System;
using System.Collections.Generic;

namespace LB5_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовтаельности.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер изменяемого члена последовательности.");
            int k = Convert.ToInt32(Console.ReadLine());
            while (k > n)
            {
                Console.WriteLine("k должно быть меньше или равно n. Введите k ещё раз.");
                k = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите значение, на которое будет изменяться член последовательности.");
            decimal p = Convert.ToDecimal(Console.ReadLine());

            decimal[] array = new decimal[n];
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }

            List<decimal> newArray = new();
            newArray.AddRange(array);
            newArray.Sort();

            Console.WriteLine("Изначальная последовательность:");
            foreach (int i in newArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Изменённая последовательность:");
            newArray.Insert(k - 1, p);
            newArray.RemoveAt(k);
            newArray.Sort();
            foreach (int i in newArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}