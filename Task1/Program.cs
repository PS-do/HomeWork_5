namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Обязательная задача*.\n" +
                " Сформировать одномерный массив из 7 элементов. Заполнить массив числами,\n" +
                " вводимыми с клавиатуры, определить среднее арифметическое элементов.");
            const int k = 7;
            int[] ar = new int[k];
            int s = 0;

            for (int i = 0; i < ar.Length; i++)
            {


                ar[i] = Convert.ToInt32(Console.ReadLine());
                s +=  ar[i];
            }
            Console.WriteLine("Среднее арифметическое:  {0:f3} ", (((double)s) / k));
        }
    }
}