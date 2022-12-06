// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
  
  
  void IndexArr()
        {
            Console.WriteLine("Введите количество рядов");
            int rows = int.Parse(Console.ReadLine());
                
            Console.WriteLine("Введите количество столбцов");
            int coll = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минимальное число");
            double min = Math.Round(Double.Parse(Console.ReadLine()));
            Console.WriteLine("Введите максимальное число");
            double max = Math.Round(Double.Parse(Console.ReadLine()));
            Console.WriteLine("Введите координаты");
            int c = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
           
            double[,] array = new double[rows, coll];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = Math.Round(new Random()
                                                 .NextDouble() 
                                             * (max - min)
                                             - min);
            }

            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i,j] + "\t  ");
                Console.WriteLine();
            }
            if (c > coll && r > rows) Console.WriteLine($"В этом массиве значение {c} отсуствтует");
            else 
            {
                    object num = array.GetValue(c,r);
                    Console.WriteLine($"Значение которое находится в координатах {r} и {c} равно {num}"); 
            }
        }

IndexArr();