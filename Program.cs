using System;

namespace LB5_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод последовательности
            Console.WriteLine("Введите длину последовтаельности, n.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер изменяемого члена последовательности, k.");
            int k = Convert.ToInt32(Console.ReadLine());
            while (k > n)
            {
                Console.WriteLine("k должно быть меньше или равно n. Введите k ещё раз.");
                k = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите значение p, на которое будет изменяться член последовательности.");
            double p = Convert.ToDouble(Console.ReadLine());
            // сортировка и вывод последовательности
            double[] array = new double[n];
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }
            Array.Sort(array);
            Console.WriteLine("Изначальная последовательность:");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // вставляем p вместо a[k]
            array[k - 1] = p;

            // сортировка методом выбора по возрастанию с поиском минимума
            for (int i = 0; i < array.Length; i++)
            {
                double min = array[i];
                int minId = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        minId = j;
                    }
                }
                // замена
                double temp = array[i];
                array[i] = min;
                array[minId] = temp;
            }
            foreach (double i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}