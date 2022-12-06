internal class Program
{
    private static void Main(string[] args)
    {
        void FindAvg()
        {

            double[,] array = new double[5, 5];
            double[] num = new double[5];
            double sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i * j + 1;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 1, k = 0; i < array.GetLength(0); i += 2)
            {
                for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
                num[k] = sum / 5;
                Console.WriteLine($"Среднее арифметическое столбца " + (i + 1) + " равно: " + num[k]);

            }
        }
        FindAvg();
    }
}