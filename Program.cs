using System;
using System.Linq;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размер массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];

            if (n == 0)
            {
                Console.WriteLine("Ошибка! Введите элементы массива!");
                Environment.Exit(0);
            }
            
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            int min = num.Min();
            int max = num.Max();
            Console.WriteLine("Минимальный элемент в массиве: " + min + "\nМаксимальный элемент в массиве: " + max);

            Console.Write("Числа которые не входят в данный массив:");
            for (int i = min; i < max; i++)
            {
                if (Array.IndexOf(num, i) < 0)
                    Console.Write(" " + i);
            }
        }
    }
}
