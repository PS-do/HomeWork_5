using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2. Сформировать одномерный массив из 15 элементов,\n" +
                " которые выбираются случайным образом из диапазона [0; 50].\n" +
                " Определить сумму максимального и минимального элементов массива.\n");
            Random random = new Random();
            const int k = 7;
            int[] ar = new int[k];
            int max, min;
            max=min=0;
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = random.Next(0,50);
                Console.WriteLine(ar[i]);
                if (ar[i]>max ) max = ar[i];
                else if (ar[i]<min) min = ar[i];
            }
            Console.WriteLine("Cумма максимального и минимального элементов массива равна: {0}", max+min);
        }
    }
}