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