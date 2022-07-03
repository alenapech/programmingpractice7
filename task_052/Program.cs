// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Задача 052");
Random rand = new Random();
int[,] array = new int[3,6];

FillArray(array);
PrintArray(array);

        for (int j = 0; j < array.GetLength(1); j++)
            {
                int sum = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    sum += array[i,j];
                }
                sum = sum/array.GetLength(0);
        Console.WriteLine($"Для {j+1} -ого столбца среднеарифметическое равно: {sum}");
        Console.WriteLine();

        }

void FillArray(int[,] currentArray)
    {
        for (int i = 0; i < currentArray.GetLength(0); i++)
            {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
            currentArray[i,j] = rand.Next(-5,5);
            }
        
        }
    }

void PrintArray(int[,] currentArray)
    {
        Console.WriteLine();
        for (int i = 0; i < currentArray.GetLength(0); i++)
            {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
            Console.Write(currentArray[i,j] +  "\t");
            }
             Console.WriteLine();
            }
    }