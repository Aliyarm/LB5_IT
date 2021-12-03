using System;

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
            double p = Convert.ToDouble(Console.ReadLine());

            double[] array = new double[n];
            Random rand = new();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }
 
            double temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Изначальная последовательность:");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            array[k - 1] = p;
            double x;
            int j;
            for (int i = 1; i < array.Length; i++)
            {
                x = array[i];
                j = i;
                while (j > 0 && array[j - 1] > x)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    j -= 1;
                }
                array[j] = x;
            }


            foreach (double i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}