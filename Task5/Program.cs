namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5. Обязательная задача*.\n" +
                " Запросить у пользователя целочисленное значение N.\n" +
                " Сформировать двумерный массив размера NxN следующего вида:" +
                "\n1 0 1 0 1\n" +
                "0 1 0 1 0\n" +
                "1 0 1 0 1\n" +
                "0 1 0 1 0\n" +
                "1 0 1 0 1\n\n" +
                "Введите размер N: ");
            int N=Convert.ToInt32(Console.ReadLine());
            int[,] ar=new int[N,N];
            Console.WriteLine("И вот что получаем:");
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i + j) % 2 == 0) ar[i,j] = 1;
                    else ar[i,j] = 0;
                    Console.Write(ar[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}