// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
internal class Program
{
    private static void Main(string[] args)
    {
        double[,] Random2DArray(int collumns, int rows)
        {
            Console.WriteLine("Введите минимальное число: ");
            double min = Math.Round(double.Parse(Console.ReadLine()));
            Console.WriteLine("Введите максимальное число: ");
            double max = Math.Round(double.Parse(Console.ReadLine()));
            double[,] arr = new double[rows, collumns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < collumns; j++)
                {
                    arr[i, j] = Math.Round(new
                        Random().NextDouble() * (-max - min) + min);

                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }
            return arr;
        }

        Random2DArray(3, 4);
    }
}